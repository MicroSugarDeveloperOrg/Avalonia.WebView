using System;
using System.ComponentModel;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSApplicationDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSApplicationTerminateReply ApplicationShouldTerminate(this INSApplicationDelegate This, NSApplication sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return (NSApplicationTerminateReply)Messaging.UInt64_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationShouldTerminate:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool OpenFile(this INSApplicationDelegate This, NSApplication sender, string filename)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr intPtr = NSString.CreateNative(filename);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:openFile:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OpenFiles(this INSApplicationDelegate This, NSApplication sender, string[] filenames)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (filenames == null)
		{
			throw new ArgumentNullException("filenames");
		}
		NSArray nSArray = NSArray.FromStrings(filenames);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:openFiles:"), sender.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool OpenTempFile(this INSApplicationDelegate This, NSApplication sender, string filename)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr intPtr = NSString.CreateNative(filename);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:openTempFile:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ApplicationShouldOpenUntitledFile(this INSApplicationDelegate This, NSApplication sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationShouldOpenUntitledFile:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ApplicationOpenUntitledFile(this INSApplicationDelegate This, NSApplication sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationOpenUntitledFile:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool OpenFileWithoutUI(this INSApplicationDelegate This, NSObject sender, string filename)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr intPtr = NSString.CreateNative(filename);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:openFileWithoutUI:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool PrintFile(this INSApplicationDelegate This, NSApplication sender, string filename)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr intPtr = NSString.CreateNative(filename);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:printFile:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSApplicationPrintReply PrintFiles(this INSApplicationDelegate This, NSApplication application, string[] fileNames, NSDictionary printSettings, bool showPrintPanels)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (fileNames == null)
		{
			throw new ArgumentNullException("fileNames");
		}
		if (printSettings == null)
		{
			throw new ArgumentNullException("printSettings");
		}
		NSArray nSArray = NSArray.FromStrings(fileNames);
		NSApplicationPrintReply result = (NSApplicationPrintReply)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("application:printFiles:withSettings:showPrintPanels:"), application.Handle, nSArray.Handle, printSettings.Handle, showPrintPanels);
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ApplicationShouldTerminateAfterLastWindowClosed(this INSApplicationDelegate This, NSApplication sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationShouldTerminateAfterLastWindowClosed:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ApplicationShouldHandleReopen(this INSApplicationDelegate This, NSApplication sender, bool hasVisibleWindows)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Messaging.bool_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("applicationShouldHandleReopen:hasVisibleWindows:"), sender.Handle, hasVisibleWindows);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMenu ApplicationDockMenu(this INSApplicationDelegate This, NSApplication sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationDockMenu:"), sender.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSError WillPresentError(this INSApplicationDelegate This, NSApplication application, NSError error)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:willPresentError:"), application.Handle, error.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillFinishLaunching(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationWillFinishLaunching:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishLaunching(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationDidFinishLaunching:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillHide(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationWillHide:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidHide(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationDidHide:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillUnhide(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationWillUnhide:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidUnhide(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationDidUnhide:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillBecomeActive(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationWillBecomeActive:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBecomeActive(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationDidBecomeActive:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillResignActive(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationWillResignActive:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidResignActive(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationDidResignActive:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillUpdate(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationWillUpdate:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidUpdate(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationDidUpdate:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillTerminate(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationWillTerminate:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ScreenParametersChanged(this INSApplicationDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applicationDidChangeScreenParameters:"), notification.Handle);
	}

	[Obsolete("Use the 'RegisterServicesMenu2' on NSApplication.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegisterServicesMenu(this INSApplicationDelegate This, string[] sendTypes, string[] returnTypes)
	{
		NSApplication.EnsureUIThread();
		if (sendTypes == null)
		{
			throw new ArgumentNullException("sendTypes");
		}
		if (returnTypes == null)
		{
			throw new ArgumentNullException("returnTypes");
		}
		NSArray nSArray = NSArray.FromStrings(sendTypes);
		NSArray nSArray2 = NSArray.FromStrings(returnTypes);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("registerServicesMenuSendTypes:returnTypes:"), nSArray.Handle, nSArray2.Handle);
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	[Obsolete("Use the 'INSServicesMenuRequestor' protocol.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteSelectionToPasteboard(this INSApplicationDelegate This, NSPasteboard board, string[] types)
	{
		NSApplication.EnsureUIThread();
		if (board == null)
		{
			throw new ArgumentNullException("board");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromStrings(types);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("writeSelectionToPasteboard:types:"), board.Handle, nSArray.Handle);
		nSArray.Dispose();
		return result;
	}

	[Obsolete("Use the 'INSServicesMenuRequestor' protocol.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadSelectionFromPasteboard(this INSApplicationDelegate This, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("readSelectionFromPasteboard:"), pboard.Handle);
	}

	[Obsolete("Use the 'OrderFrontStandardAboutPanel2' on NSApplication.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OrderFrontStandardAboutPanel(this INSApplicationDelegate This, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("orderFrontStandardAboutPanel:"), sender.Handle);
	}

	[Obsolete("Use the 'OrderFrontStandardAboutPanelWithOptions2' on NSApplication.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OrderFrontStandardAboutPanelWithOptions(this INSApplicationDelegate This, NSDictionary optionsDictionary)
	{
		NSApplication.EnsureUIThread();
		if (optionsDictionary == null)
		{
			throw new ArgumentNullException("optionsDictionary");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("orderFrontStandardAboutPanelWithOptions:"), optionsDictionary.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegisteredForRemoteNotifications(this INSApplicationDelegate This, NSApplication application, NSData deviceToken)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (deviceToken == null)
		{
			throw new ArgumentNullException("deviceToken");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:didRegisterForRemoteNotificationsWithDeviceToken:"), application.Handle, deviceToken.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedToRegisterForRemoteNotifications(this INSApplicationDelegate This, NSApplication application, NSError error)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:didFailToRegisterForRemoteNotificationsWithError:"), application.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedRemoteNotification(this INSApplicationDelegate This, NSApplication application, NSDictionary userInfo)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (userInfo == null)
		{
			throw new ArgumentNullException("userInfo");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:didReceiveRemoteNotification:"), application.Handle, userInfo.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillEncodeRestorableState(this INSApplicationDelegate This, NSApplication app, NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (app == null)
		{
			throw new ArgumentNullException("app");
		}
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:willEncodeRestorableState:"), app.Handle, encoder.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DecodedRestorableState(this INSApplicationDelegate This, NSApplication app, NSCoder state)
	{
		NSApplication.EnsureUIThread();
		if (app == null)
		{
			throw new ArgumentNullException("app");
		}
		if (state == null)
		{
			throw new ArgumentNullException("state");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:didDecodeRestorableState:"), app.Handle, state.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WillContinueUserActivity(this INSApplicationDelegate This, NSApplication application, string userActivityType)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (userActivityType == null)
		{
			throw new ArgumentNullException("userActivityType");
		}
		IntPtr intPtr = NSString.CreateNative(userActivityType);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:willContinueUserActivityWithType:"), application.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static bool ContinueUserActivity(this INSApplicationDelegate This, NSApplication application, NSUserActivity userActivity, [BlockProxy(typeof(Trampolines.NIDContinueUserActivityRestorationHandler))] ContinueUserActivityRestorationHandler restorationHandler)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		if (restorationHandler == null)
		{
			throw new ArgumentNullException("restorationHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDContinueUserActivityRestorationHandler.Handler, restorationHandler);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:continueUserActivity:restorationHandler:"), application.Handle, userActivity.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedToContinueUserActivity(this INSApplicationDelegate This, NSApplication application, string userActivityType, NSError error)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (userActivityType == null)
		{
			throw new ArgumentNullException("userActivityType");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		IntPtr intPtr = NSString.CreateNative(userActivityType);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:didFailToContinueUserActivityWithType:error:"), application.Handle, intPtr, error.Handle);
		NSString.ReleaseNative(intPtr);
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdatedUserActivity(this INSApplicationDelegate This, NSApplication application, NSUserActivity userActivity)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:didUpdateUserActivity:"), application.Handle, userActivity.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UserDidAcceptCloudKitShare(this INSApplicationDelegate This, NSApplication application, CKShareMetadata metadata)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:userDidAcceptCloudKitShareWithMetadata:"), application.Handle, metadata.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OpenUrls(this INSApplicationDelegate This, NSApplication application, NSUrl[] urls)
	{
		NSApplication.EnsureUIThread();
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (urls == null)
		{
			throw new ArgumentNullException("urls");
		}
		NSArray nSArray = NSArray.FromNSObjects(urls);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:openURLs:"), application.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool HandlesKey(this INSApplicationDelegate This, NSApplication sender, string key)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("application:delegateHandlesKey:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}
}
