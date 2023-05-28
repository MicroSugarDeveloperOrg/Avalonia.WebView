using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSWorkspaceFileOperationEventArgs : NSNotificationEventArgs
{
	[Field("NSOperationNumber", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint FileType
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSOperationNumber");
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

	public NSWorkspaceFileOperationEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
