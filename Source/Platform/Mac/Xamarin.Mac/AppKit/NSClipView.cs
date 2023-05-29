using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSClipView", true)]
public class NSClipView : NSView
{
	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	private static readonly IntPtr selDocumentViewHandle = Selector.GetHandle("documentView");

	private static readonly IntPtr selSetDocumentView_Handle = Selector.GetHandle("setDocumentView:");

	private static readonly IntPtr selDocumentRectHandle = Selector.GetHandle("documentRect");

	private static readonly IntPtr selDocumentCursorHandle = Selector.GetHandle("documentCursor");

	private static readonly IntPtr selSetDocumentCursor_Handle = Selector.GetHandle("setDocumentCursor:");

	private static readonly IntPtr selCopiesOnScrollHandle = Selector.GetHandle("copiesOnScroll");

	private static readonly IntPtr selSetCopiesOnScroll_Handle = Selector.GetHandle("setCopiesOnScroll:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selDocumentVisibleRectHandle = Selector.GetHandle("documentVisibleRect");

	private static readonly IntPtr selViewFrameChanged_Handle = Selector.GetHandle("viewFrameChanged:");

	private static readonly IntPtr selViewBoundsChanged_Handle = Selector.GetHandle("viewBoundsChanged:");

	private static readonly IntPtr selAutoscroll_Handle = Selector.GetHandle("autoscroll:");

	private static readonly IntPtr selConstrainScrollPoint_Handle = Selector.GetHandle("constrainScrollPoint:");

	private static readonly IntPtr selScrollToPoint_Handle = Selector.GetHandle("scrollToPoint:");

	private static readonly IntPtr selScrollClipViewToPoint_Handle = Selector.GetHandle("scrollClipView:toPoint:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSClipView");

	private object __mt_BackgroundColor_var;

	private object __mt_DocumentView_var;

	private object __mt_DocumentCursor_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	public virtual NSView DocumentView
	{
		[Export("documentView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_DocumentView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentViewHandle)))));
		}
		[Export("setDocumentView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentView_Handle, value.Handle);
			}
			__mt_DocumentView_var = value;
		}
	}

	public virtual CGRect DocumentRect
	{
		[Export("documentRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selDocumentRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDocumentRectHandle);
			}
			return retval;
		}
	}

	public virtual NSCursor DocumentCursor
	{
		[Export("documentCursor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCursor)(__mt_DocumentCursor_var = ((!IsDirectBinding) ? ((NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentCursorHandle))) : ((NSCursor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentCursorHandle)))));
		}
		[Export("setDocumentCursor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentCursor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentCursor_Handle, value.Handle);
			}
			__mt_DocumentCursor_var = value;
		}
	}

	public virtual bool CopiesOnScroll
	{
		[Export("copiesOnScroll")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCopiesOnScrollHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCopiesOnScrollHandle);
		}
		[Export("setCopiesOnScroll:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCopiesOnScroll_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCopiesOnScroll_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSClipView()
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
	public NSClipView(NSCoder coder)
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
	public NSClipView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSClipView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSClipView(CGRect frameRect)
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

	[Export("documentVisibleRect")]
	public virtual CGRect DocumentVisibleRect()
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selDocumentVisibleRectHandle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDocumentVisibleRectHandle);
		}
		return retval;
	}

	[Export("viewFrameChanged:")]
	public virtual void ViewFrameChanged(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selViewFrameChanged_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewFrameChanged_Handle, notification.Handle);
		}
	}

	[Export("viewBoundsChanged:")]
	public virtual void ViewBoundsChanged(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selViewBoundsChanged_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewBoundsChanged_Handle, notification.Handle);
		}
	}

	[Export("autoscroll:")]
	public new virtual bool Autoscroll(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAutoscroll_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAutoscroll_Handle, theEvent.Handle);
	}

	[Export("constrainScrollPoint:")]
	public virtual CGPoint ConstrainScrollPoint(CGPoint newOrigin)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConstrainScrollPoint_Handle, newOrigin);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConstrainScrollPoint_Handle, newOrigin);
	}

	[Export("scrollToPoint:")]
	public virtual void ScrollToPoint(CGPoint newOrigin)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selScrollToPoint_Handle, newOrigin);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selScrollToPoint_Handle, newOrigin);
		}
	}

	[Export("scrollClipView:toPoint:")]
	public virtual void ScrollClipView(NSClipView aClipView, CGPoint aPoint)
	{
		NSApplication.EnsureUIThread();
		if (aClipView == null)
		{
			throw new ArgumentNullException("aClipView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selScrollClipViewToPoint_Handle, aClipView.Handle, aPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selScrollClipViewToPoint_Handle, aClipView.Handle, aPoint);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_BackgroundColor_var = null;
			__mt_DocumentView_var = null;
			__mt_DocumentCursor_var = null;
		}
	}
}
