using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVPlayerItemVideoOutputSettings : DictionaryContainer
{
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public AVColorProperties? ColorProperties
	{
		get
		{
			return GetStrongDictionary<AVColorProperties>(AVPlayerItemVideoOutputSettingsKeys.ColorPropertiesKey);
		}
		set
		{
			SetNativeValue(AVPlayerItemVideoOutputSettingsKeys.ColorPropertiesKey, value.GetDictionary());
		}
	}

	public AVCompressionProperties? CompressionProperties
	{
		get
		{
			return GetStrongDictionary<AVCompressionProperties>(AVPlayerItemVideoOutputSettingsKeys.CompressionPropertiesKey);
		}
		set
		{
			SetNativeValue(AVPlayerItemVideoOutputSettingsKeys.CompressionPropertiesKey, value.GetDictionary());
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public bool? AllowWideColor
	{
		get
		{
			return GetBoolValue(AVPlayerItemVideoOutputSettingsKeys.AllowWideColorKey);
		}
		set
		{
			SetBooleanValue(AVPlayerItemVideoOutputSettingsKeys.AllowWideColorKey, value);
		}
	}

	public NSString? Codec
	{
		get
		{
			return GetNSStringValue(AVPlayerItemVideoOutputSettingsKeys.CodecKey);
		}
		set
		{
			SetStringValue(AVPlayerItemVideoOutputSettingsKeys.CodecKey, value);
		}
	}

	public NSString? ScalingMode
	{
		get
		{
			return GetNSStringValue(AVPlayerItemVideoOutputSettingsKeys.ScalingModeKey);
		}
		set
		{
			SetStringValue(AVPlayerItemVideoOutputSettingsKeys.ScalingModeKey, value);
		}
	}

	public NSNumber? Width
	{
		get
		{
			return base.Dictionary[AVPlayerItemVideoOutputSettingsKeys.WidthKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVPlayerItemVideoOutputSettingsKeys.WidthKey, value);
		}
	}

	public NSNumber? Height
	{
		get
		{
			return base.Dictionary[AVPlayerItemVideoOutputSettingsKeys.HeightKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVPlayerItemVideoOutputSettingsKeys.HeightKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public AVPlayerItemVideoOutputSettings()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public AVPlayerItemVideoOutputSettings(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
