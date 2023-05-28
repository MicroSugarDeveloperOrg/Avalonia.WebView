using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoreFoundation;
using CoreServices;

namespace CFNetwork;

internal class WebResponseStream : Stream, IDisposable
{
	private interface IOperation : IDisposable
	{
		bool IsCompleted { get; }

		void SetCompleted();

		void SetCanceled();

		void SetException(Exception error);

		byte[] GetBuffer(out int index, out int count);

		Task<bool> Write(int count);
	}

	private abstract class Operation<T> : IOperation, IDisposable
	{
		private CancellationTokenSource cts;

		private TaskCompletionSource<T> tcs;

		private bool completed;

		public Task<T> Task => tcs.Task;

		public bool IsCompleted => completed;

		protected TaskCompletionSource<T> TaskCompletionSource => tcs;

		protected CancellationToken CancellationToken => cts.Token;

		protected Operation(WebResponseStream parent, CancellationToken cancellationToken)
		{
			cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
			cts.Token.Register(delegate
			{
				parent.OnCanceled();
			});
			tcs = new TaskCompletionSource<T>();
		}

		public void SetCanceled()
		{
			if (!completed)
			{
				completed = true;
				tcs.SetCanceled();
			}
		}

		public void SetException(Exception error)
		{
			if (!completed)
			{
				completed = true;
				tcs.SetException(error);
			}
		}

		public void SetCompleted()
		{
			if (!completed)
			{
				completed = true;
				OnCompleted();
			}
		}

		protected abstract void OnCompleted();

		public abstract byte[] GetBuffer(out int index, out int count);

		public abstract Task<bool> Write(int count);

		~Operation()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				SetCanceled();
				if (cts != null)
				{
					cts.Dispose();
					cts = null;
				}
			}
		}
	}

	private class CopyToAsyncOperation : Operation<object>
	{
		private Stream destination;

		private byte[] buffer;

		public CopyToAsyncOperation(WebResponseStream parent, Stream destination, int bufferSize, CancellationToken cancellationToken)
			: base(parent, cancellationToken)
		{
			this.destination = destination;
			buffer = new byte[bufferSize];
		}

		public override byte[] GetBuffer(out int index, out int count)
		{
			index = 0;
			count = buffer.Length;
			return buffer;
		}

		public override async Task<bool> Write(int count)
		{
			await destination.WriteAsync(buffer, 0, count, base.CancellationToken);
			return true;
		}

		protected override void OnCompleted()
		{
			base.TaskCompletionSource.SetResult(null);
		}
	}

	private class ReadAsyncOperation : Operation<int>
	{
		private byte[] buffer;

		private int bufferIndex;

		private int bufferCount;

		private int successfullyWritten;

		public ReadAsyncOperation(WebResponseStream parent, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			: base(parent, cancellationToken)
		{
			this.buffer = buffer;
			bufferIndex = offset;
			bufferCount = count;
		}

		public override byte[] GetBuffer(out int index, out int count)
		{
			index = bufferIndex;
			count = bufferCount;
			return buffer;
		}

		public override Task<bool> Write(int count)
		{
			bufferIndex += count;
			successfullyWritten += count;
			bool result = bufferIndex < bufferCount;
			return System.Threading.Tasks.Task.FromResult(result);
		}

		protected override void OnCompleted()
		{
			base.TaskCompletionSource.SetResult(successfullyWritten);
		}
	}

	private CFHTTPStream stream;

	private WorkerThread worker;

	private WebRequestStream body;

	private CancellationTokenSource openCts;

	private TaskCompletionSource<CFHTTPMessage> openTcs;

	private IOperation currentOperation;

	private bool bytesAvailable;

	private bool busy;

	private Thread mainThread;

	private Thread workerThread;

	private volatile bool crossThreadAccess;

	private object syncRoot;

	private bool open;

	private bool canceled;

	private bool completed;

	private Exception lastError;

	public CFHTTPStream Stream => stream;

	public override bool CanRead => true;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	private WebResponseStream(CFHTTPStream stream, WebRequestStream body)
	{
		this.stream = stream;
		this.body = body;
		syncRoot = new object();
	}

	public static WebResponseStream Create(CFHTTPMessage request)
	{
		CFHTTPStream cFHTTPStream = CFStream.CreateForHTTPRequest(request);
		if (cFHTTPStream == null)
		{
			return null;
		}
		return new WebResponseStream(cFHTTPStream, null);
	}

	public static WebResponseStream Create(CFHTTPMessage request, WebRequestStream body)
	{
		CFHTTPStream cFHTTPStream = CFStream.CreateForStreamedHTTPRequest(request, body.ReadStream);
		if (cFHTTPStream == null)
		{
			return null;
		}
		return new WebResponseStream(cFHTTPStream, body);
	}

	public static WebResponseStream Create(Uri uri, HttpMethod method, Version version)
	{
		using CFHTTPMessage request = CFHTTPMessage.CreateRequest(uri, method.Method, version);
		return Create(request);
	}

	~WebResponseStream()
	{
		Dispose(disposing: false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			OnCanceled();
			if (stream != null)
			{
				stream.Dispose();
				stream = null;
			}
			if (openCts != null)
			{
				openCts.Dispose();
				openCts = null;
			}
		}
		base.Dispose(disposing);
	}

	private void OnError(Exception error)
	{
		if (error == null)
		{
			error = new InvalidOperationException("Unknown error.");
		}
		if (!completed)
		{
			lastError = error;
			completed = true;
			stream.Close();
			if (!open)
			{
				openTcs.SetException(error);
			}
			Interlocked.Exchange(ref currentOperation, null)?.SetException(error);
		}
	}

	private void OnCanceled()
	{
		if (!completed)
		{
			completed = (canceled = true);
			stream.Close();
			if (!open)
			{
				openTcs.SetCanceled();
			}
			Interlocked.Exchange(ref currentOperation, null)?.SetCanceled();
		}
	}

	private void OnCompleted()
	{
		if (!completed)
		{
			completed = true;
			stream.Close();
			if (!open)
			{
				openTcs.SetException(new InvalidOperationException());
			}
			else
			{
				Interlocked.Exchange(ref currentOperation, null)?.SetCompleted();
			}
		}
	}

	private void StartOperation(IOperation operation)
	{
		bool flag;
		lock (syncRoot)
		{
			if (!open || currentOperation != null)
			{
				throw new InvalidOperationException();
			}
			if (canceled)
			{
				operation.SetCanceled();
				return;
			}
			if (lastError != null)
			{
				operation.SetException(lastError);
				return;
			}
			if (completed)
			{
				operation.SetCompleted();
				return;
			}
			currentOperation = operation;
			flag = CheckCrossThreadAccess();
			if (!bytesAvailable)
			{
				return;
			}
		}
		if (worker != null && !Thread.CurrentThread.Equals(workerThread))
		{
			worker.Post(delegate
			{
				if (bytesAvailable)
				{
					OnBytesAvailable(exitContext: false);
				}
			});
		}
		else if (!flag)
		{
			OnBytesAvailable(exitContext: false);
		}
		else
		{
			Monitor.Enter(syncRoot);
			if (!bytesAvailable)
			{
				Monitor.Exit(syncRoot);
			}
			else
			{
				OnBytesAvailable(exitContext: true);
			}
		}
	}

	private bool CheckCrossThreadAccess()
	{
		if (crossThreadAccess)
		{
			return true;
		}
		if (Thread.CurrentThread.Equals(mainThread))
		{
			return false;
		}
		if (Thread.CurrentThread.Equals(workerThread))
		{
			return false;
		}
		crossThreadAccess = true;
		return true;
	}

	private void HasBytesAvailable()
	{
		if (!crossThreadAccess)
		{
			if (currentOperation == null || busy)
			{
				bytesAvailable = true;
				return;
			}
			if (!crossThreadAccess)
			{
				OnBytesAvailable(exitContext: false);
				return;
			}
		}
		Monitor.Enter(syncRoot);
		if (currentOperation == null || busy)
		{
			bytesAvailable = true;
			Monitor.Exit(syncRoot);
		}
		else
		{
			OnBytesAvailable(exitContext: true);
		}
	}

	private async Task OnBytesAvailable(bool exitContext)
	{
		bool keepGoing;
		do
		{
			bytesAvailable = false;
			try
			{
				keepGoing = await ReadFromServer(exitContext);
			}
			catch (Exception ex2)
			{
				Exception ex = ex2;
				OnError(ex);
				break;
			}
		}
		while (bytesAvailable && keepGoing);
		if (exitContext)
		{
			Monitor.Exit(syncRoot);
		}
	}

	private async Task<bool> ReadFromServer(bool exitContext)
	{
		int index;
		int count;
		byte[] buffer = currentOperation.GetBuffer(out index, out count);
		nint ret;
		try
		{
			ret = stream.Read(buffer, index, count);
		}
		catch (Exception ex2)
		{
			Exception ex = ex2;
			OnError(ex);
			return false;
		}
		if (ret < 0)
		{
			OnError(stream.GetError());
			return false;
		}
		if (ret == 0)
		{
			OnCompleted();
			return false;
		}
		busy = true;
		if (exitContext)
		{
			Monitor.Exit(syncRoot);
		}
		bool keepGoing;
		try
		{
			keepGoing = await currentOperation.Write((int)ret);
		}
		finally
		{
			if (exitContext)
			{
				Monitor.Enter(syncRoot);
			}
			busy = false;
		}
		if (keepGoing)
		{
			return true;
		}
		IOperation operation = Interlocked.Exchange(ref currentOperation, null);
		operation.SetCompleted();
		return false;
	}

	public async Task<CFHTTPMessage> Open(WorkerThread worker, CancellationToken cancellationToken)
	{
		this.worker = worker;
		openTcs = new TaskCompletionSource<CFHTTPMessage>();
		openCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
		openCts.Token.Register(delegate
		{
			OnCanceled();
		});
		mainThread = Thread.CurrentThread;
		try
		{
			if (worker != null)
			{
				await worker.Post(delegate
				{
					DoOpen();
				}, openCts.Token);
			}
			else
			{
				DoOpen();
			}
			return await openTcs.Task;
		}
		finally
		{
			openCts.Dispose();
			openCts = null;
		}
	}

	private void DoOpen()
	{
		if (lastError != null)
		{
			openTcs.SetException(lastError);
			return;
		}
		stream.ErrorEvent += delegate
		{
			OnError(stream.GetError());
		};
		stream.ClosedEvent += delegate
		{
			if (!open)
			{
				open = true;
				openTcs.SetResult(stream.GetResponseHeader());
			}
			OnCompleted();
		};
		stream.HasBytesAvailableEvent += delegate
		{
			if (!open)
			{
				open = true;
				openTcs.SetResult(stream.GetResponseHeader());
			}
			HasBytesAvailable();
		};
		stream.OpenCompletedEvent += delegate
		{
			if (body != null)
			{
				body.Open();
			}
		};
		workerThread = Thread.CurrentThread;
		stream.EnableEvents(CFRunLoop.Current, CFRunLoop.ModeDefault);
		stream.Open();
	}

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		CopyToAsyncOperation copyToAsyncOperation = new CopyToAsyncOperation(this, destination, bufferSize, cancellationToken);
		StartOperation(copyToAsyncOperation);
		return copyToAsyncOperation.Task;
	}

	public override void Flush()
	{
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		ReadAsyncOperation readAsyncOperation = new ReadAsyncOperation(this, buffer, offset, count, cancellationToken);
		StartOperation(readAsyncOperation);
		return readAsyncOperation.Task;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (Thread.CurrentThread.Equals(mainThread) || Thread.CurrentThread.Equals(workerThread))
		{
			throw new InvalidOperationException("You must not use synchronous Read() from the main thread.");
		}
		return ReadAsync(buffer, offset, count, CancellationToken.None).Result;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}
}
