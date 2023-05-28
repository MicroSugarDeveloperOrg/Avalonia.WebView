using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVPixelAspectRatioProperties : DictionaryContainer
{
	public NSNumber? PixelAspectRatioHorizontalSpacing
	{
		get
		{
			return base.Dictionary[AVPixelAspectRatioPropertiesKeys.PixelAspectRatioHorizontalSpacingKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVPixelAspectRatioPropertiesKeys.PixelAspectRatioHorizontalSpacingKey, value);
		}
	}

	public NSNumber? PixelAspectRatioVerticalSpacing
	{
		get
		{
			return base.Dictionary[AVPixelAspectRatioPropertiesKeys.PixelAspectRatioVerticalSpacingKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVPixelAspectRatioPropertiesKeys.PixelAspectRatioVerticalSpacingKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public AVPixelAspectRatioProperties()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public AVPixelAspectRatioProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
