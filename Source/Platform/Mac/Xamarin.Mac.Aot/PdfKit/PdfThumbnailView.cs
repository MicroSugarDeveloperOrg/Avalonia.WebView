using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFThumbnailView", true)]
public class PdfThumbnailView : NSView
{
	private static readonly IntPtr selPDFViewHandle = Selector.GetHandle("PDFView");

	private static readonly IntPtr selSetPDFView_Handle = Selector.GetHandle("setPDFView:");

	private static readonly IntPtr selThumbnailSizeHandle = Selector.GetHandle("thumbnailSize");

	private static readonly IntPtr selSetThumbnailSize_Handle = Selector.GetHandle("setThumbnailSize:");

	private static readonly IntPtr selMaximumNumberOfColumnsHandle = Selector.GetHandle("maximumNumberOfColumns");

	private static readonly IntPtr selSetMaximumNumberOfColumns_Handle = Selector.GetHandle("setMaximumNumberOfColumns:");

	private static readonly IntPtr selLabelFontHandle = Selector.GetHandle("labelFont");

	private static readonly IntPtr selSetLabelFont_Handle = Selector.GetHandle("setLabelFont:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selAllowsDraggingHandle = Selector.GetHandle("allowsDragging");

	private static readonly IntPtr selSetAllowsDragging_Handle = Selector.GetHandle("setAllowsDragging:");

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	private static readonly IntPtr selSelectedPagesHandle = Selector.GetHandle("selectedPages");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFThumbnailView");

	private object __mt_PdfView_var;

	private object __mt_LabelFont_var;

	private object __mt_BackgroundColor_var;

	private object __mt_SelectedPages_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfView PdfView
	{
		[Export("PDFView")]
		get
		{
			return (PdfView)(__mt_PdfView_var = ((!IsDirectBinding) ? ((PdfView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPDFViewHandle))) : ((PdfView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPDFViewHandle)))));
		}
		[Export("setPDFView:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPDFView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPDFView_Handle, value.Handle);
			}
			__mt_PdfView_var = value;
		}
	}

	public virtual CGSize ThumbnailSize
	{
		[Export("thumbnailSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selThumbnailSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selThumbnailSizeHandle);
		}
		[Export("setThumbnailSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetThumbnailSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetThumbnailSize_Handle, value);
			}
		}
	}

	public virtual int MaximumNumberOfColumns
	{
		[Export("maximumNumberOfColumns")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMaximumNumberOfColumnsHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMaximumNumberOfColumnsHandle);
		}
		[Export("setMaximumNumberOfColumns:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMaximumNumberOfColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMaximumNumberOfColumns_Handle, value);
			}
		}
	}

	public virtual NSFont LabelFont
	{
		[Export("labelFont")]
		get
		{
			return (NSFont)(__mt_LabelFont_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelFontHandle)))));
		}
		[Export("setLabelFont:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabelFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabelFont_Handle, value.Handle);
			}
			__mt_LabelFont_var = value;
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual bool AllowsDragging
	{
		[Export("allowsDragging")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDraggingHandle);
		}
		[Export("setAllowsDragging:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsDragging_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsDragging_Handle, value);
			}
		}
	}

	public virtual bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
		[Export("setAllowsMultipleSelection:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMultipleSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMultipleSelection_Handle, value);
			}
		}
	}

	public virtual PdfPage[] SelectedPages
	{
		[Export("selectedPages")]
		get
		{
			return (PdfPage[])(__mt_SelectedPages_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedPagesHandle)) : NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedPagesHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfThumbnailView()
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
	public PdfThumbnailView(NSCoder coder)
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
	public PdfThumbnailView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfThumbnailView(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PdfView_var = null;
			__mt_LabelFont_var = null;
			__mt_BackgroundColor_var = null;
			__mt_SelectedPages_var = null;
		}
	}
}
