using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSWindowExposeEventArgs : NSNotificationEventArgs
{
	public CGRect ExposedRect
	{
		get
		{
			IntPtr intPtr;
			using (NSString nSString = new NSString("NSExposedRect"))
			{
				intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(nSString.Handle) ?? IntPtr.Zero;
			}
			if (intPtr == IntPtr.Zero)
			{
				return default(CGRect);
			}
			using NSValue nSValue = Runtime.GetNSObject<NSValue>(intPtr);
			return nSValue.CGRectValue;
		}
	}

	public NSWindowExposeEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
