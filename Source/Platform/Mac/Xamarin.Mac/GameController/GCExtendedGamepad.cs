using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameController;

[Register("GCExtendedGamepad", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class GCExtendedGamepad : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonA = "buttonA";

	private static readonly IntPtr selButtonAHandle = Selector.GetHandle("buttonA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonB = "buttonB";

	private static readonly IntPtr selButtonBHandle = Selector.GetHandle("buttonB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonMenu = "buttonMenu";

	private static readonly IntPtr selButtonMenuHandle = Selector.GetHandle("buttonMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonOptions = "buttonOptions";

	private static readonly IntPtr selButtonOptionsHandle = Selector.GetHandle("buttonOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonX = "buttonX";

	private static readonly IntPtr selButtonXHandle = Selector.GetHandle("buttonX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonY = "buttonY";

	private static readonly IntPtr selButtonYHandle = Selector.GetHandle("buttonY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selController = "controller";

	private static readonly IntPtr selControllerHandle = Selector.GetHandle("controller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDpad = "dpad";

	private static readonly IntPtr selDpadHandle = Selector.GetHandle("dpad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftShoulder = "leftShoulder";

	private static readonly IntPtr selLeftShoulderHandle = Selector.GetHandle("leftShoulder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftThumbstick = "leftThumbstick";

	private static readonly IntPtr selLeftThumbstickHandle = Selector.GetHandle("leftThumbstick");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftThumbstickButton = "leftThumbstickButton";

	private static readonly IntPtr selLeftThumbstickButtonHandle = Selector.GetHandle("leftThumbstickButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftTrigger = "leftTrigger";

	private static readonly IntPtr selLeftTriggerHandle = Selector.GetHandle("leftTrigger");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightShoulder = "rightShoulder";

	private static readonly IntPtr selRightShoulderHandle = Selector.GetHandle("rightShoulder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightThumbstick = "rightThumbstick";

	private static readonly IntPtr selRightThumbstickHandle = Selector.GetHandle("rightThumbstick");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightThumbstickButton = "rightThumbstickButton";

	private static readonly IntPtr selRightThumbstickButtonHandle = Selector.GetHandle("rightThumbstickButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightTrigger = "rightTrigger";

	private static readonly IntPtr selRightTriggerHandle = Selector.GetHandle("rightTrigger");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveSnapshot = "saveSnapshot";

	private static readonly IntPtr selSaveSnapshotHandle = Selector.GetHandle("saveSnapshot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStateFromExtendedGamepad_ = "setStateFromExtendedGamepad:";

	private static readonly IntPtr selSetStateFromExtendedGamepad_Handle = Selector.GetHandle("setStateFromExtendedGamepad:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueChangedHandler_ = "setValueChangedHandler:";

	private static readonly IntPtr selSetValueChangedHandler_Handle = Selector.GetHandle("setValueChangedHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueChangedHandler = "valueChangedHandler";

	private static readonly IntPtr selValueChangedHandlerHandle = Selector.GetHandle("valueChangedHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCExtendedGamepad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Controller_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput ButtonA
	{
		[Export("buttonA")]
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
	public virtual GCControllerButtonInput ButtonB
	{
		[Export("buttonB")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonBHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonBHandle));
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
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual GCControllerButtonInput? ButtonOptions
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("buttonOptions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonOptionsHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput ButtonX
	{
		[Export("buttonX")]
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
	public virtual GCControllerButtonInput ButtonY
	{
		[Export("buttonY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonYHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonYHandle));
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
	public virtual GCControllerDirectionPad DPad
	{
		[Export("dpad")]
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
	public virtual GCControllerButtonInput LeftShoulder
	{
		[Export("leftShoulder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftShoulderHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftShoulderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerDirectionPad LeftThumbstick
	{
		[Export("leftThumbstick")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerDirectionPad>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftThumbstickHandle));
			}
			return Runtime.GetNSObject<GCControllerDirectionPad>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftThumbstickHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
	public virtual GCControllerButtonInput? LeftThumbstickButton
	{
		[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
		[Export("leftThumbstickButton")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftThumbstickButtonHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftThumbstickButtonHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput LeftTrigger
	{
		[Export("leftTrigger")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftTriggerHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftTriggerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput RightShoulder
	{
		[Export("rightShoulder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightShoulderHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightShoulderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerDirectionPad RightThumbstick
	{
		[Export("rightThumbstick")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerDirectionPad>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightThumbstickHandle));
			}
			return Runtime.GetNSObject<GCControllerDirectionPad>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightThumbstickHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
	public virtual GCControllerButtonInput? RightThumbstickButton
	{
		[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
		[Export("rightThumbstickButton")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightThumbstickButtonHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightThumbstickButtonHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCControllerButtonInput RightTrigger
	{
		[Export("rightTrigger")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightTriggerHandle));
			}
			return Runtime.GetNSObject<GCControllerButtonInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightTriggerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual GCExtendedGamepadValueChangedHandler? ValueChangedHandler
	{
		[Export("valueChangedHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDGCExtendedGamepadValueChangedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueChangedHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selValueChangedHandlerHandle));
			return Trampolines.NIDGCExtendedGamepadValueChangedHandler.Create(block);
		}
		[Export("setValueChangedHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDGCExtendedGamepadValueChangedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGCExtendedGamepadValueChangedHandler.Handler, value);
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
	protected GCExtendedGamepad(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCExtendedGamepad(IntPtr handle)
		: base(handle)
	{
	}

	[Export("saveSnapshot")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCExtendedGamepadSnapshot SaveSnapshot()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GCExtendedGamepadSnapshot>(Messaging.IntPtr_objc_msgSend(base.Handle, selSaveSnapshotHandle));
		}
		return Runtime.GetNSObject<GCExtendedGamepadSnapshot>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSaveSnapshotHandle));
	}

	[Export("setStateFromExtendedGamepad:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetState(GCExtendedGamepad extendedGamepad)
	{
		if (extendedGamepad == null)
		{
			throw new ArgumentNullException("extendedGamepad");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStateFromExtendedGamepad_Handle, extendedGamepad.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStateFromExtendedGamepad_Handle, extendedGamepad.Handle);
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
