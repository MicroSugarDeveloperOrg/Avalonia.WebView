using System;
using System.ComponentModel;
using CoreFoundation;
using ObjCRuntime;

namespace Foundation;

[Register("NSRunLoop", true)]
public class NSRunLoop : NSObject
{
	private static readonly IntPtr selCurrentRunLoopHandle = Selector.GetHandle("currentRunLoop");

	private static readonly IntPtr selMainRunLoopHandle = Selector.GetHandle("mainRunLoop");

	private static readonly IntPtr selCurrentModeHandle = Selector.GetHandle("currentMode");

	private static readonly IntPtr selGetCFRunLoopHandle = Selector.GetHandle("getCFRunLoop");

	private static readonly IntPtr selAddTimerForMode_Handle = Selector.GetHandle("addTimer:forMode:");

	private static readonly IntPtr selLimitDateForMode_Handle = Selector.GetHandle("limitDateForMode:");

	private static readonly IntPtr selAcceptInputForModeBeforeDate_Handle = Selector.GetHandle("acceptInputForMode:beforeDate:");

	private static readonly IntPtr selRunHandle = Selector.GetHandle("run");

	private static readonly IntPtr selRunUntilDate_Handle = Selector.GetHandle("runUntilDate:");

	private static readonly IntPtr selRunModeBeforeDate_Handle = Selector.GetHandle("runMode:beforeDate:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSRunLoop");

	[ThreadStatic]
	private static object __mt_Current_var_static;

	private static object __mt_Main_var_static;

	private object __mt_CurrentMode_var;

	private static NSString _NSDefaultRunLoopMode;

	private static NSString _NSRunLoopCommonModes;

	private static NSString _NSRunLoopConnectionReplyMode;

	private static NSString _NSRunLoopModalPanelMode;

	private static NSString _NSRunLoopEventTracking;

	public NSRunLoopMode CurrentRunLoopMode
	{
		get
		{
			NSString currentMode = CurrentMode;
			if (currentMode == NSDefaultRunLoopMode)
			{
				return NSRunLoopMode.Default;
			}
			if (currentMode == NSRunLoopCommonModes)
			{
				return NSRunLoopMode.Common;
			}
			if (currentMode == NSRunLoopConnectionReplyMode)
			{
				return NSRunLoopMode.ConnectionReply;
			}
			if (currentMode == NSRunLoopModalPanelMode)
			{
				return NSRunLoopMode.ModalPanel;
			}
			if (currentMode == NSRunLoopEventTracking)
			{
				return NSRunLoopMode.EventTracking;
			}
			return NSRunLoopMode.Other;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public static NSRunLoop Current
	{
		[Export("currentRunLoop")]
		get
		{
			return (NSRunLoop)(__mt_Current_var_static = (NSRunLoop)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentRunLoopHandle)));
		}
	}

	public static NSRunLoop Main
	{
		[Export("mainRunLoop")]
		get
		{
			return (NSRunLoop)(__mt_Main_var_static = (NSRunLoop)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMainRunLoopHandle)));
		}
	}

	public virtual NSString CurrentMode
	{
		[Export("currentMode")]
		get
		{
			return (NSString)(__mt_CurrentMode_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentModeHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentModeHandle)))));
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
	public static NSString NSRunLoopConnectionReplyMode
	{
		get
		{
			if (_NSRunLoopConnectionReplyMode == null)
			{
				_NSRunLoopConnectionReplyMode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSConnectionReplyMode");
			}
			return _NSRunLoopConnectionReplyMode;
		}
	}

	[Field("NSModalPanelRunLoopMode", "AppKit")]
	public static NSString NSRunLoopModalPanelMode
	{
		get
		{
			if (_NSRunLoopModalPanelMode == null)
			{
				_NSRunLoopModalPanelMode = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSModalPanelRunLoopMode");
			}
			return _NSRunLoopModalPanelMode;
		}
	}

	[Field("NSEventTrackingRunLoopMode", "AppKit")]
	public static NSString NSRunLoopEventTracking
	{
		get
		{
			if (_NSRunLoopEventTracking == null)
			{
				_NSRunLoopEventTracking = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSEventTrackingRunLoopMode");
			}
			return _NSRunLoopEventTracking;
		}
	}

	private static NSString GetRealMode(string mode)
	{
		if (mode == NSDefaultRunLoopMode)
		{
			return NSDefaultRunLoopMode;
		}
		if (mode == NSRunLoopCommonModes)
		{
			return NSRunLoopCommonModes;
		}
		return new NSString(mode);
	}

	private static NSString FromEnum(NSRunLoopMode mode)
	{
		return mode switch
		{
			NSRunLoopMode.Common => NSRunLoopCommonModes, 
			NSRunLoopMode.ConnectionReply => NSRunLoopConnectionReplyMode, 
			NSRunLoopMode.ModalPanel => NSRunLoopModalPanelMode, 
			NSRunLoopMode.EventTracking => NSRunLoopEventTracking, 
			_ => NSDefaultRunLoopMode, 
		};
	}

	[Advice("Use AddTimer (NSTimer, NSRunLoopMode)")]
	public void AddTimer(NSTimer timer, string forMode)
	{
		AddTimer(timer, GetRealMode(forMode));
	}

	public void AddTimer(NSTimer timer, NSRunLoopMode forMode)
	{
		AddTimer(timer, FromEnum(forMode));
	}

	[Advice("Use LimitDateForMode (NSRunLoopMode) instead")]
	public NSDate LimitDateForMode(string mode)
	{
		return LimitDateForMode(GetRealMode(mode));
	}

	public NSDate LimitDateForMode(NSRunLoopMode mode)
	{
		return LimitDateForMode(FromEnum(mode));
	}

	[Advice("Use AcceptInputForMode (NSRunLoopMode, NSDate)")]
	public void AcceptInputForMode(string mode, NSDate limitDate)
	{
		AcceptInputForMode(GetRealMode(mode), limitDate);
	}

	public void AcceptInputForMode(NSRunLoopMode mode, NSDate limitDate)
	{
		AcceptInputForMode(FromEnum(mode), limitDate);
	}

	public void Stop()
	{
		GetCFRunLoop().Stop();
	}

	public void WakeUp()
	{
		GetCFRunLoop().WakeUp();
	}

	public bool RunUntil(NSRunLoopMode mode, NSDate limitDate)
	{
		return RunUntil(FromEnum(mode), limitDate);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSRunLoop(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRunLoop(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRunLoop(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getCFRunLoop")]
	public virtual CFRunLoop GetCFRunLoop()
	{
		if (IsDirectBinding)
		{
			return new CFRunLoop(Messaging.IntPtr_objc_msgSend(base.Handle, selGetCFRunLoopHandle));
		}
		return new CFRunLoop(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGetCFRunLoopHandle));
	}

	[Export("addTimer:forMode:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddTimerForMode_Handle, timer.Handle, forMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddTimerForMode_Handle, timer.Handle, forMode.Handle);
		}
	}

	[Export("limitDateForMode:")]
	public virtual NSDate LimitDateForMode(NSString mode)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		if (IsDirectBinding)
		{
			return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLimitDateForMode_Handle, mode.Handle));
		}
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLimitDateForMode_Handle, mode.Handle));
	}

	[Export("acceptInputForMode:beforeDate:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAcceptInputForModeBeforeDate_Handle, mode.Handle, limitDate.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAcceptInputForModeBeforeDate_Handle, mode.Handle, limitDate.Handle);
		}
	}

	[Export("run")]
	public virtual void Run()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRunHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRunHandle);
		}
	}

	[Export("runUntilDate:")]
	public virtual void RunUntil(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRunUntilDate_Handle, date.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunUntilDate_Handle, date.Handle);
		}
	}

	[Export("runMode:beforeDate:")]
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
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRunModeBeforeDate_Handle, runLoopMode.Handle, limitdate.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRunModeBeforeDate_Handle, runLoopMode.Handle, limitdate.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CurrentMode_var = null;
		}
	}
}
