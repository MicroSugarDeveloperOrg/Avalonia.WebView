using System;

namespace CoreFoundation;

internal class CFDataBuffer : IDisposable
{
	private byte[] buffer;

	private CFData data;

	public IntPtr Handle => data.Handle;

	public byte[] Data => buffer;

	public byte this[int idx] => buffer[idx];

	public unsafe CFDataBuffer(byte[] buffer)
	{
		this.buffer = buffer;
		fixed (byte* ptr = buffer)
		{
			data = CFData.FromData((IntPtr)ptr, buffer.Length);
		}
	}

	public CFDataBuffer(IntPtr ptr)
	{
		data = new CFData(ptr, owns: false);
		buffer = data.GetBuffer();
	}

	~CFDataBuffer()
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
		if (data != null)
		{
			data.Dispose();
			data = null;
		}
	}
}
