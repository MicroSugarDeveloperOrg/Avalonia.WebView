using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public class AVPlayerItemErrorEventArgs : NSNotificationEventArgs
{
	[Field("AVPlayerItemFailedToPlayToEndTimeErrorKey", "AVFoundation")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSError Error
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AVFoundation.Handle, "AVPlayerItemFailedToPlayToEndTimeErrorKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSError>(ptr);
		}
	}

	public AVPlayerItemErrorEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
