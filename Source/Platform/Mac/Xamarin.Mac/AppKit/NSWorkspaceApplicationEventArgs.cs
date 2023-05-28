using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSWorkspaceApplicationEventArgs : NSNotificationEventArgs
{
	[Field("NSWorkspaceApplicationKey", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRunningApplication Application
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSWorkspaceApplicationKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSRunningApplication>(ptr);
		}
	}

	public NSWorkspaceApplicationEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
