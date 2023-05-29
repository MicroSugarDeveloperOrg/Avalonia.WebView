using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSAppleEventManager", true)]
public class NSAppleEventManager : NSObject
{
	private static readonly IntPtr selSharedAppleEventManagerHandle = Selector.GetHandle("sharedAppleEventManager");

	private static readonly IntPtr selCurrentAppleEventHandle = Selector.GetHandle("currentAppleEvent");

	private static readonly IntPtr selCurrentReplyAppleEventHandle = Selector.GetHandle("currentReplyAppleEvent");

	private static readonly IntPtr selSetEventHandlerAndSelectorForEventClassAndEventID_Handle = Selector.GetHandle("setEventHandler:andSelector:forEventClass:andEventID:");

	private static readonly IntPtr selRemoveEventHandlerForEventClassAndEventID_Handle = Selector.GetHandle("removeEventHandlerForEventClass:andEventID:");

	private static readonly IntPtr selSuspendCurrentAppleEventHandle = Selector.GetHandle("suspendCurrentAppleEvent");

	private static readonly IntPtr selAppleEventForSuspensionID_Handle = Selector.GetHandle("appleEventForSuspensionID:");

	private static readonly IntPtr selReplyAppleEventForSuspensionID_Handle = Selector.GetHandle("replyAppleEventForSuspensionID:");

	private static readonly IntPtr selSetCurrentAppleEventAndReplyEventWithSuspensionID_Handle = Selector.GetHandle("setCurrentAppleEventAndReplyEventWithSuspensionID:");

	private static readonly IntPtr selResumeWithSuspensionID_Handle = Selector.GetHandle("resumeWithSuspensionID:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAppleEventManager");

	private static object __mt_SharedAppleEventManager_var_static;

	private object __mt_CurrentAppleEvent_var;

	private object __mt_CurrentReplyAppleEvent_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSAppleEventManager SharedAppleEventManager
	{
		[Export("sharedAppleEventManager")]
		get
		{
			return (NSAppleEventManager)(__mt_SharedAppleEventManager_var_static = (NSAppleEventManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedAppleEventManagerHandle)));
		}
	}

	public virtual NSAppleEventDescriptor CurrentAppleEvent
	{
		[Export("currentAppleEvent")]
		get
		{
			return (NSAppleEventDescriptor)(__mt_CurrentAppleEvent_var = ((!IsDirectBinding) ? ((NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentAppleEventHandle))) : ((NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentAppleEventHandle)))));
		}
	}

	public virtual NSAppleEventDescriptor CurrentReplyAppleEvent
	{
		[Export("currentReplyAppleEvent")]
		get
		{
			return (NSAppleEventDescriptor)(__mt_CurrentReplyAppleEvent_var = ((!IsDirectBinding) ? ((NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentReplyAppleEventHandle))) : ((NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentReplyAppleEventHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAppleEventManager()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSAppleEventManager(NSCoder coder)
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
	public NSAppleEventManager(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAppleEventManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setEventHandler:andSelector:forEventClass:andEventID:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32(base.Handle, selSetEventHandlerAndSelectorForEventClassAndEventID_Handle, handler.Handle, handleEventSelector.Handle, (uint)eventClass, (uint)eventID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_UInt32(base.SuperHandle, selSetEventHandlerAndSelectorForEventClassAndEventID_Handle, handler.Handle, handleEventSelector.Handle, (uint)eventClass, (uint)eventID);
		}
	}

	[Export("removeEventHandlerForEventClass:andEventID:")]
	public virtual void RemoveEventHandlerForEventClassandEventID(AEEventClass eventClass, AEEventID eventID)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_UInt32(base.Handle, selRemoveEventHandlerForEventClassAndEventID_Handle, (uint)eventClass, (uint)eventID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_UInt32(base.SuperHandle, selRemoveEventHandlerForEventClassAndEventID_Handle, (uint)eventClass, (uint)eventID);
		}
	}

	[Export("suspendCurrentAppleEvent")]
	public virtual IntPtr SuspendCurrentAppleEvent()
	{
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selSuspendCurrentAppleEventHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuspendCurrentAppleEventHandle);
	}

	[Export("appleEventForSuspensionID:")]
	public virtual NSAppleEventDescriptor AppleEventForSuspensionID(IntPtr suspensionID)
	{
		if (IsDirectBinding)
		{
			return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAppleEventForSuspensionID_Handle, suspensionID));
		}
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppleEventForSuspensionID_Handle, suspensionID));
	}

	[Export("replyAppleEventForSuspensionID:")]
	public virtual NSAppleEventDescriptor ReplyAppleEventForSuspensionID(IntPtr suspensionID)
	{
		if (IsDirectBinding)
		{
			return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReplyAppleEventForSuspensionID_Handle, suspensionID));
		}
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplyAppleEventForSuspensionID_Handle, suspensionID));
	}

	[Export("setCurrentAppleEventAndReplyEventWithSuspensionID:")]
	public virtual void SetCurrentAppleEventAndReplyEventWithSuspensionID(IntPtr suspensionID)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentAppleEventAndReplyEventWithSuspensionID_Handle, suspensionID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentAppleEventAndReplyEventWithSuspensionID_Handle, suspensionID);
		}
	}

	[Export("resumeWithSuspensionID:")]
	public virtual void ResumeWithSuspensionID(IntPtr suspensionID)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResumeWithSuspensionID_Handle, suspensionID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResumeWithSuspensionID_Handle, suspensionID);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CurrentAppleEvent_var = null;
			__mt_CurrentReplyAppleEvent_var = null;
		}
	}
}
