using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNSceneSourceLoadErrors
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConsistencyElementIDErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConsistencyElementTypeErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConsistencyLineNumberErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DetailedErrorsKey;

	[Field("SCNConsistencyElementIDErrorKey", "SceneKit")]
	public static NSString ConsistencyElementIDErrorKey
	{
		get
		{
			if (_ConsistencyElementIDErrorKey == null)
			{
				_ConsistencyElementIDErrorKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNConsistencyElementIDErrorKey");
			}
			return _ConsistencyElementIDErrorKey;
		}
	}

	[Field("SCNConsistencyElementTypeErrorKey", "SceneKit")]
	public static NSString ConsistencyElementTypeErrorKey
	{
		get
		{
			if (_ConsistencyElementTypeErrorKey == null)
			{
				_ConsistencyElementTypeErrorKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNConsistencyElementTypeErrorKey");
			}
			return _ConsistencyElementTypeErrorKey;
		}
	}

	[Field("SCNConsistencyLineNumberErrorKey", "SceneKit")]
	public static NSString ConsistencyLineNumberErrorKey
	{
		get
		{
			if (_ConsistencyLineNumberErrorKey == null)
			{
				_ConsistencyLineNumberErrorKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNConsistencyLineNumberErrorKey");
			}
			return _ConsistencyLineNumberErrorKey;
		}
	}

	[Field("SCNDetailedErrorsKey", "SceneKit")]
	public static NSString DetailedErrorsKey
	{
		get
		{
			if (_DetailedErrorsKey == null)
			{
				_DetailedErrorsKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNDetailedErrorsKey");
			}
			return _DetailedErrorsKey;
		}
	}
}
