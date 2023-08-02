using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileVersion", true)]
public class NSFileVersion : NSObject
{
	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	private static readonly IntPtr selLocalizedNameOfSavingComputerHandle = Selector.GetHandle("localizedNameOfSavingComputer");

	private static readonly IntPtr selModificationDateHandle = Selector.GetHandle("modificationDate");

	private static readonly IntPtr selPersistentIdentifierHandle = Selector.GetHandle("persistentIdentifier");

	private static readonly IntPtr selIsConflictHandle = Selector.GetHandle("isConflict");

	private static readonly IntPtr selIsResolvedHandle = Selector.GetHandle("isResolved");

	private static readonly IntPtr selSetResolved_Handle = Selector.GetHandle("setResolved:");

	private static readonly IntPtr selIsDiscardableHandle = Selector.GetHandle("isDiscardable");

	private static readonly IntPtr selSetDiscardable_Handle = Selector.GetHandle("setDiscardable:");

	private static readonly IntPtr selCurrentVersionOfItemAtURL_Handle = Selector.GetHandle("currentVersionOfItemAtURL:");

	private static readonly IntPtr selOtherVersionsOfItemAtURL_Handle = Selector.GetHandle("otherVersionsOfItemAtURL:");

	private static readonly IntPtr selUnresolvedConflictVersionsOfItemAtURL_Handle = Selector.GetHandle("unresolvedConflictVersionsOfItemAtURL:");

	private static readonly IntPtr selVersionOfItemAtURLForPersistentIdentifier_Handle = Selector.GetHandle("versionOfItemAtURL:forPersistentIdentifier:");

	private static readonly IntPtr selAddVersionOfItemAtURLWithContentsOfURLOptionsError_Handle = Selector.GetHandle("addVersionOfItemAtURL:withContentsOfURL:options:error:");

	private static readonly IntPtr selTemporaryDirectoryURLForNewVersionOfItemAtURL_Handle = Selector.GetHandle("temporaryDirectoryURLForNewVersionOfItemAtURL:");

	private static readonly IntPtr selReplaceItemAtURLOptionsError_Handle = Selector.GetHandle("replaceItemAtURL:options:error:");

	private static readonly IntPtr selRemoveAndReturnError_Handle = Selector.GetHandle("removeAndReturnError:");

	private static readonly IntPtr selRemoveOtherVersionsOfItemAtURLError_Handle = Selector.GetHandle("removeOtherVersionsOfItemAtURL:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFileVersion");

	private object __mt_Url_var;

	private object __mt_ModificationDate_var;

	private object __mt_PersistentIdentifier_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle)))));
		}
	}

	public virtual string LocalizedName
	{
		[Export("localizedName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	public virtual string LocalizedNameOfSavingComputer
	{
		[Export("localizedNameOfSavingComputer")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameOfSavingComputerHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameOfSavingComputerHandle));
		}
	}

	public virtual NSDate ModificationDate
	{
		[Export("modificationDate")]
		get
		{
			return (NSDate)(__mt_ModificationDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModificationDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selModificationDateHandle)))));
		}
	}

	public virtual NSObject PersistentIdentifier
	{
		[Export("persistentIdentifier")]
		get
		{
			return (NSObject)(__mt_PersistentIdentifier_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentIdentifierHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentIdentifierHandle))));
		}
	}

	public virtual bool IsConflict
	{
		[Export("isConflict")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsConflictHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsConflictHandle);
		}
	}

	public virtual bool Resolved
	{
		[Export("isResolved")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsResolvedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsResolvedHandle);
		}
		[Export("setResolved:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetResolved_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetResolved_Handle, value);
			}
		}
	}

	public virtual bool Discardable
	{
		[Export("isDiscardable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDiscardableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDiscardableHandle);
		}
		[Export("setDiscardable:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDiscardable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDiscardable_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFileVersion(NSCoder coder)
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
	public NSFileVersion(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFileVersion(IntPtr handle)
		: base(handle)
	{
	}

	[Export("currentVersionOfItemAtURL:")]
	public static NSFileVersion GetCurrentVersion(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (NSFileVersion)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCurrentVersionOfItemAtURL_Handle, url.Handle));
	}

	[Export("otherVersionsOfItemAtURL:")]
	public static NSFileVersion[] GetOtherVersions(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return NSArray.ArrayFromHandle<NSFileVersion>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selOtherVersionsOfItemAtURL_Handle, url.Handle));
	}

	[Export("unresolvedConflictVersionsOfItemAtURL:")]
	public static NSFileVersion[] GetUnresolvedConflictVersions(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return NSArray.ArrayFromHandle<NSFileVersion>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selUnresolvedConflictVersionsOfItemAtURL_Handle, url.Handle));
	}

	[Export("versionOfItemAtURL:forPersistentIdentifier:")]
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
		return (NSFileVersion)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVersionOfItemAtURLForPersistentIdentifier_Handle, url.Handle, persistentIdentifier.Handle));
	}

	[Export("addVersionOfItemAtURL:withContentsOfURL:options:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSFileVersion result = (NSFileVersion)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(class_ptr, selAddVersionOfItemAtURLWithContentsOfURLOptionsError_Handle, url.Handle, contentsURL.Handle, (ulong)options, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("temporaryDirectoryURLForNewVersionOfItemAtURL:")]
	public static NSUrl TemporaryDirectoryForItem(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTemporaryDirectoryURLForNewVersionOfItemAtURL_Handle, url.Handle));
	}

	[Export("replaceItemAtURL:options:error:")]
	public virtual NSUrl ReplaceItem(NSUrl url, NSFileVersionReplacingOptions options, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSUrl result = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selReplaceItemAtURLOptionsError_Handle, url.Handle, (ulong)options, intPtr))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selReplaceItemAtURLOptionsError_Handle, url.Handle, (ulong)options, intPtr))));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("removeAndReturnError:")]
	public virtual bool Remove(out NSError outError)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAndReturnError_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveAndReturnError_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("removeOtherVersionsOfItemAtURL:error:")]
	public static bool RemoveOtherVersions(NSUrl url, out NSError outError)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(class_ptr, selRemoveOtherVersionsOfItemAtURLError_Handle, url.Handle, intPtr);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Url_var = null;
			__mt_ModificationDate_var = null;
			__mt_PersistentIdentifier_var = null;
		}
	}
}
