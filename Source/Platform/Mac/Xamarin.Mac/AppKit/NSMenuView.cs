using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMenuView", true)]
public class NSMenuView : NSView
{
	private static readonly IntPtr selMenuBarHeightHandle = Selector.GetHandle("menuBarHeight");

	private static readonly IntPtr selInnerRectHandle = Selector.GetHandle("innerRect");

	private static readonly IntPtr selStateImageOffsetHandle = Selector.GetHandle("stateImageOffset");

	private static readonly IntPtr selStateImageWidthHandle = Selector.GetHandle("stateImageWidth");

	private static readonly IntPtr selImageAndTitleOffsetHandle = Selector.GetHandle("imageAndTitleOffset");

	private static readonly IntPtr selImageAndTitleWidthHandle = Selector.GetHandle("imageAndTitleWidth");

	private static readonly IntPtr selKeyEquivalentOffsetHandle = Selector.GetHandle("keyEquivalentOffset");

	private static readonly IntPtr selKeyEquivalentWidthHandle = Selector.GetHandle("keyEquivalentWidth");

	private static readonly IntPtr selAttachedMenuViewHandle = Selector.GetHandle("attachedMenuView");

	private static readonly IntPtr selAttachedMenuHandle = Selector.GetHandle("attachedMenu");

	private static readonly IntPtr selIsAttachedHandle = Selector.GetHandle("isAttached");

	private static readonly IntPtr selIsTornOffHandle = Selector.GetHandle("isTornOff");

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	private static readonly IntPtr selIsHorizontalHandle = Selector.GetHandle("isHorizontal");

	private static readonly IntPtr selSetHorizontal_Handle = Selector.GetHandle("setHorizontal:");

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	private static readonly IntPtr selHighlightedItemIndexHandle = Selector.GetHandle("highlightedItemIndex");

	private static readonly IntPtr selSetHighlightedItemIndex_Handle = Selector.GetHandle("setHighlightedItemIndex:");

	private static readonly IntPtr selNeedsSizingHandle = Selector.GetHandle("needsSizing");

	private static readonly IntPtr selSetNeedsSizing_Handle = Selector.GetHandle("setNeedsSizing:");

	private static readonly IntPtr selHorizontalEdgePaddingHandle = Selector.GetHandle("horizontalEdgePadding");

	private static readonly IntPtr selSetHorizontalEdgePadding_Handle = Selector.GetHandle("setHorizontalEdgePadding:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selItemChanged_Handle = Selector.GetHandle("itemChanged:");

	private static readonly IntPtr selItemAdded_Handle = Selector.GetHandle("itemAdded:");

	private static readonly IntPtr selItemRemoved_Handle = Selector.GetHandle("itemRemoved:");

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	private static readonly IntPtr selRectOfItemAtIndex_Handle = Selector.GetHandle("rectOfItemAtIndex:");

	private static readonly IntPtr selIndexOfItemAtPoint_Handle = Selector.GetHandle("indexOfItemAtPoint:");

	private static readonly IntPtr selSetNeedsDisplayForItemAtIndex_Handle = Selector.GetHandle("setNeedsDisplayForItemAtIndex:");

	private static readonly IntPtr selSetMenuItemCellForItemAtIndex_Handle = Selector.GetHandle("setMenuItemCell:forItemAtIndex:");

	private static readonly IntPtr selMenuItemCellForItemAtIndex_Handle = Selector.GetHandle("menuItemCellForItemAtIndex:");

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	private static readonly IntPtr selLocationForSubmenu_Handle = Selector.GetHandle("locationForSubmenu:");

	private static readonly IntPtr selSetWindowFrameForAttachingToRectOnScreenPreferredEdgePopUpSelectedItem_Handle = Selector.GetHandle("setWindowFrameForAttachingToRect:onScreen:preferredEdge:popUpSelectedItem:");

	private static readonly IntPtr selDetachSubmenuHandle = Selector.GetHandle("detachSubmenu");

	private static readonly IntPtr selAttachSubmenuForItemAtIndex_Handle = Selector.GetHandle("attachSubmenuForItemAtIndex:");

	private static readonly IntPtr selPerformActionWithHighlightingForItemAtIndex_Handle = Selector.GetHandle("performActionWithHighlightingForItemAtIndex:");

	private static readonly IntPtr selTrackWithEvent_Handle = Selector.GetHandle("trackWithEvent:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMenuView");

	private object __mt_AttachedMenuView_var;

	private object __mt_AttachedMenu_var;

	private object __mt_Menu_var;

	private object __mt_Font_var;

	public override IntPtr ClassHandle => class_ptr;

	public static double MenuBarHeight
	{
		[Export("menuBarHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selMenuBarHeightHandle);
		}
	}

	public virtual CGRect InnerRect
	{
		[Export("innerRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual double StateImageOffset
	{
		[Export("stateImageOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selStateImageOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selStateImageOffsetHandle);
		}
	}

	public virtual double StateImageWidth
	{
		[Export("stateImageWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selStateImageWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selStateImageWidthHandle);
		}
	}

	public virtual double ImageAndTitleOffset
	{
		[Export("imageAndTitleOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selImageAndTitleOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selImageAndTitleOffsetHandle);
		}
	}

	public virtual double ImageAndTitleWidth
	{
		[Export("imageAndTitleWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selImageAndTitleWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selImageAndTitleWidthHandle);
		}
	}

	public virtual double KeyEquivalentOffset
	{
		[Export("keyEquivalentOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selKeyEquivalentOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentOffsetHandle);
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

	public virtual NSMenuView AttachedMenuView
	{
		[Export("attachedMenuView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuView)(__mt_AttachedMenuView_var = ((!IsDirectBinding) ? ((NSMenuView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachedMenuViewHandle))) : ((NSMenuView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachedMenuViewHandle)))));
		}
	}

	public virtual NSMenu AttachedMenu
	{
		[Export("attachedMenu")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenu)(__mt_AttachedMenu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachedMenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachedMenuHandle)))));
		}
	}

	public virtual bool IsAttached
	{
		[Export("isAttached")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAttachedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAttachedHandle);
		}
	}

	public virtual bool IsTornOff
	{
		[Export("isTornOff")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTornOffHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTornOffHandle);
		}
	}

	public new virtual NSMenu Menu
	{
		[Export("menu")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenu)(__mt_Menu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle)))));
		}
		[Export("setMenu:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value.Handle);
			}
			__mt_Menu_var = value;
		}
	}

	public virtual bool Horizontal
	{
		[Export("isHorizontal")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHorizontalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHorizontalHandle);
		}
		[Export("setHorizontal:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHorizontal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHorizontal_Handle, value);
			}
		}
	}

	public virtual NSFont Font
	{
		[Export("font")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFont)(__mt_Font_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle)))));
		}
		[Export("setFont:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, value.Handle);
			}
			__mt_Font_var = value;
		}
	}

	public virtual long HighlightedItemIndex
	{
		[Export("highlightedItemIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selHighlightedItemIndexHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selHighlightedItemIndexHandle);
		}
		[Export("setHighlightedItemIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetHighlightedItemIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetHighlightedItemIndex_Handle, value);
			}
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

	public virtual double HorizontalEdgePadding
	{
		[Export("horizontalEdgePadding")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHorizontalEdgePaddingHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHorizontalEdgePaddingHandle);
		}
		[Export("setHorizontalEdgePadding:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetHorizontalEdgePadding_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetHorizontalEdgePadding_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMenuView()
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
	public NSMenuView(NSCoder coder)
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
	public NSMenuView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMenuView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSMenuView(CGRect frame)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frame);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frame);
		}
	}

	[Export("itemChanged:")]
	public virtual void ItemChanged(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selItemChanged_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemChanged_Handle, notification.Handle);
		}
	}

	[Export("itemAdded:")]
	public virtual void ItemAdded(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selItemAdded_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemAdded_Handle, notification.Handle);
		}
	}

	[Export("itemRemoved:")]
	public virtual void ItemRemoved(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selItemRemoved_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemRemoved_Handle, notification.Handle);
		}
	}

	[Export("update")]
	public virtual void Update()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateHandle);
		}
	}

	[Export("rectOfItemAtIndex:")]
	public virtual CGRect RectOfItemAtIndex(long index)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selRectOfItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selRectOfItemAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("indexOfItemAtPoint:")]
	public virtual long IndexOfItemAtPoint(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_CGPoint(base.Handle, selIndexOfItemAtPoint_Handle, point);
		}
		return Messaging.Int64_objc_msgSendSuper_CGPoint(base.SuperHandle, selIndexOfItemAtPoint_Handle, point);
	}

	[Export("setNeedsDisplayForItemAtIndex:")]
	public virtual void SetNeedsDisplay(long itemAtIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetNeedsDisplayForItemAtIndex_Handle, itemAtIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetNeedsDisplayForItemAtIndex_Handle, itemAtIndex);
		}
	}

	[Export("setMenuItemCell:forItemAtIndex:")]
	public virtual void SetMenuItemCell(NSMenuItemCell cell, long itemAtIndex)
	{
		NSApplication.EnsureUIThread();
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetMenuItemCellForItemAtIndex_Handle, cell.Handle, itemAtIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetMenuItemCellForItemAtIndex_Handle, cell.Handle, itemAtIndex);
		}
	}

	[Export("menuItemCellForItemAtIndex:")]
	public virtual NSMenuItemCell GetMenuItemCell(long itemAtIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSMenuItemCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selMenuItemCellForItemAtIndex_Handle, itemAtIndex));
		}
		return (NSMenuItemCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selMenuItemCellForItemAtIndex_Handle, itemAtIndex));
	}

	[Export("sizeToFit")]
	public virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}

	[Export("locationForSubmenu:")]
	public virtual CGPoint LocationForSubmenu(NSMenu aSubmenu)
	{
		NSApplication.EnsureUIThread();
		if (aSubmenu == null)
		{
			throw new ArgumentNullException("aSubmenu");
		}
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_IntPtr(base.Handle, selLocationForSubmenu_Handle, aSubmenu.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocationForSubmenu_Handle, aSubmenu.Handle);
	}

	[Export("setWindowFrameForAttachingToRect:onScreen:preferredEdge:popUpSelectedItem:")]
	public virtual void SetWindowFrameForAttachingToRect(CGRect screenRect, NSScreen onScreen, NSRectEdge preferredEdge, long popupSelectedItem)
	{
		NSApplication.EnsureUIThread();
		if (onScreen == null)
		{
			throw new ArgumentNullException("onScreen");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_int_Int64(base.Handle, selSetWindowFrameForAttachingToRectOnScreenPreferredEdgePopUpSelectedItem_Handle, screenRect, onScreen.Handle, (int)preferredEdge, popupSelectedItem);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_int_Int64(base.SuperHandle, selSetWindowFrameForAttachingToRectOnScreenPreferredEdgePopUpSelectedItem_Handle, screenRect, onScreen.Handle, (int)preferredEdge, popupSelectedItem);
		}
	}

	[Export("detachSubmenu")]
	public virtual void DetachSubmenu()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDetachSubmenuHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDetachSubmenuHandle);
		}
	}

	[Export("attachSubmenuForItemAtIndex:")]
	public virtual void AttachSubmenuForItemAtIndex(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selAttachSubmenuForItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selAttachSubmenuForItemAtIndex_Handle, index);
		}
	}

	[Export("performActionWithHighlightingForItemAtIndex:")]
	public virtual void PerformActionWithHighlighting(long forItemAtIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selPerformActionWithHighlightingForItemAtIndex_Handle, forItemAtIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selPerformActionWithHighlightingForItemAtIndex_Handle, forItemAtIndex);
		}
	}

	[Export("trackWithEvent:")]
	public virtual bool TrackWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTrackWithEvent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTrackWithEvent_Handle, theEvent.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AttachedMenuView_var = null;
			__mt_AttachedMenu_var = null;
			__mt_Menu_var = null;
			__mt_Font_var = null;
		}
	}
}
