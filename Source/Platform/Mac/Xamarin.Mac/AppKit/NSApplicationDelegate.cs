using System;
using System.ComponentModel;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSApplicationDelegate", false)]
[Model]
public class NSApplicationDelegate : NSObject, INSApplicationDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSApplicationDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSApplicationDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSApplicationDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("applicationDockMenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu ApplicationDockMenu(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationOpenUntitledFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ApplicationOpenUntitledFile(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationShouldHandleReopen:hasVisibleWindows:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ApplicationShouldHandleReopen(NSApplication sender, bool hasVisibleWindows)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationShouldOpenUntitledFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ApplicationShouldOpenUntitledFile(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationShouldTerminate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSApplicationTerminateReply ApplicationShouldTerminate(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationShouldTerminateAfterLastWindowClosed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:continueUserActivity:restorationHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContinueUserActivity(NSApplication application, NSUserActivity userActivity, [BlockProxy(typeof(Trampolines.NIDContinueUserActivityRestorationHandler))] ContinueUserActivityRestorationHandler restorationHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didDecodeRestorableState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecodedRestorableState(NSApplication app, NSCoder state)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidBecomeActive:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBecomeActive(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidFinishLaunching:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishLaunching(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidHide:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidHide(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidResignActive:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidResignActive(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidUnhide:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidUnhide(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidUpdate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidUpdate(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didFailToContinueUserActivityWithType:error:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedToContinueUserActivity(NSApplication application, string userActivityType, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didFailToRegisterForRemoteNotificationsWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedToRegisterForRemoteNotifications(NSApplication application, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:delegateHandlesKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HandlesKey(NSApplication sender, string key)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:openFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OpenFile(NSApplication sender, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:openFileWithoutUI:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OpenFileWithoutUI(NSObject sender, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:openFiles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OpenFiles(NSApplication sender, string[] filenames)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:openTempFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OpenTempFile(NSApplication sender, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:openURLs:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OpenUrls(NSApplication application, NSUrl[] urls)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("orderFrontStandardAboutPanel:")]
	[Obsolete("Use the 'OrderFrontStandardAboutPanel2' on NSApplication.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontStandardAboutPanel(NSObject sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("orderFrontStandardAboutPanelWithOptions:")]
	[Obsolete("Use the 'OrderFrontStandardAboutPanelWithOptions2' on NSApplication.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontStandardAboutPanelWithOptions(NSDictionary optionsDictionary)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:printFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PrintFile(NSApplication sender, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:printFiles:withSettings:showPrintPanels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSApplicationPrintReply PrintFiles(NSApplication application, string[] fileNames, NSDictionary printSettings, bool showPrintPanels)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("readSelectionFromPasteboard:")]
	[Obsolete("Use the 'INSServicesMenuRequestor' protocol.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadSelectionFromPasteboard(NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didReceiveRemoteNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedRemoteNotification(NSApplication application, NSDictionary userInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("registerServicesMenuSendTypes:returnTypes:")]
	[Obsolete("Use the 'RegisterServicesMenu2' on NSApplication.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterServicesMenu(string[] sendTypes, string[] returnTypes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisteredForRemoteNotifications(NSApplication application, NSData deviceToken)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidChangeScreenParameters:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScreenParametersChanged(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didUpdateUserActivity:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdatedUserActivity(NSApplication application, NSUserActivity userActivity)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:userDidAcceptCloudKitShareWithMetadata:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UserDidAcceptCloudKitShare(NSApplication application, CKShareMetadata metadata)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillBecomeActive:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillBecomeActive(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:willContinueUserActivityWithType:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WillContinueUserActivity(NSApplication application, string userActivityType)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:willEncodeRestorableState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillEncodeRestorableState(NSApplication app, NSCoder encoder)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillFinishLaunching:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillFinishLaunching(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillHide:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillHide(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:willPresentError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError WillPresentError(NSApplication application, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillResignActive:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillResignActive(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillTerminate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillTerminate(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillUnhide:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillUnhide(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillUpdate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillUpdate(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("writeSelectionToPasteboard:types:")]
	[Obsolete("Use the 'INSServicesMenuRequestor' protocol.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteSelectionToPasteboard(NSPasteboard board, string[] types)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
