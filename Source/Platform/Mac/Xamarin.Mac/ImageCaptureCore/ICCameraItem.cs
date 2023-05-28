using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICCameraItem", true)]
public abstract class ICCameraItem : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUTI = "UTI";

	private static readonly IntPtr selUTIHandle = Selector.GetHandle("UTI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationDate = "creationDate";

	private static readonly IntPtr selCreationDateHandle = Selector.GetHandle("creationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileSystemPath = "fileSystemPath";

	private static readonly IntPtr selFileSystemPathHandle = Selector.GetHandle("fileSystemPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInTemporaryStore = "isInTemporaryStore";

	private static readonly IntPtr selIsInTemporaryStoreHandle = Selector.GetHandle("isInTemporaryStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLocked = "isLocked";

	private static readonly IntPtr selIsLockedHandle = Selector.GetHandle("isLocked");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRaw = "isRaw";

	private static readonly IntPtr selIsRawHandle = Selector.GetHandle("isRaw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLargeThumbnailIfAvailable = "largeThumbnailIfAvailable";

	private static readonly IntPtr selLargeThumbnailIfAvailableHandle = Selector.GetHandle("largeThumbnailIfAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataIfAvailable = "metadataIfAvailable";

	private static readonly IntPtr selMetadataIfAvailableHandle = Selector.GetHandle("metadataIfAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModificationDate = "modificationDate";

	private static readonly IntPtr selModificationDateHandle = Selector.GetHandle("modificationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentFolder = "parentFolder";

	private static readonly IntPtr selParentFolderHandle = Selector.GetHandle("parentFolder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPtpObjectHandle = "ptpObjectHandle";

	private static readonly IntPtr selPtpObjectHandleHandle = Selector.GetHandle("ptpObjectHandle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThumbnailIfAvailable = "thumbnailIfAvailable";

	private static readonly IntPtr selThumbnailIfAvailableHandle = Selector.GetHandle("thumbnailIfAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserData = "userData";

	private static readonly IntPtr selUserDataHandle = Selector.GetHandle("userData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWasAddedAfterContentCatalogCompleted = "wasAddedAfterContentCatalogCompleted";

	private static readonly IntPtr selWasAddedAfterContentCatalogCompletedHandle = Selector.GetHandle("wasAddedAfterContentCatalogCompleted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICCameraItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AddedAfterContentCatalogCompleted
	{
		[Export("wasAddedAfterContentCatalogCompleted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWasAddedAfterContentCatalogCompletedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWasAddedAfterContentCatalogCompletedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? CreationDate
	{
		[Export("creationDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICCameraDevice Device
	{
		[Export("device")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ICCameraDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle));
			}
			return Runtime.GetNSObject<ICCameraDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? FileSystemPath
	{
		[Export("fileSystemPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFileSystemPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileSystemPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InTemporaryStore
	{
		[Export("isInTemporaryStore")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInTemporaryStoreHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInTemporaryStoreHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage? LargeThumbnailIfAvailable
	{
		[Export("largeThumbnailIfAvailable")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLargeThumbnailIfAvailableHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selLargeThumbnailIfAvailableHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Locked
	{
		[Export("isLocked")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLockedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLockedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject>? MetadataIfAvailable
	{
		[Export("metadataIfAvailable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataIfAvailableHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataIfAvailableHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? ModificationDate
	{
		[Export("modificationDate")]
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
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICCameraFolder ParentFolder
	{
		[Export("parentFolder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ICCameraFolder>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentFolderHandle));
			}
			return Runtime.GetNSObject<ICCameraFolder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentFolderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint PtpObjectHandle
	{
		[Export("ptpObjectHandle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selPtpObjectHandleHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selPtpObjectHandleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Raw
	{
		[Export("isRaw")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRawHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRawHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage? ThumbnailIfAvailable
	{
		[Export("thumbnailIfAvailable")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selThumbnailIfAvailableHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selThumbnailIfAvailableHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableDictionary? UserData
	{
		[Export("userData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserDataHandle));
			}
			return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Uti
	{
		[Export("UTI")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUTIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUTIHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICCameraItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICCameraItem(IntPtr handle)
		: base(handle)
	{
	}
}
