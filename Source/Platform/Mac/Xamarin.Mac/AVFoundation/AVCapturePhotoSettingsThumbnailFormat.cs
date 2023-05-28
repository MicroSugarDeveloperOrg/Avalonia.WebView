using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class AVCapturePhotoSettingsThumbnailFormat : DictionaryContainer
{
	public NSString? Codec
	{
		get
		{
			return GetNSStringValue(AVCapturePhotoSettingsThumbnailFormatKeys.CodecKey);
		}
		set
		{
			SetStringValue(AVCapturePhotoSettingsThumbnailFormatKeys.CodecKey, value);
		}
	}

	public NSNumber? Width
	{
		get
		{
			return base.Dictionary[AVCapturePhotoSettingsThumbnailFormatKeys.WidthKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVCapturePhotoSettingsThumbnailFormatKeys.WidthKey, value);
		}
	}

	public NSNumber? Height
	{
		get
		{
			return base.Dictionary[AVCapturePhotoSettingsThumbnailFormatKeys.HeightKey] as NSNumber;
		}
		set
		{
			SetNativeValue(AVCapturePhotoSettingsThumbnailFormatKeys.HeightKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public AVCapturePhotoSettingsThumbnailFormat()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public AVCapturePhotoSettingsThumbnailFormat(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
