using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMenu", true)]
public class NSMenu : NSObject
{
	private object __mt_items_var;

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	private static readonly IntPtr selMenuBarHeightHandle = Selector.GetHandle("menuBarHeight");

	private static readonly IntPtr selHighlightedItemHandle = Selector.GetHandle("highlightedItem");

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	private static readonly IntPtr selIsTornOffHandle = Selector.GetHandle("isTornOff");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selMenuBarVisibleHandle = Selector.GetHandle("menuBarVisible");

	private static readonly IntPtr selSetMenuBarVisible_Handle = Selector.GetHandle("setMenuBarVisible:");

	private static readonly IntPtr selSupermenuHandle = Selector.GetHandle("supermenu");

	private static readonly IntPtr selSetSupermenu_Handle = Selector.GetHandle("setSupermenu:");

	private static readonly IntPtr selAutoenablesItemsHandle = Selector.GetHandle("autoenablesItems");

	private static readonly IntPtr selSetAutoenablesItems_Handle = Selector.GetHandle("setAutoenablesItems:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selMinimumWidthHandle = Selector.GetHandle("minimumWidth");

	private static readonly IntPtr selSetMinimumWidth_Handle = Selector.GetHandle("setMinimumWidth:");

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	private static readonly IntPtr selAllowsContextMenuPlugInsHandle = Selector.GetHandle("allowsContextMenuPlugIns");

	private static readonly IntPtr selSetAllowsContextMenuPlugIns_Handle = Selector.GetHandle("setAllowsContextMenuPlugIns:");

	private static readonly IntPtr selShowsStateColumnHandle = Selector.GetHandle("showsStateColumn");

	private static readonly IntPtr selSetShowsStateColumn_Handle = Selector.GetHandle("setShowsStateColumn:");

	private static readonly IntPtr selMenuChangedMessagesEnabledHandle = Selector.GetHandle("menuChangedMessagesEnabled");

	private static readonly IntPtr selSetMenuChangedMessagesEnabled_Handle = Selector.GetHandle("setMenuChangedMessagesEnabled:");

	private static readonly IntPtr selInitWithTitle_Handle = Selector.GetHandle("initWithTitle:");

	private static readonly IntPtr selPopUpContextMenuWithEventForView_Handle = Selector.GetHandle("popUpContextMenu:withEvent:forView:");

	private static readonly IntPtr selPopUpContextMenuWithEventForViewWithFont_Handle = Selector.GetHandle("popUpContextMenu:withEvent:forView:withFont:");

	private static readonly IntPtr selPopUpMenuPositioningItemAtLocationInView_Handle = Selector.GetHandle("popUpMenuPositioningItem:atLocation:inView:");

	private static readonly IntPtr selInsertItemAtIndex_Handle = Selector.GetHandle("insertItem:atIndex:");

	private static readonly IntPtr selAddItem_Handle = Selector.GetHandle("addItem:");

	private static readonly IntPtr selInsertItemWithTitleActionKeyEquivalentAtIndex_Handle = Selector.GetHandle("insertItemWithTitle:action:keyEquivalent:atIndex:");

	private static readonly IntPtr selAddItemWithTitleActionKeyEquivalent_Handle = Selector.GetHandle("addItemWithTitle:action:keyEquivalent:");

	private static readonly IntPtr selRemoveItemAtIndex_Handle = Selector.GetHandle("removeItemAtIndex:");

	private static readonly IntPtr selRemoveItem_Handle = Selector.GetHandle("removeItem:");

	private static readonly IntPtr selSetSubmenuForItem_Handle = Selector.GetHandle("setSubmenu:forItem:");

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	private static readonly IntPtr selItemArrayHandle = Selector.GetHandle("itemArray");

	private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

	private static readonly IntPtr selIndexOfItem_Handle = Selector.GetHandle("indexOfItem:");

	private static readonly IntPtr selIndexOfItemWithTitle_Handle = Selector.GetHandle("indexOfItemWithTitle:");

	private static readonly IntPtr selIndexOfItemWithTag_Handle = Selector.GetHandle("indexOfItemWithTag:");

	private static readonly IntPtr selIndexOfItemWithRepresentedObject_Handle = Selector.GetHandle("indexOfItemWithRepresentedObject:");

	private static readonly IntPtr selIndexOfItemWithSubmenu_Handle = Selector.GetHandle("indexOfItemWithSubmenu:");

	private static readonly IntPtr selIndexOfItemWithTargetAndAction_Handle = Selector.GetHandle("indexOfItemWithTarget:andAction:");

	private static readonly IntPtr selItemWithTitle_Handle = Selector.GetHandle("itemWithTitle:");

	private static readonly IntPtr selItemWithTag_Handle = Selector.GetHandle("itemWithTag:");

	private static readonly IntPtr selUpdateHandle = Selector.GetHandle("update");

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	private static readonly IntPtr selItemChanged_Handle = Selector.GetHandle("itemChanged:");

	private static readonly IntPtr selPerformActionForItemAtIndex_Handle = Selector.GetHandle("performActionForItemAtIndex:");

	private static readonly IntPtr selCancelTrackingHandle = Selector.GetHandle("cancelTracking");

	private static readonly IntPtr selCancelTrackingWithoutAnimationHandle = Selector.GetHandle("cancelTrackingWithoutAnimation");

	private static readonly IntPtr selHelpRequested_Handle = Selector.GetHandle("helpRequested:");

	private static readonly IntPtr selPropertiesToUpdateHandle = Selector.GetHandle("propertiesToUpdate");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMenu");

	private object __mt_HighlightedItem_var;

	private object __mt_Supermenu_var;

	private object __mt_WeakDelegate_var;

	private object __mt_Font_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual long Count
	{
		[Export("numberOfItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfItemsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfItemsHandle);
		}
	}

	public virtual double MenuBarHeight
	{
		[Export("menuBarHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMenuBarHeightHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMenuBarHeightHandle);
		}
	}

	public virtual NSMenuItem HighlightedItem
	{
		[Export("highlightedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuItem)(__mt_HighlightedItem_var = ((!IsDirectBinding) ? ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHighlightedItemHandle))) : ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHighlightedItemHandle)))));
		}
	}

	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
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

	public virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public static bool MenuBarVisible
	{
		[Export("menuBarVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selMenuBarVisibleHandle);
		}
		[Export("setMenuBarVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(class_ptr, selSetMenuBarVisible_Handle, value);
		}
	}

	public virtual NSMenu Supermenu
	{
		[Export("supermenu")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenu)(__mt_Supermenu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupermenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSupermenuHandle)))));
		}
		[Export("setSupermenu:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSupermenu_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSupermenu_Handle, value.Handle);
			}
			__mt_Supermenu_var = value;
		}
	}

	public virtual bool AutoEnablesItems
	{
		[Export("autoenablesItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoenablesItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoenablesItemsHandle);
		}
		[Export("setAutoenablesItems:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoenablesItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoenablesItems_Handle, value);
			}
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value.Handle);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSMenuDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSMenuDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual double MinimumWidth
	{
		[Export("minimumWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinimumWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinimumWidthHandle);
		}
		[Export("setMinimumWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinimumWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinimumWidth_Handle, value);
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

	public virtual bool AllowsContextMenuPlugIns
	{
		[Export("allowsContextMenuPlugIns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsContextMenuPlugInsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsContextMenuPlugInsHandle);
		}
		[Export("setAllowsContextMenuPlugIns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsContextMenuPlugIns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsContextMenuPlugIns_Handle, value);
			}
		}
	}

	public virtual bool ShowsStateColumn
	{
		[Export("showsStateColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsStateColumnHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsStateColumnHandle);
		}
		[Export("setShowsStateColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsStateColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsStateColumn_Handle, value);
			}
		}
	}

	public virtual bool MenuChangedMessagesEnabled
	{
		[Export("menuChangedMessagesEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMenuChangedMessagesEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMenuChangedMessagesEnabledHandle);
		}
		[Export("setMenuChangedMessagesEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMenuChangedMessagesEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMenuChangedMessagesEnabled_Handle, value);
			}
		}
	}

	private NSMenuItem InsertItem(string title, string charCode, int index)
	{
		return InsertItem(title, null, charCode, index);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMenu()
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
	public NSMenu(NSCoder coder)
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
	public NSMenu(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMenu(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTitle:")]
	public NSMenu(string aTitle)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aTitle == null)
		{
			throw new ArgumentNullException("aTitle");
		}
		IntPtr arg = NSString.CreateNative(aTitle);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTitle_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTitle_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("popUpContextMenu:withEvent:forView:")]
	public static void PopUpContextMenu(NSMenu menu, NSEvent theEvent, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selPopUpContextMenuWithEventForView_Handle, menu.Handle, theEvent.Handle, view.Handle);
	}

	[Export("popUpContextMenu:withEvent:forView:withFont:")]
	public static void PopUpContextMenu(NSMenu menu, NSEvent theEvent, NSView view, NSFont font)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selPopUpContextMenuWithEventForViewWithFont_Handle, menu.Handle, theEvent.Handle, view.Handle, font?.Handle ?? IntPtr.Zero);
	}

	[Export("popUpMenuPositioningItem:atLocation:inView:")]
	public virtual bool PopUpMenu(NSMenuItem item, CGPoint location, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGPoint_IntPtr(base.Handle, selPopUpMenuPositioningItemAtLocationInView_Handle, item?.Handle ?? IntPtr.Zero, location, view?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGPoint_IntPtr(base.SuperHandle, selPopUpMenuPositioningItemAtLocationInView_Handle, item?.Handle ?? IntPtr.Zero, location, view?.Handle ?? IntPtr.Zero);
	}

	[Export("insertItem:atIndex:")]
	public virtual void InsertItem(NSMenuItem newItem, long index)
	{
		NSApplication.EnsureUIThread();
		if (newItem == null)
		{
			throw new ArgumentNullException("newItem");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selInsertItemAtIndex_Handle, newItem.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInsertItemAtIndex_Handle, newItem.Handle, index);
		}
		__mt_items_var = ItemArray();
	}

	[Export("addItem:")]
	public virtual void AddItem(NSMenuItem newItem)
	{
		NSApplication.EnsureUIThread();
		if (newItem == null)
		{
			throw new ArgumentNullException("newItem");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItem_Handle, newItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItem_Handle, newItem.Handle);
		}
		__mt_items_var = ItemArray();
	}

	[Export("insertItemWithTitle:action:keyEquivalent:atIndex:")]
	public virtual NSMenuItem InsertItem(string title, Selector action, string charCode, long index)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (charCode == null)
		{
			throw new ArgumentNullException("charCode");
		}
		IntPtr arg = NSString.CreateNative(title);
		IntPtr arg2 = NSString.CreateNative(charCode);
		NSMenuItem result = ((!IsDirectBinding) ? ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Int64(base.SuperHandle, selInsertItemWithTitleActionKeyEquivalentAtIndex_Handle, arg, (action == null) ? IntPtr.Zero : action.Handle, arg2, index))) : ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64(base.Handle, selInsertItemWithTitleActionKeyEquivalentAtIndex_Handle, arg, (action == null) ? IntPtr.Zero : action.Handle, arg2, index))));
		__mt_items_var = ItemArray();
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("addItemWithTitle:action:keyEquivalent:")]
	public virtual NSMenuItem AddItem(string title, Selector action, string charCode)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (charCode == null)
		{
			throw new ArgumentNullException("charCode");
		}
		IntPtr arg = NSString.CreateNative(title);
		IntPtr arg2 = NSString.CreateNative(charCode);
		NSMenuItem result = ((!IsDirectBinding) ? ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddItemWithTitleActionKeyEquivalent_Handle, arg, (action == null) ? IntPtr.Zero : action.Handle, arg2))) : ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddItemWithTitleActionKeyEquivalent_Handle, arg, (action == null) ? IntPtr.Zero : action.Handle, arg2))));
		__mt_items_var = ItemArray();
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("removeItemAtIndex:")]
	public virtual void RemoveItemAt(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveItemAtIndex_Handle, index);
		}
		__mt_items_var = ItemArray();
	}

	[Export("removeItem:")]
	public virtual void RemoveItem(NSMenuItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItem_Handle, item.Handle);
		}
		__mt_items_var = ItemArray();
	}

	[Export("setSubmenu:forItem:")]
	public virtual void SetSubmenu(NSMenu aMenu, NSMenuItem anItem)
	{
		NSApplication.EnsureUIThread();
		if (aMenu == null)
		{
			throw new ArgumentNullException("aMenu");
		}
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetSubmenuForItem_Handle, aMenu.Handle, anItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetSubmenuForItem_Handle, aMenu.Handle, anItem.Handle);
		}
	}

	[Export("removeAllItems")]
	public virtual void RemoveAllItems()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllItemsHandle);
		}
		__mt_items_var = ItemArray();
	}

	[Export("itemArray")]
	public virtual NSMenuItem[] ItemArray()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemArrayHandle));
		}
		return NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemArrayHandle));
	}

	[Export("itemAtIndex:")]
	public virtual NSMenuItem ItemAt(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selItemAtIndex_Handle, index));
		}
		return (NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selItemAtIndex_Handle, index));
	}

	[Export("indexOfItem:")]
	public virtual long IndexOf(NSMenuItem index)
	{
		NSApplication.EnsureUIThread();
		if (index == null)
		{
			throw new ArgumentNullException("index");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selIndexOfItem_Handle, index.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItem_Handle, index.Handle);
	}

	[Export("indexOfItemWithTitle:")]
	public virtual long IndexOf(string aTitle)
	{
		NSApplication.EnsureUIThread();
		if (aTitle == null)
		{
			throw new ArgumentNullException("aTitle");
		}
		IntPtr arg = NSString.CreateNative(aTitle);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithTitle_Handle, arg) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithTitle_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("indexOfItemWithTag:")]
	public virtual long IndexOf(long itemTag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selIndexOfItemWithTag_Handle, itemTag);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selIndexOfItemWithTag_Handle, itemTag);
	}

	[Export("indexOfItemWithRepresentedObject:")]
	public virtual long IndexOfItem(NSObject obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithRepresentedObject_Handle, obj.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithRepresentedObject_Handle, obj.Handle);
	}

	[Export("indexOfItemWithSubmenu:")]
	public virtual long IndexOfItem(NSMenu submenu)
	{
		NSApplication.EnsureUIThread();
		if (submenu == null)
		{
			throw new ArgumentNullException("submenu");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithSubmenu_Handle, submenu.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithSubmenu_Handle, submenu.Handle);
	}

	[Export("indexOfItemWithTarget:andAction:")]
	public virtual long IndexOfItem(NSObject target, Selector actionSelector)
	{
		NSApplication.EnsureUIThread();
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (actionSelector == null)
		{
			throw new ArgumentNullException("actionSelector");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr_IntPtr(base.Handle, selIndexOfItemWithTargetAndAction_Handle, target.Handle, actionSelector.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIndexOfItemWithTargetAndAction_Handle, target.Handle, actionSelector.Handle);
	}

	[Export("itemWithTitle:")]
	public virtual NSMenuItem ItemWithTitle(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSMenuItem result = ((!IsDirectBinding) ? ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemWithTitle_Handle, arg))) : ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemWithTitle_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("itemWithTag:")]
	public virtual NSMenuItem ItemWithTag(long tag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selItemWithTag_Handle, tag));
		}
		return (NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selItemWithTag_Handle, tag));
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

	[Export("performKeyEquivalent:")]
	public virtual bool PerformKeyEquivalent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformKeyEquivalent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformKeyEquivalent_Handle, theEvent.Handle);
	}

	[Export("itemChanged:")]
	public virtual void ItemChanged(NSMenuItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selItemChanged_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemChanged_Handle, item.Handle);
		}
	}

	[Export("performActionForItemAtIndex:")]
	public virtual void PerformActionForItem(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selPerformActionForItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selPerformActionForItemAtIndex_Handle, index);
		}
	}

	[Export("cancelTracking")]
	public virtual void CancelTracking()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelTrackingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelTrackingHandle);
		}
	}

	[Export("cancelTrackingWithoutAnimation")]
	public virtual void CancelTrackingWithoutAnimation()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelTrackingWithoutAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelTrackingWithoutAnimationHandle);
		}
	}

	[Export("helpRequested:")]
	public virtual void HelpRequested(NSEvent eventPtr)
	{
		NSApplication.EnsureUIThread();
		if (eventPtr == null)
		{
			throw new ArgumentNullException("eventPtr");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selHelpRequested_Handle, eventPtr.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selHelpRequested_Handle, eventPtr.Handle);
		}
	}

	[Export("propertiesToUpdate")]
	public virtual NSMenuProperty PropertiesToUpdate()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSMenuProperty)Messaging.UInt64_objc_msgSend(base.Handle, selPropertiesToUpdateHandle);
		}
		return (NSMenuProperty)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPropertiesToUpdateHandle);
	}

	protected override void Dispose(bool disposing)
	{
		__mt_items_var = null;
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_HighlightedItem_var = null;
			__mt_Supermenu_var = null;
			__mt_WeakDelegate_var = null;
			__mt_Font_var = null;
		}
	}
}
