using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public class AVPlayerItemErrorEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	public NSError Error
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AVFoundation.Handle, "AVPlayerItemFailedToPlayToEndTimeErrorKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return (NSError)Runtime.GetNSObject(intPtr);
		}
	}

	public AVPlayerItemErrorEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
