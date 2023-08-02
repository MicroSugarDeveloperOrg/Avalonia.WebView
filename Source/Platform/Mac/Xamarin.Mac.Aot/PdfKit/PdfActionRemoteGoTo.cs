using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFActionRemoteGoTo", true)]
public class PdfActionRemoteGoTo : PdfAction
{
	private static readonly IntPtr selPageIndexHandle = Selector.GetHandle("pageIndex");

	private static readonly IntPtr selSetPageIndex_Handle = Selector.GetHandle("setPageIndex:");

	private static readonly IntPtr selPointHandle = Selector.GetHandle("point");

	private static readonly IntPtr selSetPoint_Handle = Selector.GetHandle("setPoint:");

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	private static readonly IntPtr selInitWithPageIndexAtPointFileURL_Handle = Selector.GetHandle("initWithPageIndex:atPoint:fileURL:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFActionRemoteGoTo");

	private object __mt_Url_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual int PageIndex
	{
		[Export("pageIndex")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPageIndexHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPageIndexHandle);
		}
		[Export("setPageIndex:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetPageIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetPageIndex_Handle, value);
			}
		}
	}

	public virtual CGPoint Point
	{
		[Export("point")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPointHandle);
		}
		[Export("setPoint:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetPoint_Handle, value);
			}
		}
	}

	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle)))));
		}
		[Export("setURL:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, value.Handle);
			}
			__mt_Url_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfActionRemoteGoTo()
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
	public PdfActionRemoteGoTo(NSCoder coder)
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
	public PdfActionRemoteGoTo(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfActionRemoteGoTo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPageIndex:atPoint:fileURL:")]
	public PdfActionRemoteGoTo(int pageIndex, CGPoint point, NSUrl fileUrl)
		: base(NSObjectFlag.Empty)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int_CGPoint_IntPtr(base.Handle, selInitWithPageIndexAtPointFileURL_Handle, pageIndex, point, fileUrl.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int_CGPoint_IntPtr(base.SuperHandle, selInitWithPageIndexAtPointFileURL_Handle, pageIndex, point, fileUrl.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Url_var = null;
		}
	}
}
