using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSAppleEventManager", true)]
public class NSAppleEventManager : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppleEventForSuspensionID_ = "appleEventForSuspensionID:";

	private static readonly IntPtr selAppleEventForSuspensionID_Handle = Selector.GetHandle("appleEventForSuspensionID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentAppleEvent = "currentAppleEvent";

	private static readonly IntPtr selCurrentAppleEventHandle = Selector.GetHandle("currentAppleEvent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentReplyAppleEvent = "currentReplyAppleEvent";

	private static readonly IntPtr selCurrentReplyAppleEventHandle = Selector.GetHandle("currentReplyAppleEvent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveEventHandlerForEventClass_AndEventID_ = "removeEventHandlerForEventClass:andEventID:";

	private static readonly IntPtr selRemoveEventHandlerForEventClass_AndEventID_Handle = Selector.GetHandle("removeEventHandlerForEventClass:andEventID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplyAppleEventForSuspensionID_ = "replyAppleEventForSuspensionID:";

	private static readonly IntPtr selReplyAppleEventForSuspensionID_Handle = Selector.GetHandle("replyAppleEventForSuspensionID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResumeWithSuspensionID_ = "resumeWithSuspensionID:";

	private static readonly IntPtr selResumeWithSuspensionID_Handle = Selector.GetHandle("resumeWithSuspensionID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentAppleEventAndReplyEventWithSuspensionID_ = "setCurrentAppleEventAndReplyEventWithSuspensionID:";

	private static readonly IntPtr selSetCurrentAppleEventAndReplyEventWithSuspensionID_Handle = Selector.GetHandle("setCurrentAppleEventAndReplyEventWithSuspensionID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEventHandler_AndSelector_ForEventClass_AndEventID_ = "setEventHandler:andSelector:forEventClass:andEventID:";

	private static readonly IntPtr selSetEventHandler_AndSelector_ForEventClass_AndEventID_Handle = Selector.GetHandle("setEventHandler:andSelector:forEventClass:andEventID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedAppleEventManager = "sharedAppleEventManager";

	private static readonly IntPtr selSharedAppleEventManagerHandle = Selector.GetHandle("sharedAppleEventManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuspendCurrentAppleEvent = "suspendCurrentAppleEvent";

	private static readonly IntPtr selSuspendCurrentAppleEventHandle = Selector.GetHandle("suspendCurrentAppleEvent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAppleEventManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor CurrentAppleEvent
	{
		[Export("currentAppleEvent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentAppleEventHandle));
			}
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentAppleEventHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor CurrentReplyAppleEvent
	{
		[Export("currentReplyAppleEvent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentReplyAppleEventHandle));
			}
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentReplyAppleEventHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventManager SharedAppleEventManager
	{
		[Export("sharedAppleEventManager")]
		get
		{
			return Runtime.GetNSObject<NSAppleEventManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedAppleEventManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAppleEventManager()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSAppleEventManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAppleEventManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("appleEventForSuspensionID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor AppleEventForSuspensionID(IntPtr suspensionID)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAppleEventForSuspensionID_Handle, suspensionID));
		}
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppleEventForSuspensionID_Handle, suspensionID));
	}

	[Export("removeEventHandlerForEventClass:andEventID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveEventHandler(AEEventClass eventClass, AEEventID eventID)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_UInt32(base.Handle, selRemoveEventHandlerForEventClass_AndEventID_Handle, (uint)eventClass, (uint)eventID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_UInt32(base.SuperHandle, selRemoveEventHandlerForEventClass_AndEventID_Handle, (uint)eventClass, (uint)eventID);
		}
	}

	[Export("replyAppleEventForSuspensionID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor ReplyAppleEventForSuspensionID(IntPtr suspensionID)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReplyAppleEventForSuspensionID_Handle, suspensionID));
		}
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplyAppleEventForSuspensionID_Handle, suspensionID));
	}

	[Export("resumeWithSuspensionID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResumeWithSuspensionID(IntPtr suspensionID)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResumeWithSuspensionID_Handle, suspensionID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResumeWithSuspensionID_Handle, suspensionID);
		}
	}

	[Export("setCurrentAppleEventAndReplyEventWithSuspensionID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCurrentAppleEventAndReplyEventWithSuspensionID(IntPtr suspensionID)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentAppleEventAndReplyEventWithSuspensionID_Handle, suspensionID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentAppleEventAndReplyEventWithSuspensionID_Handle, suspensionID);
		}
	}

	[Export("setEventHandler:andSelector:forEventClass:andEventID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetEventHandler(NSObject handler, Selector handleEventSelector, AEEventClass eventClass, AEEventID eventID)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (handleEventSelector == null)
		{
			throw new ArgumentNullException("handleEventSelector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32(base.Handle, selSetEventHandler_AndSelector_ForEventClass_AndEventID_Handle, handler.Handle, handleEventSelector.Handle, (uint)eventClass, (uint)eventID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_UInt32(base.SuperHandle, selSetEventHandler_AndSelector_ForEventClass_AndEventID_Handle, handler.Handle, handleEventSelector.Handle, (uint)eventClass, (uint)eventID);
		}
	}

	[Export("suspendCurrentAppleEvent")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr SuspendCurrentAppleEvent()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selSuspendCurrentAppleEventHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuspendCurrentAppleEventHandle);
	}
}
