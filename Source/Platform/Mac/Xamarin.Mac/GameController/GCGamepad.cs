using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameController;

[Register("GCGamepad", true)]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
[Deprecated(PlatformName.TvOS, 10, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class GCGamepad : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonA = "buttonA";

	private static readonly IntPtr selButtonAHandle = Selector.GetHandle("buttonA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonB = "buttonB";

	private static readonly IntPtr selButtonBHandle = Selector.GetHandle("buttonB");

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
	private const string selRightShoulder = "rightShoulder";

	private static readonly IntPtr selRightShoulderHandle = Selector.GetHandle("rightShoulder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveSnapshot = "saveSnapshot";

	private static readonly IntPtr selSaveSnapshotHandle = Selector.GetHandle("saveSnapshot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueChangedHandler_ = "setValueChangedHandler:";

	private static readonly IntPtr selSetValueChangedHandler_Handle = Selector.GetHandle("setValueChangedHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueChangedHandler = "valueChangedHandler";

	private static readonly IntPtr selValueChangedHandlerHandle = Selector.GetHandle("valueChangedHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCGamepad");

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
	public virtual GCController? Controller
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
	public virtual GCGamepadSnapshot SaveSnapshot
	{
		[Export("saveSnapshot")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCGamepadSnapshot>(Messaging.IntPtr_objc_msgSend(base.Handle, selSaveSnapshotHandle));
			}
			return Runtime.GetNSObject<GCGamepadSnapshot>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSaveSnapshotHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual GCGamepadValueChangedHandler? ValueChangedHandler
	{
		[Export("valueChangedHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDGCGamepadValueChangedHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueChangedHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selValueChangedHandlerHandle));
			return Trampolines.NIDGCGamepadValueChangedHandler.Create(block);
		}
		[Export("setValueChangedHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDGCGamepadValueChangedHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGCGamepadValueChangedHandler.Handler, value);
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
	protected GCGamepad(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCGamepad(IntPtr handle)
		: base(handle)
	{
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
