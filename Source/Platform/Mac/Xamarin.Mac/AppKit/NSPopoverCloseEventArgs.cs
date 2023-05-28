using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSPopoverCloseEventArgs : NSNotificationEventArgs
{
	[Field("NSPopoverCloseReasonKey", "AppKit")]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSString _Reason
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSPopoverCloseReasonKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSString>(ptr);
		}
	}

	public NSPopoverCloseEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
