using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileManager", true)]
public class NSFileManager : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveUbiquityIdentityDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UbiquityIdentityDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveUbiquityIdentityDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(UbiquityIdentityDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForDirectory_InDomain_AppropriateForURL_Create_Error_ = "URLForDirectory:inDomain:appropriateForURL:create:error:";

	private static readonly IntPtr selURLForDirectory_InDomain_AppropriateForURL_Create_Error_Handle = Selector.GetHandle("URLForDirectory:inDomain:appropriateForURL:create:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForPublishingUbiquitousItemAtURL_ExpirationDate_Error_ = "URLForPublishingUbiquitousItemAtURL:expirationDate:error:";

	private static readonly IntPtr selURLForPublishingUbiquitousItemAtURL_ExpirationDate_Error_Handle = Selector.GetHandle("URLForPublishingUbiquitousItemAtURL:expirationDate:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLForUbiquityContainerIdentifier_ = "URLForUbiquityContainerIdentifier:";

	private static readonly IntPtr selURLForUbiquityContainerIdentifier_Handle = Selector.GetHandle("URLForUbiquityContainerIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLsForDirectory_InDomains_ = "URLsForDirectory:inDomains:";

	private static readonly IntPtr selURLsForDirectory_InDomains_Handle = Selector.GetHandle("URLsForDirectory:inDomains:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributesOfFileSystemForPath_Error_ = "attributesOfFileSystemForPath:error:";

	private static readonly IntPtr selAttributesOfFileSystemForPath_Error_Handle = Selector.GetHandle("attributesOfFileSystemForPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributesOfItemAtPath_Error_ = "attributesOfItemAtPath:error:";

	private static readonly IntPtr selAttributesOfItemAtPath_Error_Handle = Selector.GetHandle("attributesOfItemAtPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeCurrentDirectoryPath_ = "changeCurrentDirectoryPath:";

	private static readonly IntPtr selChangeCurrentDirectoryPath_Handle = Selector.GetHandle("changeCurrentDirectoryPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentsToDisplayForPath_ = "componentsToDisplayForPath:";

	private static readonly IntPtr selComponentsToDisplayForPath_Handle = Selector.GetHandle("componentsToDisplayForPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainerURLForSecurityApplicationGroupIdentifier_ = "containerURLForSecurityApplicationGroupIdentifier:";

	private static readonly IntPtr selContainerURLForSecurityApplicationGroupIdentifier_Handle = Selector.GetHandle("containerURLForSecurityApplicationGroupIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsAtPath_ = "contentsAtPath:";

	private static readonly IntPtr selContentsAtPath_Handle = Selector.GetHandle("contentsAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsEqualAtPath_AndPath_ = "contentsEqualAtPath:andPath:";

	private static readonly IntPtr selContentsEqualAtPath_AndPath_Handle = Selector.GetHandle("contentsEqualAtPath:andPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsOfDirectoryAtPath_Error_ = "contentsOfDirectoryAtPath:error:";

	private static readonly IntPtr selContentsOfDirectoryAtPath_Error_Handle = Selector.GetHandle("contentsOfDirectoryAtPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentsOfDirectoryAtURL_IncludingPropertiesForKeys_Options_Error_ = "contentsOfDirectoryAtURL:includingPropertiesForKeys:options:error:";

	private static readonly IntPtr selContentsOfDirectoryAtURL_IncludingPropertiesForKeys_Options_Error_Handle = Selector.GetHandle("contentsOfDirectoryAtURL:includingPropertiesForKeys:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyItemAtPath_ToPath_Error_ = "copyItemAtPath:toPath:error:";

	private static readonly IntPtr selCopyItemAtPath_ToPath_Error_Handle = Selector.GetHandle("copyItemAtPath:toPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyItemAtURL_ToURL_Error_ = "copyItemAtURL:toURL:error:";

	private static readonly IntPtr selCopyItemAtURL_ToURL_Error_Handle = Selector.GetHandle("copyItemAtURL:toURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateDirectoryAtPath_WithIntermediateDirectories_Attributes_Error_ = "createDirectoryAtPath:withIntermediateDirectories:attributes:error:";

	private static readonly IntPtr selCreateDirectoryAtPath_WithIntermediateDirectories_Attributes_Error_Handle = Selector.GetHandle("createDirectoryAtPath:withIntermediateDirectories:attributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateDirectoryAtURL_WithIntermediateDirectories_Attributes_Error_ = "createDirectoryAtURL:withIntermediateDirectories:attributes:error:";

	private static readonly IntPtr selCreateDirectoryAtURL_WithIntermediateDirectories_Attributes_Error_Handle = Selector.GetHandle("createDirectoryAtURL:withIntermediateDirectories:attributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateFileAtPath_Contents_Attributes_ = "createFileAtPath:contents:attributes:";

	private static readonly IntPtr selCreateFileAtPath_Contents_Attributes_Handle = Selector.GetHandle("createFileAtPath:contents:attributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateSymbolicLinkAtPath_WithDestinationPath_Error_ = "createSymbolicLinkAtPath:withDestinationPath:error:";

	private static readonly IntPtr selCreateSymbolicLinkAtPath_WithDestinationPath_Error_Handle = Selector.GetHandle("createSymbolicLinkAtPath:withDestinationPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateSymbolicLinkAtURL_WithDestinationURL_Error_ = "createSymbolicLinkAtURL:withDestinationURL:error:";

	private static readonly IntPtr selCreateSymbolicLinkAtURL_WithDestinationURL_Error_Handle = Selector.GetHandle("createSymbolicLinkAtURL:withDestinationURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDirectoryPath = "currentDirectoryPath";

	private static readonly IntPtr selCurrentDirectoryPathHandle = Selector.GetHandle("currentDirectoryPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultManager = "defaultManager";

	private static readonly IntPtr selDefaultManagerHandle = Selector.GetHandle("defaultManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationOfSymbolicLinkAtPath_Error_ = "destinationOfSymbolicLinkAtPath:error:";

	private static readonly IntPtr selDestinationOfSymbolicLinkAtPath_Error_Handle = Selector.GetHandle("destinationOfSymbolicLinkAtPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayNameAtPath_ = "displayNameAtPath:";

	private static readonly IntPtr selDisplayNameAtPath_Handle = Selector.GetHandle("displayNameAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumeratorAtPath_ = "enumeratorAtPath:";

	private static readonly IntPtr selEnumeratorAtPath_Handle = Selector.GetHandle("enumeratorAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumeratorAtURL_IncludingPropertiesForKeys_Options_ErrorHandler_ = "enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:";

	private static readonly IntPtr selEnumeratorAtURL_IncludingPropertiesForKeys_Options_ErrorHandler_Handle = Selector.GetHandle("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvictUbiquitousItemAtURL_Error_ = "evictUbiquitousItemAtURL:error:";

	private static readonly IntPtr selEvictUbiquitousItemAtURL_Error_Handle = Selector.GetHandle("evictUbiquitousItemAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileExistsAtPath_ = "fileExistsAtPath:";

	private static readonly IntPtr selFileExistsAtPath_Handle = Selector.GetHandle("fileExistsAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileExistsAtPath_IsDirectory_ = "fileExistsAtPath:isDirectory:";

	private static readonly IntPtr selFileExistsAtPath_IsDirectory_Handle = Selector.GetHandle("fileExistsAtPath:isDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileManagerWithAuthorization_ = "fileManagerWithAuthorization:";

	private static readonly IntPtr selFileManagerWithAuthorization_Handle = Selector.GetHandle("fileManagerWithAuthorization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFileProviderServicesForItemAtURL_CompletionHandler_ = "getFileProviderServicesForItemAtURL:completionHandler:";

	private static readonly IntPtr selGetFileProviderServicesForItemAtURL_CompletionHandler_Handle = Selector.GetHandle("getFileProviderServicesForItemAtURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetRelationship_OfDirectory_InDomain_ToItemAtURL_Error_ = "getRelationship:ofDirectory:inDomain:toItemAtURL:error:";

	private static readonly IntPtr selGetRelationship_OfDirectory_InDomain_ToItemAtURL_Error_Handle = Selector.GetHandle("getRelationship:ofDirectory:inDomain:toItemAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetRelationship_OfDirectoryAtURL_ToItemAtURL_Error_ = "getRelationship:ofDirectoryAtURL:toItemAtURL:error:";

	private static readonly IntPtr selGetRelationship_OfDirectoryAtURL_ToItemAtURL_Error_Handle = Selector.GetHandle("getRelationship:ofDirectoryAtURL:toItemAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDeletableFileAtPath_ = "isDeletableFileAtPath:";

	private static readonly IntPtr selIsDeletableFileAtPath_Handle = Selector.GetHandle("isDeletableFileAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExecutableFileAtPath_ = "isExecutableFileAtPath:";

	private static readonly IntPtr selIsExecutableFileAtPath_Handle = Selector.GetHandle("isExecutableFileAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsReadableFileAtPath_ = "isReadableFileAtPath:";

	private static readonly IntPtr selIsReadableFileAtPath_Handle = Selector.GetHandle("isReadableFileAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUbiquitousItemAtURL_ = "isUbiquitousItemAtURL:";

	private static readonly IntPtr selIsUbiquitousItemAtURL_Handle = Selector.GetHandle("isUbiquitousItemAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsWritableFileAtPath_ = "isWritableFileAtPath:";

	private static readonly IntPtr selIsWritableFileAtPath_Handle = Selector.GetHandle("isWritableFileAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinkItemAtPath_ToPath_Error_ = "linkItemAtPath:toPath:error:";

	private static readonly IntPtr selLinkItemAtPath_ToPath_Error_Handle = Selector.GetHandle("linkItemAtPath:toPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinkItemAtURL_ToURL_Error_ = "linkItemAtURL:toURL:error:";

	private static readonly IntPtr selLinkItemAtURL_ToURL_Error_Handle = Selector.GetHandle("linkItemAtURL:toURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMountedVolumeURLsIncludingResourceValuesForKeys_Options_ = "mountedVolumeURLsIncludingResourceValuesForKeys:options:";

	private static readonly IntPtr selMountedVolumeURLsIncludingResourceValuesForKeys_Options_Handle = Selector.GetHandle("mountedVolumeURLsIncludingResourceValuesForKeys:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveItemAtPath_ToPath_Error_ = "moveItemAtPath:toPath:error:";

	private static readonly IntPtr selMoveItemAtPath_ToPath_Error_Handle = Selector.GetHandle("moveItemAtPath:toPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveItemAtURL_ToURL_Error_ = "moveItemAtURL:toURL:error:";

	private static readonly IntPtr selMoveItemAtURL_ToURL_Error_Handle = Selector.GetHandle("moveItemAtURL:toURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemAtPath_Error_ = "removeItemAtPath:error:";

	private static readonly IntPtr selRemoveItemAtPath_Error_Handle = Selector.GetHandle("removeItemAtPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemAtURL_Error_ = "removeItemAtURL:error:";

	private static readonly IntPtr selRemoveItemAtURL_Error_Handle = Selector.GetHandle("removeItemAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceItemAtURL_WithItemAtURL_BackupItemName_Options_ResultingItemURL_Error_ = "replaceItemAtURL:withItemAtURL:backupItemName:options:resultingItemURL:error:";

	private static readonly IntPtr selReplaceItemAtURL_WithItemAtURL_BackupItemName_Options_ResultingItemURL_Error_Handle = Selector.GetHandle("replaceItemAtURL:withItemAtURL:backupItemName:options:resultingItemURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributes_OfItemAtPath_Error_ = "setAttributes:ofItemAtPath:error:";

	private static readonly IntPtr selSetAttributes_OfItemAtPath_Error_Handle = Selector.GetHandle("setAttributes:ofItemAtPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUbiquitous_ItemAtURL_DestinationURL_Error_ = "setUbiquitous:itemAtURL:destinationURL:error:";

	private static readonly IntPtr selSetUbiquitous_ItemAtURL_DestinationURL_Error_Handle = Selector.GetHandle("setUbiquitous:itemAtURL:destinationURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDownloadingUbiquitousItemAtURL_Error_ = "startDownloadingUbiquitousItemAtURL:error:";

	private static readonly IntPtr selStartDownloadingUbiquitousItemAtURL_Error_Handle = Selector.GetHandle("startDownloadingUbiquitousItemAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubpathsAtPath_ = "subpathsAtPath:";

	private static readonly IntPtr selSubpathsAtPath_Handle = Selector.GetHandle("subpathsAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubpathsOfDirectoryAtPath_Error_ = "subpathsOfDirectoryAtPath:error:";

	private static readonly IntPtr selSubpathsOfDirectoryAtPath_Error_Handle = Selector.GetHandle("subpathsOfDirectoryAtPath:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrashItemAtURL_ResultingItemURL_Error_ = "trashItemAtURL:resultingItemURL:error:";

	private static readonly IntPtr selTrashItemAtURL_ResultingItemURL_Error_Handle = Selector.GetHandle("trashItemAtURL:resultingItemURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUbiquityIdentityToken = "ubiquityIdentityToken";

	private static readonly IntPtr selUbiquityIdentityTokenHandle = Selector.GetHandle("ubiquityIdentityToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnmountVolumeAtURL_Options_CompletionHandler_ = "unmountVolumeAtURL:options:completionHandler:";

	private static readonly IntPtr selUnmountVolumeAtURL_Options_CompletionHandler_Handle = Selector.GetHandle("unmountVolumeAtURL:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFileManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppendOnly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Busy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreationDate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeviceIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtensionHidden;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GroupOwnerAccountID;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GroupOwnerAccountName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HfsCreatorCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HfsTypeCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Immutable;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModificationDate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFileType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OwnerAccountID;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OwnerAccountName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PosixPermissions;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReferenceCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Size;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemFileNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemFreeNodes;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemFreeSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemNodes;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeBlockSpecial;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeCharacterSpecial;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeDirectory;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeRegular;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeSocket;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeSymbolicLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeUnknown;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquityIdentityDidChangeNotification;

	public static string UserName
	{
		get
		{
			using NSString nSString = Runtime.GetNSObject<NSString>(NSUserName());
			return nSString.ToString();
		}
	}

	public static string FullUserName
	{
		get
		{
			using NSString nSString = Runtime.GetNSObject<NSString>(NSFullUserName());
			return nSString.ToString();
		}
	}

	public static string HomeDirectory
	{
		get
		{
			using NSString nSString = Runtime.GetNSObject<NSString>(NSHomeDirectory());
			return nSString.ToString();
		}
	}

	public static string TemporaryDirectory
	{
		get
		{
			using NSString nSString = Runtime.GetNSObject<NSString>(NSTemporaryDirectory());
			return nSString.ToString();
		}
	}

	public string CurrentDirectory
	{
		get
		{
			return GetCurrentDirectory();
		}
		set
		{
			ChangeCurrentDirectory(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileManager DefaultManager
	{
		[Export("defaultManager", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSFileManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSFileManagerDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSFileManagerDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject UbiquityIdentityToken
	{
		[Export("ubiquityIdentityToken")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUbiquityIdentityTokenHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUbiquityIdentityTokenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("NSFileAppendOnly", "Foundation")]
	public static NSString AppendOnly
	{
		get
		{
			if (_AppendOnly == null)
			{
				_AppendOnly = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileAppendOnly");
			}
			return _AppendOnly;
		}
	}

	[Field("NSFileBusy", "Foundation")]
	public static NSString Busy
	{
		get
		{
			if (_Busy == null)
			{
				_Busy = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileBusy");
			}
			return _Busy;
		}
	}

	[Field("NSFileCreationDate", "Foundation")]
	public static NSString CreationDate
	{
		get
		{
			if (_CreationDate == null)
			{
				_CreationDate = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileCreationDate");
			}
			return _CreationDate;
		}
	}

	[Field("NSFileDeviceIdentifier", "Foundation")]
	public static NSString DeviceIdentifier
	{
		get
		{
			if (_DeviceIdentifier == null)
			{
				_DeviceIdentifier = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileDeviceIdentifier");
			}
			return _DeviceIdentifier;
		}
	}

	[Field("NSFileExtensionHidden", "Foundation")]
	public static NSString ExtensionHidden
	{
		get
		{
			if (_ExtensionHidden == null)
			{
				_ExtensionHidden = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileExtensionHidden");
			}
			return _ExtensionHidden;
		}
	}

	[Field("NSFileGroupOwnerAccountID", "Foundation")]
	public static NSString GroupOwnerAccountID
	{
		get
		{
			if (_GroupOwnerAccountID == null)
			{
				_GroupOwnerAccountID = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileGroupOwnerAccountID");
			}
			return _GroupOwnerAccountID;
		}
	}

	[Field("NSFileGroupOwnerAccountName", "Foundation")]
	public static NSString GroupOwnerAccountName
	{
		get
		{
			if (_GroupOwnerAccountName == null)
			{
				_GroupOwnerAccountName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileGroupOwnerAccountName");
			}
			return _GroupOwnerAccountName;
		}
	}

	[Field("NSFileHFSCreatorCode", "Foundation")]
	public static NSString HfsCreatorCode
	{
		get
		{
			if (_HfsCreatorCode == null)
			{
				_HfsCreatorCode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileHFSCreatorCode");
			}
			return _HfsCreatorCode;
		}
	}

	[Field("NSFileHFSTypeCode", "Foundation")]
	public static NSString HfsTypeCode
	{
		get
		{
			if (_HfsTypeCode == null)
			{
				_HfsTypeCode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileHFSTypeCode");
			}
			return _HfsTypeCode;
		}
	}

	[Field("NSFileImmutable", "Foundation")]
	public static NSString Immutable
	{
		get
		{
			if (_Immutable == null)
			{
				_Immutable = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileImmutable");
			}
			return _Immutable;
		}
	}

	[Field("NSFileModificationDate", "Foundation")]
	public static NSString ModificationDate
	{
		get
		{
			if (_ModificationDate == null)
			{
				_ModificationDate = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileModificationDate");
			}
			return _ModificationDate;
		}
	}

	[Field("NSFileType", "Foundation")]
	public static NSString NSFileType
	{
		get
		{
			if (_NSFileType == null)
			{
				_NSFileType = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileType");
			}
			return _NSFileType;
		}
	}

	[Field("NSFileOwnerAccountID", "Foundation")]
	public static NSString OwnerAccountID
	{
		get
		{
			if (_OwnerAccountID == null)
			{
				_OwnerAccountID = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileOwnerAccountID");
			}
			return _OwnerAccountID;
		}
	}

	[Field("NSFileOwnerAccountName", "Foundation")]
	public static NSString OwnerAccountName
	{
		get
		{
			if (_OwnerAccountName == null)
			{
				_OwnerAccountName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileOwnerAccountName");
			}
			return _OwnerAccountName;
		}
	}

	[Field("NSFilePosixPermissions", "Foundation")]
	public static NSString PosixPermissions
	{
		get
		{
			if (_PosixPermissions == null)
			{
				_PosixPermissions = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFilePosixPermissions");
			}
			return _PosixPermissions;
		}
	}

	[Field("NSFileReferenceCount", "Foundation")]
	public static NSString ReferenceCount
	{
		get
		{
			if (_ReferenceCount == null)
			{
				_ReferenceCount = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileReferenceCount");
			}
			return _ReferenceCount;
		}
	}

	[Field("NSFileSize", "Foundation")]
	public static NSString Size
	{
		get
		{
			if (_Size == null)
			{
				_Size = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileSize");
			}
			return _Size;
		}
	}

	[Field("NSFileSystemFileNumber", "Foundation")]
	public static NSString SystemFileNumber
	{
		get
		{
			if (_SystemFileNumber == null)
			{
				_SystemFileNumber = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileSystemFileNumber");
			}
			return _SystemFileNumber;
		}
	}

	[Field("NSFileSystemFreeNodes", "Foundation")]
	public static NSString SystemFreeNodes
	{
		get
		{
			if (_SystemFreeNodes == null)
			{
				_SystemFreeNodes = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileSystemFreeNodes");
			}
			return _SystemFreeNodes;
		}
	}

	[Field("NSFileSystemFreeSize", "Foundation")]
	public static NSString SystemFreeSize
	{
		get
		{
			if (_SystemFreeSize == null)
			{
				_SystemFreeSize = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileSystemFreeSize");
			}
			return _SystemFreeSize;
		}
	}

	[Field("NSFileSystemNodes", "Foundation")]
	public static NSString SystemNodes
	{
		get
		{
			if (_SystemNodes == null)
			{
				_SystemNodes = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileSystemNodes");
			}
			return _SystemNodes;
		}
	}

	[Field("NSFileSystemNumber", "Foundation")]
	public static NSString SystemNumber
	{
		get
		{
			if (_SystemNumber == null)
			{
				_SystemNumber = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileSystemNumber");
			}
			return _SystemNumber;
		}
	}

	[Field("NSFileSystemSize", "Foundation")]
	public static NSString SystemSize
	{
		get
		{
			if (_SystemSize == null)
			{
				_SystemSize = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileSystemSize");
			}
			return _SystemSize;
		}
	}

	[Field("NSFileTypeBlockSpecial", "Foundation")]
	public static NSString TypeBlockSpecial
	{
		get
		{
			if (_TypeBlockSpecial == null)
			{
				_TypeBlockSpecial = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileTypeBlockSpecial");
			}
			return _TypeBlockSpecial;
		}
	}

	[Field("NSFileTypeCharacterSpecial", "Foundation")]
	public static NSString TypeCharacterSpecial
	{
		get
		{
			if (_TypeCharacterSpecial == null)
			{
				_TypeCharacterSpecial = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileTypeCharacterSpecial");
			}
			return _TypeCharacterSpecial;
		}
	}

	[Field("NSFileTypeDirectory", "Foundation")]
	public static NSString TypeDirectory
	{
		get
		{
			if (_TypeDirectory == null)
			{
				_TypeDirectory = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileTypeDirectory");
			}
			return _TypeDirectory;
		}
	}

	[Field("NSFileTypeRegular", "Foundation")]
	public static NSString TypeRegular
	{
		get
		{
			if (_TypeRegular == null)
			{
				_TypeRegular = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileTypeRegular");
			}
			return _TypeRegular;
		}
	}

	[Field("NSFileTypeSocket", "Foundation")]
	public static NSString TypeSocket
	{
		get
		{
			if (_TypeSocket == null)
			{
				_TypeSocket = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileTypeSocket");
			}
			return _TypeSocket;
		}
	}

	[Field("NSFileTypeSymbolicLink", "Foundation")]
	public static NSString TypeSymbolicLink
	{
		get
		{
			if (_TypeSymbolicLink == null)
			{
				_TypeSymbolicLink = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileTypeSymbolicLink");
			}
			return _TypeSymbolicLink;
		}
	}

	[Field("NSFileTypeUnknown", "Foundation")]
	public static NSString TypeUnknown
	{
		get
		{
			if (_TypeUnknown == null)
			{
				_TypeUnknown = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileTypeUnknown");
			}
			return _TypeUnknown;
		}
	}

	[Field("NSUbiquityIdentityDidChangeNotification", "Foundation")]
	[Advice("Use NSFileManager.Notifications.ObserveUbiquityIdentityDidChange helper method instead.")]
	public static NSString UbiquityIdentityDidChangeNotification
	{
		get
		{
			if (_UbiquityIdentityDidChangeNotification == null)
			{
				_UbiquityIdentityDidChangeNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUbiquityIdentityDidChangeNotification");
			}
			return _UbiquityIdentityDidChangeNotification;
		}
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern IntPtr NSUserName();

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern IntPtr NSFullUserName();

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern IntPtr NSHomeDirectory();

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern IntPtr NSHomeDirectoryForUser(IntPtr userName);

	public static string GetHomeDirectory(string userName)
	{
		if (userName == null)
		{
			throw new ArgumentNullException("userName");
		}
		using NSString self = new NSString(userName);
		using NSString nSString = Runtime.GetNSObject<NSString>(NSHomeDirectoryForUser(self.GetHandle()));
		return nSString.ToString();
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern IntPtr NSTemporaryDirectory();

	public bool SetAttributes(NSFileAttributes attributes, string path, out NSError error)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return SetAttributes(attributes.ToDictionary(), path, out error);
	}

	public bool SetAttributes(NSFileAttributes attributes, string path)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		NSError error;
		return SetAttributes(attributes.ToDictionary(), path, out error);
	}

	public bool CreateDirectory(string path, bool createIntermediates, NSFileAttributes attributes, out NSError error)
	{
		NSDictionary attributes2 = attributes?.ToDictionary();
		return CreateDirectory(path, createIntermediates, attributes2, out error);
	}

	public bool CreateDirectory(string path, bool createIntermediates, NSFileAttributes attributes)
	{
		NSDictionary attributes2 = attributes?.ToDictionary();
		NSError error;
		return CreateDirectory(path, createIntermediates, attributes2, out error);
	}

	public bool CreateFile(string path, NSData data, NSFileAttributes attributes)
	{
		NSDictionary attr = attributes?.ToDictionary();
		return CreateFile(path, data, attr);
	}

	public NSFileAttributes GetAttributes(string path, out NSError error)
	{
		return NSFileAttributes.FromDictionary(_GetAttributes(path, out error));
	}

	public NSFileAttributes GetAttributes(string path)
	{
		NSError error;
		return NSFileAttributes.FromDictionary(_GetAttributes(path, out error));
	}

	public NSFileSystemAttributes GetFileSystemAttributes(string path)
	{
		NSError error;
		return NSFileSystemAttributes.FromDictionary(_GetFileSystemAttributes(path, out error));
	}

	public NSFileSystemAttributes GetFileSystemAttributes(string path, out NSError error)
	{
		return NSFileSystemAttributes.FromDictionary(_GetFileSystemAttributes(path, out error));
	}

	public NSUrl[] GetMountedVolumes(NSString[] properties, NSVolumeEnumerationOptions options)
	{
		using NSArray properties2 = NSArray.FromNSObjects(properties);
		return GetMountedVolumes(properties2, options);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFileManager()
		: base(NSObjectFlag.Empty)
	{
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
	protected NSFileManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFileManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("changeCurrentDirectoryPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ChangeCurrentDirectory(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeCurrentDirectoryPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selChangeCurrentDirectoryPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("componentsToDisplayForPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ComponentsToDisplay(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selComponentsToDisplayForPath_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selComponentsToDisplayForPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("contentsAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Contents(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selContentsAtPath_Handle, arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selContentsAtPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("contentsEqualAtPath:andPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContentsEqual(string path1, string path2)
	{
		if (path1 == null)
		{
			throw new ArgumentNullException("path1");
		}
		if (path2 == null)
		{
			throw new ArgumentNullException("path2");
		}
		IntPtr arg = NSString.CreateNative(path1);
		IntPtr arg2 = NSString.CreateNative(path2);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selContentsEqualAtPath_AndPath_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selContentsEqualAtPath_AndPath_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("copyItemAtPath:toPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Copy(string srcPath, string dstPath, out NSError error)
	{
		if (srcPath == null)
		{
			throw new ArgumentNullException("srcPath");
		}
		if (dstPath == null)
		{
			throw new ArgumentNullException("dstPath");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(srcPath);
		IntPtr arg3 = NSString.CreateNative(dstPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selCopyItemAtPath_ToPath_Error_Handle, arg2, arg3, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selCopyItemAtPath_ToPath_Error_Handle, arg2, arg3, ref arg));
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("copyItemAtURL:toURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Copy(NSUrl srcUrl, NSUrl dstUrl, out NSError error)
	{
		if (srcUrl == null)
		{
			throw new ArgumentNullException("srcUrl");
		}
		if (dstUrl == null)
		{
			throw new ArgumentNullException("dstUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selCopyItemAtURL_ToURL_Error_Handle, srcUrl.Handle, dstUrl.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selCopyItemAtURL_ToURL_Error_Handle, srcUrl.Handle, dstUrl.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("createDirectoryAtPath:withIntermediateDirectories:attributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CreateDirectory(string path, bool createIntermediates, NSDictionary? attributes, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_IntPtr_ref_IntPtr(base.SuperHandle, selCreateDirectoryAtPath_WithIntermediateDirectories_Attributes_Error_Handle, arg2, createIntermediates, attributes?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_bool_IntPtr_ref_IntPtr(base.Handle, selCreateDirectoryAtPath_WithIntermediateDirectories_Attributes_Error_Handle, arg2, createIntermediates, attributes?.Handle ?? IntPtr.Zero, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("createDirectoryAtURL:withIntermediateDirectories:attributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CreateDirectory(NSUrl url, bool createIntermediates, NSDictionary? attributes, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_IntPtr_ref_IntPtr(base.SuperHandle, selCreateDirectoryAtURL_WithIntermediateDirectories_Attributes_Error_Handle, url.Handle, createIntermediates, attributes?.Handle ?? IntPtr.Zero, ref arg) : Messaging.bool_objc_msgSend_IntPtr_bool_IntPtr_ref_IntPtr(base.Handle, selCreateDirectoryAtURL_WithIntermediateDirectories_Attributes_Error_Handle, url.Handle, createIntermediates, attributes?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("createFileAtPath:contents:attributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CreateFile(string path, NSData data, NSDictionary? attr)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateFileAtPath_Contents_Attributes_Handle, arg, data.Handle, attr?.Handle ?? IntPtr.Zero) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCreateFileAtPath_Contents_Attributes_Handle, arg, data.Handle, attr?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createSymbolicLinkAtPath:withDestinationPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CreateSymbolicLink(string path, string destPath, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (destPath == null)
		{
			throw new ArgumentNullException("destPath");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		IntPtr arg3 = NSString.CreateNative(destPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selCreateSymbolicLinkAtPath_WithDestinationPath_Error_Handle, arg2, arg3, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selCreateSymbolicLinkAtPath_WithDestinationPath_Error_Handle, arg2, arg3, ref arg));
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("createSymbolicLinkAtURL:withDestinationURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CreateSymbolicLink(NSUrl url, NSUrl destURL, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (destURL == null)
		{
			throw new ArgumentNullException("destURL");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selCreateSymbolicLinkAtURL_WithDestinationURL_Error_Handle, url.Handle, destURL.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selCreateSymbolicLinkAtURL_WithDestinationURL_Error_Handle, url.Handle, destURL.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("displayNameAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DisplayName(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisplayNameAtPath_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDisplayNameAtPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("evictUbiquitousItemAtURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EvictUbiquitous(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selEvictUbiquitousItemAtURL_Error_Handle, url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selEvictUbiquitousItemAtURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("fileExistsAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FileExists(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selFileExistsAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selFileExistsAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fileExistsAtPath:isDirectory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FileExists(string path, ref bool isDirectory)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_Boolean(base.SuperHandle, selFileExistsAtPath_IsDirectory_Handle, arg, ref isDirectory) : Messaging.bool_objc_msgSend_IntPtr_ref_Boolean(base.Handle, selFileExistsAtPath_IsDirectory_Handle, arg, ref isDirectory));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fileManagerWithAuthorization:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileManager FromAuthorization(NSWorkspaceAuthorization authorization)
	{
		if (authorization == null)
		{
			throw new ArgumentNullException("authorization");
		}
		return Runtime.GetNSObject<NSFileManager>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileManagerWithAuthorization_Handle, authorization.Handle));
	}

	[Export("containerURLForSecurityApplicationGroupIdentifier:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl GetContainerUrl(string securityApplicationGroupIdentifier)
	{
		if (securityApplicationGroupIdentifier == null)
		{
			throw new ArgumentNullException("securityApplicationGroupIdentifier");
		}
		IntPtr arg = NSString.CreateNative(securityApplicationGroupIdentifier);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainerURLForSecurityApplicationGroupIdentifier_Handle, arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selContainerURLForSecurityApplicationGroupIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("currentDirectoryPath")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetCurrentDirectory()
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDirectoryPathHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDirectoryPathHandle));
	}

	[Export("contentsOfDirectoryAtPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetDirectoryContent(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selContentsOfDirectoryAtPath_Error_Handle, arg2, ref arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selContentsOfDirectoryAtPath_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("contentsOfDirectoryAtURL:includingPropertiesForKeys:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[] GetDirectoryContent(NSUrl url, NSArray? properties, NSDirectoryEnumerationOptions options, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSUrl[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selContentsOfDirectoryAtURL_IncludingPropertiesForKeys_Options_Error_Handle, url.Handle, properties?.Handle ?? IntPtr.Zero, (ulong)options, ref arg)) : NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr(base.Handle, selContentsOfDirectoryAtURL_IncludingPropertiesForKeys_Options_Error_Handle, url.Handle, properties?.Handle ?? IntPtr.Zero, (ulong)options, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("subpathsOfDirectoryAtPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetDirectoryContentRecursive(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selSubpathsOfDirectoryAtPath_Error_Handle, arg2, ref arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selSubpathsOfDirectoryAtPath_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("enumeratorAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDirectoryEnumerator GetEnumerator(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSDirectoryEnumerator result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDirectoryEnumerator>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumeratorAtPath_Handle, arg)) : Runtime.GetNSObject<NSDirectoryEnumerator>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEnumeratorAtPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSDirectoryEnumerator GetEnumerator(NSUrl url, NSString[]? keys, NSDirectoryEnumerationOptions options, [BlockProxy(typeof(Trampolines.NIDNSEnumerateErrorHandler))] NSEnumerateErrorHandler? handler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		NSArray nSArray = ((keys == null) ? null : NSArray.FromNSObjects(keys));
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSEnumerateErrorHandler.Handler, handler);
		}
		NSDirectoryEnumerator result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDirectoryEnumerator>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selEnumeratorAtURL_IncludingPropertiesForKeys_Options_ErrorHandler_Handle, url.Handle, nSArray?.Handle ?? IntPtr.Zero, (ulong)options, (IntPtr)ptr)) : Runtime.GetNSObject<NSDirectoryEnumerator>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selEnumeratorAtURL_IncludingPropertiesForKeys_Options_ErrorHandler_Handle, url.Handle, nSArray?.Handle ?? IntPtr.Zero, (ulong)options, (IntPtr)ptr)));
		nSArray?.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[Export("getFileProviderServicesForItemAtURL:completionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetFileProviderServices(NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity2V41))] Action<NSDictionary<NSString, NSFileProviderService>, NSError> completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V41.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetFileProviderServicesForItemAtURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetFileProviderServicesForItemAtURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSDictionary<NSString, NSFileProviderService>> GetFileProviderServicesAsync(NSUrl url)
	{
		TaskCompletionSource<NSDictionary<NSString, NSFileProviderService>> tcs = new TaskCompletionSource<NSDictionary<NSString, NSFileProviderService>>();
		GetFileProviderServices(url, delegate(NSDictionary<NSString, NSFileProviderService> arg1_, NSError arg2_)
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

	[Export("mountedVolumeURLsIncludingResourceValuesForKeys:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[] GetMountedVolumes(NSArray? properties, NSVolumeEnumerationOptions options)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selMountedVolumeURLsIncludingResourceValuesForKeys_Options_Handle, properties?.Handle ?? IntPtr.Zero, (ulong)options));
		}
		return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selMountedVolumeURLsIncludingResourceValuesForKeys_Options_Handle, properties?.Handle ?? IntPtr.Zero, (ulong)options));
	}

	[Export("getRelationship:ofDirectory:inDomain:toItemAtURL:error:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetRelationship(out NSUrlRelationship outRelationship, NSSearchPathDirectory directory, NSSearchPathDomain domain, NSUrl toItemAtUrl, out NSError error)
	{
		if (toItemAtUrl == null)
		{
			throw new ArgumentNullException("toItemAtUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_out_NSUrlRelationship_UInt64_UInt64_IntPtr_ref_IntPtr(base.SuperHandle, selGetRelationship_OfDirectory_InDomain_ToItemAtURL_Error_Handle, out outRelationship, (ulong)directory, (ulong)domain, toItemAtUrl.Handle, ref arg) : Messaging.bool_objc_msgSend_out_NSUrlRelationship_UInt64_UInt64_IntPtr_ref_IntPtr(base.Handle, selGetRelationship_OfDirectory_InDomain_ToItemAtURL_Error_Handle, out outRelationship, (ulong)directory, (ulong)domain, toItemAtUrl.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("getRelationship:ofDirectoryAtURL:toItemAtURL:error:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetRelationship(out NSUrlRelationship outRelationship, NSUrl directoryURL, NSUrl otherURL, out NSError error)
	{
		if (directoryURL == null)
		{
			throw new ArgumentNullException("directoryURL");
		}
		if (otherURL == null)
		{
			throw new ArgumentNullException("otherURL");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_out_NSUrlRelationship_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selGetRelationship_OfDirectoryAtURL_ToItemAtURL_Error_Handle, out outRelationship, directoryURL.Handle, otherURL.Handle, ref arg) : Messaging.bool_objc_msgSend_out_NSUrlRelationship_IntPtr_IntPtr_ref_IntPtr(base.Handle, selGetRelationship_OfDirectoryAtURL_ToItemAtURL_Error_Handle, out outRelationship, directoryURL.Handle, otherURL.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("destinationOfSymbolicLinkAtPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetSymbolicLinkDestination(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selDestinationOfSymbolicLinkAtPath_Error_Handle, arg2, ref arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selDestinationOfSymbolicLinkAtPath_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("URLForDirectory:inDomain:appropriateForURL:create:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl GetUrl(NSSearchPathDirectory directory, NSSearchPathDomain domain, NSUrl? url, bool shouldCreate, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_UInt64_UInt64_IntPtr_bool_ref_IntPtr(base.SuperHandle, selURLForDirectory_InDomain_AppropriateForURL_Create_Error_Handle, (ulong)directory, (ulong)domain, (url == null) ? IntPtr.Zero : url.Handle, shouldCreate, ref arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_UInt64_UInt64_IntPtr_bool_ref_IntPtr(base.Handle, selURLForDirectory_InDomain_AppropriateForURL_Create_Error_Handle, (ulong)directory, (ulong)domain, (url == null) ? IntPtr.Zero : url.Handle, shouldCreate, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("URLForPublishingUbiquitousItemAtURL:expirationDate:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl GetUrlForPublishingUbiquitousItem(NSUrl url, out NSDate expirationDate, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr_ref_IntPtr(base.SuperHandle, selURLForPublishingUbiquitousItemAtURL_ExpirationDate_Error_Handle, url.Handle, ref arg, ref arg2)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr_ref_IntPtr(base.Handle, selURLForPublishingUbiquitousItemAtURL_ExpirationDate_Error_Handle, url.Handle, ref arg, ref arg2)));
		expirationDate = Runtime.GetNSObject<NSDate>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[Export("URLForUbiquityContainerIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl GetUrlForUbiquityContainer(string? containerIdentifier)
	{
		IntPtr arg = NSString.CreateNative(containerIdentifier);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForUbiquityContainerIdentifier_Handle, arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForUbiquityContainerIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLsForDirectory:inDomains:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[] GetUrls(NSSearchPathDirectory directory, NSSearchPathDomain domains)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend_UInt64_UInt64(base.Handle, selURLsForDirectory_InDomains_Handle, (ulong)directory, (ulong)domains));
		}
		return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_UInt64_UInt64(base.SuperHandle, selURLsForDirectory_InDomains_Handle, (ulong)directory, (ulong)domains));
	}

	[Export("isDeletableFileAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDeletableFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDeletableFileAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDeletableFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isExecutableFileAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsExecutableFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsExecutableFileAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsExecutableFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isReadableFileAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsReadableFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsReadableFileAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsReadableFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isUbiquitousItemAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsUbiquitous(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsUbiquitousItemAtURL_Handle, url.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsUbiquitousItemAtURL_Handle, url.Handle);
	}

	[Export("isWritableFileAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsWritableFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsWritableFileAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsWritableFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("linkItemAtPath:toPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Link(string srcPath, string dstPath, out NSError error)
	{
		if (srcPath == null)
		{
			throw new ArgumentNullException("srcPath");
		}
		if (dstPath == null)
		{
			throw new ArgumentNullException("dstPath");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(srcPath);
		IntPtr arg3 = NSString.CreateNative(dstPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selLinkItemAtPath_ToPath_Error_Handle, arg2, arg3, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selLinkItemAtPath_ToPath_Error_Handle, arg2, arg3, ref arg));
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("linkItemAtURL:toURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Link(NSUrl srcUrl, NSUrl dstUrl, out NSError error)
	{
		if (srcUrl == null)
		{
			throw new ArgumentNullException("srcUrl");
		}
		if (dstUrl == null)
		{
			throw new ArgumentNullException("dstUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selLinkItemAtURL_ToURL_Error_Handle, srcUrl.Handle, dstUrl.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selLinkItemAtURL_ToURL_Error_Handle, srcUrl.Handle, dstUrl.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("moveItemAtPath:toPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Move(string srcPath, string dstPath, out NSError error)
	{
		if (srcPath == null)
		{
			throw new ArgumentNullException("srcPath");
		}
		if (dstPath == null)
		{
			throw new ArgumentNullException("dstPath");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(srcPath);
		IntPtr arg3 = NSString.CreateNative(dstPath);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selMoveItemAtPath_ToPath_Error_Handle, arg2, arg3, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selMoveItemAtPath_ToPath_Error_Handle, arg2, arg3, ref arg));
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("moveItemAtURL:toURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Move(NSUrl srcUrl, NSUrl dstUrl, out NSError error)
	{
		if (srcUrl == null)
		{
			throw new ArgumentNullException("srcUrl");
		}
		if (dstUrl == null)
		{
			throw new ArgumentNullException("dstUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selMoveItemAtURL_ToURL_Error_Handle, srcUrl.Handle, dstUrl.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selMoveItemAtURL_ToURL_Error_Handle, srcUrl.Handle, dstUrl.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeItemAtPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Remove(string? path, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selRemoveItemAtPath_Error_Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selRemoveItemAtPath_Error_Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeItemAtURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Remove(NSUrl? url, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selRemoveItemAtURL_Error_Handle, (url == null) ? IntPtr.Zero : url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selRemoveItemAtURL_Error_Handle, (url == null) ? IntPtr.Zero : url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("replaceItemAtURL:withItemAtURL:backupItemName:options:resultingItemURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Replace(NSUrl originalItem, NSUrl newItem, string? backupItemName, NSFileManagerItemReplacementOptions options, out NSUrl resultingURL, out NSError error)
	{
		if (originalItem == null)
		{
			throw new ArgumentNullException("originalItem");
		}
		if (newItem == null)
		{
			throw new ArgumentNullException("newItem");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(backupItemName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_ref_IntPtr_ref_IntPtr(base.SuperHandle, selReplaceItemAtURL_WithItemAtURL_BackupItemName_Options_ResultingItemURL_Error_Handle, originalItem.Handle, newItem.Handle, arg3, (ulong)options, ref arg, ref arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_ref_IntPtr_ref_IntPtr(base.Handle, selReplaceItemAtURL_WithItemAtURL_BackupItemName_Options_ResultingItemURL_Error_Handle, originalItem.Handle, newItem.Handle, arg3, (ulong)options, ref arg, ref arg2));
		NSString.ReleaseNative(arg3);
		resultingURL = Runtime.GetNSObject<NSUrl>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[Export("setAttributes:ofItemAtPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetAttributes(NSDictionary attributes, string path, out NSError error)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selSetAttributes_OfItemAtPath_Error_Handle, attributes.Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selSetAttributes_OfItemAtPath_Error_Handle, attributes.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setUbiquitous:itemAtURL:destinationURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetUbiquitous(bool flag, NSUrl url, NSUrl destinationUrl, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (destinationUrl == null)
		{
			throw new ArgumentNullException("destinationUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_bool_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selSetUbiquitous_ItemAtURL_DestinationURL_Error_Handle, flag, url.Handle, destinationUrl.Handle, ref arg) : Messaging.bool_objc_msgSend_bool_IntPtr_IntPtr_ref_IntPtr(base.Handle, selSetUbiquitous_ItemAtURL_DestinationURL_Error_Handle, flag, url.Handle, destinationUrl.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("startDownloadingUbiquitousItemAtURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartDownloadingUbiquitous(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selStartDownloadingUbiquitousItemAtURL_Error_Handle, url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selStartDownloadingUbiquitousItemAtURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("subpathsAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Subpaths(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSubpathsAtPath_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSubpathsAtPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("trashItemAtURL:resultingItemURL:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TrashItem(NSUrl url, out NSUrl resultingItemUrl, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_ref_IntPtr(base.SuperHandle, selTrashItemAtURL_ResultingItemURL_Error_Handle, url.Handle, ref arg, ref arg2) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_ref_IntPtr(base.Handle, selTrashItemAtURL_ResultingItemURL_Error_Handle, url.Handle, ref arg, ref arg2));
		resultingItemUrl = Runtime.GetNSObject<NSUrl>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[Export("unmountVolumeAtURL:options:completionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void UnmountVolume(NSUrl url, NSFileManagerUnmountOptions mask, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selUnmountVolumeAtURL_Options_CompletionHandler_Handle, url.Handle, (ulong)mask, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selUnmountVolumeAtURL_Options_CompletionHandler_Handle, url.Handle, (ulong)mask, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task UnmountVolumeAsync(NSUrl url, NSFileManagerUnmountOptions mask)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		UnmountVolume(url, mask, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("attributesOfItemAtPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSDictionary _GetAttributes(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selAttributesOfItemAtPath_Error_Handle, arg2, ref arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selAttributesOfItemAtPath_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("attributesOfFileSystemForPath:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSDictionary _GetFileSystemAttributes(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selAttributesOfFileSystemForPath_Error_Handle, arg2, ref arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selAttributesOfFileSystemForPath_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
