using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOutlineView", true)]
public class NSOutlineView : NSTableView, INSAccessibilityElementProtocol, INativeObject, IDisposable, INSAccessibilityGroup, INSAccessibilityOutline, INSAccessibilityTable
{
	public new static class Notifications
	{
		public static NSObject ObserveColumnDidMove(EventHandler<NSViewColumnMoveEventArgs> handler)
		{
			EventHandler<NSViewColumnMoveEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnDidMoveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSViewColumnMoveEventArgs(notification));
			});
		}

		public static NSObject ObserveColumnDidMove(NSObject objectToObserve, EventHandler<NSViewColumnMoveEventArgs> handler)
		{
			EventHandler<NSViewColumnMoveEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnDidMoveNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSViewColumnMoveEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveColumnDidResize(EventHandler<NSViewColumnResizeEventArgs> handler)
		{
			EventHandler<NSViewColumnResizeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnDidResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSViewColumnResizeEventArgs(notification));
			});
		}

		public static NSObject ObserveColumnDidResize(NSObject objectToObserve, EventHandler<NSViewColumnResizeEventArgs> handler)
		{
			EventHandler<NSViewColumnResizeEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColumnDidResizeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSViewColumnResizeEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveItemDidCollapse(EventHandler<NSOutlineViewItemEventArgs> handler)
		{
			EventHandler<NSOutlineViewItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemDidCollapseNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSOutlineViewItemEventArgs(notification));
			});
		}

		public static NSObject ObserveItemDidCollapse(NSObject objectToObserve, EventHandler<NSOutlineViewItemEventArgs> handler)
		{
			EventHandler<NSOutlineViewItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemDidCollapseNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSOutlineViewItemEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveItemDidExpand(EventHandler<NSOutlineViewItemEventArgs> handler)
		{
			EventHandler<NSOutlineViewItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemDidExpandNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSOutlineViewItemEventArgs(notification));
			});
		}

		public static NSObject ObserveItemDidExpand(NSObject objectToObserve, EventHandler<NSOutlineViewItemEventArgs> handler)
		{
			EventHandler<NSOutlineViewItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemDidExpandNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSOutlineViewItemEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveItemWillCollapse(EventHandler<NSOutlineViewItemEventArgs> handler)
		{
			EventHandler<NSOutlineViewItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemWillCollapseNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSOutlineViewItemEventArgs(notification));
			});
		}

		public static NSObject ObserveItemWillCollapse(NSObject objectToObserve, EventHandler<NSOutlineViewItemEventArgs> handler)
		{
			EventHandler<NSOutlineViewItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemWillCollapseNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSOutlineViewItemEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveItemWillExpand(EventHandler<NSOutlineViewItemEventArgs> handler)
		{
			EventHandler<NSOutlineViewItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemWillExpandNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSOutlineViewItemEventArgs(notification));
			});
		}

		public static NSObject ObserveItemWillExpand(NSObject objectToObserve, EventHandler<NSOutlineViewItemEventArgs> handler)
		{
			EventHandler<NSOutlineViewItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemWillExpandNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSOutlineViewItemEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectionIsChanging(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionIsChangingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionIsChanging(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionIsChangingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumnHeaderUIElements = "accessibilityColumnHeaderUIElements";

	private static readonly IntPtr selAccessibilityColumnHeaderUIElementsHandle = Selector.GetHandle("accessibilityColumnHeaderUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityColumns = "accessibilityColumns";

	private static readonly IntPtr selAccessibilityColumnsHandle = Selector.GetHandle("accessibilityColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityHeaderGroup = "accessibilityHeaderGroup";

	private static readonly IntPtr selAccessibilityHeaderGroupHandle = Selector.GetHandle("accessibilityHeaderGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabel = "accessibilityLabel";

	private static readonly IntPtr selAccessibilityLabelHandle = Selector.GetHandle("accessibilityLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRowHeaderUIElements = "accessibilityRowHeaderUIElements";

	private static readonly IntPtr selAccessibilityRowHeaderUIElementsHandle = Selector.GetHandle("accessibilityRowHeaderUIElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityRows = "accessibilityRows";

	private static readonly IntPtr selAccessibilityRowsHandle = Selector.GetHandle("accessibilityRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedCells = "accessibilitySelectedCells";

	private static readonly IntPtr selAccessibilitySelectedCellsHandle = Selector.GetHandle("accessibilitySelectedCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedColumns = "accessibilitySelectedColumns";

	private static readonly IntPtr selAccessibilitySelectedColumnsHandle = Selector.GetHandle("accessibilitySelectedColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilitySelectedRows = "accessibilitySelectedRows";

	private static readonly IntPtr selAccessibilitySelectedRowsHandle = Selector.GetHandle("accessibilitySelectedRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleCells = "accessibilityVisibleCells";

	private static readonly IntPtr selAccessibilityVisibleCellsHandle = Selector.GetHandle("accessibilityVisibleCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleColumns = "accessibilityVisibleColumns";

	private static readonly IntPtr selAccessibilityVisibleColumnsHandle = Selector.GetHandle("accessibilityVisibleColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityVisibleRows = "accessibilityVisibleRows";

	private static readonly IntPtr selAccessibilityVisibleRowsHandle = Selector.GetHandle("accessibilityVisibleRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoresizesOutlineColumn = "autoresizesOutlineColumn";

	private static readonly IntPtr selAutoresizesOutlineColumnHandle = Selector.GetHandle("autoresizesOutlineColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosaveExpandedItems = "autosaveExpandedItems";

	private static readonly IntPtr selAutosaveExpandedItemsHandle = Selector.GetHandle("autosaveExpandedItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChild_OfItem_ = "child:ofItem:";

	private static readonly IntPtr selChild_OfItem_Handle = Selector.GetHandle("child:ofItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildIndexForItem_ = "childIndexForItem:";

	private static readonly IntPtr selChildIndexForItem_Handle = Selector.GetHandle("childIndexForItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapseItem_ = "collapseItem:";

	private static readonly IntPtr selCollapseItem_Handle = Selector.GetHandle("collapseItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapseItem_CollapseChildren_ = "collapseItem:collapseChildren:";

	private static readonly IntPtr selCollapseItem_CollapseChildren_Handle = Selector.GetHandle("collapseItem:collapseChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpandItem_ = "expandItem:";

	private static readonly IntPtr selExpandItem_Handle = Selector.GetHandle("expandItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpandItem_ExpandChildren_ = "expandItem:expandChildren:";

	private static readonly IntPtr selExpandItem_ExpandChildren_Handle = Selector.GetHandle("expandItem:expandChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameOfOutlineCellAtRow_ = "frameOfOutlineCellAtRow:";

	private static readonly IntPtr selFrameOfOutlineCellAtRow_Handle = Selector.GetHandle("frameOfOutlineCellAtRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndentationMarkerFollowsCell = "indentationMarkerFollowsCell";

	private static readonly IntPtr selIndentationMarkerFollowsCellHandle = Selector.GetHandle("indentationMarkerFollowsCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndentationPerLevel = "indentationPerLevel";

	private static readonly IntPtr selIndentationPerLevelHandle = Selector.GetHandle("indentationPerLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItemsAtIndexes_InParent_WithAnimation_ = "insertItemsAtIndexes:inParent:withAnimation:";

	private static readonly IntPtr selInsertItemsAtIndexes_InParent_WithAnimation_Handle = Selector.GetHandle("insertItemsAtIndexes:inParent:withAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertRowsAtIndexes_WithAnimation_ = "insertRowsAtIndexes:withAnimation:";

	private static readonly IntPtr selInsertRowsAtIndexes_WithAnimation_Handle = Selector.GetHandle("insertRowsAtIndexes:withAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExpandable_ = "isExpandable:";

	private static readonly IntPtr selIsExpandable_Handle = Selector.GetHandle("isExpandable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsItemExpanded_ = "isItemExpanded:";

	private static readonly IntPtr selIsItemExpanded_Handle = Selector.GetHandle("isItemExpanded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtRow_ = "itemAtRow:";

	private static readonly IntPtr selItemAtRow_Handle = Selector.GetHandle("itemAtRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLevelForItem_ = "levelForItem:";

	private static readonly IntPtr selLevelForItem_Handle = Selector.GetHandle("levelForItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLevelForRow_ = "levelForRow:";

	private static readonly IntPtr selLevelForRow_Handle = Selector.GetHandle("levelForRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveItemAtIndex_InParent_ToIndex_InParent_ = "moveItemAtIndex:inParent:toIndex:inParent:";

	private static readonly IntPtr selMoveItemAtIndex_InParent_ToIndex_InParent_Handle = Selector.GetHandle("moveItemAtIndex:inParent:toIndex:inParent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveRowAtIndex_ToIndex_ = "moveRowAtIndex:toIndex:";

	private static readonly IntPtr selMoveRowAtIndex_ToIndex_Handle = Selector.GetHandle("moveRowAtIndex:toIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfChildrenOfItem_ = "numberOfChildrenOfItem:";

	private static readonly IntPtr selNumberOfChildrenOfItem_Handle = Selector.GetHandle("numberOfChildrenOfItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutlineTableColumn = "outlineTableColumn";

	private static readonly IntPtr selOutlineTableColumnHandle = Selector.GetHandle("outlineTableColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentForItem_ = "parentForItem:";

	private static readonly IntPtr selParentForItem_Handle = Selector.GetHandle("parentForItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadItem_ = "reloadItem:";

	private static readonly IntPtr selReloadItem_Handle = Selector.GetHandle("reloadItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadItem_ReloadChildren_ = "reloadItem:reloadChildren:";

	private static readonly IntPtr selReloadItem_ReloadChildren_Handle = Selector.GetHandle("reloadItem:reloadChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemsAtIndexes_InParent_WithAnimation_ = "removeItemsAtIndexes:inParent:withAnimation:";

	private static readonly IntPtr selRemoveItemsAtIndexes_InParent_WithAnimation_Handle = Selector.GetHandle("removeItemsAtIndexes:inParent:withAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRowsAtIndexes_WithAnimation_ = "removeRowsAtIndexes:withAnimation:";

	private static readonly IntPtr selRemoveRowsAtIndexes_WithAnimation_Handle = Selector.GetHandle("removeRowsAtIndexes:withAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowForItem_ = "rowForItem:";

	private static readonly IntPtr selRowForItem_Handle = Selector.GetHandle("rowForItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilitySelectedRows_ = "setAccessibilitySelectedRows:";

	private static readonly IntPtr selSetAccessibilitySelectedRows_Handle = Selector.GetHandle("setAccessibilitySelectedRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoresizesOutlineColumn_ = "setAutoresizesOutlineColumn:";

	private static readonly IntPtr selSetAutoresizesOutlineColumn_Handle = Selector.GetHandle("setAutoresizesOutlineColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosaveExpandedItems_ = "setAutosaveExpandedItems:";

	private static readonly IntPtr selSetAutosaveExpandedItems_Handle = Selector.GetHandle("setAutosaveExpandedItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataSource_ = "setDataSource:";

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDropItem_DropChildIndex_ = "setDropItem:dropChildIndex:";

	private static readonly IntPtr selSetDropItem_DropChildIndex_Handle = Selector.GetHandle("setDropItem:dropChildIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndentationMarkerFollowsCell_ = "setIndentationMarkerFollowsCell:";

	private static readonly IntPtr selSetIndentationMarkerFollowsCell_Handle = Selector.GetHandle("setIndentationMarkerFollowsCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndentationPerLevel_ = "setIndentationPerLevel:";

	private static readonly IntPtr selSetIndentationPerLevel_Handle = Selector.GetHandle("setIndentationPerLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutlineTableColumn_ = "setOutlineTableColumn:";

	private static readonly IntPtr selSetOutlineTableColumn_Handle = Selector.GetHandle("setOutlineTableColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStronglyReferencesItems_ = "setStronglyReferencesItems:";

	private static readonly IntPtr selSetStronglyReferencesItems_Handle = Selector.GetHandle("setStronglyReferencesItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserInterfaceLayoutDirection_ = "setUserInterfaceLayoutDirection:";

	private static readonly IntPtr selSetUserInterfaceLayoutDirection_Handle = Selector.GetHandle("setUserInterfaceLayoutDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldCollapseAutoExpandedItemsForDeposited_ = "shouldCollapseAutoExpandedItemsForDeposited:";

	private static readonly IntPtr selShouldCollapseAutoExpandedItemsForDeposited_Handle = Selector.GetHandle("shouldCollapseAutoExpandedItemsForDeposited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStronglyReferencesItems = "stronglyReferencesItems";

	private static readonly IntPtr selStronglyReferencesItemsHandle = Selector.GetHandle("stronglyReferencesItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInterfaceLayoutDirection = "userInterfaceLayoutDirection";

	private static readonly IntPtr selUserInterfaceLayoutDirectionHandle = Selector.GetHandle("userInterfaceLayoutDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOutlineView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDataSource_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnDidMoveNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColumnDidResizeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemDidCollapseNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemDidExpandNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemWillCollapseNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemWillExpandNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionIsChangingNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityColumnHeaderUIElements
	{
		[Export("accessibilityColumnHeaderUIElements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnHeaderUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnHeaderUIElementsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityColumns
	{
		[Export("accessibilityColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityColumnsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual bool AccessibilityFocused
	{
		[Export("isAccessibilityFocused")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFocusedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFocusedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAccessibilityFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccessibilityFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'AccessibilityHeader' instead.")]
	public new virtual string AccessibilityHeaderGroup
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'AccessibilityHeader' instead.")]
		[Export("accessibilityHeaderGroup")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityHeaderGroupHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityHeaderGroupHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string AccessibilityIdentifier
	{
		[Export("accessibilityIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject? AccessibilityParent
	{
		[Export("accessibilityParent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityRowHeaderUIElements
	{
		[Export("accessibilityRowHeaderUIElements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRowHeaderUIElementsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowHeaderUIElementsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual INSAccessibilityRow[]? AccessibilityRows
	{
		[Export("accessibilityRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityRowsHandle));
			}
			return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityRowsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilitySelectedCells
	{
		[Export("accessibilitySelectedCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedCellsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilitySelectedColumns
	{
		[Export("accessibilitySelectedColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedColumnsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual INSAccessibilityRow[]? AccessibilitySelectedRows
	{
		[Export("accessibilitySelectedRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilitySelectedRowsHandle));
			}
			return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilitySelectedRowsHandle));
		}
		[Export("setAccessibilitySelectedRows:")]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilitySelectedRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilitySelectedRows_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityVisibleCells
	{
		[Export("accessibilityVisibleCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleCellsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleCellsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject[] AccessibilityVisibleColumns
	{
		[Export("accessibilityVisibleColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleColumnsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleColumnsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual INSAccessibilityRow[] AccessibilityVisibleRows
	{
		[Export("accessibilityVisibleRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityVisibleRowsHandle));
			}
			return NSArray.ArrayFromHandle<INSAccessibilityRow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityVisibleRowsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutoresizesOutlineColumn
	{
		[Export("autoresizesOutlineColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoresizesOutlineColumnHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoresizesOutlineColumnHandle);
		}
		[Export("setAutoresizesOutlineColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoresizesOutlineColumn_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoresizesOutlineColumn_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutosaveExpandedItems
	{
		[Export("autosaveExpandedItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosaveExpandedItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosaveExpandedItemsHandle);
		}
		[Export("setAutosaveExpandedItems:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosaveExpandedItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosaveExpandedItems_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new INSOutlineViewDataSource? DataSource
	{
		get
		{
			return WeakDataSource as INSOutlineViewDataSource;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDataSource = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new INSOutlineViewDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSOutlineViewDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IndentationMarkerFollowsCell
	{
		[Export("indentationMarkerFollowsCell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIndentationMarkerFollowsCellHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIndentationMarkerFollowsCellHandle);
		}
		[Export("setIndentationMarkerFollowsCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIndentationMarkerFollowsCell_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIndentationMarkerFollowsCell_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat IndentationPerLevel
	{
		[Export("indentationPerLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selIndentationPerLevelHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selIndentationPerLevelHandle);
		}
		[Export("setIndentationPerLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetIndentationPerLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetIndentationPerLevel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableColumn? OutlineTableColumn
	{
		[Export("outlineTableColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTableColumn>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutlineTableColumnHandle));
			}
			return Runtime.GetNSObject<NSTableColumn>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutlineTableColumnHandle));
		}
		[Export("setOutlineTableColumn:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutlineTableColumn_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutlineTableColumn_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool StronglyReferencesItems
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("stronglyReferencesItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selStronglyReferencesItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStronglyReferencesItemsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setStronglyReferencesItems:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetStronglyReferencesItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetStronglyReferencesItems_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection
	{
		[Export("userInterfaceLayoutDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSend(base.Handle, selUserInterfaceLayoutDirectionHandle);
			}
			return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUserInterfaceLayoutDirectionHandle);
		}
		[Export("setUserInterfaceLayoutDirection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetUserInterfaceLayoutDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetUserInterfaceLayoutDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject? WeakDataSource
	{
		[Export("dataSource", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle)));
			MarkDirty();
			__mt_WeakDataSource_var = nSObject;
			return nSObject;
		}
		[Export("setDataSource:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDataSource_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("NSOutlineViewColumnDidMoveNotification", "AppKit")]
	[Advice("Use NSOutlineView.Notifications.ObserveColumnDidMove helper method instead.")]
	public new static NSString ColumnDidMoveNotification
	{
		get
		{
			if (_ColumnDidMoveNotification == null)
			{
				_ColumnDidMoveNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSOutlineViewColumnDidMoveNotification");
			}
			return _ColumnDidMoveNotification;
		}
	}

	[Field("NSOutlineViewColumnDidResizeNotification", "AppKit")]
	[Advice("Use NSOutlineView.Notifications.ObserveColumnDidResize helper method instead.")]
	public new static NSString ColumnDidResizeNotification
	{
		get
		{
			if (_ColumnDidResizeNotification == null)
			{
				_ColumnDidResizeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSOutlineViewColumnDidResizeNotification");
			}
			return _ColumnDidResizeNotification;
		}
	}

	[Field("NSOutlineViewItemDidCollapseNotification", "AppKit")]
	[Advice("Use NSOutlineView.Notifications.ObserveItemDidCollapse helper method instead.")]
	public static NSString ItemDidCollapseNotification
	{
		get
		{
			if (_ItemDidCollapseNotification == null)
			{
				_ItemDidCollapseNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSOutlineViewItemDidCollapseNotification");
			}
			return _ItemDidCollapseNotification;
		}
	}

	[Field("NSOutlineViewItemDidExpandNotification", "AppKit")]
	[Advice("Use NSOutlineView.Notifications.ObserveItemDidExpand helper method instead.")]
	public static NSString ItemDidExpandNotification
	{
		get
		{
			if (_ItemDidExpandNotification == null)
			{
				_ItemDidExpandNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSOutlineViewItemDidExpandNotification");
			}
			return _ItemDidExpandNotification;
		}
	}

	[Field("NSOutlineViewItemWillCollapseNotification", "AppKit")]
	[Advice("Use NSOutlineView.Notifications.ObserveItemWillCollapse helper method instead.")]
	public static NSString ItemWillCollapseNotification
	{
		get
		{
			if (_ItemWillCollapseNotification == null)
			{
				_ItemWillCollapseNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSOutlineViewItemWillCollapseNotification");
			}
			return _ItemWillCollapseNotification;
		}
	}

	[Field("NSOutlineViewItemWillExpandNotification", "AppKit")]
	[Advice("Use NSOutlineView.Notifications.ObserveItemWillExpand helper method instead.")]
	public static NSString ItemWillExpandNotification
	{
		get
		{
			if (_ItemWillExpandNotification == null)
			{
				_ItemWillExpandNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSOutlineViewItemWillExpandNotification");
			}
			return _ItemWillExpandNotification;
		}
	}

	[Field("NSOutlineViewSelectionDidChangeNotification", "AppKit")]
	[Advice("Use NSOutlineView.Notifications.ObserveSelectionDidChange helper method instead.")]
	public new static NSString SelectionDidChangeNotification
	{
		get
		{
			if (_SelectionDidChangeNotification == null)
			{
				_SelectionDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSOutlineViewSelectionDidChangeNotification");
			}
			return _SelectionDidChangeNotification;
		}
	}

	[Field("NSOutlineViewSelectionIsChangingNotification", "AppKit")]
	[Advice("Use NSOutlineView.Notifications.ObserveSelectionIsChanging helper method instead.")]
	public new static NSString SelectionIsChangingNotification
	{
		get
		{
			if (_SelectionIsChangingNotification == null)
			{
				_SelectionIsChangingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSOutlineViewSelectionIsChangingNotification");
			}
			return _SelectionIsChangingNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOutlineView()
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
	public NSOutlineView(NSCoder coder)
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
	protected NSOutlineView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOutlineView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOutlineView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("collapseItem:collapseChildren:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CollapseItem(NSObject? item, bool collapseChildren)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selCollapseItem_CollapseChildren_Handle, item?.Handle ?? IntPtr.Zero, collapseChildren);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selCollapseItem_CollapseChildren_Handle, item?.Handle ?? IntPtr.Zero, collapseChildren);
		}
	}

	[Export("collapseItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CollapseItem(NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCollapseItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCollapseItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("expandItem:expandChildren:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExpandItem(NSObject? item, bool expandChildren)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selExpandItem_ExpandChildren_Handle, item?.Handle ?? IntPtr.Zero, expandChildren);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selExpandItem_ExpandChildren_Handle, item?.Handle ?? IntPtr.Zero, expandChildren);
		}
	}

	[Export("expandItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExpandItem(NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selExpandItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selExpandItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("frameOfOutlineCellAtRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect FrameOfOutlineCellAtRow(nint row)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selFrameOfOutlineCellAtRow_Handle, row);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selFrameOfOutlineCellAtRow_Handle, row);
		}
		return retval;
	}

	[Export("child:ofItem:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetChild(nint index, NSObject? parentItem)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint_IntPtr(base.Handle, selChild_OfItem_Handle, index, parentItem?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selChild_OfItem_Handle, index, parentItem?.Handle ?? IntPtr.Zero));
	}

	[Export("childIndexForItem:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetChildIndex(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selChildIndexForItem_Handle, item.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selChildIndexForItem_Handle, item.Handle);
	}

	[Export("parentForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetParent(NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selParentForItem_Handle, item?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selParentForItem_Handle, item?.Handle ?? IntPtr.Zero));
	}

	[Export("insertItemsAtIndexes:inParent:withAnimation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertItems(NSIndexSet indexes, NSObject? parent, NSTableViewAnimation animationOptions)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selInsertItemsAtIndexes_InParent_WithAnimation_Handle, indexes.Handle, parent?.Handle ?? IntPtr.Zero, (ulong)animationOptions);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selInsertItemsAtIndexes_InParent_WithAnimation_Handle, indexes.Handle, parent?.Handle ?? IntPtr.Zero, (ulong)animationOptions);
		}
	}

	[Export("insertRowsAtIndexes:withAnimation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void InsertRows(NSIndexSet indexes, NSTableViewAnimation animationOptions)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selInsertRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInsertRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
	}

	[Export("isExpandable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsExpandable(NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsExpandable_Handle, item?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsExpandable_Handle, item?.Handle ?? IntPtr.Zero);
	}

	[Export("isItemExpanded:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsItemExpanded(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsItemExpanded_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsItemExpanded_Handle, item.Handle);
	}

	[Export("itemAtRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ItemAtRow(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemAtRow_Handle, row));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemAtRow_Handle, row));
	}

	[Export("levelForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint LevelForItem(NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selLevelForItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selLevelForItem_Handle, item?.Handle ?? IntPtr.Zero);
	}

	[Export("levelForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint LevelForRow(nint row)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selLevelForRow_Handle, row);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selLevelForRow_Handle, row);
	}

	[Export("moveItemAtIndex:inParent:toIndex:inParent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveItem(nint fromIndex, NSObject? oldParent, nint toIndex, NSObject? newParent)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_IntPtr_nint_IntPtr(base.Handle, selMoveItemAtIndex_InParent_ToIndex_InParent_Handle, fromIndex, oldParent?.Handle ?? IntPtr.Zero, toIndex, newParent?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_IntPtr_nint_IntPtr(base.SuperHandle, selMoveItemAtIndex_InParent_ToIndex_InParent_Handle, fromIndex, oldParent?.Handle ?? IntPtr.Zero, toIndex, newParent?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("moveRowAtIndex:toIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void MoveRow(nint oldIndex, nint newIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selMoveRowAtIndex_ToIndex_Handle, oldIndex, newIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selMoveRowAtIndex_ToIndex_Handle, oldIndex, newIndex);
		}
	}

	[Export("numberOfChildrenOfItem:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfChildren(NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selNumberOfChildrenOfItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selNumberOfChildrenOfItem_Handle, item?.Handle ?? IntPtr.Zero);
	}

	[Export("reloadItem:reloadChildren:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadItem(NSObject? item, bool reloadChildren)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selReloadItem_ReloadChildren_Handle, item?.Handle ?? IntPtr.Zero, reloadChildren);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selReloadItem_ReloadChildren_Handle, item?.Handle ?? IntPtr.Zero, reloadChildren);
		}
	}

	[Export("reloadItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadItem(NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("removeItemsAtIndexes:inParent:withAnimation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItems(NSIndexSet indexes, NSObject? parent, NSTableViewAnimation animationOptions)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selRemoveItemsAtIndexes_InParent_WithAnimation_Handle, indexes.Handle, parent?.Handle ?? IntPtr.Zero, (ulong)animationOptions);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selRemoveItemsAtIndexes_InParent_WithAnimation_Handle, indexes.Handle, parent?.Handle ?? IntPtr.Zero, (ulong)animationOptions);
		}
	}

	[Export("removeRowsAtIndexes:withAnimation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void RemoveRows(NSIndexSet indexes, NSTableViewAnimation animationOptions)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selRemoveRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selRemoveRowsAtIndexes_WithAnimation_Handle, indexes.Handle, (ulong)animationOptions);
		}
	}

	[Export("rowForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RowForItem(NSObject? item)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selRowForItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selRowForItem_Handle, item?.Handle ?? IntPtr.Zero);
	}

	[Export("setDropItem:dropChildIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDropItem(NSObject? item, nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetDropItem_DropChildIndex_Handle, item?.Handle ?? IntPtr.Zero, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetDropItem_DropChildIndex_Handle, item?.Handle ?? IntPtr.Zero, index);
		}
	}

	[Export("shouldCollapseAutoExpandedItemsForDeposited:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCollapseAutoExpandedItems(bool forDeposited)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_bool(base.Handle, selShouldCollapseAutoExpandedItemsForDeposited_Handle, forDeposited);
		}
		return Messaging.bool_objc_msgSendSuper_bool(base.SuperHandle, selShouldCollapseAutoExpandedItemsForDeposited_Handle, forDeposited);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDataSource_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
