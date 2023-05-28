using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSControlTextEditingEventArgs : NSNotificationEventArgs
{
	[Field("NSFieldEditor", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextView FieldEditor
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSFieldEditor");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSTextView>(ptr);
		}
	}

	public NSControlTextEditingEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
