using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebFrameView", true)]
public class WebFrameView : NSView
{
	private static readonly IntPtr selWebFrameHandle = Selector.GetHandle("webFrame");

	private static readonly IntPtr selDocumentViewHandle = Selector.GetHandle("documentView");

	private static readonly IntPtr selCanPrintHeadersAndFootersHandle = Selector.GetHandle("canPrintHeadersAndFooters");

	private static readonly IntPtr selDocumentViewShouldHandlePrintHandle = Selector.GetHandle("documentViewShouldHandlePrint");

	private static readonly IntPtr selAllowsScrollingHandle = Selector.GetHandle("allowsScrolling");

	private static readonly IntPtr selSetAllowsScrolling_Handle = Selector.GetHandle("setAllowsScrolling:");

	private static readonly IntPtr selPrintOperationWithPrintInfo_Handle = Selector.GetHandle("printOperationWithPrintInfo:");

	private static readonly IntPtr selPrintDocumentViewHandle = Selector.GetHandle("printDocumentView");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebFrameView");

	private object __mt_WebFrame_var;

	private object __mt_DocumentView_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual WebFrame WebFrame
	{
		[Export("webFrame")]
		get
		{
			return (WebFrame)(__mt_WebFrame_var = ((!IsDirectBinding) ? ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWebFrameHandle))) : ((WebFrame)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWebFrameHandle)))));
		}
	}

	public virtual NSView DocumentView
	{
		[Export("documentView")]
		get
		{
			return (NSView)(__mt_DocumentView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentViewHandle)))));
		}
	}

	public virtual bool CanPrintHeadersAndFooters
	{
		[Export("canPrintHeadersAndFooters")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPrintHeadersAndFootersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPrintHeadersAndFootersHandle);
		}
	}

	public virtual bool DocumentViewShouldHandlePrint
	{
		[Export("documentViewShouldHandlePrint")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDocumentViewShouldHandlePrintHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDocumentViewShouldHandlePrintHandle);
		}
	}

	public virtual bool AllowsScrolling
	{
		[Export("allowsScrolling")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsScrollingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsScrollingHandle);
		}
		[Export("setAllowsScrolling:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsScrolling_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsScrolling_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebFrameView()
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
	public WebFrameView(NSCoder coder)
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
	public WebFrameView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebFrameView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("printOperationWithPrintInfo:")]
	public virtual NSPrintOperation GetPrintOperation(NSPrintInfo printInfo)
	{
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (IsDirectBinding)
		{
			return (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPrintOperationWithPrintInfo_Handle, printInfo.Handle));
		}
		return (NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrintOperationWithPrintInfo_Handle, printInfo.Handle));
	}

	[Export("printDocumentView")]
	public virtual void PrintDocumentView()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrintDocumentViewHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrintDocumentViewHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WebFrame_var = null;
			__mt_DocumentView_var = null;
		}
	}
}
