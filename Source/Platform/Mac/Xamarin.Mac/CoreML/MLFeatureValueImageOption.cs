using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Vision;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MLFeatureValueImageOption : DictionaryContainer
{
	public CGRect? CropRect
	{
		get
		{
			return GetCGRectValue(MLFeatureValueImageOptionKeys.CropRectKey);
		}
		set
		{
			SetCGRectValue(MLFeatureValueImageOptionKeys.CropRectKey, value);
		}
	}

	public VNImageCropAndScaleOption? CropAndScale
	{
		get
		{
			return (VNImageCropAndScaleOption?)(ulong?)GetNUIntValue(MLFeatureValueImageOptionKeys.CropAndScaleKey);
		}
		set
		{
			SetNumberValue(MLFeatureValueImageOptionKeys.CropAndScaleKey, (float?)value);
		}
	}

	[Preserve(Conditional = true)]
	public MLFeatureValueImageOption()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public MLFeatureValueImageOption(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
