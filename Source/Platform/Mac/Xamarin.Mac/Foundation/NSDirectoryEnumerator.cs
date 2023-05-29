using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDirectoryEnumerator", true)]
public class NSDirectoryEnumerator : NSEnumerator
{
	private static readonly IntPtr selFileAttributesHandle = Selector.GetHandle("fileAttributes");

	private static readonly IntPtr selDirectoryAttributesHandle = Selector.GetHandle("directoryAttributes");

	private static readonly IntPtr selSkipDescendentsHandle = Selector.GetHandle("skipDescendents");

	private static readonly IntPtr selFileModificationDateHandle = Selector.GetHandle("fileModificationDate");

	private static readonly IntPtr selFileTypeHandle = Selector.GetHandle("fileType");

	private static readonly IntPtr selFilePosixPermissionsHandle = Selector.GetHandle("filePosixPermissions");

	private static readonly IntPtr selFileOwnerAccountNameHandle = Selector.GetHandle("fileOwnerAccountName");

	private static readonly IntPtr selFileGroupOwnerAccountNameHandle = Selector.GetHandle("fileGroupOwnerAccountName");

	private static readonly IntPtr selFileSystemNumberHandle = Selector.GetHandle("fileSystemNumber");

	private static readonly IntPtr selFileSystemFileNumberHandle = Selector.GetHandle("fileSystemFileNumber");

	private static readonly IntPtr selFileExtensionHiddenHandle = Selector.GetHandle("fileExtensionHidden");

	private static readonly IntPtr selFileHFSCreatorCodeHandle = Selector.GetHandle("fileHFSCreatorCode");

	private static readonly IntPtr selFileHFSTypeCodeHandle = Selector.GetHandle("fileHFSTypeCode");

	private static readonly IntPtr selFileIsImmutableHandle = Selector.GetHandle("fileIsImmutable");

	private static readonly IntPtr selFileIsAppendOnlyHandle = Selector.GetHandle("fileIsAppendOnly");

	private static readonly IntPtr selFileCreationDateHandle = Selector.GetHandle("fileCreationDate");

	private static readonly IntPtr selFileOwnerAccountIDHandle = Selector.GetHandle("fileOwnerAccountID");

	private static readonly IntPtr selFileGroupOwnerAccountIDHandle = Selector.GetHandle("fileGroupOwnerAccountID");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDirectoryEnumerator");

	private object __mt_FileAttributes_var;

	private object __mt_DirectoryAttributes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDictionary FileAttributes
	{
		[Export("fileAttributes")]
		get
		{
			return (NSDictionary)(__mt_FileAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFileAttributesHandle)))));
		}
	}

	public virtual NSDictionary DirectoryAttributes
	{
		[Export("directoryAttributes")]
		get
		{
			return (NSDictionary)(__mt_DirectoryAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDirectoryAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDirectoryAttributesHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDirectoryEnumerator()
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
	public NSDirectoryEnumerator(NSCoder coder)
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
	public NSDirectoryEnumerator(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDirectoryEnumerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("skipDescendents")]
	public virtual void SkipDescendents()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSkipDescendentsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSkipDescendentsHandle);
		}
	}

	[Export("fileModificationDate")]
	public virtual NSDate FileModificationDate(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(fileAttributes.Handle, selFileModificationDateHandle));
		}
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileModificationDateHandle));
	}

	[Export("fileType")]
	public virtual string FileType(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(fileAttributes.Handle, selFileTypeHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileTypeHandle));
	}

	[Export("filePosixPermissions")]
	public virtual uint FilePosixPermissions(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend(fileAttributes.Handle, selFilePosixPermissionsHandle);
		}
		return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFilePosixPermissionsHandle);
	}

	[Export("fileOwnerAccountName")]
	public virtual string FileOwnerAccountName(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(fileAttributes.Handle, selFileOwnerAccountNameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileOwnerAccountNameHandle));
	}

	[Export("fileGroupOwnerAccountName")]
	public virtual string FileGroupOwnerAccountName(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(fileAttributes.Handle, selFileGroupOwnerAccountNameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileGroupOwnerAccountNameHandle));
	}

	[Export("fileSystemNumber")]
	public virtual long FileSystemNumber(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(fileAttributes.Handle, selFileSystemNumberHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFileSystemNumberHandle);
	}

	[Export("fileSystemFileNumber")]
	public virtual ulong FileSystemFileNumber(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend(fileAttributes.Handle, selFileSystemFileNumberHandle);
		}
		return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFileSystemFileNumberHandle);
	}

	[Export("fileExtensionHidden")]
	public virtual bool FileExtensionHidden(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(fileAttributes.Handle, selFileExtensionHiddenHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFileExtensionHiddenHandle);
	}

	[Export("fileHFSCreatorCode")]
	public virtual uint FileHfsCreatorCode(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend(fileAttributes.Handle, selFileHFSCreatorCodeHandle);
		}
		return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFileHFSCreatorCodeHandle);
	}

	[Export("fileHFSTypeCode")]
	public virtual uint FileHfsTypeCode(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend(fileAttributes.Handle, selFileHFSTypeCodeHandle);
		}
		return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFileHFSTypeCodeHandle);
	}

	[Export("fileIsImmutable")]
	public virtual bool FileIsImmutable(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(fileAttributes.Handle, selFileIsImmutableHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFileIsImmutableHandle);
	}

	[Export("fileIsAppendOnly")]
	public virtual bool FileIsAppendOnly(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(fileAttributes.Handle, selFileIsAppendOnlyHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFileIsAppendOnlyHandle);
	}

	[Export("fileCreationDate")]
	public virtual NSDate FileCreationDate(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(fileAttributes.Handle, selFileCreationDateHandle));
		}
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileCreationDateHandle));
	}

	[Export("fileOwnerAccountID")]
	public virtual NSNumber FileOwnerAccountID(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(fileAttributes.Handle, selFileOwnerAccountIDHandle));
		}
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileOwnerAccountIDHandle));
	}

	[Export("fileGroupOwnerAccountID")]
	public virtual NSNumber FileGroupOwnerAccountID(NSDictionary fileAttributes)
	{
		if (fileAttributes == null)
		{
			throw new ArgumentNullException("fileAttributes");
		}
		if (IsDirectBinding)
		{
			return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(fileAttributes.Handle, selFileGroupOwnerAccountIDHandle));
		}
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileGroupOwnerAccountIDHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FileAttributes_var = null;
			__mt_DirectoryAttributes_var = null;
		}
	}
}
