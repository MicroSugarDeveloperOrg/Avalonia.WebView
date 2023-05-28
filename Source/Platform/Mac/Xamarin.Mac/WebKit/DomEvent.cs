using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMEvent", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomEvent : DomObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBubbles = "bubbles";

	private static readonly IntPtr selBubblesHandle = Selector.GetHandle("bubbles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelBubble = "cancelBubble";

	private static readonly IntPtr selCancelBubbleHandle = Selector.GetHandle("cancelBubble");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelable = "cancelable";

	private static readonly IntPtr selCancelableHandle = Selector.GetHandle("cancelable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTarget = "currentTarget";

	private static readonly IntPtr selCurrentTargetHandle = Selector.GetHandle("currentTarget");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEventPhase = "eventPhase";

	private static readonly IntPtr selEventPhaseHandle = Selector.GetHandle("eventPhase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitEvent_CanBubbleArg_CancelableArg_ = "initEvent:canBubbleArg:cancelableArg:";

	private static readonly IntPtr selInitEvent_CanBubbleArg_CancelableArg_Handle = Selector.GetHandle("initEvent:canBubbleArg:cancelableArg:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreventDefault = "preventDefault";

	private static readonly IntPtr selPreventDefaultHandle = Selector.GetHandle("preventDefault");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReturnValue = "returnValue";

	private static readonly IntPtr selReturnValueHandle = Selector.GetHandle("returnValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCancelBubble_ = "setCancelBubble:";

	private static readonly IntPtr selSetCancelBubble_Handle = Selector.GetHandle("setCancelBubble:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReturnValue_ = "setReturnValue:";

	private static readonly IntPtr selSetReturnValue_Handle = Selector.GetHandle("setReturnValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSrcElement = "srcElement";

	private static readonly IntPtr selSrcElementHandle = Selector.GetHandle("srcElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopPropagation = "stopPropagation";

	private static readonly IntPtr selStopPropagationHandle = Selector.GetHandle("stopPropagation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeStamp = "timeStamp";

	private static readonly IntPtr selTimeStampHandle = Selector.GetHandle("timeStamp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Bubbles
	{
		[Export("bubbles")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBubblesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBubblesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CancelBubble
	{
		[Export("cancelBubble")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCancelBubbleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCancelBubbleHandle);
		}
		[Export("setCancelBubble:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCancelBubble_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCancelBubble_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Cancelable
	{
		[Export("cancelable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCancelableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCancelableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IDomEventTarget CurrentTarget
	{
		[Export("currentTarget", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IDomEventTarget>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentTargetHandle), owns: false);
			}
			return Runtime.GetINativeObject<IDomEventTarget>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentTargetHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomEventPhase EventPhase
	{
		[Export("eventPhase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (DomEventPhase)Messaging.UInt16_objc_msgSend(base.Handle, selEventPhaseHandle);
			}
			return (DomEventPhase)Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selEventPhaseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReturnValue
	{
		[Export("returnValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReturnValueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReturnValueHandle);
		}
		[Export("setReturnValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReturnValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReturnValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IDomEventTarget SourceElement
	{
		[Export("srcElement", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IDomEventTarget>(Messaging.IntPtr_objc_msgSend(base.Handle, selSrcElementHandle), owns: false);
			}
			return Runtime.GetINativeObject<IDomEventTarget>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSrcElementHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IDomEventTarget Target
	{
		[Export("target", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IDomEventTarget>(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle), owns: false);
			}
			return Runtime.GetINativeObject<IDomEventTarget>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong TimeStamp
	{
		[Export("timeStamp")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selTimeStampHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTimeStampHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Type
	{
		[Export("type", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomEvent(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public DomEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg)
		: base(NSObjectFlag.Empty)
	{
		if (eventTypeArg == null)
		{
			throw new ArgumentNullException("eventTypeArg");
		}
		IntPtr arg = NSString.CreateNative(eventTypeArg);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool(base.Handle, selInitEvent_CanBubbleArg_CancelableArg_Handle, arg, canBubbleArg, cancelableArg), "initEvent:canBubbleArg:cancelableArg:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_bool(base.SuperHandle, selInitEvent_CanBubbleArg_CancelableArg_Handle, arg, canBubbleArg, cancelableArg), "initEvent:canBubbleArg:cancelableArg:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initEvent:canBubbleArg:cancelableArg:")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InitEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg)
	{
		if (eventTypeArg == null)
		{
			throw new ArgumentNullException("eventTypeArg");
		}
		IntPtr arg = NSString.CreateNative(eventTypeArg);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_bool(base.Handle, selInitEvent_CanBubbleArg_CancelableArg_Handle, arg, canBubbleArg, cancelableArg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_bool(base.SuperHandle, selInitEvent_CanBubbleArg_CancelableArg_Handle, arg, canBubbleArg, cancelableArg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("preventDefault")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PreventDefault()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPreventDefaultHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPreventDefaultHandle);
		}
	}

	[Export("stopPropagation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopPropagation()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopPropagationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopPropagationHandle);
		}
	}
}
