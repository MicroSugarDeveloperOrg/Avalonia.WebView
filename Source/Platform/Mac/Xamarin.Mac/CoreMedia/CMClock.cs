using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public class CMClock : CMClockOrTimebase
{
	public static CMClock HostTimeClock => new CMClock(CMClockGetHostTimeClock(), owns: false);

	public CMTime CurrentTime => CMClockGetTime(base.Handle);

	public CMClock(IntPtr handle)
		: base(handle)
	{
	}

	internal CMClock(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMClockGetHostTimeClock();

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMClockGetTime(IntPtr clock);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMClockError CMClockGetAnchorTime(IntPtr clock, out CMTime outClockTime, out CMTime outReferenceClockTime);

	public CMClockError GetAnchorTime(out CMTime clockTime, out CMTime referenceClockTime)
	{
		return CMClockGetAnchorTime(base.Handle, out clockTime, out referenceClockTime);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern bool CMClockMightDrift(IntPtr clock, IntPtr otherClock);

	public bool MightDrift(CMClock otherClock)
	{
		if (otherClock == null)
		{
			throw new ArgumentNullException("otherClock");
		}
		return CMClockMightDrift(base.Handle, otherClock.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern void CMClockInvalidate(IntPtr clock);

	public void Invalidate()
	{
		CMClockInvalidate(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia", EntryPoint = "CMClockConvertHostTimeToSystemUnits")]
	public static extern ulong ConvertHostTimeToSystemUnits(CMTime hostTime);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia", EntryPoint = "CMClockMakeHostTimeFromSystemUnits")]
	public static extern CMTime CreateHostTimeFromSystemUnits(ulong hostTime);
}
