using System;
using Foundation;
using ObjCRuntime;

namespace CoreData;

public class NSPersistentStoreCoordinatorStoreChangeEventArgs : NSNotificationEventArgs
{
	[Field("NSPersistentStoreUbiquitousTransitionTypeKey", "CoreData")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPersistentStoreUbiquitousTransitionType EventType
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSPersistentStoreUbiquitousTransitionTypeKey");
			}
			IntPtr intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			if (intPtr == IntPtr.Zero)
			{
				return (NSPersistentStoreUbiquitousTransitionType)0uL;
			}
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(intPtr);
			return (NSPersistentStoreUbiquitousTransitionType)nSNumber.UInt64Value;
		}
	}

	public NSPersistentStoreCoordinatorStoreChangeEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
