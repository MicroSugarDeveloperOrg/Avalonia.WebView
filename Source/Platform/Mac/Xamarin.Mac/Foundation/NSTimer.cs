using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSTimer", true)]
public class NSTimer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFire = "fire";

	private static readonly IntPtr selFireHandle = Selector.GetHandle("fire");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFireDate = "fireDate";

	private static readonly IntPtr selFireDateHandle = Selector.GetHandle("fireDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFireDate_Interval_Repeats_Block_ = "initWithFireDate:interval:repeats:block:";

	private static readonly IntPtr selInitWithFireDate_Interval_Repeats_Block_Handle = Selector.GetHandle("initWithFireDate:interval:repeats:block:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFireDate_Interval_Target_Selector_UserInfo_Repeats_ = "initWithFireDate:interval:target:selector:userInfo:repeats:";

	private static readonly IntPtr selInitWithFireDate_Interval_Target_Selector_UserInfo_Repeats_Handle = Selector.GetHandle("initWithFireDate:interval:target:selector:userInfo:repeats:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidate = "invalidate";

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsValid = "isValid";

	private static readonly IntPtr selIsValidHandle = Selector.GetHandle("isValid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduledTimerWithTimeInterval_Repeats_Block_ = "scheduledTimerWithTimeInterval:repeats:block:";

	private static readonly IntPtr selScheduledTimerWithTimeInterval_Repeats_Block_Handle = Selector.GetHandle("scheduledTimerWithTimeInterval:repeats:block:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduledTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_ = "scheduledTimerWithTimeInterval:target:selector:userInfo:repeats:";

	private static readonly IntPtr selScheduledTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_Handle = Selector.GetHandle("scheduledTimerWithTimeInterval:target:selector:userInfo:repeats:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFireDate_ = "setFireDate:";

	private static readonly IntPtr selSetFireDate_Handle = Selector.GetHandle("setFireDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTolerance_ = "setTolerance:";

	private static readonly IntPtr selSetTolerance_Handle = Selector.GetHandle("setTolerance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeInterval = "timeInterval";

	private static readonly IntPtr selTimeIntervalHandle = Selector.GetHandle("timeInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimerWithTimeInterval_Repeats_Block_ = "timerWithTimeInterval:repeats:block:";

	private static readonly IntPtr selTimerWithTimeInterval_Repeats_Block_Handle = Selector.GetHandle("timerWithTimeInterval:repeats:block:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_ = "timerWithTimeInterval:target:selector:userInfo:repeats:";

	private static readonly IntPtr selTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_Handle = Selector.GetHandle("timerWithTimeInterval:target:selector:userInfo:repeats:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTolerance = "tolerance";

	private static readonly IntPtr selToleranceHandle = Selector.GetHandle("tolerance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInfo = "userInfo";

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTimer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? FireDate
	{
		[Export("fireDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selFireDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFireDateHandle));
		}
		[Export("setFireDate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFireDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFireDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValid
	{
		[Export("isValid")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsValidHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsValidHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeInterval
	{
		[Export("timeInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeIntervalHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual double Tolerance
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("tolerance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selToleranceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selToleranceHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setTolerance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTolerance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTolerance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject UserInfo
	{
		[Export("userInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle));
		}
	}

	public static NSTimer CreateRepeatingScheduledTimer(TimeSpan when, Action<NSTimer> action)
	{
		return CreateScheduledTimer(when.TotalSeconds, new NSTimerActionDispatcher(action), NSTimerActionDispatcher.Selector, null, repeats: true);
	}

	public static NSTimer CreateRepeatingScheduledTimer(double seconds, Action<NSTimer> action)
	{
		return CreateScheduledTimer(seconds, new NSTimerActionDispatcher(action), NSTimerActionDispatcher.Selector, null, repeats: true);
	}

	public static NSTimer CreateScheduledTimer(TimeSpan when, Action<NSTimer> action)
	{
		return CreateScheduledTimer(when.TotalSeconds, new NSTimerActionDispatcher(action), NSTimerActionDispatcher.Selector, null, repeats: false);
	}

	public static NSTimer CreateScheduledTimer(double seconds, Action<NSTimer> action)
	{
		return CreateScheduledTimer(seconds, new NSTimerActionDispatcher(action), NSTimerActionDispatcher.Selector, null, repeats: false);
	}

	public static NSTimer CreateRepeatingTimer(TimeSpan when, Action<NSTimer> action)
	{
		return CreateTimer(when.TotalSeconds, new NSTimerActionDispatcher(action), NSTimerActionDispatcher.Selector, null, repeats: true);
	}

	public static NSTimer CreateRepeatingTimer(double seconds, Action<NSTimer> action)
	{
		return CreateTimer(seconds, new NSTimerActionDispatcher(action), NSTimerActionDispatcher.Selector, null, repeats: true);
	}

	public static NSTimer CreateTimer(TimeSpan when, Action<NSTimer> action)
	{
		return CreateTimer(when.TotalSeconds, new NSTimerActionDispatcher(action), NSTimerActionDispatcher.Selector, null, repeats: false);
	}

	public static NSTimer CreateTimer(double seconds, Action<NSTimer> action)
	{
		return CreateTimer(seconds, new NSTimerActionDispatcher(action), NSTimerActionDispatcher.Selector, null, repeats: false);
	}

	public NSTimer(NSDate date, TimeSpan when, Action<NSTimer> action, bool repeats)
		: this(date, when.TotalSeconds, new NSTimerActionDispatcher(action), NSTimerActionDispatcher.Selector, null, repeats)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTimer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTimer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFireDate:interval:target:selector:userInfo:repeats:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTimer(NSDate date, double seconds, NSObject target, Selector selector, NSObject? userInfo, bool repeats)
		: base(NSObjectFlag.Empty)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithFireDate_Interval_Target_Selector_UserInfo_Repeats_Handle, date.Handle, seconds, target.Handle, selector.Handle, userInfo?.Handle ?? IntPtr.Zero, repeats), "initWithFireDate:interval:target:selector:userInfo:repeats:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithFireDate_Interval_Target_Selector_UserInfo_Repeats_Handle, date.Handle, seconds, target.Handle, selector.Handle, userInfo?.Handle ?? IntPtr.Zero, repeats), "initWithFireDate:interval:target:selector:userInfo:repeats:");
		}
	}

	[Export("initWithFireDate:interval:repeats:block:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSTimer(NSDate date, double seconds, bool repeats, [BlockProxy(typeof(Trampolines.NIDActionArity1V34))] Action<NSTimer> block)
		: base(NSObjectFlag.Empty)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V34.Handler, block);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Double_bool_IntPtr(base.Handle, selInitWithFireDate_Interval_Repeats_Block_Handle, date.Handle, seconds, repeats, (IntPtr)ptr), "initWithFireDate:interval:repeats:block:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double_bool_IntPtr(base.SuperHandle, selInitWithFireDate_Interval_Repeats_Block_Handle, date.Handle, seconds, repeats, (IntPtr)ptr), "initWithFireDate:interval:repeats:block:");
		}
		ptr->CleanupBlock();
	}

	[Export("scheduledTimerWithTimeInterval:target:selector:userInfo:repeats:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTimer CreateScheduledTimer(double seconds, NSObject target, Selector selector, NSObject? userInfo, bool repeats)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return Runtime.GetNSObject<NSTimer>(Messaging.IntPtr_objc_msgSend_Double_IntPtr_IntPtr_IntPtr_bool(class_ptr, selScheduledTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_Handle, seconds, target.Handle, selector.Handle, userInfo?.Handle ?? IntPtr.Zero, repeats));
	}

	[Export("scheduledTimerWithTimeInterval:repeats:block:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSTimer CreateScheduledTimer(double interval, bool repeats, [BlockProxy(typeof(Trampolines.NIDActionArity1V34))] Action<NSTimer> block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V34.Handler, block);
		NSTimer nSObject = Runtime.GetNSObject<NSTimer>(Messaging.IntPtr_objc_msgSend_Double_bool_IntPtr(class_ptr, selScheduledTimerWithTimeInterval_Repeats_Block_Handle, interval, repeats, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("timerWithTimeInterval:target:selector:userInfo:repeats:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTimer CreateTimer(double seconds, NSObject target, Selector selector, NSObject? userInfo, bool repeats)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return Runtime.GetNSObject<NSTimer>(Messaging.IntPtr_objc_msgSend_Double_IntPtr_IntPtr_IntPtr_bool(class_ptr, selTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_Handle, seconds, target.Handle, selector.Handle, userInfo?.Handle ?? IntPtr.Zero, repeats));
	}

	[Export("timerWithTimeInterval:repeats:block:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSTimer CreateTimer(double interval, bool repeats, [BlockProxy(typeof(Trampolines.NIDActionArity1V34))] Action<NSTimer> block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V34.Handler, block);
		NSTimer nSObject = Runtime.GetNSObject<NSTimer>(Messaging.IntPtr_objc_msgSend_Double_bool_IntPtr(class_ptr, selTimerWithTimeInterval_Repeats_Block_Handle, interval, repeats, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("fire")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Fire()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFireHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFireHandle);
		}
	}

	[Export("invalidate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invalidate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Invalidate();
		}
		base.Dispose(disposing);
	}
}
