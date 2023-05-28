using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class UNNotificationAttachmentOptions : DictionaryContainer
{
	public string? TypeHint
	{
		get
		{
			return GetStringValue(UNNotificationAttachmentOptionsKeys.TypeHint);
		}
		set
		{
			SetStringValue(UNNotificationAttachmentOptionsKeys.TypeHint, value);
		}
	}

	public bool? ThumbnailHidden
	{
		get
		{
			return GetBoolValue(UNNotificationAttachmentOptionsKeys.ThumbnailHidden);
		}
		set
		{
			SetBooleanValue(UNNotificationAttachmentOptionsKeys.ThumbnailHidden, value);
		}
	}

	public CGRect? ThumbnailClippingRect
	{
		get
		{
			return GetCGRectValue(UNNotificationAttachmentOptionsKeys.ThumbnailClippingRect);
		}
		set
		{
			SetCGRectValue(UNNotificationAttachmentOptionsKeys.ThumbnailClippingRect, value);
		}
	}

	public CMTime? ThumbnailTime
	{
		get
		{
			return GetCMTimeValue(UNNotificationAttachmentOptionsKeys.ThumbnailTime);
		}
		set
		{
			SetCMTimeValue(UNNotificationAttachmentOptionsKeys.ThumbnailTime, value);
		}
	}

	public double? ThumbnailTimeInSeconds
	{
		get
		{
			return GetDoubleValue(UNNotificationAttachmentOptionsKeys.ThumbnailTime);
		}
		set
		{
			SetNumberValue(UNNotificationAttachmentOptionsKeys.ThumbnailTime, value);
		}
	}

	[Preserve(Conditional = true)]
	public UNNotificationAttachmentOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public UNNotificationAttachmentOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
