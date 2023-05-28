using System;
using System.ComponentModel;
using CoreFoundation;
using ObjCRuntime;

namespace Foundation;

[Register("NSRunLoop", true)]
public class NSRunLoop : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptInputForMode_BeforeDate_ = "acceptInputForMode:beforeDate:";

	private static readonly IntPtr selAcceptInputForMode_BeforeDate_Handle = Selector.GetHandle("acceptInputForMode:beforeDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTimer_ForMode_ = "addTimer:forMode:";

	private static readonly IntPtr selAddTimer_ForMode_Handle = Selector.GetHandle("addTimer:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentMode = "currentMode";

	private static readonly IntPtr selCurrentModeHandle = Selector.GetHandle("currentMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentRunLoop = "currentRunLoop";

	private static readonly IntPtr selCurrentRunLoopHandle = Selector.GetHandle("currentRunLoop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCFRunLoop = "getCFRunLoop";

	private static readonly IntPtr selGetCFRunLoopHandle = Selector.GetHandle("getCFRunLoop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLimitDateForMode_ = "limitDateForMode:";

	private static readonly IntPtr selLimitDateForMode_Handle = Selector.GetHandle("limitDateForMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainRunLoop = "mainRunLoop";

	private static readonly IntPtr selMainRunLoopHandle = Selector.GetHandle("mainRunLoop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformBlock_ = "performBlock:";

	private static readonly IntPtr selPerformBlock_Handle = Selector.GetHandle("performBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformInModes_Block_ = "performInModes:block:";

	private static readonly IntPtr selPerformInModes_Block_Handle = Selector.GetHandle("performInModes:block:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRun = "run";

	private static readonly IntPtr selRunHandle = Selector.GetHandle("run");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunMode_BeforeDate_ = "runMode:beforeDate:";

	private static readonly IntPtr selRunMode_BeforeDate_Handle = Selector.GetHandle("runMode:beforeDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunUntilDate_ = "runUntilDate:";

	private static readonly IntPtr selRunUntilDate_Handle = Selector.GetHandle("runUntilDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSRunLoop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSDefaultRunLoopMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSRunLoopCommonModes;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSRunLoopConnectionReplyMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSRunLoopEventTracking;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSRunLoopModalPanelMode;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRunLoop Current
	{
		[Export("currentRunLoop", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSRunLoop>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentRunLoopHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString CurrentMode
	{
		[Export("currentMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentModeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentModeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRunLoopMode CurrentRunLoopMode => NSRunLoopModeExtensions.GetValue(CurrentMode);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRunLoop Main
	{
		[Export("mainRunLoop", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSRunLoop>(Messaging.IntPtr_objc_msgSend(class_ptr, selMainRunLoopHandle));
		}
	}

	[Field("NSDefaultRunLoopMode", "Foundation")]
	public static NSString NSDefaultRunLoopMode
	{
		get
		{
			if (_NSDefaultRunLoopMode == null)
			{
				_NSDefaultRunLoopMode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSDefaultRunLoopMode");
			}
			return _NSDefaultRunLoopMode;
		}
	}

	[Field("NSRunLoopCommonModes", "Foundation")]
	public static NSString NSRunLoopCommonModes
	{
		get
		{
			if (_NSRunLoopCommonModes == null)
			{
				_NSRunLoopCommonModes = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSRunLoopCommonModes");
			}
			return _NSRunLoopCommonModes;
		}
	}

	[Field("NSConnectionReplyMode", "Foundation")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSXpcConnection' instead.")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString NSRunLoopConnectionReplyMode
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSXpcConnection' instead.")]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_NSRunLoopConnectionReplyMode == null)
			{
				_NSRunLoopConnectionReplyMode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSConnectionReplyMode");
			}
			return _NSRunLoopConnectionReplyMode;
		}
	}

	[Field("NSEventTrackingRunLoopMode", "AppKit")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString NSRunLoopEventTracking
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_NSRunLoopEventTracking == null)
			{
				_NSRunLoopEventTracking = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSEventTrackingRunLoopMode");
			}
			return _NSRunLoopEventTracking;
		}
	}

	[Field("NSModalPanelRunLoopMode", "AppKit")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString NSRunLoopModalPanelMode
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_NSRunLoopModalPanelMode == null)
			{
				_NSRunLoopModalPanelMode = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSModalPanelRunLoopMode");
			}
			return _NSRunLoopModalPanelMode;
		}
	}

	public void Stop()
	{
		GetCFRunLoop().Stop();
	}

	public void WakeUp()
	{
		GetCFRunLoop().WakeUp();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSRunLoop(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRunLoop(IntPtr handle)
		: base(handle)
	{
	}

	[Export("acceptInputForMode:beforeDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AcceptInputForMode(NSString mode, NSDate limitDate)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		if (limitDate == null)
		{
			throw new ArgumentNullException("limitDate");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAcceptInputForMode_BeforeDate_Handle, mode.Handle, limitDate.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAcceptInputForMode_BeforeDate_Handle, mode.Handle, limitDate.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AcceptInputForMode(NSRunLoopMode mode, NSDate limitDate)
	{
		AcceptInputForMode(mode.GetConstant(), limitDate);
	}

	[Export("addTimer:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTimer(NSTimer timer, NSString forMode)
	{
		if (timer == null)
		{
			throw new ArgumentNullException("timer");
		}
		if (forMode == null)
		{
			throw new ArgumentNullException("forMode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddTimer_ForMode_Handle, timer.Handle, forMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddTimer_ForMode_Handle, timer.Handle, forMode.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AddTimer(NSTimer timer, NSRunLoopMode forMode)
	{
		AddTimer(timer, forMode.GetConstant());
	}

	[Export("getCFRunLoop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CFRunLoop GetCFRunLoop()
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGetCFRunLoopHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selGetCFRunLoopHandle));
		return (intPtr == IntPtr.Zero) ? null : new CFRunLoop(intPtr);
	}

	[Export("limitDateForMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate LimitDateForMode(NSString mode)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLimitDateForMode_Handle, mode.Handle));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLimitDateForMode_Handle, mode.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDate LimitDateForMode(NSRunLoopMode mode)
	{
		return LimitDateForMode(mode.GetConstant());
	}

	[Export("performBlock:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Perform([BlockProxy(typeof(Trampolines.NIDAction))] Action block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("performInModes:block:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Perform(NSString[] modes, [BlockProxy(typeof(Trampolines.NIDAction))] Action block)
	{
		if (modes == null)
		{
			throw new ArgumentNullException("modes");
		}
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		NSArray nSArray = NSArray.FromNSObjects(modes);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPerformInModes_Block_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPerformInModes_Block_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Perform(NSRunLoopMode[] modes, [BlockProxy(typeof(Trampolines.NIDAction))] Action block)
	{
		Perform(modes.GetConstants(), block);
	}

	[Export("run")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Run()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRunHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRunHandle);
		}
	}

	[Export("runUntilDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunUntil(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRunUntilDate_Handle, date.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunUntilDate_Handle, date.Handle);
		}
	}

	[Export("runMode:beforeDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RunUntil(NSString runLoopMode, NSDate limitdate)
	{
		if (runLoopMode == null)
		{
			throw new ArgumentNullException("runLoopMode");
		}
		if (limitdate == null)
		{
			throw new ArgumentNullException("limitdate");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRunMode_BeforeDate_Handle, runLoopMode.Handle, limitdate.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRunMode_BeforeDate_Handle, runLoopMode.Handle, limitdate.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool RunUntil(NSRunLoopMode runLoopMode, NSDate limitDate)
	{
		return RunUntil(runLoopMode.GetConstant(), limitDate);
	}
}
