using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLPhotometricLight", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLPhotometricLight : MDLPhysicallyPlausibleLight
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateCubemapFromLight_ = "generateCubemapFromLight:";

	private static readonly IntPtr selGenerateCubemapFromLight_Handle = Selector.GetHandle("generateCubemapFromLight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateSphericalHarmonicsFromLight_ = "generateSphericalHarmonicsFromLight:";

	private static readonly IntPtr selGenerateSphericalHarmonicsFromLight_Handle = Selector.GetHandle("generateSphericalHarmonicsFromLight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateTexture_ = "generateTexture:";

	private static readonly IntPtr selGenerateTexture_Handle = Selector.GetHandle("generateTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIESProfile_ = "initWithIESProfile:";

	private static readonly IntPtr selInitWithIESProfile_Handle = Selector.GetHandle("initWithIESProfile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightCubeMap = "lightCubeMap";

	private static readonly IntPtr selLightCubeMapHandle = Selector.GetHandle("lightCubeMap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSphericalHarmonicsCoefficients = "sphericalHarmonicsCoefficients";

	private static readonly IntPtr selSphericalHarmonicsCoefficientsHandle = Selector.GetHandle("sphericalHarmonicsCoefficients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSphericalHarmonicsLevel = "sphericalHarmonicsLevel";

	private static readonly IntPtr selSphericalHarmonicsLevelHandle = Selector.GetHandle("sphericalHarmonicsLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLPhotometricLight");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTexture? LightCubeMap
	{
		[Export("lightCubeMap", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selLightCubeMapHandle));
			}
			return Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLightCubeMapHandle));
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
	public MDLPhotometricLight()
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
	protected MDLPhotometricLight(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLPhotometricLight(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIESProfile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLPhotometricLight(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIESProfile_Handle, url.Handle), "initWithIESProfile:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIESProfile_Handle, url.Handle), "initWithIESProfile:");
		}
	}

	[Export("generateCubemapFromLight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GenerateCubemap(nuint textureSize)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selGenerateCubemapFromLight_Handle, textureSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selGenerateCubemapFromLight_Handle, textureSize);
		}
	}

	[Export("generateSphericalHarmonicsFromLight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GenerateSphericalHarmonics(nuint sphericalHarmonicsLevel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selGenerateSphericalHarmonicsFromLight_Handle, sphericalHarmonicsLevel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selGenerateSphericalHarmonicsFromLight_Handle, sphericalHarmonicsLevel);
		}
	}

	[Export("generateTexture:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTexture GenerateTexture(nuint textureSize)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selGenerateTexture_Handle, textureSize));
		}
		return Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selGenerateTexture_Handle, textureSize));
	}
}
