using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameController;

[Register("GCControllerButtonInput", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class GCControllerButtonInput : GCControllerElement
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPressed = "isPressed";

	private static readonly IntPtr selIsPressedHandle = Selector.GetHandle("isPressed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPressedChangedHandler = "pressedChangedHandler";

	private static readonly IntPtr selPressedChangedHandlerHandle = Selector.GetHandle("pressedChangedHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPressedChangedHandler_ = "setPressedChangedHandler:";

	private static readonly IntPtr selSetPressedChangedHandler_Handle = Selector.GetHandle("setPressedChangedHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ = "setValue:";

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueChangedHandler_ = "setValueChangedHandler:";

	private static readonly IntPtr selSetValueChangedHandler_Handle = Selector.GetHandle("setValueChangedHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueChangedHandler = "valueChangedHandler";

	private static readonly IntPtr selValueChangedHandlerHandle = Selector.GetHandle("valueChangedHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCControllerButtonInput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsPressed
	{
		[Export("isPressed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPressedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPressedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public unsafe virtual GCControllerButtonValueChanged? PressedChangedHandler
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("pressedChangedHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDGCControllerButtonValueChanged))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPressedChangedHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPressedChangedHandlerHandle));
			return Trampolines.NIDGCControllerButtonValueChanged.Create(block);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPressedChangedHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDGCControllerButtonValueChanged))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGCControllerButtonValueChanged.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPressedChangedHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPressedChangedHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Value
	{
		[Export("value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selValueHandle);
		}
		[Export("setValue:")]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual GCControllerButtonValueChanged? ValueChangedHandler
	{
		[Export("valueChangedHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDGCControllerButtonValueChanged))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueChangedHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selValueChangedHandlerHandle));
			return Trampolines.NIDGCControllerButtonValueChanged.Create(block);
		}
		[Export("setValueChangedHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDGCControllerButtonValueChanged))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGCControllerButtonValueChanged.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValueChangedHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValueChangedHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GCControllerButtonInput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCControllerButtonInput(IntPtr handle)
		: base(handle)
	{
	}

	[Obsolete("Use the 'PressedChangedHandler' property.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPressedChangedHandler([BlockProxy(typeof(Trampolines.NIDGCControllerButtonValueChanged))] GCControllerButtonValueChanged handler)
	{
		PressedChangedHandler = handler;
	}

	[Obsolete("Use the 'ValueChangedHandler' property.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValueChangedHandler([BlockProxy(typeof(Trampolines.NIDGCControllerButtonValueChanged))] GCControllerButtonValueChanged handler)
	{
		ValueChangedHandler = handler;
	}
}
