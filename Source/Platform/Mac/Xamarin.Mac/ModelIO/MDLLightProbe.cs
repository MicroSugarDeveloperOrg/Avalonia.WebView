using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLLightProbe", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLLightProbe : MDLLight
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateSphericalHarmonicsFromIrradiance_ = "generateSphericalHarmonicsFromIrradiance:";

	private static readonly IntPtr selGenerateSphericalHarmonicsFromIrradiance_Handle = Selector.GetHandle("generateSphericalHarmonicsFromIrradiance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithReflectiveTexture_IrradianceTexture_ = "initWithReflectiveTexture:irradianceTexture:";

	private static readonly IntPtr selInitWithReflectiveTexture_IrradianceTexture_Handle = Selector.GetHandle("initWithReflectiveTexture:irradianceTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIrradianceTexture = "irradianceTexture";

	private static readonly IntPtr selIrradianceTextureHandle = Selector.GetHandle("irradianceTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightProbeWithTextureSize_ForLocation_LightsToConsider_ObjectsToConsider_ReflectiveCubemap_IrradianceCubemap_ = "lightProbeWithTextureSize:forLocation:lightsToConsider:objectsToConsider:reflectiveCubemap:irradianceCubemap:";

	private static readonly IntPtr selLightProbeWithTextureSize_ForLocation_LightsToConsider_ObjectsToConsider_ReflectiveCubemap_IrradianceCubemap_Handle = Selector.GetHandle("lightProbeWithTextureSize:forLocation:lightsToConsider:objectsToConsider:reflectiveCubemap:irradianceCubemap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReflectiveTexture = "reflectiveTexture";

	private static readonly IntPtr selReflectiveTextureHandle = Selector.GetHandle("reflectiveTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSphericalHarmonicsCoefficients = "sphericalHarmonicsCoefficients";

	private static readonly IntPtr selSphericalHarmonicsCoefficientsHandle = Selector.GetHandle("sphericalHarmonicsCoefficients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSphericalHarmonicsLevel = "sphericalHarmonicsLevel";

	private static readonly IntPtr selSphericalHarmonicsLevelHandle = Selector.GetHandle("sphericalHarmonicsLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLLightProbe");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTexture? IrradianceTexture
	{
		[Export("irradianceTexture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selIrradianceTextureHandle));
			}
			return Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIrradianceTextureHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTexture? ReflectiveTexture
	{
		[Export("reflectiveTexture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selReflectiveTextureHandle));
			}
			return Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReflectiveTextureHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? SphericalHarmonicsCoefficients
	{
		[Export("sphericalHarmonicsCoefficients", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selSphericalHarmonicsCoefficientsHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSphericalHarmonicsCoefficientsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SphericalHarmonicsLevel
	{
		[Export("sphericalHarmonicsLevel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSphericalHarmonicsLevelHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSphericalHarmonicsLevelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLLightProbe()
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
	protected MDLLightProbe(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLLightProbe(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithReflectiveTexture:irradianceTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLLightProbe(MDLTexture? reflectiveTexture, MDLTexture? irradianceTexture)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithReflectiveTexture_IrradianceTexture_Handle, reflectiveTexture?.Handle ?? IntPtr.Zero, irradianceTexture?.Handle ?? IntPtr.Zero), "initWithReflectiveTexture:irradianceTexture:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithReflectiveTexture_IrradianceTexture_Handle, reflectiveTexture?.Handle ?? IntPtr.Zero, irradianceTexture?.Handle ?? IntPtr.Zero), "initWithReflectiveTexture:irradianceTexture:");
		}
	}

	[Export("lightProbeWithTextureSize:forLocation:lightsToConsider:objectsToConsider:reflectiveCubemap:irradianceCubemap:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLLightProbe? Create(nint textureSize, MDLTransform transform, MDLLight[] lightsToConsider, MDLObject[] objectsToConsider, MDLTexture? reflectiveCubemap, MDLTexture? irradianceCubemap)
	{
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (lightsToConsider == null)
		{
			throw new ArgumentNullException("lightsToConsider");
		}
		if (objectsToConsider == null)
		{
			throw new ArgumentNullException("objectsToConsider");
		}
		NSArray nSArray = NSArray.FromNSObjects(lightsToConsider);
		NSArray nSArray2 = NSArray.FromNSObjects(objectsToConsider);
		MDLLightProbe nSObject = Runtime.GetNSObject<MDLLightProbe>(Messaging.IntPtr_objc_msgSend_nint_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selLightProbeWithTextureSize_ForLocation_LightsToConsider_ObjectsToConsider_ReflectiveCubemap_IrradianceCubemap_Handle, textureSize, transform.Handle, nSArray.Handle, nSArray2.Handle, reflectiveCubemap?.Handle ?? IntPtr.Zero, irradianceCubemap?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		nSArray2.Dispose();
		return nSObject;
	}

	[Export("generateSphericalHarmonicsFromIrradiance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GenerateSphericalHarmonicsFromIrradiance(nuint sphericalHarmonicsLevel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selGenerateSphericalHarmonicsFromIrradiance_Handle, sphericalHarmonicsLevel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selGenerateSphericalHarmonicsFromIrradiance_Handle, sphericalHarmonicsLevel);
		}
	}
}
