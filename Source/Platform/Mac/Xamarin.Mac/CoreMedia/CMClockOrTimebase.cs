using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace CoreMedia;

public class CMClockOrTimebase : IDisposable, INativeObject
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public CMTime Time => CMSyncGetTime(handle);

	internal CMClockOrTimebase()
	{
	}

	public CMClockOrTimebase(IntPtr handle)
	{
		this.handle = handle;
	}

	internal CMClockOrTimebase(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(Handle);
		}
		this.handle = handle;
	}

	~CMClockOrTimebase()
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
		if (Handle != IntPtr.Zero)
		{
			CFObject.CFRelease(Handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMSyncGetTime(IntPtr clockOrTimebase);

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern double CMSyncGetRelativeRate(IntPtr ofClockOrTimebase, IntPtr relativeToClockOrTimebase);

	public static double GetRelativeRate(CMClockOrTimebase clockOrTimebaseA, CMClockOrTimebase clockOrTimebaseB)
	{
		if (clockOrTimebaseA == null)
		{
			throw new ArgumentNullException("clockOrTimebaseA");
		}
		if (clockOrTimebaseB == null)
		{
			throw new ArgumentNullException("clockOrTimebaseB");
		}
		return CMSyncGetRelativeRate(clockOrTimebaseA.Handle, clockOrTimebaseB.Handle);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMSyncError CMSyncGetRelativeRateAndAnchorTime(IntPtr ofClockOrTimebase, IntPtr relativeToClockOrTimebase, out double outRelativeRate, out CMTime outOfClockOrTimebaseAnchorTime, out CMTime outRelativeToClockOrTimebaseAnchorTime);

	public static CMSyncError GetRelativeRateAndAnchorTime(CMClockOrTimebase clockOrTimebaseA, CMClockOrTimebase clockOrTimebaseB, out double relativeRate, out CMTime timeA, out CMTime timeB)
	{
		if (clockOrTimebaseA == null)
		{
			throw new ArgumentNullException("clockOrTimebaseA");
		}
		if (clockOrTimebaseB == null)
		{
			throw new ArgumentNullException("clockOrTimebaseB");
		}
		return CMSyncGetRelativeRateAndAnchorTime(clockOrTimebaseA.Handle, clockOrTimebaseB.handle, out relativeRate, out timeA, out timeB);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMTime CMSyncConvertTime(CMTime time, IntPtr fromClockOrTimebase, IntPtr toClockOrTimebase);

	public static CMTime ConvertTime(CMTime time, CMClockOrTimebase from, CMClockOrTimebase to)
	{
		if (from == null)
		{
			throw new ArgumentNullException("from");
		}
		if (to == null)
		{
			throw new ArgumentNullException("to");
		}
		return CMSyncConvertTime(time, from.Handle, to.Handle);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern bool CMSyncMightDrift(IntPtr clockOrTimebase1, IntPtr clockOrTimebase2);

	public static bool MightDrift(CMClockOrTimebase clockOrTimebaseA, CMClockOrTimebase clockOrTimebaseB)
	{
		if (clockOrTimebaseA == null)
		{
			throw new ArgumentNullException("clockOrTimebaseA");
		}
		if (clockOrTimebaseB == null)
		{
			throw new ArgumentNullException("clockOrTimebaseB");
		}
		return CMSyncMightDrift(clockOrTimebaseA.Handle, clockOrTimebaseB.Handle);
	}
}
