using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKPhysicsJointPin", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKPhysicsJointPin : SKPhysicsJoint
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrictionTorque = "frictionTorque";

	private static readonly IntPtr selFrictionTorqueHandle = Selector.GetHandle("frictionTorque");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBodyA_BodyB_Anchor_ = "jointWithBodyA:bodyB:anchor:";

	private static readonly IntPtr selJointWithBodyA_BodyB_Anchor_Handle = Selector.GetHandle("jointWithBodyA:bodyB:anchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLowerAngleLimit = "lowerAngleLimit";

	private static readonly IntPtr selLowerAngleLimitHandle = Selector.GetHandle("lowerAngleLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationSpeed = "rotationSpeed";

	private static readonly IntPtr selRotationSpeedHandle = Selector.GetHandle("rotationSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrictionTorque_ = "setFrictionTorque:";

	private static readonly IntPtr selSetFrictionTorque_Handle = Selector.GetHandle("setFrictionTorque:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLowerAngleLimit_ = "setLowerAngleLimit:";

	private static readonly IntPtr selSetLowerAngleLimit_Handle = Selector.GetHandle("setLowerAngleLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotationSpeed_ = "setRotationSpeed:";

	private static readonly IntPtr selSetRotationSpeed_Handle = Selector.GetHandle("setRotationSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldEnableLimits_ = "setShouldEnableLimits:";

	private static readonly IntPtr selSetShouldEnableLimits_Handle = Selector.GetHandle("setShouldEnableLimits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUpperAngleLimit_ = "setUpperAngleLimit:";

	private static readonly IntPtr selSetUpperAngleLimit_Handle = Selector.GetHandle("setUpperAngleLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldEnableLimits = "shouldEnableLimits";

	private static readonly IntPtr selShouldEnableLimitsHandle = Selector.GetHandle("shouldEnableLimits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpperAngleLimit = "upperAngleLimit";

	private static readonly IntPtr selUpperAngleLimitHandle = Selector.GetHandle("upperAngleLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPhysicsJointPin");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat FrictionTorque
	{
		[Export("frictionTorque")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFrictionTorqueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFrictionTorqueHandle);
		}
		[Export("setFrictionTorque:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFrictionTorque_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFrictionTorque_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LowerAngleLimit
	{
		[Export("lowerAngleLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLowerAngleLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLowerAngleLimitHandle);
		}
		[Export("setLowerAngleLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLowerAngleLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLowerAngleLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nfloat RotationSpeed
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("rotationSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRotationSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRotationSpeedHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setRotationSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRotationSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRotationSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEnableLimits
	{
		[Export("shouldEnableLimits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldEnableLimitsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldEnableLimitsHandle);
		}
		[Export("setShouldEnableLimits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldEnableLimits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldEnableLimits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat UpperAngleLimit
	{
		[Export("upperAngleLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selUpperAngleLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selUpperAngleLimitHandle);
		}
		[Export("setUpperAngleLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetUpperAngleLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetUpperAngleLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKPhysicsJointPin(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKPhysicsJointPin(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPhysicsJointPin(IntPtr handle)
		: base(handle)
	{
	}

	[Export("jointWithBodyA:bodyB:anchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsJointPin Create(SKPhysicsBody bodyA, SKPhysicsBody bodyB, CGPoint anchor)
	{
		if (bodyA == null)
		{
			throw new ArgumentNullException("bodyA");
		}
		if (bodyB == null)
		{
			throw new ArgumentNullException("bodyB");
		}
		return Runtime.GetNSObject<SKPhysicsJointPin>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGPoint(class_ptr, selJointWithBodyA_BodyB_Anchor_Handle, bodyA.Handle, bodyB.Handle, anchor));
	}
}
