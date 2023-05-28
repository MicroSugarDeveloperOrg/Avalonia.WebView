using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNCameraController", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class SCNCameraController : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticTarget = "automaticTarget";

	private static readonly IntPtr selAutomaticTargetHandle = Selector.GetHandle("automaticTarget");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginInteraction_WithViewport_ = "beginInteraction:withViewport:";

	private static readonly IntPtr selBeginInteraction_WithViewport_Handle = Selector.GetHandle("beginInteraction:withViewport:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearRoll = "clearRoll";

	private static readonly IntPtr selClearRollHandle = Selector.GetHandle("clearRoll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContinueInteraction_WithViewport_Sensitivity_ = "continueInteraction:withViewport:sensitivity:";

	private static readonly IntPtr selContinueInteraction_WithViewport_Sensitivity_Handle = Selector.GetHandle("continueInteraction:withViewport:sensitivity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDollyBy_OnScreenPoint_Viewport_ = "dollyBy:onScreenPoint:viewport:";

	private static readonly IntPtr selDollyBy_OnScreenPoint_Viewport_Handle = Selector.GetHandle("dollyBy:onScreenPoint:viewport:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDollyToTarget_ = "dollyToTarget:";

	private static readonly IntPtr selDollyToTarget_Handle = Selector.GetHandle("dollyToTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndInteraction_WithViewport_Velocity_ = "endInteraction:withViewport:velocity:";

	private static readonly IntPtr selEndInteraction_WithViewport_Velocity_Handle = Selector.GetHandle("endInteraction:withViewport:velocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameNodes_ = "frameNodes:";

	private static readonly IntPtr selFrameNodes_Handle = Selector.GetHandle("frameNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInertiaEnabled = "inertiaEnabled";

	private static readonly IntPtr selInertiaEnabledHandle = Selector.GetHandle("inertiaEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInertiaFriction = "inertiaFriction";

	private static readonly IntPtr selInertiaFrictionHandle = Selector.GetHandle("inertiaFriction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInteractionMode = "interactionMode";

	private static readonly IntPtr selInteractionModeHandle = Selector.GetHandle("interactionMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInertiaRunning = "isInertiaRunning";

	private static readonly IntPtr selIsInertiaRunningHandle = Selector.GetHandle("isInertiaRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumHorizontalAngle = "maximumHorizontalAngle";

	private static readonly IntPtr selMaximumHorizontalAngleHandle = Selector.GetHandle("maximumHorizontalAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumVerticalAngle = "maximumVerticalAngle";

	private static readonly IntPtr selMaximumVerticalAngleHandle = Selector.GetHandle("maximumVerticalAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumHorizontalAngle = "minimumHorizontalAngle";

	private static readonly IntPtr selMinimumHorizontalAngleHandle = Selector.GetHandle("minimumHorizontalAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumVerticalAngle = "minimumVerticalAngle";

	private static readonly IntPtr selMinimumVerticalAngleHandle = Selector.GetHandle("minimumVerticalAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointOfView = "pointOfView";

	private static readonly IntPtr selPointOfViewHandle = Selector.GetHandle("pointOfView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRollAroundTarget_ = "rollAroundTarget:";

	private static readonly IntPtr selRollAroundTarget_Handle = Selector.GetHandle("rollAroundTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRollBy_AroundScreenPoint_Viewport_ = "rollBy:aroundScreenPoint:viewport:";

	private static readonly IntPtr selRollBy_AroundScreenPoint_Viewport_Handle = Selector.GetHandle("rollBy:aroundScreenPoint:viewport:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateByX_Y_ = "rotateByX:Y:";

	private static readonly IntPtr selRotateByX_Y_Handle = Selector.GetHandle("rotateByX:Y:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticTarget_ = "setAutomaticTarget:";

	private static readonly IntPtr selSetAutomaticTarget_Handle = Selector.GetHandle("setAutomaticTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInertiaEnabled_ = "setInertiaEnabled:";

	private static readonly IntPtr selSetInertiaEnabled_Handle = Selector.GetHandle("setInertiaEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInertiaFriction_ = "setInertiaFriction:";

	private static readonly IntPtr selSetInertiaFriction_Handle = Selector.GetHandle("setInertiaFriction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInteractionMode_ = "setInteractionMode:";

	private static readonly IntPtr selSetInteractionMode_Handle = Selector.GetHandle("setInteractionMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumHorizontalAngle_ = "setMaximumHorizontalAngle:";

	private static readonly IntPtr selSetMaximumHorizontalAngle_Handle = Selector.GetHandle("setMaximumHorizontalAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumVerticalAngle_ = "setMaximumVerticalAngle:";

	private static readonly IntPtr selSetMaximumVerticalAngle_Handle = Selector.GetHandle("setMaximumVerticalAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumHorizontalAngle_ = "setMinimumHorizontalAngle:";

	private static readonly IntPtr selSetMinimumHorizontalAngle_Handle = Selector.GetHandle("setMinimumHorizontalAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumVerticalAngle_ = "setMinimumVerticalAngle:";

	private static readonly IntPtr selSetMinimumVerticalAngle_Handle = Selector.GetHandle("setMinimumVerticalAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPointOfView_ = "setPointOfView:";

	private static readonly IntPtr selSetPointOfView_Handle = Selector.GetHandle("setPointOfView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWorldUp_ = "setWorldUp:";

	private static readonly IntPtr selSetWorldUp_Handle = Selector.GetHandle("setWorldUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopInertia = "stopInertia";

	private static readonly IntPtr selStopInertiaHandle = Selector.GetHandle("stopInertia");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranslateInCameraSpaceByX_Y_Z_ = "translateInCameraSpaceByX:Y:Z:";

	private static readonly IntPtr selTranslateInCameraSpaceByX_Y_Z_Handle = Selector.GetHandle("translateInCameraSpaceByX:Y:Z:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorldUp = "worldUp";

	private static readonly IntPtr selWorldUpHandle = Selector.GetHandle("worldUp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNCameraController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticTarget
	{
		[Export("automaticTarget")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticTargetHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticTargetHandle);
		}
		[Export("setAutomaticTarget:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticTarget_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticTarget_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ISCNCameraControllerDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			ISCNCameraControllerDelegate iSCNCameraControllerDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<ISCNCameraControllerDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<ISCNCameraControllerDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iSCNCameraControllerDelegate;
			return iSCNCameraControllerDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InertiaEnabled
	{
		[Export("inertiaEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInertiaEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInertiaEnabledHandle);
		}
		[Export("setInertiaEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetInertiaEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetInertiaEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float InertiaFriction
	{
		[Export("inertiaFriction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInertiaFrictionHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInertiaFrictionHandle);
		}
		[Export("setInertiaFriction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInertiaFriction_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInertiaFriction_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InertiaRunning
	{
		[Export("isInertiaRunning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInertiaRunningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInertiaRunningHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNInteractionMode InteractionMode
	{
		[Export("interactionMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNInteractionMode)Messaging.Int64_objc_msgSend(base.Handle, selInteractionModeHandle);
			}
			return (SCNInteractionMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selInteractionModeHandle);
		}
		[Export("setInteractionMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetInteractionMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetInteractionMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaximumHorizontalAngle
	{
		[Export("maximumHorizontalAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumHorizontalAngleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumHorizontalAngleHandle);
		}
		[Export("setMaximumHorizontalAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaximumHorizontalAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaximumHorizontalAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaximumVerticalAngle
	{
		[Export("maximumVerticalAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumVerticalAngleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumVerticalAngleHandle);
		}
		[Export("setMaximumVerticalAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaximumVerticalAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaximumVerticalAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinimumHorizontalAngle
	{
		[Export("minimumHorizontalAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinimumHorizontalAngleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinimumHorizontalAngleHandle);
		}
		[Export("setMinimumHorizontalAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinimumHorizontalAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinimumHorizontalAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinimumVerticalAngle
	{
		[Export("minimumVerticalAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinimumVerticalAngleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinimumVerticalAngleHandle);
		}
		[Export("setMinimumVerticalAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinimumVerticalAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinimumVerticalAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode? PointOfView
	{
		[Export("pointOfView", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selPointOfViewHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointOfViewHandle));
		}
		[Export("setPointOfView:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPointOfView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPointOfView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 Target
	{
		[Export("target", ArgumentSemantic.Assign)]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selTargetHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTargetHandle);
			}
			return retval;
		}
		[Export("setTarget:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetTarget_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetTarget_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 WorldUp
	{
		[Export("worldUp", ArgumentSemantic.Assign)]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selWorldUpHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selWorldUpHandle);
			}
			return retval;
		}
		[Export("setWorldUp:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetWorldUp_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetWorldUp_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNCameraController()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNCameraController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNCameraController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginInteraction:withViewport:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginInteraction(CGPoint location, CGSize viewport)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGSize(base.Handle, selBeginInteraction_WithViewport_Handle, location, viewport);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGSize(base.SuperHandle, selBeginInteraction_WithViewport_Handle, location, viewport);
		}
	}

	[Export("clearRoll")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearRoll()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearRollHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearRollHandle);
		}
	}

	[Export("continueInteraction:withViewport:sensitivity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ContinueInteraction(CGPoint location, CGSize viewport, nfloat sensitivity)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGSize_nfloat(base.Handle, selContinueInteraction_WithViewport_Sensitivity_Handle, location, viewport, sensitivity);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGSize_nfloat(base.SuperHandle, selContinueInteraction_WithViewport_Sensitivity_Handle, location, viewport, sensitivity);
		}
	}

	[Export("dollyBy:onScreenPoint:viewport:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Dolly(float delta, CGPoint screenPoint, CGSize viewport)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_CGPoint_CGSize(base.Handle, selDollyBy_OnScreenPoint_Viewport_Handle, delta, screenPoint, viewport);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_CGPoint_CGSize(base.SuperHandle, selDollyBy_OnScreenPoint_Viewport_Handle, delta, screenPoint, viewport);
		}
	}

	[Export("dollyToTarget:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DollyToTarget(float delta)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float(base.Handle, selDollyToTarget_Handle, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selDollyToTarget_Handle, delta);
		}
	}

	[Export("endInteraction:withViewport:velocity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndInteraction(CGPoint location, CGSize viewport, CGPoint velocity)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGSize_CGPoint(base.Handle, selEndInteraction_WithViewport_Velocity_Handle, location, viewport, velocity);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGSize_CGPoint(base.SuperHandle, selEndInteraction_WithViewport_Velocity_Handle, location, viewport, velocity);
		}
	}

	[Export("frameNodes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FrameNodes(SCNNode[] nodes)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFrameNodes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFrameNodes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("rollBy:aroundScreenPoint:viewport:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Roll(float delta, CGPoint screenPoint, CGSize viewport)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_CGPoint_CGSize(base.Handle, selRollBy_AroundScreenPoint_Viewport_Handle, delta, screenPoint, viewport);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_CGPoint_CGSize(base.SuperHandle, selRollBy_AroundScreenPoint_Viewport_Handle, delta, screenPoint, viewport);
		}
	}

	[Export("rollAroundTarget:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RollAroundTarget(float delta)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float(base.Handle, selRollAroundTarget_Handle, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selRollAroundTarget_Handle, delta);
		}
	}

	[Export("rotateByX:Y:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Rotate(float deltaX, float deltaY)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float(base.Handle, selRotateByX_Y_Handle, deltaX, deltaY);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float(base.SuperHandle, selRotateByX_Y_Handle, deltaX, deltaY);
		}
	}

	[Export("stopInertia")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopInertia()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopInertiaHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopInertiaHandle);
		}
	}

	[Export("translateInCameraSpaceByX:Y:Z:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TranslateInCameraSpace(float deltaX, float deltaY, float deltaZ)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float_float(base.Handle, selTranslateInCameraSpaceByX_Y_Z_Handle, deltaX, deltaY, deltaZ);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float_float(base.SuperHandle, selTranslateInCameraSpaceByX_Y_Z_Handle, deltaX, deltaY, deltaZ);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
