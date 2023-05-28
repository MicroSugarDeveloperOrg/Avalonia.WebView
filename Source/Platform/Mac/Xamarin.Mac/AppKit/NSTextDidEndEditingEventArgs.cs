using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSTextDidEndEditingEventArgs : NSNotificationEventArgs
{
	[Field("NSTextMovement", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint Movement
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSTextMovement");
			}
			IntPtr intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			if (intPtr == IntPtr.Zero)
			{
				return default(nint);
			}
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(intPtr);
			return nSNumber.NIntValue;
		}
	}

	public NSTextDidEndEditingEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
