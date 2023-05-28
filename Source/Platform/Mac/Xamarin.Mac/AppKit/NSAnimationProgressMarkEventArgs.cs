using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSAnimationProgressMarkEventArgs : NSNotificationEventArgs
{
	[Field("NSAnimationProgressMark", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Progress
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSAnimationProgressMark");
			}
			IntPtr intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			if (intPtr == IntPtr.Zero)
			{
				return 0f;
			}
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(intPtr);
			return nSNumber.FloatValue;
		}
	}

	public NSAnimationProgressMarkEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
