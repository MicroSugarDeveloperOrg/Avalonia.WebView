using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSURL", true)]
public class NSUrl : NSObject
{
	private static readonly IntPtr selAbsoluteStringHandle = Selector.GetHandle("absoluteString");

	private static readonly IntPtr selAbsoluteURLHandle = Selector.GetHandle("absoluteURL");

	private static readonly IntPtr selBaseURLHandle = Selector.GetHandle("baseURL");

	private static readonly IntPtr selFragmentHandle = Selector.GetHandle("fragment");

	private static readonly IntPtr selHostHandle = Selector.GetHandle("host");

	private static readonly IntPtr selIsFileURLHandle = Selector.GetHandle("isFileURL");

	private static readonly IntPtr selParameterStringHandle = Selector.GetHandle("parameterString");

	private static readonly IntPtr selPasswordHandle = Selector.GetHandle("password");

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	private static readonly IntPtr selQueryHandle = Selector.GetHandle("query");

	private static readonly IntPtr selRelativePathHandle = Selector.GetHandle("relativePath");

	private static readonly IntPtr selRelativeStringHandle = Selector.GetHandle("relativeString");

	private static readonly IntPtr selResourceSpecifierHandle = Selector.GetHandle("resourceSpecifier");

	private static readonly IntPtr selSchemeHandle = Selector.GetHandle("scheme");

	private static readonly IntPtr selUserHandle = Selector.GetHandle("user");

	private static readonly IntPtr selStandardizedURLHandle = Selector.GetHandle("standardizedURL");

	private static readonly IntPtr selFilePathURLHandle = Selector.GetHandle("filePathURL");

	private static readonly IntPtr selFileReferenceURLHandle = Selector.GetHandle("fileReferenceURL");

	private static readonly IntPtr selInitWithSchemeHostPath_Handle = Selector.GetHandle("initWithScheme:host:path:");

	private static readonly IntPtr selInitFileURLWithPathIsDirectory_Handle = Selector.GetHandle("initFileURLWithPath:isDirectory:");

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	private static readonly IntPtr selInitWithStringRelativeToURL_Handle = Selector.GetHandle("initWithString:relativeToURL:");

	private static readonly IntPtr selURLWithString_Handle = Selector.GetHandle("URLWithString:");

	private static readonly IntPtr selURLWithStringRelativeToURL_Handle = Selector.GetHandle("URLWithString:relativeToURL:");

	private static readonly IntPtr selIsEqual_Handle = Selector.GetHandle("isEqual:");

	private static readonly IntPtr selURLByAppendingPathComponentIsDirectory_Handle = Selector.GetHandle("URLByAppendingPathComponent:isDirectory:");

	private static readonly IntPtr selURLFromPasteboard_Handle = Selector.GetHandle("URLFromPasteboard:");

	private static readonly IntPtr selWriteToPasteboard_Handle = Selector.GetHandle("writeToPasteboard:");

	private static readonly IntPtr selBookmarkDataWithContentsOfURLError_Handle = Selector.GetHandle("bookmarkDataWithContentsOfURL:error:");

	private static readonly IntPtr selURLByResolvingBookmarkDataOptionsRelativeToURLBookmarkDataIsStaleError_Handle = Selector.GetHandle("URLByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");

	private static readonly IntPtr selWriteBookmarkDataToURLOptionsError_Handle = Selector.GetHandle("writeBookmarkData:toURL:options:error:");

	private static readonly IntPtr selStartAccessingSecurityScopedResourceHandle = Selector.GetHandle("startAccessingSecurityScopedResource");

	private static readonly IntPtr selStopAccessingSecurityScopedResourceHandle = Selector.GetHandle("stopAccessingSecurityScopedResource");

	private static readonly IntPtr selGetResourceValueForKeyError_Handle = Selector.GetHandle("getResourceValue:forKey:error:");

	private static readonly IntPtr selResourceValuesForKeysError_Handle = Selector.GetHandle("resourceValuesForKeys:error:");

	private static readonly IntPtr selSetResourceValueForKeyError_Handle = Selector.GetHandle("setResourceValue:forKey:error:");

	private static readonly IntPtr selBookmarkDataWithOptionsIncludingResourceValuesForKeysRelativeToURLError_Handle = Selector.GetHandle("bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error:");

	private static readonly IntPtr selInitByResolvingBookmarkDataOptionsRelativeToURLBookmarkDataIsStaleError_Handle = Selector.GetHandle("initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURL");

	private object __mt_AbsoluteUrl_var;

	private object __mt_BaseUrl_var;

	private object __mt_StandardizedUrl_var;

	private object __mt_FilePathUrl_var;

	private object __mt_FileReferenceUrl_var;

	private static NSString _NameKey;

	private static NSString _LocalizedNameKey;

	private static NSString _IsRegularFileKey;

	private static NSString _IsDirectoryKey;

	private static NSString _IsSymbolicLinkKey;

	private static NSString _IsVolumeKey;

	private static NSString _IsPackageKey;

	private static NSString _IsSystemImmutableKey;

	private static NSString _IsUserImmutableKey;

	private static NSString _IsHiddenKey;

	private static NSString _HasHiddenExtensionKey;

	private static NSString _CreationDateKey;

	private static NSString _ContentAccessDateKey;

	private static NSString _ContentModificationDateKey;

	private static NSString _AttributeModificationDateKey;

	private static NSString _LinkCountKey;

	private static NSString _ParentDirectoryURLKey;

	private static NSString _VolumeURLKey;

	private static NSString _TypeIdentifierKey;

	private static NSString _LocalizedTypeDescriptionKey;

	private static NSString _LabelNumberKey;

	private static NSString _LabelColorKey;

	private static NSString _LocalizedLabelKey;

	private static NSString _EffectiveIconKey;

	private static NSString _CustomIconKey;

	private static NSString _FileSizeKey;

	private static NSString _FileAllocatedSizeKey;

	private static NSString _IsAliasFileKey;

	private static NSString _VolumeLocalizedFormatDescriptionKey;

	private static NSString _VolumeTotalCapacityKey;

	private static NSString _VolumeAvailableCapacityKey;

	private static NSString _VolumeResourceCountKey;

	private static NSString _VolumeSupportsPersistentIDsKey;

	private static NSString _VolumeSupportsSymbolicLinksKey;

	private static NSString _VolumeSupportsHardLinksKey;

	private static NSString _VolumeSupportsJournalingKey;

	private static NSString _VolumeIsJournalingKey;

	private static NSString _VolumeSupportsSparseFilesKey;

	private static NSString _VolumeSupportsZeroRunsKey;

	private static NSString _VolumeSupportsCaseSensitiveNamesKey;

	private static NSString _VolumeSupportsCasePreservedNamesKey;

	private static NSString _KeysOfUnsetValuesKey;

	private static NSString _FileResourceIdentifierKey;

	private static NSString _VolumeIdentifierKey;

	private static NSString _PreferredIOBlockSizeKey;

	private static NSString _IsReadableKey;

	private static NSString _IsWritableKey;

	private static NSString _IsExecutableKey;

	private static NSString _IsMountTriggerKey;

	private static NSString _FileSecurityKey;

	private static NSString _FileResourceTypeKey;

	private static NSString _FileResourceTypeNamedPipe;

	private static NSString _FileResourceTypeCharacterSpecial;

	private static NSString _FileResourceTypeDirectory;

	private static NSString _FileResourceTypeBlockSpecial;

	private static NSString _FileResourceTypeRegular;

	private static NSString _FileResourceTypeSymbolicLink;

	private static NSString _FileResourceTypeSocket;

	private static NSString _FileResourceTypeUnknown;

	private static NSString _TotalFileSizeKey;

	private static NSString _TotalFileAllocatedSizeKey;

	private static NSString _VolumeSupportsRootDirectoryDatesKey;

	private static NSString _VolumeSupportsVolumeSizesKey;

	private static NSString _VolumeSupportsRenamingKey;

	private static NSString _VolumeSupportsAdvisoryFileLockingKey;

	private static NSString _VolumeSupportsExtendedSecurityKey;

	private static NSString _VolumeIsBrowsableKey;

	private static NSString _VolumeMaximumFileSizeKey;

	private static NSString _VolumeIsEjectableKey;

	private static NSString _VolumeIsRemovableKey;

	private static NSString _VolumeIsInternalKey;

	private static NSString _VolumeIsAutomountedKey;

	private static NSString _VolumeIsLocalKey;

	private static NSString _VolumeIsReadOnlyKey;

	private static NSString _VolumeCreationDateKey;

	private static NSString _VolumeURLForRemountingKey;

	private static NSString _VolumeUUIDStringKey;

	private static NSString _VolumeNameKey;

	private static NSString _VolumeLocalizedNameKey;

	private static NSString _IsUbiquitousItemKey;

	private static NSString _UbiquitousItemHasUnresolvedConflictsKey;

	private static NSString _UbiquitousItemIsDownloadedKey;

	private static NSString _UbiquitousItemIsDownloadingKey;

	private static NSString _UbiquitousItemIsUploadedKey;

	private static NSString _UbiquitousItemIsUploadingKey;

	private static NSString _UbiquitousItemPercentDownloadedKey;

	private static NSString _UbiquitousItemPercentUploadedKey;

	private static NSString _IsExcludedFromBackupKey;

	private static NSString _PathKey;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string AbsoluteString
	{
		[Export("absoluteString")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAbsoluteStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAbsoluteStringHandle));
		}
	}

	public virtual NSUrl AbsoluteUrl
	{
		[Export("absoluteURL")]
		get
		{
			return (NSUrl)(__mt_AbsoluteUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAbsoluteURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAbsoluteURLHandle)))));
		}
	}

	public virtual NSUrl BaseUrl
	{
		[Export("baseURL")]
		get
		{
			return (NSUrl)(__mt_BaseUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBaseURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBaseURLHandle)))));
		}
	}

	public virtual string Fragment
	{
		[Export("fragment")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFragmentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFragmentHandle));
		}
	}

	public virtual string Host
	{
		[Export("host")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHostHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostHandle));
		}
	}

	public virtual bool IsFileUrl
	{
		[Export("isFileURL")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFileURLHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFileURLHandle);
		}
	}

	public virtual string ParameterString
	{
		[Export("parameterString")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selParameterStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParameterStringHandle));
		}
	}

	public virtual string Password
	{
		[Export("password")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPasswordHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPasswordHandle));
		}
	}

	public virtual string Path
	{
		[Export("path")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
		}
	}

	public virtual string Query
	{
		[Export("query")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selQueryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQueryHandle));
		}
	}

	public virtual string RelativePath
	{
		[Export("relativePath")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRelativePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelativePathHandle));
		}
	}

	public virtual string RelativeString
	{
		[Export("relativeString")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRelativeStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelativeStringHandle));
		}
	}

	public virtual string ResourceSpecifier
	{
		[Export("resourceSpecifier")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selResourceSpecifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourceSpecifierHandle));
		}
	}

	public virtual string Scheme
	{
		[Export("scheme")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSchemeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSchemeHandle));
		}
	}

	public virtual string User
	{
		[Export("user")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserHandle));
		}
	}

	public virtual NSUrl StandardizedUrl
	{
		[Export("standardizedURL")]
		get
		{
			return (NSUrl)(__mt_StandardizedUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardizedURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardizedURLHandle)))));
		}
	}

	public virtual NSUrl FilePathUrl
	{
		[Export("filePathURL")]
		get
		{
			return (NSUrl)(__mt_FilePathUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilePathURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFilePathURLHandle)))));
		}
	}

	public virtual NSUrl FileReferenceUrl
	{
		[Export("fileReferenceURL")]
		get
		{
			return (NSUrl)(__mt_FileReferenceUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileReferenceURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFileReferenceURLHandle)))));
		}
	}

	[Field("NSURLNameKey", "Foundation")]
	public static NSString NameKey
	{
		get
		{
			if (_NameKey == null)
			{
				_NameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLNameKey");
			}
			return _NameKey;
		}
	}

	[Field("NSURLLocalizedNameKey", "Foundation")]
	public static NSString LocalizedNameKey
	{
		get
		{
			if (_LocalizedNameKey == null)
			{
				_LocalizedNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLocalizedNameKey");
			}
			return _LocalizedNameKey;
		}
	}

	[Field("NSURLIsRegularFileKey", "Foundation")]
	public static NSString IsRegularFileKey
	{
		get
		{
			if (_IsRegularFileKey == null)
			{
				_IsRegularFileKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsRegularFileKey");
			}
			return _IsRegularFileKey;
		}
	}

	[Field("NSURLIsDirectoryKey", "Foundation")]
	public static NSString IsDirectoryKey
	{
		get
		{
			if (_IsDirectoryKey == null)
			{
				_IsDirectoryKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsDirectoryKey");
			}
			return _IsDirectoryKey;
		}
	}

	[Field("NSURLIsSymbolicLinkKey", "Foundation")]
	public static NSString IsSymbolicLinkKey
	{
		get
		{
			if (_IsSymbolicLinkKey == null)
			{
				_IsSymbolicLinkKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsSymbolicLinkKey");
			}
			return _IsSymbolicLinkKey;
		}
	}

	[Field("NSURLIsVolumeKey", "Foundation")]
	public static NSString IsVolumeKey
	{
		get
		{
			if (_IsVolumeKey == null)
			{
				_IsVolumeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsVolumeKey");
			}
			return _IsVolumeKey;
		}
	}

	[Field("NSURLIsPackageKey", "Foundation")]
	public static NSString IsPackageKey
	{
		get
		{
			if (_IsPackageKey == null)
			{
				_IsPackageKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsPackageKey");
			}
			return _IsPackageKey;
		}
	}

	[Field("NSURLIsSystemImmutableKey", "Foundation")]
	public static NSString IsSystemImmutableKey
	{
		get
		{
			if (_IsSystemImmutableKey == null)
			{
				_IsSystemImmutableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsSystemImmutableKey");
			}
			return _IsSystemImmutableKey;
		}
	}

	[Field("NSURLIsUserImmutableKey", "Foundation")]
	public static NSString IsUserImmutableKey
	{
		get
		{
			if (_IsUserImmutableKey == null)
			{
				_IsUserImmutableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsUserImmutableKey");
			}
			return _IsUserImmutableKey;
		}
	}

	[Field("NSURLIsHiddenKey", "Foundation")]
	public static NSString IsHiddenKey
	{
		get
		{
			if (_IsHiddenKey == null)
			{
				_IsHiddenKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsHiddenKey");
			}
			return _IsHiddenKey;
		}
	}

	[Field("NSURLHasHiddenExtensionKey", "Foundation")]
	public static NSString HasHiddenExtensionKey
	{
		get
		{
			if (_HasHiddenExtensionKey == null)
			{
				_HasHiddenExtensionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLHasHiddenExtensionKey");
			}
			return _HasHiddenExtensionKey;
		}
	}

	[Field("NSURLCreationDateKey", "Foundation")]
	public static NSString CreationDateKey
	{
		get
		{
			if (_CreationDateKey == null)
			{
				_CreationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLCreationDateKey");
			}
			return _CreationDateKey;
		}
	}

	[Field("NSURLContentAccessDateKey", "Foundation")]
	public static NSString ContentAccessDateKey
	{
		get
		{
			if (_ContentAccessDateKey == null)
			{
				_ContentAccessDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLContentAccessDateKey");
			}
			return _ContentAccessDateKey;
		}
	}

	[Field("NSURLContentModificationDateKey", "Foundation")]
	public static NSString ContentModificationDateKey
	{
		get
		{
			if (_ContentModificationDateKey == null)
			{
				_ContentModificationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLContentModificationDateKey");
			}
			return _ContentModificationDateKey;
		}
	}

	[Field("NSURLAttributeModificationDateKey", "Foundation")]
	public static NSString AttributeModificationDateKey
	{
		get
		{
			if (_AttributeModificationDateKey == null)
			{
				_AttributeModificationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAttributeModificationDateKey");
			}
			return _AttributeModificationDateKey;
		}
	}

	[Field("NSURLLinkCountKey", "Foundation")]
	public static NSString LinkCountKey
	{
		get
		{
			if (_LinkCountKey == null)
			{
				_LinkCountKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLinkCountKey");
			}
			return _LinkCountKey;
		}
	}

	[Field("NSURLParentDirectoryURLKey", "Foundation")]
	public static NSString ParentDirectoryURLKey
	{
		get
		{
			if (_ParentDirectoryURLKey == null)
			{
				_ParentDirectoryURLKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLParentDirectoryURLKey");
			}
			return _ParentDirectoryURLKey;
		}
	}

	[Field("NSURLVolumeURLKey", "Foundation")]
	public static NSString VolumeURLKey
	{
		get
		{
			if (_VolumeURLKey == null)
			{
				_VolumeURLKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeURLKey");
			}
			return _VolumeURLKey;
		}
	}

	[Field("NSURLTypeIdentifierKey", "Foundation")]
	public static NSString TypeIdentifierKey
	{
		get
		{
			if (_TypeIdentifierKey == null)
			{
				_TypeIdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLTypeIdentifierKey");
			}
			return _TypeIdentifierKey;
		}
	}

	[Field("NSURLLocalizedTypeDescriptionKey", "Foundation")]
	public static NSString LocalizedTypeDescriptionKey
	{
		get
		{
			if (_LocalizedTypeDescriptionKey == null)
			{
				_LocalizedTypeDescriptionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLocalizedTypeDescriptionKey");
			}
			return _LocalizedTypeDescriptionKey;
		}
	}

	[Field("NSURLLabelNumberKey", "Foundation")]
	public static NSString LabelNumberKey
	{
		get
		{
			if (_LabelNumberKey == null)
			{
				_LabelNumberKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLabelNumberKey");
			}
			return _LabelNumberKey;
		}
	}

	[Field("NSURLLabelColorKey", "Foundation")]
	public static NSString LabelColorKey
	{
		get
		{
			if (_LabelColorKey == null)
			{
				_LabelColorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLabelColorKey");
			}
			return _LabelColorKey;
		}
	}

	[Field("NSURLLocalizedLabelKey", "Foundation")]
	public static NSString LocalizedLabelKey
	{
		get
		{
			if (_LocalizedLabelKey == null)
			{
				_LocalizedLabelKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLocalizedLabelKey");
			}
			return _LocalizedLabelKey;
		}
	}

	[Field("NSURLEffectiveIconKey", "Foundation")]
	public static NSString EffectiveIconKey
	{
		get
		{
			if (_EffectiveIconKey == null)
			{
				_EffectiveIconKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLEffectiveIconKey");
			}
			return _EffectiveIconKey;
		}
	}

	[Field("NSURLCustomIconKey", "Foundation")]
	public static NSString CustomIconKey
	{
		get
		{
			if (_CustomIconKey == null)
			{
				_CustomIconKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLCustomIconKey");
			}
			return _CustomIconKey;
		}
	}

	[Field("NSURLFileSizeKey", "Foundation")]
	public static NSString FileSizeKey
	{
		get
		{
			if (_FileSizeKey == null)
			{
				_FileSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileSizeKey");
			}
			return _FileSizeKey;
		}
	}

	[Field("NSURLFileAllocatedSizeKey", "Foundation")]
	public static NSString FileAllocatedSizeKey
	{
		get
		{
			if (_FileAllocatedSizeKey == null)
			{
				_FileAllocatedSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileAllocatedSizeKey");
			}
			return _FileAllocatedSizeKey;
		}
	}

	[Field("NSURLIsAliasFileKey", "Foundation")]
	public static NSString IsAliasFileKey
	{
		get
		{
			if (_IsAliasFileKey == null)
			{
				_IsAliasFileKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsAliasFileKey");
			}
			return _IsAliasFileKey;
		}
	}

	[Field("NSURLVolumeLocalizedFormatDescriptionKey", "Foundation")]
	public static NSString VolumeLocalizedFormatDescriptionKey
	{
		get
		{
			if (_VolumeLocalizedFormatDescriptionKey == null)
			{
				_VolumeLocalizedFormatDescriptionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeLocalizedFormatDescriptionKey");
			}
			return _VolumeLocalizedFormatDescriptionKey;
		}
	}

	[Field("NSURLVolumeTotalCapacityKey", "Foundation")]
	public static NSString VolumeTotalCapacityKey
	{
		get
		{
			if (_VolumeTotalCapacityKey == null)
			{
				_VolumeTotalCapacityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeTotalCapacityKey");
			}
			return _VolumeTotalCapacityKey;
		}
	}

	[Field("NSURLVolumeAvailableCapacityKey", "Foundation")]
	public static NSString VolumeAvailableCapacityKey
	{
		get
		{
			if (_VolumeAvailableCapacityKey == null)
			{
				_VolumeAvailableCapacityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeAvailableCapacityKey");
			}
			return _VolumeAvailableCapacityKey;
		}
	}

	[Field("NSURLVolumeResourceCountKey", "Foundation")]
	public static NSString VolumeResourceCountKey
	{
		get
		{
			if (_VolumeResourceCountKey == null)
			{
				_VolumeResourceCountKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeResourceCountKey");
			}
			return _VolumeResourceCountKey;
		}
	}

	[Field("NSURLVolumeSupportsPersistentIDsKey", "Foundation")]
	public static NSString VolumeSupportsPersistentIDsKey
	{
		get
		{
			if (_VolumeSupportsPersistentIDsKey == null)
			{
				_VolumeSupportsPersistentIDsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsPersistentIDsKey");
			}
			return _VolumeSupportsPersistentIDsKey;
		}
	}

	[Field("NSURLVolumeSupportsSymbolicLinksKey", "Foundation")]
	public static NSString VolumeSupportsSymbolicLinksKey
	{
		get
		{
			if (_VolumeSupportsSymbolicLinksKey == null)
			{
				_VolumeSupportsSymbolicLinksKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsSymbolicLinksKey");
			}
			return _VolumeSupportsSymbolicLinksKey;
		}
	}

	[Field("NSURLVolumeSupportsHardLinksKey", "Foundation")]
	public static NSString VolumeSupportsHardLinksKey
	{
		get
		{
			if (_VolumeSupportsHardLinksKey == null)
			{
				_VolumeSupportsHardLinksKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsHardLinksKey");
			}
			return _VolumeSupportsHardLinksKey;
		}
	}

	[Field("NSURLVolumeSupportsJournalingKey", "Foundation")]
	public static NSString VolumeSupportsJournalingKey
	{
		get
		{
			if (_VolumeSupportsJournalingKey == null)
			{
				_VolumeSupportsJournalingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsJournalingKey");
			}
			return _VolumeSupportsJournalingKey;
		}
	}

	[Field("NSURLVolumeIsJournalingKey", "Foundation")]
	public static NSString VolumeIsJournalingKey
	{
		get
		{
			if (_VolumeIsJournalingKey == null)
			{
				_VolumeIsJournalingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsJournalingKey");
			}
			return _VolumeIsJournalingKey;
		}
	}

	[Field("NSURLVolumeSupportsSparseFilesKey", "Foundation")]
	public static NSString VolumeSupportsSparseFilesKey
	{
		get
		{
			if (_VolumeSupportsSparseFilesKey == null)
			{
				_VolumeSupportsSparseFilesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsSparseFilesKey");
			}
			return _VolumeSupportsSparseFilesKey;
		}
	}

	[Field("NSURLVolumeSupportsZeroRunsKey", "Foundation")]
	public static NSString VolumeSupportsZeroRunsKey
	{
		get
		{
			if (_VolumeSupportsZeroRunsKey == null)
			{
				_VolumeSupportsZeroRunsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsZeroRunsKey");
			}
			return _VolumeSupportsZeroRunsKey;
		}
	}

	[Field("NSURLVolumeSupportsCaseSensitiveNamesKey", "Foundation")]
	public static NSString VolumeSupportsCaseSensitiveNamesKey
	{
		get
		{
			if (_VolumeSupportsCaseSensitiveNamesKey == null)
			{
				_VolumeSupportsCaseSensitiveNamesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsCaseSensitiveNamesKey");
			}
			return _VolumeSupportsCaseSensitiveNamesKey;
		}
	}

	[Field("NSURLVolumeSupportsCasePreservedNamesKey", "Foundation")]
	public static NSString VolumeSupportsCasePreservedNamesKey
	{
		get
		{
			if (_VolumeSupportsCasePreservedNamesKey == null)
			{
				_VolumeSupportsCasePreservedNamesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsCasePreservedNamesKey");
			}
			return _VolumeSupportsCasePreservedNamesKey;
		}
	}

	[Field("NSURLKeysOfUnsetValuesKey", "Foundation")]
	public static NSString KeysOfUnsetValuesKey
	{
		get
		{
			if (_KeysOfUnsetValuesKey == null)
			{
				_KeysOfUnsetValuesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLKeysOfUnsetValuesKey");
			}
			return _KeysOfUnsetValuesKey;
		}
	}

	[Field("NSURLFileResourceIdentifierKey", "Foundation")]
	public static NSString FileResourceIdentifierKey
	{
		get
		{
			if (_FileResourceIdentifierKey == null)
			{
				_FileResourceIdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceIdentifierKey");
			}
			return _FileResourceIdentifierKey;
		}
	}

	[Field("NSURLVolumeIdentifierKey", "Foundation")]
	public static NSString VolumeIdentifierKey
	{
		get
		{
			if (_VolumeIdentifierKey == null)
			{
				_VolumeIdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIdentifierKey");
			}
			return _VolumeIdentifierKey;
		}
	}

	[Field("NSURLPreferredIOBlockSizeKey", "Foundation")]
	public static NSString PreferredIOBlockSizeKey
	{
		get
		{
			if (_PreferredIOBlockSizeKey == null)
			{
				_PreferredIOBlockSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLPreferredIOBlockSizeKey");
			}
			return _PreferredIOBlockSizeKey;
		}
	}

	[Field("NSURLIsReadableKey", "Foundation")]
	public static NSString IsReadableKey
	{
		get
		{
			if (_IsReadableKey == null)
			{
				_IsReadableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsReadableKey");
			}
			return _IsReadableKey;
		}
	}

	[Field("NSURLIsWritableKey", "Foundation")]
	public static NSString IsWritableKey
	{
		get
		{
			if (_IsWritableKey == null)
			{
				_IsWritableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsWritableKey");
			}
			return _IsWritableKey;
		}
	}

	[Field("NSURLIsExecutableKey", "Foundation")]
	public static NSString IsExecutableKey
	{
		get
		{
			if (_IsExecutableKey == null)
			{
				_IsExecutableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsExecutableKey");
			}
			return _IsExecutableKey;
		}
	}

	[Field("NSURLIsMountTriggerKey", "Foundation")]
	public static NSString IsMountTriggerKey
	{
		get
		{
			if (_IsMountTriggerKey == null)
			{
				_IsMountTriggerKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsMountTriggerKey");
			}
			return _IsMountTriggerKey;
		}
	}

	[Field("NSURLFileSecurityKey", "Foundation")]
	public static NSString FileSecurityKey
	{
		get
		{
			if (_FileSecurityKey == null)
			{
				_FileSecurityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileSecurityKey");
			}
			return _FileSecurityKey;
		}
	}

	[Field("NSURLFileResourceTypeKey", "Foundation")]
	public static NSString FileResourceTypeKey
	{
		get
		{
			if (_FileResourceTypeKey == null)
			{
				_FileResourceTypeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeKey");
			}
			return _FileResourceTypeKey;
		}
	}

	[Field("NSURLFileResourceTypeNamedPipe", "Foundation")]
	public static NSString FileResourceTypeNamedPipe
	{
		get
		{
			if (_FileResourceTypeNamedPipe == null)
			{
				_FileResourceTypeNamedPipe = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeNamedPipe");
			}
			return _FileResourceTypeNamedPipe;
		}
	}

	[Field("NSURLFileResourceTypeCharacterSpecial", "Foundation")]
	public static NSString FileResourceTypeCharacterSpecial
	{
		get
		{
			if (_FileResourceTypeCharacterSpecial == null)
			{
				_FileResourceTypeCharacterSpecial = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeCharacterSpecial");
			}
			return _FileResourceTypeCharacterSpecial;
		}
	}

	[Field("NSURLFileResourceTypeDirectory", "Foundation")]
	public static NSString FileResourceTypeDirectory
	{
		get
		{
			if (_FileResourceTypeDirectory == null)
			{
				_FileResourceTypeDirectory = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeDirectory");
			}
			return _FileResourceTypeDirectory;
		}
	}

	[Field("NSURLFileResourceTypeBlockSpecial", "Foundation")]
	public static NSString FileResourceTypeBlockSpecial
	{
		get
		{
			if (_FileResourceTypeBlockSpecial == null)
			{
				_FileResourceTypeBlockSpecial = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeBlockSpecial");
			}
			return _FileResourceTypeBlockSpecial;
		}
	}

	[Field("NSURLFileResourceTypeRegular", "Foundation")]
	public static NSString FileResourceTypeRegular
	{
		get
		{
			if (_FileResourceTypeRegular == null)
			{
				_FileResourceTypeRegular = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeRegular");
			}
			return _FileResourceTypeRegular;
		}
	}

	[Field("NSURLFileResourceTypeSymbolicLink", "Foundation")]
	public static NSString FileResourceTypeSymbolicLink
	{
		get
		{
			if (_FileResourceTypeSymbolicLink == null)
			{
				_FileResourceTypeSymbolicLink = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeSymbolicLink");
			}
			return _FileResourceTypeSymbolicLink;
		}
	}

	[Field("NSURLFileResourceTypeSocket", "Foundation")]
	public static NSString FileResourceTypeSocket
	{
		get
		{
			if (_FileResourceTypeSocket == null)
			{
				_FileResourceTypeSocket = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeSocket");
			}
			return _FileResourceTypeSocket;
		}
	}

	[Field("NSURLFileResourceTypeUnknown", "Foundation")]
	public static NSString FileResourceTypeUnknown
	{
		get
		{
			if (_FileResourceTypeUnknown == null)
			{
				_FileResourceTypeUnknown = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeUnknown");
			}
			return _FileResourceTypeUnknown;
		}
	}

	[Field("NSURLTotalFileSizeKey", "Foundation")]
	public static NSString TotalFileSizeKey
	{
		get
		{
			if (_TotalFileSizeKey == null)
			{
				_TotalFileSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLTotalFileSizeKey");
			}
			return _TotalFileSizeKey;
		}
	}

	[Field("NSURLTotalFileAllocatedSizeKey", "Foundation")]
	public static NSString TotalFileAllocatedSizeKey
	{
		get
		{
			if (_TotalFileAllocatedSizeKey == null)
			{
				_TotalFileAllocatedSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLTotalFileAllocatedSizeKey");
			}
			return _TotalFileAllocatedSizeKey;
		}
	}

	[Field("NSURLVolumeSupportsRootDirectoryDatesKey", "Foundation")]
	public static NSString VolumeSupportsRootDirectoryDatesKey
	{
		get
		{
			if (_VolumeSupportsRootDirectoryDatesKey == null)
			{
				_VolumeSupportsRootDirectoryDatesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsRootDirectoryDatesKey");
			}
			return _VolumeSupportsRootDirectoryDatesKey;
		}
	}

	[Field("NSURLVolumeSupportsVolumeSizesKey", "Foundation")]
	public static NSString VolumeSupportsVolumeSizesKey
	{
		get
		{
			if (_VolumeSupportsVolumeSizesKey == null)
			{
				_VolumeSupportsVolumeSizesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsVolumeSizesKey");
			}
			return _VolumeSupportsVolumeSizesKey;
		}
	}

	[Field("NSURLVolumeSupportsRenamingKey", "Foundation")]
	public static NSString VolumeSupportsRenamingKey
	{
		get
		{
			if (_VolumeSupportsRenamingKey == null)
			{
				_VolumeSupportsRenamingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsRenamingKey");
			}
			return _VolumeSupportsRenamingKey;
		}
	}

	[Field("NSURLVolumeSupportsAdvisoryFileLockingKey", "Foundation")]
	public static NSString VolumeSupportsAdvisoryFileLockingKey
	{
		get
		{
			if (_VolumeSupportsAdvisoryFileLockingKey == null)
			{
				_VolumeSupportsAdvisoryFileLockingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsAdvisoryFileLockingKey");
			}
			return _VolumeSupportsAdvisoryFileLockingKey;
		}
	}

	[Field("NSURLVolumeSupportsExtendedSecurityKey", "Foundation")]
	public static NSString VolumeSupportsExtendedSecurityKey
	{
		get
		{
			if (_VolumeSupportsExtendedSecurityKey == null)
			{
				_VolumeSupportsExtendedSecurityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsExtendedSecurityKey");
			}
			return _VolumeSupportsExtendedSecurityKey;
		}
	}

	[Field("NSURLVolumeIsBrowsableKey", "Foundation")]
	public static NSString VolumeIsBrowsableKey
	{
		get
		{
			if (_VolumeIsBrowsableKey == null)
			{
				_VolumeIsBrowsableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsBrowsableKey");
			}
			return _VolumeIsBrowsableKey;
		}
	}

	[Field("NSURLVolumeMaximumFileSizeKey", "Foundation")]
	public static NSString VolumeMaximumFileSizeKey
	{
		get
		{
			if (_VolumeMaximumFileSizeKey == null)
			{
				_VolumeMaximumFileSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeMaximumFileSizeKey");
			}
			return _VolumeMaximumFileSizeKey;
		}
	}

	[Field("NSURLVolumeIsEjectableKey", "Foundation")]
	public static NSString VolumeIsEjectableKey
	{
		get
		{
			if (_VolumeIsEjectableKey == null)
			{
				_VolumeIsEjectableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsEjectableKey");
			}
			return _VolumeIsEjectableKey;
		}
	}

	[Field("NSURLVolumeIsRemovableKey", "Foundation")]
	public static NSString VolumeIsRemovableKey
	{
		get
		{
			if (_VolumeIsRemovableKey == null)
			{
				_VolumeIsRemovableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsRemovableKey");
			}
			return _VolumeIsRemovableKey;
		}
	}

	[Field("NSURLVolumeIsInternalKey", "Foundation")]
	public static NSString VolumeIsInternalKey
	{
		get
		{
			if (_VolumeIsInternalKey == null)
			{
				_VolumeIsInternalKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsInternalKey");
			}
			return _VolumeIsInternalKey;
		}
	}

	[Field("NSURLVolumeIsAutomountedKey", "Foundation")]
	public static NSString VolumeIsAutomountedKey
	{
		get
		{
			if (_VolumeIsAutomountedKey == null)
			{
				_VolumeIsAutomountedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsAutomountedKey");
			}
			return _VolumeIsAutomountedKey;
		}
	}

	[Field("NSURLVolumeIsLocalKey", "Foundation")]
	public static NSString VolumeIsLocalKey
	{
		get
		{
			if (_VolumeIsLocalKey == null)
			{
				_VolumeIsLocalKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsLocalKey");
			}
			return _VolumeIsLocalKey;
		}
	}

	[Field("NSURLVolumeIsReadOnlyKey", "Foundation")]
	public static NSString VolumeIsReadOnlyKey
	{
		get
		{
			if (_VolumeIsReadOnlyKey == null)
			{
				_VolumeIsReadOnlyKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsReadOnlyKey");
			}
			return _VolumeIsReadOnlyKey;
		}
	}

	[Field("NSURLVolumeCreationDateKey", "Foundation")]
	public static NSString VolumeCreationDateKey
	{
		get
		{
			if (_VolumeCreationDateKey == null)
			{
				_VolumeCreationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeCreationDateKey");
			}
			return _VolumeCreationDateKey;
		}
	}

	[Field("NSURLVolumeURLForRemountingKey", "Foundation")]
	public static NSString VolumeURLForRemountingKey
	{
		get
		{
			if (_VolumeURLForRemountingKey == null)
			{
				_VolumeURLForRemountingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeURLForRemountingKey");
			}
			return _VolumeURLForRemountingKey;
		}
	}

	[Field("NSURLVolumeUUIDStringKey", "Foundation")]
	public static NSString VolumeUUIDStringKey
	{
		get
		{
			if (_VolumeUUIDStringKey == null)
			{
				_VolumeUUIDStringKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeUUIDStringKey");
			}
			return _VolumeUUIDStringKey;
		}
	}

	[Field("NSURLVolumeNameKey", "Foundation")]
	public static NSString VolumeNameKey
	{
		get
		{
			if (_VolumeNameKey == null)
			{
				_VolumeNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeNameKey");
			}
			return _VolumeNameKey;
		}
	}

	[Field("NSURLVolumeLocalizedNameKey", "Foundation")]
	public static NSString VolumeLocalizedNameKey
	{
		get
		{
			if (_VolumeLocalizedNameKey == null)
			{
				_VolumeLocalizedNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeLocalizedNameKey");
			}
			return _VolumeLocalizedNameKey;
		}
	}

	[Field("NSURLIsUbiquitousItemKey", "Foundation")]
	public static NSString IsUbiquitousItemKey
	{
		get
		{
			if (_IsUbiquitousItemKey == null)
			{
				_IsUbiquitousItemKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsUbiquitousItemKey");
			}
			return _IsUbiquitousItemKey;
		}
	}

	[Field("NSURLUbiquitousItemHasUnresolvedConflictsKey", "Foundation")]
	public static NSString UbiquitousItemHasUnresolvedConflictsKey
	{
		get
		{
			if (_UbiquitousItemHasUnresolvedConflictsKey == null)
			{
				_UbiquitousItemHasUnresolvedConflictsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemHasUnresolvedConflictsKey");
			}
			return _UbiquitousItemHasUnresolvedConflictsKey;
		}
	}

	[Field("NSURLUbiquitousItemIsDownloadedKey", "Foundation")]
	public static NSString UbiquitousItemIsDownloadedKey
	{
		get
		{
			if (_UbiquitousItemIsDownloadedKey == null)
			{
				_UbiquitousItemIsDownloadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemIsDownloadedKey");
			}
			return _UbiquitousItemIsDownloadedKey;
		}
	}

	[Field("NSURLUbiquitousItemIsDownloadingKey", "Foundation")]
	public static NSString UbiquitousItemIsDownloadingKey
	{
		get
		{
			if (_UbiquitousItemIsDownloadingKey == null)
			{
				_UbiquitousItemIsDownloadingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemIsDownloadingKey");
			}
			return _UbiquitousItemIsDownloadingKey;
		}
	}

	[Field("NSURLUbiquitousItemIsUploadedKey", "Foundation")]
	public static NSString UbiquitousItemIsUploadedKey
	{
		get
		{
			if (_UbiquitousItemIsUploadedKey == null)
			{
				_UbiquitousItemIsUploadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemIsUploadedKey");
			}
			return _UbiquitousItemIsUploadedKey;
		}
	}

	[Field("NSURLUbiquitousItemIsUploadingKey", "Foundation")]
	public static NSString UbiquitousItemIsUploadingKey
	{
		get
		{
			if (_UbiquitousItemIsUploadingKey == null)
			{
				_UbiquitousItemIsUploadingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemIsUploadingKey");
			}
			return _UbiquitousItemIsUploadingKey;
		}
	}

	[Field("NSURLUbiquitousItemPercentDownloadedKey", "Foundation")]
	public static NSString UbiquitousItemPercentDownloadedKey
	{
		get
		{
			if (_UbiquitousItemPercentDownloadedKey == null)
			{
				_UbiquitousItemPercentDownloadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemPercentDownloadedKey");
			}
			return _UbiquitousItemPercentDownloadedKey;
		}
	}

	[Field("NSURLUbiquitousItemPercentUploadedKey", "Foundation")]
	public static NSString UbiquitousItemPercentUploadedKey
	{
		get
		{
			if (_UbiquitousItemPercentUploadedKey == null)
			{
				_UbiquitousItemPercentUploadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemPercentUploadedKey");
			}
			return _UbiquitousItemPercentUploadedKey;
		}
	}

	[Field("NSURLIsExcludedFromBackupKey", "Foundation")]
	[MountainLion]
	public static NSString IsExcludedFromBackupKey
	{
		[MountainLion]
		get
		{
			if (_IsExcludedFromBackupKey == null)
			{
				_IsExcludedFromBackupKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsExcludedFromBackupKey");
			}
			return _IsExcludedFromBackupKey;
		}
	}

	[Field("NSURLPathKey", "Foundation")]
	[MountainLion]
	public static NSString PathKey
	{
		[MountainLion]
		get
		{
			if (_PathKey == null)
			{
				_PathKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLPathKey");
			}
			return _PathKey;
		}
	}

	public NSUrl(string path, string relativeToUrl)
		: this(path, new NSUrl(relativeToUrl))
	{
	}

	public override bool Equals(object t)
	{
		if (t == null)
		{
			return false;
		}
		if (t is NSUrl)
		{
			return IsEqual((NSUrl)t);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (int)base.Handle;
	}

	public static NSUrl FromFilename(string url)
	{
		return new NSUrl(url, isDir: false);
	}

	public NSUrl MakeRelative(string url)
	{
		return _FromStringRelative(url, this);
	}

	public override string ToString()
	{
		return AbsoluteString ?? base.ToString();
	}

	public bool TryGetResource(string key, out NSObject value, out NSError error)
	{
		return GetResourceValue(out value, key, out error);
	}

	public bool TryGetResource(string key, out NSObject value)
	{
		NSError error;
		return GetResourceValue(out value, key, out error);
	}

	public bool SetResource(string key, NSObject value, out NSError error)
	{
		return SetResourceValue(value, key, out error);
	}

	public bool SetResource(string key, NSObject value)
	{
		NSError error;
		return SetResourceValue(value, key, out error);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrl(NSCoder coder)
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
	public NSUrl(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrl(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithScheme:host:path:")]
	public NSUrl(string scheme, string host, string path)
		: base(NSObjectFlag.Empty)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(scheme);
		IntPtr arg2 = NSString.CreateNative(host);
		IntPtr arg3 = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSchemeHostPath_Handle, arg, arg2, arg3);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSchemeHostPath_Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("initFileURLWithPath:isDirectory:")]
	public NSUrl(string path, bool isDir)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitFileURLWithPathIsDirectory_Handle, arg, isDir);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitFileURLWithPathIsDirectory_Handle, arg, isDir);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:")]
	public NSUrl(string path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:relativeToURL:")]
	public NSUrl(string path, NSUrl relativeToUrl)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (relativeToUrl == null)
		{
			throw new ArgumentNullException("relativeToUrl");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithStringRelativeToURL_Handle, arg, relativeToUrl.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithStringRelativeToURL_Handle, arg, relativeToUrl.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("URLWithString:")]
	public static NSUrl FromString(string s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		IntPtr arg = NSString.CreateNative(s);
		NSUrl result = (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selURLWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLWithString:relativeToURL:")]
	internal static NSUrl _FromStringRelative(string url, NSUrl relative)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (relative == null)
		{
			throw new ArgumentNullException("relative");
		}
		IntPtr arg = NSString.CreateNative(url);
		NSUrl result = (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selURLWithStringRelativeToURL_Handle, arg, relative.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isEqual:")]
	public virtual bool IsEqual(NSUrl other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqual_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqual_Handle, other.Handle);
	}

	[Export("URLByAppendingPathComponent:isDirectory:")]
	public virtual NSUrl Append(string pathComponent, bool isDirectory)
	{
		if (pathComponent == null)
		{
			throw new ArgumentNullException("pathComponent");
		}
		IntPtr arg = NSString.CreateNative(pathComponent);
		NSUrl result = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selURLByAppendingPathComponentIsDirectory_Handle, arg, isDirectory))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selURLByAppendingPathComponentIsDirectory_Handle, arg, isDirectory))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLFromPasteboard:")]
	public static NSUrl FromPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selURLFromPasteboard_Handle, pasteboard.Handle));
	}

	[Export("writeToPasteboard:")]
	public virtual void WriteToPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWriteToPasteboard_Handle, pasteboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToPasteboard_Handle, pasteboard.Handle);
		}
	}

	[Export("bookmarkDataWithContentsOfURL:error:")]
	public static NSData GetBookmarkData(NSUrl bookmarkFileUrl, out NSError error)
	{
		if (bookmarkFileUrl == null)
		{
			throw new ArgumentNullException("bookmarkFileUrl");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSData result = (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selBookmarkDataWithContentsOfURLError_Handle, bookmarkFileUrl.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("URLByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:")]
	public static NSUrl FromBookmarkData(NSData data, NSUrlBookmarkResolutionOptions options, NSUrl relativeToUrl, out bool isStale, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSUrl result = (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_out_Boolean_IntPtr(class_ptr, selURLByResolvingBookmarkDataOptionsRelativeToURLBookmarkDataIsStaleError_Handle, data.Handle, (ulong)options, relativeToUrl?.Handle ?? IntPtr.Zero, out isStale, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("writeBookmarkData:toURL:options:error:")]
	public static bool WriteBookmarkData(NSData data, NSUrl bookmarkFileUrl, NSUrlBookmarkCreationOptions options, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (bookmarkFileUrl == null)
		{
			throw new ArgumentNullException("bookmarkFileUrl");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(class_ptr, selWriteBookmarkDataToURLOptionsError_Handle, data.Handle, bookmarkFileUrl.Handle, (ulong)options, intPtr);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("startAccessingSecurityScopedResource")]
	public virtual bool StartAccessingSecurityScopedResource()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStartAccessingSecurityScopedResourceHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStartAccessingSecurityScopedResourceHandle);
	}

	[Export("stopAccessingSecurityScopedResource")]
	public virtual void StopAccessingSecurityScopedResource()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopAccessingSecurityScopedResourceHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopAccessingSecurityScopedResourceHandle);
		}
	}

	[Export("getResourceValue:forKey:error:")]
	internal virtual bool GetResourceValue(out NSObject value, string key, out NSError error)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr2 = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr2, 0);
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGetResourceValueForKeyError_Handle, intPtr, arg, intPtr2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selGetResourceValueForKeyError_Handle, intPtr, arg, intPtr2));
		NSString.ReleaseNative(arg);
		IntPtr intPtr3 = Marshal.ReadIntPtr(intPtr);
		value = ((intPtr3 != IntPtr.Zero) ? Runtime.GetNSObject(intPtr3) : null);
		Marshal.FreeHGlobal(intPtr);
		IntPtr intPtr4 = Marshal.ReadIntPtr(intPtr2);
		error = ((intPtr4 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr4)) : null);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	[Export("resourceValuesForKeys:error:")]
	public virtual NSDictionary GetResourceValues(NSString[] keys, out NSError error)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSArray nSArray = NSArray.FromNSObjects(keys);
		NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selResourceValuesForKeysError_Handle, nSArray.Handle, intPtr))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selResourceValuesForKeysError_Handle, nSArray.Handle, intPtr))));
		nSArray.Dispose();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("setResourceValue:forKey:error:")]
	internal virtual bool SetResourceValue(NSObject value, string key, out NSError error)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetResourceValueForKeyError_Handle, value.Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetResourceValueForKeyError_Handle, value.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error:")]
	public virtual NSData CreateBookmarkData(NSUrlBookmarkCreationOptions options, string[] resourceValues, NSUrl relativeUrl, out NSError error)
	{
		if (resourceValues == null)
		{
			throw new ArgumentNullException("resourceValues");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSArray nSArray = NSArray.FromStrings(resourceValues);
		NSData result = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBookmarkDataWithOptionsIncludingResourceValuesForKeysRelativeToURLError_Handle, (ulong)options, nSArray.Handle, relativeUrl?.Handle ?? IntPtr.Zero, intPtr))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr(base.Handle, selBookmarkDataWithOptionsIncludingResourceValuesForKeysRelativeToURLError_Handle, (ulong)options, nSArray.Handle, relativeUrl?.Handle ?? IntPtr.Zero, intPtr))));
		nSArray.Dispose();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:")]
	public NSUrl(NSData bookmarkData, NSUrlBookmarkResolutionOptions resolutionOptions, NSUrl relativeUrl, out bool bookmarkIsStale, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (bookmarkData == null)
		{
			throw new ArgumentNullException("bookmarkData");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_out_Boolean_IntPtr(base.Handle, selInitByResolvingBookmarkDataOptionsRelativeToURLBookmarkDataIsStaleError_Handle, bookmarkData.Handle, (ulong)resolutionOptions, relativeUrl?.Handle ?? IntPtr.Zero, out bookmarkIsStale, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_out_Boolean_IntPtr(base.SuperHandle, selInitByResolvingBookmarkDataOptionsRelativeToURLBookmarkDataIsStaleError_Handle, bookmarkData.Handle, (ulong)resolutionOptions, relativeUrl?.Handle ?? IntPtr.Zero, out bookmarkIsStale, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AbsoluteUrl_var = null;
			__mt_BaseUrl_var = null;
			__mt_StandardizedUrl_var = null;
			__mt_FilePathUrl_var = null;
			__mt_FileReferenceUrl_var = null;
		}
	}
}
