using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMKeyboardEvent", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomKeyboardEvent : DomUIEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAltGraphKey = "altGraphKey";

	private static readonly IntPtr selAltGraphKeyHandle = Selector.GetHandle("altGraphKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAltKey = "altKey";

	private static readonly IntPtr selAltKeyHandle = Selector.GetHandle("altKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharCode = "charCode";

	private static readonly IntPtr selCharCodeHandle = Selector.GetHandle("charCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCtrlKey = "ctrlKey";

	private static readonly IntPtr selCtrlKeyHandle = Selector.GetHandle("ctrlKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetModifierState_ = "getModifierState:";

	private static readonly IntPtr selGetModifierState_Handle = Selector.GetHandle("getModifierState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_ = "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:";

	private static readonly IntPtr selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_Handle = Selector.GetHandle("initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_ = "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:";

	private static readonly IntPtr selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_Handle = Selector.GetHandle("initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyCode = "keyCode";

	private static readonly IntPtr selKeyCodeHandle = Selector.GetHandle("keyCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyIdentifier = "keyIdentifier";

	private static readonly IntPtr selKeyIdentifierHandle = Selector.GetHandle("keyIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyLocation = "keyLocation";

	private static readonly IntPtr selKeyLocationHandle = Selector.GetHandle("keyLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetaKey = "metaKey";

	private static readonly IntPtr selMetaKeyHandle = Selector.GetHandle("metaKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShiftKey = "shiftKey";

	private static readonly IntPtr selShiftKeyHandle = Selector.GetHandle("shiftKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMKeyboardEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AltGraphKey
	{
		[Export("altGraphKey")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAltGraphKeyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAltGraphKeyHandle);
		}
	}

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
	public new virtual int CharCode
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
	public new virtual int KeyCode
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
	public virtual string KeyIdentifier
	{
		[Export("keyIdentifier", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomKeyLocation KeyLocation
	{
		[Export("keyLocation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (DomKeyLocation)Messaging.UInt32_objc_msgSend(base.Handle, selKeyLocationHandle);
			}
			return (DomKeyLocation)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selKeyLocationHandle);
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomKeyboardEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomKeyboardEvent(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public DomKeyboardEvent(string eventType, bool canBubble, bool cancelable, DomAbstractView view, string keyIdentifier, DomKeyLocation keyLocation, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, bool altGraphKey)
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
		if (keyIdentifier == null)
		{
			throw new ArgumentNullException("keyIdentifier");
		}
		IntPtr arg = NSString.CreateNative(eventType);
		IntPtr arg2 = NSString.CreateNative(keyIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool_IntPtr_IntPtr_UInt32_bool_bool_bool_bool_bool(base.Handle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_Handle, arg, canBubble, cancelable, view.Handle, arg2, (uint)keyLocation, ctrlKey, altKey, shiftKey, metaKey, altGraphKey), "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_bool_IntPtr_IntPtr_UInt32_bool_bool_bool_bool_bool(base.SuperHandle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_Handle, arg, canBubble, cancelable, view.Handle, arg2, (uint)keyLocation, ctrlKey, altKey, shiftKey, metaKey, altGraphKey), "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public DomKeyboardEvent(string eventType, bool canBubble, bool cancelable, DomAbstractView view, string keyIdentifier, DomKeyLocation keyLocation, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey)
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
		if (keyIdentifier == null)
		{
			throw new ArgumentNullException("keyIdentifier");
		}
		IntPtr arg = NSString.CreateNative(eventType);
		IntPtr arg2 = NSString.CreateNative(keyIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool_IntPtr_IntPtr_UInt32_bool_bool_bool_bool(base.Handle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_Handle, arg, canBubble, cancelable, view.Handle, arg2, (uint)keyLocation, ctrlKey, altKey, shiftKey, metaKey), "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_bool_IntPtr_IntPtr_UInt32_bool_bool_bool_bool(base.SuperHandle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_Handle, arg, canBubble, cancelable, view.Handle, arg2, (uint)keyLocation, ctrlKey, altKey, shiftKey, metaKey), "initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("getModifierState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetModifierState(string keyIdentifier)
	{
		if (keyIdentifier == null)
		{
			throw new ArgumentNullException("keyIdentifier");
		}
		IntPtr arg = NSString.CreateNative(keyIdentifier);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetModifierState_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selGetModifierState_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:altGraphKey:")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InitEvent(string eventType, bool canBubble, bool cancelable, DomAbstractView view, string keyIdentifier, DomKeyLocation keyLocation, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, bool altGraphKey)
	{
		if (eventType == null)
		{
			throw new ArgumentNullException("eventType");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (keyIdentifier == null)
		{
			throw new ArgumentNullException("keyIdentifier");
		}
		IntPtr arg = NSString.CreateNative(eventType);
		IntPtr arg2 = NSString.CreateNative(keyIdentifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_bool_IntPtr_IntPtr_UInt32_bool_bool_bool_bool_bool(base.Handle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_Handle, arg, canBubble, cancelable, view.Handle, arg2, (uint)keyLocation, ctrlKey, altKey, shiftKey, metaKey, altGraphKey);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_bool_IntPtr_IntPtr_UInt32_bool_bool_bool_bool_bool(base.SuperHandle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_AltGraphKey_Handle, arg, canBubble, cancelable, view.Handle, arg2, (uint)keyLocation, ctrlKey, altKey, shiftKey, metaKey, altGraphKey);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initKeyboardEvent:canBubble:cancelable:view:keyIdentifier:keyLocation:ctrlKey:altKey:shiftKey:metaKey:")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InitEvent(string eventType, bool canBubble, bool cancelable, DomAbstractView view, string keyIdentifier, DomKeyLocation keyLocation, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey)
	{
		if (eventType == null)
		{
			throw new ArgumentNullException("eventType");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (keyIdentifier == null)
		{
			throw new ArgumentNullException("keyIdentifier");
		}
		IntPtr arg = NSString.CreateNative(eventType);
		IntPtr arg2 = NSString.CreateNative(keyIdentifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_bool_IntPtr_IntPtr_UInt32_bool_bool_bool_bool(base.Handle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_Handle, arg, canBubble, cancelable, view.Handle, arg2, (uint)keyLocation, ctrlKey, altKey, shiftKey, metaKey);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_bool_IntPtr_IntPtr_UInt32_bool_bool_bool_bool(base.SuperHandle, selInitKeyboardEvent_CanBubble_Cancelable_View_KeyIdentifier_KeyLocation_CtrlKey_AltKey_ShiftKey_MetaKey_Handle, arg, canBubble, cancelable, view.Handle, arg2, (uint)keyLocation, ctrlKey, altKey, shiftKey, metaKey);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}
}
