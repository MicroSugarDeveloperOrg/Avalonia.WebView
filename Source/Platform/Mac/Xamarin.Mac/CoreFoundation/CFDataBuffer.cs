using System;
using System.Runtime.InteropServices;

namespace CoreFoundation;

internal class CFDataBuffer : IDisposable
{
	private byte[] buffer;

	private CFData data;

	private bool owns;

	public IntPtr Handle => data.Handle;

	public byte[] Data => buffer;

	public byte this[int idx] => buffer[idx];

	public CFDataBuffer(byte[] buffer)
	{
		this.buffer = buffer;
		GCHandle gCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		data = CFData.FromData(gCHandle.AddrOfPinnedObject(), buffer.Length);
		gCHandle.Free();
		owns = true;
	}

	public CFDataBuffer(IntPtr ptr)
	{
		data = new CFData(ptr, owns: false);
		buffer = data.GetBuffer();
		owns = false;
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
