using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextAttachment", true)]
public class NSTextAttachment : NSObject
{
	private static readonly IntPtr selFileWrapperHandle = Selector.GetHandle("fileWrapper");

	private static readonly IntPtr selSetFileWrapper_Handle = Selector.GetHandle("setFileWrapper:");

	private static readonly IntPtr selAttachmentCellHandle = Selector.GetHandle("attachmentCell");

	private static readonly IntPtr selSetAttachmentCell_Handle = Selector.GetHandle("setAttachmentCell:");

	private static readonly IntPtr selInitWithFileWrapper_Handle = Selector.GetHandle("initWithFileWrapper:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextAttachment");

	private object __mt_FileWrapper_var;

	private object __mt_AttachmentCell_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSFileWrapper FileWrapper
	{
		[Export("fileWrapper")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFileWrapper)(__mt_FileWrapper_var = ((!IsDirectBinding) ? ((NSFileWrapper)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileWrapperHandle))) : ((NSFileWrapper)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFileWrapperHandle)))));
		}
		[Export("setFileWrapper:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileWrapper_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileWrapper_Handle, value.Handle);
			}
			__mt_FileWrapper_var = value;
		}
	}

	public virtual NSTextAttachmentCell AttachmentCell
	{
		[Export("attachmentCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextAttachmentCell)(__mt_AttachmentCell_var = ((!IsDirectBinding) ? ((NSTextAttachmentCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachmentCellHandle))) : ((NSTextAttachmentCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachmentCellHandle)))));
		}
		[Export("setAttachmentCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttachmentCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttachmentCell_Handle, value.Handle);
			}
			__mt_AttachmentCell_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextAttachment()
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
	public NSTextAttachment(NSCoder coder)
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
	public NSTextAttachment(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextAttachment(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFileWrapper:")]
	public NSTextAttachment(NSFileWrapper fileWrapper)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (fileWrapper == null)
		{
			throw new ArgumentNullException("fileWrapper");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFileWrapper_Handle, fileWrapper.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFileWrapper_Handle, fileWrapper.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FileWrapper_var = null;
			__mt_AttachmentCell_var = null;
		}
	}
}
