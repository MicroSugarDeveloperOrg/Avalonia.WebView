using Foundation;
using ObjCRuntime;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AppKit;

[Register("NSApplication", true)]
public class NSApplication : NSResponder
{
    [Register]
    private sealed class _NSApplicationDelegate : NSApplicationDelegate
    {
        internal NSApplicationTermination applicationShouldTerminate;

        internal NSApplicationFile openFile;

        internal EventHandler<NSApplicationFilesEventArgs> openFiles;

        internal NSApplicationFile openTempFile;

        internal NSApplicationPredicate applicationShouldOpenUntitledFile;

        internal NSApplicationPredicate applicationOpenUntitledFile;

        internal NSApplicationFileCommand openFileWithoutUI;

        internal NSApplicationFile printFile;

        internal NSApplicationPrint printFiles;

        internal NSApplicationPredicate applicationShouldTerminateAfterLastWindowClosed;

        internal NSApplicationReopen applicationShouldHandleReopen;

        internal NSApplicationMenu applicationDockMenu;

        internal NSApplicationError willPresentError;

        internal EventHandler willFinishLaunching;

        internal EventHandler didFinishLaunching;

        internal EventHandler willHide;

        internal EventHandler didHide;

        internal EventHandler willUnhide;

        internal EventHandler didUnhide;

        internal EventHandler willBecomeActive;

        internal EventHandler didBecomeActive;

        internal EventHandler willResignActive;

        internal EventHandler didResignActive;

        internal EventHandler willUpdate;

        internal EventHandler didUpdate;

        internal EventHandler willTerminate;

        internal EventHandler screenParametersChanged;

        internal EventHandler<NSApplicationRegisterEventArgs> registerServicesMenu;

        internal NSApplicationSelection writeSelectionToPasteboard;

        internal NSPasteboardPredicate readSelectionFromPasteboard;

        internal EventHandler orderFrontStandardAboutPanel;

        internal EventHandler orderFrontStandardAboutPanelWithOptions;

        internal EventHandler<NSDataEventArgs> registeredForRemoteNotifications;

        internal EventHandler<NSErrorEventArgs> failedToRegisterForRemoteNotifications;

        internal EventHandler<NSDictionaryEventArgs> receivedRemoteNotification;

        internal EventHandler<NSCoderEventArgs> willEncodeRestorableState;

        internal EventHandler<NSCoderEventArgs> decodedRestorableState;

        [Preserve(Conditional = true)]
        public override NSApplicationTerminateReply ApplicationShouldTerminate(NSApplication sender)
        {
            return applicationShouldTerminate?.Invoke(sender) ?? NSApplicationTerminateReply.Now;
        }

        [Preserve(Conditional = true)]
        public override bool OpenFile(NSApplication sender, string filename)
        {
            return openFile?.Invoke(sender, filename) ?? false;
        }

        [Preserve(Conditional = true)]
        public override void OpenFiles(NSApplication sender, string[] filenames)
        {
            EventHandler<NSApplicationFilesEventArgs> eventHandler = openFiles;
            if (eventHandler != null)
            {
                NSApplicationFilesEventArgs e = new NSApplicationFilesEventArgs(filenames);
                eventHandler(sender, e);
            }
        }

        [Preserve(Conditional = true)]
        public override bool OpenTempFile(NSApplication sender, string filename)
        {
            return openTempFile?.Invoke(sender, filename) ?? false;
        }

        [Preserve(Conditional = true)]
        public override bool ApplicationShouldOpenUntitledFile(NSApplication sender)
        {
            return applicationShouldOpenUntitledFile?.Invoke(sender) ?? false;
        }

        [Preserve(Conditional = true)]
        public override bool ApplicationOpenUntitledFile(NSApplication sender)
        {
            return applicationOpenUntitledFile?.Invoke(sender) ?? false;
        }

        [Preserve(Conditional = true)]
        public override bool OpenFileWithoutUI(NSObject sender, string filename)
        {
            return openFileWithoutUI?.Invoke(sender, filename) ?? false;
        }

        [Preserve(Conditional = true)]
        public override bool PrintFile(NSApplication sender, string filename)
        {
            return printFile?.Invoke(sender, filename) ?? false;
        }

        [Preserve(Conditional = true)]
        public override NSApplicationPrintReply PrintFiles(NSApplication application, string[] fileNames, NSDictionary printSettings, bool showPrintPanels)
        {
            return printFiles?.Invoke(application, fileNames, printSettings, showPrintPanels) ?? NSApplicationPrintReply.Failure;
        }

        [Preserve(Conditional = true)]
        public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
        {
            return applicationShouldTerminateAfterLastWindowClosed?.Invoke(sender) ?? false;
        }

        [Preserve(Conditional = true)]
        public override bool ApplicationShouldHandleReopen(NSApplication sender, bool hasVisibleWindows)
        {
            return applicationShouldHandleReopen?.Invoke(sender, hasVisibleWindows) ?? false;
        }

        [Preserve(Conditional = true)]
        public override NSMenu ApplicationDockMenu(NSApplication sender)
        {
            return applicationDockMenu?.Invoke(sender);
        }

        [Preserve(Conditional = true)]
        public override NSError WillPresentError(NSApplication application, NSError error)
        {
            return willPresentError?.Invoke(application, error);
        }

        [Preserve(Conditional = true)]
        public override void WillFinishLaunching(NSNotification notification)
        {
            willFinishLaunching?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void DidFinishLaunching(NSNotification notification)
        {
            didFinishLaunching?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void WillHide(NSNotification notification)
        {
            willHide?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void DidHide(NSNotification notification)
        {
            didHide?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void WillUnhide(NSNotification notification)
        {
            willUnhide?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void DidUnhide(NSNotification notification)
        {
            didUnhide?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void WillBecomeActive(NSNotification notification)
        {
            willBecomeActive?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void DidBecomeActive(NSNotification notification)
        {
            didBecomeActive?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void WillResignActive(NSNotification notification)
        {
            willResignActive?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void DidResignActive(NSNotification notification)
        {
            didResignActive?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void WillUpdate(NSNotification notification)
        {
            willUpdate?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void DidUpdate(NSNotification notification)
        {
            didUpdate?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void WillTerminate(NSNotification notification)
        {
            willTerminate?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void ScreenParametersChanged(NSNotification notification)
        {
            screenParametersChanged?.Invoke(notification, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void RegisterServicesMenu(string[] sendTypes, string[] returnTypes)
        {
            EventHandler<NSApplicationRegisterEventArgs> eventHandler = registerServicesMenu;
            if (eventHandler != null)
            {
                NSApplicationRegisterEventArgs e = new NSApplicationRegisterEventArgs(returnTypes);
                eventHandler(sendTypes, e);
            }
        }

        [Preserve(Conditional = true)]
        public override bool WriteSelectionToPasteboard(NSPasteboard board, string[] types)
        {
            return writeSelectionToPasteboard?.Invoke(board, types) ?? false;
        }

        [Preserve(Conditional = true)]
        public override bool ReadSelectionFromPasteboard(NSPasteboard pboard)
        {
            return readSelectionFromPasteboard?.Invoke(pboard) ?? false;
        }

        [Preserve(Conditional = true)]
        public override void OrderFrontStandardAboutPanel(NSObject sender)
        {
            orderFrontStandardAboutPanel?.Invoke(sender, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void OrderFrontStandardAboutPanelWithOptions(NSDictionary optionsDictionary)
        {
            orderFrontStandardAboutPanelWithOptions?.Invoke(optionsDictionary, EventArgs.Empty);
        }

        [Preserve(Conditional = true)]
        public override void RegisteredForRemoteNotifications(NSApplication application, NSData deviceToken)
        {
            EventHandler<NSDataEventArgs> eventHandler = registeredForRemoteNotifications;
            if (eventHandler != null)
            {
                NSDataEventArgs e = new NSDataEventArgs(deviceToken);
                eventHandler(application, e);
            }
        }

        [Preserve(Conditional = true)]
        public override void FailedToRegisterForRemoteNotifications(NSApplication application, NSError error)
        {
            EventHandler<NSErrorEventArgs> eventHandler = failedToRegisterForRemoteNotifications;
            if (eventHandler != null)
            {
                NSErrorEventArgs e = new NSErrorEventArgs(error);
                eventHandler(application, e);
            }
        }

        [Preserve(Conditional = true)]
        public override void ReceivedRemoteNotification(NSApplication application, NSDictionary userInfo)
        {
            EventHandler<NSDictionaryEventArgs> eventHandler = receivedRemoteNotification;
            if (eventHandler != null)
            {
                NSDictionaryEventArgs e = new NSDictionaryEventArgs(userInfo);
                eventHandler(application, e);
            }
        }

        [Preserve(Conditional = true)]
        public override void WillEncodeRestorableState(NSApplication app, NSCoder encoder)
        {
            EventHandler<NSCoderEventArgs> eventHandler = willEncodeRestorableState;
            if (eventHandler != null)
            {
                NSCoderEventArgs e = new NSCoderEventArgs(encoder);
                eventHandler(app, e);
            }
        }

        [Preserve(Conditional = true)]
        public override void DecodedRestorableState(NSApplication app, NSCoder state)
        {
            EventHandler<NSCoderEventArgs> eventHandler = decodedRestorableState;
            if (eventHandler != null)
            {
                NSCoderEventArgs e = new NSCoderEventArgs(state);
                eventHandler(app, e);
            }
        }
    }

    public static class Notifications
    {
        public static NSObject ObserveDidBecomeActive(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(DidBecomeActiveNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveDidHide(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(DidHideNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveDidFinishLaunching(EventHandler<NSApplicationDidFinishLaunchingEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(DidFinishLaunchingNotification, delegate (NSNotification notification)
            {
                handler(null, new NSApplicationDidFinishLaunchingEventArgs(notification));
            });
        }

        public static NSObject ObserveDidResignActive(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(DidResignActiveNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveDidUnhide(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(DidUnhideNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveDidUpdate(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(DidUpdateNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveWillBecomeActive(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(WillBecomeActiveNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveWillHide(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(WillHideNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveWillFinishLaunching(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(WillFinishLaunchingNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveWillResignActive(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(WillResignActiveNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveWillUnhide(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(WillUnhideNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveWillUpdate(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(WillUpdateNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveWillTerminate(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(WillTerminateNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveDidChangeScreenParameters(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeScreenParametersNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }

        public static NSObject ObserveDidFinishRestoringWindows(EventHandler<NSNotificationEventArgs> handler)
        {
            return NSNotificationCenter.DefaultCenter.AddObserver(DidFinishRestoringWindowsNotification, delegate (NSNotification notification)
            {
                handler(null, new NSNotificationEventArgs(notification));
            });
        }
    }

    public static bool CheckForIllegalCrossThreadCalls;

    private static Thread mainThread;

    private static bool initialized;

    private static readonly IntPtr selSharedApplicationHandle;

    private static readonly IntPtr selDelegateHandle;

    private static readonly IntPtr selSetDelegate_Handle;

    private static readonly IntPtr selContextHandle;

    private static readonly IntPtr selMainWindowHandle;

    private static readonly IntPtr selKeyWindowHandle;

    private static readonly IntPtr selIsActiveHandle;

    private static readonly IntPtr selIsHiddenHandle;

    private static readonly IntPtr selIsRunningHandle;

    private static readonly IntPtr selModalWindowHandle;

    private static readonly IntPtr selCurrentEventHandle;

    private static readonly IntPtr selWindowsHandle;

    private static readonly IntPtr selMainMenuHandle;

    private static readonly IntPtr selSetMainMenu_Handle;

    private static readonly IntPtr selHelpMenuHandle;

    private static readonly IntPtr selSetHelpMenu_Handle;

    private static readonly IntPtr selApplicationIconImageHandle;

    private static readonly IntPtr selSetApplicationIconImage_Handle;

    private static readonly IntPtr selDockTileHandle;

    private static readonly IntPtr selPresentationOptionsHandle;

    private static readonly IntPtr selSetPresentationOptions_Handle;

    private static readonly IntPtr selCurrentSystemPresentationOptionsHandle;

    private static readonly IntPtr selWindowsMenuHandle;

    private static readonly IntPtr selSetWindowsMenu_Handle;

    private static readonly IntPtr selIsFullKeyboardAccessEnabledHandle;

    private static readonly IntPtr selServicesProviderHandle;

    private static readonly IntPtr selSetServicesProvider_Handle;

    private static readonly IntPtr selUserInterfaceLayoutDirectionHandle;

    private static readonly IntPtr selServicesMenuHandle;

    private static readonly IntPtr selSetServicesMenu_Handle;

    private static readonly IntPtr selHide_Handle;

    private static readonly IntPtr selUnhide_Handle;

    private static readonly IntPtr selUnhideWithoutActivationHandle;

    private static readonly IntPtr selWindowWithWindowNumber_Handle;

    private static readonly IntPtr selDeactivateHandle;

    private static readonly IntPtr selActivateIgnoringOtherApps_Handle;

    private static readonly IntPtr selHideOtherApplications_Handle;

    private static readonly IntPtr selUnhideAllApplications_Handle;

    private static readonly IntPtr selFinishLaunchingHandle;

    private static readonly IntPtr selRunHandle;

    private static readonly IntPtr selRunModalForWindow_Handle;

    private static readonly IntPtr selStop_Handle;

    private static readonly IntPtr selStopModalHandle;

    private static readonly IntPtr selStopModalWithCode_Handle;

    private static readonly IntPtr selAbortModalHandle;

    private static readonly IntPtr selBeginModalSessionForWindow_Handle;

    private static readonly IntPtr selRunModalSession_Handle;

    private static readonly IntPtr selEndModalSession_Handle;

    private static readonly IntPtr selTerminate_Handle;

    private static readonly IntPtr selRequestUserAttention_Handle;

    private static readonly IntPtr selCancelUserAttentionRequest_Handle;

    private static readonly IntPtr selBeginSheetModalForWindowModalDelegateDidEndSelectorContextInfo_Handle;

    private static readonly IntPtr selEndSheet_Handle;

    private static readonly IntPtr selEndSheetReturnCode_Handle;

    private static readonly IntPtr selNextEventMatchingMaskUntilDateInModeDequeue_Handle;

    private static readonly IntPtr selDiscardEventsMatchingMaskBeforeEvent_Handle;

    private static readonly IntPtr selPostEventAtStart_Handle;

    private static readonly IntPtr selSendEvent_Handle;

    private static readonly IntPtr selPreventWindowOrderingHandle;

    private static readonly IntPtr selMakeWindowsPerformInOrder_Handle;

    private static readonly IntPtr selSetWindowsNeedUpdate_Handle;

    private static readonly IntPtr selUpdateWindowsHandle;

    private static readonly IntPtr selActivationPolicyHandle;

    private static readonly IntPtr selSetActivationPolicy_Handle;

    private static readonly IntPtr selSendActionToFrom_Handle;

    private static readonly IntPtr selTargetForAction_Handle;

    private static readonly IntPtr selTargetForActionToFrom_Handle;

    private static readonly IntPtr selTryToPerformWith_Handle;

    private static readonly IntPtr selValidRequestorForSendTypeReturnType_Handle;

    private static readonly IntPtr selReportException_Handle;

    private static readonly IntPtr selDetachDrawingThreadToTargetWithObject_Handle;

    private static readonly IntPtr selReplyToApplicationShouldTerminate_Handle;

    private static readonly IntPtr selReplyToOpenOrPrint_Handle;

    private static readonly IntPtr selOrderFrontCharacterPalette_Handle;

    private static readonly IntPtr selArrangeInFront_Handle;

    private static readonly IntPtr selRemoveWindowsItem_Handle;

    private static readonly IntPtr selAddWindowsItemTitleFilename_Handle;

    private static readonly IntPtr selChangeWindowsItemTitleFilename_Handle;

    private static readonly IntPtr selUpdateWindowsItem_Handle;

    private static readonly IntPtr selMiniaturizeAll_Handle;

    private static readonly IntPtr selOrderFrontColorPanel_Handle;

    private static readonly IntPtr selDisableRelaunchOnLoginHandle;

    private static readonly IntPtr selEnableRelaunchOnLoginHandle;

    private static readonly IntPtr selEnabledRemoteNotificationTypesHandle;

    private static readonly IntPtr selRegisterForRemoteNotificationTypes_Handle;

    private static readonly IntPtr selUnregisterForRemoteNotificationsHandle;

    private static readonly IntPtr selRestoreWindowWithIdentifierStateCompletionHandler_Handle;

    private static readonly IntPtr class_ptr;

    private static object __mt_SharedApplication_var_static;

    private object __mt_WeakDelegate_var;

    private object __mt_Context_var;

    private object __mt_MainWindow_var;

    private object __mt_KeyWindow_var;

    private object __mt_ModalWindow_var;

    private object __mt_CurrentEvent_var;

    private object __mt_Windows_var;

    private object __mt_MainMenu_var;

    private object __mt_HelpMenu_var;

    private object __mt_ApplicationIconImage_var;

    private object __mt_DockTile_var;

    private object __mt_WindowsMenu_var;

    private object __mt_ServicesProvider_var;

    private object __mt_ServicesMenu_var;

    private static NSString _DidBecomeActiveNotification;

    private static NSString _DidHideNotification;

    private static NSString _DidFinishLaunchingNotification;

    private static NSString _DidResignActiveNotification;

    private static NSString _DidUnhideNotification;

    private static NSString _DidUpdateNotification;

    private static NSString _WillBecomeActiveNotification;

    private static NSString _WillHideNotification;

    private static NSString _WillFinishLaunchingNotification;

    private static NSString _WillResignActiveNotification;

    private static NSString _WillUnhideNotification;

    private static NSString _WillUpdateNotification;

    private static NSString _WillTerminateNotification;

    private static NSString _DidChangeScreenParametersNotification;

    private static NSString _LaunchIsDefaultLaunchKey;

    private static NSString _LaunchRemoteNotificationKey;

    private static NSString _DidFinishRestoringWindowsNotification;

    public override IntPtr ClassHandle => class_ptr;


    static NSApplication()
    {
        CheckForIllegalCrossThreadCalls = true;
        selSharedApplicationHandle = Selector.GetHandle("sharedApplication");
        selDelegateHandle = Selector.GetHandle("delegate");
        selSetDelegate_Handle = Selector.GetHandle("setDelegate:");
        selContextHandle = Selector.GetHandle("context");
        selMainWindowHandle = Selector.GetHandle("mainWindow");
        selKeyWindowHandle = Selector.GetHandle("keyWindow");
        selIsActiveHandle = Selector.GetHandle("isActive");
        selIsHiddenHandle = Selector.GetHandle("isHidden");
        selIsRunningHandle = Selector.GetHandle("isRunning");
        selModalWindowHandle = Selector.GetHandle("modalWindow");
        selCurrentEventHandle = Selector.GetHandle("currentEvent");
        selWindowsHandle = Selector.GetHandle("windows");
        selMainMenuHandle = Selector.GetHandle("mainMenu");
        selSetMainMenu_Handle = Selector.GetHandle("setMainMenu:");
        selHelpMenuHandle = Selector.GetHandle("helpMenu");
        selSetHelpMenu_Handle = Selector.GetHandle("setHelpMenu:");
        selApplicationIconImageHandle = Selector.GetHandle("applicationIconImage");
        selSetApplicationIconImage_Handle = Selector.GetHandle("setApplicationIconImage:");
        selDockTileHandle = Selector.GetHandle("dockTile");
        selPresentationOptionsHandle = Selector.GetHandle("presentationOptions");
        selSetPresentationOptions_Handle = Selector.GetHandle("setPresentationOptions:");
        selCurrentSystemPresentationOptionsHandle = Selector.GetHandle("currentSystemPresentationOptions");
        selWindowsMenuHandle = Selector.GetHandle("windowsMenu");
        selSetWindowsMenu_Handle = Selector.GetHandle("setWindowsMenu:");
        selIsFullKeyboardAccessEnabledHandle = Selector.GetHandle("isFullKeyboardAccessEnabled");
        selServicesProviderHandle = Selector.GetHandle("servicesProvider");
        selSetServicesProvider_Handle = Selector.GetHandle("setServicesProvider:");
        selUserInterfaceLayoutDirectionHandle = Selector.GetHandle("userInterfaceLayoutDirection");
        selServicesMenuHandle = Selector.GetHandle("servicesMenu");
        selSetServicesMenu_Handle = Selector.GetHandle("setServicesMenu:");
        selHide_Handle = Selector.GetHandle("hide:");
        selUnhide_Handle = Selector.GetHandle("unhide:");
        selUnhideWithoutActivationHandle = Selector.GetHandle("unhideWithoutActivation");
        selWindowWithWindowNumber_Handle = Selector.GetHandle("windowWithWindowNumber:");
        selDeactivateHandle = Selector.GetHandle("deactivate");
        selActivateIgnoringOtherApps_Handle = Selector.GetHandle("activateIgnoringOtherApps:");
        selHideOtherApplications_Handle = Selector.GetHandle("hideOtherApplications:");
        selUnhideAllApplications_Handle = Selector.GetHandle("unhideAllApplications:");
        selFinishLaunchingHandle = Selector.GetHandle("finishLaunching");
        selRunHandle = Selector.GetHandle("run");
        selRunModalForWindow_Handle = Selector.GetHandle("runModalForWindow:");
        selStop_Handle = Selector.GetHandle("stop:");
        selStopModalHandle = Selector.GetHandle("stopModal");
        selStopModalWithCode_Handle = Selector.GetHandle("stopModalWithCode:");
        selAbortModalHandle = Selector.GetHandle("abortModal");
        selBeginModalSessionForWindow_Handle = Selector.GetHandle("beginModalSessionForWindow:");
        selRunModalSession_Handle = Selector.GetHandle("runModalSession:");
        selEndModalSession_Handle = Selector.GetHandle("endModalSession:");
        selTerminate_Handle = Selector.GetHandle("terminate:");
        selRequestUserAttention_Handle = Selector.GetHandle("requestUserAttention:");
        selCancelUserAttentionRequest_Handle = Selector.GetHandle("cancelUserAttentionRequest:");
        selBeginSheetModalForWindowModalDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginSheet:modalForWindow:modalDelegate:didEndSelector:contextInfo:");
        selEndSheet_Handle = Selector.GetHandle("endSheet:");
        selEndSheetReturnCode_Handle = Selector.GetHandle("endSheet:returnCode:");
        selNextEventMatchingMaskUntilDateInModeDequeue_Handle = Selector.GetHandle("nextEventMatchingMask:untilDate:inMode:dequeue:");
        selDiscardEventsMatchingMaskBeforeEvent_Handle = Selector.GetHandle("discardEventsMatchingMask:beforeEvent:");
        selPostEventAtStart_Handle = Selector.GetHandle("postEvent:atStart:");
        selSendEvent_Handle = Selector.GetHandle("sendEvent:");
        selPreventWindowOrderingHandle = Selector.GetHandle("preventWindowOrdering");
        selMakeWindowsPerformInOrder_Handle = Selector.GetHandle("makeWindowsPerform:inOrder:");
        selSetWindowsNeedUpdate_Handle = Selector.GetHandle("setWindowsNeedUpdate:");
        selUpdateWindowsHandle = Selector.GetHandle("updateWindows");
        selActivationPolicyHandle = Selector.GetHandle("activationPolicy");
        selSetActivationPolicy_Handle = Selector.GetHandle("setActivationPolicy:");
        selSendActionToFrom_Handle = Selector.GetHandle("sendAction:to:from:");
        selTargetForAction_Handle = Selector.GetHandle("targetForAction:");
        selTargetForActionToFrom_Handle = Selector.GetHandle("targetForAction:to:from:");
        selTryToPerformWith_Handle = Selector.GetHandle("tryToPerform:with:");
        selValidRequestorForSendTypeReturnType_Handle = Selector.GetHandle("validRequestorForSendType:returnType:");
        selReportException_Handle = Selector.GetHandle("reportException:");
        selDetachDrawingThreadToTargetWithObject_Handle = Selector.GetHandle("detachDrawingThread:toTarget:withObject:");
        selReplyToApplicationShouldTerminate_Handle = Selector.GetHandle("replyToApplicationShouldTerminate:");
        selReplyToOpenOrPrint_Handle = Selector.GetHandle("replyToOpenOrPrint:");
        selOrderFrontCharacterPalette_Handle = Selector.GetHandle("orderFrontCharacterPalette:");
        selArrangeInFront_Handle = Selector.GetHandle("arrangeInFront:");
        selRemoveWindowsItem_Handle = Selector.GetHandle("removeWindowsItem:");
        selAddWindowsItemTitleFilename_Handle = Selector.GetHandle("addWindowsItem:title:filename:");
        selChangeWindowsItemTitleFilename_Handle = Selector.GetHandle("changeWindowsItem:title:filename:");
        selUpdateWindowsItem_Handle = Selector.GetHandle("updateWindowsItem:");
        selMiniaturizeAll_Handle = Selector.GetHandle("miniaturizeAll:");
        selOrderFrontColorPanel_Handle = Selector.GetHandle("orderFrontColorPanel:");
        selDisableRelaunchOnLoginHandle = Selector.GetHandle("disableRelaunchOnLogin");
        selEnableRelaunchOnLoginHandle = Selector.GetHandle("enableRelaunchOnLogin");
        selEnabledRemoteNotificationTypesHandle = Selector.GetHandle("enabledRemoteNotificationTypes");
        selRegisterForRemoteNotificationTypes_Handle = Selector.GetHandle("registerForRemoteNotificationTypes:");
        selUnregisterForRemoteNotificationsHandle = Selector.GetHandle("unregisterForRemoteNotifications");
        selRestoreWindowWithIdentifierStateCompletionHandler_Handle = Selector.GetHandle("restoreWindowWithIdentifier:state:completionHandler:");
        class_ptr = Class.GetHandle("NSApplication");
        RuntimeHelpers.RunClassConstructor(typeof(NSObject).TypeHandle);
        class_ptr = Class.GetHandle("NSApplication");
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public NSApplication(NSCoder coder)
    : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.InitWithCoder, coder);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public NSApplication(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public NSApplication(IntPtr handle)
        : base(handle)
    {
    }

    [DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
    private static extern void NSApplicationMain(int argc, string[] argv);

    [ThreadSafe]
    public static NSApplication SharedApplication
    {
        [Export("sharedApplication")]
        get
        {
            return (NSApplication)(__mt_SharedApplication_var_static = (NSApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedApplicationHandle)));
        }
    }

    public static void Init()
    {
        if (initialized)
            throw new InvalidOperationException("Init has already be be invoked; it can only be invoke once");

        initialized = true;

        Assembly assembly = typeof(NSApplication).Assembly;
        //RuntimeEx.RegisterEntryAssembly(assembly);
        Runtime.RegisterEntryAssembly(assembly);

        if (SynchronizationContext.Current == null)
            SynchronizationContext.SetSynchronizationContext(new AppKitSynchronizationContext());

        mainThread = Thread.CurrentThread;
    }

    public static void InitDrawingBridge()
    {
        FieldInfo field = Type.GetType("System.Drawing.GDIPlus, System.Drawing").GetField("UseCocoaDrawable", BindingFlags.Static | BindingFlags.Public);
        FieldInfo? field2 = Type.GetType("System.Drawing.GDIPlus, System.Drawing").GetField("UseCarbonDrawable", BindingFlags.Static | BindingFlags.Public);
        field.SetValue(null, true);
        field2.SetValue(null, false);
    }

    public static void Main(string[] args)
    {
        if (SynchronizationContext.Current == null || !typeof(AppKitSynchronizationContext).IsAssignableFrom(SynchronizationContext.Current.GetType()))
            SynchronizationContext.SetSynchronizationContext(new AppKitSynchronizationContext());

        mainThread = Thread.CurrentThread;
        NSApplicationMain(args.Length, args);
    }

    [Export("restoreWindowWithIdentifier:state:completionHandler:")]
    public unsafe static void RestoreWindow(string identifier, NSCoder state, NSWindowCompletionHandler onCompletion)
    {
        EnsureUIThread();
        if (identifier == null)
        {
            throw new ArgumentNullException("identifier");
        }
        if (state == null)
        {
            throw new ArgumentNullException("state");
        }
        if (onCompletion == null)
        {
            throw new ArgumentNullException("onCompletion");
        }
        IntPtr arg = NSString.CreateNative(identifier);
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDNSWindowCompletionHandler.Handler, onCompletion);
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRestoreWindowWithIdentifierStateCompletionHandler_Handle, arg, state.Handle, (IntPtr)ptr);
        NSString.ReleaseNative(arg);
        ptr->CleanupBlock();
    }


    [Field("NSApplicationDidBecomeActiveNotification", "AppKit")]
    public static NSString DidBecomeActiveNotification
    {
        get
        {
            if (_DidBecomeActiveNotification == null)
            {
                _DidBecomeActiveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationDidBecomeActiveNotification");
            }
            return _DidBecomeActiveNotification;
        }
    }

    [Field("NSApplicationDidHideNotification", "AppKit")]
    public static NSString DidHideNotification
    {
        get
        {
            if (_DidHideNotification == null)
            {
                _DidHideNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationDidHideNotification");
            }
            return _DidHideNotification;
        }
    }

    [Field("NSApplicationDidFinishLaunchingNotification", "AppKit")]
    public static NSString DidFinishLaunchingNotification
    {
        get
        {
            if (_DidFinishLaunchingNotification == null)
            {
                _DidFinishLaunchingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationDidFinishLaunchingNotification");
            }
            return _DidFinishLaunchingNotification;
        }
    }

    [Field("NSApplicationDidResignActiveNotification", "AppKit")]
    public static NSString DidResignActiveNotification
    {
        get
        {
            if (_DidResignActiveNotification == null)
            {
                _DidResignActiveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationDidResignActiveNotification");
            }
            return _DidResignActiveNotification;
        }
    }

    [Field("NSApplicationDidUnhideNotification", "AppKit")]
    public static NSString DidUnhideNotification
    {
        get
        {
            if (_DidUnhideNotification == null)
            {
                _DidUnhideNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationDidUnhideNotification");
            }
            return _DidUnhideNotification;
        }
    }

    [Field("NSApplicationDidUpdateNotification", "AppKit")]
    public static NSString DidUpdateNotification
    {
        get
        {
            if (_DidUpdateNotification == null)
            {
                _DidUpdateNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationDidUpdateNotification");
            }
            return _DidUpdateNotification;
        }
    }

    [Field("NSApplicationWillBecomeActiveNotification", "AppKit")]
    public static NSString WillBecomeActiveNotification
    {
        get
        {
            if (_WillBecomeActiveNotification == null)
            {
                _WillBecomeActiveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationWillBecomeActiveNotification");
            }
            return _WillBecomeActiveNotification;
        }
    }

    [Field("NSApplicationWillHideNotification", "AppKit")]
    public static NSString WillHideNotification
    {
        get
        {
            if (_WillHideNotification == null)
            {
                _WillHideNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationWillHideNotification");
            }
            return _WillHideNotification;
        }
    }

    [Field("NSApplicationWillFinishLaunchingNotification", "AppKit")]
    public static NSString WillFinishLaunchingNotification
    {
        get
        {
            if (_WillFinishLaunchingNotification == null)
            {
                _WillFinishLaunchingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationWillFinishLaunchingNotification");
            }
            return _WillFinishLaunchingNotification;
        }
    }

    [Field("NSApplicationWillResignActiveNotification", "AppKit")]
    public static NSString WillResignActiveNotification
    {
        get
        {
            if (_WillResignActiveNotification == null)
            {
                _WillResignActiveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationWillResignActiveNotification");
            }
            return _WillResignActiveNotification;
        }
    }

    [Field("NSApplicationWillUnhideNotification", "AppKit")]
    public static NSString WillUnhideNotification
    {
        get
        {
            if (_WillUnhideNotification == null)
            {
                _WillUnhideNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationWillUnhideNotification");
            }
            return _WillUnhideNotification;
        }
    }

    [Field("NSApplicationWillUpdateNotification", "AppKit")]
    public static NSString WillUpdateNotification
    {
        get
        {
            if (_WillUpdateNotification == null)
            {
                _WillUpdateNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationWillUpdateNotification");
            }
            return _WillUpdateNotification;
        }
    }

    [Field("NSApplicationWillTerminateNotification", "AppKit")]
    public static NSString WillTerminateNotification
    {
        get
        {
            if (_WillTerminateNotification == null)
            {
                _WillTerminateNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationWillTerminateNotification");
            }
            return _WillTerminateNotification;
        }
    }

    [Field("NSApplicationDidChangeScreenParametersNotification", "AppKit")]
    public static NSString DidChangeScreenParametersNotification
    {
        get
        {
            if (_DidChangeScreenParametersNotification == null)
            {
                _DidChangeScreenParametersNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationDidChangeScreenParametersNotification");
            }
            return _DidChangeScreenParametersNotification;
        }
    }

    [Field("NSApplicationLaunchIsDefaultLaunchKey", "AppKit")]
    public static NSString LaunchIsDefaultLaunchKey
    {
        get
        {
            if (_LaunchIsDefaultLaunchKey == null)
            {
                _LaunchIsDefaultLaunchKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationLaunchIsDefaultLaunchKey");
            }
            return _LaunchIsDefaultLaunchKey;
        }
    }

    [Field("NSApplicationLaunchRemoteNotificationKey", "AppKit")]
    public static NSString LaunchRemoteNotificationKey
    {
        get
        {
            if (_LaunchRemoteNotificationKey == null)
            {
                _LaunchRemoteNotificationKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationLaunchRemoteNotificationKey");
            }
            return _LaunchRemoteNotificationKey;
        }
    }

    [Field("NSApplicationDidFinishRestoringWindowsNotification", "AppKit")]
    public static NSString DidFinishRestoringWindowsNotification
    {
        get
        {
            if (_DidFinishRestoringWindowsNotification == null)
            {
                _DidFinishRestoringWindowsNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationDidFinishRestoringWindowsNotification");
            }
            return _DidFinishRestoringWindowsNotification;
        }
    }

    public NSApplicationActivationPolicy ActivationPolicy
    {
        get
        {
            return GetActivationPolicy();
        }
        set
        {
            SetActivationPolicy(value);
        }
    }

    public virtual NSObject WeakDelegate
    {
        [Export("delegate", ArgumentSemantic.Assign)]
        get
        {
            EnsureUIThread();
            return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selDelegateHandle))));
        }
        [Export("setDelegate:", ArgumentSemantic.Assign)]
        set
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
            }
            __mt_WeakDelegate_var = value;
        }
    }

    public NSApplicationDelegate Delegate
    {
        get
        {
            return WeakDelegate as NSApplicationDelegate;
        }
        set
        {
            WeakDelegate = value;
        }
    }

    public virtual NSGraphicsContext Context
    {
        [Export("context")]
        get
        {
            EnsureUIThread();
            return (NSGraphicsContext)(__mt_Context_var = ((!IsDirectBinding) ? ((NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selContextHandle))) : ((NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selContextHandle)))));
        }
    }

    public virtual NSWindow MainWindow
    {
        [Export("mainWindow")]
        get
        {
            EnsureUIThread();
            return (NSWindow)(__mt_MainWindow_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selMainWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selMainWindowHandle)))));
        }
    }

    public virtual NSWindow KeyWindow
    {
        [Export("keyWindow")]
        get
        {
            EnsureUIThread();
            return (NSWindow)(__mt_KeyWindow_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selKeyWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selKeyWindowHandle)))));
        }
    }

    public virtual bool Active
    {
        [Export("isActive")]
        get
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selIsActiveHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsActiveHandle);
        }
    }

    public virtual bool Hidden
    {
        [Export("isHidden")]
        get
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selIsHiddenHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsHiddenHandle);
        }
    }

    public virtual bool Running
    {
        [Export("isRunning")]
        get
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selIsRunningHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsRunningHandle);
        }
    }

    public virtual NSWindow ModalWindow
    {
        [Export("modalWindow")]
        get
        {
            EnsureUIThread();
            return (NSWindow)(__mt_ModalWindow_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selModalWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selModalWindowHandle)))));
        }
    }

    public virtual NSEvent CurrentEvent
    {
        [Export("currentEvent")]
        get
        {
            EnsureUIThread();
            return (NSEvent)(__mt_CurrentEvent_var = ((!IsDirectBinding) ? ((NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selCurrentEventHandle))) : ((NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selCurrentEventHandle)))));
        }
    }

    public virtual NSWindow[] Windows
    {
        [Export("windows")]
        get
        {
            EnsureUIThread();
            return (NSWindow[])(__mt_Windows_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selWindowsHandle)) : NSArray.ArrayFromHandle<NSWindow>(Messaging.IntPtr_objc_msgSend(Handle, selWindowsHandle))));
        }
    }

    public virtual NSMenu MainMenu
    {
        [Export("mainMenu")]
        get
        {
            EnsureUIThread();
            return (NSMenu)(__mt_MainMenu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selMainMenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selMainMenuHandle)))));
        }
        [Export("setMainMenu:")]
        set
        {
            EnsureUIThread();
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetMainMenu_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetMainMenu_Handle, value.Handle);
            }
            __mt_MainMenu_var = value;
        }
    }

    public virtual NSMenu HelpMenu
    {
        [Export("helpMenu")]
        get
        {
            EnsureUIThread();
            return (NSMenu)(__mt_HelpMenu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selHelpMenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selHelpMenuHandle)))));
        }
        [Export("setHelpMenu:")]
        set
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetHelpMenu_Handle, value?.Handle ?? IntPtr.Zero);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetHelpMenu_Handle, value?.Handle ?? IntPtr.Zero);
            }
            __mt_HelpMenu_var = value;
        }
    }

    public virtual NSImage ApplicationIconImage
    {
        [Export("applicationIconImage")]
        get
        {
            EnsureUIThread();
            return (NSImage)(__mt_ApplicationIconImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selApplicationIconImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selApplicationIconImageHandle)))));
        }
        [Export("setApplicationIconImage:")]
        set
        {
            EnsureUIThread();
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetApplicationIconImage_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetApplicationIconImage_Handle, value.Handle);
            }
            __mt_ApplicationIconImage_var = value;
        }
    }

    public virtual NSDockTile DockTile
    {
        [Export("dockTile")]
        get
        {
            EnsureUIThread();
            return (NSDockTile)(__mt_DockTile_var = ((!IsDirectBinding) ? ((NSDockTile)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selDockTileHandle))) : ((NSDockTile)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selDockTileHandle)))));
        }
    }

    public virtual NSApplicationPresentationOptions PresentationOptions
    {
        [Export("presentationOptions")]
        get
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                return (NSApplicationPresentationOptions)Messaging.UInt64_objc_msgSend(Handle, selPresentationOptionsHandle);
            }
            return (NSApplicationPresentationOptions)Messaging.UInt64_objc_msgSendSuper(SuperHandle, selPresentationOptionsHandle);
        }
        [Export("setPresentationOptions:")]
        set
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_UInt64(Handle, selSetPresentationOptions_Handle, (ulong)value);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_UInt64(SuperHandle, selSetPresentationOptions_Handle, (ulong)value);
            }
        }
    }

    public virtual NSApplicationPresentationOptions CurrentSystemPresentationOptions
    {
        [Export("currentSystemPresentationOptions")]
        get
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                return (NSApplicationPresentationOptions)Messaging.UInt64_objc_msgSend(Handle, selCurrentSystemPresentationOptionsHandle);
            }
            return (NSApplicationPresentationOptions)Messaging.UInt64_objc_msgSendSuper(SuperHandle, selCurrentSystemPresentationOptionsHandle);
        }
    }

    public virtual NSMenu WindowsMenu
    {
        [Export("windowsMenu")]
        get
        {
            EnsureUIThread();
            return (NSMenu)(__mt_WindowsMenu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selWindowsMenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selWindowsMenuHandle)))));
        }
        [Export("setWindowsMenu:")]
        set
        {
            EnsureUIThread();
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetWindowsMenu_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetWindowsMenu_Handle, value.Handle);
            }
            __mt_WindowsMenu_var = value;
        }
    }

    public virtual bool FullKeyboardAccessEnabled
    {
        [Export("isFullKeyboardAccessEnabled")]
        get
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(Handle, selIsFullKeyboardAccessEnabledHandle);
            }
            return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsFullKeyboardAccessEnabledHandle);
        }
    }

    public virtual NSObject ServicesProvider
    {
        [Export("servicesProvider")]
        get
        {
            EnsureUIThread();
            return (NSObject)(__mt_ServicesProvider_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selServicesProviderHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selServicesProviderHandle))));
        }
        [Export("setServicesProvider:")]
        set
        {
            EnsureUIThread();
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetServicesProvider_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetServicesProvider_Handle, value.Handle);
            }
            __mt_ServicesProvider_var = value;
        }
    }

    public virtual NSApplicationLayoutDirection UserInterfaceLayoutDirection
    {
        [Export("userInterfaceLayoutDirection")]
        get
        {
            EnsureUIThread();
            if (IsDirectBinding)
            {
                return (NSApplicationLayoutDirection)Messaging.Int64_objc_msgSend(Handle, selUserInterfaceLayoutDirectionHandle);
            }
            return (NSApplicationLayoutDirection)Messaging.Int64_objc_msgSendSuper(SuperHandle, selUserInterfaceLayoutDirectionHandle);
        }
    }

    public virtual NSMenu ServicesMenu
    {
        [Export("servicesMenu")]
        get
        {
            EnsureUIThread();
            return (NSMenu)(__mt_ServicesMenu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selServicesMenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selServicesMenuHandle)))));
        }
        [Export("setServicesMenu:")]
        set
        {
            EnsureUIThread();
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(Handle, selSetServicesMenu_Handle, value.Handle);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetServicesMenu_Handle, value.Handle);
            }
            __mt_ServicesMenu_var = value;
        }
    }


    public NSApplicationTermination ApplicationShouldTerminate
    {
        get
        {
            return EnsureNSApplicationDelegate().applicationShouldTerminate;
        }
        set
        {
            EnsureNSApplicationDelegate().applicationShouldTerminate = value;
        }
    }

    public NSApplicationFile OpenFile
    {
        get
        {
            return EnsureNSApplicationDelegate().openFile;
        }
        set
        {
            EnsureNSApplicationDelegate().openFile = value;
        }
    }

    public NSApplicationFile OpenTempFile
    {
        get
        {
            return EnsureNSApplicationDelegate().openTempFile;
        }
        set
        {
            EnsureNSApplicationDelegate().openTempFile = value;
        }
    }

    public NSApplicationPredicate ApplicationShouldOpenUntitledFile
    {
        get
        {
            return EnsureNSApplicationDelegate().applicationShouldOpenUntitledFile;
        }
        set
        {
            EnsureNSApplicationDelegate().applicationShouldOpenUntitledFile = value;
        }
    }

    public NSApplicationPredicate ApplicationOpenUntitledFile
    {
        get
        {
            return EnsureNSApplicationDelegate().applicationOpenUntitledFile;
        }
        set
        {
            EnsureNSApplicationDelegate().applicationOpenUntitledFile = value;
        }
    }

    public NSApplicationFileCommand OpenFileWithoutUI
    {
        get
        {
            return EnsureNSApplicationDelegate().openFileWithoutUI;
        }
        set
        {
            EnsureNSApplicationDelegate().openFileWithoutUI = value;
        }
    }

    public NSApplicationFile PrintFile
    {
        get
        {
            return EnsureNSApplicationDelegate().printFile;
        }
        set
        {
            EnsureNSApplicationDelegate().printFile = value;
        }
    }

    public NSApplicationPrint PrintFiles
    {
        get
        {
            return EnsureNSApplicationDelegate().printFiles;
        }
        set
        {
            EnsureNSApplicationDelegate().printFiles = value;
        }
    }

    public NSApplicationPredicate ApplicationShouldTerminateAfterLastWindowClosed
    {
        get
        {
            return EnsureNSApplicationDelegate().applicationShouldTerminateAfterLastWindowClosed;
        }
        set
        {
            EnsureNSApplicationDelegate().applicationShouldTerminateAfterLastWindowClosed = value;
        }
    }

    public NSApplicationReopen ApplicationShouldHandleReopen
    {
        get
        {
            return EnsureNSApplicationDelegate().applicationShouldHandleReopen;
        }
        set
        {
            EnsureNSApplicationDelegate().applicationShouldHandleReopen = value;
        }
    }

    public NSApplicationMenu ApplicationDockMenu
    {
        get
        {
            return EnsureNSApplicationDelegate().applicationDockMenu;
        }
        set
        {
            EnsureNSApplicationDelegate().applicationDockMenu = value;
        }
    }

    public NSApplicationError WillPresentError
    {
        get
        {
            return EnsureNSApplicationDelegate().willPresentError;
        }
        set
        {
            EnsureNSApplicationDelegate().willPresentError = value;
        }
    }

    public NSApplicationSelection WriteSelectionToPasteboard
    {
        get
        {
            return EnsureNSApplicationDelegate().writeSelectionToPasteboard;
        }
        set
        {
            EnsureNSApplicationDelegate().writeSelectionToPasteboard = value;
        }
    }

    public NSPasteboardPredicate ReadSelectionFromPasteboard
    {
        get
        {
            return EnsureNSApplicationDelegate().readSelectionFromPasteboard;
        }
        set
        {
            EnsureNSApplicationDelegate().readSelectionFromPasteboard = value;
        }
    }

    public event EventHandler<NSApplicationFilesEventArgs> OpenFiles
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.openFiles = (EventHandler<NSApplicationFilesEventArgs>)System.Delegate.Combine(nSApplicationDelegate.openFiles, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.openFiles = (EventHandler<NSApplicationFilesEventArgs>)System.Delegate.Remove(nSApplicationDelegate.openFiles, value);
        }
    }

    public event EventHandler WillFinishLaunching
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willFinishLaunching = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.willFinishLaunching, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willFinishLaunching = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.willFinishLaunching, value);
        }
    }

    public event EventHandler DidFinishLaunching
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didFinishLaunching = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.didFinishLaunching, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didFinishLaunching = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.didFinishLaunching, value);
        }
    }

    public event EventHandler WillHide
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willHide = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.willHide, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willHide = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.willHide, value);
        }
    }

    public event EventHandler DidHide
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didHide = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.didHide, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didHide = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.didHide, value);
        }
    }

    public event EventHandler WillUnhide
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willUnhide = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.willUnhide, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willUnhide = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.willUnhide, value);
        }
    }

    public event EventHandler DidUnhide
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didUnhide = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.didUnhide, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didUnhide = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.didUnhide, value);
        }
    }

    public event EventHandler WillBecomeActive
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willBecomeActive = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.willBecomeActive, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willBecomeActive = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.willBecomeActive, value);
        }
    }

    public event EventHandler DidBecomeActive
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didBecomeActive = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.didBecomeActive, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didBecomeActive = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.didBecomeActive, value);
        }
    }

    public event EventHandler WillResignActive
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willResignActive = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.willResignActive, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willResignActive = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.willResignActive, value);
        }
    }

    public event EventHandler DidResignActive
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didResignActive = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.didResignActive, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didResignActive = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.didResignActive, value);
        }
    }

    public event EventHandler WillUpdate
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willUpdate = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.willUpdate, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willUpdate = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.willUpdate, value);
        }
    }

    public event EventHandler DidUpdate
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didUpdate = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.didUpdate, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.didUpdate = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.didUpdate, value);
        }
    }

    public event EventHandler WillTerminate
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willTerminate = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.willTerminate, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willTerminate = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.willTerminate, value);
        }
    }

    public event EventHandler ScreenParametersChanged
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.screenParametersChanged = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.screenParametersChanged, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.screenParametersChanged = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.screenParametersChanged, value);
        }
    }

    public event EventHandler<NSApplicationRegisterEventArgs> RegisterServicesMenu
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.registerServicesMenu = (EventHandler<NSApplicationRegisterEventArgs>)System.Delegate.Combine(nSApplicationDelegate.registerServicesMenu, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.registerServicesMenu = (EventHandler<NSApplicationRegisterEventArgs>)System.Delegate.Remove(nSApplicationDelegate.registerServicesMenu, value);
        }
    }

    public event EventHandler OrderFrontStandardAboutPanel
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.orderFrontStandardAboutPanel = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.orderFrontStandardAboutPanel, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.orderFrontStandardAboutPanel = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.orderFrontStandardAboutPanel, value);
        }
    }

    public event EventHandler OrderFrontStandardAboutPanelWithOptions
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.orderFrontStandardAboutPanelWithOptions = (EventHandler)System.Delegate.Combine(nSApplicationDelegate.orderFrontStandardAboutPanelWithOptions, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.orderFrontStandardAboutPanelWithOptions = (EventHandler)System.Delegate.Remove(nSApplicationDelegate.orderFrontStandardAboutPanelWithOptions, value);
        }
    }

    public event EventHandler<NSDataEventArgs> RegisteredForRemoteNotifications
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.registeredForRemoteNotifications = (EventHandler<NSDataEventArgs>)System.Delegate.Combine(nSApplicationDelegate.registeredForRemoteNotifications, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.registeredForRemoteNotifications = (EventHandler<NSDataEventArgs>)System.Delegate.Remove(nSApplicationDelegate.registeredForRemoteNotifications, value);
        }
    }

    public event EventHandler<NSErrorEventArgs> FailedToRegisterForRemoteNotifications
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.failedToRegisterForRemoteNotifications = (EventHandler<NSErrorEventArgs>)System.Delegate.Combine(nSApplicationDelegate.failedToRegisterForRemoteNotifications, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.failedToRegisterForRemoteNotifications = (EventHandler<NSErrorEventArgs>)System.Delegate.Remove(nSApplicationDelegate.failedToRegisterForRemoteNotifications, value);
        }
    }

    public event EventHandler<NSDictionaryEventArgs> ReceivedRemoteNotification
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.receivedRemoteNotification = (EventHandler<NSDictionaryEventArgs>)System.Delegate.Combine(nSApplicationDelegate.receivedRemoteNotification, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.receivedRemoteNotification = (EventHandler<NSDictionaryEventArgs>)System.Delegate.Remove(nSApplicationDelegate.receivedRemoteNotification, value);
        }
    }

    public event EventHandler<NSCoderEventArgs> WillEncodeRestorableState
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willEncodeRestorableState = (EventHandler<NSCoderEventArgs>)System.Delegate.Combine(nSApplicationDelegate.willEncodeRestorableState, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.willEncodeRestorableState = (EventHandler<NSCoderEventArgs>)System.Delegate.Remove(nSApplicationDelegate.willEncodeRestorableState, value);
        }
    }

    public event EventHandler<NSCoderEventArgs> DecodedRestorableState
    {
        add
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.decodedRestorableState = (EventHandler<NSCoderEventArgs>)System.Delegate.Combine(nSApplicationDelegate.decodedRestorableState, value);
        }
        remove
        {
            _NSApplicationDelegate nSApplicationDelegate = EnsureNSApplicationDelegate();
            nSApplicationDelegate.decodedRestorableState = (EventHandler<NSCoderEventArgs>)System.Delegate.Remove(nSApplicationDelegate.decodedRestorableState, value);
        }
    }

    public void BeginSheet(NSWindow sheet, NSWindow docWindow)
    {
        BeginSheet(sheet, docWindow, null, null, IntPtr.Zero);
    }

    public void BeginSheet(NSWindow sheet, NSWindow docWindow, NSAction onEnded)
    {
        NSObject modalDelegate = OneShotTracker.Create(onEnded);
        BeginSheet(sheet, docWindow, modalDelegate, NSActionDispatcher.Selector, IntPtr.Zero);
    }

    public static void EnsureUIThread()
    {
        if (CheckForIllegalCrossThreadCalls && mainThread != Thread.CurrentThread)
            throw new AppKitThreadAccessException();
    }

    public NSEvent NextEvent(NSEventMask mask, NSDate expiration, string mode, bool deqFlag)
    {
        return NextEvent((uint)mask, expiration, mode, deqFlag);
    }

    public void DiscardEvents(NSEventMask mask, NSEvent lastEvent)
    {
        DiscardEvents((uint)mask, lastEvent);
    }

    [Export("hide:")]
    public virtual void Hide(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selHide_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selHide_Handle, sender.Handle);
        }
    }

    [Export("unhide:")]
    public virtual void Unhide(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selUnhide_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selUnhide_Handle, sender.Handle);
        }
    }

    [Export("unhideWithoutActivation")]
    public virtual void UnhideWithoutActivation()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selUnhideWithoutActivationHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selUnhideWithoutActivationHandle);
        }
    }

    [Export("windowWithWindowNumber:")]
    public virtual NSWindow WindowWithWindowNumber(long windowNum)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            return (NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(Handle, selWindowWithWindowNumber_Handle, windowNum));
        }
        return (NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(SuperHandle, selWindowWithWindowNumber_Handle, windowNum));
    }

    [Export("deactivate")]
    public virtual void Deactivate()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selDeactivateHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selDeactivateHandle);
        }
    }

    [Export("activateIgnoringOtherApps:")]
    public virtual void ActivateIgnoringOtherApps(bool flag)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_bool(Handle, selActivateIgnoringOtherApps_Handle, flag);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_bool(SuperHandle, selActivateIgnoringOtherApps_Handle, flag);
        }
    }

    [Export("hideOtherApplications:")]
    public virtual void HideOtherApplications(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selHideOtherApplications_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selHideOtherApplications_Handle, sender.Handle);
        }
    }

    [Export("unhideAllApplications:")]
    public virtual void UnhideAllApplications(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selUnhideAllApplications_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selUnhideAllApplications_Handle, sender.Handle);
        }
    }

    [Export("finishLaunching")]
    public virtual void FinishLaunching()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selFinishLaunchingHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selFinishLaunchingHandle);
        }
    }

    [Export("run")]
    public virtual void Run()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selRunHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selRunHandle);
        }
    }

    [Export("runModalForWindow:")]
    public virtual long RunModalForWindow(NSWindow theWindow)
    {
        EnsureUIThread();
        if (theWindow == null)
        {
            throw new ArgumentNullException("theWindow");
        }
        if (IsDirectBinding)
        {
            return Messaging.Int64_objc_msgSend_IntPtr(Handle, selRunModalForWindow_Handle, theWindow.Handle);
        }
        return Messaging.Int64_objc_msgSendSuper_IntPtr(SuperHandle, selRunModalForWindow_Handle, theWindow.Handle);
    }

    [Export("stop:")]
    public virtual void Stop(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selStop_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selStop_Handle, sender.Handle);
        }
    }

    [Export("stopModal")]
    public virtual void StopModal()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selStopModalHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selStopModalHandle);
        }
    }

    [Export("stopModalWithCode:")]
    public virtual void StopModalWithCode(long returnCode)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_Int64(Handle, selStopModalWithCode_Handle, returnCode);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_Int64(SuperHandle, selStopModalWithCode_Handle, returnCode);
        }
    }

    [Export("abortModal")]
    [ThreadSafe]
    public virtual void AbortModal()
    {
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selAbortModalHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selAbortModalHandle);
        }
    }

    [Export("beginModalSessionForWindow:")]
    public virtual IntPtr BeginModalSession(NSWindow theWindow)
    {
        EnsureUIThread();
        if (theWindow == null)
        {
            throw new ArgumentNullException("theWindow");
        }
        if (IsDirectBinding)
        {
            return Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selBeginModalSessionForWindow_Handle, theWindow.Handle);
        }
        return Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selBeginModalSessionForWindow_Handle, theWindow.Handle);
    }

    [Export("runModalSession:")]
    public virtual long RunModalSession(IntPtr session)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            return Messaging.Int64_objc_msgSend_IntPtr(Handle, selRunModalSession_Handle, session);
        }
        return Messaging.Int64_objc_msgSendSuper_IntPtr(SuperHandle, selRunModalSession_Handle, session);
    }

    [Export("endModalSession:")]
    public virtual void EndModalSession(IntPtr session)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selEndModalSession_Handle, session);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selEndModalSession_Handle, session);
        }
    }

    [Export("terminate:")]
    public virtual void Terminate(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selTerminate_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selTerminate_Handle, sender.Handle);
        }
    }

    [Export("requestUserAttention:")]
    public virtual long RequestUserAttention(NSRequestUserAttentionType requestType)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            return Messaging.Int64_objc_msgSend_UInt64(Handle, selRequestUserAttention_Handle, (ulong)requestType);
        }
        return Messaging.Int64_objc_msgSendSuper_UInt64(SuperHandle, selRequestUserAttention_Handle, (ulong)requestType);
    }

    [Export("cancelUserAttentionRequest:")]
    public virtual void CancelUserAttentionRequest(long request)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_Int64(Handle, selCancelUserAttentionRequest_Handle, request);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_Int64(SuperHandle, selCancelUserAttentionRequest_Handle, request);
        }
    }

    [Export("beginSheet:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
    public virtual void BeginSheet(NSWindow sheet, NSWindow docWindow, NSObject modalDelegate, Selector didEndSelector, IntPtr contextInfo)
    {
        EnsureUIThread();
        if (sheet == null)
        {
            throw new ArgumentNullException("sheet");
        }
        if (docWindow == null)
        {
            throw new ArgumentNullException("docWindow");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selBeginSheetModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, sheet.Handle, docWindow.Handle, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(SuperHandle, selBeginSheetModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, sheet.Handle, docWindow.Handle, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
        }
    }

    [Export("endSheet:")]
    public virtual void EndSheet(NSWindow sheet)
    {
        EnsureUIThread();
        if (sheet == null)
        {
            throw new ArgumentNullException("sheet");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selEndSheet_Handle, sheet.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selEndSheet_Handle, sheet.Handle);
        }
    }

    [Export("endSheet:returnCode:")]
    public virtual void EndSheet(NSWindow sheet, long returnCode)
    {
        EnsureUIThread();
        if (sheet == null)
        {
            throw new ArgumentNullException("sheet");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_Int64(Handle, selEndSheetReturnCode_Handle, sheet.Handle, returnCode);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_Int64(SuperHandle, selEndSheetReturnCode_Handle, sheet.Handle, returnCode);
        }
    }

    [Export("nextEventMatchingMask:untilDate:inMode:dequeue:")]
    protected virtual NSEvent NextEvent(ulong mask, NSDate expiration, string mode, bool deqFlag)
    {
        EnsureUIThread();
        if (expiration == null)
        {
            throw new ArgumentNullException("expiration");
        }
        if (mode == null)
        {
            throw new ArgumentNullException("mode");
        }
        IntPtr arg = NSString.CreateNative(mode);
        NSEvent result = ((!IsDirectBinding) ? ((NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_bool(SuperHandle, selNextEventMatchingMaskUntilDateInModeDequeue_Handle, mask, expiration.Handle, arg, deqFlag))) : ((NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_bool(Handle, selNextEventMatchingMaskUntilDateInModeDequeue_Handle, mask, expiration.Handle, arg, deqFlag))));
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export("discardEventsMatchingMask:beforeEvent:")]
    protected virtual void DiscardEvents(ulong mask, NSEvent lastEvent)
    {
        EnsureUIThread();
        if (lastEvent == null)
        {
            throw new ArgumentNullException("lastEvent");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_UInt64_IntPtr(Handle, selDiscardEventsMatchingMaskBeforeEvent_Handle, mask, lastEvent.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_UInt64_IntPtr(SuperHandle, selDiscardEventsMatchingMaskBeforeEvent_Handle, mask, lastEvent.Handle);
        }
    }

    [Export("postEvent:atStart:")]
    [ThreadSafe]
    public virtual void PostEvent(NSEvent theEvent, bool atStart)
    {
        if (theEvent == null)
        {
            throw new ArgumentNullException("theEvent");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_bool(Handle, selPostEventAtStart_Handle, theEvent.Handle, atStart);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_bool(SuperHandle, selPostEventAtStart_Handle, theEvent.Handle, atStart);
        }
    }

    [Export("sendEvent:")]
    public virtual void SendEvent(NSEvent theEvent)
    {
        EnsureUIThread();
        if (theEvent == null)
        {
            throw new ArgumentNullException("theEvent");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selSendEvent_Handle, theEvent.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSendEvent_Handle, theEvent.Handle);
        }
    }

    [Export("preventWindowOrdering")]
    public virtual void PreventWindowOrdering()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selPreventWindowOrderingHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selPreventWindowOrderingHandle);
        }
    }

    [Export("makeWindowsPerform:inOrder:")]
    public virtual NSWindow MakeWindowsPerform(Selector aSelector, bool inOrder)
    {
        EnsureUIThread();
        if (aSelector == null)
        {
            throw new ArgumentNullException("aSelector");
        }
        if (IsDirectBinding)
        {
            return (NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_bool(Handle, selMakeWindowsPerformInOrder_Handle, aSelector.Handle, inOrder));
        }
        return (NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(SuperHandle, selMakeWindowsPerformInOrder_Handle, aSelector.Handle, inOrder));
    }

    [Export("setWindowsNeedUpdate:")]
    public virtual void SetWindowsNeedUpdate(bool needUpdate)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_bool(Handle, selSetWindowsNeedUpdate_Handle, needUpdate);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_bool(SuperHandle, selSetWindowsNeedUpdate_Handle, needUpdate);
        }
    }

    [Export("updateWindows")]
    public virtual void UpdateWindows()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selUpdateWindowsHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selUpdateWindowsHandle);
        }
    }

    [Export("setMainMenu:")]
    [Obsolete("Use MainMenu property", false)]
    public virtual void SetMainMenu(NSMenu aMenu)
    {
        EnsureUIThread();
        if (aMenu == null)
        {
            throw new ArgumentNullException("aMenu");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selSetMainMenu_Handle, aMenu.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetMainMenu_Handle, aMenu.Handle);
        }
    }

    [Export("activationPolicy")]
    protected virtual NSApplicationActivationPolicy GetActivationPolicy()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            return (NSApplicationActivationPolicy)Messaging.Int64_objc_msgSend(Handle, selActivationPolicyHandle);
        }
        return (NSApplicationActivationPolicy)Messaging.Int64_objc_msgSendSuper(SuperHandle, selActivationPolicyHandle);
    }

    [Export("setActivationPolicy:")]
    protected virtual bool SetActivationPolicy(NSApplicationActivationPolicy activationPolicy)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_Int64(Handle, selSetActivationPolicy_Handle, (long)activationPolicy);
        }
        return Messaging.bool_objc_msgSendSuper_Int64(SuperHandle, selSetActivationPolicy_Handle, (long)activationPolicy);
    }

    [Export("sendAction:to:from:")]
    public virtual bool SendAction(Selector theAction, NSObject theTarget, NSObject sender)
    {
        EnsureUIThread();
        if (theAction == null)
        {
            throw new ArgumentNullException("theAction");
        }
        if (theTarget == null)
        {
            throw new ArgumentNullException("theTarget");
        }
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selSendActionToFrom_Handle, theAction.Handle, theTarget.Handle, sender.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selSendActionToFrom_Handle, theAction.Handle, theTarget.Handle, sender.Handle);
    }

    [Export("targetForAction:")]
    public virtual NSObject TargetForAction(Selector theAction)
    {
        EnsureUIThread();
        if (theAction == null)
        {
            throw new ArgumentNullException("theAction");
        }
        if (IsDirectBinding)
        {
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selTargetForAction_Handle, theAction.Handle));
        }
        return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selTargetForAction_Handle, theAction.Handle));
    }

    [Export("targetForAction:to:from:")]
    public virtual NSObject TargetForAction(Selector theAction, NSObject theTarget, NSObject sender)
    {
        EnsureUIThread();
        if (theAction == null)
        {
            throw new ArgumentNullException("theAction");
        }
        if (theTarget == null)
        {
            throw new ArgumentNullException("theTarget");
        }
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selTargetForActionToFrom_Handle, theAction.Handle, theTarget.Handle, sender.Handle));
        }
        return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selTargetForActionToFrom_Handle, theAction.Handle, theTarget.Handle, sender.Handle));
    }

    [Export("tryToPerform:with:")]
    public virtual bool TryToPerform(Selector anAction, NSObject target)
    {
        EnsureUIThread();
        if (anAction == null)
        {
            throw new ArgumentNullException("anAction");
        }
        if (target == null)
        {
            throw new ArgumentNullException("target");
        }
        if (IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr_IntPtr(Handle, selTryToPerformWith_Handle, anAction.Handle, target.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selTryToPerformWith_Handle, anAction.Handle, target.Handle);
    }

    [Export("validRequestorForSendType:returnType:")]
    public virtual NSObject ValidRequestor(string sendType, string returnType)
    {
        EnsureUIThread();
        if (sendType == null)
        {
            throw new ArgumentNullException("sendType");
        }
        if (returnType == null)
        {
            throw new ArgumentNullException("returnType");
        }
        IntPtr arg = NSString.CreateNative(sendType);
        IntPtr arg2 = NSString.CreateNative(returnType);
        NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selValidRequestorForSendTypeReturnType_Handle, arg, arg2)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(Handle, selValidRequestorForSendTypeReturnType_Handle, arg, arg2)));
        NSString.ReleaseNative(arg);
        NSString.ReleaseNative(arg2);
        return result;
    }

    [Export("reportException:")]
    public virtual void ReportException(NSException theException)
    {
        EnsureUIThread();
        if (theException == null)
        {
            throw new ArgumentNullException("theException");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selReportException_Handle, theException.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selReportException_Handle, theException.Handle);
        }
    }

    [Export("detachDrawingThread:toTarget:withObject:")]
    public static void DetachDrawingThread(Selector selector, NSObject target, NSObject argument)
    {
        EnsureUIThread();
        if (selector == null)
        {
            throw new ArgumentNullException("selector");
        }
        if (target == null)
        {
            throw new ArgumentNullException("target");
        }
        if (argument == null)
        {
            throw new ArgumentNullException("argument");
        }
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selDetachDrawingThreadToTargetWithObject_Handle, selector.Handle, target.Handle, argument.Handle);
    }

    [Export("replyToApplicationShouldTerminate:")]
    public virtual void ReplyToApplicationShouldTerminate(bool shouldTerminate)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_bool(Handle, selReplyToApplicationShouldTerminate_Handle, shouldTerminate);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_bool(SuperHandle, selReplyToApplicationShouldTerminate_Handle, shouldTerminate);
        }
    }

    [Export("replyToOpenOrPrint:")]
    public virtual void ReplyToOpenOrPrint(NSApplicationDelegateReply reply)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_UInt64(Handle, selReplyToOpenOrPrint_Handle, (ulong)reply);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_UInt64(SuperHandle, selReplyToOpenOrPrint_Handle, (ulong)reply);
        }
    }

    [Export("orderFrontCharacterPalette:")]
    public virtual void OrderFrontCharacterPalette(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selOrderFrontCharacterPalette_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selOrderFrontCharacterPalette_Handle, sender.Handle);
        }
    }

    [Export("arrangeInFront:")]
    public virtual void ArrangeInFront(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selArrangeInFront_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selArrangeInFront_Handle, sender.Handle);
        }
    }

    [Export("removeWindowsItem:")]
    public virtual void RemoveWindowsItem(NSWindow win)
    {
        EnsureUIThread();
        if (win == null)
        {
            throw new ArgumentNullException("win");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selRemoveWindowsItem_Handle, win.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selRemoveWindowsItem_Handle, win.Handle);
        }
    }

    [Export("addWindowsItem:title:filename:")]
    public virtual void AddWindowsItem(NSWindow win, string title, bool isFilename)
    {
        EnsureUIThread();
        if (win == null)
        {
            throw new ArgumentNullException("win");
        }
        if (title == null)
        {
            throw new ArgumentNullException("title");
        }
        IntPtr arg = NSString.CreateNative(title);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(Handle, selAddWindowsItemTitleFilename_Handle, win.Handle, arg, isFilename);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(SuperHandle, selAddWindowsItemTitleFilename_Handle, win.Handle, arg, isFilename);
        }
        NSString.ReleaseNative(arg);
    }

    [Export("changeWindowsItem:title:filename:")]
    public virtual void ChangeWindowsItem(NSWindow win, string title, bool isFilename)
    {
        EnsureUIThread();
        if (win == null)
        {
            throw new ArgumentNullException("win");
        }
        if (title == null)
        {
            throw new ArgumentNullException("title");
        }
        IntPtr arg = NSString.CreateNative(title);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(Handle, selChangeWindowsItemTitleFilename_Handle, win.Handle, arg, isFilename);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(SuperHandle, selChangeWindowsItemTitleFilename_Handle, win.Handle, arg, isFilename);
        }
        NSString.ReleaseNative(arg);
    }

    [Export("updateWindowsItem:")]
    public virtual void UpdateWindowsItem(NSWindow win)
    {
        EnsureUIThread();
        if (win == null)
        {
            throw new ArgumentNullException("win");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selUpdateWindowsItem_Handle, win.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selUpdateWindowsItem_Handle, win.Handle);
        }
    }

    [Export("miniaturizeAll:")]
    public virtual void MiniaturizeAll(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selMiniaturizeAll_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selMiniaturizeAll_Handle, sender.Handle);
        }
    }

    [Export("orderFrontColorPanel:")]
    public virtual void OrderFrontColorPanel(NSObject sender)
    {
        EnsureUIThread();
        if (sender == null)
        {
            throw new ArgumentNullException("sender");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selOrderFrontColorPanel_Handle, sender.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selOrderFrontColorPanel_Handle, sender.Handle);
        }
    }

    [Export("disableRelaunchOnLogin")]
    [ThreadSafe]
    public virtual void DisableRelaunchOnLogin()
    {
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selDisableRelaunchOnLoginHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selDisableRelaunchOnLoginHandle);
        }
    }

    [Export("enableRelaunchOnLogin")]
    [ThreadSafe]
    public virtual void EnableRelaunchOnLogin()
    {
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selEnableRelaunchOnLoginHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selEnableRelaunchOnLoginHandle);
        }
    }

    [Export("enabledRemoteNotificationTypes")]
    public virtual NSRemoteNotificationType EnabledRemoteNotificationTypes()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            return (NSRemoteNotificationType)Messaging.UInt64_objc_msgSend(Handle, selEnabledRemoteNotificationTypesHandle);
        }
        return (NSRemoteNotificationType)Messaging.UInt64_objc_msgSendSuper(SuperHandle, selEnabledRemoteNotificationTypesHandle);
    }

    [Export("registerForRemoteNotificationTypes:")]
    public virtual void RegisterForRemoteNotificationTypes(NSRemoteNotificationType types)
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_UInt64(Handle, selRegisterForRemoteNotificationTypes_Handle, (ulong)types);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_UInt64(SuperHandle, selRegisterForRemoteNotificationTypes_Handle, (ulong)types);
        }
    }

    [Export("unregisterForRemoteNotifications")]
    public virtual void UnregisterForRemoteNotifications()
    {
        EnsureUIThread();
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selUnregisterForRemoteNotificationsHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selUnregisterForRemoteNotificationsHandle);
        }
    }

    private _NSApplicationDelegate EnsureNSApplicationDelegate()
    {
        NSObject nSObject = WeakDelegate;
        if (nSObject == null || !(nSObject is _NSApplicationDelegate))
        {
            nSObject = (WeakDelegate = new _NSApplicationDelegate());
        }
        return (_NSApplicationDelegate)nSObject;
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (Handle == IntPtr.Zero)
        {
            __mt_WeakDelegate_var = null;
            __mt_Context_var = null;
            __mt_MainWindow_var = null;
            __mt_KeyWindow_var = null;
            __mt_ModalWindow_var = null;
            __mt_CurrentEvent_var = null;
            __mt_Windows_var = null;
            __mt_MainMenu_var = null;
            __mt_HelpMenu_var = null;
            __mt_ApplicationIconImage_var = null;
            __mt_DockTile_var = null;
            __mt_WindowsMenu_var = null;
            __mt_ServicesProvider_var = null;
            __mt_ServicesMenu_var = null;
        }
    }
}
