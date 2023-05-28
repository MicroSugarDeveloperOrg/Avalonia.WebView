using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class SCNRenderingArguments
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModelTransform;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModelViewProjectionTransform;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModelViewTransform;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NormalTransform;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProjectionTransform;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ViewTransform;

	[Field("SCNModelTransform", "SceneKit")]
	public static NSString ModelTransform
	{
		get
		{
			if (_ModelTransform == null)
			{
				_ModelTransform = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNModelTransform");
			}
			return _ModelTransform;
		}
	}

	[Field("SCNModelViewProjectionTransform", "SceneKit")]
	public static NSString ModelViewProjectionTransform
	{
		get
		{
			if (_ModelViewProjectionTransform == null)
			{
				_ModelViewProjectionTransform = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNModelViewProjectionTransform");
			}
			return _ModelViewProjectionTransform;
		}
	}

	[Field("SCNModelViewTransform", "SceneKit")]
	public static NSString ModelViewTransform
	{
		get
		{
			if (_ModelViewTransform == null)
			{
				_ModelViewTransform = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNModelViewTransform");
			}
			return _ModelViewTransform;
		}
	}

	[Field("SCNNormalTransform", "SceneKit")]
	public static NSString NormalTransform
	{
		get
		{
			if (_NormalTransform == null)
			{
				_NormalTransform = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNNormalTransform");
			}
			return _NormalTransform;
		}
	}

	[Field("SCNProjectionTransform", "SceneKit")]
	public static NSString ProjectionTransform
	{
		get
		{
			if (_ProjectionTransform == null)
			{
				_ProjectionTransform = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNProjectionTransform");
			}
			return _ProjectionTransform;
		}
	}

	[Field("SCNViewTransform", "SceneKit")]
	public static NSString ViewTransform
	{
		get
		{
			if (_ViewTransform == null)
			{
				_ViewTransform = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNViewTransform");
			}
			return _ViewTransform;
		}
	}
}
