using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSWorkspaceRenamedEventArgs : NSNotificationEventArgs
{
	[Field("NSWorkspaceVolumeLocalizedNameKey", "AppKit")]
	private static IntPtr k0;

	[Field("NSWorkspaceVolumeURLKey", "AppKit")]
	private static IntPtr k1;

	[Field("NSWorkspaceVolumeOldLocalizedNameKey", "AppKit")]
	private static IntPtr k2;

	[Field("NSWorkspaceVolumeOldURLKey", "AppKit")]
	private static IntPtr k3;

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string OldVolumeLocalizedName
	{
		get
		{
			if (k2 == IntPtr.Zero)
			{
				k2 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSWorkspaceVolumeOldLocalizedNameKey");
			}
			IntPtr usrhandle = base.Notification.UserInfo?.LowlevelObjectForKey(k2) ?? IntPtr.Zero;
			return NSString.FromHandle(usrhandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl OldVolumeUrl
	{
		get
		{
			if (k3 == IntPtr.Zero)
			{
				k3 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSWorkspaceVolumeOldURLKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k3) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSUrl>(ptr);
		}
	}

	public NSWorkspaceRenamedEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
