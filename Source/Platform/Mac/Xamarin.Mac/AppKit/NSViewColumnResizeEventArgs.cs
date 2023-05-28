using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSViewColumnResizeEventArgs : NSNotificationEventArgs
{
	[Field("NSTableColumn", "AppKit")]
	private static IntPtr k0;

	[Field("NSOldWidth", "AppKit")]
	private static IntPtr k1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTableColumn Column
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSTableColumn");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSTableColumn>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint OldWidth
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSOldWidth");
			}
			IntPtr intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(k1) ?? IntPtr.Zero;
			if (intPtr == IntPtr.Zero)
			{
				return default(nint);
			}
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(intPtr);
			return nSNumber.NIntValue;
		}
	}

	public NSViewColumnResizeEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
