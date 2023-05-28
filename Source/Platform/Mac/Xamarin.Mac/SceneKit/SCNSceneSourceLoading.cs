using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNSceneSourceLoading
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationImportPolicyDoNotPlay;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationImportPolicyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationImportPolicyPlay;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationImportPolicyPlayRepeatedly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationImportPolicyPlayUsingSceneTimeBase;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetDirectoryUrlsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CheckConsistencyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConvertToYUpKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConvertUnitsToMetersKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreateNormalsIfAbsentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FlattenSceneKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionPreserveOriginalTopology;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OverrideAssetUrlsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StrictConformanceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UseSafeModeKey;

	[Field("SCNSceneSourceAnimationImportPolicyDoNotPlay", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AnimationImportPolicyDoNotPlay
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AnimationImportPolicyDoNotPlay == null)
			{
				_AnimationImportPolicyDoNotPlay = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyDoNotPlay");
			}
			return _AnimationImportPolicyDoNotPlay;
		}
	}

	[Field("SCNSceneSourceAnimationImportPolicyKey", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AnimationImportPolicyKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AnimationImportPolicyKey == null)
			{
				_AnimationImportPolicyKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyKey");
			}
			return _AnimationImportPolicyKey;
		}
	}

	[Field("SCNSceneSourceAnimationImportPolicyPlay", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AnimationImportPolicyPlay
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AnimationImportPolicyPlay == null)
			{
				_AnimationImportPolicyPlay = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyPlay");
			}
			return _AnimationImportPolicyPlay;
		}
	}

	[Field("SCNSceneSourceAnimationImportPolicyPlayRepeatedly", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AnimationImportPolicyPlayRepeatedly
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AnimationImportPolicyPlayRepeatedly == null)
			{
				_AnimationImportPolicyPlayRepeatedly = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyPlayRepeatedly");
			}
			return _AnimationImportPolicyPlayRepeatedly;
		}
	}

	[Field("SCNSceneSourceAnimationImportPolicyPlayUsingSceneTimeBase", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AnimationImportPolicyPlayUsingSceneTimeBase
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AnimationImportPolicyPlayUsingSceneTimeBase == null)
			{
				_AnimationImportPolicyPlayUsingSceneTimeBase = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAnimationImportPolicyPlayUsingSceneTimeBase");
			}
			return _AnimationImportPolicyPlayUsingSceneTimeBase;
		}
	}

	[Field("SCNSceneSourceAssetDirectoryURLsKey", "SceneKit")]
	public static NSString AssetDirectoryUrlsKey
	{
		get
		{
			if (_AssetDirectoryUrlsKey == null)
			{
				_AssetDirectoryUrlsKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetDirectoryURLsKey");
			}
			return _AssetDirectoryUrlsKey;
		}
	}

	[Field("SCNSceneSourceCheckConsistencyKey", "SceneKit")]
	public static NSString CheckConsistencyKey
	{
		get
		{
			if (_CheckConsistencyKey == null)
			{
				_CheckConsistencyKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceCheckConsistencyKey");
			}
			return _CheckConsistencyKey;
		}
	}

	[Field("SCNSceneSourceConvertToYUpKey", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString ConvertToYUpKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ConvertToYUpKey == null)
			{
				_ConvertToYUpKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceConvertToYUpKey");
			}
			return _ConvertToYUpKey;
		}
	}

	[Field("SCNSceneSourceConvertUnitsToMetersKey", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString ConvertUnitsToMetersKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ConvertUnitsToMetersKey == null)
			{
				_ConvertUnitsToMetersKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceConvertUnitsToMetersKey");
			}
			return _ConvertUnitsToMetersKey;
		}
	}

	[Field("SCNSceneSourceCreateNormalsIfAbsentKey", "SceneKit")]
	public static NSString CreateNormalsIfAbsentKey
	{
		get
		{
			if (_CreateNormalsIfAbsentKey == null)
			{
				_CreateNormalsIfAbsentKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceCreateNormalsIfAbsentKey");
			}
			return _CreateNormalsIfAbsentKey;
		}
	}

	[Field("SCNSceneSourceFlattenSceneKey", "SceneKit")]
	public static NSString FlattenSceneKey
	{
		get
		{
			if (_FlattenSceneKey == null)
			{
				_FlattenSceneKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceFlattenSceneKey");
			}
			return _FlattenSceneKey;
		}
	}

	[Field("SCNSceneSourceLoadingOptionPreserveOriginalTopology", "SceneKit")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString OptionPreserveOriginalTopology
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionPreserveOriginalTopology == null)
			{
				_OptionPreserveOriginalTopology = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceLoadingOptionPreserveOriginalTopology");
			}
			return _OptionPreserveOriginalTopology;
		}
	}

	[Field("SCNSceneSourceOverrideAssetURLsKey", "SceneKit")]
	public static NSString OverrideAssetUrlsKey
	{
		get
		{
			if (_OverrideAssetUrlsKey == null)
			{
				_OverrideAssetUrlsKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceOverrideAssetURLsKey");
			}
			return _OverrideAssetUrlsKey;
		}
	}

	[Field("SCNSceneSourceStrictConformanceKey", "SceneKit")]
	public static NSString StrictConformanceKey
	{
		get
		{
			if (_StrictConformanceKey == null)
			{
				_StrictConformanceKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceStrictConformanceKey");
			}
			return _StrictConformanceKey;
		}
	}

	[Field("SCNSceneSourceUseSafeModeKey", "SceneKit")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	public static NSString UseSafeModeKey
	{
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		get
		{
			if (_UseSafeModeKey == null)
			{
				_UseSafeModeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceUseSafeModeKey");
			}
			return _UseSafeModeKey;
		}
	}
}
