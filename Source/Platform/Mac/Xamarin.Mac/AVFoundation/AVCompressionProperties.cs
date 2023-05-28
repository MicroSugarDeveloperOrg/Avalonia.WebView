using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVCompressionProperties : DictionaryContainer
{
	public AVCleanApertureProperties? CleanAperture
	{
		get
		{
			return GetStrongDictionary<AVCleanApertureProperties>(AVCompressionPropertiesKeys.CleanApertureKey);
		}
		set
		{
			SetNativeValue(AVCompressionPropertiesKeys.CleanApertureKey, value.GetDictionary());
		}
	}

	public AVPixelAspectRatioProperties? PixelAspectRatio
	{
		get
		{
			return GetStrongDictionary<AVPixelAspectRatioProperties>(AVCompressionPropertiesKeys.PixelAspectRatioKey);
		}
		set
		{
			SetNativeValue(AVCompressionPropertiesKeys.PixelAspectRatioKey, value.GetDictionary());
		}
	}

	[Preserve(Conditional = true)]
	public AVCompressionProperties()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public AVCompressionProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
