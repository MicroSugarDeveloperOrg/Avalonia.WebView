using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileWrapper", true)]
public class NSFileWrapper : NSObject
{
	private static readonly IntPtr selIsDirectoryHandle = Selector.GetHandle("isDirectory");

	private static readonly IntPtr selIsRegularFileHandle = Selector.GetHandle("isRegularFile");

	private static readonly IntPtr selIsSymbolicLinkHandle = Selector.GetHandle("isSymbolicLink");

	private static readonly IntPtr selFileWrappersHandle = Selector.GetHandle("fileWrappers");

	private static readonly IntPtr selSymbolicLinkDestinationURLHandle = Selector.GetHandle("symbolicLinkDestinationURL");

	private static readonly IntPtr selPreferredFilenameHandle = Selector.GetHandle("preferredFilename");

	private static readonly IntPtr selSetPreferredFilename_Handle = Selector.GetHandle("setPreferredFilename:");

	private static readonly IntPtr selFilenameHandle = Selector.GetHandle("filename");

	private static readonly IntPtr selSetFilename_Handle = Selector.GetHandle("setFilename:");

	private static readonly IntPtr selFileAttributesHandle = Selector.GetHandle("fileAttributes");

	private static readonly IntPtr selSetFileAttributes_Handle = Selector.GetHandle("setFileAttributes:");

	private static readonly IntPtr selInitWithURLOptionsError_Handle = Selector.GetHandle("initWithURL:options:error:");

	private static readonly IntPtr selInitDirectoryWithFileWrappers_Handle = Selector.GetHandle("initDirectoryWithFileWrappers:");

	private static readonly IntPtr selInitRegularFileWithContents_Handle = Selector.GetHandle("initRegularFileWithContents:");

	private static readonly IntPtr selInitSymbolicLinkWithDestinationURL_Handle = Selector.GetHandle("initSymbolicLinkWithDestinationURL:");

	private static readonly IntPtr selMatchesContentsOfURL_Handle = Selector.GetHandle("matchesContentsOfURL:");

	private static readonly IntPtr selReadFromURLOptionsError_Handle = Selector.GetHandle("readFromURL:options:error:");

	private static readonly IntPtr selWriteToURLOptionsOriginalContentsURLError_Handle = Selector.GetHandle("writeToURL:options:originalContentsURL:error:");

	private static readonly IntPtr selSerializedRepresentationHandle = Selector.GetHandle("serializedRepresentation");

	private static readonly IntPtr selAddFileWrapper_Handle = Selector.GetHandle("addFileWrapper:");

	private static readonly IntPtr selAddRegularFileWithContentsPreferredFilename_Handle = Selector.GetHandle("addRegularFileWithContents:preferredFilename:");

	private static readonly IntPtr selRemoveFileWrapper_Handle = Selector.GetHandle("removeFileWrapper:");

	private static readonly IntPtr selKeyForFileWrapper_Handle = Selector.GetHandle("keyForFileWrapper:");

	private static readonly IntPtr selRegularFileContentsHandle = Selector.GetHandle("regularFileContents");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFileWrapper");

	private object __mt_FileWrappers_var;

	private object __mt_SymbolicLinkDestinationURL_var;

	private object __mt_FileAttributes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool IsDirectory
	{
		[Export("isDirectory")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDirectoryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDirectoryHandle);
		}
	}

	public virtual bool IsRegularFile
	{
		[Export("isRegularFile")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRegularFileHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRegularFileHandle);
		}
	}

	public virtual bool IsSymbolicLink
	{
		[Export("isSymbolicLink")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSymbolicLinkHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSymbolicLinkHandle);
		}
	}

	public virtual NSDictionary FileWrappers
	{
		[Export("fileWrappers")]
		get
		{
			return (NSDictionary)(__mt_FileWrappers_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileWrappersHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFileWrappersHandle)))));
		}
	}

	public virtual NSUrl SymbolicLinkDestinationURL
	{
		[Export("symbolicLinkDestinationURL")]
		get
		{
			return (NSUrl)(__mt_SymbolicLinkDestinationURL_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSymbolicLinkDestinationURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSymbolicLinkDestinationURLHandle)))));
		}
	}

	public virtual string PreferredFilename
	{
		[Export("preferredFilename")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredFilenameHandle));
		}
		[Export("setPreferredFilename:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreferredFilename_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreferredFilename_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Filename
	{
		[Export("filename")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilenameHandle));
		}
		[Export("setFilename:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFilename_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFilename_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary FileAttributes
	{
		[Export("fileAttributes")]
		get
		{
			return (NSDictionary)(__mt_FileAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFileAttributesHandle)))));
		}
		[Export("setFileAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileAttributes_Handle, value.Handle);
			}
			__mt_FileAttributes_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFileWrapper()
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
	public NSFileWrapper(NSCoder coder)
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
	public NSFileWrapper(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFileWrapper(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:options:error:")]
	public NSFileWrapper(NSUrl url, NSFileWrapperReadingOptions options, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selInitWithURLOptionsError_Handle, url.Handle, (ulong)options, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selInitWithURLOptionsError_Handle, url.Handle, (ulong)options, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initDirectoryWithFileWrappers:")]
	public NSFileWrapper(NSDictionary childrenByPreferredName)
		: base(NSObjectFlag.Empty)
	{
		if (childrenByPreferredName == null)
		{
			throw new ArgumentNullException("childrenByPreferredName");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitDirectoryWithFileWrappers_Handle, childrenByPreferredName.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitDirectoryWithFileWrappers_Handle, childrenByPreferredName.Handle);
		}
	}

	[Export("initRegularFileWithContents:")]
	public NSFileWrapper(NSData contents)
		: base(NSObjectFlag.Empty)
	{
		if (contents == null)
		{
			throw new ArgumentNullException("contents");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitRegularFileWithContents_Handle, contents.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitRegularFileWithContents_Handle, contents.Handle);
		}
	}

	[Export("initSymbolicLinkWithDestinationURL:")]
	public NSFileWrapper(NSUrl urlToSymbolicLink)
		: base(NSObjectFlag.Empty)
	{
		if (urlToSymbolicLink == null)
		{
			throw new ArgumentNullException("urlToSymbolicLink");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitSymbolicLinkWithDestinationURL_Handle, urlToSymbolicLink.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitSymbolicLinkWithDestinationURL_Handle, urlToSymbolicLink.Handle);
		}
	}

	[Export("matchesContentsOfURL:")]
	public virtual bool MatchesContentsOfURL(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selMatchesContentsOfURL_Handle, url.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchesContentsOfURL_Handle, url.Handle);
	}

	[Export("readFromURL:options:error:")]
	public virtual bool Read(NSUrl url, NSFileWrapperReadingOptions options, out NSError outError)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selReadFromURLOptionsError_Handle, url.Handle, (ulong)options, intPtr) : Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selReadFromURLOptionsError_Handle, url.Handle, (ulong)options, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("writeToURL:options:originalContentsURL:error:")]
	public virtual bool Write(NSUrl url, NSFileWrapperWritingOptions options, NSUrl originalContentsURL, out NSError outError)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (originalContentsURL == null)
		{
			throw new ArgumentNullException("originalContentsURL");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selWriteToURLOptionsOriginalContentsURLError_Handle, url.Handle, (ulong)options, originalContentsURL.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selWriteToURLOptionsOriginalContentsURLError_Handle, url.Handle, (ulong)options, originalContentsURL.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("serializedRepresentation")]
	public virtual NSData GetSerializedRepresentation()
	{
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSerializedRepresentationHandle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSerializedRepresentationHandle));
	}

	[Export("addFileWrapper:")]
	public virtual string AddFileWrapper(NSFileWrapper child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAddFileWrapper_Handle, child.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddFileWrapper_Handle, child.Handle));
	}

	[Export("addRegularFileWithContents:preferredFilename:")]
	public virtual string AddRegularFile(NSData dataContents, string preferredFilename)
	{
		if (dataContents == null)
		{
			throw new ArgumentNullException("dataContents");
		}
		if (preferredFilename == null)
		{
			throw new ArgumentNullException("preferredFilename");
		}
		IntPtr arg = NSString.CreateNative(preferredFilename);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddRegularFileWithContentsPreferredFilename_Handle, dataContents.Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddRegularFileWithContentsPreferredFilename_Handle, dataContents.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeFileWrapper:")]
	public virtual void RemoveFileWrapper(NSFileWrapper child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveFileWrapper_Handle, child.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveFileWrapper_Handle, child.Handle);
		}
	}

	[Export("keyForFileWrapper:")]
	public virtual string KeyForFileWrapper(NSFileWrapper child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selKeyForFileWrapper_Handle, child.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyForFileWrapper_Handle, child.Handle));
	}

	[Export("regularFileContents")]
	public virtual NSData GetRegularFileContents()
	{
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRegularFileContentsHandle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRegularFileContentsHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FileWrappers_var = null;
			__mt_SymbolicLinkDestinationURL_var = null;
			__mt_FileAttributes_var = null;
		}
	}
}
