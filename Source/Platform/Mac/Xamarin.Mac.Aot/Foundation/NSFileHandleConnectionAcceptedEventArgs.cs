using System;
using ObjCRuntime;

namespace Foundation;

public class NSFileHandleConnectionAcceptedEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	public NSFileHandle NearSocketConnection
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.Foundation.Handle, "NSFileHandleNotificationFileHandleItem");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return (NSFileHandle)Runtime.GetNSObject(intPtr);
		}
	}

	public int UnixErrorCode
	{
		get
		{
			IntPtr intPtr;
			using (NSString nSString = new NSString("NSFileHandleError"))
			{
				intPtr = base.Notification.UserInfo.LowlevelObjectForKey(nSString.Handle);
			}
			if (intPtr == IntPtr.Zero)
			{
				return 0;
			}
			using NSNumber nSNumber = new NSNumber(intPtr);
			return nSNumber.Int32Value;
		}
	}

	public NSFileHandleConnectionAcceptedEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
