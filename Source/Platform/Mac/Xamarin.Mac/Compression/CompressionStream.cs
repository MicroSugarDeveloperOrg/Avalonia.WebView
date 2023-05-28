using System;
using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Compression;

[iOS(9, 0)]
[Mac(10, 11)]
public class CompressionStream : Stream
{
	private sealed class CopyToAsyncStream : Stream
	{
		private readonly CompressionStream _deflateStream;

		private readonly Stream _destination;

		private readonly CancellationToken _cancellationToken;

		private byte[] _arrayPoolBuffer;

		private int _arrayPoolBufferHighWaterMark;

		public override bool CanWrite => true;

		public override bool CanRead => false;

		public override bool CanSeek => false;

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

		public CopyToAsyncStream(CompressionStream deflateStream, Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			if (deflateStream == null)
			{
				throw new ArgumentNullException("deflateStream");
			}
			if (destination == null)
			{
				throw new ArgumentNullException("destination");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize");
			}
			_deflateStream = deflateStream;
			_destination = destination;
			_cancellationToken = cancellationToken;
			_arrayPoolBuffer = ArrayPool<byte>.Shared.Rent(bufferSize);
		}

		public async Task CopyFromSourceToDestination()
		{
			_deflateStream.AsyncOperationStarting();
			try
			{
				while (true)
				{
					int bytesRead = _deflateStream._inflater.Inflate(_arrayPoolBuffer, 0, _arrayPoolBuffer.Length);
					if (bytesRead > 0)
					{
						if (bytesRead > _arrayPoolBufferHighWaterMark)
						{
							_arrayPoolBufferHighWaterMark = bytesRead;
						}
						await _destination.WriteAsync(_arrayPoolBuffer, 0, bytesRead, _cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						continue;
					}
					break;
				}
				await _deflateStream._stream.CopyToAsync(this, _arrayPoolBuffer.Length, _cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			finally
			{
				_deflateStream.AsyncOperationCompleting();
				Array.Clear(_arrayPoolBuffer, 0, _arrayPoolBufferHighWaterMark);
				ArrayPool<byte>.Shared.Return(_arrayPoolBuffer, false);
				_arrayPoolBuffer = null;
			}
		}

		public override async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (buffer == _arrayPoolBuffer)
			{
				throw new ArgumentException("buffer");
			}
			_deflateStream.EnsureNotDisposed();
			if (count <= 0)
			{
				return;
			}
			if (count > buffer.Length - offset)
			{
				throw new InvalidDataException("Found invalid data while decoding.");
			}
			_deflateStream._inflater.SetInput(buffer, offset, count);
			while (true)
			{
				int bytesRead = _deflateStream._inflater.Inflate(_arrayPoolBuffer, 0, _arrayPoolBuffer.Length);
				if (bytesRead > 0)
				{
					if (bytesRead > _arrayPoolBufferHighWaterMark)
					{
						_arrayPoolBufferHighWaterMark = bytesRead;
					}
					await _destination.WriteAsync(_arrayPoolBuffer, 0, bytesRead, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					continue;
				}
				break;
			}
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			WriteAsync(buffer, offset, count, default(CancellationToken)).GetAwaiter().GetResult();
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}
	}

	private const int DefaultBufferSize = 8192;

    private Stream? _stream;
    Stream Stream
    {
        get
        {
            if (_stream is null)
                throw new ObjectDisposedException(null, "Can not access a closed Stream.");
            return _stream;
        }
    }

    private CompressionMode _mode;

    CompressionAlgorithm _algorithm;

    private bool _leaveOpen;

    private Inflater? _inflater;
    Inflater Inflater
    {
        get
        {
            if (_inflater is null)
                throw new InvalidOperationException("Can't access an inflater when decompressing");
            return _inflater;
        }
    }
    private Deflater? _deflater;
    Deflater Deflater
    {
        get
        {
            if (_deflater is null)
                throw new InvalidOperationException("Can't access a deflater when compressing");
            return _deflater;
        }
    }
    private byte[]? _buffer;
    Byte[] Buffer
    {
        get
        {
            if (_buffer is null)
                throw new InvalidOperationException("Buffer has not been initialized");
            return _buffer;
        }
    }

    private int _activeAsyncOperation;

	private bool _wroteBytes;

	public Stream BaseStream => _stream;

	public override bool CanRead
	{
		get
		{
			if (_stream == null)
			{
				return false;
			}
			return _mode == CompressionMode.Decompress && _stream.CanRead;
		}
	}

	public override bool CanWrite
	{
		get
		{
			if (_stream == null)
			{
				return false;
			}
			return _mode == CompressionMode.Compress && _stream.CanWrite;
		}
	}

	public override bool CanSeek => false;

	public override long Length
	{
		get
		{
			throw new NotSupportedException("This operation is not supported.");
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException("This operation is not supported.");
		}
		set
		{
			throw new NotSupportedException("This operation is not supported.");
		}
	}

	private bool AsyncOperationIsActive => _activeAsyncOperation != 0;

	public CompressionStream(Stream stream, CompressionAlgorithm algorithm)
		: this(stream, algorithm, leaveOpen: false)
	{
	}

	public CompressionStream(Stream stream, CompressionAlgorithm algorithm, bool leaveOpen)
		: this(stream, CompressionMode.Compress, algorithm, leaveOpen)
	{
	}

	public CompressionStream(Stream stream, CompressionMode mode, CompressionAlgorithm algorithm)
		: this(stream, mode, algorithm, leaveOpen: false)
	{
	}

	public CompressionStream(Stream stream, CompressionMode mode, CompressionAlgorithm algorithm, bool leaveOpen)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		switch (mode)
		{
		case CompressionMode.Decompress:
			InitializeInflater(stream, algorithm, leaveOpen);
			break;
		case CompressionMode.Compress:
			InitializeDeflater(stream, algorithm, leaveOpen);
			break;
		default:
			throw new ArgumentException("Enum value was out of legal range.", "mode");
		}
	}

	internal void InitializeInflater(Stream stream, CompressionAlgorithm algorithm, bool leaveOpen)
	{
		if (!stream.CanRead)
		{
			throw new ArgumentException("Stream does not support reading.", "stream");
		}
		_algorithm = algorithm;
        _inflater = new Inflater(algorithm);
		_stream = stream;
		_mode = CompressionMode.Decompress;
		_leaveOpen = leaveOpen;
	}

	internal void InitializeDeflater(Stream stream, CompressionAlgorithm algorithm, bool leaveOpen)
	{
		if (!stream.CanWrite)
		{
			throw new ArgumentException("Stream does not support writing.", "stream");
		}
        _algorithm = algorithm;
        _deflater = new Deflater(algorithm);
		_stream = stream;
		_mode = CompressionMode.Compress;
		_leaveOpen = leaveOpen;
		InitializeBuffer();
	}

	private void InitializeBuffer()
	{
		_buffer = ArrayPool<byte>.Shared.Rent(8192);
	}

	private void EnsureBufferInitialized()
	{
		if (_buffer == null)
		{
			InitializeBuffer();
		}
	}

	public override void Flush()
	{
		EnsureNotDisposed();
		if (_mode == CompressionMode.Compress)
		{
			FlushBuffers();
		}
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		EnsureNoActiveAsyncOperation();
		EnsureNotDisposed();
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCanceled(cancellationToken);
		}
		return (_mode != CompressionMode.Compress || !_wroteBytes) ? Task.CompletedTask : FlushAsyncCore(cancellationToken);
	}

	private async Task FlushAsyncCore(CancellationToken cancellationToken)
	{
		AsyncOperationStarting();
		try
		{
			await WriteDeflaterOutputAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			bool flushSuccessful;
			do
			{
				flushSuccessful = _deflater.Flush(_buffer, out var compressedBytes);
				if (flushSuccessful)
				{
					await _stream.WriteAsync(_buffer, 0, compressedBytes, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			while (flushSuccessful);
		}
		finally
		{
			AsyncOperationCompleting();
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("This operation is not supported.");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("This operation is not supported.");
	}

	public override int ReadByte()
	{
		EnsureDecompressionMode();
		EnsureNotDisposed();
		byte b;
		return _inflater.Inflate(out b) ? b : base.ReadByte();
	}

	public override int Read(byte[] array, int offset, int count)
	{
		ValidateParameters(array, offset, count);
		return ReadCore(new Span<byte>(array, offset, count));
	}

	public virtual int Read(Span<byte> destination)
	{
		if (GetType() != typeof(CompressionStream))
		{
			return Read(destination);
		}
		return ReadCore(destination);
	}

	internal int ReadCore(Span<byte> destination)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		EnsureDecompressionMode();
		EnsureNotDisposed();
		EnsureBufferInitialized();
		int num = 0;
		while (true)
		{
			int num2 = _inflater.Inflate(destination.Slice(num));
			num += num2;
			if (num == destination.Length || _inflater.Finished())
			{
				break;
			}
			int num3 = _stream.Read(_buffer, 0, _buffer.Length);
			if (num3 <= 0)
			{
				break;
			}
			if (num3 > _buffer.Length)
			{
				throw new InvalidDataException("Found invalid data while decoding.");
			}
			_inflater.SetInput(_buffer, 0, num3);
		}
		return num;
	}

	private void ValidateParameters(byte[] array, int offset, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException("Offset plus count is larger than the length of target array.");
		}
	}

	private void EnsureNotDisposed()
	{
		if (_stream == null)
		{
			ThrowStreamClosedException();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowStreamClosedException()
	{
		throw new ObjectDisposedException(null, "Can not access a closed Stream.");
	}

	private void EnsureDecompressionMode()
	{
		if (_mode != 0)
		{
			ThrowCannotReadFromDeflateStreamException();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowCannotReadFromDeflateStreamException()
	{
		throw new InvalidOperationException("Reading from the compression stream is not supported.");
	}

	private void EnsureCompressionMode()
	{
		if (_mode != CompressionMode.Compress)
		{
			ThrowCannotWriteToDeflateStreamException();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowCannotWriteToDeflateStreamException()
	{
		throw new InvalidOperationException("Writing to the compression stream is not supported.");
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) => TaskToApm.Begin(ReadAsync (buffer, offset, count, CancellationToken.None), asyncCallback, asyncState);

	public override int EndRead(IAsyncResult asyncResult) => TaskToApm.End<int>(asyncResult);

    public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		ValidateParameters(array, offset, count);
		return ReadAsyncMemory(new Memory<byte>(array, offset, count), cancellationToken).AsTask();
	}

	public virtual ValueTask<int> ReadAsync(Memory<byte> destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (GetType() != typeof(CompressionStream))
		{
			return  new ValueTask<int>(base.ReadAsync(destination.ToArray(), 0, destination.Length, cancellationToken));
		}
		return ReadAsyncMemory(destination, cancellationToken);
	}

    internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken)
	{
		EnsureDecompressionMode();
		EnsureNoActiveAsyncOperation();
		EnsureNotDisposed();
		if (cancellationToken.IsCancellationRequested)
		{
			return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
		}
		EnsureBufferInitialized();
		bool flag = true;
		AsyncOperationStarting();
		try
		{
			int num = _inflater.Inflate(destination.Span);
			if (num != 0)
			{
				return new ValueTask<int>(num);
			}
			if (_inflater.Finished())
			{
				return new ValueTask<int>(0);
			}
			ValueTask<int> readTask = new ValueTask<int>(Stream.ReadAsync(_buffer, 0, _buffer.Length, cancellationToken));
			flag = false;
			return FinishReadAsyncMemory(readTask, destination, cancellationToken);
		}
		finally
		{
			if (flag)
			{
				AsyncOperationCompleting();
			}
		}
	}

    private async ValueTask<int> FinishReadAsyncMemory(
        ValueTask<int> readTask, Memory<byte> destination, CancellationToken cancellationToken)
    {
        try
        {
            while (true)
            {
                int bytesRead = await readTask.ConfigureAwait(false);
                EnsureNotDisposed();

                if (bytesRead <= 0)
                {
                    // This indicates the base stream has received EOF
                    return 0;
                }
                else if (bytesRead > Buffer.Length)
                {
                    // The stream is either malicious or poorly implemented and returned a number of
                    // bytes larger than the buffer supplied to it.
                    throw new InvalidDataException("Found invalid data while decoding.");
                }

                cancellationToken.ThrowIfCancellationRequested();

                // Feed the data from base stream into decompression engine
                Inflater.SetInput(Buffer, 0, bytesRead);
                bytesRead = Inflater.Inflate(destination.Span);

                if (bytesRead == 0 && !Inflater.Finished())
                {
                    readTask = new ValueTask<int>(Stream.ReadAsync(_buffer, 0, _buffer.Length, cancellationToken));
                }
                else
                {
                    return bytesRead;
                }
            }
        }
        finally
        {
            AsyncOperationCompleting();
        }
    }


    public override void Write(byte[] array, int offset, int count)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		ValidateParameters(array, offset, count);
		WriteCore(new ReadOnlySpan<byte>(array, offset, count));
	}

	public virtual void Write(ReadOnlySpan<byte> source)
	{
		if (GetType() != typeof(CompressionStream))
		{
			Write(source.ToArray(), 0, source.Length);
		}
		else
		{
			WriteCore(source);
		}
	}

	internal unsafe void WriteCore(ReadOnlySpan<byte> source)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		EnsureCompressionMode();
		EnsureNotDisposed();
		WriteDeflaterOutput();
		fixed (byte* inputBufferPtr = &MemoryMarshal.GetReference<byte>(source))
		{
			_deflater.SetInput(inputBufferPtr, source.Length);
			WriteDeflaterOutput();
			_wroteBytes = true;
		}
	}

	private void WriteDeflaterOutput()
	{
		while (!_deflater.NeedsInput())
		{
			int deflateOutput = _deflater.GetDeflateOutput(_buffer);
			if (deflateOutput > 0)
			{
				_stream.Write(_buffer, 0, deflateOutput);
			}
			if (_deflater.Finished())
			{
				break;
			}
		}
	}

	private void FlushBuffers()
	{
		if (!_wroteBytes)
		{
			return;
		}
		WriteDeflaterOutput();
		bool flag;
		do
		{
			flag = _deflater.Flush(_buffer, out var bytesRead);
			if (flag)
			{
				_stream.Write(_buffer, 0, bytesRead);
			}
		}
		while (flag);
	}

	private void PurgeBuffers(bool disposing)
	{
		if (!disposing || _stream == null || _mode != CompressionMode.Compress)
		{
			return;
		}
		if (_wroteBytes)
		{
			WriteDeflaterOutput();
			bool flag;
			do
			{
				flag = _deflater.Finish(_buffer, out var bytesRead);
				if (bytesRead > 0)
				{
					_stream.Write(_buffer, 0, bytesRead);
				}
			}
			while (!flag);
		}
		else
		{
			int bytesRead2;
			while (!_deflater.Finish(_buffer, out bytesRead2))
			{
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			PurgeBuffers(disposing);
		}
		finally
		{
			try
			{
				if (disposing && !_leaveOpen)
				{
					_stream?.Dispose();
				}
			}
			finally
			{
				_stream = null;
				try
				{
					_deflater?.Dispose();
					_inflater?.Dispose();
				}
				finally
				{
					_deflater = null;
					_inflater = null;
					byte[] buffer = _buffer;
					if (buffer != null)
					{
						_buffer = null;
						if (!AsyncOperationIsActive)
						{
							ArrayPool<byte>.Shared.Return(buffer, false);
						}
					}
					base.Dispose(disposing);
				}
			}
		}
	}

	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		return System.Threading.Tasks.TaskToApm.Begin(WriteAsync(array, offset, count, CancellationToken.None), asyncCallback, asyncState);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		System.Threading.Tasks.TaskToApm.End(asyncResult);
	}

	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
	{
		ValidateParameters(array, offset, count);
		return WriteAsyncMemory(new ReadOnlyMemory<byte>(array, offset, count), cancellationToken);
	}

	public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
	{
		if (GetType() != typeof(CompressionStream))
		{
			return new ValueTask(base.WriteAsync(source.ToArray(), 0, source.Length ,cancellationToken));
		}
		return new ValueTask(WriteAsyncMemory(source, cancellationToken));
	}

	internal Task WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
	{
		EnsureCompressionMode();
		EnsureNoActiveAsyncOperation();
		EnsureNotDisposed();
		return cancellationToken.IsCancellationRequested ? Task.FromCanceled<int>(cancellationToken) : WriteAsyncMemoryCore(source, cancellationToken);
	}

	private async Task WriteAsyncMemoryCore(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
	{
		AsyncOperationStarting();
		try
		{
			await WriteDeflaterOutputAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			_deflater.SetInput(source);
			await WriteDeflaterOutputAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			_wroteBytes = true;
		}
		finally
		{
			AsyncOperationCompleting();
		}
	}

	private async Task WriteDeflaterOutputAsync(CancellationToken cancellationToken)
	{
		while (!_deflater.NeedsInput())
		{
			int compressedBytes = _deflater.GetDeflateOutput(_buffer);
			if (compressedBytes > 0)
			{
				await _stream.WriteAsync(_buffer, 0, compressedBytes, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (_deflater.Finished())
			{
				break;
			}
		}
	}

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		EnsureDecompressionMode();
		EnsureNoActiveAsyncOperation();
		EnsureNotDisposed();
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCanceled<int>(cancellationToken);
		}
		return new CopyToAsyncStream(this, destination, bufferSize, cancellationToken).CopyFromSourceToDestination();
	}

	private void EnsureNoActiveAsyncOperation()
	{
		if (AsyncOperationIsActive)
		{
			ThrowInvalidBeginCall();
		}
	}

	private void AsyncOperationStarting()
	{
		if (Interlocked.CompareExchange(ref _activeAsyncOperation, 1, 0) != 0)
		{
			ThrowInvalidBeginCall();
		}
	}

	private void AsyncOperationCompleting()
	{
		int num = Interlocked.CompareExchange(ref _activeAsyncOperation, 0, 1);
		if (num != 1)
		{
			throw new InvalidOperationException(string.Format("Expected {0} to be 1, got {1}", "_activeAsyncOperation", num));
		}
	}

	private static void ThrowInvalidBeginCall()
	{
		throw new InvalidOperationException("Only one asynchronous reader or writer is allowed time at one time.");
	}
}
