using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSFontCollectionChangedEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	private static IntPtr k1;

	private static IntPtr k2;

	private static IntPtr k3;

	public NSFontCollectionAction Action
	{
		get
		{
			if (_Action == NSFontCollection.ActionWasShown)
			{
				return NSFontCollectionAction.Shown;
			}
			if (_Action == NSFontCollection.ActionWasHidden)
			{
				return NSFontCollectionAction.Hidden;
			}
			if (_Action == NSFontCollection.ActionWasRenamed)
			{
				return NSFontCollectionAction.Renamed;
			}
			return NSFontCollectionAction.Unknown;
		}
	}

	public NSFontCollectionVisibility Visibility => (NSFontCollectionVisibility)(int)_Visibility;

	internal NSString _Action
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSFontCollectionActionKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return (NSString)Runtime.GetNSObject(intPtr);
		}
	}

	public string Name
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSFontCollectionNameKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k1);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return NSString.FromHandle(intPtr);
		}
	}

	public string OldName
	{
		get
		{
			if (k2 == IntPtr.Zero)
			{
				k2 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSFontCollectionOldNameKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k2);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return NSString.FromHandle(intPtr);
		}
	}

	internal NSNumber _Visibility
	{
		get
		{
			if (k3 == IntPtr.Zero)
			{
				k3 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSFontCollectionVisibilityKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k3);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return (NSNumber)Runtime.GetNSObject(intPtr);
		}
	}

	public NSFontCollectionChangedEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
