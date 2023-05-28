using System.ComponentModel;
using AppKit;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

[Register("IKImageBrowserView", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSCollectionView' instead.")]
public class IKImageBrowserView : NSView, INSDraggingSource, INativeObject, IDisposable
{
	[Register]
	internal class _IKImageBrowserDelegate : NSObject, IIKImageBrowserDelegate, INativeObject, IDisposable
	{
		internal EventHandler<IKImageBrowserViewEventEventArgs>? backgroundWasRightClicked;

		internal EventHandler<IKImageBrowserViewIndexEventArgs>? cellWasDoubleClicked;

		internal EventHandler<IKImageBrowserViewIndexEventEventArgs>? cellWasRightClicked;

		internal EventHandler? selectionDidChange;

		public _IKImageBrowserDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("imageBrowser:backgroundWasRightClickedWithEvent:")]
		public void BackgroundWasRightClicked(IKImageBrowserView browser, NSEvent nsevent)
		{
			EventHandler<IKImageBrowserViewEventEventArgs> eventHandler = backgroundWasRightClicked;
			if (eventHandler != null)
			{
				IKImageBrowserViewEventEventArgs e = new IKImageBrowserViewEventEventArgs(nsevent);
				eventHandler(browser, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("imageBrowser:cellWasDoubleClickedAtIndex:")]
		public void CellWasDoubleClicked(IKImageBrowserView browser, nint index)
		{
			EventHandler<IKImageBrowserViewIndexEventArgs> eventHandler = cellWasDoubleClicked;
			if (eventHandler != null)
			{
				IKImageBrowserViewIndexEventArgs e = new IKImageBrowserViewIndexEventArgs(index);
				eventHandler(browser, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("imageBrowser:cellWasRightClickedAtIndex:withEvent:")]
		public void CellWasRightClicked(IKImageBrowserView browser, nint index, NSEvent nsevent)
		{
			EventHandler<IKImageBrowserViewIndexEventEventArgs> eventHandler = cellWasRightClicked;
			if (eventHandler != null)
			{
				IKImageBrowserViewIndexEventEventArgs e = new IKImageBrowserViewIndexEventEventArgs(index, nsevent);
				eventHandler(browser, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("imageBrowserSelectionDidChange:")]
		public void SelectionDidChange(IKImageBrowserView browser)
		{
			selectionDidChange?.Invoke(browser, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsDroppingOnItems = "allowsDroppingOnItems";

	private static readonly IntPtr selAllowsDroppingOnItemsHandle = Selector.GetHandle("allowsDroppingOnItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsEmptySelection = "allowsEmptySelection";

	private static readonly IntPtr selAllowsEmptySelectionHandle = Selector.GetHandle("allowsEmptySelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsMultipleSelection = "allowsMultipleSelection";

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsReordering = "allowsReordering";

	private static readonly IntPtr selAllowsReorderingHandle = Selector.GetHandle("allowsReordering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimates = "animates";

	private static readonly IntPtr selAnimatesHandle = Selector.GetHandle("animates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundLayer = "backgroundLayer";

	private static readonly IntPtr selBackgroundLayerHandle = Selector.GetHandle("backgroundLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanControlQuickLookPanel = "canControlQuickLookPanel";

	private static readonly IntPtr selCanControlQuickLookPanelHandle = Selector.GetHandle("canControlQuickLookPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellForItemAtIndex_ = "cellForItemAtIndex:";

	private static readonly IntPtr selCellForItemAtIndex_Handle = Selector.GetHandle("cellForItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellSize = "cellSize";

	private static readonly IntPtr selCellSizeHandle = Selector.GetHandle("cellSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellsStyleMask = "cellsStyleMask";

	private static readonly IntPtr selCellsStyleMaskHandle = Selector.GetHandle("cellsStyleMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapseGroupAtIndex_ = "collapseGroupAtIndex:";

	private static readonly IntPtr selCollapseGroupAtIndex_Handle = Selector.GetHandle("collapseGroupAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnIndexesInRect_ = "columnIndexesInRect:";

	private static readonly IntPtr selColumnIndexesInRect_Handle = Selector.GetHandle("columnIndexesInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstrainsToOriginalSize = "constrainsToOriginalSize";

	private static readonly IntPtr selConstrainsToOriginalSizeHandle = Selector.GetHandle("constrainsToOriginalSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentResizingMask = "contentResizingMask";

	private static readonly IntPtr selContentResizingMaskHandle = Selector.GetHandle("contentResizingMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_BeganAt_ = "draggedImage:beganAt:";

	private static readonly IntPtr selDraggedImage_BeganAt_Handle = Selector.GetHandle("draggedImage:beganAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_EndedAt_Deposited_ = "draggedImage:endedAt:deposited:";

	private static readonly IntPtr selDraggedImage_EndedAt_Deposited_Handle = Selector.GetHandle("draggedImage:endedAt:deposited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_EndedAt_Operation_ = "draggedImage:endedAt:operation:";

	private static readonly IntPtr selDraggedImage_EndedAt_Operation_Handle = Selector.GetHandle("draggedImage:endedAt:operation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggedImage_MovedTo_ = "draggedImage:movedTo:";

	private static readonly IntPtr selDraggedImage_MovedTo_Handle = Selector.GetHandle("draggedImage:movedTo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingDestinationDelegate = "draggingDestinationDelegate";

	private static readonly IntPtr selDraggingDestinationDelegateHandle = Selector.GetHandle("draggingDestinationDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingSourceOperationMaskForLocal_ = "draggingSourceOperationMaskForLocal:";

	private static readonly IntPtr selDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("draggingSourceOperationMaskForLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDropOperation = "dropOperation";

	private static readonly IntPtr selDropOperationHandle = Selector.GetHandle("dropOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpandGroupAtIndex_ = "expandGroupAtIndex:";

	private static readonly IntPtr selExpandGroupAtIndex_Handle = Selector.GetHandle("expandGroupAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForegroundLayer = "foregroundLayer";

	private static readonly IntPtr selForegroundLayerHandle = Selector.GetHandle("foregroundLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoreModifierKeysWhileDragging = "ignoreModifierKeysWhileDragging";

	private static readonly IntPtr selIgnoreModifierKeysWhileDraggingHandle = Selector.GetHandle("ignoreModifierKeysWhileDragging");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexAtLocationOfDroppedItem = "indexAtLocationOfDroppedItem";

	private static readonly IntPtr selIndexAtLocationOfDroppedItemHandle = Selector.GetHandle("indexAtLocationOfDroppedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemAtPoint_ = "indexOfItemAtPoint:";

	private static readonly IntPtr selIndexOfItemAtPoint_Handle = Selector.GetHandle("indexOfItemAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntercellSpacing = "intercellSpacing";

	private static readonly IntPtr selIntercellSpacingHandle = Selector.GetHandle("intercellSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsGroupExpandedAtIndex_ = "isGroupExpandedAtIndex:";

	private static readonly IntPtr selIsGroupExpandedAtIndex_Handle = Selector.GetHandle("isGroupExpandedAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemFrameAtIndex_ = "itemFrameAtIndex:";

	private static readonly IntPtr selItemFrameAtIndex_Handle = Selector.GetHandle("itemFrameAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamesOfPromisedFilesDroppedAtDestination_ = "namesOfPromisedFilesDroppedAtDestination:";

	private static readonly IntPtr selNamesOfPromisedFilesDroppedAtDestination_Handle = Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewCellForRepresentedItem_ = "newCellForRepresentedItem:";

	private static readonly IntPtr selNewCellForRepresentedItem_Handle = Selector.GetHandle("newCellForRepresentedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColumns = "numberOfColumns";

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfRows = "numberOfRows";

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectOfColumn_ = "rectOfColumn:";

	private static readonly IntPtr selRectOfColumn_Handle = Selector.GetHandle("rectOfColumn:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectOfRow_ = "rectOfRow:";

	private static readonly IntPtr selRectOfRow_Handle = Selector.GetHandle("rectOfRow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadData = "reloadData";

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowIndexesInRect_ = "rowIndexesInRect:";

	private static readonly IntPtr selRowIndexesInRect_Handle = Selector.GetHandle("rowIndexesInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollIndexToVisible_ = "scrollIndexToVisible:";

	private static readonly IntPtr selScrollIndexToVisible_Handle = Selector.GetHandle("scrollIndexToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionIndexes = "selectionIndexes";

	private static readonly IntPtr selSelectionIndexesHandle = Selector.GetHandle("selectionIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsDroppingOnItems_ = "setAllowsDroppingOnItems:";

	private static readonly IntPtr selSetAllowsDroppingOnItems_Handle = Selector.GetHandle("setAllowsDroppingOnItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsEmptySelection_ = "setAllowsEmptySelection:";

	private static readonly IntPtr selSetAllowsEmptySelection_Handle = Selector.GetHandle("setAllowsEmptySelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsMultipleSelection_ = "setAllowsMultipleSelection:";

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsReordering_ = "setAllowsReordering:";

	private static readonly IntPtr selSetAllowsReordering_Handle = Selector.GetHandle("setAllowsReordering:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimates_ = "setAnimates:";

	private static readonly IntPtr selSetAnimates_Handle = Selector.GetHandle("setAnimates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundLayer_ = "setBackgroundLayer:";

	private static readonly IntPtr selSetBackgroundLayer_Handle = Selector.GetHandle("setBackgroundLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanControlQuickLookPanel_ = "setCanControlQuickLookPanel:";

	private static readonly IntPtr selSetCanControlQuickLookPanel_Handle = Selector.GetHandle("setCanControlQuickLookPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellSize_ = "setCellSize:";

	private static readonly IntPtr selSetCellSize_Handle = Selector.GetHandle("setCellSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCellsStyleMask_ = "setCellsStyleMask:";

	private static readonly IntPtr selSetCellsStyleMask_Handle = Selector.GetHandle("setCellsStyleMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConstrainsToOriginalSize_ = "setConstrainsToOriginalSize:";

	private static readonly IntPtr selSetConstrainsToOriginalSize_Handle = Selector.GetHandle("setConstrainsToOriginalSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentResizingMask_ = "setContentResizingMask:";

	private static readonly IntPtr selSetContentResizingMask_Handle = Selector.GetHandle("setContentResizingMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataSource_ = "setDataSource:";

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingDestinationDelegate_ = "setDraggingDestinationDelegate:";

	private static readonly IntPtr selSetDraggingDestinationDelegate_Handle = Selector.GetHandle("setDraggingDestinationDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDropIndex_DropOperation_ = "setDropIndex:dropOperation:";

	private static readonly IntPtr selSetDropIndex_DropOperation_Handle = Selector.GetHandle("setDropIndex:dropOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetForegroundLayer_ = "setForegroundLayer:";

	private static readonly IntPtr selSetForegroundLayer_Handle = Selector.GetHandle("setForegroundLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntercellSpacing_ = "setIntercellSpacing:";

	private static readonly IntPtr selSetIntercellSpacing_Handle = Selector.GetHandle("setIntercellSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionIndexes_ByExtendingSelection_ = "setSelectionIndexes:byExtendingSelection:";

	private static readonly IntPtr selSetSelectionIndexes_ByExtendingSelection_Handle = Selector.GetHandle("setSelectionIndexes:byExtendingSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZoomValue_ = "setZoomValue:";

	private static readonly IntPtr selSetZoomValue_Handle = Selector.GetHandle("setZoomValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleItemIndexes = "visibleItemIndexes";

	private static readonly IntPtr selVisibleItemIndexesHandle = Selector.GetHandle("visibleItemIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZoomValue = "zoomValue";

	private static readonly IntPtr selZoomValueHandle = Selector.GetHandle("zoomValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKImageBrowserView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_DraggingDestinationDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDataSource_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BackgroundColorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CellsHighlightedTitleAttributesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CellsOutlineColorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CellsSubtitleAttributesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CellsTitleAttributesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionColorKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsDroppingOnItems
	{
		[Export("allowsDroppingOnItems")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDroppingOnItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDroppingOnItemsHandle);
		}
		[Export("setAllowsDroppingOnItems:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsDroppingOnItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsDroppingOnItems_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsEmptySelection
	{
		[Export("allowsEmptySelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEmptySelectionHandle);
		}
		[Export("setAllowsEmptySelection:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsEmptySelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsEmptySelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
		[Export("setAllowsMultipleSelection:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMultipleSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMultipleSelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsReordering
	{
		[Export("allowsReordering")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsReorderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsReorderingHandle);
		}
		[Export("setAllowsReordering:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsReordering_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsReordering_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Animates
	{
		[Export("animates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAnimatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAnimatesHandle);
		}
		[Export("setAnimates:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAnimates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAnimates_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer BackgroundLayer
	{
		[Export("backgroundLayer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundLayerHandle));
			}
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundLayerHandle));
		}
		[Export("setBackgroundLayer:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundLayer_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundLayer_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanControlQuickLookPanel
	{
		[Export("canControlQuickLookPanel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanControlQuickLookPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanControlQuickLookPanelHandle);
		}
		[Export("setCanControlQuickLookPanel:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanControlQuickLookPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanControlQuickLookPanel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize CellSize
	{
		[Export("cellSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selCellSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selCellSizeHandle);
		}
		[Export("setCellSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetCellSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetCellSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKCellsStyle CellsStyleMask
	{
		[Export("cellsStyleMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (IKCellsStyle)Messaging.UInt64_objc_msgSend(base.Handle, selCellsStyleMaskHandle);
			}
			return (IKCellsStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCellsStyleMaskHandle);
		}
		[Export("setCellsStyleMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCellsStyleMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCellsStyleMask_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ColumnCount
	{
		[Export("numberOfColumns")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfColumnsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfColumnsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ConstrainsToOriginalSize
	{
		[Export("constrainsToOriginalSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selConstrainsToOriginalSizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selConstrainsToOriginalSizeHandle);
		}
		[Export("setConstrainsToOriginalSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetConstrainsToOriginalSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetConstrainsToOriginalSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewResizingMask ContentResizingMask
	{
		[Export("contentResizingMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSViewResizingMask)Messaging.UInt64_objc_msgSend(base.Handle, selContentResizingMaskHandle);
			}
			return (NSViewResizingMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selContentResizingMaskHandle);
		}
		[Export("setContentResizingMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetContentResizingMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetContentResizingMask_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IIKImageBrowserDataSource DataSource
	{
		get
		{
			return WeakDataSource as IIKImageBrowserDataSource;
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
	public IIKImageBrowserDelegate Delegate
	{
		get
		{
			return WeakDelegate as IIKImageBrowserDelegate;
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
	public virtual INSDraggingDestination DraggingDestinationDelegate
	{
		[Export("draggingDestinationDelegate", ArgumentSemantic.Weak)]
		get
		{
			INSDraggingDestination iNSDraggingDestination = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSDraggingDestination>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingDestinationDelegateHandle), owns: false) : Runtime.GetINativeObject<INSDraggingDestination>(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingDestinationDelegateHandle), owns: false));
			MarkDirty();
			__mt_DraggingDestinationDelegate_var = iNSDraggingDestination;
			return iNSDraggingDestination;
		}
		[Export("setDraggingDestinationDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDraggingDestinationDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDraggingDestinationDelegate_Handle, value.Handle);
			}
			MarkDirty();
			__mt_DraggingDestinationDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer ForegroundLayer
	{
		[Export("foregroundLayer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selForegroundLayerHandle));
			}
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForegroundLayerHandle));
		}
		[Export("setForegroundLayer:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetForegroundLayer_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetForegroundLayer_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IgnoreModifierKeysWhileDragging
	{
		[Export("ignoreModifierKeysWhileDragging")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoreModifierKeysWhileDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoreModifierKeysWhileDraggingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize IntercellSpacing
	{
		[Export("intercellSpacing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selIntercellSpacingHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selIntercellSpacingHandle);
		}
		[Export("setIntercellSpacing:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetIntercellSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetIntercellSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RowCount
	{
		[Export("numberOfRows")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfRowsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfRowsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SelectionIndexes
	{
		[Export("selectionIndexes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDataSource
	{
		[Export("dataSource", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle)));
			MarkDirty();
			__mt_WeakDataSource_var = nSObject;
			return nSObject;
		}
		[Export("setDataSource:", ArgumentSemantic.Assign)]
		set
		{
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
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ZoomValue
	{
		[Export("zoomValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selZoomValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selZoomValueHandle);
		}
		[Export("setZoomValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetZoomValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetZoomValue_Handle, value);
			}
		}
	}

	[Field("IKImageBrowserBackgroundColorKey", "ImageKit")]
	public static NSString BackgroundColorKey
	{
		get
		{
			if (_BackgroundColorKey == null)
			{
				_BackgroundColorKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserBackgroundColorKey");
			}
			return _BackgroundColorKey;
		}
	}

	[Field("IKImageBrowserCellsHighlightedTitleAttributesKey", "ImageKit")]
	public static NSString CellsHighlightedTitleAttributesKey
	{
		get
		{
			if (_CellsHighlightedTitleAttributesKey == null)
			{
				_CellsHighlightedTitleAttributesKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCellsHighlightedTitleAttributesKey");
			}
			return _CellsHighlightedTitleAttributesKey;
		}
	}

	[Field("IKImageBrowserCellsOutlineColorKey", "ImageKit")]
	public static NSString CellsOutlineColorKey
	{
		get
		{
			if (_CellsOutlineColorKey == null)
			{
				_CellsOutlineColorKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCellsOutlineColorKey");
			}
			return _CellsOutlineColorKey;
		}
	}

	[Field("IKImageBrowserCellsSubtitleAttributesKey", "ImageKit")]
	public static NSString CellsSubtitleAttributesKey
	{
		get
		{
			if (_CellsSubtitleAttributesKey == null)
			{
				_CellsSubtitleAttributesKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCellsSubtitleAttributesKey");
			}
			return _CellsSubtitleAttributesKey;
		}
	}

	[Field("IKImageBrowserCellsTitleAttributesKey", "ImageKit")]
	public static NSString CellsTitleAttributesKey
	{
		get
		{
			if (_CellsTitleAttributesKey == null)
			{
				_CellsTitleAttributesKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserCellsTitleAttributesKey");
			}
			return _CellsTitleAttributesKey;
		}
	}

	[Field("IKImageBrowserSelectionColorKey", "ImageKit")]
	public static NSString SelectionColorKey
	{
		get
		{
			if (_SelectionColorKey == null)
			{
				_SelectionColorKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserSelectionColorKey");
			}
			return _SelectionColorKey;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_IKImageBrowserDelegate);

	public event EventHandler<IKImageBrowserViewEventEventArgs> BackgroundWasRightClicked
	{
		add
		{
			_IKImageBrowserDelegate iKImageBrowserDelegate = EnsureIKImageBrowserDelegate();
			iKImageBrowserDelegate.backgroundWasRightClicked = (EventHandler<IKImageBrowserViewEventEventArgs>)System.Delegate.Combine(iKImageBrowserDelegate.backgroundWasRightClicked, value);
		}
		remove
		{
			_IKImageBrowserDelegate iKImageBrowserDelegate = EnsureIKImageBrowserDelegate();
			iKImageBrowserDelegate.backgroundWasRightClicked = (EventHandler<IKImageBrowserViewEventEventArgs>)System.Delegate.Remove(iKImageBrowserDelegate.backgroundWasRightClicked, value);
		}
	}

	public event EventHandler<IKImageBrowserViewIndexEventArgs> CellWasDoubleClicked
	{
		add
		{
			_IKImageBrowserDelegate iKImageBrowserDelegate = EnsureIKImageBrowserDelegate();
			iKImageBrowserDelegate.cellWasDoubleClicked = (EventHandler<IKImageBrowserViewIndexEventArgs>)System.Delegate.Combine(iKImageBrowserDelegate.cellWasDoubleClicked, value);
		}
		remove
		{
			_IKImageBrowserDelegate iKImageBrowserDelegate = EnsureIKImageBrowserDelegate();
			iKImageBrowserDelegate.cellWasDoubleClicked = (EventHandler<IKImageBrowserViewIndexEventArgs>)System.Delegate.Remove(iKImageBrowserDelegate.cellWasDoubleClicked, value);
		}
	}

	public event EventHandler<IKImageBrowserViewIndexEventEventArgs> CellWasRightClicked
	{
		add
		{
			_IKImageBrowserDelegate iKImageBrowserDelegate = EnsureIKImageBrowserDelegate();
			iKImageBrowserDelegate.cellWasRightClicked = (EventHandler<IKImageBrowserViewIndexEventEventArgs>)System.Delegate.Combine(iKImageBrowserDelegate.cellWasRightClicked, value);
		}
		remove
		{
			_IKImageBrowserDelegate iKImageBrowserDelegate = EnsureIKImageBrowserDelegate();
			iKImageBrowserDelegate.cellWasRightClicked = (EventHandler<IKImageBrowserViewIndexEventEventArgs>)System.Delegate.Remove(iKImageBrowserDelegate.cellWasRightClicked, value);
		}
	}

	public event EventHandler SelectionDidChange
	{
		add
		{
			_IKImageBrowserDelegate iKImageBrowserDelegate = EnsureIKImageBrowserDelegate();
			iKImageBrowserDelegate.selectionDidChange = (EventHandler)System.Delegate.Combine(iKImageBrowserDelegate.selectionDidChange, value);
		}
		remove
		{
			_IKImageBrowserDelegate iKImageBrowserDelegate = EnsureIKImageBrowserDelegate();
			iKImageBrowserDelegate.selectionDidChange = (EventHandler)System.Delegate.Remove(iKImageBrowserDelegate.selectionDidChange, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageBrowserView()
		: base(NSObjectFlag.Empty)
	{
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
	public IKImageBrowserView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected IKImageBrowserView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKImageBrowserView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IKImageBrowserView(CGRect frame)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
	}

	[Export("collapseGroupAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CollapseGroup(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selCollapseGroupAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selCollapseGroupAtIndex_Handle, index);
		}
	}

	[Export("draggedImage:beganAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageBeganAt(NSImage image, CGPoint screenPoint)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImage_BeganAt_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImage_BeganAt_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggedImage:endedAt:deposited:")]
	[Deprecated(PlatformName.MacOSX, 10, 1, PlatformArchitecture.All, "Use DraggedImageEndedAtOperation instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageEndedAtDeposited(NSImage image, CGPoint screenPoint, bool deposited)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_bool(base.Handle, selDraggedImage_EndedAt_Deposited_Handle, image.Handle, screenPoint, deposited);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_bool(base.SuperHandle, selDraggedImage_EndedAt_Deposited_Handle, image.Handle, screenPoint, deposited);
		}
	}

	[Export("draggedImage:endedAt:operation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageEndedAtOperation(NSImage image, CGPoint screenPoint, NSDragOperation operation)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint_UInt64(base.Handle, selDraggedImage_EndedAt_Operation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint_UInt64(base.SuperHandle, selDraggedImage_EndedAt_Operation_Handle, image.Handle, screenPoint, (ulong)operation);
		}
	}

	[Export("draggedImage:movedTo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageMovedTo(NSImage image, CGPoint screenPoint)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDraggedImage_MovedTo_Handle, image.Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDraggedImage_MovedTo_Handle, image.Handle, screenPoint);
		}
	}

	[Export("draggingSourceOperationMaskForLocal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingSourceOperationMaskForLocal(bool flag)
	{
		if (base.IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_bool(base.Handle, selDraggingSourceOperationMaskForLocal_Handle, flag);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_bool(base.SuperHandle, selDraggingSourceOperationMaskForLocal_Handle, flag);
	}

	[Export("dropOperation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKImageBrowserDropOperation DropOperation()
	{
		if (base.IsDirectBinding)
		{
			return (IKImageBrowserDropOperation)Messaging.int_objc_msgSend(base.Handle, selDropOperationHandle);
		}
		return (IKImageBrowserDropOperation)Messaging.int_objc_msgSendSuper(base.SuperHandle, selDropOperationHandle);
	}

	[Export("expandGroupAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExpandGroup(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selExpandGroupAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selExpandGroupAtIndex_Handle, index);
		}
	}

	[Export("cellForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKImageBrowserCell GetCellAt(nint itemIndex)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<IKImageBrowserCell>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selCellForItemAtIndex_Handle, itemIndex));
		}
		return Runtime.GetNSObject<IKImageBrowserCell>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selCellForItemAtIndex_Handle, itemIndex));
	}

	[Export("columnIndexesInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet GetColumnIndexes(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selColumnIndexesInRect_Handle, rect));
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selColumnIndexesInRect_Handle, rect));
	}

	[Export("indexAtLocationOfDroppedItem")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetIndexAtLocationOfDroppedItem()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selIndexAtLocationOfDroppedItemHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selIndexAtLocationOfDroppedItemHandle);
	}

	[Export("indexOfItemAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetIndexOfItem(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_CGPoint(base.Handle, selIndexOfItemAtPoint_Handle, point);
		}
		return Messaging.nint_objc_msgSendSuper_CGPoint(base.SuperHandle, selIndexOfItemAtPoint_Handle, point);
	}

	[Export("itemFrameAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetItemFrame(nint index)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selItemFrameAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selItemFrameAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("rectOfColumn:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetRectOfColumn(nint columnIndex)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selRectOfColumn_Handle, columnIndex);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selRectOfColumn_Handle, columnIndex);
		}
		return retval;
	}

	[Export("rectOfRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetRectOfRow(nint rowIndex)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selRectOfRow_Handle, rowIndex);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selRectOfRow_Handle, rowIndex);
		}
		return retval;
	}

	[Export("rowIndexesInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet GetRowIndexes(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selRowIndexesInRect_Handle, rect));
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selRowIndexesInRect_Handle, rect));
	}

	[Export("visibleItemIndexes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet GetVisibleItemIndexes()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selVisibleItemIndexesHandle));
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisibleItemIndexesHandle));
	}

	[Export("isGroupExpandedAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsGroupExpanded(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsGroupExpandedAtIndex_Handle, index);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsGroupExpandedAtIndex_Handle, index);
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use NSFilePromiseProvider objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
	}

	[Export("newCellForRepresentedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKImageBrowserCell NewCell(IIKImageBrowserItem representedItem)
	{
		if (representedItem != null)
		{
			if (!(representedItem is NSObject))
			{
				throw new ArgumentException("The object passed of type " + representedItem.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<IKImageBrowserCell>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewCellForRepresentedItem_Handle, representedItem.Handle));
			}
			return Runtime.GetNSObject<IKImageBrowserCell>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewCellForRepresentedItem_Handle, representedItem.Handle));
		}
		throw new ArgumentNullException("representedItem");
	}

	[Export("reloadData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadData()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("scrollIndexToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollIndexToVisible(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selScrollIndexToVisible_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selScrollIndexToVisible_Handle, index);
		}
	}

	[Export("setSelectionIndexes:byExtendingSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectItemsAt(NSIndexSet indexes, bool extendSelection)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetSelectionIndexes_ByExtendingSelection_Handle, indexes.Handle, extendSelection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetSelectionIndexes_ByExtendingSelection_Handle, indexes.Handle, extendSelection);
		}
	}

	[Export("setDropIndex:dropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDropIndex(nint index, IKImageBrowserDropOperation operation)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_int(base.Handle, selSetDropIndex_DropOperation_Handle, index, (int)operation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_int(base.SuperHandle, selSetDropIndex_DropOperation_Handle, index, (int)operation);
		}
	}

	internal virtual _IKImageBrowserDelegate CreateInternalEventDelegateType()
	{
		return new _IKImageBrowserDelegate();
	}

	internal _IKImageBrowserDelegate EnsureIKImageBrowserDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_IKImageBrowserDelegate iKImageBrowserDelegate = Delegate as _IKImageBrowserDelegate;
		if (iKImageBrowserDelegate == null)
		{
			iKImageBrowserDelegate = (_IKImageBrowserDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return iKImageBrowserDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DraggingDestinationDelegate_var = null;
			__mt_WeakDataSource_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
