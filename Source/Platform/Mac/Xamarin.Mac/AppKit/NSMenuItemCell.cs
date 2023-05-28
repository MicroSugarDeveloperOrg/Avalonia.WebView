using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSMenuItemCell", true)]
public class NSMenuItemCell : NSButtonCell
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalcSize = "calcSize";

	private static readonly IntPtr selCalcSizeHandle = Selector.GetHandle("calcSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawBorderAndBackgroundWithFrame_InView_ = "drawBorderAndBackgroundWithFrame:inView:";

	private static readonly IntPtr selDrawBorderAndBackgroundWithFrame_InView_Handle = Selector.GetHandle("drawBorderAndBackgroundWithFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawImageWithFrame_InView_ = "drawImageWithFrame:inView:";

	private static readonly IntPtr selDrawImageWithFrame_InView_Handle = Selector.GetHandle("drawImageWithFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawKeyEquivalentWithFrame_InView_ = "drawKeyEquivalentWithFrame:inView:";

	private static readonly IntPtr selDrawKeyEquivalentWithFrame_InView_Handle = Selector.GetHandle("drawKeyEquivalentWithFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawSeparatorItemWithFrame_InView_ = "drawSeparatorItemWithFrame:inView:";

	private static readonly IntPtr selDrawSeparatorItemWithFrame_InView_Handle = Selector.GetHandle("drawSeparatorItemWithFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawStateImageWithFrame_InView_ = "drawStateImageWithFrame:inView:";

	private static readonly IntPtr selDrawStateImageWithFrame_InView_Handle = Selector.GetHandle("drawStateImageWithFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawTitleWithFrame_InView_ = "drawTitleWithFrame:inView:";

	private static readonly IntPtr selDrawTitleWithFrame_InView_Handle = Selector.GetHandle("drawTitleWithFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWidth = "imageWidth";

	private static readonly IntPtr selImageWidthHandle = Selector.GetHandle("imageWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitImageCell_ = "initImageCell:";

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyEquivalentRectForBounds_ = "keyEquivalentRectForBounds:";

	private static readonly IntPtr selKeyEquivalentRectForBounds_Handle = Selector.GetHandle("keyEquivalentRectForBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyEquivalentWidth = "keyEquivalentWidth";

	private static readonly IntPtr selKeyEquivalentWidthHandle = Selector.GetHandle("keyEquivalentWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuItem = "menuItem";

	private static readonly IntPtr selMenuItemHandle = Selector.GetHandle("menuItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuView = "menuView";

	private static readonly IntPtr selMenuViewHandle = Selector.GetHandle("menuView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsDisplay = "needsDisplay";

	private static readonly IntPtr selNeedsDisplayHandle = Selector.GetHandle("needsDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsSizing = "needsSizing";

	private static readonly IntPtr selNeedsSizingHandle = Selector.GetHandle("needsSizing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenuItem_ = "setMenuItem:";

	private static readonly IntPtr selSetMenuItem_Handle = Selector.GetHandle("setMenuItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenuView_ = "setMenuView:";

	private static readonly IntPtr selSetMenuView_Handle = Selector.GetHandle("setMenuView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplay_ = "setNeedsDisplay:";

	private static readonly IntPtr selSetNeedsDisplay_Handle = Selector.GetHandle("setNeedsDisplay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsSizing_ = "setNeedsSizing:";

	private static readonly IntPtr selSetNeedsSizing_Handle = Selector.GetHandle("setNeedsSizing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStateImageRectForBounds_ = "stateImageRectForBounds:";

	private static readonly IntPtr selStateImageRectForBounds_Handle = Selector.GetHandle("stateImageRectForBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStateImageWidth = "stateImageWidth";

	private static readonly IntPtr selStateImageWidthHandle = Selector.GetHandle("stateImageWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTag = "tag";

	private static readonly IntPtr selTagHandle = Selector.GetHandle("tag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleRectForBounds_ = "titleRectForBounds:";

	private static readonly IntPtr selTitleRectForBounds_Handle = Selector.GetHandle("titleRectForBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleWidth = "titleWidth";

	private static readonly IntPtr selTitleWidthHandle = Selector.GetHandle("titleWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMenuItemCell");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ImageWidth
	{
		[Export("imageWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selImageWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selImageWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat KeyEquivalentWidth
	{
		[Export("keyEquivalentWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selKeyEquivalentWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem MenuItem
	{
		[Export("menuItem", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuItemHandle));
			}
			return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuItemHandle));
		}
		[Export("setMenuItem:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenuItem_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenuItem_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuView? MenuView
	{
		[Export("menuView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenuView>(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuViewHandle));
			}
			return Runtime.GetNSObject<NSMenuView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuViewHandle));
		}
		[Export("setMenuView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenuView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenuView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsDisplay
	{
		[Export("needsDisplay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsDisplayHandle);
		}
		[Export("setNeedsDisplay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsDisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsDisplay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NeedsSizing
	{
		[Export("needsSizing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNeedsSizingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNeedsSizingHandle);
		}
		[Export("setNeedsSizing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNeedsSizing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNeedsSizing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual nint Tag
	{
		[Export("tag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selTagHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selTagHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat TitleWidth
	{
		[Export("titleWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTitleWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTitleWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMenuItemCell()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSMenuItemCell(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSMenuItemCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMenuItemCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMenuItemCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMenuItemCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
	}

	[Export("calcSize")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CalcSize()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCalcSizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCalcSizeHandle);
		}
	}

	[Export("drawBorderAndBackgroundWithFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawBorderAndBackground(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawBorderAndBackgroundWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawBorderAndBackgroundWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawImageWithFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawImage(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawImageWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawImageWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawKeyEquivalentWithFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawKeyEquivalent(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawKeyEquivalentWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawKeyEquivalentWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawSeparatorItemWithFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawSeparatorItem(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawSeparatorItemWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawSeparatorItemWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawStateImageWithFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawStateImage(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawStateImageWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawStateImageWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("drawTitleWithFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawTitle(CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawTitleWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawTitleWithFrame_InView_Handle, cellFrame, controlView.Handle);
		}
	}

	[Export("keyEquivalentRectForBounds:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect KeyEquivalentRectForBounds(CGRect cellFrame)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selKeyEquivalentRectForBounds_Handle, cellFrame);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selKeyEquivalentRectForBounds_Handle, cellFrame);
		}
		return retval;
	}

	[Export("stateImageRectForBounds:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect StateImageRectForBounds(CGRect cellFrame)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selStateImageRectForBounds_Handle, cellFrame);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selStateImageRectForBounds_Handle, cellFrame);
		}
		return retval;
	}

	[Export("stateImageWidth")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat StateImageWidth()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend(base.Handle, selStateImageWidthHandle);
		}
		return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStateImageWidthHandle);
	}

	[Export("titleRectForBounds:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGRect TitleRectForBounds(CGRect cellFrame)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selTitleRectForBounds_Handle, cellFrame);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selTitleRectForBounds_Handle, cellFrame);
		}
		return retval;
	}
}
