using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ModelIO;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNMaterial", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNMaterial : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding, ISCNAnimatable, ISCNShadable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnimation_ForKey_ = "addAnimation:forKey:";

	private static readonly IntPtr selAddAnimation_ForKey_Handle = Selector.GetHandle("addAnimation:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnimationPlayer_ForKey_ = "addAnimationPlayer:forKey:";

	private static readonly IntPtr selAddAnimationPlayer_ForKey_Handle = Selector.GetHandle("addAnimationPlayer:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAmbient = "ambient";

	private static readonly IntPtr selAmbientHandle = Selector.GetHandle("ambient");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAmbientOcclusion = "ambientOcclusion";

	private static readonly IntPtr selAmbientOcclusionHandle = Selector.GetHandle("ambientOcclusion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationKeys = "animationKeys";

	private static readonly IntPtr selAnimationKeysHandle = Selector.GetHandle("animationKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationPlayerForKey_ = "animationPlayerForKey:";

	private static readonly IntPtr selAnimationPlayerForKey_Handle = Selector.GetHandle("animationPlayerForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendMode = "blendMode";

	private static readonly IntPtr selBlendModeHandle = Selector.GetHandle("blendMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearCoat = "clearCoat";

	private static readonly IntPtr selClearCoatHandle = Selector.GetHandle("clearCoat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearCoatNormal = "clearCoatNormal";

	private static readonly IntPtr selClearCoatNormalHandle = Selector.GetHandle("clearCoatNormal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearCoatRoughness = "clearCoatRoughness";

	private static readonly IntPtr selClearCoatRoughnessHandle = Selector.GetHandle("clearCoatRoughness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorBufferWriteMask = "colorBufferWriteMask";

	private static readonly IntPtr selColorBufferWriteMaskHandle = Selector.GetHandle("colorBufferWriteMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCullMode = "cullMode";

	private static readonly IntPtr selCullModeHandle = Selector.GetHandle("cullMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiffuse = "diffuse";

	private static readonly IntPtr selDiffuseHandle = Selector.GetHandle("diffuse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplacement = "displacement";

	private static readonly IntPtr selDisplacementHandle = Selector.GetHandle("displacement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmission = "emission";

	private static readonly IntPtr selEmissionHandle = Selector.GetHandle("emission");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillMode = "fillMode";

	private static readonly IntPtr selFillModeHandle = Selector.GetHandle("fillMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFresnelExponent = "fresnelExponent";

	private static readonly IntPtr selFresnelExponentHandle = Selector.GetHandle("fresnelExponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleBindingOfSymbol_UsingBlock_ = "handleBindingOfSymbol:usingBlock:";

	private static readonly IntPtr selHandleBindingOfSymbol_UsingBlock_Handle = Selector.GetHandle("handleBindingOfSymbol:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleUnbindingOfSymbol_UsingBlock_ = "handleUnbindingOfSymbol:usingBlock:";

	private static readonly IntPtr selHandleUnbindingOfSymbol_UsingBlock_Handle = Selector.GetHandle("handleUnbindingOfSymbol:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAnimationForKeyPaused_ = "isAnimationForKeyPaused:";

	private static readonly IntPtr selIsAnimationForKeyPaused_Handle = Selector.GetHandle("isAnimationForKeyPaused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDoubleSided = "isDoubleSided";

	private static readonly IntPtr selIsDoubleSidedHandle = Selector.GetHandle("isDoubleSided");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLitPerPixel = "isLitPerPixel";

	private static readonly IntPtr selIsLitPerPixelHandle = Selector.GetHandle("isLitPerPixel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightingModelName = "lightingModelName";

	private static readonly IntPtr selLightingModelNameHandle = Selector.GetHandle("lightingModelName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocksAmbientWithDiffuse = "locksAmbientWithDiffuse";

	private static readonly IntPtr selLocksAmbientWithDiffuseHandle = Selector.GetHandle("locksAmbientWithDiffuse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaterial = "material";

	private static readonly IntPtr selMaterialHandle = Selector.GetHandle("material");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaterialWithMDLMaterial_ = "materialWithMDLMaterial:";

	private static readonly IntPtr selMaterialWithMDLMaterial_Handle = Selector.GetHandle("materialWithMDLMaterial:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetalness = "metalness";

	private static readonly IntPtr selMetalnessHandle = Selector.GetHandle("metalness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiply = "multiply";

	private static readonly IntPtr selMultiplyHandle = Selector.GetHandle("multiply");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNormal = "normal";

	private static readonly IntPtr selNormalHandle = Selector.GetHandle("normal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseAnimationForKey_ = "pauseAnimationForKey:";

	private static readonly IntPtr selPauseAnimationForKey_Handle = Selector.GetHandle("pauseAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgram = "program";

	private static readonly IntPtr selProgramHandle = Selector.GetHandle("program");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadsFromDepthBuffer = "readsFromDepthBuffer";

	private static readonly IntPtr selReadsFromDepthBufferHandle = Selector.GetHandle("readsFromDepthBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReflective = "reflective";

	private static readonly IntPtr selReflectiveHandle = Selector.GetHandle("reflective");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllAnimations = "removeAllAnimations";

	private static readonly IntPtr selRemoveAllAnimationsHandle = Selector.GetHandle("removeAllAnimations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_ = "removeAnimationForKey:";

	private static readonly IntPtr selRemoveAnimationForKey_Handle = Selector.GetHandle("removeAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_BlendOutDuration_ = "removeAnimationForKey:blendOutDuration:";

	private static readonly IntPtr selRemoveAnimationForKey_BlendOutDuration_Handle = Selector.GetHandle("removeAnimationForKey:blendOutDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_FadeOutDuration_ = "removeAnimationForKey:fadeOutDuration:";

	private static readonly IntPtr selRemoveAnimationForKey_FadeOutDuration_Handle = Selector.GetHandle("removeAnimationForKey:fadeOutDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResumeAnimationForKey_ = "resumeAnimationForKey:";

	private static readonly IntPtr selResumeAnimationForKey_Handle = Selector.GetHandle("resumeAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoughness = "roughness";

	private static readonly IntPtr selRoughnessHandle = Selector.GetHandle("roughness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelfIllumination = "selfIllumination";

	private static readonly IntPtr selSelfIlluminationHandle = Selector.GetHandle("selfIllumination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendMode_ = "setBlendMode:";

	private static readonly IntPtr selSetBlendMode_Handle = Selector.GetHandle("setBlendMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorBufferWriteMask_ = "setColorBufferWriteMask:";

	private static readonly IntPtr selSetColorBufferWriteMask_Handle = Selector.GetHandle("setColorBufferWriteMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCullMode_ = "setCullMode:";

	private static readonly IntPtr selSetCullMode_Handle = Selector.GetHandle("setCullMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleSided_ = "setDoubleSided:";

	private static readonly IntPtr selSetDoubleSided_Handle = Selector.GetHandle("setDoubleSided:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillMode_ = "setFillMode:";

	private static readonly IntPtr selSetFillMode_Handle = Selector.GetHandle("setFillMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFresnelExponent_ = "setFresnelExponent:";

	private static readonly IntPtr selSetFresnelExponent_Handle = Selector.GetHandle("setFresnelExponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLightingModelName_ = "setLightingModelName:";

	private static readonly IntPtr selSetLightingModelName_Handle = Selector.GetHandle("setLightingModelName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLitPerPixel_ = "setLitPerPixel:";

	private static readonly IntPtr selSetLitPerPixel_Handle = Selector.GetHandle("setLitPerPixel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocksAmbientWithDiffuse_ = "setLocksAmbientWithDiffuse:";

	private static readonly IntPtr selSetLocksAmbientWithDiffuse_Handle = Selector.GetHandle("setLocksAmbientWithDiffuse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProgram_ = "setProgram:";

	private static readonly IntPtr selSetProgram_Handle = Selector.GetHandle("setProgram:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadsFromDepthBuffer_ = "setReadsFromDepthBuffer:";

	private static readonly IntPtr selSetReadsFromDepthBuffer_Handle = Selector.GetHandle("setReadsFromDepthBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShaderModifiers_ = "setShaderModifiers:";

	private static readonly IntPtr selSetShaderModifiers_Handle = Selector.GetHandle("setShaderModifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShininess_ = "setShininess:";

	private static readonly IntPtr selSetShininess_Handle = Selector.GetHandle("setShininess:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeed_ForAnimationKey_ = "setSpeed:forAnimationKey:";

	private static readonly IntPtr selSetSpeed_ForAnimationKey_Handle = Selector.GetHandle("setSpeed:forAnimationKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransparency_ = "setTransparency:";

	private static readonly IntPtr selSetTransparency_Handle = Selector.GetHandle("setTransparency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransparencyMode_ = "setTransparencyMode:";

	private static readonly IntPtr selSetTransparencyMode_Handle = Selector.GetHandle("setTransparencyMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWritesToDepthBuffer_ = "setWritesToDepthBuffer:";

	private static readonly IntPtr selSetWritesToDepthBuffer_Handle = Selector.GetHandle("setWritesToDepthBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShaderModifiers = "shaderModifiers";

	private static readonly IntPtr selShaderModifiersHandle = Selector.GetHandle("shaderModifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShininess = "shininess";

	private static readonly IntPtr selShininessHandle = Selector.GetHandle("shininess");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpecular = "specular";

	private static readonly IntPtr selSpecularHandle = Selector.GetHandle("specular");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransparency = "transparency";

	private static readonly IntPtr selTransparencyHandle = Selector.GetHandle("transparency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransparencyMode = "transparencyMode";

	private static readonly IntPtr selTransparencyModeHandle = Selector.GetHandle("transparencyMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransparent = "transparent";

	private static readonly IntPtr selTransparentHandle = Selector.GetHandle("transparent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritesToDepthBuffer = "writesToDepthBuffer";

	private static readonly IntPtr selWritesToDepthBufferHandle = Selector.GetHandle("writesToDepthBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNMaterial");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMaterialProperty Ambient
	{
		[Export("ambient")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selAmbientHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAmbientHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty AmbientOcclusion
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("ambientOcclusion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selAmbientOcclusionHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAmbientOcclusionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SCNBlendMode BlendMode
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("blendMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNBlendMode)Messaging.Int64_objc_msgSend(base.Handle, selBlendModeHandle);
			}
			return (SCNBlendMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBlendModeHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setBlendMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBlendMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBlendMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty ClearCoat
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("clearCoat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selClearCoatHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClearCoatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty ClearCoatNormal
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("clearCoatNormal")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selClearCoatNormalHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClearCoatNormalHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty ClearCoatRoughness
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("clearCoatRoughness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selClearCoatRoughnessHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClearCoatRoughnessHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual SCNColorMask ColorBufferWriteMask
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("colorBufferWriteMask", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNColorMask)Messaging.Int64_objc_msgSend(base.Handle, selColorBufferWriteMaskHandle);
			}
			return (SCNColorMask)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selColorBufferWriteMaskHandle);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setColorBufferWriteMask:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetColorBufferWriteMask_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetColorBufferWriteMask_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNCullMode CullMode
	{
		[Export("cullMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNCullMode)Messaging.Int64_objc_msgSend(base.Handle, selCullModeHandle);
			}
			return (SCNCullMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCullModeHandle);
		}
		[Export("setCullMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetCullMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCullMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMaterialProperty Diffuse
	{
		[Export("diffuse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selDiffuseHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDiffuseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty Displacement
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("displacement")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplacementHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplacementHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DoubleSided
	{
		[Export("isDoubleSided")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDoubleSidedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDoubleSidedHandle);
		}
		[Export("setDoubleSided:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDoubleSided_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDoubleSided_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMaterialProperty Emission
	{
		[Export("emission")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selEmissionHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmissionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual SCNFillMode FillMode
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("fillMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNFillMode)Messaging.UInt64_objc_msgSend(base.Handle, selFillModeHandle);
			}
			return (SCNFillMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFillModeHandle);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setFillMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFillMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFillMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual nfloat FresnelExponent
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("fresnelExponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFresnelExponentHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFresnelExponentHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setFresnelExponent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFresnelExponent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFresnelExponent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString LightingModelName
	{
		[Export("lightingModelName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLightingModelNameHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLightingModelNameHandle));
		}
		[Export("setLightingModelName:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLightingModelName_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLightingModelName_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LitPerPixel
	{
		[Export("isLitPerPixel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLitPerPixelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLitPerPixelHandle);
		}
		[Export("setLitPerPixel:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLitPerPixel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLitPerPixel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LocksAmbientWithDiffuse
	{
		[Export("locksAmbientWithDiffuse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLocksAmbientWithDiffuseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLocksAmbientWithDiffuseHandle);
		}
		[Export("setLocksAmbientWithDiffuse:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLocksAmbientWithDiffuse_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLocksAmbientWithDiffuse_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty Metalness
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("metalness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetalnessHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetalnessHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMaterialProperty Multiply
	{
		[Export("multiply")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selMultiplyHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMultiplyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
	{
		[Export("name", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMaterialProperty Normal
	{
		[Export("normal")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selNormalHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNormalHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual SCNProgram? Program
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("program", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNProgram>(Messaging.IntPtr_objc_msgSend(base.Handle, selProgramHandle));
			}
			return Runtime.GetNSObject<SCNProgram>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProgramHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setProgram:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProgram_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProgram_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool ReadsFromDepthBuffer
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("readsFromDepthBuffer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReadsFromDepthBufferHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReadsFromDepthBufferHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setReadsFromDepthBuffer:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReadsFromDepthBuffer_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReadsFromDepthBuffer_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMaterialProperty Reflective
	{
		[Export("reflective")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selReflectiveHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReflectiveHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty Roughness
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("roughness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selRoughnessHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRoughnessHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty SelfIllumination
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("selfIllumination")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelfIlluminationHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelfIlluminationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public SCNShaderModifiers? ShaderModifiers
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakShaderModifiers != null) ? new NSMutableDictionary(WeakShaderModifiers) : null);
			return (nSMutableDictionary == null) ? null : new SCNShaderModifiers(nSMutableDictionary);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		set
		{
			WeakShaderModifiers = value.GetDictionary();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Shininess
	{
		[Export("shininess")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selShininessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selShininessHandle);
		}
		[Export("setShininess:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetShininess_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetShininess_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMaterialProperty Specular
	{
		[Export("specular")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selSpecularHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpecularHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Transparency
	{
		[Export("transparency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTransparencyHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTransparencyHandle);
		}
		[Export("setTransparency:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetTransparency_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetTransparency_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNTransparencyMode TransparencyMode
	{
		[Export("transparencyMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNTransparencyMode)Messaging.Int64_objc_msgSend(base.Handle, selTransparencyModeHandle);
			}
			return (SCNTransparencyMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTransparencyModeHandle);
		}
		[Export("setTransparencyMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTransparencyMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTransparencyMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMaterialProperty Transparent
	{
		[Export("transparent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransparentHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransparentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSDictionary? WeakShaderModifiers
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("shaderModifiers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selShaderModifiersHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShaderModifiersHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setShaderModifiers:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShaderModifiers_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShaderModifiers_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WritesToDepthBuffer
	{
		[Export("writesToDepthBuffer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWritesToDepthBufferHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWritesToDepthBufferHandle);
		}
		[Export("setWritesToDepthBuffer:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWritesToDepthBuffer_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWritesToDepthBuffer_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNMaterial()
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
	public SCNMaterial(NSCoder coder)
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
	protected SCNMaterial(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNMaterial(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addAnimation:forKey:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnimation(CAAnimation animation, NSString? key)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddAnimation_ForKey_Handle, animation.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddAnimation_ForKey_Handle, animation.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
	}

	[Export("addAnimationPlayer:forKey:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnimation(SCNAnimationPlayer player, NSString? key)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddAnimationPlayer_ForKey_Handle, player.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddAnimationPlayer_ForKey_Handle, player.Handle, (key == null) ? IntPtr.Zero : key.Handle);
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

	[Export("material")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNMaterial Create()
	{
		return Runtime.GetNSObject<SCNMaterial>(Messaging.IntPtr_objc_msgSend(class_ptr, selMaterialHandle));
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

	[Export("materialWithMDLMaterial:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNMaterial FromMaterial(MDLMaterial material)
	{
		if (material == null)
		{
			throw new ArgumentNullException("material");
		}
		return Runtime.GetNSObject<SCNMaterial>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selMaterialWithMDLMaterial_Handle, material.Handle));
	}

	[Export("animationForKey:")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAAnimation GetAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("animationKeys")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] GetAnimationKeys()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationKeysHandle));
		}
		return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationKeysHandle));
	}

	[Export("animationPlayerForKey:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNAnimationPlayer? GetAnimationPlayer(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SCNAnimationPlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationPlayerForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject<SCNAnimationPlayer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationPlayerForKey_Handle, key.Handle));
	}

	[Export("handleBindingOfSymbol:usingBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void HandleBinding(string symbol, [BlockProxy(typeof(Trampolines.NIDSCNBindingHandler))] SCNBindingHandler handler)
	{
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(symbol);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNBindingHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selHandleBindingOfSymbol_UsingBlock_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selHandleBindingOfSymbol_UsingBlock_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("handleUnbindingOfSymbol:usingBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void HandleUnbinding(string symbol, [BlockProxy(typeof(Trampolines.NIDSCNBindingHandler))] SCNBindingHandler handler)
	{
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(symbol);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNBindingHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selHandleUnbindingOfSymbol_UsingBlock_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selHandleUnbindingOfSymbol_UsingBlock_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("isAnimationForKeyPaused:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAnimationPaused(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsAnimationForKeyPaused_Handle, key.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsAnimationForKeyPaused_Handle, key.Handle);
	}

	[Export("pauseAnimationForKey:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PauseAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPauseAnimationForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPauseAnimationForKey_Handle, key.Handle);
		}
	}

	[Export("removeAllAnimations")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllAnimations()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllAnimationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllAnimationsHandle);
		}
	}

	[Export("removeAnimationForKey:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAnimationForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAnimationForKey_Handle, key.Handle);
		}
	}

	[Export("removeAnimationForKey:fadeOutDuration:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimation(NSString key, nfloat duration)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selRemoveAnimationForKey_FadeOutDuration_Handle, key.Handle, duration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selRemoveAnimationForKey_FadeOutDuration_Handle, key.Handle, duration);
		}
	}

	[Export("removeAnimationForKey:blendOutDuration:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimationUsingBlendOutDuration(NSString key, nfloat blendOutDuration)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selRemoveAnimationForKey_BlendOutDuration_Handle, key.Handle, blendOutDuration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selRemoveAnimationForKey_BlendOutDuration_Handle, key.Handle, blendOutDuration);
		}
	}

	[Export("resumeAnimationForKey:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResumeAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResumeAnimationForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResumeAnimationForKey_Handle, key.Handle);
		}
	}

	[Export("setSpeed:forAnimationKey:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSpeed(nfloat speed, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_IntPtr(base.Handle, selSetSpeed_ForAnimationKey_Handle, speed, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_IntPtr(base.SuperHandle, selSetSpeed_ForAnimationKey_Handle, speed, key.Handle);
		}
	}
}
