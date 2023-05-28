using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMMouseEvent", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomMouseEvent : DomUIEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAltKey = "altKey";

	private static readonly IntPtr selAltKeyHandle = Selector.GetHandle("altKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButton = "button";

	private static readonly IntPtr selButtonHandle = Selector.GetHandle("button");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClientX = "clientX";

	private static readonly IntPtr selClientXHandle = Selector.GetHandle("clientX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClientY = "clientY";

	private static readonly IntPtr selClientYHandle = Selector.GetHandle("clientY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCtrlKey = "ctrlKey";

	private static readonly IntPtr selCtrlKeyHandle = Selector.GetHandle("ctrlKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFromElement = "fromElement";

	private static readonly IntPtr selFromElementHandle = Selector.GetHandle("fromElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitMouseEvent_CanBubble_Cancelable_View_Detail_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Button_RelatedTarget_ = "initMouseEvent:canBubble:cancelable:view:detail:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:button:relatedTarget:";

	private static readonly IntPtr selInitMouseEvent_CanBubble_Cancelable_View_Detail_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Button_RelatedTarget_Handle = Selector.GetHandle("initMouseEvent:canBubble:cancelable:view:detail:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:button:relatedTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetaKey = "metaKey";

	private static readonly IntPtr selMetaKeyHandle = Selector.GetHandle("metaKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffsetX = "offsetX";

	private static readonly IntPtr selOffsetXHandle = Selector.GetHandle("offsetX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffsetY = "offsetY";

	private static readonly IntPtr selOffsetYHandle = Selector.GetHandle("offsetY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelatedTarget = "relatedTarget";

	private static readonly IntPtr selRelatedTargetHandle = Selector.GetHandle("relatedTarget");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreenX = "screenX";

	private static readonly IntPtr selScreenXHandle = Selector.GetHandle("screenX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreenY = "screenY";

	private static readonly IntPtr selScreenYHandle = Selector.GetHandle("screenY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShiftKey = "shiftKey";

	private static readonly IntPtr selShiftKeyHandle = Selector.GetHandle("shiftKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToElement = "toElement";

	private static readonly IntPtr selToElementHandle = Selector.GetHandle("toElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selX = "x";

	private static readonly IntPtr selXHandle = Selector.GetHandle("x");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selY = "y";

	private static readonly IntPtr selYHandle = Selector.GetHandle("y");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMMouseEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AltKey
	{
		[Export("altKey")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAltKeyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAltKeyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ushort Button
	{
		[Export("button")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt16_objc_msgSend(base.Handle, selButtonHandle);
			}
			return Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selButtonHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ClientX
	{
		[Export("clientX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientXHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ClientY
	{
		[Export("clientY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientYHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CtrlKey
	{
		[Export("ctrlKey")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCtrlKeyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCtrlKeyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode FromElement
	{
		[Export("fromElement", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selFromElementHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFromElementHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MetaKey
	{
		[Export("metaKey")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMetaKeyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMetaKeyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int OffsetX
	{
		[Export("offsetX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetXHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int OffsetY
	{
		[Export("offsetY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetYHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IDomEventTarget RelatedTarget
	{
		[Export("relatedTarget", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IDomEventTarget>(Messaging.IntPtr_objc_msgSend(base.Handle, selRelatedTargetHandle), owns: false);
			}
			return Runtime.GetINativeObject<IDomEventTarget>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelatedTargetHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ScreenX
	{
		[Export("screenX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScreenXHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScreenXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ScreenY
	{
		[Export("screenY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScreenYHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScreenYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShiftKey
	{
		[Export("shiftKey")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShiftKeyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShiftKeyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode ToElement
	{
		[Export("toElement", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selToElementHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToElementHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int X
	{
		[Export("x")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selXHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Y
	{
		[Export("y")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selYHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomMouseEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomMouseEvent(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public DomMouseEvent(string eventType, bool canBubble, bool cancelable, DomAbstractView view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, ushort button, IDomEventTarget relatedTarget)
		: base(NSObjectFlag.Empty)
	{
		if (eventType == null)
		{
			throw new ArgumentNullException("eventType");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (relatedTarget != null)
		{
			if (!(relatedTarget is NSObject))
			{
				throw new ArgumentException("The object passed of type " + relatedTarget.GetType()?.ToString() + " does not derive from NSObject");
			}
			IntPtr arg = NSString.CreateNative(eventType);
			if (base.IsDirectBinding)
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool_IntPtr_int_int_int_int_int_bool_bool_bool_bool_UInt16_IntPtr(base.Handle, selInitMouseEvent_CanBubble_Cancelable_View_Detail_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Button_RelatedTarget_Handle, arg, canBubble, cancelable, view.Handle, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget.Handle), "initMouseEvent:canBubble:cancelable:view:detail:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:button:relatedTarget:");
			}
			else
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_bool_IntPtr_int_int_int_int_int_bool_bool_bool_bool_UInt16_IntPtr(base.SuperHandle, selInitMouseEvent_CanBubble_Cancelable_View_Detail_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Button_RelatedTarget_Handle, arg, canBubble, cancelable, view.Handle, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget.Handle), "initMouseEvent:canBubble:cancelable:view:detail:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:button:relatedTarget:");
			}
			NSString.ReleaseNative(arg);
			return;
		}
		throw new ArgumentNullException("relatedTarget");
	}

	[Export("initMouseEvent:canBubble:cancelable:view:detail:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:button:relatedTarget:")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InitEvent(string eventType, bool canBubble, bool cancelable, DomAbstractView view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, ushort button, IDomEventTarget relatedTarget)
	{
		if (eventType == null)
		{
			throw new ArgumentNullException("eventType");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (relatedTarget != null)
		{
			if (!(relatedTarget is NSObject))
			{
				throw new ArgumentException("The object passed of type " + relatedTarget.GetType()?.ToString() + " does not derive from NSObject");
			}
			IntPtr arg = NSString.CreateNative(eventType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr_bool_bool_IntPtr_int_int_int_int_int_bool_bool_bool_bool_UInt16_IntPtr(base.Handle, selInitMouseEvent_CanBubble_Cancelable_View_Detail_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Button_RelatedTarget_Handle, arg, canBubble, cancelable, view.Handle, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_bool_bool_IntPtr_int_int_int_int_int_bool_bool_bool_bool_UInt16_IntPtr(base.SuperHandle, selInitMouseEvent_CanBubble_Cancelable_View_Detail_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Button_RelatedTarget_Handle, arg, canBubble, cancelable, view.Handle, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget.Handle);
			}
			NSString.ReleaseNative(arg);
			return;
		}
		throw new ArgumentNullException("relatedTarget");
	}
}
