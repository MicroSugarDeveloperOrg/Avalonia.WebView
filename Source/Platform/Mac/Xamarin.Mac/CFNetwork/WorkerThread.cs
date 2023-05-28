using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using CoreFoundation;
using Foundation;

namespace CFNetwork;

public class WorkerThread
{
	private struct Event
	{
		public Func<CancellationToken, object> Callback;

		public TaskCompletionSource<object> Tcs;

		public CancellationTokenSource Cts;
	}

	private class Context : SynchronizationContext
	{
		private WorkerThread worker;

		public Context(WorkerThread worker)
		{
			this.worker = worker;
		}

		public override SynchronizationContext CreateCopy()
		{
			return new Context(worker);
		}

		public override void Post(SendOrPostCallback d, object state)
		{
			worker.PostNoResult(delegate
			{
				d(state);
			});
		}

		public override void Send(SendOrPostCallback d, object state)
		{
			worker.Post(delegate
			{
				d(state);
			}).Wait();
		}
	}

	private class Source : CFRunLoopSourceCustom
	{
		private WorkerThread worker;

		public Source(WorkerThread worker)
		{
			this.worker = worker;
		}

		protected override void OnSchedule(CFRunLoop loop, NSString mode)
		{
		}

		protected override void OnCancel(CFRunLoop loop, NSString mode)
		{
		}

		protected override void OnPerform()
		{
			worker.Perform();
		}
	}

	private CFRunLoop loop;

	private Source source;

	private Context context;

	private CancellationTokenSource cts;

	private ManualResetEventSlim readyEvent;

	private ConcurrentQueue<Event> eventQueue = new ConcurrentQueue<Event>();

	public WorkerThread()
	{
		cts = new CancellationTokenSource();
		readyEvent = new ManualResetEventSlim(initialState: false);
		Thread thread = new Thread((ThreadStart)delegate
		{
			Main();
		});
		thread.Start();
		readyEvent.Wait();
	}

	[Conditional("DEBUG")]
	private static void Log(string message, params object[] args)
	{
	}

	public void Main()
	{
		source = new Source(this);
		loop = CFRunLoop.Current;
		loop.AddSource(source, CFRunLoop.ModeDefault);
		context = new Context(this);
		SynchronizationContext.SetSynchronizationContext(context);
		readyEvent.Set();
		loop.Run();
		cts.Dispose();
		source.Dispose();
	}

	public void Stop()
	{
		cts.Cancel();
		loop.RemoveSource(source, CFRunLoop.ModeDefault);
		loop.Stop();
	}

	protected void PostNoResult(Action callback)
	{
		Event item = default(Event);
		item.Callback = delegate
		{
			callback();
			return null;
		};
		eventQueue.Enqueue(item);
		source.Signal();
		loop.WakeUp();
	}

	public Task Post(Action callback)
	{
		return Post(delegate
		{
			callback();
		}, CancellationToken.None);
	}

	public async Task Post(Action<CancellationToken> callback, CancellationToken cancellationToken)
	{
		Event ev = default(Event);
		ev.Callback = delegate(CancellationToken c)
		{
			callback(c);
			return null;
		};
		ev.Tcs = new TaskCompletionSource<object>();
		ev.Cts = CancellationTokenSource.CreateLinkedTokenSource(cts.Token, cancellationToken);
		eventQueue.Enqueue(ev);
		source.Signal();
		loop.WakeUp();
		try
		{
			await ev.Tcs.Task;
		}
		finally
		{
			ev.Cts.Dispose();
		}
	}

	public Task<T> Post<T>(Func<T> callback)
	{
		return Post((CancellationToken c) => callback(), CancellationToken.None);
	}

	public async Task<T> Post<T>(Func<CancellationToken, T> callback, CancellationToken cancellationToken)
	{
		Event ev = default(Event);
		ev.Callback = (CancellationToken c) => callback(c);
		ev.Tcs = new TaskCompletionSource<object>();
		ev.Cts = CancellationTokenSource.CreateLinkedTokenSource(cts.Token, cancellationToken);
		eventQueue.Enqueue(ev);
		source.Signal();
		loop.WakeUp();
		try
		{
			object result = await ev.Tcs.Task;
			if (result != null)
			{
				return (T)result;
			}
			return default(T);
		}
		finally
		{
			ev.Cts.Dispose();
		}
	}

	protected void Perform()
	{
		if (!eventQueue.TryDequeue(out var result))
		{
			return;
		}
		if (result.Cts != null && result.Cts.IsCancellationRequested)
		{
			result.Tcs.SetCanceled();
			return;
		}
		CancellationTokenSource cancellationTokenSource = result.Cts ?? cts;
		try
		{
			object result2 = result.Callback(cancellationTokenSource.Token);
			if (result.Tcs != null)
			{
				result.Tcs.SetResult(result2);
			}
		}
		catch (TaskCanceledException)
		{
			if (result.Tcs != null)
			{
				result.Tcs.SetCanceled();
			}
		}
		catch (Exception exception)
		{
			if (result.Tcs != null)
			{
				result.Tcs.SetException(exception);
			}
		}
	}
}
