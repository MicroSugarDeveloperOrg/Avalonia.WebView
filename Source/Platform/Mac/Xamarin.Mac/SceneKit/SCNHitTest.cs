using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNHitTest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BackFaceCullingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoundingBoxOnlyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ClipToZRangeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FirstFoundOnlyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IgnoreChildNodesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IgnoreHiddenNodesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IgnoreLightAreaKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionCategoryBitMaskKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionSearchModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RootNodeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SearchModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SortResultsKey;

	[Field("SCNHitTestBackFaceCullingKey", "SceneKit")]
	public static NSString BackFaceCullingKey
	{
		get
		{
			if (_BackFaceCullingKey == null)
			{
				_BackFaceCullingKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestBackFaceCullingKey");
			}
			return _BackFaceCullingKey;
		}
	}

	[Field("SCNHitTestBoundingBoxOnlyKey", "SceneKit")]
	public static NSString BoundingBoxOnlyKey
	{
		get
		{
			if (_BoundingBoxOnlyKey == null)
			{
				_BoundingBoxOnlyKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestBoundingBoxOnlyKey");
			}
			return _BoundingBoxOnlyKey;
		}
	}

	[Field("SCNHitTestClipToZRangeKey", "SceneKit")]
	public static NSString ClipToZRangeKey
	{
		get
		{
			if (_ClipToZRangeKey == null)
			{
				_ClipToZRangeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestClipToZRangeKey");
			}
			return _ClipToZRangeKey;
		}
	}

	[Field("SCNHitTestFirstFoundOnlyKey", "SceneKit")]
	public static NSString FirstFoundOnlyKey
	{
		get
		{
			if (_FirstFoundOnlyKey == null)
			{
				_FirstFoundOnlyKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestFirstFoundOnlyKey");
			}
			return _FirstFoundOnlyKey;
		}
	}

	[Field("SCNHitTestIgnoreChildNodesKey", "SceneKit")]
	public static NSString IgnoreChildNodesKey
	{
		get
		{
			if (_IgnoreChildNodesKey == null)
			{
				_IgnoreChildNodesKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestIgnoreChildNodesKey");
			}
			return _IgnoreChildNodesKey;
		}
	}

	[Field("SCNHitTestIgnoreHiddenNodesKey", "SceneKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString IgnoreHiddenNodesKey
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_IgnoreHiddenNodesKey == null)
			{
				_IgnoreHiddenNodesKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestIgnoreHiddenNodesKey");
			}
			return _IgnoreHiddenNodesKey;
		}
	}

	[Field("SCNHitTestOptionIgnoreLightArea", "SceneKit")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString IgnoreLightAreaKey
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_IgnoreLightAreaKey == null)
			{
				_IgnoreLightAreaKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestOptionIgnoreLightArea");
			}
			return _IgnoreLightAreaKey;
		}
	}

	[Field("SCNHitTestOptionCategoryBitMask", "SceneKit")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString OptionCategoryBitMaskKey
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionCategoryBitMaskKey == null)
			{
				_OptionCategoryBitMaskKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestOptionCategoryBitMask");
			}
			return _OptionCategoryBitMaskKey;
		}
	}

	[Field("SCNHitTestOptionSearchMode", "SceneKit")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString OptionSearchModeKey
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OptionSearchModeKey == null)
			{
				_OptionSearchModeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestOptionSearchMode");
			}
			return _OptionSearchModeKey;
		}
	}

	[Field("SCNHitTestRootNodeKey", "SceneKit")]
	public static NSString RootNodeKey
	{
		get
		{
			if (_RootNodeKey == null)
			{
				_RootNodeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestRootNodeKey");
			}
			return _RootNodeKey;
		}
	}

	[Field("SCNHitTestOptionSearchMode", "SceneKit")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString SearchModeKey
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_SearchModeKey == null)
			{
				_SearchModeKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestOptionSearchMode");
			}
			return _SearchModeKey;
		}
	}

	[Field("SCNHitTestSortResultsKey", "SceneKit")]
	public static NSString SortResultsKey
	{
		get
		{
			if (_SortResultsKey == null)
			{
				_SortResultsKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNHitTestSortResultsKey");
			}
			return _SortResultsKey;
		}
	}
}
