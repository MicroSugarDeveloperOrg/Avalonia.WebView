using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNPhysicsField", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsField : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategoryBitMask = "categoryBitMask";

	private static readonly IntPtr selCategoryBitMaskHandle = Selector.GetHandle("categoryBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomFieldWithEvaluationBlock_ = "customFieldWithEvaluationBlock:";

	private static readonly IntPtr selCustomFieldWithEvaluationBlock_Handle = Selector.GetHandle("customFieldWithEvaluationBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDirection = "direction";

	private static readonly IntPtr selDirectionHandle = Selector.GetHandle("direction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDragField = "dragField";

	private static readonly IntPtr selDragFieldHandle = Selector.GetHandle("dragField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElectricField = "electricField";

	private static readonly IntPtr selElectricFieldHandle = Selector.GetHandle("electricField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFalloffExponent = "falloffExponent";

	private static readonly IntPtr selFalloffExponentHandle = Selector.GetHandle("falloffExponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHalfExtent = "halfExtent";

	private static readonly IntPtr selHalfExtentHandle = Selector.GetHandle("halfExtent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsActive = "isActive";

	private static readonly IntPtr selIsActiveHandle = Selector.GetHandle("isActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExclusive = "isExclusive";

	private static readonly IntPtr selIsExclusiveHandle = Selector.GetHandle("isExclusive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinearGravityField = "linearGravityField";

	private static readonly IntPtr selLinearGravityFieldHandle = Selector.GetHandle("linearGravityField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagneticField = "magneticField";

	private static readonly IntPtr selMagneticFieldHandle = Selector.GetHandle("magneticField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumDistance = "minimumDistance";

	private static readonly IntPtr selMinimumDistanceHandle = Selector.GetHandle("minimumDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseFieldWithSmoothness_AnimationSpeed_ = "noiseFieldWithSmoothness:animationSpeed:";

	private static readonly IntPtr selNoiseFieldWithSmoothness_AnimationSpeed_Handle = Selector.GetHandle("noiseFieldWithSmoothness:animationSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffset = "offset";

	private static readonly IntPtr selOffsetHandle = Selector.GetHandle("offset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRadialGravityField = "radialGravityField";

	private static readonly IntPtr selRadialGravityFieldHandle = Selector.GetHandle("radialGravityField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScope = "scope";

	private static readonly IntPtr selScopeHandle = Selector.GetHandle("scope");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActive_ = "setActive:";

	private static readonly IntPtr selSetActive_Handle = Selector.GetHandle("setActive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCategoryBitMask_ = "setCategoryBitMask:";

	private static readonly IntPtr selSetCategoryBitMask_Handle = Selector.GetHandle("setCategoryBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDirection_ = "setDirection:";

	private static readonly IntPtr selSetDirection_Handle = Selector.GetHandle("setDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExclusive_ = "setExclusive:";

	private static readonly IntPtr selSetExclusive_Handle = Selector.GetHandle("setExclusive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFalloffExponent_ = "setFalloffExponent:";

	private static readonly IntPtr selSetFalloffExponent_Handle = Selector.GetHandle("setFalloffExponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHalfExtent_ = "setHalfExtent:";

	private static readonly IntPtr selSetHalfExtent_Handle = Selector.GetHandle("setHalfExtent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumDistance_ = "setMinimumDistance:";

	private static readonly IntPtr selSetMinimumDistance_Handle = Selector.GetHandle("setMinimumDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOffset_ = "setOffset:";

	private static readonly IntPtr selSetOffset_Handle = Selector.GetHandle("setOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScope_ = "setScope:";

	private static readonly IntPtr selSetScope_Handle = Selector.GetHandle("setScope:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrength_ = "setStrength:";

	private static readonly IntPtr selSetStrength_Handle = Selector.GetHandle("setStrength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesEllipsoidalExtent_ = "setUsesEllipsoidalExtent:";

	private static readonly IntPtr selSetUsesEllipsoidalExtent_Handle = Selector.GetHandle("setUsesEllipsoidalExtent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpringField = "springField";

	private static readonly IntPtr selSpringFieldHandle = Selector.GetHandle("springField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrength = "strength";

	private static readonly IntPtr selStrengthHandle = Selector.GetHandle("strength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTurbulenceFieldWithSmoothness_AnimationSpeed_ = "turbulenceFieldWithSmoothness:animationSpeed:";

	private static readonly IntPtr selTurbulenceFieldWithSmoothness_AnimationSpeed_Handle = Selector.GetHandle("turbulenceFieldWithSmoothness:animationSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesEllipsoidalExtent = "usesEllipsoidalExtent";

	private static readonly IntPtr selUsesEllipsoidalExtentHandle = Selector.GetHandle("usesEllipsoidalExtent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVortexField = "vortexField";

	private static readonly IntPtr selVortexFieldHandle = Selector.GetHandle("vortexField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsField");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Active
	{
		[Export("isActive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsActiveHandle);
		}
		[Export("setActive:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetActive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetActive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CategoryBitMask
	{
		[Export("categoryBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCategoryBitMaskHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCategoryBitMaskHandle);
		}
		[Export("setCategoryBitMask:")]
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
	public virtual SCNVector3 Direction
	{
		[Export("direction")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selDirectionHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDirectionHandle);
			}
			return retval;
		}
		[Export("setDirection:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetDirection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetDirection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Exclusive
	{
		[Export("isExclusive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExclusiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExclusiveHandle);
		}
		[Export("setExclusive:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetExclusive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExclusive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat FalloffExponent
	{
		[Export("falloffExponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFalloffExponentHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFalloffExponentHandle);
		}
		[Export("setFalloffExponent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFalloffExponent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFalloffExponent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 HalfExtent
	{
		[Export("halfExtent")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selHalfExtentHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selHalfExtentHandle);
			}
			return retval;
		}
		[Export("setHalfExtent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetHalfExtent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetHalfExtent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumDistance
	{
		[Export("minimumDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumDistanceHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumDistanceHandle);
		}
		[Export("setMinimumDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 Offset
	{
		[Export("offset")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selOffsetHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selOffsetHandle);
			}
			return retval;
		}
		[Export("setOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsFieldScope Scope
	{
		[Export("scope")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNPhysicsFieldScope)Messaging.Int64_objc_msgSend(base.Handle, selScopeHandle);
			}
			return (SCNPhysicsFieldScope)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selScopeHandle);
		}
		[Export("setScope:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetScope_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetScope_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Strength
	{
		[Export("strength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selStrengthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStrengthHandle);
		}
		[Export("setStrength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetStrength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetStrength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesEllipsoidalExtent
	{
		[Export("usesEllipsoidalExtent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesEllipsoidalExtentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesEllipsoidalExtentHandle);
		}
		[Export("setUsesEllipsoidalExtent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesEllipsoidalExtent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesEllipsoidalExtent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNPhysicsField(NSCoder coder)
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
	protected SCNPhysicsField(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsField(IntPtr handle)
		: base(handle)
	{
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

	[Export("dragField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsField CreateDragField()
	{
		return Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend(class_ptr, selDragFieldHandle));
	}

	[Export("electricField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsField CreateElectricField()
	{
		return Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend(class_ptr, selElectricFieldHandle));
	}

	[Export("linearGravityField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsField CreateLinearGravityField()
	{
		return Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend(class_ptr, selLinearGravityFieldHandle));
	}

	[Export("magneticField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsField CreateMagneticField()
	{
		return Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend(class_ptr, selMagneticFieldHandle));
	}

	[Export("noiseFieldWithSmoothness:animationSpeed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsField CreateNoiseField(nfloat smoothness, nfloat speed)
	{
		return Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selNoiseFieldWithSmoothness_AnimationSpeed_Handle, smoothness, speed));
	}

	[Export("radialGravityField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsField CreateRadialGravityField()
	{
		return Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend(class_ptr, selRadialGravityFieldHandle));
	}

	[Export("springField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsField CreateSpringField()
	{
		return Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend(class_ptr, selSpringFieldHandle));
	}

	[Export("turbulenceFieldWithSmoothness:animationSpeed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsField CreateTurbulenceField(nfloat smoothness, nfloat speed)
	{
		return Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selTurbulenceFieldWithSmoothness_AnimationSpeed_Handle, smoothness, speed));
	}

	[Export("vortexField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsField CreateVortexField()
	{
		return Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend(class_ptr, selVortexFieldHandle));
	}

	[Export("customFieldWithEvaluationBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SCNPhysicsField CustomField([BlockProxy(typeof(Trampolines.NIDSCNFieldForceEvaluator))] SCNFieldForceEvaluator evaluator)
	{
		if (evaluator == null)
		{
			throw new ArgumentNullException("evaluator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNFieldForceEvaluator.Handler, evaluator);
		SCNPhysicsField nSObject = Runtime.GetNSObject<SCNPhysicsField>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCustomFieldWithEvaluationBlock_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
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
}
