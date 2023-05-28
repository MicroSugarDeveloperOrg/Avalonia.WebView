using System;
using ObjCRuntime;

namespace Foundation;

public class NSUbiquitousKeyValueStoreChangeEventArgs : NSNotificationEventArgs
{
	[Field("NSUbiquitousKeyValueStoreChangedKeysKey", "Foundation")]
	private static IntPtr k0;

	[Field("NSUbiquitousKeyValueStoreChangeReasonKey", "Foundation")]
	private static IntPtr k1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string[] ChangedKeys
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangedKeysKey");
			}
			IntPtr intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			if (intPtr == IntPtr.Zero)
			{
				return Array.Empty<string>();
			}
			return NSArray.StringArrayFromHandle(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUbiquitousKeyValueStoreChangeReason ChangeReason
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangeReasonKey");
			}
			IntPtr intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(k1) ?? IntPtr.Zero;
			if (intPtr == IntPtr.Zero)
			{
				return NSUbiquitousKeyValueStoreChangeReason.ServerChange;
			}
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(intPtr);
			return (NSUbiquitousKeyValueStoreChangeReason)nSNumber.Int64Value;
		}
	}

	public NSUbiquitousKeyValueStoreChangeEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
