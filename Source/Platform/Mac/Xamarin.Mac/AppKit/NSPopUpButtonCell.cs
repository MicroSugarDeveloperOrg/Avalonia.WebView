using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPopUpButtonCell", true)]
public class NSPopUpButtonCell : NSMenuItemCell
{
	private static readonly IntPtr selItemArrayHandle = Selector.GetHandle("itemArray");

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	private static readonly IntPtr selLastItemHandle = Selector.GetHandle("lastItem");

	private static readonly IntPtr selSelectedItemHandle = Selector.GetHandle("selectedItem");

	private static readonly IntPtr selIndexOfSelectedItemHandle = Selector.GetHandle("indexOfSelectedItem");

	private static readonly IntPtr selItemTitlesHandle = Selector.GetHandle("itemTitles");

	private static readonly IntPtr selTitleOfSelectedItemHandle = Selector.GetHandle("titleOfSelectedItem");

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	private static readonly IntPtr selPullsDownHandle = Selector.GetHandle("pullsDown");

	private static readonly IntPtr selSetPullsDown_Handle = Selector.GetHandle("setPullsDown:");

	private static readonly IntPtr selAutoenablesItemsHandle = Selector.GetHandle("autoenablesItems");

	private static readonly IntPtr selSetAutoenablesItems_Handle = Selector.GetHandle("setAutoenablesItems:");

	private static readonly IntPtr selPreferredEdgeHandle = Selector.GetHandle("preferredEdge");

	private static readonly IntPtr selSetPreferredEdge_Handle = Selector.GetHandle("setPreferredEdge:");

	private static readonly IntPtr selUsesItemFromMenuHandle = Selector.GetHandle("usesItemFromMenu");

	private static readonly IntPtr selSetUsesItemFromMenu_Handle = Selector.GetHandle("setUsesItemFromMenu:");

	private static readonly IntPtr selAltersStateOfSelectedItemHandle = Selector.GetHandle("altersStateOfSelectedItem");

	private static readonly IntPtr selSetAltersStateOfSelectedItem_Handle = Selector.GetHandle("setAltersStateOfSelectedItem:");

	private static readonly IntPtr selArrowPositionHandle = Selector.GetHandle("arrowPosition");

	private static readonly IntPtr selSetArrowPosition_Handle = Selector.GetHandle("setArrowPosition:");

	private static readonly IntPtr selObjectValueHandle = Selector.GetHandle("objectValue");

	private static readonly IntPtr selSetObjectValue_Handle = Selector.GetHandle("setObjectValue:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selInitTextCellPullsDown_Handle = Selector.GetHandle("initTextCell:pullsDown:");

	private static readonly IntPtr selAddItemWithTitle_Handle = Selector.GetHandle("addItemWithTitle:");

	private static readonly IntPtr selAddItemsWithTitles_Handle = Selector.GetHandle("addItemsWithTitles:");

	private static readonly IntPtr selInsertItemWithTitleAtIndex_Handle = Selector.GetHandle("insertItemWithTitle:atIndex:");

	private static readonly IntPtr selRemoveItemWithTitle_Handle = Selector.GetHandle("removeItemWithTitle:");

	private static readonly IntPtr selRemoveItemAtIndex_Handle = Selector.GetHandle("removeItemAtIndex:");

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	private static readonly IntPtr selIndexOfItem_Handle = Selector.GetHandle("indexOfItem:");

	private static readonly IntPtr selIndexOfItemWithTitle_Handle = Selector.GetHandle("indexOfItemWithTitle:");

	private static readonly IntPtr selIndexOfItemWithTag_Handle = Selector.GetHandle("indexOfItemWithTag:");

	private static readonly IntPtr selIndexOfItemWithRepresentedObject_Handle = Selector.GetHandle("indexOfItemWithRepresentedObject:");

	private static readonly IntPtr selIndexOfItemWithTargetAndAction_Handle = Selector.GetHandle("indexOfItemWithTarget:andAction:");

	private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

	private static readonly IntPtr selItemWithTitle_Handle = Selector.GetHandle("itemWithTitle:");

	private static readonly IntPtr selSelectItem_Handle = Selector.GetHandle("selectItem:");

	private static readonly IntPtr selSelectItemAtIndex_Handle = Selector.GetHandle("selectItemAtIndex:");

	private static readonly IntPtr selSelectItemWithTitle_Handle = Selector.GetHandle("selectItemWithTitle:");

	private static readonly IntPtr selSelectItemWithTag_Handle = Selector.GetHandle("selectItemWithTag:");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selSynchronizeTitleAndSelectedItemHandle = Selector.GetHandle("synchronizeTitleAndSelectedItem");

	private static readonly IntPtr selItemTitleAtIndex_Handle = Selector.GetHandle("itemTitleAtIndex:");

	private static readonly IntPtr selAttachPopUpWithFrameInView_Handle = Selector.GetHandle("attachPopUpWithFrame:inView:");

	private static readonly IntPtr selDismissPopUpHandle = Selector.GetHandle("dismissPopUp");

	private static readonly IntPtr selPerformClickWithFrameInView_Handle = Selector.GetHandle("performClickWithFrame:inView:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPopUpButtonCell");

	private object __mt_Items_var;

	private object __mt_LastItem_var;

	private object __mt_SelectedItem_var;

	private object __mt_Menu_var;

	private object __mt_ObjectValue_var;

	public NSMenuItem this[int idx] => ItemAt(idx);

	public NSMenuItem this[string title] => ItemWithTitle(title);

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSMenuItem[] Items
	{
		[Export("itemArray")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuItem[])(__mt_Items_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemArrayHandle)) : NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemArrayHandle))));
		}
	}

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

	public virtual NSMenuItem LastItem
	{
		[Export("lastItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuItem)(__mt_LastItem_var = ((!IsDirectBinding) ? ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastItemHandle))) : ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLastItemHandle)))));
		}
	}

	public virtual NSMenuItem SelectedItem
	{
		[Export("selectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenuItem)(__mt_SelectedItem_var = ((!IsDirectBinding) ? ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedItemHandle))) : ((NSMenuItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedItemHandle)))));
		}
	}

	public virtual long SelectedItemIndex
	{
		[Export("indexOfSelectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selIndexOfSelectedItemHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selIndexOfSelectedItemHandle);
		}
	}

	public virtual string[] ItemTitles
	{
		[Export("itemTitles")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selItemTitlesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemTitlesHandle));
		}
	}

	public virtual string TitleOfSelectedItem
	{
		[Export("titleOfSelectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleOfSelectedItemHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleOfSelectedItemHandle));
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

	public virtual bool PullsDown
	{
		[Export("pullsDown")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPullsDownHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPullsDownHandle);
		}
		[Export("setPullsDown:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPullsDown_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPullsDown_Handle, value);
			}
		}
	}

	public virtual bool AutoenablesItems
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

	public virtual NSRectEdge PreferredEdge
	{
		[Export("preferredEdge")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSRectEdge)Messaging.int_objc_msgSend(base.Handle, selPreferredEdgeHandle);
			}
			return (NSRectEdge)Messaging.int_objc_msgSendSuper(base.SuperHandle, selPreferredEdgeHandle);
		}
		[Export("setPreferredEdge:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetPreferredEdge_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetPreferredEdge_Handle, (int)value);
			}
		}
	}

	public virtual bool UsesItemFromMenu
	{
		[Export("usesItemFromMenu")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesItemFromMenuHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesItemFromMenuHandle);
		}
		[Export("setUsesItemFromMenu:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesItemFromMenu_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesItemFromMenu_Handle, value);
			}
		}
	}

	public virtual bool AltersStateOfSelectedItem
	{
		[Export("altersStateOfSelectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAltersStateOfSelectedItemHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAltersStateOfSelectedItemHandle);
		}
		[Export("setAltersStateOfSelectedItem:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAltersStateOfSelectedItem_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAltersStateOfSelectedItem_Handle, value);
			}
		}
	}

	public virtual NSPopUpArrowPosition ArrowPosition
	{
		[Export("arrowPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPopUpArrowPosition)Messaging.UInt64_objc_msgSend(base.Handle, selArrowPositionHandle);
			}
			return (NSPopUpArrowPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selArrowPositionHandle);
		}
		[Export("setArrowPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetArrowPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetArrowPosition_Handle, (ulong)value);
			}
		}
	}

	public new virtual NSObject ObjectValue
	{
		[Export("objectValue")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_ObjectValue_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValueHandle))));
		}
		[Export("setObjectValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectValue_Handle, value.Handle);
			}
			__mt_ObjectValue_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPopUpButtonCell()
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
	public NSPopUpButtonCell(NSCoder coder)
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
	public NSPopUpButtonCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPopUpButtonCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSPopUpButtonCell(string aString)
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
	public NSPopUpButtonCell(NSImage image)
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

	[Export("initTextCell:pullsDown:")]
	public NSPopUpButtonCell(string stringValue, bool pullDown)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (stringValue == null)
		{
			throw new ArgumentNullException("stringValue");
		}
		IntPtr arg = NSString.CreateNative(stringValue);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitTextCellPullsDown_Handle, arg, pullDown);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitTextCellPullsDown_Handle, arg, pullDown);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addItemWithTitle:")]
	public virtual void AddItem(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItemWithTitle_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItemWithTitle_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addItemsWithTitles:")]
	public virtual void AddItems(string[] itemTitles)
	{
		NSApplication.EnsureUIThread();
		if (itemTitles == null)
		{
			throw new ArgumentNullException("itemTitles");
		}
		NSArray nSArray = NSArray.FromStrings(itemTitles);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItemsWithTitles_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItemsWithTitles_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("insertItemWithTitle:atIndex:")]
	public virtual void InsertItem(string title, long index)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selInsertItemWithTitleAtIndex_Handle, arg, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInsertItemWithTitleAtIndex_Handle, arg, index);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeItemWithTitle:")]
	public virtual void RemoveItem(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItemWithTitle_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItemWithTitle_Handle, arg);
		}
		NSString.ReleaseNative(arg);
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
	}

	[Export("indexOfItem:")]
	public virtual long IndexOf(NSMenuItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selIndexOfItem_Handle, item.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItem_Handle, item.Handle);
	}

	[Export("indexOfItemWithTitle:")]
	public virtual long IndexOfItemWithTitle(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithTitle_Handle, arg) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithTitle_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("indexOfItemWithTag:")]
	public virtual long IndexOfItemWithTag(long tag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selIndexOfItemWithTag_Handle, tag);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selIndexOfItemWithTag_Handle, tag);
	}

	[Export("indexOfItemWithRepresentedObject:")]
	public virtual long IndexOfItemWithRepresentedObject(NSObject obj)
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

	[Export("indexOfItemWithTarget:andAction:")]
	public virtual long IndexOfItemWithTargetandAction(NSObject target, Selector actionSelector)
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

	[Export("selectItem:")]
	public virtual void SelectItem(NSMenuItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectItem_Handle, item.Handle);
		}
	}

	[Export("selectItemAtIndex:")]
	public virtual void SelectItemAt(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSelectItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSelectItemAtIndex_Handle, index);
		}
	}

	[Export("selectItemWithTitle:")]
	public virtual void SelectItemWithTitle(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectItemWithTitle_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectItemWithTitle_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("selectItemWithTag:")]
	public virtual bool SelectItemWithTag(long tag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selSelectItemWithTag_Handle, tag);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selSelectItemWithTag_Handle, tag);
	}

	[Export("setTitle:")]
	public virtual void SetTitle(string aString)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
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

	[Export("synchronizeTitleAndSelectedItem")]
	public virtual void SynchronizeTitleAndSelectedItem()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSynchronizeTitleAndSelectedItemHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSynchronizeTitleAndSelectedItemHandle);
		}
	}

	[Export("itemTitleAtIndex:")]
	public virtual string GetItemTitle(int index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItemTitleAtIndex_Handle, index));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItemTitleAtIndex_Handle, index));
	}

	[Export("attachPopUpWithFrame:inView:")]
	public virtual void AttachPopUp(CGRect cellFrame, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selAttachPopUpWithFrameInView_Handle, cellFrame, inView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selAttachPopUpWithFrameInView_Handle, cellFrame, inView.Handle);
		}
	}

	[Export("dismissPopUp")]
	public virtual void DismissPopUp()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDismissPopUpHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDismissPopUpHandle);
		}
	}

	[Export("performClickWithFrame:inView:")]
	public virtual void PerformClick(CGRect withFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selPerformClickWithFrameInView_Handle, withFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selPerformClickWithFrameInView_Handle, withFrame, controlView.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Items_var = null;
			__mt_LastItem_var = null;
			__mt_SelectedItem_var = null;
			__mt_Menu_var = null;
			__mt_ObjectValue_var = null;
		}
	}
}
