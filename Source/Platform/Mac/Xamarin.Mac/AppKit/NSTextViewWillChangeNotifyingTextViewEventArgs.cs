using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSTextViewWillChangeNotifyingTextViewEventArgs : NSNotificationEventArgs
{
	[Field("NSOldNotifyingTextView", "AppKit")]
	private static IntPtr k0;

	[Field("NSNewNotifyingTextView", "AppKit")]
	private static IntPtr k1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextView OldView
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSOldNotifyingTextView");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSTextView>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextView NewView
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSNewNotifyingTextView");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k1) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSTextView>(ptr);
		}
	}

	public NSTextViewWillChangeNotifyingTextViewEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
