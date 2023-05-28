using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSWorkspace", true)]
public class NSWorkspace : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveActiveSpaceDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(ActiveSpaceDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveActiveSpaceDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(ActiveSpaceDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidActivateApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidActivateApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidActivateApplication(NSObject objectToObserve, EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidActivateApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeFileLabels(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidChangeFileLabelsNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeFileLabels(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidChangeFileLabelsNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidDeactivateApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidDeactivateApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidDeactivateApplication(NSObject objectToObserve, EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidDeactivateApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidHideApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidHideApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidHideApplication(NSObject objectToObserve, EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidHideApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidLaunchApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidLaunchApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidLaunchApplication(NSObject objectToObserve, EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidLaunchApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidMount(EventHandler<NSWorkspaceMountEventArgs> handler)
		{
			EventHandler<NSWorkspaceMountEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidMountNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceMountEventArgs(notification));
			});
		}

		public static NSObject ObserveDidMount(NSObject objectToObserve, EventHandler<NSWorkspaceMountEventArgs> handler)
		{
			EventHandler<NSWorkspaceMountEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidMountNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceMountEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidPerformFileOperation(EventHandler<NSWorkspaceFileOperationEventArgs> handler)
		{
			EventHandler<NSWorkspaceFileOperationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidPerformFileOperationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceFileOperationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidPerformFileOperation(NSObject objectToObserve, EventHandler<NSWorkspaceFileOperationEventArgs> handler)
		{
			EventHandler<NSWorkspaceFileOperationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidPerformFileOperationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceFileOperationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidRenameVolume(EventHandler<NSWorkspaceRenamedEventArgs> handler)
		{
			EventHandler<NSWorkspaceRenamedEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidRenameVolumeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceRenamedEventArgs(notification));
			});
		}

		public static NSObject ObserveDidRenameVolume(NSObject objectToObserve, EventHandler<NSWorkspaceRenamedEventArgs> handler)
		{
			EventHandler<NSWorkspaceRenamedEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidRenameVolumeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceRenamedEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidTerminateApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidTerminateApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidTerminateApplication(NSObject objectToObserve, EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidTerminateApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidUnhideApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidUnhideApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUnhideApplication(NSObject objectToObserve, EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidUnhideApplicationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidUnmount(EventHandler<NSWorkspaceMountEventArgs> handler)
		{
			EventHandler<NSWorkspaceMountEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidUnmountNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceMountEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUnmount(NSObject objectToObserve, EventHandler<NSWorkspaceMountEventArgs> handler)
		{
			EventHandler<NSWorkspaceMountEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidUnmountNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceMountEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidWake(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidWakeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidWake(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(DidWakeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDisplayOptionsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DisplayOptionsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDisplayOptionsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DisplayOptionsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveScreensDidSleep(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(ScreensDidSleepNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveScreensDidSleep(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(ScreensDidSleepNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveScreensDidWake(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(ScreensDidWakeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveScreensDidWake(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(ScreensDidWakeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSessionDidBecomeActive(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(SessionDidBecomeActiveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSessionDidBecomeActive(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(SessionDidBecomeActiveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSessionDidResignActive(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(SessionDidResignActiveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSessionDidResignActive(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(SessionDidResignActiveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillLaunchApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(WillLaunchApplication, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillLaunchApplication(NSObject objectToObserve, EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			EventHandler<NSWorkspaceApplicationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(WillLaunchApplication, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceApplicationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillPowerOff(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(WillPowerOffNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillPowerOff(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(WillPowerOffNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillSleep(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(WillSleepNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillSleep(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(WillSleepNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillUnmount(EventHandler<NSWorkspaceMountEventArgs> handler)
		{
			EventHandler<NSWorkspaceMountEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(WillUnmountNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceMountEventArgs(notification));
			});
		}

		public static NSObject ObserveWillUnmount(NSObject objectToObserve, EventHandler<NSWorkspaceMountEventArgs> handler)
		{
			EventHandler<NSWorkspaceMountEventArgs> handler2 = handler;
			return SharedWorkspace.NotificationCenter.AddObserver(WillUnmountNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSWorkspaceMountEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForApplicationToOpenURL_ = "URLForApplicationToOpenURL:";

	private static readonly IntPtr selURLForApplicationToOpenURL_Handle = Selector.GetHandle("URLForApplicationToOpenURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForApplicationWithBundleIdentifier_ = "URLForApplicationWithBundleIdentifier:";

	private static readonly IntPtr selURLForApplicationWithBundleIdentifier_Handle = Selector.GetHandle("URLForApplicationWithBundleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbsolutePathForAppBundleWithIdentifier_ = "absolutePathForAppBundleWithIdentifier:";

	private static readonly IntPtr selAbsolutePathForAppBundleWithIdentifier_Handle = Selector.GetHandle("absolutePathForAppBundleWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisplayShouldDifferentiateWithoutColor = "accessibilityDisplayShouldDifferentiateWithoutColor";

	private static readonly IntPtr selAccessibilityDisplayShouldDifferentiateWithoutColorHandle = Selector.GetHandle("accessibilityDisplayShouldDifferentiateWithoutColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisplayShouldIncreaseContrast = "accessibilityDisplayShouldIncreaseContrast";

	private static readonly IntPtr selAccessibilityDisplayShouldIncreaseContrastHandle = Selector.GetHandle("accessibilityDisplayShouldIncreaseContrast");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisplayShouldInvertColors = "accessibilityDisplayShouldInvertColors";

	private static readonly IntPtr selAccessibilityDisplayShouldInvertColorsHandle = Selector.GetHandle("accessibilityDisplayShouldInvertColors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisplayShouldReduceMotion = "accessibilityDisplayShouldReduceMotion";

	private static readonly IntPtr selAccessibilityDisplayShouldReduceMotionHandle = Selector.GetHandle("accessibilityDisplayShouldReduceMotion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDisplayShouldReduceTransparency = "accessibilityDisplayShouldReduceTransparency";

	private static readonly IntPtr selAccessibilityDisplayShouldReduceTransparencyHandle = Selector.GetHandle("accessibilityDisplayShouldReduceTransparency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActivateFileViewerSelectingURLs_ = "activateFileViewerSelectingURLs:";

	private static readonly IntPtr selActivateFileViewerSelectingURLs_Handle = Selector.GetHandle("activateFileViewerSelectingURLs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveApplication = "activeApplication";

	private static readonly IntPtr selActiveApplicationHandle = Selector.GetHandle("activeApplication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDesktopImageOptionsForScreen_ = "desktopImageOptionsForScreen:";

	private static readonly IntPtr selDesktopImageOptionsForScreen_Handle = Selector.GetHandle("desktopImageOptionsForScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDesktopImageURLForScreen_ = "desktopImageURLForScreen:";

	private static readonly IntPtr selDesktopImageURLForScreen_Handle = Selector.GetHandle("desktopImageURLForScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuplicateURLs_CompletionHandler_ = "duplicateURLs:completionHandler:";

	private static readonly IntPtr selDuplicateURLs_CompletionHandler_Handle = Selector.GetHandle("duplicateURLs:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendPowerOffBy_ = "extendPowerOffBy:";

	private static readonly IntPtr selExtendPowerOffBy_Handle = Selector.GetHandle("extendPowerOffBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileLabelColors = "fileLabelColors";

	private static readonly IntPtr selFileLabelColorsHandle = Selector.GetHandle("fileLabelColors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileLabels = "fileLabels";

	private static readonly IntPtr selFileLabelsHandle = Selector.GetHandle("fileLabels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilenameExtension_IsValidForType_ = "filenameExtension:isValidForType:";

	private static readonly IntPtr selFilenameExtension_IsValidForType_Handle = Selector.GetHandle("filenameExtension:isValidForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrontmostApplication = "frontmostApplication";

	private static readonly IntPtr selFrontmostApplicationHandle = Selector.GetHandle("frontmostApplication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullPathForApplication_ = "fullPathForApplication:";

	private static readonly IntPtr selFullPathForApplication_Handle = Selector.GetHandle("fullPathForApplication:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFileSystemInfoForPath_IsRemovable_IsWritable_IsUnmountable_Description_Type_ = "getFileSystemInfoForPath:isRemovable:isWritable:isUnmountable:description:type:";

	private static readonly IntPtr selGetFileSystemInfoForPath_IsRemovable_IsWritable_IsUnmountable_Description_Type_Handle = Selector.GetHandle("getFileSystemInfoForPath:isRemovable:isWritable:isUnmountable:description:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetInfoForFile_Application_Type_ = "getInfoForFile:application:type:";

	private static readonly IntPtr selGetInfoForFile_Application_Type_Handle = Selector.GetHandle("getInfoForFile:application:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHideOtherApplications = "hideOtherApplications";

	private static readonly IntPtr selHideOtherApplicationsHandle = Selector.GetHandle("hideOtherApplications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIconForFile_ = "iconForFile:";

	private static readonly IntPtr selIconForFile_Handle = Selector.GetHandle("iconForFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIconForFileType_ = "iconForFileType:";

	private static readonly IntPtr selIconForFileType_Handle = Selector.GetHandle("iconForFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIconForFiles_ = "iconForFiles:";

	private static readonly IntPtr selIconForFiles_Handle = Selector.GetHandle("iconForFiles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFilePackageAtPath_ = "isFilePackageAtPath:";

	private static readonly IntPtr selIsFilePackageAtPath_Handle = Selector.GetHandle("isFilePackageAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSwitchControlEnabled = "isSwitchControlEnabled";

	private static readonly IntPtr selIsSwitchControlEnabledHandle = Selector.GetHandle("isSwitchControlEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVoiceOverEnabled = "isVoiceOverEnabled";

	private static readonly IntPtr selIsVoiceOverEnabledHandle = Selector.GetHandle("isVoiceOverEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunchAppWithBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifier_ = "launchAppWithBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifier:";

	private static readonly IntPtr selLaunchAppWithBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifier_Handle = Selector.GetHandle("launchAppWithBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunchApplication_ = "launchApplication:";

	private static readonly IntPtr selLaunchApplication_Handle = Selector.GetHandle("launchApplication:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunchApplication_ShowIcon_Autolaunch_ = "launchApplication:showIcon:autolaunch:";

	private static readonly IntPtr selLaunchApplication_ShowIcon_Autolaunch_Handle = Selector.GetHandle("launchApplication:showIcon:autolaunch:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunchApplicationAtURL_Options_Configuration_Error_ = "launchApplicationAtURL:options:configuration:error:";

	private static readonly IntPtr selLaunchApplicationAtURL_Options_Configuration_Error_Handle = Selector.GetHandle("launchApplicationAtURL:options:configuration:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLaunchedApplications = "launchedApplications";

	private static readonly IntPtr selLaunchedApplicationsHandle = Selector.GetHandle("launchedApplications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedDescriptionForType_ = "localizedDescriptionForType:";

	private static readonly IntPtr selLocalizedDescriptionForType_Handle = Selector.GetHandle("localizedDescriptionForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuBarOwningApplication = "menuBarOwningApplication";

	private static readonly IntPtr selMenuBarOwningApplicationHandle = Selector.GetHandle("menuBarOwningApplication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMountedLocalVolumePaths = "mountedLocalVolumePaths";

	private static readonly IntPtr selMountedLocalVolumePathsHandle = Selector.GetHandle("mountedLocalVolumePaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMountedRemovableMedia = "mountedRemovableMedia";

	private static readonly IntPtr selMountedRemovableMediaHandle = Selector.GetHandle("mountedRemovableMedia");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteFileSystemChanged_ = "noteFileSystemChanged:";

	private static readonly IntPtr selNoteFileSystemChanged_Handle = Selector.GetHandle("noteFileSystemChanged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotificationCenter = "notificationCenter";

	private static readonly IntPtr selNotificationCenterHandle = Selector.GetHandle("notificationCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenApplicationAtURL_Configuration_CompletionHandler_ = "openApplicationAtURL:configuration:completionHandler:";

	private static readonly IntPtr selOpenApplicationAtURL_Configuration_CompletionHandler_Handle = Selector.GetHandle("openApplicationAtURL:configuration:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenFile_ = "openFile:";

	private static readonly IntPtr selOpenFile_Handle = Selector.GetHandle("openFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenFile_FromImage_At_InView_ = "openFile:fromImage:at:inView:";

	private static readonly IntPtr selOpenFile_FromImage_At_InView_Handle = Selector.GetHandle("openFile:fromImage:at:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenFile_WithApplication_ = "openFile:withApplication:";

	private static readonly IntPtr selOpenFile_WithApplication_Handle = Selector.GetHandle("openFile:withApplication:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenFile_WithApplication_AndDeactivate_ = "openFile:withApplication:andDeactivate:";

	private static readonly IntPtr selOpenFile_WithApplication_AndDeactivate_Handle = Selector.GetHandle("openFile:withApplication:andDeactivate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenURL_ = "openURL:";

	private static readonly IntPtr selOpenURL_Handle = Selector.GetHandle("openURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenURL_Configuration_CompletionHandler_ = "openURL:configuration:completionHandler:";

	private static readonly IntPtr selOpenURL_Configuration_CompletionHandler_Handle = Selector.GetHandle("openURL:configuration:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenURL_Options_Configuration_Error_ = "openURL:options:configuration:error:";

	private static readonly IntPtr selOpenURL_Options_Configuration_Error_Handle = Selector.GetHandle("openURL:options:configuration:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenURLs_WithAppBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifiers_ = "openURLs:withAppBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifiers:";

	private static readonly IntPtr selOpenURLs_WithAppBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifiers_Handle = Selector.GetHandle("openURLs:withAppBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenURLs_WithApplicationAtURL_Configuration_CompletionHandler_ = "openURLs:withApplicationAtURL:configuration:completionHandler:";

	private static readonly IntPtr selOpenURLs_WithApplicationAtURL_Configuration_CompletionHandler_Handle = Selector.GetHandle("openURLs:withApplicationAtURL:configuration:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenURLs_WithApplicationAtURL_Options_Configuration_Error_ = "openURLs:withApplicationAtURL:options:configuration:error:";

	private static readonly IntPtr selOpenURLs_WithApplicationAtURL_Options_Configuration_Error_Handle = Selector.GetHandle("openURLs:withApplicationAtURL:options:configuration:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformFileOperation_Source_Destination_Files_Tag_ = "performFileOperation:source:destination:files:tag:";

	private static readonly IntPtr selPerformFileOperation_Source_Destination_Files_Tag_Handle = Selector.GetHandle("performFileOperation:source:destination:files:tag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredFilenameExtensionForType_ = "preferredFilenameExtensionForType:";

	private static readonly IntPtr selPreferredFilenameExtensionForType_Handle = Selector.GetHandle("preferredFilenameExtensionForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecycleURLs_CompletionHandler_ = "recycleURLs:completionHandler:";

	private static readonly IntPtr selRecycleURLs_CompletionHandler_Handle = Selector.GetHandle("recycleURLs:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAuthorizationOfType_CompletionHandler_ = "requestAuthorizationOfType:completionHandler:";

	private static readonly IntPtr selRequestAuthorizationOfType_CompletionHandler_Handle = Selector.GetHandle("requestAuthorizationOfType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunningApplications = "runningApplications";

	private static readonly IntPtr selRunningApplicationsHandle = Selector.GetHandle("runningApplications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectFile_InFileViewerRootedAtPath_ = "selectFile:inFileViewerRootedAtPath:";

	private static readonly IntPtr selSelectFile_InFileViewerRootedAtPath_Handle = Selector.GetHandle("selectFile:inFileViewerRootedAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDesktopImageURL_ForScreen_Options_Error_ = "setDesktopImageURL:forScreen:options:error:";

	private static readonly IntPtr selSetDesktopImageURL_ForScreen_Options_Error_Handle = Selector.GetHandle("setDesktopImageURL:forScreen:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIcon_ForFile_Options_ = "setIcon:forFile:options:";

	private static readonly IntPtr selSetIcon_ForFile_Options_Handle = Selector.GetHandle("setIcon:forFile:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedWorkspace = "sharedWorkspace";

	private static readonly IntPtr selSharedWorkspaceHandle = Selector.GetHandle("sharedWorkspace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowSearchResultsForQueryString_ = "showSearchResultsForQueryString:";

	private static readonly IntPtr selShowSearchResultsForQueryString_Handle = Selector.GetHandle("showSearchResultsForQueryString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType_ConformsToType_ = "type:conformsToType:";

	private static readonly IntPtr selType_ConformsToType_Handle = Selector.GetHandle("type:conformsToType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypeOfFile_Error_ = "typeOfFile:error:";

	private static readonly IntPtr selTypeOfFile_Error_Handle = Selector.GetHandle("typeOfFile:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnmountAndEjectDeviceAtPath_ = "unmountAndEjectDeviceAtPath:";

	private static readonly IntPtr selUnmountAndEjectDeviceAtPath_Handle = Selector.GetHandle("unmountAndEjectDeviceAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnmountAndEjectDeviceAtURL_Error_ = "unmountAndEjectDeviceAtURL:error:";

	private static readonly IntPtr selUnmountAndEjectDeviceAtURL_Error_Handle = Selector.GetHandle("unmountAndEjectDeviceAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSWorkspace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActiveSpaceDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidActivateApplicationNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeFileLabelsNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidDeactivateApplicationNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidHideApplicationNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidLaunchApplicationNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidMountNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidPerformFileOperationNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidRenameVolumeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidTerminateApplicationNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidUnhideApplicationNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidUnmountNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidWakeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayOptionsDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LaunchConfigurationAppleEvent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LaunchConfigurationArchitecture;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LaunchConfigurationArguments;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LaunchConfigurationEnvironment;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OperationCopy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OperationDestroy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OperationDuplicate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OperationLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OperationMove;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OperationRecycle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScreensDidSleepNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScreensDidWakeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SessionDidBecomeActiveNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SessionDidResignActiveNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillLaunchApplication;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillPowerOffNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillSleepNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillUnmountNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityDisplayShouldDifferentiateWithoutColor
	{
		[Export("accessibilityDisplayShouldDifferentiateWithoutColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityDisplayShouldDifferentiateWithoutColorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisplayShouldDifferentiateWithoutColorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityDisplayShouldIncreaseContrast
	{
		[Export("accessibilityDisplayShouldIncreaseContrast")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityDisplayShouldIncreaseContrastHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisplayShouldIncreaseContrastHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityDisplayShouldInvertColors
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("accessibilityDisplayShouldInvertColors")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityDisplayShouldInvertColorsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisplayShouldInvertColorsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityDisplayShouldReduceMotion
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("accessibilityDisplayShouldReduceMotion")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityDisplayShouldReduceMotionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisplayShouldReduceMotionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AccessibilityDisplayShouldReduceTransparency
	{
		[Export("accessibilityDisplayShouldReduceTransparency")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityDisplayShouldReduceTransparencyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityDisplayShouldReduceTransparencyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSWorkspace.FrontmostApplication' instead.")]
	public virtual NSDictionary ActiveApplication
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSWorkspace.FrontmostApplication' instead.")]
		[Export("activeApplication")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selActiveApplicationHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActiveApplicationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public virtual NSColor[] FileLabelColors
	{
		[Export("fileLabelColors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileLabelColorsHandle));
			}
			return NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileLabelColorsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public virtual string[] FileLabels
	{
		[Export("fileLabels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFileLabelsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileLabelsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRunningApplication FrontmostApplication
	{
		[Export("frontmostApplication")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSend(base.Handle, selFrontmostApplicationHandle));
			}
			return Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrontmostApplicationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, "Use 'NSWorkspace.RunningApplications' instead.")]
	public virtual NSDictionary[] LaunchedApplications
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, "Use 'NSWorkspace.RunningApplications' instead.")]
		[Export("launchedApplications")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selLaunchedApplicationsHandle));
			}
			return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLaunchedApplicationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRunningApplication MenuBarOwningApplication
	{
		[Export("menuBarOwningApplication")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuBarOwningApplicationHandle));
			}
			return Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuBarOwningApplicationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	public virtual string[] MountedLocalVolumePaths
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		[Export("mountedLocalVolumePaths")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMountedLocalVolumePathsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMountedLocalVolumePathsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	public virtual string[] MountedRemovableMedia
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		[Export("mountedRemovableMedia")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMountedRemovableMediaHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMountedRemovableMediaHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public virtual NSNotificationCenter NotificationCenter
	{
		[Export("notificationCenter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNotificationCenter>(Messaging.IntPtr_objc_msgSend(base.Handle, selNotificationCenterHandle));
			}
			return Runtime.GetNSObject<NSNotificationCenter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNotificationCenterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public virtual NSRunningApplication[] RunningApplications
	{
		[Export("runningApplications")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSRunningApplication>(Messaging.IntPtr_objc_msgSend(base.Handle, selRunningApplicationsHandle));
			}
			return NSArray.ArrayFromHandle<NSRunningApplication>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRunningApplicationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public static NSWorkspace SharedWorkspace
	{
		[Export("sharedWorkspace")]
		get
		{
			return Runtime.GetNSObject<NSWorkspace>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedWorkspaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool SwitchControlEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("isSwitchControlEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSwitchControlEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSwitchControlEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool VoiceOverEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("isVoiceOverEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVoiceOverEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVoiceOverEnabledHandle);
		}
	}

	[Field("NSWorkspaceActiveSpaceDidChangeNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveActiveSpaceDidChange helper method instead.")]
	public static NSString ActiveSpaceDidChangeNotification
	{
		get
		{
			if (_ActiveSpaceDidChangeNotification == null)
			{
				_ActiveSpaceDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceActiveSpaceDidChangeNotification");
			}
			return _ActiveSpaceDidChangeNotification;
		}
	}

	[Field("NSWorkspaceDidActivateApplicationNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidActivateApplication helper method instead.")]
	public static NSString DidActivateApplicationNotification
	{
		get
		{
			if (_DidActivateApplicationNotification == null)
			{
				_DidActivateApplicationNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidActivateApplicationNotification");
			}
			return _DidActivateApplicationNotification;
		}
	}

	[Field("NSWorkspaceDidChangeFileLabelsNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidChangeFileLabels helper method instead.")]
	public static NSString DidChangeFileLabelsNotification
	{
		get
		{
			if (_DidChangeFileLabelsNotification == null)
			{
				_DidChangeFileLabelsNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidChangeFileLabelsNotification");
			}
			return _DidChangeFileLabelsNotification;
		}
	}

	[Field("NSWorkspaceDidDeactivateApplicationNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidDeactivateApplication helper method instead.")]
	public static NSString DidDeactivateApplicationNotification
	{
		get
		{
			if (_DidDeactivateApplicationNotification == null)
			{
				_DidDeactivateApplicationNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidDeactivateApplicationNotification");
			}
			return _DidDeactivateApplicationNotification;
		}
	}

	[Field("NSWorkspaceDidHideApplicationNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidHideApplication helper method instead.")]
	public static NSString DidHideApplicationNotification
	{
		get
		{
			if (_DidHideApplicationNotification == null)
			{
				_DidHideApplicationNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidHideApplicationNotification");
			}
			return _DidHideApplicationNotification;
		}
	}

	[Field("NSWorkspaceDidLaunchApplicationNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidLaunchApplication helper method instead.")]
	public static NSString DidLaunchApplicationNotification
	{
		get
		{
			if (_DidLaunchApplicationNotification == null)
			{
				_DidLaunchApplicationNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidLaunchApplicationNotification");
			}
			return _DidLaunchApplicationNotification;
		}
	}

	[Field("NSWorkspaceDidMountNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidMount helper method instead.")]
	public static NSString DidMountNotification
	{
		get
		{
			if (_DidMountNotification == null)
			{
				_DidMountNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidMountNotification");
			}
			return _DidMountNotification;
		}
	}

	[Field("NSWorkspaceDidPerformFileOperationNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidPerformFileOperation helper method instead.")]
	public static NSString DidPerformFileOperationNotification
	{
		get
		{
			if (_DidPerformFileOperationNotification == null)
			{
				_DidPerformFileOperationNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidPerformFileOperationNotification");
			}
			return _DidPerformFileOperationNotification;
		}
	}

	[Field("NSWorkspaceDidRenameVolumeNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidRenameVolume helper method instead.")]
	public static NSString DidRenameVolumeNotification
	{
		get
		{
			if (_DidRenameVolumeNotification == null)
			{
				_DidRenameVolumeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidRenameVolumeNotification");
			}
			return _DidRenameVolumeNotification;
		}
	}

	[Field("NSWorkspaceDidTerminateApplicationNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidTerminateApplication helper method instead.")]
	public static NSString DidTerminateApplicationNotification
	{
		get
		{
			if (_DidTerminateApplicationNotification == null)
			{
				_DidTerminateApplicationNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidTerminateApplicationNotification");
			}
			return _DidTerminateApplicationNotification;
		}
	}

	[Field("NSWorkspaceDidUnhideApplicationNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidUnhideApplication helper method instead.")]
	public static NSString DidUnhideApplicationNotification
	{
		get
		{
			if (_DidUnhideApplicationNotification == null)
			{
				_DidUnhideApplicationNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidUnhideApplicationNotification");
			}
			return _DidUnhideApplicationNotification;
		}
	}

	[Field("NSWorkspaceDidUnmountNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidUnmount helper method instead.")]
	public static NSString DidUnmountNotification
	{
		get
		{
			if (_DidUnmountNotification == null)
			{
				_DidUnmountNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidUnmountNotification");
			}
			return _DidUnmountNotification;
		}
	}

	[Field("NSWorkspaceDidWakeNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveDidWake helper method instead.")]
	public static NSString DidWakeNotification
	{
		get
		{
			if (_DidWakeNotification == null)
			{
				_DidWakeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDidWakeNotification");
			}
			return _DidWakeNotification;
		}
	}

	[Field("NSWorkspaceAccessibilityDisplayOptionsDidChangeNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Advice("Use NSWorkspace.Notifications.ObserveDisplayOptionsDidChange helper method instead.")]
	public static NSString DisplayOptionsDidChangeNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_DisplayOptionsDidChangeNotification == null)
			{
				_DisplayOptionsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceAccessibilityDisplayOptionsDidChangeNotification");
			}
			return _DisplayOptionsDidChangeNotification;
		}
	}

	[Field("NSWorkspaceLaunchConfigurationAppleEvent", "AppKit")]
	public static NSString LaunchConfigurationAppleEvent
	{
		get
		{
			if (_LaunchConfigurationAppleEvent == null)
			{
				_LaunchConfigurationAppleEvent = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceLaunchConfigurationAppleEvent");
			}
			return _LaunchConfigurationAppleEvent;
		}
	}

	[Field("NSWorkspaceLaunchConfigurationArchitecture", "AppKit")]
	public static NSString LaunchConfigurationArchitecture
	{
		get
		{
			if (_LaunchConfigurationArchitecture == null)
			{
				_LaunchConfigurationArchitecture = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceLaunchConfigurationArchitecture");
			}
			return _LaunchConfigurationArchitecture;
		}
	}

	[Field("NSWorkspaceLaunchConfigurationArguments", "AppKit")]
	public static NSString LaunchConfigurationArguments
	{
		get
		{
			if (_LaunchConfigurationArguments == null)
			{
				_LaunchConfigurationArguments = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceLaunchConfigurationArguments");
			}
			return _LaunchConfigurationArguments;
		}
	}

	[Field("NSWorkspaceLaunchConfigurationEnvironment", "AppKit")]
	public static NSString LaunchConfigurationEnvironment
	{
		get
		{
			if (_LaunchConfigurationEnvironment == null)
			{
				_LaunchConfigurationEnvironment = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceLaunchConfigurationEnvironment");
			}
			return _LaunchConfigurationEnvironment;
		}
	}

	[Field("NSWorkspaceCopyOperation", "AppKit")]
	public static NSString OperationCopy
	{
		get
		{
			if (_OperationCopy == null)
			{
				_OperationCopy = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceCopyOperation");
			}
			return _OperationCopy;
		}
	}

	[Field("NSWorkspaceDestroyOperation", "AppKit")]
	public static NSString OperationDestroy
	{
		get
		{
			if (_OperationDestroy == null)
			{
				_OperationDestroy = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDestroyOperation");
			}
			return _OperationDestroy;
		}
	}

	[Field("NSWorkspaceDuplicateOperation", "AppKit")]
	public static NSString OperationDuplicate
	{
		get
		{
			if (_OperationDuplicate == null)
			{
				_OperationDuplicate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceDuplicateOperation");
			}
			return _OperationDuplicate;
		}
	}

	[Field("NSWorkspaceLinkOperation", "AppKit")]
	public static NSString OperationLink
	{
		get
		{
			if (_OperationLink == null)
			{
				_OperationLink = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceLinkOperation");
			}
			return _OperationLink;
		}
	}

	[Field("NSWorkspaceMoveOperation", "AppKit")]
	public static NSString OperationMove
	{
		get
		{
			if (_OperationMove == null)
			{
				_OperationMove = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceMoveOperation");
			}
			return _OperationMove;
		}
	}

	[Field("NSWorkspaceRecycleOperation", "AppKit")]
	public static NSString OperationRecycle
	{
		get
		{
			if (_OperationRecycle == null)
			{
				_OperationRecycle = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceRecycleOperation");
			}
			return _OperationRecycle;
		}
	}

	[Field("NSWorkspaceScreensDidSleepNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveScreensDidSleep helper method instead.")]
	public static NSString ScreensDidSleepNotification
	{
		get
		{
			if (_ScreensDidSleepNotification == null)
			{
				_ScreensDidSleepNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceScreensDidSleepNotification");
			}
			return _ScreensDidSleepNotification;
		}
	}

	[Field("NSWorkspaceScreensDidWakeNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveScreensDidWake helper method instead.")]
	public static NSString ScreensDidWakeNotification
	{
		get
		{
			if (_ScreensDidWakeNotification == null)
			{
				_ScreensDidWakeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceScreensDidWakeNotification");
			}
			return _ScreensDidWakeNotification;
		}
	}

	[Field("NSWorkspaceSessionDidBecomeActiveNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveSessionDidBecomeActive helper method instead.")]
	public static NSString SessionDidBecomeActiveNotification
	{
		get
		{
			if (_SessionDidBecomeActiveNotification == null)
			{
				_SessionDidBecomeActiveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceSessionDidBecomeActiveNotification");
			}
			return _SessionDidBecomeActiveNotification;
		}
	}

	[Field("NSWorkspaceSessionDidResignActiveNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveSessionDidResignActive helper method instead.")]
	public static NSString SessionDidResignActiveNotification
	{
		get
		{
			if (_SessionDidResignActiveNotification == null)
			{
				_SessionDidResignActiveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceSessionDidResignActiveNotification");
			}
			return _SessionDidResignActiveNotification;
		}
	}

	[Field("NSWorkspaceWillLaunchApplicationNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveWillLaunchApplication helper method instead.")]
	public static NSString WillLaunchApplication
	{
		get
		{
			if (_WillLaunchApplication == null)
			{
				_WillLaunchApplication = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceWillLaunchApplicationNotification");
			}
			return _WillLaunchApplication;
		}
	}

	[Field("NSWorkspaceWillPowerOffNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveWillPowerOff helper method instead.")]
	public static NSString WillPowerOffNotification
	{
		get
		{
			if (_WillPowerOffNotification == null)
			{
				_WillPowerOffNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceWillPowerOffNotification");
			}
			return _WillPowerOffNotification;
		}
	}

	[Field("NSWorkspaceWillSleepNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveWillSleep helper method instead.")]
	public static NSString WillSleepNotification
	{
		get
		{
			if (_WillSleepNotification == null)
			{
				_WillSleepNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceWillSleepNotification");
			}
			return _WillSleepNotification;
		}
	}

	[Field("NSWorkspaceWillUnmountNotification", "AppKit")]
	[Advice("Use NSWorkspace.Notifications.ObserveWillUnmount helper method instead.")]
	public static NSString WillUnmountNotification
	{
		get
		{
			if (_WillUnmountNotification == null)
			{
				_WillUnmountNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWorkspaceWillUnmountNotification");
			}
			return _WillUnmountNotification;
		}
	}

	public virtual bool OpenUrls(NSUrl[] urls, string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor, string[] identifiers)
	{
		return _OpenUrls(urls, bundleIdentifier, options, descriptor, null);
	}

	public virtual bool OpenUrls(NSUrl[] urls, string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor)
	{
		return _OpenUrls(urls, bundleIdentifier, options, descriptor, null);
	}

	public virtual NSImage IconForFileType(string fileType)
	{
		IntPtr fileTypeOrTypeCode = NSString.CreateNative(fileType);
		try
		{
			return IconForFileType(fileTypeOrTypeCode);
		}
		finally
		{
			NSString.ReleaseNative(fileTypeOrTypeCode);
		}
	}

	public virtual NSImage IconForFileType(HfsTypeCode typeCode)
	{
		IntPtr nSFileType = GetNSFileType((uint)typeCode);
		return IconForFileType(nSFileType);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern IntPtr NSFileTypeForHFSTypeCode(uint hfsFileTypeCode);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern int UTGetOSTypeFromString(IntPtr str);

	private static IntPtr GetNSFileType(uint fourCcTypeCode)
	{
		return NSFileTypeForHFSTypeCode(fourCcTypeCode);
	}

	[Obsolete("Use the overload that takes 'ref NSError' instead.")]
	public virtual NSRunningApplication LaunchApplication(NSUrl url, NSWorkspaceLaunchOptions options, NSDictionary configuration, NSError error)
	{
		return LaunchApplication(url, options, configuration, out error);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSWorkspace()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSWorkspace(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSWorkspace(IntPtr handle)
		: base(handle)
	{
	}

	[Export("absolutePathForAppBundleWithIdentifier:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the 'UrlForApplication' method instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? AbsolutePathForAppBundle(string bundleIdentifier)
	{
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAbsolutePathForAppBundleWithIdentifier_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAbsolutePathForAppBundleWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("activateFileViewerSelectingURLs:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ActivateFileViewer(NSUrl[] fileUrls)
	{
		if (fileUrls == null)
		{
			throw new ArgumentNullException("fileUrls");
		}
		NSArray nSArray = NSArray.FromNSObjects(fileUrls);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selActivateFileViewerSelectingURLs_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selActivateFileViewerSelectingURLs_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("desktopImageOptionsForScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary DesktopImageOptions(NSScreen screen)
	{
		NSApplication.EnsureUIThread();
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDesktopImageOptionsForScreen_Handle, screen.Handle));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDesktopImageOptionsForScreen_Handle, screen.Handle));
	}

	[Export("desktopImageURLForScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl DesktopImageUrl(NSScreen screen)
	{
		NSApplication.EnsureUIThread();
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDesktopImageURLForScreen_Handle, screen.Handle));
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDesktopImageURLForScreen_Handle, screen.Handle));
	}

	[Export("duplicateURLs:completionHandler:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DuplicateUrls(NSArray urls, [BlockProxy(typeof(Trampolines.NIDNSWorkspaceUrlHandler))] NSWorkspaceUrlHandler completionHandler)
	{
		if (urls == null)
		{
			throw new ArgumentNullException("urls");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSWorkspaceUrlHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDuplicateURLs_CompletionHandler_Handle, urls.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDuplicateURLs_CompletionHandler_Handle, urls.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("extendPowerOffBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ExtendPowerOffBy(nint requested)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selExtendPowerOffBy_Handle, requested);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selExtendPowerOffBy_Handle, requested);
	}

	[Export("fullPathForApplication:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the 'UrlForApplication' method instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? FullPathForApplication(string appName)
	{
		if (appName == null)
		{
			throw new ArgumentNullException("appName");
		}
		IntPtr arg = NSString.CreateNative(appName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFullPathForApplication_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFullPathForApplication_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getFileSystemInfoForPath:isRemovable:isWritable:isUnmountable:description:type:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetFileSystemInfo(string fullPath, out bool removableFlag, out bool writableFlag, out bool unmountableFlag, out string description, out string fileSystemType)
	{
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(fullPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_out_Boolean_out_Boolean_out_Boolean_ref_IntPtr_ref_IntPtr(base.SuperHandle, selGetFileSystemInfoForPath_IsRemovable_IsWritable_IsUnmountable_Description_Type_Handle, arg3, out removableFlag, out writableFlag, out unmountableFlag, ref arg, ref arg2) : Messaging.bool_objc_msgSend_IntPtr_out_Boolean_out_Boolean_out_Boolean_ref_IntPtr_ref_IntPtr(base.Handle, selGetFileSystemInfoForPath_IsRemovable_IsWritable_IsUnmountable_Description_Type_Handle, arg3, out removableFlag, out writableFlag, out unmountableFlag, ref arg, ref arg2));
		NSString.ReleaseNative(arg3);
		description = NSString.FromHandle(arg);
		fileSystemType = NSString.FromHandle(arg2);
		return result;
	}

	[Export("getInfoForFile:application:type:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetInfo(string fullPath, out string appName, out string fileType)
	{
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(fullPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_ref_IntPtr(base.SuperHandle, selGetInfoForFile_Application_Type_Handle, arg3, ref arg, ref arg2) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_ref_IntPtr(base.Handle, selGetInfoForFile_Application_Type_Handle, arg3, ref arg, ref arg2));
		NSString.ReleaseNative(arg3);
		appName = NSString.FromHandle(arg);
		fileType = NSString.FromHandle(arg2);
		return result;
	}

	[Export("hideOtherApplications")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HideOtherApplications()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selHideOtherApplicationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selHideOtherApplicationsHandle);
		}
	}

	[Export("iconForFile:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage IconForFile(string fullPath)
	{
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		NSImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIconForFile_Handle, arg)) : Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIconForFile_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("iconForFileType:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSImage IconForFileType(IntPtr fileTypeOrTypeCode)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIconForFileType_Handle, fileTypeOrTypeCode));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIconForFileType_Handle, fileTypeOrTypeCode));
	}

	[Export("iconForFiles:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage IconForFiles(string[] fullPaths)
	{
		if (fullPaths == null)
		{
			throw new ArgumentNullException("fullPaths");
		}
		NSArray nSArray = NSArray.FromStrings(fullPaths);
		NSImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIconForFiles_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIconForFiles_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("isFilePackageAtPath:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFilePackage(string fullPath)
	{
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsFilePackageAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsFilePackageAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("filenameExtension:isValidForType:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFilenameExtensionValid(string filenameExtension, string typeName)
	{
		if (filenameExtension == null)
		{
			throw new ArgumentNullException("filenameExtension");
		}
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(filenameExtension);
		IntPtr arg2 = NSString.CreateNative(typeName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFilenameExtension_IsValidForType_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selFilenameExtension_IsValidForType_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("launchAppWithBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifier:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LaunchApp(string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor, IntPtr identifier)
	{
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selLaunchAppWithBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifier_Handle, arg, (ulong)options, descriptor.Handle, identifier) : Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selLaunchAppWithBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifier_Handle, arg, (ulong)options, descriptor.Handle, identifier));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("launchApplication:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LaunchApplication(string appName)
	{
		if (appName == null)
		{
			throw new ArgumentNullException("appName");
		}
		IntPtr arg = NSString.CreateNative(appName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLaunchApplication_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLaunchApplication_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("launchApplicationAtURL:options:configuration:error:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRunningApplication LaunchApplication(NSUrl url, NSWorkspaceLaunchOptions options, NSDictionary configuration, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		IntPtr arg = IntPtr.Zero;
		NSRunningApplication result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_ref_IntPtr(base.SuperHandle, selLaunchApplicationAtURL_Options_Configuration_Error_Handle, url.Handle, (ulong)options, configuration.Handle, ref arg)) : Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_ref_IntPtr(base.Handle, selLaunchApplicationAtURL_Options_Configuration_Error_Handle, url.Handle, (ulong)options, configuration.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("launchApplication:showIcon:autolaunch:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LaunchApplication(string appName, bool showIcon, bool autolaunch)
	{
		if (appName == null)
		{
			throw new ArgumentNullException("appName");
		}
		IntPtr arg = NSString.CreateNative(appName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_bool(base.SuperHandle, selLaunchApplication_ShowIcon_Autolaunch_Handle, arg, showIcon, autolaunch) : Messaging.bool_objc_msgSend_IntPtr_bool_bool(base.Handle, selLaunchApplication_ShowIcon_Autolaunch_Handle, arg, showIcon, autolaunch));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedDescriptionForType:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedDescription(string typeName)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocalizedDescriptionForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLocalizedDescriptionForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("noteFileSystemChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteFileSystemChanged(string path)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoteFileSystemChanged_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoteFileSystemChanged_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("openApplicationAtURL:configuration:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void OpenApplication(NSUrl applicationUrl, NSWorkspaceOpenConfiguration configuration, [BlockProxy(typeof(Trampolines.NIDActionArity2V10))] Action<NSRunningApplication, NSError>? completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (applicationUrl == null)
		{
			throw new ArgumentNullException("applicationUrl");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V10.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selOpenApplicationAtURL_Configuration_CompletionHandler_Handle, applicationUrl.Handle, configuration.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selOpenApplicationAtURL_Configuration_CompletionHandler_Handle, applicationUrl.Handle, configuration.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSRunningApplication> OpenApplicationAsync(NSUrl applicationUrl, NSWorkspaceOpenConfiguration configuration)
	{
		TaskCompletionSource<NSRunningApplication> tcs = new TaskCompletionSource<NSRunningApplication>();
		OpenApplication(applicationUrl, configuration, delegate(NSRunningApplication arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("openFile:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the 'OpenUrl' method instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OpenFile(string fullPath)
	{
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpenFile_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selOpenFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("openFile:withApplication:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OpenFile(string fullPath, string? appName)
	{
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		IntPtr arg2 = NSString.CreateNative(appName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selOpenFile_WithApplication_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selOpenFile_WithApplication_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("openFile:withApplication:andDeactivate:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OpenFile(string fullPath, string? appName, bool deactivate)
	{
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		IntPtr arg2 = NSString.CreateNative(appName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selOpenFile_WithApplication_AndDeactivate_Handle, arg, arg2, deactivate) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selOpenFile_WithApplication_AndDeactivate_Handle, arg, arg2, deactivate));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("openFile:fromImage:at:inView:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSWorkspace.OpenUrl' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OpenFile(string fullPath, NSImage anImage, CGPoint point, NSView aView)
	{
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		if (anImage == null)
		{
			throw new ArgumentNullException("anImage");
		}
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_CGPoint_IntPtr(base.SuperHandle, selOpenFile_FromImage_At_InView_Handle, arg, anImage.Handle, point, aView.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr(base.Handle, selOpenFile_FromImage_At_InView_Handle, arg, anImage.Handle, point, aView.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("openURL:options:configuration:error:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRunningApplication? OpenURL(NSUrl url, NSWorkspaceLaunchOptions options, NSDictionary configuration, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		IntPtr arg = IntPtr.Zero;
		NSRunningApplication result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_ref_IntPtr(base.SuperHandle, selOpenURL_Options_Configuration_Error_Handle, url.Handle, (ulong)options, configuration.Handle, ref arg)) : Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_ref_IntPtr(base.Handle, selOpenURL_Options_Configuration_Error_Handle, url.Handle, (ulong)options, configuration.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("openURLs:withApplicationAtURL:options:configuration:error:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRunningApplication? OpenURLs(NSUrl[] urls, NSUrl applicationURL, NSWorkspaceLaunchOptions options, NSDictionary configuration, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (urls == null)
		{
			throw new ArgumentNullException("urls");
		}
		if (applicationURL == null)
		{
			throw new ArgumentNullException("applicationURL");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(urls);
		NSRunningApplication result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_ref_IntPtr(base.SuperHandle, selOpenURLs_WithApplicationAtURL_Options_Configuration_Error_Handle, nSArray.Handle, applicationURL.Handle, (ulong)options, configuration.Handle, ref arg)) : Runtime.GetNSObject<NSRunningApplication>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_ref_IntPtr(base.Handle, selOpenURLs_WithApplicationAtURL_Options_Configuration_Error_Handle, nSArray.Handle, applicationURL.Handle, (ulong)options, configuration.Handle, ref arg)));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("openURL:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OpenUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selOpenURL_Handle, url.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpenURL_Handle, url.Handle);
	}

	[Export("openURL:configuration:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void OpenUrl(NSUrl url, NSWorkspaceOpenConfiguration configuration, [BlockProxy(typeof(Trampolines.NIDActionArity2V10))] Action<NSRunningApplication, NSError>? completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V10.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selOpenURL_Configuration_CompletionHandler_Handle, url.Handle, configuration.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selOpenURL_Configuration_CompletionHandler_Handle, url.Handle, configuration.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSRunningApplication> OpenUrlAsync(NSUrl url, NSWorkspaceOpenConfiguration configuration)
	{
		TaskCompletionSource<NSRunningApplication> tcs = new TaskCompletionSource<NSRunningApplication>();
		OpenUrl(url, configuration, delegate(NSRunningApplication arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("openURLs:withApplicationAtURL:configuration:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void OpenUrls(NSUrl[] urls, NSUrl applicationUrl, NSWorkspaceOpenConfiguration configuration, [BlockProxy(typeof(Trampolines.NIDActionArity2V10))] Action<NSRunningApplication, NSError>? completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (urls == null)
		{
			throw new ArgumentNullException("urls");
		}
		if (applicationUrl == null)
		{
			throw new ArgumentNullException("applicationUrl");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		NSArray nSArray = NSArray.FromNSObjects(urls);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V10.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selOpenURLs_WithApplicationAtURL_Configuration_CompletionHandler_Handle, nSArray.Handle, applicationUrl.Handle, configuration.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selOpenURLs_WithApplicationAtURL_Configuration_CompletionHandler_Handle, nSArray.Handle, applicationUrl.Handle, configuration.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSRunningApplication> OpenUrlsAsync(NSUrl[] urls, NSUrl applicationUrl, NSWorkspaceOpenConfiguration configuration)
	{
		TaskCompletionSource<NSRunningApplication> tcs = new TaskCompletionSource<NSRunningApplication>();
		OpenUrls(urls, applicationUrl, configuration, delegate(NSRunningApplication arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("performFileOperation:source:destination:files:tag:")]
	[ThreadSafe]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PerformFileOperation(NSString workspaceOperation, string source, string destination, string[] files, out nint tag)
	{
		if (workspaceOperation == null)
		{
			throw new ArgumentNullException("workspaceOperation");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (files == null)
		{
			throw new ArgumentNullException("files");
		}
		IntPtr arg = NSString.CreateNative(source);
		IntPtr arg2 = NSString.CreateNative(destination);
		NSArray nSArray = NSArray.FromStrings(files);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_out_nint(base.SuperHandle, selPerformFileOperation_Source_Destination_Files_Tag_Handle, workspaceOperation.Handle, arg, arg2, nSArray.Handle, out tag) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_out_nint(base.Handle, selPerformFileOperation_Source_Destination_Files_Tag_Handle, workspaceOperation.Handle, arg, arg2, nSArray.Handle, out tag));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray.Dispose();
		return result;
	}

	[Export("preferredFilenameExtensionForType:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PreferredFilenameExtension(string typeName)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPreferredFilenameExtensionForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPreferredFilenameExtensionForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("recycleURLs:completionHandler:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RecycleUrls(NSArray urls, [BlockProxy(typeof(Trampolines.NIDNSWorkspaceUrlHandler))] NSWorkspaceUrlHandler completionHandler)
	{
		if (urls == null)
		{
			throw new ArgumentNullException("urls");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSWorkspaceUrlHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRecycleURLs_CompletionHandler_Handle, urls.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRecycleURLs_CompletionHandler_Handle, urls.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("requestAuthorizationOfType:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RequestAuthorization(NSWorkspaceAuthorizationType type, [BlockProxy(typeof(Trampolines.NIDActionArity2V11))] Action<NSWorkspaceAuthorization, NSError> completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selRequestAuthorizationOfType_CompletionHandler_Handle, (long)type, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selRequestAuthorizationOfType_CompletionHandler_Handle, (long)type, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("selectFile:inFileViewerRootedAtPath:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectFile(string fullPath, string rootFullPath)
	{
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		if (rootFullPath == null)
		{
			throw new ArgumentNullException("rootFullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		IntPtr arg2 = NSString.CreateNative(rootFullPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSelectFile_InFileViewerRootedAtPath_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSelectFile_InFileViewerRootedAtPath_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setDesktopImageURL:forScreen:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetDesktopImageUrl(NSUrl url, NSScreen screen, NSDictionary options, NSError error)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selSetDesktopImageURL_ForScreen_Options_Error_Handle, url.Handle, screen.Handle, options.Handle, error.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetDesktopImageURL_ForScreen_Options_Error_Handle, url.Handle, screen.Handle, options.Handle, error.Handle);
	}

	[Export("setIcon:forFile:options:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetIconforFile(NSImage image, string fullPath, NSWorkspaceIconCreationOptions options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selSetIcon_ForFile_Options_Handle, image.Handle, arg, (ulong)options) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selSetIcon_ForFile_Options_Handle, image.Handle, arg, (ulong)options));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("showSearchResultsForQueryString:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowSearchResults(string queryString)
	{
		if (queryString == null)
		{
			throw new ArgumentNullException("queryString");
		}
		IntPtr arg = NSString.CreateNative(queryString);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowSearchResultsForQueryString_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShowSearchResultsForQueryString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("type:conformsToType:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TypeConformsTo(string firstTypeName, string secondTypeName)
	{
		if (firstTypeName == null)
		{
			throw new ArgumentNullException("firstTypeName");
		}
		if (secondTypeName == null)
		{
			throw new ArgumentNullException("secondTypeName");
		}
		IntPtr arg = NSString.CreateNative(firstTypeName);
		IntPtr arg2 = NSString.CreateNative(secondTypeName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selType_ConformsToType_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selType_ConformsToType_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("typeOfFile:error:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string TypeOfFile(string absoluteFilePath, out NSError outError)
	{
		if (absoluteFilePath == null)
		{
			throw new ArgumentNullException("absoluteFilePath");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(absoluteFilePath);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selTypeOfFile_Error_Handle, arg2, ref arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selTypeOfFile_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("unmountAndEjectDeviceAtPath:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UnmountAndEjectDevice(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnmountAndEjectDeviceAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selUnmountAndEjectDeviceAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("unmountAndEjectDeviceAtURL:error:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UnmountAndEjectDevice(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selUnmountAndEjectDeviceAtURL_Error_Handle, url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selUnmountAndEjectDeviceAtURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("URLForApplicationWithBundleIdentifier:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl UrlForApplication(string bundleIdentifier)
	{
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForApplicationWithBundleIdentifier_Handle, arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForApplicationWithBundleIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLForApplicationToOpenURL:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl UrlForApplication(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForApplicationToOpenURL_Handle, url.Handle));
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForApplicationToOpenURL_Handle, url.Handle));
	}

	[Export("openURLs:withAppBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifiers:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool _OpenUrls(NSUrl[] urls, string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor, string[]? identifiers)
	{
		if (urls == null)
		{
			throw new ArgumentNullException("urls");
		}
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		NSArray nSArray = NSArray.FromNSObjects(urls);
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		NSArray nSArray2 = ((identifiers == null) ? null : NSArray.FromStrings(identifiers));
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selOpenURLs_WithAppBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifiers_Handle, nSArray.Handle, arg, (ulong)options, descriptor.Handle, nSArray2?.Handle ?? IntPtr.Zero) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selOpenURLs_WithAppBundleIdentifier_Options_AdditionalEventParamDescriptor_LaunchIdentifiers_Handle, nSArray.Handle, arg, (ulong)options, descriptor.Handle, nSArray2?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		nSArray2?.Dispose();
		return result;
	}
}
