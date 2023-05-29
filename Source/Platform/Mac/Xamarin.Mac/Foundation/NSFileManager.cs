using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileManager", true)]
public class NSFileManager : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveUbiquityIdentityDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(UbiquityIdentityDidChangeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selDefaultManagerHandle = Selector.GetHandle("defaultManager");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selUbiquityIdentityTokenHandle = Selector.GetHandle("ubiquityIdentityToken");

	private static readonly IntPtr selSetAttributesOfItemAtPathError_Handle = Selector.GetHandle("setAttributes:ofItemAtPath:error:");

	private static readonly IntPtr selCreateDirectoryAtPathWithIntermediateDirectoriesAttributesError_Handle = Selector.GetHandle("createDirectoryAtPath:withIntermediateDirectories:attributes:error:");

	private static readonly IntPtr selContentsOfDirectoryAtPathError_Handle = Selector.GetHandle("contentsOfDirectoryAtPath:error:");

	private static readonly IntPtr selSubpathsOfDirectoryAtPathError_Handle = Selector.GetHandle("subpathsOfDirectoryAtPath:error:");

	private static readonly IntPtr selAttributesOfItemAtPathError_Handle = Selector.GetHandle("attributesOfItemAtPath:error:");

	private static readonly IntPtr selAttributesOfFileSystemForPathError_Handle = Selector.GetHandle("attributesOfFileSystemForPath:error:");

	private static readonly IntPtr selCreateSymbolicLinkAtPathWithDestinationPathError_Handle = Selector.GetHandle("createSymbolicLinkAtPath:withDestinationPath:error:");

	private static readonly IntPtr selDestinationOfSymbolicLinkAtPathError_Handle = Selector.GetHandle("destinationOfSymbolicLinkAtPath:error:");

	private static readonly IntPtr selCopyItemAtPathToPathError_Handle = Selector.GetHandle("copyItemAtPath:toPath:error:");

	private static readonly IntPtr selMoveItemAtPathToPathError_Handle = Selector.GetHandle("moveItemAtPath:toPath:error:");

	private static readonly IntPtr selLinkItemAtPathToPathError_Handle = Selector.GetHandle("linkItemAtPath:toPath:error:");

	private static readonly IntPtr selRemoveItemAtPathError_Handle = Selector.GetHandle("removeItemAtPath:error:");

	private static readonly IntPtr selCurrentDirectoryPathHandle = Selector.GetHandle("currentDirectoryPath");

	private static readonly IntPtr selChangeCurrentDirectoryPath_Handle = Selector.GetHandle("changeCurrentDirectoryPath:");

	private static readonly IntPtr selFileExistsAtPath_Handle = Selector.GetHandle("fileExistsAtPath:");

	private static readonly IntPtr selFileExistsAtPathIsDirectory_Handle = Selector.GetHandle("fileExistsAtPath:isDirectory:");

	private static readonly IntPtr selIsReadableFileAtPath_Handle = Selector.GetHandle("isReadableFileAtPath:");

	private static readonly IntPtr selIsWritableFileAtPath_Handle = Selector.GetHandle("isWritableFileAtPath:");

	private static readonly IntPtr selIsExecutableFileAtPath_Handle = Selector.GetHandle("isExecutableFileAtPath:");

	private static readonly IntPtr selIsDeletableFileAtPath_Handle = Selector.GetHandle("isDeletableFileAtPath:");

	private static readonly IntPtr selContentsEqualAtPathAndPath_Handle = Selector.GetHandle("contentsEqualAtPath:andPath:");

	private static readonly IntPtr selDisplayNameAtPath_Handle = Selector.GetHandle("displayNameAtPath:");

	private static readonly IntPtr selComponentsToDisplayForPath_Handle = Selector.GetHandle("componentsToDisplayForPath:");

	private static readonly IntPtr selEnumeratorAtPath_Handle = Selector.GetHandle("enumeratorAtPath:");

	private static readonly IntPtr selSubpathsAtPath_Handle = Selector.GetHandle("subpathsAtPath:");

	private static readonly IntPtr selContentsAtPath_Handle = Selector.GetHandle("contentsAtPath:");

	private static readonly IntPtr selCreateFileAtPathContentsAttributes_Handle = Selector.GetHandle("createFileAtPath:contents:attributes:");

	private static readonly IntPtr selContentsOfDirectoryAtURLIncludingPropertiesForKeysOptionsError_Handle = Selector.GetHandle("contentsOfDirectoryAtURL:includingPropertiesForKeys:options:error:");

	private static readonly IntPtr selCopyItemAtURLToURLError_Handle = Selector.GetHandle("copyItemAtURL:toURL:error:");

	private static readonly IntPtr selMoveItemAtURLToURLError_Handle = Selector.GetHandle("moveItemAtURL:toURL:error:");

	private static readonly IntPtr selLinkItemAtURLToURLError_Handle = Selector.GetHandle("linkItemAtURL:toURL:error:");

	private static readonly IntPtr selRemoveItemAtURLError_Handle = Selector.GetHandle("removeItemAtURL:error:");

	private static readonly IntPtr selEnumeratorAtURLIncludingPropertiesForKeysOptionsErrorHandler_Handle = Selector.GetHandle("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:");

	private static readonly IntPtr selURLForDirectoryInDomainAppropriateForURLCreateError_Handle = Selector.GetHandle("URLForDirectory:inDomain:appropriateForURL:create:error:");

	private static readonly IntPtr selURLsForDirectoryInDomains_Handle = Selector.GetHandle("URLsForDirectory:inDomains:");

	private static readonly IntPtr selReplaceItemAtURLWithItemAtURLBackupItemNameOptionsResultingItemURLError_Handle = Selector.GetHandle("replaceItemAtURL:withItemAtURL:backupItemName:options:resultingItemURL:error:");

	private static readonly IntPtr selMountedVolumeURLsIncludingResourceValuesForKeysOptions_Handle = Selector.GetHandle("mountedVolumeURLsIncludingResourceValuesForKeys:options:");

	private static readonly IntPtr selCreateDirectoryAtURLWithIntermediateDirectoriesAttributesError_Handle = Selector.GetHandle("createDirectoryAtURL:withIntermediateDirectories:attributes:error:");

	private static readonly IntPtr selCreateSymbolicLinkAtURLWithDestinationURLError_Handle = Selector.GetHandle("createSymbolicLinkAtURL:withDestinationURL:error:");

	private static readonly IntPtr selSetUbiquitousItemAtURLDestinationURLError_Handle = Selector.GetHandle("setUbiquitous:itemAtURL:destinationURL:error:");

	private static readonly IntPtr selIsUbiquitousItemAtURL_Handle = Selector.GetHandle("isUbiquitousItemAtURL:");

	private static readonly IntPtr selStartDownloadingUbiquitousItemAtURLError_Handle = Selector.GetHandle("startDownloadingUbiquitousItemAtURL:error:");

	private static readonly IntPtr selEvictUbiquitousItemAtURLError_Handle = Selector.GetHandle("evictUbiquitousItemAtURL:error:");

	private static readonly IntPtr selURLForUbiquityContainerIdentifier_Handle = Selector.GetHandle("URLForUbiquityContainerIdentifier:");

	private static readonly IntPtr selURLForPublishingUbiquitousItemAtURLExpirationDateError_Handle = Selector.GetHandle("URLForPublishingUbiquitousItemAtURL:expirationDate:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFileManager");

	private static object __mt_DefaultManager_var_static;

	private object __mt_WeakDelegate_var;

	private object __mt_UbiquityIdentityToken_var;

	private static NSString _NSFileType;

	private static NSString _TypeDirectory;

	private static NSString _TypeRegular;

	private static NSString _TypeSymbolicLink;

	private static NSString _TypeSocket;

	private static NSString _TypeCharacterSpecial;

	private static NSString _TypeBlockSpecial;

	private static NSString _TypeUnknown;

	private static NSString _Size;

	private static NSString _ModificationDate;

	private static NSString _ReferenceCount;

	private static NSString _DeviceIdentifier;

	private static NSString _OwnerAccountName;

	private static NSString _GroupOwnerAccountName;

	private static NSString _PosixPermissions;

	private static NSString _SystemNumber;

	private static NSString _SystemFileNumber;

	private static NSString _ExtensionHidden;

	private static NSString _HfsCreatorCode;

	private static NSString _HfsTypeCode;

	private static NSString _Immutable;

	private static NSString _AppendOnly;

	private static NSString _CreationDate;

	private static NSString _OwnerAccountID;

	private static NSString _GroupOwnerAccountID;

	private static NSString _Busy;

	private static NSString _SystemSize;

	private static NSString _SystemFreeSize;

	private static NSString _SystemNodes;

	private static NSString _SystemFreeNodes;

	private static NSString _UbiquityIdentityDidChangeNotification;

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

	public static NSFileManager DefaultManager
	{
		[Export("defaultManager")]
		get
		{
			return (NSFileManager)(__mt_DefaultManager_var_static = (NSFileManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultManagerHandle)));
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value.Handle);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSFileManagerDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSFileManagerDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	[MountainLion]
	[Since(6, 0)]
	public virtual NSObject UbiquityIdentityToken
	{
		[MountainLion]
		[Export("ubiquityIdentityToken")]
		get
		{
			return (NSObject)(__mt_UbiquityIdentityToken_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUbiquityIdentityTokenHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUbiquityIdentityTokenHandle))));
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

	[Field("NSUbiquityIdentityDidChangeNotification", "Foundation")]
	[MountainLion]
	public static NSString UbiquityIdentityDidChangeNotification
	{
		[MountainLion]
		get
		{
			if (_UbiquityIdentityDidChangeNotification == null)
			{
				_UbiquityIdentityDidChangeNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUbiquityIdentityDidChangeNotification");
			}
			return _UbiquityIdentityDidChangeNotification;
		}
	}

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
		return NSFileAttributes.FromDict(_GetAttributes(path, out error));
	}

	public NSFileAttributes GetAttributes(string path)
	{
		NSError error;
		return NSFileAttributes.FromDict(_GetAttributes(path, out error));
	}

	public NSFileSystemAttributes GetFileSystemAttributes(string path)
	{
		NSError error;
		return NSFileSystemAttributes.FromDict(_GetFileSystemAttributes(path, out error));
	}

	public NSFileSystemAttributes GetFileSystemAttributes(string path, out NSError error)
	{
		return NSFileSystemAttributes.FromDict(_GetFileSystemAttributes(path, out error));
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFileManager()
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
	public NSFileManager(NSCoder coder)
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
	public NSFileManager(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFileManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setAttributes:ofItemAtPath:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetAttributesOfItemAtPathError_Handle, attributes.Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetAttributesOfItemAtPathError_Handle, attributes.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("createDirectoryAtPath:withIntermediateDirectories:attributes:error:")]
	public virtual bool CreateDirectory(string path, bool createIntermediates, NSDictionary attributes, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr(base.SuperHandle, selCreateDirectoryAtPathWithIntermediateDirectoriesAttributesError_Handle, arg, createIntermediates, attributes?.Handle ?? IntPtr.Zero, intPtr) : Messaging.bool_objc_msgSend_IntPtr_bool_IntPtr_IntPtr(base.Handle, selCreateDirectoryAtPathWithIntermediateDirectoriesAttributesError_Handle, arg, createIntermediates, attributes?.Handle ?? IntPtr.Zero, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("contentsOfDirectoryAtPath:error:")]
	public virtual string[] GetDirectoryContent(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selContentsOfDirectoryAtPathError_Handle, arg, intPtr)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selContentsOfDirectoryAtPathError_Handle, arg, intPtr)));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("subpathsOfDirectoryAtPath:error:")]
	public virtual string[] GetDirectoryContentRecursive(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSubpathsOfDirectoryAtPathError_Handle, arg, intPtr)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selSubpathsOfDirectoryAtPathError_Handle, arg, intPtr)));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("attributesOfItemAtPath:error:")]
	internal virtual NSDictionary _GetAttributes(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAttributesOfItemAtPathError_Handle, arg, intPtr))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selAttributesOfItemAtPathError_Handle, arg, intPtr))));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("attributesOfFileSystemForPath:error:")]
	internal virtual NSDictionary _GetFileSystemAttributes(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAttributesOfFileSystemForPathError_Handle, arg, intPtr))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selAttributesOfFileSystemForPathError_Handle, arg, intPtr))));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("createSymbolicLinkAtPath:withDestinationPath:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		IntPtr arg2 = NSString.CreateNative(destPath);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateSymbolicLinkAtPathWithDestinationPathError_Handle, arg, arg2, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCreateSymbolicLinkAtPathWithDestinationPathError_Handle, arg, arg2, intPtr));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("destinationOfSymbolicLinkAtPath:error:")]
	public virtual string GetSymbolicLinkDestination(string path, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDestinationOfSymbolicLinkAtPathError_Handle, arg, intPtr)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDestinationOfSymbolicLinkAtPathError_Handle, arg, intPtr)));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("copyItemAtPath:toPath:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(srcPath);
		IntPtr arg2 = NSString.CreateNative(dstPath);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCopyItemAtPathToPathError_Handle, arg, arg2, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCopyItemAtPathToPathError_Handle, arg, arg2, intPtr));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("moveItemAtPath:toPath:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(srcPath);
		IntPtr arg2 = NSString.CreateNative(dstPath);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMoveItemAtPathToPathError_Handle, arg, arg2, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selMoveItemAtPathToPathError_Handle, arg, arg2, intPtr));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("linkItemAtPath:toPath:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(srcPath);
		IntPtr arg2 = NSString.CreateNative(dstPath);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLinkItemAtPathToPathError_Handle, arg, arg2, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selLinkItemAtPathToPathError_Handle, arg, arg2, intPtr));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("removeItemAtPath:error:")]
	public virtual bool Remove(string path, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveItemAtPathError_Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveItemAtPathError_Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("currentDirectoryPath")]
	public virtual string GetCurrentDirectory()
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDirectoryPathHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDirectoryPathHandle));
	}

	[Export("changeCurrentDirectoryPath:")]
	public virtual bool ChangeCurrentDirectory(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeCurrentDirectoryPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selChangeCurrentDirectoryPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fileExistsAtPath:")]
	public virtual bool FileExists(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selFileExistsAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selFileExistsAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fileExistsAtPath:isDirectory:")]
	public virtual bool FileExists(string path, ref bool isDirectory)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_out_Boolean(base.SuperHandle, selFileExistsAtPathIsDirectory_Handle, arg, out isDirectory) : Messaging.bool_objc_msgSend_IntPtr_out_Boolean(base.Handle, selFileExistsAtPathIsDirectory_Handle, arg, out isDirectory));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isReadableFileAtPath:")]
	public virtual bool IsReadableFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsReadableFileAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsReadableFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isWritableFileAtPath:")]
	public virtual bool IsWritableFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsWritableFileAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsWritableFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isExecutableFileAtPath:")]
	public virtual bool IsExecutableFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsExecutableFileAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsExecutableFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isDeletableFileAtPath:")]
	public virtual bool IsDeletableFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDeletableFileAtPath_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDeletableFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("contentsEqualAtPath:andPath:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selContentsEqualAtPathAndPath_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selContentsEqualAtPathAndPath_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("displayNameAtPath:")]
	public virtual string DisplayName(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisplayNameAtPath_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDisplayNameAtPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("componentsToDisplayForPath:")]
	public virtual string[] ComponentsToDisplay(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selComponentsToDisplayForPath_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selComponentsToDisplayForPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("enumeratorAtPath:")]
	public virtual NSDirectoryEnumerator GetEnumerator(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSDirectoryEnumerator result = ((!IsDirectBinding) ? ((NSDirectoryEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumeratorAtPath_Handle, arg))) : ((NSDirectoryEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEnumeratorAtPath_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("subpathsAtPath:")]
	public virtual string[] Subpaths(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSubpathsAtPath_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSubpathsAtPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("contentsAtPath:")]
	public virtual NSData Contents(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSData result = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selContentsAtPath_Handle, arg))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selContentsAtPath_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createFileAtPath:contents:attributes:")]
	public virtual bool CreateFile(string path, NSData data, NSDictionary attr)
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateFileAtPathContentsAttributes_Handle, arg, data.Handle, attr?.Handle ?? IntPtr.Zero) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCreateFileAtPathContentsAttributes_Handle, arg, data.Handle, attr?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("contentsOfDirectoryAtURL:includingPropertiesForKeys:options:error:")]
	public virtual NSUrl[] GetDirectoryContent(NSUrl url, NSArray properties, NSDirectoryEnumerationOptions options, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSUrl[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selContentsOfDirectoryAtURLIncludingPropertiesForKeysOptionsError_Handle, url.Handle, properties.Handle, (ulong)options, intPtr)) : NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selContentsOfDirectoryAtURLIncludingPropertiesForKeysOptionsError_Handle, url.Handle, properties.Handle, (ulong)options, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("copyItemAtURL:toURL:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCopyItemAtURLToURLError_Handle, srcUrl.Handle, dstUrl.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCopyItemAtURLToURLError_Handle, srcUrl.Handle, dstUrl.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("moveItemAtURL:toURL:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMoveItemAtURLToURLError_Handle, srcUrl.Handle, dstUrl.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selMoveItemAtURLToURLError_Handle, srcUrl.Handle, dstUrl.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("linkItemAtURL:toURL:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLinkItemAtURLToURLError_Handle, srcUrl.Handle, dstUrl.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selLinkItemAtURLToURLError_Handle, srcUrl.Handle, dstUrl.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("removeItemAtURL:error:")]
	public virtual bool Remove(NSUrl url, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveItemAtURLError_Handle, url?.Handle ?? IntPtr.Zero, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveItemAtURLError_Handle, url?.Handle ?? IntPtr.Zero, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("enumeratorAtURL:includingPropertiesForKeys:options:errorHandler:")]
	public unsafe virtual NSDirectoryEnumerator GetEnumerator(NSUrl url, NSArray properties, NSDirectoryEnumerationOptions options, NSEnumerateErrorHandler handler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlock(Trampolines.SDNSEnumerateErrorHandler.Handler, handler);
		}
		NSDirectoryEnumerator result = ((!IsDirectBinding) ? ((NSDirectoryEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selEnumeratorAtURLIncludingPropertiesForKeysOptionsErrorHandler_Handle, url.Handle, properties?.Handle ?? IntPtr.Zero, (ulong)options, (IntPtr)ptr))) : ((NSDirectoryEnumerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selEnumeratorAtURLIncludingPropertiesForKeysOptionsErrorHandler_Handle, url.Handle, properties?.Handle ?? IntPtr.Zero, (ulong)options, (IntPtr)ptr))));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[Export("URLForDirectory:inDomain:appropriateForURL:create:error:")]
	public virtual NSUrl GetUrl(NSSearchPathDirectory directory, NSSearchPathDomain domain, NSUrl url, bool shouldCreate, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSUrl result = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_UInt64_IntPtr_bool_IntPtr(base.SuperHandle, selURLForDirectoryInDomainAppropriateForURLCreateError_Handle, (ulong)directory, (ulong)domain, url?.Handle ?? IntPtr.Zero, shouldCreate, intPtr))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_UInt64_IntPtr_bool_IntPtr(base.Handle, selURLForDirectoryInDomainAppropriateForURLCreateError_Handle, (ulong)directory, (ulong)domain, url?.Handle ?? IntPtr.Zero, shouldCreate, intPtr))));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("URLsForDirectory:inDomains:")]
	public virtual NSUrl[] GetUrls(NSSearchPathDirectory directory, NSSearchPathDomain domains)
	{
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend_UInt64_UInt64(base.Handle, selURLsForDirectoryInDomains_Handle, (ulong)directory, (ulong)domains));
		}
		return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_UInt64_UInt64(base.SuperHandle, selURLsForDirectoryInDomains_Handle, (ulong)directory, (ulong)domains));
	}

	[Export("replaceItemAtURL:withItemAtURL:backupItemName:options:resultingItemURL:error:")]
	public virtual bool Replace(NSUrl originalItem, NSUrl newItem, string backupItemName, NSFileManagerItemReplacementOptions options, out NSUrl resultingURL, out NSError error)
	{
		if (originalItem == null)
		{
			throw new ArgumentNullException("originalItem");
		}
		if (newItem == null)
		{
			throw new ArgumentNullException("newItem");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr intPtr2 = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr2, 0);
		IntPtr arg = NSString.CreateNative(backupItemName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selReplaceItemAtURLWithItemAtURLBackupItemNameOptionsResultingItemURLError_Handle, originalItem.Handle, newItem.Handle, arg, (ulong)options, intPtr, intPtr2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selReplaceItemAtURLWithItemAtURLBackupItemNameOptionsResultingItemURLError_Handle, originalItem.Handle, newItem.Handle, arg, (ulong)options, intPtr, intPtr2));
		NSString.ReleaseNative(arg);
		IntPtr intPtr3 = Marshal.ReadIntPtr(intPtr);
		resultingURL = ((intPtr3 != IntPtr.Zero) ? ((NSUrl)Runtime.GetNSObject(intPtr3)) : null);
		Marshal.FreeHGlobal(intPtr);
		IntPtr intPtr4 = Marshal.ReadIntPtr(intPtr2);
		error = ((intPtr4 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr4)) : null);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	[Export("mountedVolumeURLsIncludingResourceValuesForKeys:options:")]
	public virtual NSUrl[] GetMountedVolumes(NSArray properties, NSVolumeEnumerationOptions options)
	{
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selMountedVolumeURLsIncludingResourceValuesForKeysOptions_Handle, properties?.Handle ?? IntPtr.Zero, (ulong)options));
		}
		return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selMountedVolumeURLsIncludingResourceValuesForKeysOptions_Handle, properties?.Handle ?? IntPtr.Zero, (ulong)options));
	}

	[Export("createDirectoryAtURL:withIntermediateDirectories:attributes:error:")]
	public virtual bool CreateDirectory(NSUrl url, bool createIntermediates, NSDictionary attributes, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr(base.SuperHandle, selCreateDirectoryAtURLWithIntermediateDirectoriesAttributesError_Handle, url.Handle, createIntermediates, attributes?.Handle ?? IntPtr.Zero, intPtr) : Messaging.bool_objc_msgSend_IntPtr_bool_IntPtr_IntPtr(base.Handle, selCreateDirectoryAtURLWithIntermediateDirectoriesAttributesError_Handle, url.Handle, createIntermediates, attributes?.Handle ?? IntPtr.Zero, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("createSymbolicLinkAtURL:withDestinationURL:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateSymbolicLinkAtURLWithDestinationURLError_Handle, url.Handle, destURL.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCreateSymbolicLinkAtURLWithDestinationURLError_Handle, url.Handle, destURL.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("setUbiquitous:itemAtURL:destinationURL:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_bool_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetUbiquitousItemAtURLDestinationURLError_Handle, flag, url.Handle, destinationUrl.Handle, intPtr) : Messaging.bool_objc_msgSend_bool_IntPtr_IntPtr_IntPtr(base.Handle, selSetUbiquitousItemAtURLDestinationURLError_Handle, flag, url.Handle, destinationUrl.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("isUbiquitousItemAtURL:")]
	public virtual bool IsUbiquitous(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsUbiquitousItemAtURL_Handle, url.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsUbiquitousItemAtURL_Handle, url.Handle);
	}

	[Export("startDownloadingUbiquitousItemAtURL:error:")]
	public virtual bool StartDownloadingUbiquitous(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartDownloadingUbiquitousItemAtURLError_Handle, url.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartDownloadingUbiquitousItemAtURLError_Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("evictUbiquitousItemAtURL:error:")]
	public virtual bool EvictUbiquitous(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEvictUbiquitousItemAtURLError_Handle, url.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selEvictUbiquitousItemAtURLError_Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("URLForUbiquityContainerIdentifier:")]
	public virtual NSUrl GetUrlForUbiquityContainer(string containerIdentifier)
	{
		IntPtr arg = NSString.CreateNative(containerIdentifier);
		NSUrl result = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLForUbiquityContainerIdentifier_Handle, arg))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLForUbiquityContainerIdentifier_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLForPublishingUbiquitousItemAtURL:expirationDate:error:")]
	public virtual NSUrl GetUrlForPublishingUbiquitousItem(NSUrl url, out NSDate expirationDate, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr intPtr2 = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr2, 0);
		NSUrl result = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selURLForPublishingUbiquitousItemAtURLExpirationDateError_Handle, url.Handle, intPtr, intPtr2))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selURLForPublishingUbiquitousItemAtURLExpirationDateError_Handle, url.Handle, intPtr, intPtr2))));
		IntPtr intPtr3 = Marshal.ReadIntPtr(intPtr);
		expirationDate = ((intPtr3 != IntPtr.Zero) ? ((NSDate)Runtime.GetNSObject(intPtr3)) : null);
		Marshal.FreeHGlobal(intPtr);
		IntPtr intPtr4 = Marshal.ReadIntPtr(intPtr2);
		error = ((intPtr4 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr4)) : null);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_UbiquityIdentityToken_var = null;
		}
	}
}
