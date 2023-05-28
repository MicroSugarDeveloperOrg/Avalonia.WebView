using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMUIEvent", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomUIEvent : DomEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharCode = "charCode";

	private static readonly IntPtr selCharCodeHandle = Selector.GetHandle("charCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetail = "detail";

	private static readonly IntPtr selDetailHandle = Selector.GetHandle("detail");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitUIEvent_CanBubble_Cancelable_View_Detail_ = "initUIEvent:canBubble:cancelable:view:detail:";

	private static readonly IntPtr selInitUIEvent_CanBubble_Cancelable_View_Detail_Handle = Selector.GetHandle("initUIEvent:canBubble:cancelable:view:detail:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyCode = "keyCode";

	private static readonly IntPtr selKeyCodeHandle = Selector.GetHandle("keyCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerX = "layerX";

	private static readonly IntPtr selLayerXHandle = Selector.GetHandle("layerX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerY = "layerY";

	private static readonly IntPtr selLayerYHandle = Selector.GetHandle("layerY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageX = "pageX";

	private static readonly IntPtr selPageXHandle = Selector.GetHandle("pageX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selView = "view";

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWhich = "which";

	private static readonly IntPtr selWhichHandle = Selector.GetHandle("which");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMUIEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int CharCode
	{
		[Export("charCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selCharCodeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selCharCodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Detail
	{
		[Export("detail")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selDetailHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selDetailHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int KeyCode
	{
		[Export("keyCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selKeyCodeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selKeyCodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int LayerX
	{
		[Export("layerX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLayerXHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLayerXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int LayerY
	{
		[Export("layerY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLayerYHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLayerYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int PageX
	{
		[Export("pageX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPageXHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPageXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomAbstractView View
	{
		[Export("view", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomAbstractView>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle));
			}
			return Runtime.GetNSObject<DomAbstractView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Which
	{
		[Export("which")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selWhichHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selWhichHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomUIEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomUIEvent(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public DomUIEvent(string eventType, bool canBubble, bool cancelable, DomAbstractView view, int detail)
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
		IntPtr arg = NSString.CreateNative(eventType);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool_IntPtr_int(base.Handle, selInitUIEvent_CanBubble_Cancelable_View_Detail_Handle, arg, canBubble, cancelable, view.Handle, detail), "initUIEvent:canBubble:cancelable:view:detail:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_bool_IntPtr_int(base.SuperHandle, selInitUIEvent_CanBubble_Cancelable_View_Detail_Handle, arg, canBubble, cancelable, view.Handle, detail), "initUIEvent:canBubble:cancelable:view:detail:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initUIEvent:canBubble:cancelable:view:detail:")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InitEvent(string eventType, bool canBubble, bool cancelable, DomAbstractView view, int detail)
	{
		if (eventType == null)
		{
			throw new ArgumentNullException("eventType");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		IntPtr arg = NSString.CreateNative(eventType);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_bool_IntPtr_int(base.Handle, selInitUIEvent_CanBubble_Cancelable_View_Detail_Handle, arg, canBubble, cancelable, view.Handle, detail);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_bool_IntPtr_int(base.SuperHandle, selInitUIEvent_CanBubble_Cancelable_View_Detail_Handle, arg, canBubble, cancelable, view.Handle, detail);
		}
		NSString.ReleaseNative(arg);
	}
}
