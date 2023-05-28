using System;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSApplicationDelegate", WrapperType = typeof(NSApplicationDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationShouldTerminate", Selector = "applicationShouldTerminate:", ReturnType = typeof(NSApplicationTerminateReply), ParameterType = new Type[] { typeof(NSApplication) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenFile", Selector = "application:openFile:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenFiles", Selector = "application:openFiles:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(string[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenTempFile", Selector = "application:openTempFile:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationShouldOpenUntitledFile", Selector = "applicationShouldOpenUntitledFile:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSApplication) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationOpenUntitledFile", Selector = "applicationOpenUntitledFile:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSApplication) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenFileWithoutUI", Selector = "application:openFileWithoutUI:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSObject),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrintFile", Selector = "application:printFile:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrintFiles", Selector = "application:printFiles:withSettings:showPrintPanels:", ReturnType = typeof(NSApplicationPrintReply), ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(string[]),
	typeof(NSDictionary),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationShouldTerminateAfterLastWindowClosed", Selector = "applicationShouldTerminateAfterLastWindowClosed:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSApplication) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationShouldHandleReopen", Selector = "applicationShouldHandleReopen:hasVisibleWindows:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationDockMenu", Selector = "applicationDockMenu:", ReturnType = typeof(NSMenu), ParameterType = new Type[] { typeof(NSApplication) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentError", Selector = "application:willPresentError:", ReturnType = typeof(NSError), ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillFinishLaunching", Selector = "applicationWillFinishLaunching:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishLaunching", Selector = "applicationDidFinishLaunching:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillHide", Selector = "applicationWillHide:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHide", Selector = "applicationDidHide:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUnhide", Selector = "applicationWillUnhide:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnhide", Selector = "applicationDidUnhide:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBecomeActive", Selector = "applicationWillBecomeActive:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeActive", Selector = "applicationDidBecomeActive:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResignActive", Selector = "applicationWillResignActive:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResignActive", Selector = "applicationDidResignActive:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUpdate", Selector = "applicationWillUpdate:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "applicationDidUpdate:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillTerminate", Selector = "applicationWillTerminate:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScreenParametersChanged", Selector = "applicationDidChangeScreenParameters:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegisterServicesMenu", Selector = "registerServicesMenuSendTypes:returnTypes:", ParameterType = new Type[]
{
	typeof(string[]),
	typeof(string[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteSelectionToPasteboard", Selector = "writeSelectionToPasteboard:types:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSPasteboard),
	typeof(string[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadSelectionFromPasteboard", Selector = "readSelectionFromPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSPasteboard) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OrderFrontStandardAboutPanel", Selector = "orderFrontStandardAboutPanel:", ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OrderFrontStandardAboutPanelWithOptions", Selector = "orderFrontStandardAboutPanelWithOptions:", ParameterType = new Type[] { typeof(NSDictionary) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegisteredForRemoteNotifications", Selector = "application:didRegisterForRemoteNotificationsWithDeviceToken:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToRegisterForRemoteNotifications", Selector = "application:didFailToRegisterForRemoteNotificationsWithError:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedRemoteNotification", Selector = "application:didReceiveRemoteNotification:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEncodeRestorableState", Selector = "application:willEncodeRestorableState:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(NSCoder)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecodedRestorableState", Selector = "application:didDecodeRestorableState:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(NSCoder)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillContinueUserActivity", Selector = "application:willContinueUserActivityWithType:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContinueUserActivity", Selector = "application:continueUserActivity:restorationHandler:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(NSUserActivity),
	typeof(ContinueUserActivityRestorationHandler)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDContinueUserActivityRestorationHandler)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToContinueUserActivity", Selector = "application:didFailToContinueUserActivityWithType:error:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(string),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedUserActivity", Selector = "application:didUpdateUserActivity:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(NSUserActivity)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserDidAcceptCloudKitShare", Selector = "application:userDidAcceptCloudKitShareWithMetadata:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(CKShareMetadata)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenUrls", Selector = "application:openURLs:", ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(NSUrl[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandlesKey", Selector = "application:delegateHandlesKey:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSApplication),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface INSApplicationDelegate : INativeObject, IDisposable
{
}
