using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SceneKit;

[Register("SCNPhysicsBody", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsBody : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsResting = "allowsResting";

	private static readonly IntPtr selAllowsRestingHandle = Selector.GetHandle("allowsResting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAngularDamping = "angularDamping";

	private static readonly IntPtr selAngularDampingHandle = Selector.GetHandle("angularDamping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAngularRestingThreshold = "angularRestingThreshold";

	private static readonly IntPtr selAngularRestingThresholdHandle = Selector.GetHandle("angularRestingThreshold");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAngularVelocity = "angularVelocity";

	private static readonly IntPtr selAngularVelocityHandle = Selector.GetHandle("angularVelocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAngularVelocityFactor = "angularVelocityFactor";

	private static readonly IntPtr selAngularVelocityFactorHandle = Selector.GetHandle("angularVelocityFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyForce_AtPosition_Impulse_ = "applyForce:atPosition:impulse:";

	private static readonly IntPtr selApplyForce_AtPosition_Impulse_Handle = Selector.GetHandle("applyForce:atPosition:impulse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyForce_Impulse_ = "applyForce:impulse:";

	private static readonly IntPtr selApplyForce_Impulse_Handle = Selector.GetHandle("applyForce:impulse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyTorque_Impulse_ = "applyTorque:impulse:";

	private static readonly IntPtr selApplyTorque_Impulse_Handle = Selector.GetHandle("applyTorque:impulse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithType_Shape_ = "bodyWithType:shape:";

	private static readonly IntPtr selBodyWithType_Shape_Handle = Selector.GetHandle("bodyWithType:shape:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategoryBitMask = "categoryBitMask";

	private static readonly IntPtr selCategoryBitMaskHandle = Selector.GetHandle("categoryBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterOfMassOffset = "centerOfMassOffset";

	private static readonly IntPtr selCenterOfMassOffsetHandle = Selector.GetHandle("centerOfMassOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharge = "charge";

	private static readonly IntPtr selChargeHandle = Selector.GetHandle("charge");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearAllForces = "clearAllForces";

	private static readonly IntPtr selClearAllForcesHandle = Selector.GetHandle("clearAllForces");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollisionBitMask = "collisionBitMask";

	private static readonly IntPtr selCollisionBitMaskHandle = Selector.GetHandle("collisionBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactTestBitMask = "contactTestBitMask";

	private static readonly IntPtr selContactTestBitMaskHandle = Selector.GetHandle("contactTestBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContinuousCollisionDetectionThreshold = "continuousCollisionDetectionThreshold";

	private static readonly IntPtr selContinuousCollisionDetectionThresholdHandle = Selector.GetHandle("continuousCollisionDetectionThreshold");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDamping = "damping";

	private static readonly IntPtr selDampingHandle = Selector.GetHandle("damping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDynamicBody = "dynamicBody";

	private static readonly IntPtr selDynamicBodyHandle = Selector.GetHandle("dynamicBody");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFriction = "friction";

	private static readonly IntPtr selFrictionHandle = Selector.GetHandle("friction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAffectedByGravity = "isAffectedByGravity";

	private static readonly IntPtr selIsAffectedByGravityHandle = Selector.GetHandle("isAffectedByGravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsResting = "isResting";

	private static readonly IntPtr selIsRestingHandle = Selector.GetHandle("isResting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKinematicBody = "kinematicBody";

	private static readonly IntPtr selKinematicBodyHandle = Selector.GetHandle("kinematicBody");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinearRestingThreshold = "linearRestingThreshold";

	private static readonly IntPtr selLinearRestingThresholdHandle = Selector.GetHandle("linearRestingThreshold");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMass = "mass";

	private static readonly IntPtr selMassHandle = Selector.GetHandle("mass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMomentOfInertia = "momentOfInertia";

	private static readonly IntPtr selMomentOfInertiaHandle = Selector.GetHandle("momentOfInertia");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhysicsShape = "physicsShape";

	private static readonly IntPtr selPhysicsShapeHandle = Selector.GetHandle("physicsShape");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetTransform = "resetTransform";

	private static readonly IntPtr selResetTransformHandle = Selector.GetHandle("resetTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestitution = "restitution";

	private static readonly IntPtr selRestitutionHandle = Selector.GetHandle("restitution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRollingFriction = "rollingFriction";

	private static readonly IntPtr selRollingFrictionHandle = Selector.GetHandle("rollingFriction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAffectedByGravity_ = "setAffectedByGravity:";

	private static readonly IntPtr selSetAffectedByGravity_Handle = Selector.GetHandle("setAffectedByGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsResting_ = "setAllowsResting:";

	private static readonly IntPtr selSetAllowsResting_Handle = Selector.GetHandle("setAllowsResting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAngularDamping_ = "setAngularDamping:";

	private static readonly IntPtr selSetAngularDamping_Handle = Selector.GetHandle("setAngularDamping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAngularRestingThreshold_ = "setAngularRestingThreshold:";

	private static readonly IntPtr selSetAngularRestingThreshold_Handle = Selector.GetHandle("setAngularRestingThreshold:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAngularVelocity_ = "setAngularVelocity:";

	private static readonly IntPtr selSetAngularVelocity_Handle = Selector.GetHandle("setAngularVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAngularVelocityFactor_ = "setAngularVelocityFactor:";

	private static readonly IntPtr selSetAngularVelocityFactor_Handle = Selector.GetHandle("setAngularVelocityFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCategoryBitMask_ = "setCategoryBitMask:";

	private static readonly IntPtr selSetCategoryBitMask_Handle = Selector.GetHandle("setCategoryBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCenterOfMassOffset_ = "setCenterOfMassOffset:";

	private static readonly IntPtr selSetCenterOfMassOffset_Handle = Selector.GetHandle("setCenterOfMassOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCharge_ = "setCharge:";

	private static readonly IntPtr selSetCharge_Handle = Selector.GetHandle("setCharge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollisionBitMask_ = "setCollisionBitMask:";

	private static readonly IntPtr selSetCollisionBitMask_Handle = Selector.GetHandle("setCollisionBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContactTestBitMask_ = "setContactTestBitMask:";

	private static readonly IntPtr selSetContactTestBitMask_Handle = Selector.GetHandle("setContactTestBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContinuousCollisionDetectionThreshold_ = "setContinuousCollisionDetectionThreshold:";

	private static readonly IntPtr selSetContinuousCollisionDetectionThreshold_Handle = Selector.GetHandle("setContinuousCollisionDetectionThreshold:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDamping_ = "setDamping:";

	private static readonly IntPtr selSetDamping_Handle = Selector.GetHandle("setDamping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFriction_ = "setFriction:";

	private static readonly IntPtr selSetFriction_Handle = Selector.GetHandle("setFriction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLinearRestingThreshold_ = "setLinearRestingThreshold:";

	private static readonly IntPtr selSetLinearRestingThreshold_Handle = Selector.GetHandle("setLinearRestingThreshold:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMass_ = "setMass:";

	private static readonly IntPtr selSetMass_Handle = Selector.GetHandle("setMass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMomentOfInertia_ = "setMomentOfInertia:";

	private static readonly IntPtr selSetMomentOfInertia_Handle = Selector.GetHandle("setMomentOfInertia:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPhysicsShape_ = "setPhysicsShape:";

	private static readonly IntPtr selSetPhysicsShape_Handle = Selector.GetHandle("setPhysicsShape:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResting_ = "setResting:";

	private static readonly IntPtr selSetResting_Handle = Selector.GetHandle("setResting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRestitution_ = "setRestitution:";

	private static readonly IntPtr selSetRestitution_Handle = Selector.GetHandle("setRestitution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRollingFriction_ = "setRollingFriction:";

	private static readonly IntPtr selSetRollingFriction_Handle = Selector.GetHandle("setRollingFriction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetType_ = "setType:";

	private static readonly IntPtr selSetType_Handle = Selector.GetHandle("setType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesDefaultMomentOfInertia_ = "setUsesDefaultMomentOfInertia:";

	private static readonly IntPtr selSetUsesDefaultMomentOfInertia_Handle = Selector.GetHandle("setUsesDefaultMomentOfInertia:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVelocity_ = "setVelocity:";

	private static readonly IntPtr selSetVelocity_Handle = Selector.GetHandle("setVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVelocityFactor_ = "setVelocityFactor:";

	private static readonly IntPtr selSetVelocityFactor_Handle = Selector.GetHandle("setVelocityFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStaticBody = "staticBody";

	private static readonly IntPtr selStaticBodyHandle = Selector.GetHandle("staticBody");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesDefaultMomentOfInertia = "usesDefaultMomentOfInertia";

	private static readonly IntPtr selUsesDefaultMomentOfInertiaHandle = Selector.GetHandle("usesDefaultMomentOfInertia");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVelocity = "velocity";

	private static readonly IntPtr selVelocityHandle = Selector.GetHandle("velocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVelocityFactor = "velocityFactor";

	private static readonly IntPtr selVelocityFactorHandle = Selector.GetHandle("velocityFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsBody");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool AffectedByGravity
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("isAffectedByGravity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAffectedByGravityHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAffectedByGravityHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAffectedByGravity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAffectedByGravity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAffectedByGravity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsResting
	{
		[Export("allowsResting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsRestingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsRestingHandle);
		}
		[Export("setAllowsResting:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsResting_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsResting_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat AngularDamping
	{
		[Export("angularDamping")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAngularDampingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAngularDampingHandle);
		}
		[Export("setAngularDamping:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAngularDamping_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAngularDamping_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual nfloat AngularRestingThreshold
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("angularRestingThreshold")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAngularRestingThresholdHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAngularRestingThresholdHandle);
		}
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setAngularRestingThreshold:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAngularRestingThreshold_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAngularRestingThreshold_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector4 AngularVelocity
	{
		[Export("angularVelocity")]
		get
		{
			SCNVector4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector4_objc_msgSend_stret(out retval, base.Handle, selAngularVelocityHandle);
			}
			else
			{
				Messaging.SCNVector4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAngularVelocityHandle);
			}
			return retval;
		}
		[Export("setAngularVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector4(base.Handle, selSetAngularVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector4(base.SuperHandle, selSetAngularVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 AngularVelocityFactor
	{
		[Export("angularVelocityFactor")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAngularVelocityFactorHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAngularVelocityFactorHandle);
			}
			return retval;
		}
		[Export("setAngularVelocityFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAngularVelocityFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAngularVelocityFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CategoryBitMask
	{
		[Export("categoryBitMask", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCategoryBitMaskHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCategoryBitMaskHandle);
		}
		[Export("setCategoryBitMask:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetCategoryBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetCategoryBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual SCNVector3 CenterOfMassOffset
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("centerOfMassOffset", ArgumentSemantic.Assign)]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selCenterOfMassOffsetHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCenterOfMassOffsetHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setCenterOfMassOffset:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetCenterOfMassOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetCenterOfMassOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Charge
	{
		[Export("charge")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selChargeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selChargeHandle);
		}
		[Export("setCharge:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetCharge_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetCharge_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CollisionBitMask
	{
		[Export("collisionBitMask", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCollisionBitMaskHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCollisionBitMaskHandle);
		}
		[Export("setCollisionBitMask:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetCollisionBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetCollisionBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nuint ContactTestBitMask
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("contactTestBitMask", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selContactTestBitMaskHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selContactTestBitMaskHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setContactTestBitMask:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetContactTestBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetContactTestBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual nfloat ContinuousCollisionDetectionThreshold
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("continuousCollisionDetectionThreshold")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selContinuousCollisionDetectionThresholdHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selContinuousCollisionDetectionThresholdHandle);
		}
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setContinuousCollisionDetectionThreshold:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetContinuousCollisionDetectionThreshold_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetContinuousCollisionDetectionThreshold_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Damping
	{
		[Export("damping")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDampingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDampingHandle);
		}
		[Export("setDamping:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetDamping_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetDamping_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Friction
	{
		[Export("friction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFrictionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFrictionHandle);
		}
		[Export("setFriction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFriction_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFriction_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsResting
	{
		[Export("isResting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRestingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRestingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual nfloat LinearRestingThreshold
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("linearRestingThreshold")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLinearRestingThresholdHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLinearRestingThresholdHandle);
		}
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setLinearRestingThreshold:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLinearRestingThreshold_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLinearRestingThreshold_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Mass
	{
		[Export("mass")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMassHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMassHandle);
		}
		[Export("setMass:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMass_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMass_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SCNVector3 MomentOfInertia
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("momentOfInertia", ArgumentSemantic.Assign)]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selMomentOfInertiaHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMomentOfInertiaHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setMomentOfInertia:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetMomentOfInertia_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetMomentOfInertia_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsShape PhysicsShape
	{
		[Export("physicsShape", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNPhysicsShape>(Messaging.IntPtr_objc_msgSend(base.Handle, selPhysicsShapeHandle));
			}
			return Runtime.GetNSObject<SCNPhysicsShape>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhysicsShapeHandle));
		}
		[Export("setPhysicsShape:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPhysicsShape_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPhysicsShape_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Restitution
	{
		[Export("restitution")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRestitutionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRestitutionHandle);
		}
		[Export("setRestitution:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRestitution_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRestitution_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RollingFriction
	{
		[Export("rollingFriction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRollingFrictionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRollingFrictionHandle);
		}
		[Export("setRollingFriction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRollingFriction_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRollingFriction_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsBodyType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNPhysicsBodyType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (SCNPhysicsBodyType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
		[Export("setType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool UsesDefaultMomentOfInertia
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("usesDefaultMomentOfInertia")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesDefaultMomentOfInertiaHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesDefaultMomentOfInertiaHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setUsesDefaultMomentOfInertia:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesDefaultMomentOfInertia_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesDefaultMomentOfInertia_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 Velocity
	{
		[Export("velocity")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selVelocityHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVelocityHandle);
			}
			return retval;
		}
		[Export("setVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 VelocityFactor
	{
		[Export("velocityFactor")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selVelocityFactorHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVelocityFactorHandle);
			}
			return retval;
		}
		[Export("setVelocityFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetVelocityFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetVelocityFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNPhysicsBody(NSCoder coder)
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
	protected SCNPhysicsBody(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsBody(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applyForce:impulse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyForce(SCNVector3 direction, bool impulse)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_SCNVector3_bool(base.Handle, selApplyForce_Impulse_Handle, direction, impulse);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_SCNVector3_bool(base.SuperHandle, selApplyForce_Impulse_Handle, direction, impulse);
		}
	}

	[Export("applyForce:atPosition:impulse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyForce(SCNVector3 direction, SCNVector3 position, bool impulse)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_SCNVector3_SCNVector3_bool(base.Handle, selApplyForce_AtPosition_Impulse_Handle, direction, position, impulse);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_SCNVector3_SCNVector3_bool(base.SuperHandle, selApplyForce_AtPosition_Impulse_Handle, direction, position, impulse);
		}
	}

	[Export("applyTorque:impulse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyTorque(SCNVector4 torque, bool impulse)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_SCNVector4_bool(base.Handle, selApplyTorque_Impulse_Handle, torque, impulse);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_SCNVector4_bool(base.SuperHandle, selApplyTorque_Impulse_Handle, torque, impulse);
		}
	}

	[Export("clearAllForces")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearAllForces()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearAllForcesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearAllForcesHandle);
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("bodyWithType:shape:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsBody CreateBody(SCNPhysicsBodyType type, SCNPhysicsShape? shape)
	{
		return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSend_Int64_IntPtr(class_ptr, selBodyWithType_Shape_Handle, (long)type, shape?.Handle ?? IntPtr.Zero));
	}

	[Export("dynamicBody")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsBody CreateDynamicBody()
	{
		return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSend(class_ptr, selDynamicBodyHandle));
	}

	[Export("kinematicBody")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsBody CreateKinematicBody()
	{
		return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSend(class_ptr, selKinematicBodyHandle));
	}

	[Export("staticBody")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsBody CreateStaticBody()
	{
		return Runtime.GetNSObject<SCNPhysicsBody>(Messaging.IntPtr_objc_msgSend(class_ptr, selStaticBodyHandle));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("resetTransform")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResetTransform()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetTransformHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetTransformHandle);
		}
	}

	[Export("setResting:")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetResting(bool resting)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetResting_Handle, resting);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetResting_Handle, resting);
		}
	}
}
