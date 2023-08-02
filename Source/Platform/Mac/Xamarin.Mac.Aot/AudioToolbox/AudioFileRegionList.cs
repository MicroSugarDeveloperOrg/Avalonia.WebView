using System;
using System.Runtime.InteropServices;
using CoreFoundation;

namespace AudioToolbox;

public class AudioFileRegionList : IDisposable
{
	private IntPtr ptr;

	private readonly bool owns;

	public SmpteTimeType SmpteTimeType => (SmpteTimeType)Marshal.ReadInt32(ptr);

	public uint Count => (uint)Marshal.ReadInt32(ptr, 4);

	public unsafe AudioFileRegion this[int index]
	{
		get
		{
			if (index >= Count || index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			byte* ptr = (byte*)(void*)this.ptr + 8;
			for (int i = 0; i < index; i++)
			{
				ptr += new AudioFileRegion((IntPtr)ptr).TotalSize;
			}
			return new AudioFileRegion((IntPtr)ptr);
		}
	}

	public AudioFileRegionList(IntPtr ptr, bool owns)
	{
		this.ptr = ptr;
		this.owns = owns;
	}

	~AudioFileRegionList()
	{
		Dispose(disposing: false);
		GC.SuppressFinalize(this);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (owns && !(ptr == IntPtr.Zero))
		{
			for (int i = 0; i < Count; i++)
			{
				CFObject.CFRelease(this[i].NameWeak);
			}
			Marshal.FreeHGlobal(ptr);
			ptr = IntPtr.Zero;
		}
	}
}
