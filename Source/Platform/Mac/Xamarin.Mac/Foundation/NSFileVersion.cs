using System;
using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileVersion", true)]
public class NSFileVersion : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddVersionOfItemAtURL_WithContentsOfURL_Options_Error_ = "addVersionOfItemAtURL:withContentsOfURL:options:error:";

	private static readonly IntPtr selAddVersionOfItemAtURL_WithContentsOfURL_Options_Error_Handle = Selector.GetHandle("addVersionOfItemAtURL:withContentsOfURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentVersionOfItemAtURL_ = "currentVersionOfItemAtURL:";

	private static readonly IntPtr selCurrentVersionOfItemAtURL_Handle = Selector.GetHandle("currentVersionOfItemAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetNonlocalVersionsOfItemAtURL_CompletionHandler_ = "getNonlocalVersionsOfItemAtURL:completionHandler:";

	private static readonly IntPtr selGetNonlocalVersionsOfItemAtURL_CompletionHandler_Handle = Selector.GetHandle("getNonlocalVersionsOfItemAtURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasLocalContents = "hasLocalContents";

	private static readonly IntPtr selHasLocalContentsHandle = Selector.GetHandle("hasLocalContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasThumbnail = "hasThumbnail";

	private static readonly IntPtr selHasThumbnailHandle = Selector.GetHandle("hasThumbnail");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsConflict = "isConflict";

	private static readonly IntPtr selIsConflictHandle = Selector.GetHandle("isConflict");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDiscardable = "isDiscardable";

	private static readonly IntPtr selIsDiscardableHandle = Selector.GetHandle("isDiscardable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsResolved = "isResolved";

	private static readonly IntPtr selIsResolvedHandle = Selector.GetHandle("isResolved");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedName = "localizedName";

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedNameOfSavingComputer = "localizedNameOfSavingComputer";

	private static readonly IntPtr selLocalizedNameOfSavingComputerHandle = Selector.GetHandle("localizedNameOfSavingComputer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModificationDate = "modificationDate";

	private static readonly IntPtr selModificationDateHandle = Selector.GetHandle("modificationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOriginatorNameComponents = "originatorNameComponents";

	private static readonly IntPtr selOriginatorNameComponentsHandle = Selector.GetHandle("originatorNameComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOtherVersionsOfItemAtURL_ = "otherVersionsOfItemAtURL:";

	private static readonly IntPtr selOtherVersionsOfItemAtURL_Handle = Selector.GetHandle("otherVersionsOfItemAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentIdentifier = "persistentIdentifier";

	private static readonly IntPtr selPersistentIdentifierHandle = Selector.GetHandle("persistentIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAndReturnError_ = "removeAndReturnError:";

	private static readonly IntPtr selRemoveAndReturnError_Handle = Selector.GetHandle("removeAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveOtherVersionsOfItemAtURL_Error_ = "removeOtherVersionsOfItemAtURL:error:";

	private static readonly IntPtr selRemoveOtherVersionsOfItemAtURL_Error_Handle = Selector.GetHandle("removeOtherVersionsOfItemAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceItemAtURL_Options_Error_ = "replaceItemAtURL:options:error:";

	private static readonly IntPtr selReplaceItemAtURL_Options_Error_Handle = Selector.GetHandle("replaceItemAtURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDiscardable_ = "setDiscardable:";

	private static readonly IntPtr selSetDiscardable_Handle = Selector.GetHandle("setDiscardable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResolved_ = "setResolved:";

	private static readonly IntPtr selSetResolved_Handle = Selector.GetHandle("setResolved:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryDirectoryURLForNewVersionOfItemAtURL_ = "temporaryDirectoryURLForNewVersionOfItemAtURL:";

	private static readonly IntPtr selTemporaryDirectoryURLForNewVersionOfItemAtURL_Handle = Selector.GetHandle("temporaryDirectoryURLForNewVersionOfItemAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnresolvedConflictVersionsOfItemAtURL_ = "unresolvedConflictVersionsOfItemAtURL:";

	private static readonly IntPtr selUnresolvedConflictVersionsOfItemAtURL_Handle = Selector.GetHandle("unresolvedConflictVersionsOfItemAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersionOfItemAtURL_ForPersistentIdentifier_ = "versionOfItemAtURL:forPersistentIdentifier:";

	private static readonly IntPtr selVersionOfItemAtURL_ForPersistentIdentifier_Handle = Selector.GetHandle("versionOfItemAtURL:forPersistentIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFileVersion");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Discardable
	{
		[Export("isDiscardable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDiscardableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDiscardableHandle);
		}
		[Export("setDiscardable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDiscardable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDiscardable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual bool HasLocalContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("hasLocalContents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasLocalContentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasLocalContentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual bool HasThumbnail
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("hasThumbnail")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasThumbnailHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasThumbnailHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsConflict
	{
		[Export("isConflict")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsConflictHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsConflictHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedName
	{
		[Export("localizedName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedNameOfSavingComputer
	{
		[Export("localizedNameOfSavingComputer", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameOfSavingComputerHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameOfSavingComputerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate ModificationDate
	{
		[Export("modificationDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selModificationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModificationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual NSPersonNameComponents? OriginatorNameComponents
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("originatorNameComponents", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSend(base.Handle, selOriginatorNameComponentsHandle));
			}
			return Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOriginatorNameComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject PersistentIdentifier
	{
		[Export("persistentIdentifier", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentIdentifierHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Resolved
	{
		[Export("isResolved")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsResolvedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsResolvedHandle);
		}
		[Export("setResolved:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetResolved_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetResolved_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFileVersion(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFileVersion(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addVersionOfItemAtURL:withContentsOfURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileVersion AddVersion(NSUrl url, NSUrl contentsURL, NSFileVersionAddingOptions options, out NSError outError)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (contentsURL == null)
		{
			throw new ArgumentNullException("contentsURL");
		}
		IntPtr arg = IntPtr.Zero;
		NSFileVersion nSObject = Runtime.GetNSObject<NSFileVersion>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr(class_ptr, selAddVersionOfItemAtURL_WithContentsOfURL_Options_Error_Handle, url.Handle, contentsURL.Handle, (ulong)options, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("currentVersionOfItemAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileVersion GetCurrentVersion(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSFileVersion>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCurrentVersionOfItemAtURL_Handle, url.Handle));
	}

	[Export("getNonlocalVersionsOfItemAtURL:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void GetNonlocalVersions(NSUrl url, [BlockProxy(typeof(Trampolines.NIDNSFileVersionNonlocalVersionsCompletionHandler))] NSFileVersionNonlocalVersionsCompletionHandler completionHandler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSFileVersionNonlocalVersionsCompletionHandler.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selGetNonlocalVersionsOfItemAtURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSFileVersion[]> GetNonlocalVersionsAsync(NSUrl url)
	{
		TaskCompletionSource<NSFileVersion[]> tcs = new TaskCompletionSource<NSFileVersion[]>();
		GetNonlocalVersions(url, delegate(NSFileVersion[]? nonlocalFileVersions_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(nonlocalFileVersions_);
			}
		});
		return tcs.Task;
	}

	[Export("otherVersionsOfItemAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileVersion[] GetOtherVersions(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return NSArray.ArrayFromHandle<NSFileVersion>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selOtherVersionsOfItemAtURL_Handle, url.Handle));
	}

	[Export("versionOfItemAtURL:forPersistentIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileVersion GetSpecificVersion(NSUrl url, NSObject persistentIdentifier)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (persistentIdentifier == null)
		{
			throw new ArgumentNullException("persistentIdentifier");
		}
		return Runtime.GetNSObject<NSFileVersion>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVersionOfItemAtURL_ForPersistentIdentifier_Handle, url.Handle, persistentIdentifier.Handle));
	}

	[Export("unresolvedConflictVersionsOfItemAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileVersion[] GetUnresolvedConflictVersions(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return NSArray.ArrayFromHandle<NSFileVersion>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selUnresolvedConflictVersionsOfItemAtURL_Handle, url.Handle));
	}

	[Export("removeAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Remove(out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selRemoveAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selRemoveAndReturnError_Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeOtherVersionsOfItemAtURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool RemoveOtherVersions(NSUrl url, out NSError outError)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selRemoveOtherVersionsOfItemAtURL_Error_Handle, url.Handle, ref arg);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("replaceItemAtURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl ReplaceItem(NSUrl url, NSFileVersionReplacingOptions options, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selReplaceItemAtURL_Options_Error_Handle, url.Handle, (ulong)options, ref arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(base.Handle, selReplaceItemAtURL_Options_Error_Handle, url.Handle, (ulong)options, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("temporaryDirectoryURLForNewVersionOfItemAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl TemporaryDirectoryForItem(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTemporaryDirectoryURLForNewVersionOfItemAtURL_Handle, url.Handle));
	}
}
