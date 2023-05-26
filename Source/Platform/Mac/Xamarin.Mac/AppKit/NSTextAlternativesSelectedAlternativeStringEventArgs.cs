using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSTextAlternativesSelectedAlternativeStringEventArgs : NSNotificationEventArgs
{
	[Field("NSAlternativeString", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string AlternativeString
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSAlternativeString");
			}
			IntPtr usrhandle = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return NSString.FromHandle(usrhandle);
		}
	}

	public NSTextAlternativesSelectedAlternativeStringEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
