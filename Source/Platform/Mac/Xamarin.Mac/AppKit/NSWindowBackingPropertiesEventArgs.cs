using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSWindowBackingPropertiesEventArgs : NSNotificationEventArgs
{
	[Field("NSBackingPropertyOldScaleFactorKey", "AppKit")]
	private static IntPtr k0;

	[Field("NSBackingPropertyOldColorSpaceKey", "AppKit")]
	private static IntPtr k1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint OldScaleFactor
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSBackingPropertyOldScaleFactorKey");
			}
			IntPtr intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			if (intPtr == IntPtr.Zero)
			{
				return default(nint);
			}
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(intPtr);
			return nSNumber.NIntValue;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSColorSpace OldColorSpace
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSBackingPropertyOldColorSpaceKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k1) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSColorSpace>(ptr);
		}
	}

	public NSWindowBackingPropertiesEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
