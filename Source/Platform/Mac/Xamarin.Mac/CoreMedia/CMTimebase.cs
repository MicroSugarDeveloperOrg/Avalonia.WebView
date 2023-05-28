using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public class CMTimebase : CMClockOrTimebase
{
	public const double VeryLongTimeInterval = 8073216000.0;

	private const int GetMethodDeprecatedMajor = 10;

	private const int GetMethodDeprecatedMinor = 11;

	public double EffectiveRate => CMTimebaseGetEffectiveRate(base.Handle);

	public double Rate
	{
		get
		{
			return CMTimebaseGetRate(base.Handle);
		}
		set
		{
			CMTimebaseError cMTimebaseError = CMTimebaseSetRate(base.Handle, value);
			if (cMTimebaseError != 0)
			{
				throw new ArgumentException(cMTimebaseError.ToString());
			}
		}
	}

	public new CMTime Time
	{
		get
		{
			return CMTimebaseGetTime(base.Handle);
		}
		set
		{
			CMTimebaseError cMTimebaseError = CMTimebaseSetTime(base.Handle, value);
			if (cMTimebaseError != 0)
			{
				throw new ArgumentException(cMTimebaseError.ToString());
			}
		}
	}

	public CMTimebase(IntPtr handle)
		: base(handle)
	{
	}

	private CMTimebase(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseCreateWithMasterClock(IntPtr allocator, IntPtr masterClock, out IntPtr timebaseOut);

	public CMTimebase(CMClock masterClock)
	{
		if (masterClock == null)
		{
			throw new ArgumentNullException("masterClock");
		}
		CMTimebaseError cMTimebaseError = CMTimebaseCreateWithMasterClock(IntPtr.Zero, masterClock.Handle, out handle);
		if (cMTimebaseError != 0)
		{
			throw new ArgumentException(cMTimebaseError.ToString());
		}
		CFObject.CFRetain(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseCreateWithMasterTimebase(IntPtr allocator, IntPtr masterTimebase, out IntPtr timebaseOut);

	public CMTimebase(CMTimebase masterTimebase)
	{
		if (masterTimebase == null)
		{
			throw new ArgumentNullException("masterTimebase");
		}
		CMTimebaseError cMTimebaseError = CMTimebaseCreateWithMasterTimebase(IntPtr.Zero, masterTimebase.Handle, out handle);
		if (cMTimebaseError != 0)
		{
			throw new ArgumentException(cMTimebaseError.ToString());
		}
		CFObject.CFRetain(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern double CMTimebaseGetEffectiveRate(IntPtr timebase);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern double CMTimebaseGetRate(IntPtr timebase);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseSetRate(IntPtr timebase, double rate);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMTimebaseGetTime(IntPtr timebase);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseSetTime(IntPtr timebase, CMTime time);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMTimebaseGetMasterTimebase(IntPtr timebase);

	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'CopyMasterTimebase' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'CopyMasterTimebase' instead.")]
	public CMTimebase GetMasterTimebase()
	{
		IntPtr intPtr = CMTimebaseGetMasterTimebase(base.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CMTimebase(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMTimebaseGetMasterClock(IntPtr timebase);

	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'CopyMasterClock' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'CopyMasterClock' instead.")]
	public CMClock GetMasterClock()
	{
		IntPtr intPtr = CMTimebaseGetMasterClock(base.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CMClock(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMTimebaseGetMaster(IntPtr timebase);

	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'CopyMaster' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'CopyMaster' instead.")]
	public CMClockOrTimebase GetMaster()
	{
		IntPtr intPtr = CMTimebaseGetMaster(base.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CMClockOrTimebase(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMTimebaseGetUltimateMasterClock(IntPtr timebase);

	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'CopyUltimateMasterClock' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'CopyUltimateMasterClock' instead.")]
	public CMClock GetUltimateMasterClock()
	{
		IntPtr intPtr = CMTimebaseGetUltimateMasterClock(base.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CMClock(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTime CMTimebaseGetTimeWithTimeScale(IntPtr timebase, CMTimeScale timescale, CMTimeRoundingMethod method);

	public CMTime GetTime(CMTimeScale timeScale, CMTimeRoundingMethod roundingMethod)
	{
		return CMTimebaseGetTimeWithTimeScale(base.Handle, timeScale, roundingMethod);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseSetAnchorTime(IntPtr timebase, CMTime timebaseTime, CMTime immediateMasterTime);

	public CMTimebaseError SetAnchorTime(CMTime timebaseTime, CMTime immediateMasterTime)
	{
		return CMTimebaseSetAnchorTime(base.Handle, timebaseTime, immediateMasterTime);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseGetTimeAndRate(IntPtr timebase, out CMTime time, out double rate);

	public CMTimebaseError GetTimeAndRate(out CMTime time, out double rate)
	{
		return CMTimebaseGetTimeAndRate(base.Handle, out time, out rate);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseSetRateAndAnchorTime(IntPtr timebase, double rate, CMTime timebaseTime, CMTime immediateMasterTime);

	public CMTimebaseError SetRateAndAnchorTime(double rate, CMTime timebaseTime, CMTime immediateMasterTime)
	{
		return CMTimebaseSetRateAndAnchorTime(base.Handle, rate, timebaseTime, immediateMasterTime);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseNotificationBarrier(IntPtr timebase);

	public CMTimebaseError NotificationBarrier()
	{
		return CMTimebaseNotificationBarrier(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseAddTimer(IntPtr timebase, IntPtr timer, IntPtr runloop);

	public CMTimebaseError AddTimer(NSTimer timer, NSRunLoop runloop)
	{
		if (timer == null)
		{
			throw new ArgumentNullException("timer");
		}
		if (runloop == null)
		{
			throw new ArgumentNullException("runloop");
		}
		using CFRunLoop cFRunLoop = runloop.GetCFRunLoop();
		return CMTimebaseAddTimer(base.Handle, timer.Handle, cFRunLoop.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseRemoveTimer(IntPtr timebase, IntPtr timer);

	public CMTimebaseError RemoveTimer(NSTimer timer)
	{
		if (timer == null)
		{
			throw new ArgumentNullException("timer");
		}
		return CMTimebaseRemoveTimer(base.Handle, timer.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseSetTimerNextFireTime(IntPtr timebase, IntPtr timer, CMTime fireTime, uint flags);

	public CMTimebaseError SetTimerNextFireTime(NSTimer timer, CMTime fireTime)
	{
		if (timer == null)
		{
			throw new ArgumentNullException("timer");
		}
		return CMTimebaseSetTimerNextFireTime(base.Handle, timer.Handle, fireTime, 0u);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMTimebaseError CMTimebaseSetTimerToFireImmediately(IntPtr timebase, IntPtr timer);

	public CMTimebaseError SetTimerToFireImmediately(NSTimer timer)
	{
		if (timer == null)
		{
			throw new ArgumentNullException("timer");
		}
		return CMTimebaseSetTimerToFireImmediately(base.Handle, timer.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern CMTimebaseError CMTimebaseSetMasterTimebase(IntPtr timebase, IntPtr newMasterTimebase);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public CMTimebaseError SetMasterTimebase(CMTimebase newMasterTimebase)
	{
		if (newMasterTimebase == null)
		{
			throw new ArgumentNullException("newMasterTimebase");
		}
		return CMTimebaseSetMasterTimebase(base.Handle, newMasterTimebase.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern CMTimebaseError CMTimebaseSetMasterClock(IntPtr timebase, IntPtr newMasterClock);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public CMTimebaseError SetMasterClock(CMClock newMasterClock)
	{
		if (newMasterClock == null)
		{
			throw new ArgumentNullException("newMasterClock");
		}
		return CMTimebaseSetMasterClock(base.Handle, newMasterClock.Handle);
	}

	private bool IsDeprecated()
	{
		return PlatformHelper.CheckSystemVersion(10, 11);
	}

	public CMTimebase CopyMasterTimebase()
	{
		IntPtr zero = IntPtr.Zero;
		bool flag = IsDeprecated();
		zero = ((!flag) ? CMTimebaseGetMasterTimebase(base.Handle) : CMTimebaseCopyMasterTimebase(base.Handle));
		if (zero == IntPtr.Zero)
		{
			return null;
		}
		return new CMTimebase(zero, flag);
	}

	public CMClock CopyMasterClock()
	{
		IntPtr zero = IntPtr.Zero;
		bool flag = IsDeprecated();
		zero = ((!flag) ? CMTimebaseGetMasterClock(base.Handle) : CMTimebaseCopyMasterClock(base.Handle));
		if (zero == IntPtr.Zero)
		{
			return null;
		}
		return new CMClock(zero, flag);
	}

	public CMClockOrTimebase CopyMaster()
	{
		IntPtr zero = IntPtr.Zero;
		bool flag = IsDeprecated();
		zero = ((!flag) ? CMTimebaseGetMaster(base.Handle) : CMTimebaseCopyMaster(base.Handle));
		if (zero == IntPtr.Zero)
		{
			return null;
		}
		return new CMClockOrTimebase(zero, flag);
	}

	public CMClock CopyUltimateMasterClock()
	{
		IntPtr zero = IntPtr.Zero;
		bool flag = IsDeprecated();
		zero = ((!flag) ? CMTimebaseGetUltimateMasterClock(base.Handle) : CMTimebaseCopyUltimateMasterClock(base.Handle));
		if (zero == IntPtr.Zero)
		{
			return null;
		}
		return new CMClock(zero, flag);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	[Watch(6, 0)]
	private static extern IntPtr CMTimebaseCopyMasterTimebase(IntPtr timebase);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	[Watch(6, 0)]
	private static extern IntPtr CMTimebaseCopyMasterClock(IntPtr timebase);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	[Watch(6, 0)]
	private static extern IntPtr CMTimebaseCopyMaster(IntPtr timebase);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	[Watch(6, 0)]
	private static extern IntPtr CMTimebaseCopyUltimateMasterClock(IntPtr timebase);
}
