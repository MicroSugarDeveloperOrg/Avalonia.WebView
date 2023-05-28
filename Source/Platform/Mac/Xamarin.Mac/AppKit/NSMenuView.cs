using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMenuView", true)]
[Introduced(PlatformName.MacOSX, 10, 0, 0, PlatformArchitecture.Arch32, null)]
public class NSMenuView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachSubmenuForItemAtIndex_ = "attachSubmenuForItemAtIndex:";

	private static readonly IntPtr selAttachSubmenuForItemAtIndex_Handle = Selector.GetHandle("attachSubmenuForItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachedMenu = "attachedMenu";

	private static readonly IntPtr selAttachedMenuHandle = Selector.GetHandle("attachedMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachedMenuView = "attachedMenuView";

	private static readonly IntPtr selAttachedMenuViewHandle = Selector.GetHandle("attachedMenuView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetachSubmenu = "detachSubmenu";

	private static readonly IntPtr selDetachSubmenuHandle = Selector.GetHandle("detachSubmenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFont = "font";

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightedItemIndex = "highlightedItemIndex";

	private static readonly IntPtr selHighlightedItemIndexHandle = Selector.GetHandle("highlightedItemIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalEdgePadding = "horizontalEdgePadding";

	private static readonly IntPtr selHorizontalEdgePaddingHandle = Selector.GetHandle("horizontalEdgePadding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageAndTitleOffset = "imageAndTitleOffset";

	private static readonly IntPtr selImageAndTitleOffsetHandle = Selector.GetHandle("imageAndTitleOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageAndTitleWidth = "imageAndTitleWidth";

	private static readonly IntPtr selImageAndTitleWidthHandle = Selector.GetHandle("imageAndTitleWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemAtPoint_ = "indexOfItemAtPoint:";

	private static readonly IntPtr selIndexOfItemAtPoint_Handle = Selector.GetHandle("indexOfItemAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInnerRect = "innerRect";

	private static readonly IntPtr selInnerRectHandle = Selector.GetHandle("innerRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAttached = "isAttached";

	private static readonly IntPtr selIsAttachedHandle = Selector.GetHandle("isAttached");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHorizontal = "isHorizontal";

	private static readonly IntPtr selIsHorizontalHandle = Selector.GetHandle("isHorizontal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTornOff = "isTornOff";

	private static readonly IntPtr selIsTornOffHandle = Selector.GetHandle("isTornOff");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAdded_ = "itemAdded:";

	private static readonly IntPtr selItemAdded_Handle = Selector.GetHandle("itemAdded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemChanged_ = "itemChanged:";

	private static readonly IntPtr selItemChanged_Handle = Selector.GetHandle("itemChanged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemRemoved_ = "itemRemoved:";

	private static readonly IntPtr selItemRemoved_Handle = Selector.GetHandle("itemRemoved:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyEquivalentOffset = "keyEquivalentOffset";

	private static readonly IntPtr selKeyEquivalentOffsetHandle = Selector.GetHandle("keyEquivalentOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyEquivalentWidth = "keyEquivalentWidth";

	private static readonly IntPtr selKeyEquivalentWidthHandle = Selector.GetHandle("keyEquivalentWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocationForSubmenu_ = "locationForSubmenu:";

	private static readonly IntPtr selLocationForSubmenu_Handle = Selector.GetHandle("locationForSubmenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenu = "menu";

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuBarHeight = "menuBarHeight";

	private static readonly IntPtr selMenuBarHeightHandle = Selector.GetHandle("menuBarHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuItemCellForItemAtIndex_ = "menuItemCellForItemAtIndex:";

	private static readonly IntPtr selMenuItemCellForItemAtIndex_Handle = Selector.GetHandle("menuItemCellForItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsSizing = "needsSizing";

	private static readonly IntPtr selNeedsSizingHandle = Selector.GetHandle("needsSizing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformActionWithHighlightingForItemAtIndex_ = "performActionWithHighlightingForItemAtIndex:";

	private static readonly IntPtr selPerformActionWithHighlightingForItemAtIndex_Handle = Selector.GetHandle("performActionWithHighlightingForItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectOfItemAtIndex_ = "rectOfItemAtIndex:";

	private static readonly IntPtr selRectOfItemAtIndex_Handle = Selector.GetHandle("rectOfItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFont_ = "setFont:";

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHighlightedItemIndex_ = "setHighlightedItemIndex:";

	private static readonly IntPtr selSetHighlightedItemIndex_Handle = Selector.GetHandle("setHighlightedItemIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontal_ = "setHorizontal:";

	private static readonly IntPtr selSetHorizontal_Handle = Selector.GetHandle("setHorizontal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHorizontalEdgePadding_ = "setHorizontalEdgePadding:";

	private static readonly IntPtr selSetHorizontalEdgePadding_Handle = Selector.GetHandle("setHorizontalEdgePadding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenu_ = "setMenu:";

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenuItemCell_ForItemAtIndex_ = "setMenuItemCell:forItemAtIndex:";

	private static readonly IntPtr selSetMenuItemCell_ForItemAtIndex_Handle = Selector.GetHandle("setMenuItemCell:forItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplayForItemAtIndex_ = "setNeedsDisplayForItemAtIndex:";

	private static readonly IntPtr selSetNeedsDisplayForItemAtIndex_Handle = Selector.GetHandle("setNeedsDisplayForItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsSizing_ = "setNeedsSizing:";

	private static readonly IntPtr selSetNeedsSizing_Handle = Selector.GetHandle("setNeedsSizing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWindowFrameForAttachingToRect_OnScreen_PreferredEdge_PopUpSelectedItem_ = "setWindowFrameForAttachingToRect:onScreen:preferredEdge:popUpSelectedItem:";

	private static readonly IntPtr selSetWindowFrameForAttachingToRect_OnScreen_PreferredEdge_PopUpSelectedItem_Handle = Selector.GetHandle("setWindowFrameForAttachingToRect:onScreen:preferredEdge:popUpSelectedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeToFit = "sizeToFit";

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStateImageOffset = "stateImageOffset";

	private static readonly IntPtr selStateImageOffsetHandle = Selector.GetHandle("stateImageOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStateImageWidth = "stateImageWidth";

	private static readonly IntPtr selStateImageWidthHandle = Selector.GetHandle("stateImageWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackWithEvent_ = "trackWithEvent:";

	private static readonly IntPtr selTrackWithEvent_Handle = Selector.GetHandle("trackWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdate = "update";

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMenuView");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu AttachedMenu
	{
		[Export("attachedMenu")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachedMenuHandle));
			}
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachedMenuHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuView AttachedMenuView
	{
		[Export("attachedMenuView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenuView>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachedMenuViewHandle));
			}
			return Runtime.GetNSObject<NSMenuView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachedMenuViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont Font
	{
		[Export("font")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle));
			}
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle));
		}
		[Export("setFont:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint HighlightedItemIndex
	{
		[Export("highlightedItemIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHighlightedItemIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHighlightedItemIndexHandle);
		}
		[Export("setHighlightedItemIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetHighlightedItemIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetHighlightedItemIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Horizontal
	{
		[Export("isHorizontal")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHorizontalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHorizontalHandle);
		}
		[Export("setHorizontal:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHorizontal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHorizontal_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat HorizontalEdgePadding
	{
		[Export("horizontalEdgePadding")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selHorizontalEdgePaddingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selHorizontalEdgePaddingHandle);
		}
		[Export("setHorizontalEdgePadding:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetHorizontalEdgePadding_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetHorizontalEdgePadding_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ImageAndTitleOffset
	{
		[Export("imageAndTitleOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selImageAndTitleOffsetHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selImageAndTitleOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ImageAndTitleWidth
	{
		[Export("imageAndTitleWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selImageAndTitleWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selImageAndTitleWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect InnerRect
	{
		[Export("innerRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selInnerRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selInnerRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAttached
	{
		[Export("isAttached")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAttachedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAttachedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsTornOff
	{
		[Export("isTornOff")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTornOffHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTornOffHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat KeyEquivalentOffset
	{
		[Export("keyEquivalentOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selKeyEquivalentOffsetHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentOffsetHandle);
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
	public new virtual NSMenu? Menu
	{
		[Export("menu")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle));
			}
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle));
		}
		[Export("setMenu:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat MenuBarHeight
	{
		[Export("menuBarHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nfloat_objc_msgSend(class_ptr, selMenuBarHeightHandle);
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
	public virtual nfloat StateImageOffset
	{
		[Export("stateImageOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selStateImageOffsetHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStateImageOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat StateImageWidth
	{
		[Export("stateImageWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selStateImageWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStateImageWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMenuView()
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
	public NSMenuView(NSCoder coder)
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
	protected NSMenuView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMenuView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMenuView(CGRect frame)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
	}

	[Export("attachSubmenuForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AttachSubmenuForItemAtIndex(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selAttachSubmenuForItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selAttachSubmenuForItemAtIndex_Handle, index);
		}
	}

	[Export("detachSubmenu")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DetachSubmenu()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDetachSubmenuHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDetachSubmenuHandle);
		}
	}

	[Export("menuItemCellForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItemCell GetMenuItemCell(nint itemAtIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenuItemCell>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selMenuItemCellForItemAtIndex_Handle, itemAtIndex));
		}
		return Runtime.GetNSObject<NSMenuItemCell>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selMenuItemCellForItemAtIndex_Handle, itemAtIndex));
	}

	[Export("indexOfItemAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfItemAtPoint(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_CGPoint(base.Handle, selIndexOfItemAtPoint_Handle, point);
		}
		return Messaging.nint_objc_msgSendSuper_CGPoint(base.SuperHandle, selIndexOfItemAtPoint_Handle, point);
	}

	[Export("itemAdded:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemAdded(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selItemAdded_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemAdded_Handle, notification.Handle);
		}
	}

	[Export("itemChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemChanged(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selItemChanged_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemChanged_Handle, notification.Handle);
		}
	}

	[Export("itemRemoved:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemRemoved(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selItemRemoved_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemRemoved_Handle, notification.Handle);
		}
	}

	[Export("locationForSubmenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint LocationForSubmenu(NSMenu aSubmenu)
	{
		NSApplication.EnsureUIThread();
		if (aSubmenu == null)
		{
			throw new ArgumentNullException("aSubmenu");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_IntPtr(base.Handle, selLocationForSubmenu_Handle, aSubmenu.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocationForSubmenu_Handle, aSubmenu.Handle);
	}

	[Export("performActionWithHighlightingForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformActionWithHighlighting(nint forItemAtIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selPerformActionWithHighlightingForItemAtIndex_Handle, forItemAtIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selPerformActionWithHighlightingForItemAtIndex_Handle, forItemAtIndex);
		}
	}

	[Export("rectOfItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RectOfItemAtIndex(nint index)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selRectOfItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selRectOfItemAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("setMenuItemCell:forItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMenuItemCell(NSMenuItemCell cell, nint itemAtIndex)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetMenuItemCell_ForItemAtIndex_Handle, cell.Handle, itemAtIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetMenuItemCell_ForItemAtIndex_Handle, cell.Handle, itemAtIndex);
		}
	}

	[Export("setNeedsDisplayForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsDisplay(nint itemAtIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selSetNeedsDisplayForItemAtIndex_Handle, itemAtIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNeedsDisplayForItemAtIndex_Handle, itemAtIndex);
		}
	}

	[Export("setWindowFrameForAttachingToRect:onScreen:preferredEdge:popUpSelectedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWindowFrameForAttachingToRect(CGRect screenRect, NSScreen onScreen, NSRectEdge preferredEdge, nint popupSelectedItem)
	{
		NSApplication.EnsureUIThread();
		if (onScreen == null)
		{
			throw new ArgumentNullException("onScreen");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_UInt64_nint(base.Handle, selSetWindowFrameForAttachingToRect_OnScreen_PreferredEdge_PopUpSelectedItem_Handle, screenRect, onScreen.Handle, (ulong)preferredEdge, popupSelectedItem);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_UInt64_nint(base.SuperHandle, selSetWindowFrameForAttachingToRect_OnScreen_PreferredEdge_PopUpSelectedItem_Handle, screenRect, onScreen.Handle, (ulong)preferredEdge, popupSelectedItem);
		}
	}

	[Export("sizeToFit")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}

	[Export("trackWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TrackWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTrackWithEvent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTrackWithEvent_Handle, theEvent.Handle);
	}

	[Export("update")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateHandle);
		}
	}
}
