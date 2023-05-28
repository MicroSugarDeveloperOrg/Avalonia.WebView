using Foundation;
using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
internal static class MLFeatureValueImageOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CropAndScaleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CropRectKey;

	[Field("MLFeatureValueImageOptionCropAndScale", "CoreML")]
	public static NSString CropAndScaleKey
	{
		get
		{
			if (_CropAndScaleKey == null)
			{
				_CropAndScaleKey = Dlfcn.GetStringConstant(Libraries.CoreML.Handle, "MLFeatureValueImageOptionCropAndScale");
			}
			return _CropAndScaleKey;
		}
	}

	[Field("MLFeatureValueImageOptionCropRect", "CoreML")]
	public static NSString CropRectKey
	{
		get
		{
			if (_CropRectKey == null)
			{
				_CropRectKey = Dlfcn.GetStringConstant(Libraries.CoreML.Handle, "MLFeatureValueImageOptionCropRect");
			}
			return _CropRectKey;
		}
	}
}
