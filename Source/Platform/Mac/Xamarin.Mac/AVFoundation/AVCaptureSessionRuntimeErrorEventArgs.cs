using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public class AVCaptureSessionRuntimeErrorEventArgs : NSNotificationEventArgs
{
	[Field("AVCaptureSessionErrorKey", "AVFoundation")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSError Error
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AVFoundation.Handle, "AVCaptureSessionErrorKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSError>(ptr);
		}
	}

	public AVCaptureSessionRuntimeErrorEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
