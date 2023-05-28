using System;
using Foundation;
using ObjCRuntime;

namespace CoreData;

public class NSPersistentStoreRemoteChangeEventArgs : NSNotificationEventArgs
{
	[Field("NSStoreUUIDKey", "CoreData")]
	private static IntPtr k0;

	[Field("NSPersistentStoreURLKey", "CoreData")]
	private static IntPtr k1;

	[Field("NSPersistentHistoryTokenKey", "CoreData")]
	private static IntPtr k2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUuid Uuid
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSStoreUUIDKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSUuid>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Url
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSPersistentStoreURLKey");
			}
			IntPtr usrhandle = base.Notification.UserInfo?.LowlevelObjectForKey(k1) ?? IntPtr.Zero;
			return NSString.FromHandle(usrhandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPersistentHistoryToken PersistentHistoryTracking
	{
		get
		{
			if (k2 == IntPtr.Zero)
			{
				k2 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSPersistentHistoryTokenKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k2) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSPersistentHistoryToken>(ptr);
		}
	}

	public NSPersistentStoreRemoteChangeEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
