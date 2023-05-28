using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICStatusNotificationKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CodeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalizedNotificationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NotificationKey;

	[Field("ICStatusCodeKey", "ImageCaptureCore")]
	public static NSString CodeKey
	{
		get
		{
			if (_CodeKey == null)
			{
				_CodeKey = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICStatusCodeKey");
			}
			return _CodeKey;
		}
	}

	[Field("ICLocalizedStatusNotificationKey", "ImageCaptureCore")]
	public static NSString LocalizedNotificationKey
	{
		get
		{
			if (_LocalizedNotificationKey == null)
			{
				_LocalizedNotificationKey = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICLocalizedStatusNotificationKey");
			}
			return _LocalizedNotificationKey;
		}
	}

	[Field("ICStatusNotificationKey", "ImageCaptureCore")]
	public static NSString NotificationKey
	{
		get
		{
			if (_NotificationKey == null)
			{
				_NotificationKey = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICStatusNotificationKey");
			}
			return _NotificationKey;
		}
	}
}
