using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

public static class NSFileProviderItem_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileProviderItemCapabilities GetCapabilities(this INSFileProviderItem This)
	{
		return (NSFileProviderItemCapabilities)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("capabilities"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber? GetDocumentSize(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("documentSize")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber? GetChildItemCount(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("childItemCount")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDate? GetCreationDate(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("creationDate")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDate? GetContentModificationDate(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("contentModificationDate")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDate? GetLastUsedDate(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("lastUsedDate")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetTagData(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("tagData")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber? GetFavoriteRank(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("favoriteRank")));
	}

	[Obsolete("'IsTrashed' is not available in macOS and will be removed in the future.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsTrashed(this INSFileProviderItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isTrashed"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsUploaded(this INSFileProviderItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isUploaded"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsUploading(this INSFileProviderItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isUploading"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSError? GetUploadingError(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("uploadingError")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsDownloaded(this INSFileProviderItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isDownloaded"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsDownloading(this INSFileProviderItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isDownloading"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSError? GetDownloadingError(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("downloadingError")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsMostRecentVersionDownloaded(this INSFileProviderItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isMostRecentVersionDownloaded"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsShared(this INSFileProviderItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isShared"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsSharedByCurrentUser(this INSFileProviderItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isSharedByCurrentUser"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersonNameComponents? GetOwnerNameComponents(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("ownerNameComponents")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersonNameComponents? GetMostRecentEditorNameComponents(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("mostRecentEditorNameComponents")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary? GetUserInfo(this INSFileProviderItem This)
	{
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("userInfo")));
	}
}
