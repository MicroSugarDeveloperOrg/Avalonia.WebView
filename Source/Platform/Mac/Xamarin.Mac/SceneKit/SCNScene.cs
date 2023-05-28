using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using GameplayKit;
using ModelIO;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNScene", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNScene : NSObject, IEnumerable<SCNNode>, IEnumerable, INSCoding, INativeObject, IDisposable, INSSecureCoding, IGKSceneRootNodeType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddParticleSystem_WithTransform_ = "addParticleSystem:withTransform:";

	private static readonly IntPtr selAddParticleSystem_WithTransform_Handle = Selector.GetHandle("addParticleSystem:withTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeForKey_ = "attributeForKey:";

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackground = "background";

	private static readonly IntPtr selBackgroundHandle = Selector.GetHandle("background");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFogColor = "fogColor";

	private static readonly IntPtr selFogColorHandle = Selector.GetHandle("fogColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFogDensityExponent = "fogDensityExponent";

	private static readonly IntPtr selFogDensityExponentHandle = Selector.GetHandle("fogDensityExponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFogEndDistance = "fogEndDistance";

	private static readonly IntPtr selFogEndDistanceHandle = Selector.GetHandle("fogEndDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFogStartDistance = "fogStartDistance";

	private static readonly IntPtr selFogStartDistanceHandle = Selector.GetHandle("fogStartDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPaused = "isPaused";

	private static readonly IntPtr selIsPausedHandle = Selector.GetHandle("isPaused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightingEnvironment = "lightingEnvironment";

	private static readonly IntPtr selLightingEnvironmentHandle = Selector.GetHandle("lightingEnvironment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleSystems = "particleSystems";

	private static readonly IntPtr selParticleSystemsHandle = Selector.GetHandle("particleSystems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhysicsWorld = "physicsWorld";

	private static readonly IntPtr selPhysicsWorldHandle = Selector.GetHandle("physicsWorld");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllParticleSystems = "removeAllParticleSystems";

	private static readonly IntPtr selRemoveAllParticleSystemsHandle = Selector.GetHandle("removeAllParticleSystems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveParticleSystem_ = "removeParticleSystem:";

	private static readonly IntPtr selRemoveParticleSystem_Handle = Selector.GetHandle("removeParticleSystem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootNode = "rootNode";

	private static readonly IntPtr selRootNodeHandle = Selector.GetHandle("rootNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScene = "scene";

	private static readonly IntPtr selSceneHandle = Selector.GetHandle("scene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneNamed_ = "sceneNamed:";

	private static readonly IntPtr selSceneNamed_Handle = Selector.GetHandle("sceneNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneNamed_InDirectory_Options_ = "sceneNamed:inDirectory:options:";

	private static readonly IntPtr selSceneNamed_InDirectory_Options_Handle = Selector.GetHandle("sceneNamed:inDirectory:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneWithMDLAsset_ = "sceneWithMDLAsset:";

	private static readonly IntPtr selSceneWithMDLAsset_Handle = Selector.GetHandle("sceneWithMDLAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneWithURL_Options_Error_ = "sceneWithURL:options:error:";

	private static readonly IntPtr selSceneWithURL_Options_Error_Handle = Selector.GetHandle("sceneWithURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreenSpaceReflectionMaximumDistance = "screenSpaceReflectionMaximumDistance";

	private static readonly IntPtr selScreenSpaceReflectionMaximumDistanceHandle = Selector.GetHandle("screenSpaceReflectionMaximumDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreenSpaceReflectionSampleCount = "screenSpaceReflectionSampleCount";

	private static readonly IntPtr selScreenSpaceReflectionSampleCountHandle = Selector.GetHandle("screenSpaceReflectionSampleCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreenSpaceReflectionStride = "screenSpaceReflectionStride";

	private static readonly IntPtr selScreenSpaceReflectionStrideHandle = Selector.GetHandle("screenSpaceReflectionStride");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttribute_ForKey_ = "setAttribute:forKey:";

	private static readonly IntPtr selSetAttribute_ForKey_Handle = Selector.GetHandle("setAttribute:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFogColor_ = "setFogColor:";

	private static readonly IntPtr selSetFogColor_Handle = Selector.GetHandle("setFogColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFogDensityExponent_ = "setFogDensityExponent:";

	private static readonly IntPtr selSetFogDensityExponent_Handle = Selector.GetHandle("setFogDensityExponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFogEndDistance_ = "setFogEndDistance:";

	private static readonly IntPtr selSetFogEndDistance_Handle = Selector.GetHandle("setFogEndDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFogStartDistance_ = "setFogStartDistance:";

	private static readonly IntPtr selSetFogStartDistance_Handle = Selector.GetHandle("setFogStartDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaused_ = "setPaused:";

	private static readonly IntPtr selSetPaused_Handle = Selector.GetHandle("setPaused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScreenSpaceReflectionMaximumDistance_ = "setScreenSpaceReflectionMaximumDistance:";

	private static readonly IntPtr selSetScreenSpaceReflectionMaximumDistance_Handle = Selector.GetHandle("setScreenSpaceReflectionMaximumDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScreenSpaceReflectionSampleCount_ = "setScreenSpaceReflectionSampleCount:";

	private static readonly IntPtr selSetScreenSpaceReflectionSampleCount_Handle = Selector.GetHandle("setScreenSpaceReflectionSampleCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScreenSpaceReflectionStride_ = "setScreenSpaceReflectionStride:";

	private static readonly IntPtr selSetScreenSpaceReflectionStride_Handle = Selector.GetHandle("setScreenSpaceReflectionStride:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWantsScreenSpaceReflection_ = "setWantsScreenSpaceReflection:";

	private static readonly IntPtr selSetWantsScreenSpaceReflection_Handle = Selector.GetHandle("setWantsScreenSpaceReflection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsScreenSpaceReflection = "wantsScreenSpaceReflection";

	private static readonly IntPtr selWantsScreenSpaceReflectionHandle = Selector.GetHandle("wantsScreenSpaceReflection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_Options_Delegate_ProgressHandler_ = "writeToURL:options:delegate:progressHandler:";

	private static readonly IntPtr selWriteToURL_Options_Delegate_ProgressHandler_Handle = Selector.GetHandle("writeToURL:options:delegate:progressHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNScene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EndTimeAttributeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExportDestinationUrl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameRateAttributeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StartTimeAttributeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UpAxisAttributeKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty Background
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("background")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual NSObject FogColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("fogColor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFogColorHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFogColorHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setFogColor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFogColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFogColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual nfloat FogDensityExponent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("fogDensityExponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFogDensityExponentHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFogDensityExponentHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setFogDensityExponent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFogDensityExponent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFogDensityExponent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual nfloat FogEndDistance
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("fogEndDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFogEndDistanceHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFogEndDistanceHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setFogEndDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFogEndDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFogEndDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual nfloat FogStartDistance
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("fogStartDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFogStartDistanceHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFogStartDistanceHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setFogStartDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFogStartDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFogStartDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual SCNMaterialProperty LightingEnvironment
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("lightingEnvironment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selLightingEnvironmentHandle));
			}
			return Runtime.GetNSObject<SCNMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLightingEnvironmentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SCNParticleSystem[] ParticleSystems
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("particleSystems")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SCNParticleSystem>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticleSystemsHandle));
			}
			return NSArray.ArrayFromHandle<SCNParticleSystem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticleSystemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual bool Paused
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("isPaused")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPausedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPausedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setPaused:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPaused_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPaused_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual SCNPhysicsWorld PhysicsWorld
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("physicsWorld")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNPhysicsWorld>(Messaging.IntPtr_objc_msgSend(base.Handle, selPhysicsWorldHandle));
			}
			return Runtime.GetNSObject<SCNPhysicsWorld>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhysicsWorldHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode RootNode
	{
		[Export("rootNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selRootNodeHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual nfloat ScreenSpaceReflectionMaximumDistance
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("screenSpaceReflectionMaximumDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScreenSpaceReflectionMaximumDistanceHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScreenSpaceReflectionMaximumDistanceHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setScreenSpaceReflectionMaximumDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetScreenSpaceReflectionMaximumDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetScreenSpaceReflectionMaximumDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual nint ScreenSpaceReflectionSampleCount
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("screenSpaceReflectionSampleCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selScreenSpaceReflectionSampleCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selScreenSpaceReflectionSampleCountHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setScreenSpaceReflectionSampleCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetScreenSpaceReflectionSampleCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetScreenSpaceReflectionSampleCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual nfloat ScreenSpaceReflectionStride
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("screenSpaceReflectionStride")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScreenSpaceReflectionStrideHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScreenSpaceReflectionStrideHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setScreenSpaceReflectionStride:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetScreenSpaceReflectionStride_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetScreenSpaceReflectionStride_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool WantsScreenSpaceReflection
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("wantsScreenSpaceReflection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsScreenSpaceReflectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsScreenSpaceReflectionHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setWantsScreenSpaceReflection:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWantsScreenSpaceReflection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWantsScreenSpaceReflection_Handle, value);
			}
		}
	}

	[Field("SCNSceneEndTimeAttributeKey", "SceneKit")]
	public static NSString EndTimeAttributeKey
	{
		get
		{
			if (_EndTimeAttributeKey == null)
			{
				_EndTimeAttributeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneEndTimeAttributeKey");
			}
			return _EndTimeAttributeKey;
		}
	}

	[Field("SCNSceneExportDestinationURL", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ExportDestinationUrl
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ExportDestinationUrl == null)
			{
				_ExportDestinationUrl = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneExportDestinationURL");
			}
			return _ExportDestinationUrl;
		}
	}

	[Field("SCNSceneFrameRateAttributeKey", "SceneKit")]
	public static NSString FrameRateAttributeKey
	{
		get
		{
			if (_FrameRateAttributeKey == null)
			{
				_FrameRateAttributeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneFrameRateAttributeKey");
			}
			return _FrameRateAttributeKey;
		}
	}

	[Field("SCNSceneStartTimeAttributeKey", "SceneKit")]
	public static NSString StartTimeAttributeKey
	{
		get
		{
			if (_StartTimeAttributeKey == null)
			{
				_StartTimeAttributeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneStartTimeAttributeKey");
			}
			return _StartTimeAttributeKey;
		}
	}

	[Field("SCNSceneUpAxisAttributeKey", "SceneKit")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString UpAxisAttributeKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_UpAxisAttributeKey == null)
			{
				_UpAxisAttributeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneUpAxisAttributeKey");
			}
			return _UpAxisAttributeKey;
		}
	}

	[Obsolete("Use the 'ISCNSceneExportDelegate' overload instead.")]
	[Mac(10, 9)]
	public virtual bool WriteToUrl(NSUrl url, SCNSceneLoadingOptions options, SCNSceneExportDelegate handler, SCNSceneExportProgressHandler exportProgressHandler)
	{
		return WriteToUrl(url, options?.Dictionary, (ISCNSceneExportDelegate?)handler, exportProgressHandler);
	}

	[Obsolete("Use the 'ISCNSceneExportDelegate' overload instead.")]
	[Mac(10, 9)]
	public virtual bool WriteToUrl(NSUrl url, NSDictionary options, SCNSceneExportDelegate handler, SCNSceneExportProgressHandler exportProgressHandler)
	{
		return WriteToUrl(url, options, (ISCNSceneExportDelegate?)handler, exportProgressHandler);
	}

	public void Add(SCNNode node)
	{
		RootNode.AddChildNode(node);
	}

	public IEnumerator<SCNNode> GetEnumerator()
	{
		return RootNode.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNScene()
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
	public SCNScene(NSCoder coder)
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
	protected SCNScene(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNScene(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addParticleSystem:withTransform:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddParticleSystem(SCNParticleSystem system, SCNMatrix4 transform)
	{
		if (system == null)
		{
			throw new ArgumentNullException("system");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_SCNMatrix4(base.Handle, selAddParticleSystem_WithTransform_Handle, system.Handle, transform);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_SCNMatrix4(base.SuperHandle, selAddParticleSystem_WithTransform_Handle, system.Handle, transform);
		}
	}

	[Export("scene")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNScene Create()
	{
		return Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend(class_ptr, selSceneHandle));
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

	[Export("sceneWithMDLAsset:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNScene FromAsset(MDLAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSceneWithMDLAsset_Handle, asset.Handle));
	}

	[Export("sceneNamed:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNScene FromFile(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SCNScene nSObject = Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSceneNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("sceneNamed:inDirectory:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNScene FromFile(string name, string? directory, NSDictionary? options)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(directory);
		SCNScene nSObject = Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSceneNamed_InDirectory_Options_Handle, arg, arg2, options?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNScene FromFile(string name, string directory, SCNSceneLoadingOptions options)
	{
		return FromFile(name, directory, options.GetDictionary());
	}

	[Export("sceneWithURL:options:error:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNScene FromUrl(NSUrl url, NSDictionary? options, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		SCNScene nSObject = Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selSceneWithURL_Options_Error_Handle, url.Handle, options?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNScene FromUrl(NSUrl url, SCNSceneLoadingOptions? options, out NSError error)
	{
		return FromUrl(url, options.GetDictionary(), out error);
	}

	[Export("attributeForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAttribute(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, key.Handle));
	}

	[Export("removeAllParticleSystems")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllParticleSystems()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllParticleSystemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllParticleSystemsHandle);
		}
	}

	[Export("removeParticleSystem:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveParticleSystem(SCNParticleSystem system)
	{
		if (system == null)
		{
			throw new ArgumentNullException("system");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveParticleSystem_Handle, system.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveParticleSystem_Handle, system.Handle);
		}
	}

	[Export("setAttribute:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAttribute(NSObject attribute, NSString key)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttribute_ForKey_Handle, attribute.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttribute_ForKey_Handle, attribute.Handle, key.Handle);
		}
	}

	[Export("writeToURL:options:delegate:progressHandler:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool WriteToUrl(NSUrl url, NSDictionary? options, ISCNSceneExportDelegate? aDelegate, [BlockProxy(typeof(Trampolines.NIDSCNSceneExportProgressHandler))] SCNSceneExportProgressHandler? exportProgressHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		BlockLiteral* ptr;
		if (exportProgressHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNSceneExportProgressHandler.Handler, exportProgressHandler);
		}
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selWriteToURL_Options_Delegate_ProgressHandler_Handle, url.Handle, options?.Handle ?? IntPtr.Zero, aDelegate?.Handle ?? IntPtr.Zero, (IntPtr)ptr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selWriteToURL_Options_Delegate_ProgressHandler_Handle, url.Handle, options?.Handle ?? IntPtr.Zero, aDelegate?.Handle ?? IntPtr.Zero, (IntPtr)ptr));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool WriteToUrl(NSUrl url, SCNSceneLoadingOptions options, ISCNSceneExportDelegate handler, [BlockProxy(typeof(Trampolines.NIDSCNSceneExportProgressHandler))] SCNSceneExportProgressHandler exportProgressHandler)
	{
		return WriteToUrl(url, options.GetDictionary(), handler, exportProgressHandler);
	}
}
