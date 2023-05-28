using System;
using System.ComponentModel;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileWrapper", true)]
public class NSFileWrapper : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddFileWrapper_ = "addFileWrapper:";

	private static readonly IntPtr selAddFileWrapper_Handle = Selector.GetHandle("addFileWrapper:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRegularFileWithContents_PreferredFilename_ = "addRegularFileWithContents:preferredFilename:";

	private static readonly IntPtr selAddRegularFileWithContents_PreferredFilename_Handle = Selector.GetHandle("addRegularFileWithContents:preferredFilename:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileAttributes = "fileAttributes";

	private static readonly IntPtr selFileAttributesHandle = Selector.GetHandle("fileAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileWrappers = "fileWrappers";

	private static readonly IntPtr selFileWrappersHandle = Selector.GetHandle("fileWrappers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilename = "filename";

	private static readonly IntPtr selFilenameHandle = Selector.GetHandle("filename");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIcon = "icon";

	private static readonly IntPtr selIconHandle = Selector.GetHandle("icon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitDirectoryWithFileWrappers_ = "initDirectoryWithFileWrappers:";

	private static readonly IntPtr selInitDirectoryWithFileWrappers_Handle = Selector.GetHandle("initDirectoryWithFileWrappers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitRegularFileWithContents_ = "initRegularFileWithContents:";

	private static readonly IntPtr selInitRegularFileWithContents_Handle = Selector.GetHandle("initRegularFileWithContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitSymbolicLinkWithDestinationURL_ = "initSymbolicLinkWithDestinationURL:";

	private static readonly IntPtr selInitSymbolicLinkWithDestinationURL_Handle = Selector.GetHandle("initSymbolicLinkWithDestinationURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Options_Error_ = "initWithURL:options:error:";

	private static readonly IntPtr selInitWithURL_Options_Error_Handle = Selector.GetHandle("initWithURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDirectory = "isDirectory";

	private static readonly IntPtr selIsDirectoryHandle = Selector.GetHandle("isDirectory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRegularFile = "isRegularFile";

	private static readonly IntPtr selIsRegularFileHandle = Selector.GetHandle("isRegularFile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSymbolicLink = "isSymbolicLink";

	private static readonly IntPtr selIsSymbolicLinkHandle = Selector.GetHandle("isSymbolicLink");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyForFileWrapper_ = "keyForFileWrapper:";

	private static readonly IntPtr selKeyForFileWrapper_Handle = Selector.GetHandle("keyForFileWrapper:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchesContentsOfURL_ = "matchesContentsOfURL:";

	private static readonly IntPtr selMatchesContentsOfURL_Handle = Selector.GetHandle("matchesContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredFilename = "preferredFilename";

	private static readonly IntPtr selPreferredFilenameHandle = Selector.GetHandle("preferredFilename");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadFromURL_Options_Error_ = "readFromURL:options:error:";

	private static readonly IntPtr selReadFromURL_Options_Error_Handle = Selector.GetHandle("readFromURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegularFileContents = "regularFileContents";

	private static readonly IntPtr selRegularFileContentsHandle = Selector.GetHandle("regularFileContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFileWrapper_ = "removeFileWrapper:";

	private static readonly IntPtr selRemoveFileWrapper_Handle = Selector.GetHandle("removeFileWrapper:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSerializedRepresentation = "serializedRepresentation";

	private static readonly IntPtr selSerializedRepresentationHandle = Selector.GetHandle("serializedRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFileAttributes_ = "setFileAttributes:";

	private static readonly IntPtr selSetFileAttributes_Handle = Selector.GetHandle("setFileAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFilename_ = "setFilename:";

	private static readonly IntPtr selSetFilename_Handle = Selector.GetHandle("setFilename:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIcon_ = "setIcon:";

	private static readonly IntPtr selSetIcon_Handle = Selector.GetHandle("setIcon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredFilename_ = "setPreferredFilename:";

	private static readonly IntPtr selSetPreferredFilename_Handle = Selector.GetHandle("setPreferredFilename:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSymbolicLinkDestinationURL = "symbolicLinkDestinationURL";

	private static readonly IntPtr selSymbolicLinkDestinationURLHandle = Selector.GetHandle("symbolicLinkDestinationURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_Options_OriginalContentsURL_Error_ = "writeToURL:options:originalContentsURL:error:";

	private static readonly IntPtr selWriteToURL_Options_OriginalContentsURL_Error_Handle = Selector.GetHandle("writeToURL:options:originalContentsURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFileWrapper");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary FileAttributes
	{
		[Export("fileAttributes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileAttributesHandle));
		}
		[Export("setFileAttributes:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary FileWrappers
	{
		[Export("fileWrappers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileWrappersHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileWrappersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Filename
	{
		[Export("filename")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilenameHandle));
		}
		[Export("setFilename:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage Icon
	{
		[Export("icon", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selIconHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconHandle));
		}
		[Export("setIcon:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIcon_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIcon_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDirectory
	{
		[Export("isDirectory")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDirectoryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDirectoryHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsRegularFile
	{
		[Export("isRegularFile")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRegularFileHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRegularFileHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSymbolicLink
	{
		[Export("isSymbolicLink")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSymbolicLinkHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSymbolicLinkHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PreferredFilename
	{
		[Export("preferredFilename")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl SymbolicLinkDestinationURL
	{
		[Export("symbolicLinkDestinationURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selSymbolicLinkDestinationURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSymbolicLinkDestinationURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFileWrapper()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFileWrapper(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFileWrapper(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFileWrapper(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:options:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileWrapper(NSUrl url, NSFileWrapperReadingOptions options, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(base.Handle, selInitWithURL_Options_Error_Handle, url.Handle, (ulong)options, ref arg), "initWithURL:options:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selInitWithURL_Options_Error_Handle, url.Handle, (ulong)options, ref arg), "initWithURL:options:error:");
		}
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initDirectoryWithFileWrappers:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileWrapper(NSDictionary childrenByPreferredName)
		: base(NSObjectFlag.Empty)
	{
		if (childrenByPreferredName == null)
		{
			throw new ArgumentNullException("childrenByPreferredName");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitDirectoryWithFileWrappers_Handle, childrenByPreferredName.Handle), "initDirectoryWithFileWrappers:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitDirectoryWithFileWrappers_Handle, childrenByPreferredName.Handle), "initDirectoryWithFileWrappers:");
		}
	}

	[Export("initRegularFileWithContents:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileWrapper(NSData contents)
		: base(NSObjectFlag.Empty)
	{
		if (contents == null)
		{
			throw new ArgumentNullException("contents");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitRegularFileWithContents_Handle, contents.Handle), "initRegularFileWithContents:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitRegularFileWithContents_Handle, contents.Handle), "initRegularFileWithContents:");
		}
	}

	[Export("initSymbolicLinkWithDestinationURL:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileWrapper(NSUrl urlToSymbolicLink)
		: base(NSObjectFlag.Empty)
	{
		if (urlToSymbolicLink == null)
		{
			throw new ArgumentNullException("urlToSymbolicLink");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitSymbolicLinkWithDestinationURL_Handle, urlToSymbolicLink.Handle), "initSymbolicLinkWithDestinationURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitSymbolicLinkWithDestinationURL_Handle, urlToSymbolicLink.Handle), "initSymbolicLinkWithDestinationURL:");
		}
	}

	[Export("addFileWrapper:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AddFileWrapper(NSFileWrapper child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAddFileWrapper_Handle, child.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddFileWrapper_Handle, child.Handle));
	}

	[Export("addRegularFileWithContents:preferredFilename:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddRegularFileWithContents_PreferredFilename_Handle, dataContents.Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddRegularFileWithContents_PreferredFilename_Handle, dataContents.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("regularFileContents")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetRegularFileContents()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selRegularFileContentsHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRegularFileContentsHandle));
	}

	[Export("serializedRepresentation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetSerializedRepresentation()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selSerializedRepresentationHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSerializedRepresentationHandle));
	}

	[Export("keyForFileWrapper:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string KeyForFileWrapper(NSFileWrapper child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selKeyForFileWrapper_Handle, child.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyForFileWrapper_Handle, child.Handle));
	}

	[Export("matchesContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MatchesContentsOfURL(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selMatchesContentsOfURL_Handle, url.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchesContentsOfURL_Handle, url.Handle);
	}

	[Export("readFromURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Read(NSUrl url, NSFileWrapperReadingOptions options, out NSError outError)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selReadFromURL_Options_Error_Handle, url.Handle, (ulong)options, ref arg) : Messaging.bool_objc_msgSend_IntPtr_UInt64_ref_IntPtr(base.Handle, selReadFromURL_Options_Error_Handle, url.Handle, (ulong)options, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeFileWrapper:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveFileWrapper(NSFileWrapper child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveFileWrapper_Handle, child.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveFileWrapper_Handle, child.Handle);
		}
	}

	[Export("writeToURL:options:originalContentsURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr_ref_IntPtr(base.SuperHandle, selWriteToURL_Options_OriginalContentsURL_Error_Handle, url.Handle, (ulong)options, originalContentsURL.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr_ref_IntPtr(base.Handle, selWriteToURL_Options_OriginalContentsURL_Error_Handle, url.Handle, (ulong)options, originalContentsURL.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
