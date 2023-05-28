using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace MediaAccessibility;

public static class MAAudibleMedia
{
	public static class Notifications
	{
		public static NSObject ObserveSettingsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SettingsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSettingsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SettingsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SettingsChangedNotification;

	[Field("kMAAudibleMediaSettingsChangedNotification", "MediaAccessibility")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Advice("Use MAAudibleMedia.Notifications.ObserveSettingsChanged helper method instead.")]
	public static NSString SettingsChangedNotification
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_SettingsChangedNotification == null)
			{
				_SettingsChangedNotification = Dlfcn.GetStringConstant(Libraries.MediaAccessibility.Handle, "kMAAudibleMediaSettingsChangedNotification");
			}
			return _SettingsChangedNotification;
		}
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	[iOS(8, 0)]
	[Mac(10, 10)]
	private static extern IntPtr MAAudibleMediaCopyPreferredCharacteristics();

	public static string[] GetPreferredCharacteristics()
	{
		IntPtr intPtr = MAAudibleMediaCopyPreferredCharacteristics();
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		string[] result = NSArray.StringArrayFromHandle(intPtr);
		CFObject.CFRelease(intPtr);
		return result;
	}
}
