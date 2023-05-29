using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSWorkspace", true)]
public class NSWorkspace : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveWillPowerOff(EventHandler<NSNotificationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(WillPowerOffNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillSleep(EventHandler<NSNotificationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(WillSleepNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidWake(EventHandler<NSNotificationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidWakeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveScreensDidSleep(EventHandler<NSNotificationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(ScreensDidSleepNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveScreensDidWake(EventHandler<NSNotificationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(ScreensDidWakeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSessionDidBecomeActive(EventHandler<NSNotificationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(SessionDidBecomeActiveNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSessionDidResignActive(EventHandler<NSNotificationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(SessionDidResignActiveNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidRenameVolume(EventHandler<NSWorkspaceRenamedEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidRenameVolumeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceRenamedEventArgs(notification));
			});
		}

		public static NSObject ObserveDidMount(EventHandler<NSWorkspaceMountEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidMountNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceMountEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUnmount(EventHandler<NSWorkspaceMountEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidUnmountNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceMountEventArgs(notification));
			});
		}

		public static NSObject ObserveWillUnmount(EventHandler<NSWorkspaceMountEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(WillUnmountNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceMountEventArgs(notification));
			});
		}

		public static NSObject ObserveWillLaunchApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(WillLaunchApplication, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidLaunchApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidLaunchApplicationNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidTerminateApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidTerminateApplicationNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidHideApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidHideApplicationNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUnhideApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidUnhideApplicationNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidActivateApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidActivateApplicationNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidDeactivateApplication(EventHandler<NSWorkspaceApplicationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidDeactivateApplicationNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceApplicationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidPerformFileOperation(EventHandler<NSWorkspaceFileOperationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidPerformFileOperationNotification, delegate(NSNotification notification)
			{
				handler(null, new NSWorkspaceFileOperationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeFileLabels(EventHandler<NSNotificationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(DidChangeFileLabelsNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveActiveSpaceDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			return SharedWorkspace.NotificationCenter.AddObserver(ActiveSpaceDidChangeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selSharedWorkspaceHandle = Selector.GetHandle("sharedWorkspace");

	private static readonly IntPtr selNotificationCenterHandle = Selector.GetHandle("notificationCenter");

	private static readonly IntPtr selFileLabelsHandle = Selector.GetHandle("fileLabels");

	private static readonly IntPtr selFileLabelColorsHandle = Selector.GetHandle("fileLabelColors");

	private static readonly IntPtr selMountedLocalVolumePathsHandle = Selector.GetHandle("mountedLocalVolumePaths");

	private static readonly IntPtr selMountedRemovableMediaHandle = Selector.GetHandle("mountedRemovableMedia");

	private static readonly IntPtr selLaunchedApplicationsHandle = Selector.GetHandle("launchedApplications");

	private static readonly IntPtr selActiveApplicationHandle = Selector.GetHandle("activeApplication");

	private static readonly IntPtr selRunningApplicationsHandle = Selector.GetHandle("runningApplications");

	private static readonly IntPtr selFrontmostApplicationHandle = Selector.GetHandle("frontmostApplication");

	private static readonly IntPtr selMenuBarOwningApplicationHandle = Selector.GetHandle("menuBarOwningApplication");

	private static readonly IntPtr selOpenFile_Handle = Selector.GetHandle("openFile:");

	private static readonly IntPtr selOpenFileWithApplication_Handle = Selector.GetHandle("openFile:withApplication:");

	private static readonly IntPtr selOpenFileWithApplicationAndDeactivate_Handle = Selector.GetHandle("openFile:withApplication:andDeactivate:");

	private static readonly IntPtr selOpenFileFromImageAtInView_Handle = Selector.GetHandle("openFile:fromImage:at:inView:");

	private static readonly IntPtr selOpenURL_Handle = Selector.GetHandle("openURL:");

	private static readonly IntPtr selLaunchApplication_Handle = Selector.GetHandle("launchApplication:");

	private static readonly IntPtr selLaunchApplicationAtURLOptionsConfigurationError_Handle = Selector.GetHandle("launchApplicationAtURL:options:configuration:error:");

	private static readonly IntPtr selLaunchApplicationShowIconAutolaunch_Handle = Selector.GetHandle("launchApplication:showIcon:autolaunch:");

	private static readonly IntPtr selFullPathForApplication_Handle = Selector.GetHandle("fullPathForApplication:");

	private static readonly IntPtr selSelectFileInFileViewerRootedAtPath_Handle = Selector.GetHandle("selectFile:inFileViewerRootedAtPath:");

	private static readonly IntPtr selActivateFileViewerSelectingURLs_Handle = Selector.GetHandle("activateFileViewerSelectingURLs:");

	private static readonly IntPtr selShowSearchResultsForQueryString_Handle = Selector.GetHandle("showSearchResultsForQueryString:");

	private static readonly IntPtr selNoteFileSystemChanged_Handle = Selector.GetHandle("noteFileSystemChanged:");

	private static readonly IntPtr selGetInfoForFileApplicationType_Handle = Selector.GetHandle("getInfoForFile:application:type:");

	private static readonly IntPtr selIsFilePackageAtPath_Handle = Selector.GetHandle("isFilePackageAtPath:");

	private static readonly IntPtr selIconForFile_Handle = Selector.GetHandle("iconForFile:");

	private static readonly IntPtr selIconForFiles_Handle = Selector.GetHandle("iconForFiles:");

	private static readonly IntPtr selIconForFileType_Handle = Selector.GetHandle("iconForFileType:");

	private static readonly IntPtr selSetIconForFileOptions_Handle = Selector.GetHandle("setIcon:forFile:options:");

	private static readonly IntPtr selRecycleURLsCompletionHandler_Handle = Selector.GetHandle("recycleURLs:completionHandler:");

	private static readonly IntPtr selDuplicateURLsCompletionHandler_Handle = Selector.GetHandle("duplicateURLs:completionHandler:");

	private static readonly IntPtr selGetFileSystemInfoForPathIsRemovableIsWritableIsUnmountableDescriptionType_Handle = Selector.GetHandle("getFileSystemInfoForPath:isRemovable:isWritable:isUnmountable:description:type:");

	private static readonly IntPtr selPerformFileOperationSourceDestinationFilesTag_Handle = Selector.GetHandle("performFileOperation:source:destination:files:tag:");

	private static readonly IntPtr selUnmountAndEjectDeviceAtPath_Handle = Selector.GetHandle("unmountAndEjectDeviceAtPath:");

	private static readonly IntPtr selUnmountAndEjectDeviceAtURLError_Handle = Selector.GetHandle("unmountAndEjectDeviceAtURL:error:");

	private static readonly IntPtr selExtendPowerOffBy_Handle = Selector.GetHandle("extendPowerOffBy:");

	private static readonly IntPtr selHideOtherApplicationsHandle = Selector.GetHandle("hideOtherApplications");

	private static readonly IntPtr selURLForApplicationWithBundleIdentifier_Handle = Selector.GetHandle("URLForApplicationWithBundleIdentifier:");

	private static readonly IntPtr selURLForApplicationToOpenURL_Handle = Selector.GetHandle("URLForApplicationToOpenURL:");

	private static readonly IntPtr selAbsolutePathForAppBundleWithIdentifier_Handle = Selector.GetHandle("absolutePathForAppBundleWithIdentifier:");

	private static readonly IntPtr selLaunchAppWithBundleIdentifierOptionsAdditionalEventParamDescriptorLaunchIdentifier_Handle = Selector.GetHandle("launchAppWithBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifier:");

	private static readonly IntPtr selOpenURLsWithAppBundleIdentifierOptionsAdditionalEventParamDescriptorLaunchIdentifiers_Handle = Selector.GetHandle("openURLs:withAppBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifiers:");

	private static readonly IntPtr selTypeOfFileError_Handle = Selector.GetHandle("typeOfFile:error:");

	private static readonly IntPtr selLocalizedDescriptionForType_Handle = Selector.GetHandle("localizedDescriptionForType:");

	private static readonly IntPtr selPreferredFilenameExtensionForType_Handle = Selector.GetHandle("preferredFilenameExtensionForType:");

	private static readonly IntPtr selFilenameExtensionIsValidForType_Handle = Selector.GetHandle("filenameExtension:isValidForType:");

	private static readonly IntPtr selTypeConformsToType_Handle = Selector.GetHandle("type:conformsToType:");

	private static readonly IntPtr selSetDesktopImageURLForScreenOptionsError_Handle = Selector.GetHandle("setDesktopImageURL:forScreen:options:error:");

	private static readonly IntPtr selDesktopImageURLForScreen_Handle = Selector.GetHandle("desktopImageURLForScreen:");

	private static readonly IntPtr selDesktopImageOptionsForScreen_Handle = Selector.GetHandle("desktopImageOptionsForScreen:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSWorkspace");

	private static object __mt_SharedWorkspace_var_static;

	private object __mt_NotificationCenter_var;

	private object __mt_FileLabelColors_var;

	private object __mt_LaunchedApplications_var;

	private object __mt_ActiveApplication_var;

	private object __mt_RunningApplications_var;

	private object __mt_FrontmostApplication_var;

	private object __mt_MenuBarOwningApplication_var;

	private static NSString _WillPowerOffNotification;

	private static NSString _WillSleepNotification;

	private static NSString _DidWakeNotification;

	private static NSString _ScreensDidSleepNotification;

	private static NSString _ScreensDidWakeNotification;

	private static NSString _SessionDidBecomeActiveNotification;

	private static NSString _SessionDidResignActiveNotification;

	private static NSString _DidRenameVolumeNotification;

	private static NSString _DidMountNotification;

	private static NSString _DidUnmountNotification;

	private static NSString _WillUnmountNotification;

	private static NSString _WillLaunchApplication;

	private static NSString _DidLaunchApplicationNotification;

	private static NSString _DidTerminateApplicationNotification;

	private static NSString _DidHideApplicationNotification;

	private static NSString _DidUnhideApplicationNotification;

	private static NSString _DidActivateApplicationNotification;

	private static NSString _DidDeactivateApplicationNotification;

	private static NSString _DidPerformFileOperationNotification;

	private static NSString _DidChangeFileLabelsNotification;

	private static NSString _ActiveSpaceDidChangeNotification;

	private static NSString _OperationRecycle;

	private static NSString _OperationDuplicate;

	private static NSString _OperationMove;

	private static NSString _OperationCopy;

	private static NSString _OperationLink;

	private static NSString _OperationDestroy;

	public override IntPtr ClassHandle => class_ptr;

	[ThreadSafe]
	public static NSWorkspace SharedWorkspace
	{
		[Export("sharedWorkspace")]
		get
		{
			return (NSWorkspace)(__mt_SharedWorkspace_var_static = (NSWorkspace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedWorkspaceHandle)));
		}
	}

	public virtual NSNotificationCenter NotificationCenter
	{
		[Export("notificationCenter")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSNotificationCenter)(__mt_NotificationCenter_var = ((!IsDirectBinding) ? ((NSNotificationCenter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNotificationCenterHandle))) : ((NSNotificationCenter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNotificationCenterHandle)))));
		}
	}

	public virtual string[] FileLabels
	{
		[Export("fileLabels")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFileLabelsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileLabelsHandle));
		}
	}

	public virtual NSColor[] FileLabelColors
	{
		[Export("fileLabelColors")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor[])(__mt_FileLabelColors_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileLabelColorsHandle)) : NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileLabelColorsHandle))));
		}
	}

	public virtual string[] MountedLocalVolumePaths
	{
		[Export("mountedLocalVolumePaths")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMountedLocalVolumePathsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMountedLocalVolumePathsHandle));
		}
	}

	public virtual string[] MountedRemovableMedia
	{
		[Export("mountedRemovableMedia")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMountedRemovableMediaHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMountedRemovableMediaHandle));
		}
	}

	public virtual NSDictionary[] LaunchedApplications
	{
		[Export("launchedApplications")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary[])(__mt_LaunchedApplications_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLaunchedApplicationsHandle)) : NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selLaunchedApplicationsHandle))));
		}
	}

	public virtual NSDictionary ActiveApplication
	{
		[Export("activeApplication")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_ActiveApplication_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActiveApplicationHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selActiveApplicationHandle)))));
		}
	}

	[ThreadSafe]
	public virtual NSRunningApplication[] RunningApplications
	{
		[Export("runningApplications")]
		get
		{
			return (NSRunningApplication[])(__mt_RunningApplications_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSRunningApplication>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRunningApplicationsHandle)) : NSArray.ArrayFromHandle<NSRunningApplication>(Messaging.IntPtr_objc_msgSend(base.Handle, selRunningApplicationsHandle))));
		}
	}

	public virtual NSRunningApplication FrontmostApplication
	{
		[Export("frontmostApplication")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSRunningApplication)(__mt_FrontmostApplication_var = ((!IsDirectBinding) ? ((NSRunningApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrontmostApplicationHandle))) : ((NSRunningApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFrontmostApplicationHandle)))));
		}
	}

	public virtual NSRunningApplication MenuBarOwningApplication
	{
		[Export("menuBarOwningApplication")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSRunningApplication)(__mt_MenuBarOwningApplication_var = ((!IsDirectBinding) ? ((NSRunningApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuBarOwningApplicationHandle))) : ((NSRunningApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuBarOwningApplicationHandle)))));
		}
	}

	[Field("NSWorkspaceWillPowerOffNotification", "AppKit")]
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

	[Field("NSWorkspaceDidWakeNotification", "AppKit")]
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

	[Field("NSWorkspaceScreensDidSleepNotification", "AppKit")]
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

	[Field("NSWorkspaceDidRenameVolumeNotification", "AppKit")]
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

	[Field("NSWorkspaceDidMountNotification", "AppKit")]
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

	[Field("NSWorkspaceDidUnmountNotification", "AppKit")]
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

	[Field("NSWorkspaceWillUnmountNotification", "AppKit")]
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

	[Field("NSWorkspaceWillLaunchApplicationNotification", "AppKit")]
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

	[Field("NSWorkspaceDidLaunchApplicationNotification", "AppKit")]
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

	[Field("NSWorkspaceDidTerminateApplicationNotification", "AppKit")]
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

	[Field("NSWorkspaceDidHideApplicationNotification", "AppKit")]
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

	[Field("NSWorkspaceDidUnhideApplicationNotification", "AppKit")]
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

	[Field("NSWorkspaceDidActivateApplicationNotification", "AppKit")]
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

	[Field("NSWorkspaceDidDeactivateApplicationNotification", "AppKit")]
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

	[Field("NSWorkspaceDidPerformFileOperationNotification", "AppKit")]
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

	[Field("NSWorkspaceDidChangeFileLabelsNotification", "AppKit")]
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

	[Field("NSWorkspaceActiveSpaceDidChangeNotification", "AppKit")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSWorkspace()
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
	public NSWorkspace(NSCoder coder)
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
	public NSWorkspace(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSWorkspace(IntPtr handle)
		: base(handle)
	{
	}

	[Export("openFile:")]
	public virtual bool OpenFile(string fullPath)
	{
		NSApplication.EnsureUIThread();
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpenFile_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selOpenFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("openFile:withApplication:")]
	public virtual bool OpenFile(string fullPath, string appName)
	{
		NSApplication.EnsureUIThread();
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		if (appName == null)
		{
			throw new ArgumentNullException("appName");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		IntPtr arg2 = NSString.CreateNative(appName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selOpenFileWithApplication_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selOpenFileWithApplication_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("openFile:withApplication:andDeactivate:")]
	public virtual bool OpenFile(string fullPath, string appName, bool deactivate)
	{
		NSApplication.EnsureUIThread();
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		if (appName == null)
		{
			throw new ArgumentNullException("appName");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		IntPtr arg2 = NSString.CreateNative(appName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selOpenFileWithApplicationAndDeactivate_Handle, arg, arg2, deactivate) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selOpenFileWithApplicationAndDeactivate_Handle, arg, arg2, deactivate));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("openFile:fromImage:at:inView:")]
	public virtual bool OpenFile(string fullPath, NSImage anImage, CGPoint point, NSView aView)
	{
		NSApplication.EnsureUIThread();
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_CGPoint_IntPtr(base.SuperHandle, selOpenFileFromImageAtInView_Handle, arg, anImage.Handle, point, aView.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr(base.Handle, selOpenFileFromImageAtInView_Handle, arg, anImage.Handle, point, aView.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("openURL:")]
	public virtual bool OpenUrl(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selOpenURL_Handle, url.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpenURL_Handle, url.Handle);
	}

	[Export("launchApplication:")]
	public virtual bool LaunchApplication(string appName)
	{
		NSApplication.EnsureUIThread();
		if (appName == null)
		{
			throw new ArgumentNullException("appName");
		}
		IntPtr arg = NSString.CreateNative(appName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLaunchApplication_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLaunchApplication_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("launchApplicationAtURL:options:configuration:error:")]
	public virtual NSRunningApplication LaunchApplication(NSUrl url, NSWorkspaceLaunchOptions options, NSDictionary configuration, out NSError error)
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSRunningApplication result = ((!IsDirectBinding) ? ((NSRunningApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selLaunchApplicationAtURLOptionsConfigurationError_Handle, url.Handle, (ulong)options, configuration.Handle, intPtr))) : ((NSRunningApplication)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selLaunchApplicationAtURLOptionsConfigurationError_Handle, url.Handle, (ulong)options, configuration.Handle, intPtr))));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("launchApplication:showIcon:autolaunch:")]
	public virtual bool LaunchApplication(string appName, bool showIcon, bool autolaunch)
	{
		NSApplication.EnsureUIThread();
		if (appName == null)
		{
			throw new ArgumentNullException("appName");
		}
		IntPtr arg = NSString.CreateNative(appName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_bool(base.SuperHandle, selLaunchApplicationShowIconAutolaunch_Handle, arg, showIcon, autolaunch) : Messaging.bool_objc_msgSend_IntPtr_bool_bool(base.Handle, selLaunchApplicationShowIconAutolaunch_Handle, arg, showIcon, autolaunch));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fullPathForApplication:")]
	public virtual string FullPathForApplication(string appName)
	{
		NSApplication.EnsureUIThread();
		if (appName == null)
		{
			throw new ArgumentNullException("appName");
		}
		IntPtr arg = NSString.CreateNative(appName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFullPathForApplication_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFullPathForApplication_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("selectFile:inFileViewerRootedAtPath:")]
	public virtual bool SelectFile(string fullPath, string rootFullPath)
	{
		NSApplication.EnsureUIThread();
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSelectFileInFileViewerRootedAtPath_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSelectFileInFileViewerRootedAtPath_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("activateFileViewerSelectingURLs:")]
	public virtual void ActivateFileViewer(NSUrl[] fileUrls)
	{
		NSApplication.EnsureUIThread();
		if (fileUrls == null)
		{
			throw new ArgumentNullException("fileUrls");
		}
		NSArray nSArray = NSArray.FromNSObjects(fileUrls);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selActivateFileViewerSelectingURLs_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selActivateFileViewerSelectingURLs_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("showSearchResultsForQueryString:")]
	public virtual bool ShowSearchResults(string queryString)
	{
		NSApplication.EnsureUIThread();
		if (queryString == null)
		{
			throw new ArgumentNullException("queryString");
		}
		IntPtr arg = NSString.CreateNative(queryString);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowSearchResultsForQueryString_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShowSearchResultsForQueryString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("noteFileSystemChanged:")]
	public virtual void NoteFileSystemChanged(string path)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoteFileSystemChanged_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoteFileSystemChanged_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("getInfoForFile:application:type:")]
	public virtual bool GetInfo(string fullPath, out string appName, out string fileType)
	{
		NSApplication.EnsureUIThread();
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr intPtr2 = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr2, 0);
		IntPtr arg = NSString.CreateNative(fullPath);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGetInfoForFileApplicationType_Handle, arg, intPtr, intPtr2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selGetInfoForFileApplicationType_Handle, arg, intPtr, intPtr2));
		NSString.ReleaseNative(arg);
		IntPtr intPtr3 = Marshal.ReadIntPtr(intPtr);
		appName = ((intPtr3 != IntPtr.Zero) ? NSString.FromHandle(intPtr3) : null);
		Marshal.FreeHGlobal(intPtr);
		IntPtr intPtr4 = Marshal.ReadIntPtr(intPtr2);
		fileType = ((intPtr4 != IntPtr.Zero) ? NSString.FromHandle(intPtr4) : null);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	[Export("isFilePackageAtPath:")]
	public virtual bool IsFilePackage(string fullPath)
	{
		NSApplication.EnsureUIThread();
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsFilePackageAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsFilePackageAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("iconForFile:")]
	public virtual NSImage IconForFile(string fullPath)
	{
		NSApplication.EnsureUIThread();
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		NSImage result = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIconForFile_Handle, arg))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIconForFile_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("iconForFiles:")]
	public virtual NSImage IconForFiles(string[] fullPaths)
	{
		NSApplication.EnsureUIThread();
		if (fullPaths == null)
		{
			throw new ArgumentNullException("fullPaths");
		}
		NSArray nSArray = NSArray.FromStrings(fullPaths);
		NSImage result = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIconForFiles_Handle, nSArray.Handle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIconForFiles_Handle, nSArray.Handle))));
		nSArray.Dispose();
		return result;
	}

	[Export("iconForFileType:")]
	public virtual NSImage IconForFileType(string fileType)
	{
		NSApplication.EnsureUIThread();
		if (fileType == null)
		{
			throw new ArgumentNullException("fileType");
		}
		IntPtr arg = NSString.CreateNative(fileType);
		NSImage result = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIconForFileType_Handle, arg))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIconForFileType_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setIcon:forFile:options:")]
	public virtual bool SetIconforFile(NSImage image, string fullPath, NSWorkspaceIconCreationOptions options)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr arg = NSString.CreateNative(fullPath);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selSetIconForFileOptions_Handle, image.Handle, arg, (ulong)options) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selSetIconForFileOptions_Handle, image.Handle, arg, (ulong)options));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("recycleURLs:completionHandler:")]
	public unsafe virtual void RecycleUrls(NSArray urls, NSWorkspaceUrlHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
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
		blockLiteral.SetupBlock(Trampolines.SDNSWorkspaceUrlHandler.Handler, completionHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRecycleURLsCompletionHandler_Handle, urls.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRecycleURLsCompletionHandler_Handle, urls.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("duplicateURLs:completionHandler:")]
	public unsafe virtual void DuplicateUrls(NSArray urls, NSWorkspaceUrlHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
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
		blockLiteral.SetupBlock(Trampolines.SDNSWorkspaceUrlHandler.Handler, completionHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDuplicateURLsCompletionHandler_Handle, urls.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDuplicateURLsCompletionHandler_Handle, urls.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("getFileSystemInfoForPath:isRemovable:isWritable:isUnmountable:description:type:")]
	public virtual bool GetFileSystemInfo(string fullPath, out bool removableFlag, out bool writableFlag, out bool unmountableFlag, out string description, out string fileSystemType)
	{
		NSApplication.EnsureUIThread();
		if (fullPath == null)
		{
			throw new ArgumentNullException("fullPath");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr intPtr2 = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr2, 0);
		IntPtr arg = NSString.CreateNative(fullPath);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_out_Boolean_out_Boolean_out_Boolean_IntPtr_IntPtr(base.SuperHandle, selGetFileSystemInfoForPathIsRemovableIsWritableIsUnmountableDescriptionType_Handle, arg, out removableFlag, out writableFlag, out unmountableFlag, intPtr, intPtr2) : Messaging.bool_objc_msgSend_IntPtr_out_Boolean_out_Boolean_out_Boolean_IntPtr_IntPtr(base.Handle, selGetFileSystemInfoForPathIsRemovableIsWritableIsUnmountableDescriptionType_Handle, arg, out removableFlag, out writableFlag, out unmountableFlag, intPtr, intPtr2));
		NSString.ReleaseNative(arg);
		IntPtr intPtr3 = Marshal.ReadIntPtr(intPtr);
		description = ((intPtr3 != IntPtr.Zero) ? NSString.FromHandle(intPtr3) : null);
		Marshal.FreeHGlobal(intPtr);
		IntPtr intPtr4 = Marshal.ReadIntPtr(intPtr2);
		fileSystemType = ((intPtr4 != IntPtr.Zero) ? NSString.FromHandle(intPtr4) : null);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	[Export("performFileOperation:source:destination:files:tag:")]
	public virtual bool PerformFileOperation(NSString workspaceOperation, string source, string destination, string[] files, out long tag)
	{
		NSApplication.EnsureUIThread();
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_out_Int64(base.SuperHandle, selPerformFileOperationSourceDestinationFilesTag_Handle, workspaceOperation.Handle, arg, arg2, nSArray.Handle, out tag) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_out_Int64(base.Handle, selPerformFileOperationSourceDestinationFilesTag_Handle, workspaceOperation.Handle, arg, arg2, nSArray.Handle, out tag));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray.Dispose();
		return result;
	}

	[Export("unmountAndEjectDeviceAtPath:")]
	public virtual bool UnmountAndEjectDevice(string path)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnmountAndEjectDeviceAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selUnmountAndEjectDeviceAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("unmountAndEjectDeviceAtURL:error:")]
	public virtual bool UnmountAndEjectDevice(NSUrl url, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUnmountAndEjectDeviceAtURLError_Handle, url.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selUnmountAndEjectDeviceAtURLError_Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("extendPowerOffBy:")]
	public virtual long ExtendPowerOffBy(long requested)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selExtendPowerOffBy_Handle, requested);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selExtendPowerOffBy_Handle, requested);
	}

	[Export("hideOtherApplications")]
	public virtual void HideOtherApplications()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selHideOtherApplicationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selHideOtherApplicationsHandle);
		}
	}

	[Export("URLForApplicationWithBundleIdentifier:")]
	public virtual NSUrl UrlForApplication(string bundleIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		NSUrl result = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForApplicationWithBundleIdentifier_Handle, arg))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForApplicationWithBundleIdentifier_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLForApplicationToOpenURL:")]
	public virtual NSUrl UrlForApplication(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForApplicationToOpenURL_Handle, url.Handle));
		}
		return (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForApplicationToOpenURL_Handle, url.Handle));
	}

	[Export("absolutePathForAppBundleWithIdentifier:")]
	public virtual string AbsolutePathForAppBundle(string bundleIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAbsolutePathForAppBundleWithIdentifier_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAbsolutePathForAppBundleWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("launchAppWithBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifier:")]
	public virtual bool LaunchApp(string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor, IntPtr identifier)
	{
		NSApplication.EnsureUIThread();
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selLaunchAppWithBundleIdentifierOptionsAdditionalEventParamDescriptorLaunchIdentifier_Handle, arg, (ulong)options, descriptor.Handle, identifier) : Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selLaunchAppWithBundleIdentifierOptionsAdditionalEventParamDescriptorLaunchIdentifier_Handle, arg, (ulong)options, descriptor.Handle, identifier));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("openURLs:withAppBundleIdentifier:options:additionalEventParamDescriptor:launchIdentifiers:")]
	public virtual bool OpenUrls(NSUrl[] urls, string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor, string[] identifiers)
	{
		NSApplication.EnsureUIThread();
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
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(urls);
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		NSArray nSArray2 = NSArray.FromStrings(identifiers);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selOpenURLsWithAppBundleIdentifierOptionsAdditionalEventParamDescriptorLaunchIdentifiers_Handle, nSArray.Handle, arg, (ulong)options, descriptor.Handle, nSArray2.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selOpenURLsWithAppBundleIdentifierOptionsAdditionalEventParamDescriptorLaunchIdentifiers_Handle, nSArray.Handle, arg, (ulong)options, descriptor.Handle, nSArray2.Handle));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		nSArray2.Dispose();
		return result;
	}

	[Export("typeOfFile:error:")]
	public virtual string TypeOfFile(string absoluteFilePath, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (absoluteFilePath == null)
		{
			throw new ArgumentNullException("absoluteFilePath");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(absoluteFilePath);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTypeOfFileError_Handle, arg, intPtr)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selTypeOfFileError_Handle, arg, intPtr)));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("localizedDescriptionForType:")]
	public virtual string LocalizedDescription(string typeName)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocalizedDescriptionForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLocalizedDescriptionForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("preferredFilenameExtensionForType:")]
	public virtual string PreferredFilenameExtension(string typeName)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPreferredFilenameExtensionForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPreferredFilenameExtensionForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("filenameExtension:isValidForType:")]
	public virtual bool IsFilenameExtensionValid(string filenameExtension, string typeName)
	{
		NSApplication.EnsureUIThread();
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFilenameExtensionIsValidForType_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selFilenameExtensionIsValidForType_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("type:conformsToType:")]
	public virtual bool TypeConformsTo(string firstTypeName, string secondTypeName)
	{
		NSApplication.EnsureUIThread();
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTypeConformsToType_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTypeConformsToType_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setDesktopImageURL:forScreen:options:error:")]
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
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selSetDesktopImageURLForScreenOptionsError_Handle, url.Handle, screen.Handle, options.Handle, error.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetDesktopImageURLForScreenOptionsError_Handle, url.Handle, screen.Handle, options.Handle, error.Handle);
	}

	[Export("desktopImageURLForScreen:")]
	public virtual NSUrl DesktopImageUrl(NSScreen screen)
	{
		NSApplication.EnsureUIThread();
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		if (IsDirectBinding)
		{
			return (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDesktopImageURLForScreen_Handle, screen.Handle));
		}
		return (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDesktopImageURLForScreen_Handle, screen.Handle));
	}

	[Export("desktopImageOptionsForScreen:")]
	public virtual NSDictionary DesktopImageOptions(NSScreen screen)
	{
		NSApplication.EnsureUIThread();
		if (screen == null)
		{
			throw new ArgumentNullException("screen");
		}
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDesktopImageOptionsForScreen_Handle, screen.Handle));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDesktopImageOptionsForScreen_Handle, screen.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_NotificationCenter_var = null;
			__mt_FileLabelColors_var = null;
			__mt_LaunchedApplications_var = null;
			__mt_ActiveApplication_var = null;
			__mt_RunningApplications_var = null;
			__mt_FrontmostApplication_var = null;
			__mt_MenuBarOwningApplication_var = null;
		}
	}
}
