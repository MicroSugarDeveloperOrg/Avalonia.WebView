using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
public struct CVTime
{
	public long TimeValue;

	public long TimeScale;

	public CVTimeFlags TimeFlags;

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

	public static CVTime ZeroTime => (CVTime)Marshal.PtrToStructure(Dlfcn.GetIndirect(Libraries.CoreVideo.Handle, "kCVZeroTime"), typeof(CVTime));

	public static CVTime IndefiniteTime => (CVTime)Marshal.PtrToStructure(Dlfcn.GetIndirect(Libraries.CoreVideo.Handle, "kCVIndefiniteTime"), typeof(CVTime));

	public override bool Equals(object other)
	{
		if (!(other is CVTime cVTime))
		{
			return false;
		}
		return TimeValue == cVTime.TimeValue && TimeScale == cVTime.TimeScale && TimeFlags == cVTime.TimeFlags;
	}

	public override int GetHashCode()
	{
		return TimeValue.GetHashCode() ^ TimeScale.GetHashCode() ^ Flags;
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", EntryPoint = "CVGetCurrentHostTime")]
	public static extern ulong GetCurrentHostTime();

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", EntryPoint = "CVGetHostClockFrequency")]
	public static extern double GetHostClockFrequency();

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", EntryPoint = "CVGetHostClockMinimumTimeDelta")]
	public static extern uint GetHostClockMinimumTimeDelta();
}
