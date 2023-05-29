using System;
using System.Runtime.InteropServices;
using CoreFoundation;

namespace AudioToolbox;

public class AudioFileMarkerList : IDisposable
{
	private IntPtr ptr;

	private readonly bool owns;

	public SmpteTimeType SmpteTimeType => (SmpteTimeType)Marshal.ReadInt32(ptr);

	public uint Count => (uint)Marshal.ReadInt32(ptr, 4);

	public unsafe AudioFileMarker this[int index]
	{
		get
		{
			if (index >= Count || index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return *(AudioFileMarker*)((byte*)(void*)ptr + (nint)8 * (nint)sizeof(AudioFileMarker) + (nint)(index * sizeof(AudioFileMarker)) * (nint)sizeof(AudioFileMarker));
		}
	}

	public AudioFileMarkerList(IntPtr ptr, bool owns)
	{
		this.ptr = ptr;
		this.owns = owns;
	}

	~AudioFileMarkerList()
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
				CFObject.CFRelease(this[i].Name_cfstringref);
			}
			Marshal.FreeHGlobal(ptr);
			ptr = IntPtr.Zero;
		}
	}
}
