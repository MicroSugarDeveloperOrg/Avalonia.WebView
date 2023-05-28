using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMWheelEvent", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomWheelEvent : DomMouseEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWheelEvent_WheelDeltaY_View_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_ = "initWheelEvent:wheelDeltaY:view:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:";

	private static readonly IntPtr selInitWheelEvent_WheelDeltaY_View_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Handle = Selector.GetHandle("initWheelEvent:wheelDeltaY:view:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHorizontal = "isHorizontal";

	private static readonly IntPtr selIsHorizontalHandle = Selector.GetHandle("isHorizontal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWheelDelta = "wheelDelta";

	private static readonly IntPtr selWheelDeltaHandle = Selector.GetHandle("wheelDelta");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWheelDeltaX = "wheelDeltaX";

	private static readonly IntPtr selWheelDeltaXHandle = Selector.GetHandle("wheelDeltaX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWheelDeltaY = "wheelDeltaY";

	private static readonly IntPtr selWheelDeltaYHandle = Selector.GetHandle("wheelDeltaY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMWheelEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsHorizontal
	{
		[Export("isHorizontal")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHorizontalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHorizontalHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDelta WheelDelta
	{
		[Export("wheelDelta")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (DomDelta)Messaging.int_objc_msgSend(base.Handle, selWheelDeltaHandle);
			}
			return (DomDelta)Messaging.int_objc_msgSendSuper(base.SuperHandle, selWheelDeltaHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int WheelDeltaX
	{
		[Export("wheelDeltaX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selWheelDeltaXHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selWheelDeltaXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int WheelDeltaY
	{
		[Export("wheelDeltaY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selWheelDeltaYHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selWheelDeltaYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomWheelEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomWheelEvent(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public DomWheelEvent(int wheelDeltaX, int wheelDeltaY, DomAbstractView view, int screenX, int screnY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey)
		: base(NSObjectFlag.Empty)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_int_int_IntPtr_int_int_int_int_bool_bool_bool_bool(base.Handle, selInitWheelEvent_WheelDeltaY_View_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Handle, wheelDeltaX, wheelDeltaY, view.Handle, screenX, screnY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey), "initWheelEvent:wheelDeltaY:view:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_int_int_IntPtr_int_int_int_int_bool_bool_bool_bool(base.SuperHandle, selInitWheelEvent_WheelDeltaY_View_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Handle, wheelDeltaX, wheelDeltaY, view.Handle, screenX, screnY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey), "initWheelEvent:wheelDeltaY:view:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:");
		}
	}

	[Export("initWheelEvent:wheelDeltaY:view:screenX:screenY:clientX:clientY:ctrlKey:altKey:shiftKey:metaKey:")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InitEvent(int wheelDeltaX, int wheelDeltaY, DomAbstractView view, int screenX, int screnY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_int_IntPtr_int_int_int_int_bool_bool_bool_bool(base.Handle, selInitWheelEvent_WheelDeltaY_View_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Handle, wheelDeltaX, wheelDeltaY, view.Handle, screenX, screnY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_int_IntPtr_int_int_int_int_bool_bool_bool_bool(base.SuperHandle, selInitWheelEvent_WheelDeltaY_View_ScreenX_ScreenY_ClientX_ClientY_CtrlKey_AltKey_ShiftKey_MetaKey_Handle, wheelDeltaX, wheelDeltaY, view.Handle, screenX, screnY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey);
		}
	}
}
