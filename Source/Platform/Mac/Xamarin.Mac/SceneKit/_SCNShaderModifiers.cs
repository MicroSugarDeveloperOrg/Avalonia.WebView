using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public static class _SCNShaderModifiers
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EntryPointFragmentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EntryPointGeometryKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EntryPointLightingModelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EntryPointSurfaceKey;

	[Field("SCNShaderModifierEntryPointFragment", "SceneKit")]
	internal static NSString EntryPointFragmentKey
	{
		get
		{
			if (_EntryPointFragmentKey == null)
			{
				_EntryPointFragmentKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNShaderModifierEntryPointFragment");
			}
			return _EntryPointFragmentKey;
		}
	}

	[Field("SCNShaderModifierEntryPointGeometry", "SceneKit")]
	internal static NSString EntryPointGeometryKey
	{
		get
		{
			if (_EntryPointGeometryKey == null)
			{
				_EntryPointGeometryKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNShaderModifierEntryPointGeometry");
			}
			return _EntryPointGeometryKey;
		}
	}

	[Field("SCNShaderModifierEntryPointLightingModel", "SceneKit")]
	internal static NSString EntryPointLightingModelKey
	{
		get
		{
			if (_EntryPointLightingModelKey == null)
			{
				_EntryPointLightingModelKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNShaderModifierEntryPointLightingModel");
			}
			return _EntryPointLightingModelKey;
		}
	}

	[Field("SCNShaderModifierEntryPointSurface", "SceneKit")]
	internal static NSString EntryPointSurfaceKey
	{
		get
		{
			if (_EntryPointSurfaceKey == null)
			{
				_EntryPointSurfaceKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNShaderModifierEntryPointSurface");
			}
			return _EntryPointSurfaceKey;
		}
	}
}
