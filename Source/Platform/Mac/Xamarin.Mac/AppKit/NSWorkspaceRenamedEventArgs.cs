using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSWorkspaceRenamedEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	private static IntPtr k1;

	private static IntPtr k2;

	private static IntPtr k3;

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

	public string OldVolumeLocalizedName
	{
		get
		{
			if (k2 == IntPtr.Zero)
			{
				k2 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSWorkspaceVolumeOldLocalizedNameKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k2);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return NSString.FromHandle(intPtr);
		}
	}

	public NSUrl OldVolumeUrl
	{
		get
		{
			if (k3 == IntPtr.Zero)
			{
				k3 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSWorkspaceVolumeOldURLKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k3);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return (NSUrl)Runtime.GetNSObject(intPtr);
		}
	}

	public NSWorkspaceRenamedEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
