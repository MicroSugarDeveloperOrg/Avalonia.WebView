using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameController;

[Register("GCMicroGamepad", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
public class GCMicroGamepad : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsRotation = "allowsRotation";

	private static readonly IntPtr selAllowsRotationHandle = Selector.GetHandle("allowsRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonA = "buttonA";

	private static readonly IntPtr selButtonAHandle = Selector.GetHandle("buttonA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonMenu = "buttonMenu";

	private static readonly IntPtr selButtonMenuHandle = Selector.GetHandle("buttonMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonX = "buttonX";

	private static readonly IntPtr selButtonXHandle = Selector.GetHandle("buttonX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selController = "controller";

	private static readonly IntPtr selControllerHandle = Selector.GetHandle("controller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDpad = "dpad";

	private static readonly IntPtr selDpadHandle = Selector.GetHandle("dpad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReportsAbsoluteDpadValues = "reportsAbsoluteDpadValues";

	private static readonly IntPtr selReportsAbsoluteDpadValuesHandle = Selector.GetHandle("reportsAbsoluteDpadValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveSnapshot = "saveSnapshot";

	private static readonly IntPtr selSaveSnapshotHandle = Selector.GetHandle("saveSnapshot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsRotation_ = "setAllowsRotation:";

	private static readonly IntPtr selSetAllowsRotation_Handle = Selector.GetHandle("setAllowsRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReportsAbsoluteDpadValues_ = "setReportsAbsoluteDpadValues:";

	private static readonly IntPtr selSetReportsAbsoluteDpadValues_Handle = Selector.GetHandle("setReportsAbsoluteDpadValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStateFromMicroGamepad_ = "setStateFromMicroGamepad:";

	private static readonly IntPtr selSetStateFromMicroGamepad_Handle = Selector.GetHandle("setStateFromMicroGamepad:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueChangedHandler_ = "setValueChangedHandler:";

	private static readonly IntPtr selSetValueChangedHandler_Handle = Selector.GetHandle("setValueChangedHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueChangedHandler = "valueChangedHandler";

	private static readonly IntPtr selValueChangedHandlerHandle = Selector.GetHandle("valueChangedHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCMicroGamepad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Controller_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsRotation
	{
		[Export("allowsRotation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsRotationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsRotationHandle);
		}
		[Export("setAllowsRotation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput ButtonA
	{
		[Export("buttonA", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonAHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonAHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual GCControllerButtonInput ButtonMenu
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("buttonMenu")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonMenuHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonMenuHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput ButtonX
	{
		[Export("buttonX", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonXHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonXHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCController Controller
	{
		[Export("controller", ArgumentSemantic.Assign)]
		get
		{
			GCController gCController = ((!base.IsDirectBinding) ? Runtime.GetNSObject<GCController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selControllerHandle)) : Runtime.GetNSObject<GCController>(Messaging.IntPtr_objc_msgSend(base.Handle, selControllerHandle)));
			MarkDirty();
			__mt_Controller_var = gCController;
			return gCController;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerDirectionPad Dpad
	{
		[Export("dpad", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerDirectionPad>(Messaging.IntPtr_objc_msgSend(base.Handle, selDpadHandle));
			}
			return Runtime.GetNSObject<GCControllerDirectionPad>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDpadHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReportsAbsoluteDpadValues
	{
		[Export("reportsAbsoluteDpadValues")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReportsAbsoluteDpadValuesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReportsAbsoluteDpadValuesHandle);
		}
		[Export("setReportsAbsoluteDpadValues:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReportsAbsoluteDpadValues_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReportsAbsoluteDpadValues_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
	public virtual GCMicroGamepadSnapshot SaveSnapshot
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
		[Export("saveSnapshot")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCMicroGamepadSnapshot>(Messaging.IntPtr_objc_msgSend(base.Handle, selSaveSnapshotHandle));
			}
			return Runtime.GetNSObject<GCMicroGamepadSnapshot>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSaveSnapshotHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual GCMicroGamepadValueChangedHandler? ValueChangedHandler
	{
		[Export("valueChangedHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDGCMicroGamepadValueChangedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueChangedHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selValueChangedHandlerHandle));
			return Trampolines.NIDGCMicroGamepadValueChangedHandler.Create(block);
		}
		[Export("setValueChangedHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDGCMicroGamepadValueChangedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGCMicroGamepadValueChangedHandler.Handler, value);
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
	protected GCMicroGamepad(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCMicroGamepad(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setStateFromMicroGamepad:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetState(GCMicroGamepad microGamepad)
	{
		if (microGamepad == null)
		{
			throw new ArgumentNullException("microGamepad");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStateFromMicroGamepad_Handle, microGamepad.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStateFromMicroGamepad_Handle, microGamepad.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Controller_var = null;
		}
	}
}
