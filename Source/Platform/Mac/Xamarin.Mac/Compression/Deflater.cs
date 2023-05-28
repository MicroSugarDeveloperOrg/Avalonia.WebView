using System;
using System.Buffers;

namespace Compression;

internal sealed class Deflater : IDisposable
{
	private CompressionStreamStruct _compression_struct;

	private bool _finished;

	private MemoryHandle _inputBufferHandle;

	private bool _isDisposed;

	private object SyncLock => this;

	public bool Finished()
	{
		return _finished;
	}

	internal Deflater(CompressionAlgorithm algorithm)
	{
		DeflateInit(algorithm);
	}

	~Deflater()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (!_isDisposed)
		{
			CompressionStreamStruct.compression_stream_destroy(ref _compression_struct);
			DeallocateInputBufferHandle();
			_isDisposed = true;
		}
	}

	public bool NeedsInput()
	{
		return _compression_struct.SourceSize == 0;
	}

	internal unsafe void SetInput(ReadOnlyMemory<byte> inputBuffer)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!NeedsInput())
		{
			throw new InvalidOperationException("We have something left in previous input!");
		}
		if (_inputBufferHandle.Pointer != null)
		{
			throw new InvalidOperationException("Unexpected input buffer handler found.");
		}
		if (inputBuffer.Length == 0)
		{
			return;
		}
		lock (SyncLock)
		{
			_inputBufferHandle = inputBuffer.Pin();
			_compression_struct.Source = (IntPtr)_inputBufferHandle.Pointer;
			_compression_struct.SourceSize = inputBuffer.Length;
		}
	}

	internal unsafe void SetInput(byte* inputBufferPtr, int count)
	{
		if (!NeedsInput())
		{
			throw new InvalidOperationException("We have something left in previous input!");
		}
		if (inputBufferPtr == null)
		{
			throw new ArgumentNullException("inputBufferPtr");
		}
		if (_inputBufferHandle.Pointer != null)
		{
			throw new InvalidOperationException("Unexpected input buffer handler found.");
		}
		if (count == 0)
		{
			return;
		}
		lock (SyncLock)
		{
			_compression_struct.Source = (IntPtr)inputBufferPtr;
			_compression_struct.SourceSize = count;
		}
	}

	internal int GetDeflateOutput(byte[] outputBuffer)
	{
		if (outputBuffer == null)
		{
			throw new ArgumentNullException("outputBuffer");
		}
		if (NeedsInput())
		{
			throw new InvalidOperationException("GetDeflateOutput should only be called after providing input");
		}
		try
		{
			ReadDeflateOutput(outputBuffer, StreamFlag.Continue, out var bytesRead);
			return bytesRead;
		}
		finally
		{
			if (0 == _compression_struct.SourceSize)
			{
				DeallocateInputBufferHandle();
			}
		}
	}

	private unsafe CompressionStatus ReadDeflateOutput(byte[] outputBuffer, StreamFlag flushCode, out int bytesRead)
	{
		if (outputBuffer != null && outputBuffer.Length < 0)
		{
			throw new ArgumentException("outputbuffer length must be bigger than 0");
		}
		lock (SyncLock)
		{
			fixed (byte* ptr = &outputBuffer[0])
			{
				_compression_struct.Destination = (IntPtr)ptr;
				_compression_struct.DestinationSize = outputBuffer.Length;
				CompressionStatus compressionStatus = CompressionStreamStruct.compression_stream_process(ref _compression_struct, flushCode);
				CompressionStatus compressionStatus2 = compressionStatus;
				CompressionStatus compressionStatus3 = compressionStatus2;
				if ((uint)compressionStatus3 <= 1u)
				{
					bytesRead = outputBuffer.Length - (int)_compression_struct.DestinationSize;
				}
				else
				{
					bytesRead = 0;
				}
				_finished = compressionStatus == CompressionStatus.End;
				return compressionStatus;
			}
		}
	}

	internal bool Finish(byte[] outputBuffer, out int bytesRead)
	{
		if (outputBuffer == null)
		{
			throw new ArgumentNullException("outputBuffer");
		}
		if (outputBuffer.Length < 0)
		{
			throw new ArgumentException("Can't pass in an empty output buffer!");
		}
		CompressionStatus compressionStatus = ReadDeflateOutput(outputBuffer, StreamFlag.Finalize, out bytesRead);
		return compressionStatus == CompressionStatus.End;
	}

	internal unsafe bool Flush(byte[] outputBuffer, out int bytesRead)
	{
		if (outputBuffer == null)
		{
			throw new ArgumentNullException("outputBuffer");
		}
		if (outputBuffer.Length < 0)
		{
			throw new ArgumentException("Can't pass in an empty output buffer!");
		}
		if (!NeedsInput())
		{
			throw new InvalidOperationException("We have something left in previous input!");
		}
		if (_inputBufferHandle.Pointer != null)
		{
			throw new InvalidOperationException("InputHandler should not be set");
		}
		if (_finished)
		{
			return ReadDeflateOutput(outputBuffer, StreamFlag.Finalize, out bytesRead) == CompressionStatus.Ok;
		}
		bytesRead = 0;
		return false;
	}

	private void DeallocateInputBufferHandle()
	{
		lock (SyncLock)
		{
			_compression_struct.SourceSize = 0;
			_compression_struct.Source = IntPtr.Zero;
			((MemoryHandle)_inputBufferHandle).Dispose();
		}
	}

	private void DeflateInit(CompressionAlgorithm algorithm)
	{
		_finished = false;
		_compression_struct = default(CompressionStreamStruct);
		CompressionStatus compressionStatus = CompressionStreamStruct.compression_stream_init(ref _compression_struct, StreamOperation.Encode, algorithm);
		if (compressionStatus != 0)
		{
			throw new InvalidOperationException(compressionStatus.ToString());
		}
	}
}
