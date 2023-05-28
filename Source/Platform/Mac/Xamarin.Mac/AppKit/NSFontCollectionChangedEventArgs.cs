using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSFontCollectionChangedEventArgs : NSNotificationEventArgs
{
	[Field("NSFontCollectionActionKey", "AppKit")]
	private static IntPtr k0;

	[Field("NSFontCollectionNameKey", "AppKit")]
	private static IntPtr k1;

	[Field("NSFontCollectionOldNameKey", "AppKit")]
	private static IntPtr k2;

	[Field("NSFontCollectionVisibilityKey", "AppKit")]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSString _Action
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSFontCollectionActionKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSString>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Name
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSFontCollectionNameKey");
			}
			IntPtr usrhandle = base.Notification.UserInfo?.LowlevelObjectForKey(k1) ?? IntPtr.Zero;
			return NSString.FromHandle(usrhandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string OldName
	{
		get
		{
			if (k2 == IntPtr.Zero)
			{
				k2 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSFontCollectionOldNameKey");
			}
			IntPtr usrhandle = base.Notification.UserInfo?.LowlevelObjectForKey(k2) ?? IntPtr.Zero;
			return NSString.FromHandle(usrhandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSNumber _Visibility
	{
		get
		{
			if (k3 == IntPtr.Zero)
			{
				k3 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSFontCollectionVisibilityKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k3) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSNumber>(ptr);
		}
	}

	public NSFontCollectionChangedEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
