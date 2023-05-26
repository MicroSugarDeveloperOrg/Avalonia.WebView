using System;
using ObjCRuntime;

namespace Foundation;

public class NSUbiquitousKeyValueStoreChangeEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	private static IntPtr k1;

	public string[] ChangedKeys
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangedKeysKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return new string[0];
			}
			return NSArray.StringArrayFromHandle(intPtr);
		}
	}

	public NSUbiquitousKeyValueStoreChangeReason ChangeReason
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangeReasonKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k1);
			if (intPtr == IntPtr.Zero)
			{
				return NSUbiquitousKeyValueStoreChangeReason.ServerChange;
			}
			using NSNumber nSNumber = new NSNumber(intPtr);
			return (NSUbiquitousKeyValueStoreChangeReason)nSNumber.Int32Value;
		}
	}

	public NSUbiquitousKeyValueStoreChangeEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
