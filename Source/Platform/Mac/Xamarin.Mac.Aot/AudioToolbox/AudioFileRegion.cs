using System;
using System.Runtime.InteropServices;
using CoreFoundation;

namespace AudioToolbox;

public struct AudioFileRegion
{
	private readonly IntPtr ptr;

	public uint RegionID => (uint)Marshal.ReadInt32(ptr);

	public string Name => CFString.FetchString(NameWeak);

	internal IntPtr NameWeak => Marshal.ReadIntPtr(ptr, 4);

	public unsafe AudioFileRegionFlags Flags => (AudioFileRegionFlags)Marshal.ReadInt32(ptr, 4 + sizeof(IntPtr));

	public unsafe int Count => Marshal.ReadInt32(ptr, 8 + sizeof(IntPtr));

	public unsafe AudioFileMarker this[int index]
	{
		get
		{
			if (index >= Count || index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return *(AudioFileMarker*)((byte*)(void*)ptr + (nint)12 * (nint)sizeof(AudioFileMarker) + (nint)sizeof(IntPtr) * (nint)sizeof(AudioFileMarker) + (nint)(index * sizeof(AudioFileMarker)) * (nint)sizeof(AudioFileMarker));
		}
	}

	internal unsafe int TotalSize => Count * sizeof(AudioFileMarker);

	public AudioFileRegion(IntPtr ptr)
	{
		this.ptr = ptr;
	}
}
