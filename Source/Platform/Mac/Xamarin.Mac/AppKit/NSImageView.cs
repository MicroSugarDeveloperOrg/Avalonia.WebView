using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSImageView", true)]
public class NSImageView : NSControl
{
	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	private static readonly IntPtr selImageAlignmentHandle = Selector.GetHandle("imageAlignment");

	private static readonly IntPtr selSetImageAlignment_Handle = Selector.GetHandle("setImageAlignment:");

	private static readonly IntPtr selImageScalingHandle = Selector.GetHandle("imageScaling");

	private static readonly IntPtr selSetImageScaling_Handle = Selector.GetHandle("setImageScaling:");

	private static readonly IntPtr selImageFrameStyleHandle = Selector.GetHandle("imageFrameStyle");

	private static readonly IntPtr selSetImageFrameStyle_Handle = Selector.GetHandle("setImageFrameStyle:");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selAnimatesHandle = Selector.GetHandle("animates");

	private static readonly IntPtr selSetAnimates_Handle = Selector.GetHandle("setAnimates:");

	private static readonly IntPtr selAllowsCutCopyPasteHandle = Selector.GetHandle("allowsCutCopyPaste");

	private static readonly IntPtr selSetAllowsCutCopyPaste_Handle = Selector.GetHandle("setAllowsCutCopyPaste:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSImageView");

	private object __mt_Image_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSImage Image
	{
		[Export("image")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_Image_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle)))));
		}
		[Export("setImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_Image_var = value;
		}
	}

	public virtual NSImageAlignment ImageAlignment
	{
		[Export("imageAlignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSImageAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selImageAlignmentHandle);
			}
			return (NSImageAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageAlignmentHandle);
		}
		[Export("setImageAlignment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImageAlignment_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImageAlignment_Handle, (ulong)value);
			}
		}
	}

	public virtual NSImageScale ImageScaling
	{
		[Export("imageScaling")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSImageScale)Messaging.UInt64_objc_msgSend(base.Handle, selImageScalingHandle);
			}
			return (NSImageScale)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageScalingHandle);
		}
		[Export("setImageScaling:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImageScaling_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImageScaling_Handle, (ulong)value);
			}
		}
	}

	public virtual NSImageFrameStyle ImageFrameStyle
	{
		[Export("imageFrameStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSImageFrameStyle)Messaging.UInt64_objc_msgSend(base.Handle, selImageFrameStyleHandle);
			}
			return (NSImageFrameStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageFrameStyleHandle);
		}
		[Export("setImageFrameStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImageFrameStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImageFrameStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	public virtual bool Animates
	{
		[Export("animates")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAnimatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAnimatesHandle);
		}
		[Export("setAnimates:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAnimates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAnimates_Handle, value);
			}
		}
	}

	public virtual bool AllowsCutCopyPaste
	{
		[Export("allowsCutCopyPaste")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCutCopyPasteHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCutCopyPasteHandle);
		}
		[Export("setAllowsCutCopyPaste:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsCutCopyPaste_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsCutCopyPaste_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSImageView()
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
	public NSImageView(NSCoder coder)
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
	public NSImageView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSImageView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSImageView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Image_var = null;
		}
	}
}
