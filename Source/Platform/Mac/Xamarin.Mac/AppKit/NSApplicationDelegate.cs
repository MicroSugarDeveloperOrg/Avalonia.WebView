using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSApplicationDelegate", true)]
[Model]
public class NSApplicationDelegate : NSObject
{
	[Export("applicationDidFinishLaunching:")]
	public virtual void FinishedLaunching(NSObject notification)
	{
		throw new Exception("model");
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSApplicationDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSApplicationDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSApplicationDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSApplicationDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applicationShouldTerminate:")]
	public virtual NSApplicationTerminateReply ApplicationShouldTerminate(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:openFile:")]
	public virtual bool OpenFile(NSApplication sender, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:openFiles:")]
	public virtual void OpenFiles(NSApplication sender, string[] filenames)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:openTempFile:")]
	public virtual bool OpenTempFile(NSApplication sender, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationShouldOpenUntitledFile:")]
	public virtual bool ApplicationShouldOpenUntitledFile(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationOpenUntitledFile:")]
	public virtual bool ApplicationOpenUntitledFile(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:openFileWithoutUI:")]
	public virtual bool OpenFileWithoutUI(NSObject sender, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:printFile:")]
	public virtual bool PrintFile(NSApplication sender, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:printFiles:withSettings:showPrintPanels:")]
	public virtual NSApplicationPrintReply PrintFiles(NSApplication application, string[] fileNames, NSDictionary printSettings, bool showPrintPanels)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationShouldTerminateAfterLastWindowClosed:")]
	public virtual bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationShouldHandleReopen:hasVisibleWindows:")]
	public virtual bool ApplicationShouldHandleReopen(NSApplication sender, bool hasVisibleWindows)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDockMenu:")]
	public virtual NSMenu ApplicationDockMenu(NSApplication sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:willPresentError:")]
	public virtual NSError WillPresentError(NSApplication application, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillFinishLaunching:")]
	public virtual void WillFinishLaunching(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidFinishLaunching:")]
	public virtual void DidFinishLaunching(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillHide:")]
	public virtual void WillHide(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidHide:")]
	public virtual void DidHide(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillUnhide:")]
	public virtual void WillUnhide(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidUnhide:")]
	public virtual void DidUnhide(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillBecomeActive:")]
	public virtual void WillBecomeActive(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidBecomeActive:")]
	public virtual void DidBecomeActive(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillResignActive:")]
	public virtual void WillResignActive(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidResignActive:")]
	public virtual void DidResignActive(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillUpdate:")]
	public virtual void WillUpdate(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidUpdate:")]
	public virtual void DidUpdate(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationWillTerminate:")]
	public virtual void WillTerminate(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("applicationDidChangeScreenParameters:")]
	public virtual void ScreenParametersChanged(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("registerServicesMenuSendTypes:returnTypes:")]
	public virtual void RegisterServicesMenu(string[] sendTypes, string[] returnTypes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("writeSelectionToPasteboard:types:")]
	public virtual bool WriteSelectionToPasteboard(NSPasteboard board, string[] types)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("readSelectionFromPasteboard:")]
	public virtual bool ReadSelectionFromPasteboard(NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("orderFrontStandardAboutPanel:")]
	public virtual void OrderFrontStandardAboutPanel(NSObject sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("orderFrontStandardAboutPanelWithOptions:")]
	public virtual void OrderFrontStandardAboutPanelWithOptions(NSDictionary optionsDictionary)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
	public virtual void RegisteredForRemoteNotifications(NSApplication application, NSData deviceToken)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didFailToRegisterForRemoteNotificationsWithError:")]
	public virtual void FailedToRegisterForRemoteNotifications(NSApplication application, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didReceiveRemoteNotification:")]
	public virtual void ReceivedRemoteNotification(NSApplication application, NSDictionary userInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:willEncodeRestorableState:")]
	public virtual void WillEncodeRestorableState(NSApplication app, NSCoder encoder)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("application:didDecodeRestorableState:")]
	public virtual void DecodedRestorableState(NSApplication app, NSCoder state)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
