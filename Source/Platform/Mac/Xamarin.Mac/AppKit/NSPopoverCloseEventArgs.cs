using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSPopoverCloseEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	public NSPopoverCloseReason Reason
	{
		get
		{
			if (_Reason == NSPopover.CloseReasonStandard)
			{
				return NSPopoverCloseReason.Standard;
			}
			if (_Reason == NSPopover.CloseReasonDetachToWindow)
			{
				return NSPopoverCloseReason.DetachToWindow;
			}
			return NSPopoverCloseReason.Unknown;
		}
	}

	internal NSString _Reason
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSPopoverCloseReasonKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return (NSString)Runtime.GetNSObject(intPtr);
		}
	}

	public NSPopoverCloseEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
