using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPopUpButton", true)]
public class NSPopUpButton : NSButton
{
	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	private static readonly IntPtr selLastItemHandle = Selector.GetHandle("lastItem");

	private static readonly IntPtr selSelectedItemHandle = Selector.GetHandle("selectedItem");

	private static readonly IntPtr selIndexOfSelectedItemHandle = Selector.GetHandle("indexOfSelectedItem");

	private static readonly IntPtr selTitleOfSelectedItemHandle = Selector.GetHandle("titleOfSelectedItem");

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	private static readonly IntPtr selPullsDownHandle = Selector.GetHandle("pullsDown");

	private static readonly IntPtr selSetPullsDown_Handle = Selector.GetHandle("setPullsDown:");

	private static readonly IntPtr selAutoenablesItemsHandle = Selector.GetHandle("autoenablesItems");

	private static readonly IntPtr selSetAutoenablesItems_Handle = Selector.GetHandle("setAutoenablesItems:");

	private static readonly IntPtr selPreferredEdgeHandle = Selector.GetHandle("preferredEdge");

	private static readonly IntPtr selSetPreferredEdge_Handle = Selector.GetHandle("setPreferredEdge:");

	private static readonly IntPtr selInitWithFramePullsDown_Handle = Selector.GetHandle("initWithFrame:pullsDown:");

	private static readonly IntPtr selAddItemWithTitle_Handle = Selector.GetHandle("addItemWithTitle:");

	private static readonly IntPtr selAddItemsWithTitles_Handle = Selector.GetHandle("addItemsWithTitles:");

	private static readonly IntPtr selInsertItemWithTitleAtIndex_Handle = Selector.GetHandle("insertItemWithTitle:atIndex:");

	private static readonly IntPtr selRemoveItemWithTitle_Handle = Selector.GetHandle("removeItemWithTitle:");

	private static readonly IntPtr selRemoveItemAtIndex_Handle = Selector.GetHandle("removeItemAtIndex:");

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	private static readonly IntPtr selItemArrayHandle = Selector.GetHandle("itemArray");

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

	private static readonly IntPtr selItemTitlesHandle = Selector.GetHandle("itemTitles");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPopUpButton");

	private object __mt_LastItem_var;

	private object __mt_SelectedItem_var;

	private object __mt_Menu_var;

	public new NSPopUpButtonCell Cell
	{
		get
		{
			return (NSPopUpButtonCell)base.Cell;
		}
		set
		{
			base.Cell = value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual long ItemCount
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

	public virtual long IndexOfSelectedItem
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPopUpButton()
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
	public NSPopUpButton(NSCoder coder)
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
	public NSPopUpButton(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPopUpButton(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:pullsDown:")]
	public NSPopUpButton(CGRect buttonFrame, bool pullsDown)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_bool(base.Handle, selInitWithFramePullsDown_Handle, buttonFrame, pullsDown);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_bool(base.SuperHandle, selInitWithFramePullsDown_Handle, buttonFrame, pullsDown);
		}
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
	public virtual void RemoveItem(long index)
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

	[Export("itemArray")]
	public virtual NSMenuItem[] Items()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemArrayHandle));
		}
		return NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemArrayHandle));
	}

	[Export("indexOfItem:")]
	public virtual long IndexOfItem(NSMenuItem item)
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
	public virtual long IndexOfItem(string title)
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
	public virtual long IndexOfItem(long tag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selIndexOfItemWithTag_Handle, tag);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selIndexOfItemWithTag_Handle, tag);
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

	[Export("itemAtIndex:")]
	public virtual NSMenuItem ItemAtIndex(long index)
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("selectItemAtIndex:")]
	public virtual void SelectItem(long index)
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
	public virtual void SelectItem(string title)
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
	public virtual string ItemTitle(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selItemTitleAtIndex_Handle, index));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selItemTitleAtIndex_Handle, index));
	}

	[Export("itemTitles")]
	public virtual string[] ItemTitles()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selItemTitlesHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemTitlesHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_LastItem_var = null;
			__mt_SelectedItem_var = null;
			__mt_Menu_var = null;
		}
	}
}
