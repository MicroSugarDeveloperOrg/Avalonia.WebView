using System;
using ObjCRuntime;

namespace Foundation;

public class NSUndoManagerCloseUndoGroupEventArgs : NSNotificationEventArgs
{
	[Field("NSUndoManagerGroupIsDiscardableKey", "Foundation")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool? Discardable
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.Foundation.Handle, "NSUndoManagerGroupIsDiscardableKey");
			}
			NSDictionary userInfo = base.Notification.UserInfo;
			if (userInfo == null)
			{
				return null;
			}
			IntPtr intPtr = userInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(intPtr);
			return nSNumber.BoolValue;
		}
	}

	public NSUndoManagerCloseUndoGroupEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
