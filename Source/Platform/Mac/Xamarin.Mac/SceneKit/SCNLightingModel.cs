using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNLightingModel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Blinn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Constant;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Lambert;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Phong;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PhysicallyBased;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShadowOnly;

	[Field("SCNLightingModelBlinn", "SceneKit")]
	public static NSString Blinn
	{
		get
		{
			if (_Blinn == null)
			{
				_Blinn = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightingModelBlinn");
			}
			return _Blinn;
		}
	}

	[Field("SCNLightingModelConstant", "SceneKit")]
	public static NSString Constant
	{
		get
		{
			if (_Constant == null)
			{
				_Constant = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightingModelConstant");
			}
			return _Constant;
		}
	}

	[Field("SCNLightingModelLambert", "SceneKit")]
	public static NSString Lambert
	{
		get
		{
			if (_Lambert == null)
			{
				_Lambert = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightingModelLambert");
			}
			return _Lambert;
		}
	}

	[Field("SCNLightingModelPhong", "SceneKit")]
	public static NSString Phong
	{
		get
		{
			if (_Phong == null)
			{
				_Phong = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightingModelPhong");
			}
			return _Phong;
		}
	}

	[Field("SCNLightingModelPhysicallyBased", "SceneKit")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString PhysicallyBased
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PhysicallyBased == null)
			{
				_PhysicallyBased = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightingModelPhysicallyBased");
			}
			return _PhysicallyBased;
		}
	}

	[Field("SCNLightingModelShadowOnly", "SceneKit")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString ShadowOnly
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ShadowOnly == null)
			{
				_ShadowOnly = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightingModelShadowOnly");
			}
			return _ShadowOnly;
		}
	}
}
