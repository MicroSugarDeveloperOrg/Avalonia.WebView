using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSWorkspaceMountEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	private static IntPtr k1;

	public string VolumeLocalizedName
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSWorkspaceVolumeLocalizedNameKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return NSString.FromHandle(intPtr);
		}
	}

	public NSUrl VolumeUrl
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSWorkspaceVolumeURLKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k1);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return (NSUrl)Runtime.GetNSObject(intPtr);
		}
	}

	public NSWorkspaceMountEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
