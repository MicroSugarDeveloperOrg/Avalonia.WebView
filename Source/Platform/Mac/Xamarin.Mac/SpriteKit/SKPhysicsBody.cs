using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKPhysicsBody", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKPhysicsBody : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAffectedByGravity = "affectedByGravity";

	private static readonly IntPtr selAffectedByGravityHandle = Selector.GetHandle("affectedByGravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllContactedBodies = "allContactedBodies";

	private static readonly IntPtr selAllContactedBodiesHandle = Selector.GetHandle("allContactedBodies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsRotation = "allowsRotation";

	private static readonly IntPtr selAllowsRotationHandle = Selector.GetHandle("allowsRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAngularDamping = "angularDamping";

	private static readonly IntPtr selAngularDampingHandle = Selector.GetHandle("angularDamping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAngularVelocity = "angularVelocity";

	private static readonly IntPtr selAngularVelocityHandle = Selector.GetHandle("angularVelocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyAngularImpulse_ = "applyAngularImpulse:";

	private static readonly IntPtr selApplyAngularImpulse_Handle = Selector.GetHandle("applyAngularImpulse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyForce_ = "applyForce:";

	private static readonly IntPtr selApplyForce_Handle = Selector.GetHandle("applyForce:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyForce_AtPoint_ = "applyForce:atPoint:";

	private static readonly IntPtr selApplyForce_AtPoint_Handle = Selector.GetHandle("applyForce:atPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyImpulse_ = "applyImpulse:";

	private static readonly IntPtr selApplyImpulse_Handle = Selector.GetHandle("applyImpulse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyImpulse_AtPoint_ = "applyImpulse:atPoint:";

	private static readonly IntPtr selApplyImpulse_AtPoint_Handle = Selector.GetHandle("applyImpulse:atPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyTorque_ = "applyTorque:";

	private static readonly IntPtr selApplyTorque_Handle = Selector.GetHandle("applyTorque:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArea = "area";

	private static readonly IntPtr selAreaHandle = Selector.GetHandle("area");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithBodies_ = "bodyWithBodies:";

	private static readonly IntPtr selBodyWithBodies_Handle = Selector.GetHandle("bodyWithBodies:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithCircleOfRadius_ = "bodyWithCircleOfRadius:";

	private static readonly IntPtr selBodyWithCircleOfRadius_Handle = Selector.GetHandle("bodyWithCircleOfRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithCircleOfRadius_Center_ = "bodyWithCircleOfRadius:center:";

	private static readonly IntPtr selBodyWithCircleOfRadius_Center_Handle = Selector.GetHandle("bodyWithCircleOfRadius:center:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithEdgeChainFromPath_ = "bodyWithEdgeChainFromPath:";

	private static readonly IntPtr selBodyWithEdgeChainFromPath_Handle = Selector.GetHandle("bodyWithEdgeChainFromPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithEdgeFromPoint_ToPoint_ = "bodyWithEdgeFromPoint:toPoint:";

	private static readonly IntPtr selBodyWithEdgeFromPoint_ToPoint_Handle = Selector.GetHandle("bodyWithEdgeFromPoint:toPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithEdgeLoopFromPath_ = "bodyWithEdgeLoopFromPath:";

	private static readonly IntPtr selBodyWithEdgeLoopFromPath_Handle = Selector.GetHandle("bodyWithEdgeLoopFromPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithEdgeLoopFromRect_ = "bodyWithEdgeLoopFromRect:";

	private static readonly IntPtr selBodyWithEdgeLoopFromRect_Handle = Selector.GetHandle("bodyWithEdgeLoopFromRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithPolygonFromPath_ = "bodyWithPolygonFromPath:";

	private static readonly IntPtr selBodyWithPolygonFromPath_Handle = Selector.GetHandle("bodyWithPolygonFromPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithRectangleOfSize_ = "bodyWithRectangleOfSize:";

	private static readonly IntPtr selBodyWithRectangleOfSize_Handle = Selector.GetHandle("bodyWithRectangleOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithRectangleOfSize_Center_ = "bodyWithRectangleOfSize:center:";

	private static readonly IntPtr selBodyWithRectangleOfSize_Center_Handle = Selector.GetHandle("bodyWithRectangleOfSize:center:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithTexture_AlphaThreshold_Size_ = "bodyWithTexture:alphaThreshold:size:";

	private static readonly IntPtr selBodyWithTexture_AlphaThreshold_Size_Handle = Selector.GetHandle("bodyWithTexture:alphaThreshold:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyWithTexture_Size_ = "bodyWithTexture:size:";

	private static readonly IntPtr selBodyWithTexture_Size_Handle = Selector.GetHandle("bodyWithTexture:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategoryBitMask = "categoryBitMask";

	private static readonly IntPtr selCategoryBitMaskHandle = Selector.GetHandle("categoryBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharge = "charge";

	private static readonly IntPtr selChargeHandle = Selector.GetHandle("charge");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollisionBitMask = "collisionBitMask";

	private static readonly IntPtr selCollisionBitMaskHandle = Selector.GetHandle("collisionBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactTestBitMask = "contactTestBitMask";

	private static readonly IntPtr selContactTestBitMaskHandle = Selector.GetHandle("contactTestBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDensity = "density";

	private static readonly IntPtr selDensityHandle = Selector.GetHandle("density");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFieldBitMask = "fieldBitMask";

	private static readonly IntPtr selFieldBitMaskHandle = Selector.GetHandle("fieldBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFriction = "friction";

	private static readonly IntPtr selFrictionHandle = Selector.GetHandle("friction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDynamic = "isDynamic";

	private static readonly IntPtr selIsDynamicHandle = Selector.GetHandle("isDynamic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsResting = "isResting";

	private static readonly IntPtr selIsRestingHandle = Selector.GetHandle("isResting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJoints = "joints";

	private static readonly IntPtr selJointsHandle = Selector.GetHandle("joints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinearDamping = "linearDamping";

	private static readonly IntPtr selLinearDampingHandle = Selector.GetHandle("linearDamping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMass = "mass";

	private static readonly IntPtr selMassHandle = Selector.GetHandle("mass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNode = "node";

	private static readonly IntPtr selNodeHandle = Selector.GetHandle("node");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPinned = "pinned";

	private static readonly IntPtr selPinnedHandle = Selector.GetHandle("pinned");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestitution = "restitution";

	private static readonly IntPtr selRestitutionHandle = Selector.GetHandle("restitution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAffectedByGravity_ = "setAffectedByGravity:";

	private static readonly IntPtr selSetAffectedByGravity_Handle = Selector.GetHandle("setAffectedByGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsRotation_ = "setAllowsRotation:";

	private static readonly IntPtr selSetAllowsRotation_Handle = Selector.GetHandle("setAllowsRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAngularDamping_ = "setAngularDamping:";

	private static readonly IntPtr selSetAngularDamping_Handle = Selector.GetHandle("setAngularDamping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAngularVelocity_ = "setAngularVelocity:";

	private static readonly IntPtr selSetAngularVelocity_Handle = Selector.GetHandle("setAngularVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCategoryBitMask_ = "setCategoryBitMask:";

	private static readonly IntPtr selSetCategoryBitMask_Handle = Selector.GetHandle("setCategoryBitMask:");

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
	private const string selSetDensity_ = "setDensity:";

	private static readonly IntPtr selSetDensity_Handle = Selector.GetHandle("setDensity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDynamic_ = "setDynamic:";

	private static readonly IntPtr selSetDynamic_Handle = Selector.GetHandle("setDynamic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFieldBitMask_ = "setFieldBitMask:";

	private static readonly IntPtr selSetFieldBitMask_Handle = Selector.GetHandle("setFieldBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFriction_ = "setFriction:";

	private static readonly IntPtr selSetFriction_Handle = Selector.GetHandle("setFriction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLinearDamping_ = "setLinearDamping:";

	private static readonly IntPtr selSetLinearDamping_Handle = Selector.GetHandle("setLinearDamping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMass_ = "setMass:";

	private static readonly IntPtr selSetMass_Handle = Selector.GetHandle("setMass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPinned_ = "setPinned:";

	private static readonly IntPtr selSetPinned_Handle = Selector.GetHandle("setPinned:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResting_ = "setResting:";

	private static readonly IntPtr selSetResting_Handle = Selector.GetHandle("setResting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRestitution_ = "setRestitution:";

	private static readonly IntPtr selSetRestitution_Handle = Selector.GetHandle("setRestitution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesPreciseCollisionDetection_ = "setUsesPreciseCollisionDetection:";

	private static readonly IntPtr selSetUsesPreciseCollisionDetection_Handle = Selector.GetHandle("setUsesPreciseCollisionDetection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVelocity_ = "setVelocity:";

	private static readonly IntPtr selSetVelocity_Handle = Selector.GetHandle("setVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesPreciseCollisionDetection = "usesPreciseCollisionDetection";

	private static readonly IntPtr selUsesPreciseCollisionDetectionHandle = Selector.GetHandle("usesPreciseCollisionDetection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVelocity = "velocity";

	private static readonly IntPtr selVelocityHandle = Selector.GetHandle("velocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPhysicsBody");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Node_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AffectedByGravity
	{
		[Export("affectedByGravity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAffectedByGravityHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAffectedByGravityHandle);
		}
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
	public virtual SKPhysicsBody[] AllContactedBodies
	{
		[Export("allContactedBodies")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllContactedBodiesHandle));
			}
			return NSArray.ArrayFromHandle<SKPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllContactedBodiesHandle));
		}
	}

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
	public virtual nfloat AngularDamping
	{
		[Export("angularDamping", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAngularDampingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAngularDampingHandle);
		}
		[Export("setAngularDamping:", ArgumentSemantic.Assign)]
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
	public virtual nfloat AngularVelocity
	{
		[Export("angularVelocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAngularVelocityHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAngularVelocityHandle);
		}
		[Export("setAngularVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAngularVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAngularVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Area
	{
		[Export("area")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAreaHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAreaHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint CategoryBitMask
	{
		[Export("categoryBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selCategoryBitMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selCategoryBitMaskHandle);
		}
		[Export("setCategoryBitMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetCategoryBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetCategoryBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nfloat Charge
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("charge")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selChargeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selChargeHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	public virtual uint CollisionBitMask
	{
		[Export("collisionBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selCollisionBitMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selCollisionBitMaskHandle);
		}
		[Export("setCollisionBitMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetCollisionBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetCollisionBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint ContactTestBitMask
	{
		[Export("contactTestBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selContactTestBitMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selContactTestBitMaskHandle);
		}
		[Export("setContactTestBitMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetContactTestBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetContactTestBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Density
	{
		[Export("density")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDensityHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDensityHandle);
		}
		[Export("setDensity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetDensity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetDensity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Dynamic
	{
		[Export("isDynamic")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDynamicHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDynamicHandle);
		}
		[Export("setDynamic:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDynamic_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDynamic_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual uint FieldBitMask
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("fieldBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selFieldBitMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFieldBitMaskHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setFieldBitMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetFieldBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetFieldBitMask_Handle, value);
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
	public virtual SKPhysicsJoint[] Joints
	{
		[Export("joints")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKPhysicsJoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selJointsHandle));
			}
			return NSArray.ArrayFromHandle<SKPhysicsJoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selJointsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LinearDamping
	{
		[Export("linearDamping", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLinearDampingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLinearDampingHandle);
		}
		[Export("setLinearDamping:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLinearDamping_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLinearDamping_Handle, value);
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
	public virtual SKNode Node
	{
		[Export("node", ArgumentSemantic.Weak)]
		get
		{
			SKNode sKNode = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeHandle)) : Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeHandle)));
			MarkDirty();
			__mt_Node_var = sKNode;
			return sKNode;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool Pinned
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("pinned")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPinnedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPinnedHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPinned:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPinned_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPinned_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Resting
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
		[Export("setResting:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetResting_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetResting_Handle, value);
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
	public virtual bool UsesPreciseCollisionDetection
	{
		[Export("usesPreciseCollisionDetection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesPreciseCollisionDetectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesPreciseCollisionDetectionHandle);
		}
		[Export("setUsesPreciseCollisionDetection:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesPreciseCollisionDetection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesPreciseCollisionDetection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGVector Velocity
	{
		[Export("velocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGVector_objc_msgSend(base.Handle, selVelocityHandle);
			}
			return Messaging.CGVector_objc_msgSendSuper(base.SuperHandle, selVelocityHandle);
		}
		[Export("setVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGVector(base.Handle, selSetVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGVector(base.SuperHandle, selSetVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKPhysicsBody(NSCoder coder)
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
	protected SKPhysicsBody(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPhysicsBody(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applyAngularImpulse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyAngularImpulse(nfloat impulse)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, selApplyAngularImpulse_Handle, impulse);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selApplyAngularImpulse_Handle, impulse);
		}
	}

	[Export("applyForce:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyForce(CGVector force)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGVector(base.Handle, selApplyForce_Handle, force);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGVector(base.SuperHandle, selApplyForce_Handle, force);
		}
	}

	[Export("applyForce:atPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyForce(CGVector force, CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGVector_CGPoint(base.Handle, selApplyForce_AtPoint_Handle, force, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGVector_CGPoint(base.SuperHandle, selApplyForce_AtPoint_Handle, force, point);
		}
	}

	[Export("applyImpulse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyImpulse(CGVector impulse)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGVector(base.Handle, selApplyImpulse_Handle, impulse);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGVector(base.SuperHandle, selApplyImpulse_Handle, impulse);
		}
	}

	[Export("applyImpulse:atPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyImpulse(CGVector impulse, CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGVector_CGPoint(base.Handle, selApplyImpulse_AtPoint_Handle, impulse, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGVector_CGPoint(base.SuperHandle, selApplyImpulse_AtPoint_Handle, impulse, point);
		}
	}

	[Export("applyTorque:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyTorque(nfloat torque)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, selApplyTorque_Handle, torque);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selApplyTorque_Handle, torque);
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

	[Export("bodyWithTexture:size:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody Create(SKTexture texture, CGSize size)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize(class_ptr, selBodyWithTexture_Size_Handle, texture.Handle, size));
	}

	[Export("bodyWithTexture:alphaThreshold:size:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody Create(SKTexture texture, float alphaThreshold, CGSize size)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_IntPtr_float_CGSize(class_ptr, selBodyWithTexture_AlphaThreshold_Size_Handle, texture.Handle, alphaThreshold, size));
	}

	[Export("bodyWithPolygonFromPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody CreateBodyFromPath(CGPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBodyWithPolygonFromPath_Handle, path.Handle));
	}

	[Export("bodyWithCircleOfRadius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody CreateCircularBody(nfloat radius)
	{
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selBodyWithCircleOfRadius_Handle, radius));
	}

	[Export("bodyWithCircleOfRadius:center:")]
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody CreateCircularBody(nfloat radius, CGPoint center)
	{
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_nfloat_CGPoint(class_ptr, selBodyWithCircleOfRadius_Center_Handle, radius, center));
	}

	[Export("bodyWithEdgeFromPoint:toPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody CreateEdge(CGPoint fromPoint, CGPoint toPoint)
	{
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_CGPoint_CGPoint(class_ptr, selBodyWithEdgeFromPoint_ToPoint_Handle, fromPoint, toPoint));
	}

	[Export("bodyWithEdgeChainFromPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody CreateEdgeChain(CGPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBodyWithEdgeChainFromPath_Handle, path.Handle));
	}

	[Export("bodyWithEdgeLoopFromPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody CreateEdgeLoop(CGPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBodyWithEdgeLoopFromPath_Handle, path.Handle));
	}

	[Export("bodyWithEdgeLoopFromRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody CreateEdgeLoop(CGRect rect)
	{
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selBodyWithEdgeLoopFromRect_Handle, rect));
	}

	[Export("bodyWithRectangleOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody CreateRectangularBody(CGSize size)
	{
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_CGSize(class_ptr, selBodyWithRectangleOfSize_Handle, size));
	}

	[Export("bodyWithRectangleOfSize:center:")]
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody CreateRectangularBody(CGSize size, CGPoint center)
	{
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_CGSize_CGPoint(class_ptr, selBodyWithRectangleOfSize_Center_Handle, size, center));
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

	[Export("bodyWithBodies:")]
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKPhysicsBody FromBodies(SKPhysicsBody[] bodies)
	{
		if (bodies == null)
		{
			throw new ArgumentNullException("bodies");
		}
		NSArray nSArray = NSArray.FromNSObjects(bodies);
		SKPhysicsBody nSObject = Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBodyWithBodies_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Node_var = null;
		}
	}
}
