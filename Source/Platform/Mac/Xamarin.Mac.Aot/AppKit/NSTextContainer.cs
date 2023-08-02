using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextContainer", true)]
public class NSTextContainer : NSObject
{
	private static readonly IntPtr selIsSimpleRectangularTextContainerHandle = Selector.GetHandle("isSimpleRectangularTextContainer");

	private static readonly IntPtr selLayoutManagerHandle = Selector.GetHandle("layoutManager");

	private static readonly IntPtr selSetLayoutManager_Handle = Selector.GetHandle("setLayoutManager:");

	private static readonly IntPtr selTextViewHandle = Selector.GetHandle("textView");

	private static readonly IntPtr selSetTextView_Handle = Selector.GetHandle("setTextView:");

	private static readonly IntPtr selWidthTracksTextViewHandle = Selector.GetHandle("widthTracksTextView");

	private static readonly IntPtr selSetWidthTracksTextView_Handle = Selector.GetHandle("setWidthTracksTextView:");

	private static readonly IntPtr selHeightTracksTextViewHandle = Selector.GetHandle("heightTracksTextView");

	private static readonly IntPtr selSetHeightTracksTextView_Handle = Selector.GetHandle("setHeightTracksTextView:");

	private static readonly IntPtr selContainerSizeHandle = Selector.GetHandle("containerSize");

	private static readonly IntPtr selSetContainerSize_Handle = Selector.GetHandle("setContainerSize:");

	private static readonly IntPtr selLineFragmentPaddingHandle = Selector.GetHandle("lineFragmentPadding");

	private static readonly IntPtr selSetLineFragmentPadding_Handle = Selector.GetHandle("setLineFragmentPadding:");

	private static readonly IntPtr selInitWithContainerSize_Handle = Selector.GetHandle("initWithContainerSize:");

	private static readonly IntPtr selReplaceLayoutManager_Handle = Selector.GetHandle("replaceLayoutManager:");

	private static readonly IntPtr selContainsPoint_Handle = Selector.GetHandle("containsPoint:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextContainer");

	private object __mt_LayoutManager_var;

	private object __mt_TextView_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool IsSimpleRectangularTextContainer
	{
		[Export("isSimpleRectangularTextContainer")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSimpleRectangularTextContainerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSimpleRectangularTextContainerHandle);
		}
	}

	public virtual NSLayoutManager LayoutManager
	{
		[Export("layoutManager")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSLayoutManager)(__mt_LayoutManager_var = ((!IsDirectBinding) ? ((NSLayoutManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutManagerHandle))) : ((NSLayoutManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutManagerHandle)))));
		}
		[Export("setLayoutManager:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLayoutManager_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLayoutManager_Handle, value.Handle);
			}
			__mt_LayoutManager_var = value;
		}
	}

	public virtual NSTextView TextView
	{
		[Export("textView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextView)(__mt_TextView_var = ((!IsDirectBinding) ? ((NSTextView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextViewHandle))) : ((NSTextView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextViewHandle)))));
		}
		[Export("setTextView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextView_Handle, value.Handle);
			}
			__mt_TextView_var = value;
		}
	}

	public virtual bool WidthTracksTextView
	{
		[Export("widthTracksTextView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWidthTracksTextViewHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWidthTracksTextViewHandle);
		}
		[Export("setWidthTracksTextView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWidthTracksTextView_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWidthTracksTextView_Handle, value);
			}
		}
	}

	public virtual bool HeightTracksTextView
	{
		[Export("heightTracksTextView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHeightTracksTextViewHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHeightTracksTextViewHandle);
		}
		[Export("setHeightTracksTextView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHeightTracksTextView_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHeightTracksTextView_Handle, value);
			}
		}
	}

	public virtual CGSize ContainerSize
	{
		[Export("containerSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContainerSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContainerSizeHandle);
		}
		[Export("setContainerSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContainerSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContainerSize_Handle, value);
			}
		}
	}

	public virtual double LineFragmentPadding
	{
		[Export("lineFragmentPadding")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLineFragmentPaddingHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLineFragmentPaddingHandle);
		}
		[Export("setLineFragmentPadding:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetLineFragmentPadding_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetLineFragmentPadding_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextContainer()
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
	public NSTextContainer(NSCoder coder)
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
	public NSTextContainer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextContainer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContainerSize:")]
	public NSTextContainer(CGSize size)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selInitWithContainerSize_Handle, size);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGSize(base.SuperHandle, selInitWithContainerSize_Handle, size);
		}
	}

	[Export("replaceLayoutManager:")]
	public virtual void ReplaceLayoutManager(NSLayoutManager newLayoutManager)
	{
		NSApplication.EnsureUIThread();
		if (newLayoutManager == null)
		{
			throw new ArgumentNullException("newLayoutManager");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceLayoutManager_Handle, newLayoutManager.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceLayoutManager_Handle, newLayoutManager.Handle);
		}
	}

	[Export("containsPoint:")]
	public virtual bool ContainsPoint(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selContainsPoint_Handle, point);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selContainsPoint_Handle, point);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_LayoutManager_var = null;
			__mt_TextView_var = null;
		}
	}
}
