using System;
using ObjCRuntime;

namespace Foundation;

public class NSUndoManagerCloseUndoGroupEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	public bool? Discardable
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.Foundation.Handle, "NSUndoManagerGroupIsDiscardableKey");
			}
			if (base.Notification.UserInfo == null)
			{
				return null;
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			using NSNumber nSNumber = new NSNumber(intPtr);
			return nSNumber.BoolValue;
		}
	}

	public NSUndoManagerCloseUndoGroupEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
