using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
internal static class UNNotificationAttachmentOptionsKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThumbnailClippingRect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThumbnailHidden;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThumbnailTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeHint;

	[Field("UNNotificationAttachmentOptionsThumbnailClippingRectKey", "UserNotifications")]
	public static NSString ThumbnailClippingRect
	{
		get
		{
			if (_ThumbnailClippingRect == null)
			{
				_ThumbnailClippingRect = Dlfcn.GetStringConstant(Libraries.UserNotifications.Handle, "UNNotificationAttachmentOptionsThumbnailClippingRectKey");
			}
			return _ThumbnailClippingRect;
		}
	}

	[Field("UNNotificationAttachmentOptionsThumbnailHiddenKey", "UserNotifications")]
	public static NSString ThumbnailHidden
	{
		get
		{
			if (_ThumbnailHidden == null)
			{
				_ThumbnailHidden = Dlfcn.GetStringConstant(Libraries.UserNotifications.Handle, "UNNotificationAttachmentOptionsThumbnailHiddenKey");
			}
			return _ThumbnailHidden;
		}
	}

	[Field("UNNotificationAttachmentOptionsThumbnailTimeKey", "UserNotifications")]
	public static NSString ThumbnailTime
	{
		get
		{
			if (_ThumbnailTime == null)
			{
				_ThumbnailTime = Dlfcn.GetStringConstant(Libraries.UserNotifications.Handle, "UNNotificationAttachmentOptionsThumbnailTimeKey");
			}
			return _ThumbnailTime;
		}
	}

	[Field("UNNotificationAttachmentOptionsTypeHintKey", "UserNotifications")]
	public static NSString TypeHint
	{
		get
		{
			if (_TypeHint == null)
			{
				_TypeHint = Dlfcn.GetStringConstant(Libraries.UserNotifications.Handle, "UNNotificationAttachmentOptionsTypeHintKey");
			}
			return _TypeHint;
		}
	}
}
