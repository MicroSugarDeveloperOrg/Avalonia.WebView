using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSWorkspaceMountEventArgs : NSNotificationEventArgs
{
	[Field("NSWorkspaceVolumeLocalizedNameKey", "AppKit")]
	private static IntPtr k0;

	[Field("NSWorkspaceVolumeURLKey", "AppKit")]
	private static IntPtr k1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string VolumeLocalizedName
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSWorkspaceVolumeLocalizedNameKey");
			}
			IntPtr usrhandle = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return NSString.FromHandle(usrhandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl VolumeUrl
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSWorkspaceVolumeURLKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k1) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSUrl>(ptr);
		}
	}

	public NSWorkspaceMountEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
