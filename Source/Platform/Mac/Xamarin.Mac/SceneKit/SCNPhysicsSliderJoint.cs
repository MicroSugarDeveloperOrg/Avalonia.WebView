using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNPhysicsSliderJoint", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsSliderJoint : SCNPhysicsBehavior
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorA = "anchorA";

	private static readonly IntPtr selAnchorAHandle = Selector.GetHandle("anchorA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorB = "anchorB";

	private static readonly IntPtr selAnchorBHandle = Selector.GetHandle("anchorB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAxisA = "axisA";

	private static readonly IntPtr selAxisAHandle = Selector.GetHandle("axisA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAxisB = "axisB";

	private static readonly IntPtr selAxisBHandle = Selector.GetHandle("axisB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyA = "bodyA";

	private static readonly IntPtr selBodyAHandle = Selector.GetHandle("bodyA");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyB = "bodyB";

	private static readonly IntPtr selBodyBHandle = Selector.GetHandle("bodyB");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBody_Axis_Anchor_ = "jointWithBody:axis:anchor:";

	private static readonly IntPtr selJointWithBody_Axis_Anchor_Handle = Selector.GetHandle("jointWithBody:axis:anchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJointWithBodyA_AxisA_AnchorA_BodyB_AxisB_AnchorB_ = "jointWithBodyA:axisA:anchorA:bodyB:axisB:anchorB:";

	private static readonly IntPtr selJointWithBodyA_AxisA_AnchorA_BodyB_AxisB_AnchorB_Handle = Selector.GetHandle("jointWithBodyA:axisA:anchorA:bodyB:axisB:anchorB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumAngularLimit = "maximumAngularLimit";

	private static readonly IntPtr selMaximumAngularLimitHandle = Selector.GetHandle("maximumAngularLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumLinearLimit = "maximumLinearLimit";

	private static readonly IntPtr selMaximumLinearLimitHandle = Selector.GetHandle("maximumLinearLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumAngularLimit = "minimumAngularLimit";

	private static readonly IntPtr selMinimumAngularLimitHandle = Selector.GetHandle("minimumAngularLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumLinearLimit = "minimumLinearLimit";

	private static readonly IntPtr selMinimumLinearLimitHandle = Selector.GetHandle("minimumLinearLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMotorMaximumForce = "motorMaximumForce";

	private static readonly IntPtr selMotorMaximumForceHandle = Selector.GetHandle("motorMaximumForce");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMotorMaximumTorque = "motorMaximumTorque";

	private static readonly IntPtr selMotorMaximumTorqueHandle = Selector.GetHandle("motorMaximumTorque");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMotorTargetAngularVelocity = "motorTargetAngularVelocity";

	private static readonly IntPtr selMotorTargetAngularVelocityHandle = Selector.GetHandle("motorTargetAngularVelocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMotorTargetLinearVelocity = "motorTargetLinearVelocity";

	private static readonly IntPtr selMotorTargetLinearVelocityHandle = Selector.GetHandle("motorTargetLinearVelocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorA_ = "setAnchorA:";

	private static readonly IntPtr selSetAnchorA_Handle = Selector.GetHandle("setAnchorA:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorB_ = "setAnchorB:";

	private static readonly IntPtr selSetAnchorB_Handle = Selector.GetHandle("setAnchorB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAxisA_ = "setAxisA:";

	private static readonly IntPtr selSetAxisA_Handle = Selector.GetHandle("setAxisA:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAxisB_ = "setAxisB:";

	private static readonly IntPtr selSetAxisB_Handle = Selector.GetHandle("setAxisB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumAngularLimit_ = "setMaximumAngularLimit:";

	private static readonly IntPtr selSetMaximumAngularLimit_Handle = Selector.GetHandle("setMaximumAngularLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumLinearLimit_ = "setMaximumLinearLimit:";

	private static readonly IntPtr selSetMaximumLinearLimit_Handle = Selector.GetHandle("setMaximumLinearLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumAngularLimit_ = "setMinimumAngularLimit:";

	private static readonly IntPtr selSetMinimumAngularLimit_Handle = Selector.GetHandle("setMinimumAngularLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumLinearLimit_ = "setMinimumLinearLimit:";

	private static readonly IntPtr selSetMinimumLinearLimit_Handle = Selector.GetHandle("setMinimumLinearLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMotorMaximumForce_ = "setMotorMaximumForce:";

	private static readonly IntPtr selSetMotorMaximumForce_Handle = Selector.GetHandle("setMotorMaximumForce:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMotorMaximumTorque_ = "setMotorMaximumTorque:";

	private static readonly IntPtr selSetMotorMaximumTorque_Handle = Selector.GetHandle("setMotorMaximumTorque:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMotorTargetAngularVelocity_ = "setMotorTargetAngularVelocity:";

	private static readonly IntPtr selSetMotorTargetAngularVelocity_Handle = Selector.GetHandle("setMotorTargetAngularVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMotorTargetLinearVelocity_ = "setMotorTargetLinearVelocity:";

	private static readonly IntPtr selSetMotorTargetLinearVelocity_Handle = Selector.GetHandle("setMotorTargetLinearVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsSliderJoint");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 AnchorA
	{
		[Export("anchorA")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAnchorAHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAnchorAHandle);
			}
			return retval;
		}
		[Export("setAnchorA:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAnchorA_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAnchorA_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 AnchorB
	{
		[Export("anchorB")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAnchorBHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAnchorBHandle);
			}
			return retval;
		}
		[Export("setAnchorB:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAnchorB_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAnchorB_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 AxisA
	{
		[Export("axisA")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAxisAHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAxisAHandle);
			}
			return retval;
		}
		[Export("setAxisA:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAxisA_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAxisA_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 AxisB
	{
		[Export("axisB")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAxisBHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAxisBHandle);
			}
			return retval;
		}
		[Export("setAxisB:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAxisB_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAxisB_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsBody BodyA
	{
		[Export("bodyA")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSend(base.Handle, selBodyAHandle));
			}
			return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBodyAHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsBody BodyB
	{
		[Export("bodyB")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSend(base.Handle, selBodyBHandle));
			}
			return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBodyBHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MaximumAngularLimit
	{
		[Export("maximumAngularLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumAngularLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumAngularLimitHandle);
		}
		[Export("setMaximumAngularLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaximumAngularLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaximumAngularLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MaximumLinearLimit
	{
		[Export("maximumLinearLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumLinearLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumLinearLimitHandle);
		}
		[Export("setMaximumLinearLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaximumLinearLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaximumLinearLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumAngularLimit
	{
		[Export("minimumAngularLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumAngularLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumAngularLimitHandle);
		}
		[Export("setMinimumAngularLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumAngularLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumAngularLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumLinearLimit
	{
		[Export("minimumLinearLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumLinearLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumLinearLimitHandle);
		}
		[Export("setMinimumLinearLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumLinearLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumLinearLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MotorMaximumForce
	{
		[Export("motorMaximumForce")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMotorMaximumForceHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMotorMaximumForceHandle);
		}
		[Export("setMotorMaximumForce:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMotorMaximumForce_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMotorMaximumForce_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MotorMaximumTorque
	{
		[Export("motorMaximumTorque")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMotorMaximumTorqueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMotorMaximumTorqueHandle);
		}
		[Export("setMotorMaximumTorque:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMotorMaximumTorque_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMotorMaximumTorque_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MotorTargetAngularVelocity
	{
		[Export("motorTargetAngularVelocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMotorTargetAngularVelocityHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMotorTargetAngularVelocityHandle);
		}
		[Export("setMotorTargetAngularVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMotorTargetAngularVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMotorTargetAngularVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MotorTargetLinearVelocity
	{
		[Export("motorTargetLinearVelocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMotorTargetLinearVelocityHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMotorTargetLinearVelocityHandle);
		}
		[Export("setMotorTargetLinearVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMotorTargetLinearVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMotorTargetLinearVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNPhysicsSliderJoint(NSCoder coder)
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
	protected SCNPhysicsSliderJoint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsSliderJoint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("jointWithBodyA:axisA:anchorA:bodyB:axisB:anchorB:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsSliderJoint Create(SCNPhysicsBody bodyA, SCNVector3 axisA, SCNVector3 anchorA, SCNPhysicsBody bodyB, SCNVector3 axisB, SCNVector3 anchorB)
	{
		if (bodyA == null)
		{
			throw new ArgumentNullException("bodyA");
		}
		if (bodyB == null)
		{
			throw new ArgumentNullException("bodyB");
		}
		return Runtime.GetNSObject<SCNPhysicsSliderJoint>(Messaging.IntPtr_objc_msgSend_IntPtr_SCNVector3_SCNVector3_IntPtr_SCNVector3_SCNVector3(class_ptr, selJointWithBodyA_AxisA_AnchorA_BodyB_AxisB_AnchorB_Handle, bodyA.Handle, axisA, anchorA, bodyB.Handle, axisB, anchorB));
	}

	[Export("jointWithBody:axis:anchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsSliderJoint Create(SCNPhysicsBody body, SCNVector3 axis, SCNVector3 anchor)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return Runtime.GetNSObject<SCNPhysicsSliderJoint>(Messaging.IntPtr_objc_msgSend_IntPtr_SCNVector3_SCNVector3(class_ptr, selJointWithBody_Axis_Anchor_Handle, body.Handle, axis, anchor));
	}
}
