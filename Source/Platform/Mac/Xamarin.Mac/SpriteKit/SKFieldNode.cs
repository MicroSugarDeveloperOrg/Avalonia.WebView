using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace SpriteKit;

[Register("SKFieldNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class SKFieldNode : SKNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationSpeed = "animationSpeed";

	private static readonly IntPtr selAnimationSpeedHandle = Selector.GetHandle("animationSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategoryBitMask = "categoryBitMask";

	private static readonly IntPtr selCategoryBitMaskHandle = Selector.GetHandle("categoryBitMask");

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
	private const string selFalloff = "falloff";

	private static readonly IntPtr selFalloffHandle = Selector.GetHandle("falloff");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExclusive = "isExclusive";

	private static readonly IntPtr selIsExclusiveHandle = Selector.GetHandle("isExclusive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinearGravityFieldWithVector_ = "linearGravityFieldWithVector:";

	private static readonly IntPtr selLinearGravityFieldWithVector_Handle = Selector.GetHandle("linearGravityFieldWithVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagneticField = "magneticField";

	private static readonly IntPtr selMagneticFieldHandle = Selector.GetHandle("magneticField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumRadius = "minimumRadius";

	private static readonly IntPtr selMinimumRadiusHandle = Selector.GetHandle("minimumRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseFieldWithSmoothness_AnimationSpeed_ = "noiseFieldWithSmoothness:animationSpeed:";

	private static readonly IntPtr selNoiseFieldWithSmoothness_AnimationSpeed_Handle = Selector.GetHandle("noiseFieldWithSmoothness:animationSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRadialGravityField = "radialGravityField";

	private static readonly IntPtr selRadialGravityFieldHandle = Selector.GetHandle("radialGravityField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegion = "region";

	private static readonly IntPtr selRegionHandle = Selector.GetHandle("region");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationSpeed_ = "setAnimationSpeed:";

	private static readonly IntPtr selSetAnimationSpeed_Handle = Selector.GetHandle("setAnimationSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCategoryBitMask_ = "setCategoryBitMask:";

	private static readonly IntPtr selSetCategoryBitMask_Handle = Selector.GetHandle("setCategoryBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDirection_ = "setDirection:";

	private static readonly IntPtr selSetDirection_Handle = Selector.GetHandle("setDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExclusive_ = "setExclusive:";

	private static readonly IntPtr selSetExclusive_Handle = Selector.GetHandle("setExclusive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFalloff_ = "setFalloff:";

	private static readonly IntPtr selSetFalloff_Handle = Selector.GetHandle("setFalloff:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumRadius_ = "setMinimumRadius:";

	private static readonly IntPtr selSetMinimumRadius_Handle = Selector.GetHandle("setMinimumRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRegion_ = "setRegion:";

	private static readonly IntPtr selSetRegion_Handle = Selector.GetHandle("setRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSmoothness_ = "setSmoothness:";

	private static readonly IntPtr selSetSmoothness_Handle = Selector.GetHandle("setSmoothness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrength_ = "setStrength:";

	private static readonly IntPtr selSetStrength_Handle = Selector.GetHandle("setStrength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTexture_ = "setTexture:";

	private static readonly IntPtr selSetTexture_Handle = Selector.GetHandle("setTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmoothness = "smoothness";

	private static readonly IntPtr selSmoothnessHandle = Selector.GetHandle("smoothness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpringField = "springField";

	private static readonly IntPtr selSpringFieldHandle = Selector.GetHandle("springField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrength = "strength";

	private static readonly IntPtr selStrengthHandle = Selector.GetHandle("strength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexture = "texture";

	private static readonly IntPtr selTextureHandle = Selector.GetHandle("texture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTurbulenceFieldWithSmoothness_AnimationSpeed_ = "turbulenceFieldWithSmoothness:animationSpeed:";

	private static readonly IntPtr selTurbulenceFieldWithSmoothness_AnimationSpeed_Handle = Selector.GetHandle("turbulenceFieldWithSmoothness:animationSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVelocityFieldWithTexture_ = "velocityFieldWithTexture:";

	private static readonly IntPtr selVelocityFieldWithTexture_Handle = Selector.GetHandle("velocityFieldWithTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVelocityFieldWithVector_ = "velocityFieldWithVector:";

	private static readonly IntPtr selVelocityFieldWithVector_Handle = Selector.GetHandle("velocityFieldWithVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVortexField = "vortexField";

	private static readonly IntPtr selVortexFieldHandle = Selector.GetHandle("vortexField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKFieldNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float AnimationSpeed
	{
		[Export("animationSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAnimationSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAnimationSpeedHandle);
		}
		[Export("setAnimationSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAnimationSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAnimationSpeed_Handle, value);
			}
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
	public virtual Vector4 Direction
	{
		[Export("direction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_vector_float3__Vector4_objc_msgSend(base.Handle, selDirectionHandle);
			}
			return Messaging.xamarin_vector_float3__Vector4_objc_msgSendSuper(base.SuperHandle, selDirectionHandle);
		}
		[Export("setDirection:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_vector_float3__void_objc_msgSend_Vector4(base.Handle, selSetDirection_Handle, value);
			}
			else
			{
				Messaging.xamarin_vector_float3__void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetDirection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
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
	public virtual float Falloff
	{
		[Export("falloff")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFalloffHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFalloffHandle);
		}
		[Export("setFalloff:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFalloff_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFalloff_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinimumRadius
	{
		[Export("minimumRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinimumRadiusHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinimumRadiusHandle);
		}
		[Export("setMinimumRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinimumRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinimumRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKRegion Region
	{
		[Export("region", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSend(base.Handle, selRegionHandle));
			}
			return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRegionHandle));
		}
		[Export("setRegion:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRegion_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRegion_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Smoothness
	{
		[Export("smoothness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSmoothnessHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSmoothnessHandle);
		}
		[Export("setSmoothness:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSmoothness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSmoothness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Strength
	{
		[Export("strength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selStrengthHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selStrengthHandle);
		}
		[Export("setStrength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetStrength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetStrength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture Texture
	{
		[Export("texture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureHandle));
			}
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureHandle));
		}
		[Export("setTexture:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTexture_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTexture_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKFieldNode()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKFieldNode(NSCoder coder)
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
	protected SKFieldNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKFieldNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("customFieldWithEvaluationBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SKFieldNode CreateCustomField([BlockProxy(typeof(Trampolines.NIDSKFieldForceEvaluator))] SKFieldForceEvaluator evaluator)
	{
		if (evaluator == null)
		{
			throw new ArgumentNullException("evaluator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKFieldForceEvaluator.Handler, evaluator);
		SKFieldNode nSObject = Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCustomFieldWithEvaluationBlock_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("dragField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateDragField()
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend(class_ptr, selDragFieldHandle));
	}

	[Export("electricField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateElectricField()
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend(class_ptr, selElectricFieldHandle));
	}

	[Export("linearGravityFieldWithVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateLinearGravityField(Vector4 direction)
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector4(class_ptr, selLinearGravityFieldWithVector_Handle, direction));
	}

	[Export("magneticField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateMagneticField()
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend(class_ptr, selMagneticFieldHandle));
	}

	[Export("noiseFieldWithSmoothness:animationSpeed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateNoiseField(nfloat smoothness, nfloat speed)
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selNoiseFieldWithSmoothness_AnimationSpeed_Handle, smoothness, speed));
	}

	[Export("radialGravityField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateRadialGravityField()
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend(class_ptr, selRadialGravityFieldHandle));
	}

	[Export("springField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateSpringField()
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend(class_ptr, selSpringFieldHandle));
	}

	[Export("turbulenceFieldWithSmoothness:animationSpeed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateTurbulenceField(nfloat smoothness, nfloat speed)
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selTurbulenceFieldWithSmoothness_AnimationSpeed_Handle, smoothness, speed));
	}

	[Export("velocityFieldWithVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateVelocityField(Vector4 direction)
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector4(class_ptr, selVelocityFieldWithVector_Handle, direction));
	}

	[Export("velocityFieldWithTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateVelocityField(SKTexture velocityTexture)
	{
		if (velocityTexture == null)
		{
			throw new ArgumentNullException("velocityTexture");
		}
		return Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVelocityFieldWithTexture_Handle, velocityTexture.Handle));
	}

	[Export("vortexField")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKFieldNode CreateVortexField()
	{
		return Runtime.GetNSObject<SKFieldNode>(Messaging.IntPtr_objc_msgSend(class_ptr, selVortexFieldHandle));
	}
}
