using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMenuItemCell", true)]
public class NSMenuItemCell : NSButtonCell
{
	private static readonly IntPtr selImageWidthHandle = Selector.GetHandle("imageWidth");

	private static readonly IntPtr selTitleWidthHandle = Selector.GetHandle("titleWidth");

	private static readonly IntPtr selKeyEquivalentWidthHandle = Selector.GetHandle("keyEquivalentWidth");

	private static readonly IntPtr selTagHandle = Selector.GetHandle("tag");

	private static readonly IntPtr selMenuItemHandle = Selector.GetHandle("menuItem");

	private static readonly IntPtr selSetMenuItem_Handle = Selector.GetHandle("setMenuItem:");

	private static readonly IntPtr selMenuViewHandle = Selector.GetHandle("menuView");

	private static readonly IntPtr selSetMenuView_Handle = Selector.GetHandle("setMenuView:");

	private static readonly IntPtr selNeedsSizingHandle = Selector.GetHandle("needsSizing");

	private static readonly IntPtr selSetNeedsSizing_Handle = Selector.GetHandle("setNeedsSizing:");

	private static readonly IntPtr selNeedsDisplayHandle = Selector.GetHandle("needsDisplay");

	private static readonly IntPtr selSetNeedsDisplay_Handle = Selector.GetHandle("setNeedsDisplay:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selCalcSizeHandle = Selector.GetHandle("calcSize");

	private static readonly IntPtr selStateImageWidthHandle = Selector.GetHandle("stateImageWidth");

	private static readonly IntPtr selStateImageRectForBounds_Handle = Selector.GetHandle("stateImageRectForBounds:");

	private static readonly IntPtr selTitleRectForBounds_Handle = Selector.GetHandle("titleRectForBounds:");

	private static readonly IntPtr selKeyEquivalentRectForBounds_Handle = Selector.GetHandle("keyEquivalentRectForBounds:");

	private static readonly IntPtr selDrawSeparatorItemWithFrameInView_Handle = Selector.GetHandle("drawSeparatorItemWithFrame:inView:");

	private static readonly IntPtr selDrawStateImageWithFrameInView_Handle = Selector.GetHandle("drawStateImageWithFrame:inView:");

	private static readonly IntPtr selDrawImageWithFrameInView_Handle = Selector.GetHandle("drawImageWithFrame:inView:");

	private static readonly IntPtr selDrawTitleWithFrameInView_Handle = Selector.GetHandle("drawTitleWithFrame:inView:");

	private static readonly IntPtr selDrawKeyEquivalentWithFrameInView_Handle = Selector.GetHandle("drawKeyEquivalentWithFrame:inView:");

	private static readonly IntPtr selDrawBorderAndBackgroundWithFrameInView_Handle = Selector.GetHandle("drawBorderAndBackgroundWithFrame:inView:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMenuItemCell");

	private object __mt_MenuItem_var;

	private object __mt_MenuView_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual double ImageWidth
	{
		[Export("imageWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selImageWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selImageWidthHandle);
		}
	}

	public virtual double TitleWidth
	{
		[Export("titleWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTitleWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTitleWidthHandle);
		}
	}

	public virtual double KeyEquivalentWidth
	{
		[Export("keyEquivalentWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selKeyEquivalentWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentWidthHandle);
		}
	}

	public new virtual long Tag
	{
		[Export("tag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selTagHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTagHandle);
		}
	}

	public virtual NSMenuItem MenuItem
	{
		[Export("menuItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuItem)(__mt_MenuItem_var = ((!IsDirectBinding) ? ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuItemHandle))) : ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuItemHandle)))));
		}
		[Export("setMenuItem:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenuItem_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenuItem_Handle, value.Handle);
			}
			__mt_MenuItem_var = value;
		}
	}

	public virtual NSMenuView MenuView
	{
		[Export("menuView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuView)(__mt_MenuView_var = ((!IsDirectBinding) ? ((NSMenuView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuViewHandle))) : ((NSMenuView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuViewHandle)))));
		}
		[Export("setMenuView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenuView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenuView_Handle, value.Handle);
			}
			__mt_MenuView_var = value;
		}
	}

	public virtual bool NeedsSizing
	{
		[Export("needsSizing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsSizingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsSizingHandle);
		}
		[Export("setNeedsSizing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsSizing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsSizing_Handle, value);
			}
		}
	}

	public virtual bool NeedsDisplay
	{
		[Export("needsDisplay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsDisplayHandle);
		}
		[Export("setNeedsDisplay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsDisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsDisplay_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMenuItemCell()
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
	public NSMenuItemCell(NSCoder coder)
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
	public NSMenuItemCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMenuItemCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSMenuItemCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	public NSMenuItemCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle);
		}
	}

	[Export("calcSize")]
	public virtual void CalcSize()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCalcSizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCalcSizeHandle);
		}
	}

	[Export("stateImageWidth")]
	public virtual double StateImageWidth()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend(base.Handle, selStateImageWidthHandle);
		}
		return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selStateImageWidthHandle);
	}

	[Export("stateImageRectForBounds:")]
	public virtual CGRect StateImageRectForBounds(CGRect cellFrame)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selStateImageRectForBounds_Handle, cellFrame);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selStateImageRectForBounds_Handle, cellFrame);
		}
		return retval;
	}

	[Export("titleRectForBounds:")]
	public new virtual CGRect TitleRectForBounds(CGRect cellFrame)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selTitleRectForBounds_Handle, cellFrame);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selTitleRectForBounds_Handle, cellFrame);
		}
		return retval;
	}

	[Export("keyEquivalentRectForBounds:")]
	public virtual CGRect KeyEquivalentRectForBounds(CGRect cellFrame)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selKeyEquivalentRectForBounds_Handle, cellFrame);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selKeyEquivalentRectForBounds_Handle, cellFrame);
		}
		return retval;
	}

	[Export("drawSeparatorItemWithFrame:inView:")]
	public virtual void DrawSeparatorItem(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawSeparatorItemWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawSeparatorItemWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawStateImageWithFrame:inView:")]
	public virtual void DrawStateImage(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawStateImageWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawStateImageWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawImageWithFrame:inView:")]
	public virtual void DrawImage(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawImageWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawImageWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawTitleWithFrame:inView:")]
	public virtual void DrawTitle(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawTitleWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawTitleWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawKeyEquivalentWithFrame:inView:")]
	public virtual void DrawKeyEquivalent(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawKeyEquivalentWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawKeyEquivalentWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawBorderAndBackgroundWithFrame:inView:")]
	public virtual void DrawBorderAndBackground(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawBorderAndBackgroundWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawBorderAndBackgroundWithFrameInView_Handle, cellFrame, controlView.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_MenuItem_var = null;
			__mt_MenuView_var = null;
		}
	}
}
