using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNLightType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Ambient;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Area;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Directional;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Ies;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Omni;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Probe;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Spot;

	[Field("SCNLightTypeAmbient", "SceneKit")]
	public static NSString Ambient
	{
		get
		{
			if (_Ambient == null)
			{
				_Ambient = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightTypeAmbient");
			}
			return _Ambient;
		}
	}

	[Field("SCNLightTypeArea", "SceneKit")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString Area
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Area == null)
			{
				_Area = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightTypeArea");
			}
			return _Area;
		}
	}

	[Field("SCNLightTypeDirectional", "SceneKit")]
	public static NSString Directional
	{
		get
		{
			if (_Directional == null)
			{
				_Directional = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightTypeDirectional");
			}
			return _Directional;
		}
	}

	[Field("SCNLightTypeIES", "SceneKit")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString Ies
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Ies == null)
			{
				_Ies = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightTypeIES");
			}
			return _Ies;
		}
	}

	[Field("SCNLightTypeOmni", "SceneKit")]
	public static NSString Omni
	{
		get
		{
			if (_Omni == null)
			{
				_Omni = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightTypeOmni");
			}
			return _Omni;
		}
	}

	[Field("SCNLightTypeProbe", "SceneKit")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString Probe
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Probe == null)
			{
				_Probe = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightTypeProbe");
			}
			return _Probe;
		}
	}

	[Field("SCNLightTypeSpot", "SceneKit")]
	public static NSString Spot
	{
		get
		{
			if (_Spot == null)
			{
				_Spot = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNLightTypeSpot");
			}
			return _Spot;
		}
	}
}
