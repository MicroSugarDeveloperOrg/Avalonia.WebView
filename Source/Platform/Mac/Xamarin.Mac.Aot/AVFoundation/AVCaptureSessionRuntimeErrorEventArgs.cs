using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public class AVCaptureSessionRuntimeErrorEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	public NSError Error
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AVFoundation.Handle, "AVCaptureSessionErrorKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return (NSError)Runtime.GetNSObject(intPtr);
		}
	}

	public AVCaptureSessionRuntimeErrorEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
