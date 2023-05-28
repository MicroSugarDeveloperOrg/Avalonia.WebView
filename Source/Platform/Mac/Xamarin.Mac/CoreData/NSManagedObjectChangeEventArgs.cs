using System;
using Foundation;
using ObjCRuntime;

namespace CoreData;

public class NSManagedObjectChangeEventArgs : NSNotificationEventArgs
{
	[Field("NSInsertedObjectsKey", "CoreData")]
	private static IntPtr k0;

	[Field("NSUpdatedObjectsKey", "CoreData")]
	private static IntPtr k1;

	[Field("NSDeletedObjectsKey", "CoreData")]
	private static IntPtr k2;

	[Field("NSRefreshedObjectsKey", "CoreData")]
	private static IntPtr k3;

	[Field("NSInvalidatedObjectsKey", "CoreData")]
	private static IntPtr k4;

	[Field("NSInvalidatedAllObjectsKey", "CoreData")]
	private static IntPtr k5;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSet InsertedObjects
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSInsertedObjectsKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSSet>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSet UpdatedObjects
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSUpdatedObjectsKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k1) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSSet>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSet DeletedObjects
	{
		get
		{
			if (k2 == IntPtr.Zero)
			{
				k2 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSDeletedObjectsKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k2) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSSet>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSet RefreshedObjects
	{
		get
		{
			if (k3 == IntPtr.Zero)
			{
				k3 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSRefreshedObjectsKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k3) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSSet>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSet InvalidatedObjects
	{
		get
		{
			if (k4 == IntPtr.Zero)
			{
				k4 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSInvalidatedObjectsKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k4) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSSet>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool InvalidatedAllObjects
	{
		get
		{
			if (k5 == IntPtr.Zero)
			{
				k5 = Dlfcn.GetIntPtr(Libraries.CoreData.Handle, "NSInvalidatedAllObjectsKey");
			}
			NSDictionary userInfo = base.Notification.UserInfo;
			if (userInfo == null)
			{
				return false;
			}
			IntPtr intPtr = userInfo.LowlevelObjectForKey(k5);
			return intPtr != IntPtr.Zero;
		}
	}

	public NSManagedObjectChangeEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
