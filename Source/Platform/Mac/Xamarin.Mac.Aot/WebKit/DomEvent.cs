using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMEvent", true)]
public class DomEvent : DomObject
{
	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	private static readonly IntPtr selCurrentTargetHandle = Selector.GetHandle("currentTarget");

	private static readonly IntPtr selEventPhaseHandle = Selector.GetHandle("eventPhase");

	private static readonly IntPtr selBubblesHandle = Selector.GetHandle("bubbles");

	private static readonly IntPtr selCancelableHandle = Selector.GetHandle("cancelable");

	private static readonly IntPtr selTimeStampHandle = Selector.GetHandle("timeStamp");

	private static readonly IntPtr selSrcElementHandle = Selector.GetHandle("srcElement");

	private static readonly IntPtr selReturnValueHandle = Selector.GetHandle("returnValue");

	private static readonly IntPtr selSetReturnValue_Handle = Selector.GetHandle("setReturnValue:");

	private static readonly IntPtr selCancelBubbleHandle = Selector.GetHandle("cancelBubble");

	private static readonly IntPtr selSetCancelBubble_Handle = Selector.GetHandle("setCancelBubble:");

	private static readonly IntPtr selStopPropagationHandle = Selector.GetHandle("stopPropagation");

	private static readonly IntPtr selPreventDefaultHandle = Selector.GetHandle("preventDefault");

	private static readonly IntPtr selInitEventCanBubbleArgCancelableArg_Handle = Selector.GetHandle("initEvent:canBubbleArg:cancelableArg:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMEvent");

	private object __mt_Target_var;

	private object __mt_CurrentTarget_var;

	private object __mt_SourceElement_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Type
	{
		[Export("type")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	public virtual NSObject Target
	{
		[Export("target")]
		get
		{
			return (NSObject)(__mt_Target_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle))));
		}
	}

	public virtual NSObject CurrentTarget
	{
		[Export("currentTarget")]
		get
		{
			return (NSObject)(__mt_CurrentTarget_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentTargetHandle))));
		}
	}

	public virtual DomEventPhase EventPhase
	{
		[Export("eventPhase")]
		get
		{
			if (IsDirectBinding)
			{
				return (DomEventPhase)Messaging.UInt16_objc_msgSend(base.Handle, selEventPhaseHandle);
			}
			return (DomEventPhase)Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selEventPhaseHandle);
		}
	}

	public virtual bool Bubbles
	{
		[Export("bubbles")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBubblesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBubblesHandle);
		}
	}

	public virtual bool Cancelable
	{
		[Export("cancelable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCancelableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCancelableHandle);
		}
	}

	public virtual ulong TimeStamp
	{
		[Export("timeStamp")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selTimeStampHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTimeStampHandle);
		}
	}

	public virtual NSObject SourceElement
	{
		[Export("srcElement")]
		get
		{
			return (NSObject)(__mt_SourceElement_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSrcElementHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSrcElementHandle))));
		}
	}

	public virtual bool ReturnValue
	{
		[Export("returnValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReturnValueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReturnValueHandle);
		}
		[Export("setReturnValue:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReturnValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReturnValue_Handle, value);
			}
		}
	}

	public virtual bool CancelBubble
	{
		[Export("cancelBubble")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCancelBubbleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCancelBubbleHandle);
		}
		[Export("setCancelBubble:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCancelBubble_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCancelBubble_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomEvent(NSCoder coder)
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
	public DomEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomEvent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("stopPropagation")]
	public virtual void StopPropagation()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopPropagationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopPropagationHandle);
		}
	}

	[Export("preventDefault")]
	public virtual void PreventDefault()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPreventDefaultHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPreventDefaultHandle);
		}
	}

	[Export("initEvent:canBubbleArg:cancelableArg:")]
	public virtual void InitEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg)
	{
		if (eventTypeArg == null)
		{
			throw new ArgumentNullException("eventTypeArg");
		}
		IntPtr arg = NSString.CreateNative(eventTypeArg);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_bool(base.Handle, selInitEventCanBubbleArgCancelableArg_Handle, arg, canBubbleArg, cancelableArg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_bool(base.SuperHandle, selInitEventCanBubbleArgCancelableArg_Handle, arg, canBubbleArg, cancelableArg);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Target_var = null;
			__mt_CurrentTarget_var = null;
			__mt_SourceElement_var = null;
		}
	}
}
