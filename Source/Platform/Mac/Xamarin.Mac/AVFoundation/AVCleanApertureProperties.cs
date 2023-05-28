using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVCleanApertureProperties : DictionaryContainer
{
	public NSNumber? Width
	{
		get
		{
			return base.Dictionary[AVCleanAperturePropertiesKeys.WidthKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVCleanAperturePropertiesKeys.WidthKey, value);
		}
	}

	public NSNumber? Height
	{
		get
		{
			return base.Dictionary[AVCleanAperturePropertiesKeys.HeightKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVCleanAperturePropertiesKeys.HeightKey, value);
		}
	}

	public NSNumber? HorizontalOffset
	{
		get
		{
			return base.Dictionary[AVCleanAperturePropertiesKeys.HorizontalOffsetKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVCleanAperturePropertiesKeys.HorizontalOffsetKey, value);
		}
	}

	public NSNumber? VerticalOffset
	{
		get
		{
			return base.Dictionary[AVCleanAperturePropertiesKeys.VerticalOffsetKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVCleanAperturePropertiesKeys.VerticalOffsetKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public AVCleanApertureProperties()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public AVCleanApertureProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
