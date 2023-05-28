using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNSceneSourceProperties
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetAuthorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetAuthoringToolKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetContributorsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetCreatedDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetModifiedDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetUnitKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetUnitMeterKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetUnitNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetUpAxisKey;

	[Field("SCNSceneSourceAssetAuthorKey", "SceneKit")]
	public static NSString AssetAuthorKey
	{
		get
		{
			if (_AssetAuthorKey == null)
			{
				_AssetAuthorKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetAuthorKey");
			}
			return _AssetAuthorKey;
		}
	}

	[Field("SCNSceneSourceAssetAuthoringToolKey", "SceneKit")]
	public static NSString AssetAuthoringToolKey
	{
		get
		{
			if (_AssetAuthoringToolKey == null)
			{
				_AssetAuthoringToolKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetAuthoringToolKey");
			}
			return _AssetAuthoringToolKey;
		}
	}

	[Field("SCNSceneSourceAssetContributorsKey", "SceneKit")]
	public static NSString AssetContributorsKey
	{
		get
		{
			if (_AssetContributorsKey == null)
			{
				_AssetContributorsKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetContributorsKey");
			}
			return _AssetContributorsKey;
		}
	}

	[Field("SCNSceneSourceAssetCreatedDateKey", "SceneKit")]
	public static NSString AssetCreatedDateKey
	{
		get
		{
			if (_AssetCreatedDateKey == null)
			{
				_AssetCreatedDateKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetCreatedDateKey");
			}
			return _AssetCreatedDateKey;
		}
	}

	[Field("SCNSceneSourceAssetModifiedDateKey", "SceneKit")]
	public static NSString AssetModifiedDateKey
	{
		get
		{
			if (_AssetModifiedDateKey == null)
			{
				_AssetModifiedDateKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetModifiedDateKey");
			}
			return _AssetModifiedDateKey;
		}
	}

	[Field("SCNSceneSourceAssetUnitKey", "SceneKit")]
	public static NSString AssetUnitKey
	{
		get
		{
			if (_AssetUnitKey == null)
			{
				_AssetUnitKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetUnitKey");
			}
			return _AssetUnitKey;
		}
	}

	[Field("SCNSceneSourceAssetUnitMeterKey", "SceneKit")]
	public static NSString AssetUnitMeterKey
	{
		get
		{
			if (_AssetUnitMeterKey == null)
			{
				_AssetUnitMeterKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetUnitMeterKey");
			}
			return _AssetUnitMeterKey;
		}
	}

	[Field("SCNSceneSourceAssetUnitNameKey", "SceneKit")]
	public static NSString AssetUnitNameKey
	{
		get
		{
			if (_AssetUnitNameKey == null)
			{
				_AssetUnitNameKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetUnitNameKey");
			}
			return _AssetUnitNameKey;
		}
	}

	[Field("SCNSceneSourceAssetUpAxisKey", "SceneKit")]
	public static NSString AssetUpAxisKey
	{
		get
		{
			if (_AssetUpAxisKey == null)
			{
				_AssetUpAxisKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNSceneSourceAssetUpAxisKey");
			}
			return _AssetUpAxisKey;
		}
	}
}
