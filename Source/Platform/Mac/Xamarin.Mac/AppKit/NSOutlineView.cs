using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOutlineView", true)]
public class NSOutlineView : NSTableView
{
	private static readonly IntPtr selOutlineTableColumnHandle = Selector.GetHandle("outlineTableColumn");

	private static readonly IntPtr selSetOutlineTableColumn_Handle = Selector.GetHandle("setOutlineTableColumn:");

	private static readonly IntPtr selIndentationPerLevelHandle = Selector.GetHandle("indentationPerLevel");

	private static readonly IntPtr selSetIndentationPerLevel_Handle = Selector.GetHandle("setIndentationPerLevel:");

	private static readonly IntPtr selIndentationMarkerFollowsCellHandle = Selector.GetHandle("indentationMarkerFollowsCell");

	private static readonly IntPtr selSetIndentationMarkerFollowsCell_Handle = Selector.GetHandle("setIndentationMarkerFollowsCell:");

	private static readonly IntPtr selAutoresizesOutlineColumnHandle = Selector.GetHandle("autoresizesOutlineColumn");

	private static readonly IntPtr selSetAutoresizesOutlineColumn_Handle = Selector.GetHandle("setAutoresizesOutlineColumn:");

	private static readonly IntPtr selAutosaveExpandedItemsHandle = Selector.GetHandle("autosaveExpandedItems");

	private static readonly IntPtr selSetAutosaveExpandedItems_Handle = Selector.GetHandle("setAutosaveExpandedItems:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	private static readonly IntPtr selIsExpandable_Handle = Selector.GetHandle("isExpandable:");

	private static readonly IntPtr selExpandItemExpandChildren_Handle = Selector.GetHandle("expandItem:expandChildren:");

	private static readonly IntPtr selExpandItem_Handle = Selector.GetHandle("expandItem:");

	private static readonly IntPtr selCollapseItemCollapseChildren_Handle = Selector.GetHandle("collapseItem:collapseChildren:");

	private static readonly IntPtr selCollapseItem_Handle = Selector.GetHandle("collapseItem:");

	private static readonly IntPtr selReloadItemReloadChildren_Handle = Selector.GetHandle("reloadItem:reloadChildren:");

	private static readonly IntPtr selReloadItem_Handle = Selector.GetHandle("reloadItem:");

	private static readonly IntPtr selParentForItem_Handle = Selector.GetHandle("parentForItem:");

	private static readonly IntPtr selItemAtRow_Handle = Selector.GetHandle("itemAtRow:");

	private static readonly IntPtr selRowForItem_Handle = Selector.GetHandle("rowForItem:");

	private static readonly IntPtr selLevelForItem_Handle = Selector.GetHandle("levelForItem:");

	private static readonly IntPtr selLevelForRow_Handle = Selector.GetHandle("levelForRow:");

	private static readonly IntPtr selIsItemExpanded_Handle = Selector.GetHandle("isItemExpanded:");

	private static readonly IntPtr selFrameOfOutlineCellAtRow_Handle = Selector.GetHandle("frameOfOutlineCellAtRow:");

	private static readonly IntPtr selSetDropItemDropChildIndex_Handle = Selector.GetHandle("setDropItem:dropChildIndex:");

	private static readonly IntPtr selShouldCollapseAutoExpandedItemsForDeposited_Handle = Selector.GetHandle("shouldCollapseAutoExpandedItemsForDeposited:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOutlineView");

	private object __mt_OutlineTableColumn_var;

	private object __mt_WeakDelegate_var;

	private object __mt_WeakDataSource_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSTableColumn OutlineTableColumn
	{
		[Export("outlineTableColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTableColumn)(__mt_OutlineTableColumn_var = ((!IsDirectBinding) ? ((NSTableColumn)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutlineTableColumnHandle))) : ((NSTableColumn)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutlineTableColumnHandle)))));
		}
		[Export("setOutlineTableColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutlineTableColumn_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutlineTableColumn_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_OutlineTableColumn_var = value;
		}
	}

	public virtual double IndentationPerLevel
	{
		[Export("indentationPerLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selIndentationPerLevelHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selIndentationPerLevelHandle);
		}
		[Export("setIndentationPerLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetIndentationPerLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetIndentationPerLevel_Handle, value);
			}
		}
	}

	public virtual bool IndentationMarkerFollowsCell
	{
		[Export("indentationMarkerFollowsCell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIndentationMarkerFollowsCellHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIndentationMarkerFollowsCellHandle);
		}
		[Export("setIndentationMarkerFollowsCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIndentationMarkerFollowsCell_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIndentationMarkerFollowsCell_Handle, value);
			}
		}
	}

	public virtual bool AutoresizesOutlineColumn
	{
		[Export("autoresizesOutlineColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoresizesOutlineColumnHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoresizesOutlineColumnHandle);
		}
		[Export("setAutoresizesOutlineColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoresizesOutlineColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoresizesOutlineColumn_Handle, value);
			}
		}
	}

	public virtual bool AutosaveExpandedItems
	{
		[Export("autosaveExpandedItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosaveExpandedItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosaveExpandedItemsHandle);
		}
		[Export("setAutosaveExpandedItems:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosaveExpandedItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosaveExpandedItems_Handle, value);
			}
		}
	}

	public new virtual NSObject WeakDelegate
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

	public new NSOutlineViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSOutlineViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public new virtual NSObject WeakDataSource
	{
		[Export("dataSource")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDataSource_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle))));
		}
		[Export("setDataSource:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value.Handle);
			}
			__mt_WeakDataSource_var = value;
		}
	}

	public new NSOutlineViewDataSource DataSource
	{
		get
		{
			return WeakDataSource as NSOutlineViewDataSource;
		}
		set
		{
			WeakDataSource = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOutlineView()
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
	public NSOutlineView(NSCoder coder)
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
	public NSOutlineView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOutlineView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isExpandable:")]
	public virtual bool IsExpandable(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsExpandable_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsExpandable_Handle, item.Handle);
	}

	[Export("expandItem:expandChildren:")]
	public virtual void ExpandItem(NSObject item, bool expandChildren)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selExpandItemExpandChildren_Handle, item?.Handle ?? IntPtr.Zero, expandChildren);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selExpandItemExpandChildren_Handle, item?.Handle ?? IntPtr.Zero, expandChildren);
		}
	}

	[Export("expandItem:")]
	public virtual void ExpandItem(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selExpandItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selExpandItem_Handle, item.Handle);
		}
	}

	[Export("collapseItem:collapseChildren:")]
	public virtual void CollapseItem(NSObject item, bool collapseChildren)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selCollapseItemCollapseChildren_Handle, item?.Handle ?? IntPtr.Zero, collapseChildren);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selCollapseItemCollapseChildren_Handle, item?.Handle ?? IntPtr.Zero, collapseChildren);
		}
	}

	[Export("collapseItem:")]
	public virtual void CollapseItem(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCollapseItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCollapseItem_Handle, item.Handle);
		}
	}

	[Export("reloadItem:reloadChildren:")]
	public virtual void ReloadItem(NSObject item, bool reloadChildren)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selReloadItemReloadChildren_Handle, item?.Handle ?? IntPtr.Zero, reloadChildren);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selReloadItemReloadChildren_Handle, item?.Handle ?? IntPtr.Zero, reloadChildren);
		}
	}

	[Export("reloadItem:")]
	public virtual void ReloadItem(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadItem_Handle, item.Handle);
		}
	}

	[Export("parentForItem:")]
	public virtual NSObject GetParent(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selParentForItem_Handle, item.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selParentForItem_Handle, item.Handle));
	}

	[Export("itemAtRow:")]
	public virtual NSObject ItemAtRow(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selItemAtRow_Handle, row));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selItemAtRow_Handle, row));
	}

	[Export("rowForItem:")]
	public virtual long RowForItem(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selRowForItem_Handle, item.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selRowForItem_Handle, item.Handle);
	}

	[Export("levelForItem:")]
	public virtual long LevelForItem(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selLevelForItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selLevelForItem_Handle, item?.Handle ?? IntPtr.Zero);
	}

	[Export("levelForRow:")]
	public virtual long LevelForRow(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selLevelForRow_Handle, row);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selLevelForRow_Handle, row);
	}

	[Export("isItemExpanded:")]
	public virtual bool IsItemExpanded(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsItemExpanded_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsItemExpanded_Handle, item.Handle);
	}

	[Export("frameOfOutlineCellAtRow:")]
	public virtual CGRect FrameOfOutlineCellAtRow(long row)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selFrameOfOutlineCellAtRow_Handle, row);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selFrameOfOutlineCellAtRow_Handle, row);
		}
		return retval;
	}

	[Export("setDropItem:dropChildIndex:")]
	public virtual void SetDropItem(NSObject item, long index)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetDropItemDropChildIndex_Handle, item.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetDropItemDropChildIndex_Handle, item.Handle, index);
		}
	}

	[Export("shouldCollapseAutoExpandedItemsForDeposited:")]
	public virtual bool ShouldCollapseAutoExpandedItems(bool forDeposited)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_bool(base.Handle, selShouldCollapseAutoExpandedItemsForDeposited_Handle, forDeposited);
		}
		return Messaging.bool_objc_msgSendSuper_bool(base.SuperHandle, selShouldCollapseAutoExpandedItemsForDeposited_Handle, forDeposited);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OutlineTableColumn_var = null;
			__mt_WeakDelegate_var = null;
			__mt_WeakDataSource_var = null;
		}
	}
}
