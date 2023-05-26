using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreVideo;

public struct CVTime
{
	public long TimeValue;

	public long TimeScale;

	public CVTimeFlags TimeFlags;

	private static IntPtr CoreVideo_libraryHandle = Dlfcn.dlopen("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", 0);

	public int Flags
	{
		get
		{
			return (int)TimeFlags;
		}
		set
		{
			TimeFlags = (CVTimeFlags)value;
		}
	}

	public static CVTime ZeroTime => (CVTime)Marshal.PtrToStructure(Dlfcn.GetIndirect(CoreVideo_libraryHandle, "kCVZeroTime"), typeof(CVTime));

	public static CVTime IndefiniteTime => (CVTime)Marshal.PtrToStructure(Dlfcn.GetIndirect(CoreVideo_libraryHandle, "kCVIndefiniteTime"), typeof(CVTime));

	public override bool Equals(object other)
	{
		if (!(other is CVTime cVTime))
		{
			return false;
		}
		if (TimeValue == cVTime.TimeValue && TimeScale == cVTime.TimeScale)
		{
			return TimeFlags == cVTime.TimeFlags;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return TimeValue.GetHashCode() ^ TimeScale.GetHashCode() ^ Flags;
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", EntryPoint = "CVGetCurrentHostTime")]
	public static extern long GetCurrentHostTime();

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", EntryPoint = "CVGetHostClockFrequency")]
	public static extern double GetHostClockFrequency();

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", EntryPoint = "CVGetHostClockMinimumTimeDelta")]
	public static extern int GetHostClockMinimumTimeDelta();
}
