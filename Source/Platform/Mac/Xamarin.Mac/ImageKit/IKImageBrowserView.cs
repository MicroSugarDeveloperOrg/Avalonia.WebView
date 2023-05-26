using System;
using System.ComponentModel;
using AppKit;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKImageBrowserView", true)]
public class IKImageBrowserView : NSView
{
	[Register]
	private sealed class _IKImageBrowserDelegate : IKImageBrowserDelegate
	{
		internal EventHandler selectionDidChange;

		internal EventHandler<IKImageBrowserViewIndexEventArgs> cellWasDoubleClicked;

		internal EventHandler<IKImageBrowserViewIndexEventEventArgs> cellWasRightClicked;

		internal EventHandler<IKImageBrowserViewEventEventArgs> backgroundWasRightClicked;

		[Preserve(Conditional = true)]
		public override void SelectionDidChange(IKImageBrowserView browser)
		{
			selectionDidChange?.Invoke(browser, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void CellWasDoubleClicked(IKImageBrowserView browser, int index)
		{
			EventHandler<IKImageBrowserViewIndexEventArgs> eventHandler = cellWasDoubleClicked;
			if (eventHandler != null)
			{
				IKImageBrowserViewIndexEventArgs e = new IKImageBrowserViewIndexEventArgs(index);
				eventHandler(browser, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void CellWasRightClicked(IKImageBrowserView browser, int index, NSEvent nsevent)
		{
			EventHandler<IKImageBrowserViewIndexEventEventArgs> eventHandler = cellWasRightClicked;
			if (eventHandler != null)
			{
				IKImageBrowserViewIndexEventEventArgs e = new IKImageBrowserViewIndexEventEventArgs(index, nsevent);
				eventHandler(browser, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void BackgroundWasRightClicked(IKImageBrowserView browser, NSEvent nsevent)
		{
			EventHandler<IKImageBrowserViewEventEventArgs> eventHandler = backgroundWasRightClicked;
			if (eventHandler != null)
			{
				IKImageBrowserViewEventEventArgs e = new IKImageBrowserViewEventEventArgs(nsevent);
				eventHandler(browser, e);
			}
		}
	}

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selCellsStyleMaskHandle = Selector.GetHandle("cellsStyleMask");

	private static readonly IntPtr selSetCellsStyleMask_Handle = Selector.GetHandle("setCellsStyleMask:");

	private static readonly IntPtr selConstrainsToOriginalSizeHandle = Selector.GetHandle("constrainsToOriginalSize");

	private static readonly IntPtr selSetConstrainsToOriginalSize_Handle = Selector.GetHandle("setConstrainsToOriginalSize:");

	private static readonly IntPtr selBackgroundLayerHandle = Selector.GetHandle("backgroundLayer");

	private static readonly IntPtr selSetBackgroundLayer_Handle = Selector.GetHandle("setBackgroundLayer:");

	private static readonly IntPtr selForegroundLayerHandle = Selector.GetHandle("foregroundLayer");

	private static readonly IntPtr selSetForegroundLayer_Handle = Selector.GetHandle("setForegroundLayer:");

	private static readonly IntPtr selZoomValueHandle = Selector.GetHandle("zoomValue");

	private static readonly IntPtr selSetZoomValue_Handle = Selector.GetHandle("setZoomValue:");

	private static readonly IntPtr selContentResizingMaskHandle = Selector.GetHandle("contentResizingMask");

	private static readonly IntPtr selSetContentResizingMask_Handle = Selector.GetHandle("setContentResizingMask:");

	private static readonly IntPtr selCellSizeHandle = Selector.GetHandle("cellSize");

	private static readonly IntPtr selSetCellSize_Handle = Selector.GetHandle("setCellSize:");

	private static readonly IntPtr selIntercellSpacingHandle = Selector.GetHandle("intercellSpacing");

	private static readonly IntPtr selSetIntercellSpacing_Handle = Selector.GetHandle("setIntercellSpacing:");

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	private static readonly IntPtr selCanControlQuickLookPanelHandle = Selector.GetHandle("canControlQuickLookPanel");

	private static readonly IntPtr selSetCanControlQuickLookPanel_Handle = Selector.GetHandle("setCanControlQuickLookPanel:");

	private static readonly IntPtr selSelectionIndexesHandle = Selector.GetHandle("selectionIndexes");

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	private static readonly IntPtr selAllowsEmptySelectionHandle = Selector.GetHandle("allowsEmptySelection");

	private static readonly IntPtr selSetAllowsEmptySelection_Handle = Selector.GetHandle("setAllowsEmptySelection:");

	private static readonly IntPtr selAllowsReorderingHandle = Selector.GetHandle("allowsReordering");

	private static readonly IntPtr selSetAllowsReordering_Handle = Selector.GetHandle("setAllowsReordering:");

	private static readonly IntPtr selAnimatesHandle = Selector.GetHandle("animates");

	private static readonly IntPtr selSetAnimates_Handle = Selector.GetHandle("setAnimates:");

	private static readonly IntPtr selDraggingDestinationDelegateHandle = Selector.GetHandle("draggingDestinationDelegate");

	private static readonly IntPtr selSetDraggingDestinationDelegate_Handle = Selector.GetHandle("setDraggingDestinationDelegate:");

	private static readonly IntPtr selAllowsDroppingOnItemsHandle = Selector.GetHandle("allowsDroppingOnItems");

	private static readonly IntPtr selSetAllowsDroppingOnItems_Handle = Selector.GetHandle("setAllowsDroppingOnItems:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	private static readonly IntPtr selNewCellForRepresentedItem_Handle = Selector.GetHandle("newCellForRepresentedItem:");

	private static readonly IntPtr selCellForItemAtIndex_Handle = Selector.GetHandle("cellForItemAtIndex:");

	private static readonly IntPtr selScrollIndexToVisible_Handle = Selector.GetHandle("scrollIndexToVisible:");

	private static readonly IntPtr selIndexOfItemAtPoint_Handle = Selector.GetHandle("indexOfItemAtPoint:");

	private static readonly IntPtr selItemFrameAtIndex_Handle = Selector.GetHandle("itemFrameAtIndex:");

	private static readonly IntPtr selVisibleItemIndexesHandle = Selector.GetHandle("visibleItemIndexes");

	private static readonly IntPtr selRowIndexesInRect_Handle = Selector.GetHandle("rowIndexesInRect:");

	private static readonly IntPtr selColumnIndexesInRect_Handle = Selector.GetHandle("columnIndexesInRect:");

	private static readonly IntPtr selRectOfColumn_Handle = Selector.GetHandle("rectOfColumn:");

	private static readonly IntPtr selRectOfRow_Handle = Selector.GetHandle("rectOfRow:");

	private static readonly IntPtr selSetSelectionIndexesByExtendingSelection_Handle = Selector.GetHandle("setSelectionIndexes:byExtendingSelection:");

	private static readonly IntPtr selExpandGroupAtIndex_Handle = Selector.GetHandle("expandGroupAtIndex:");

	private static readonly IntPtr selCollapseGroupAtIndex_Handle = Selector.GetHandle("collapseGroupAtIndex:");

	private static readonly IntPtr selIsGroupExpandedAtIndex_Handle = Selector.GetHandle("isGroupExpandedAtIndex:");

	private static readonly IntPtr selIndexAtLocationOfDroppedItemHandle = Selector.GetHandle("indexAtLocationOfDroppedItem");

	private static readonly IntPtr selDropOperationHandle = Selector.GetHandle("dropOperation");

	private static readonly IntPtr selSetDropIndexDropOperation_Handle = Selector.GetHandle("setDropIndex:dropOperation:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKImageBrowserView");

	private object __mt_WeakDataSource_var;

	private object __mt_WeakDelegate_var;

	private object __mt_BackgroundLayer_var;

	private object __mt_ForegroundLayer_var;

	private object __mt_SelectionIndexes_var;

	private object __mt_DraggingDestinationDelegate_var;

	private static NSString _BackgroundColorKey;

	private static NSString _SelectionColorKey;

	private static NSString _CellsOutlineColorKey;

	private static NSString _CellsTitleAttributesKey;

	private static NSString _CellsHighlightedTitleAttributesKey;

	private static NSString _CellsSubtitleAttributesKey;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject WeakDataSource
	{
		[Export("dataSource", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDataSource_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle))));
		}
		[Export("setDataSource:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDataSource_var = value;
		}
	}

	public IKImageBrowserDataSource DataSource
	{
		get
		{
			return WeakDataSource as IKImageBrowserDataSource;
		}
		set
		{
			WeakDataSource = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public IKImageBrowserDelegate Delegate
	{
		get
		{
			return WeakDelegate as IKImageBrowserDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual IKCellsStyle CellsStyleMask
	{
		[Export("cellsStyleMask")]
		get
		{
			if (IsDirectBinding)
			{
				return (IKCellsStyle)Messaging.UInt32_objc_msgSend(base.Handle, selCellsStyleMaskHandle);
			}
			return (IKCellsStyle)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selCellsStyleMaskHandle);
		}
		[Export("setCellsStyleMask:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetCellsStyleMask_Handle, (uint)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetCellsStyleMask_Handle, (uint)value);
			}
		}
	}

	public virtual bool ConstrainsToOriginalSize
	{
		[Export("constrainsToOriginalSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selConstrainsToOriginalSizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selConstrainsToOriginalSizeHandle);
		}
		[Export("setConstrainsToOriginalSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetConstrainsToOriginalSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetConstrainsToOriginalSize_Handle, value);
			}
		}
	}

	public virtual CALayer BackgroundLayer
	{
		[Export("backgroundLayer")]
		get
		{
			return (CALayer)(__mt_BackgroundLayer_var = ((!IsDirectBinding) ? ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundLayerHandle))) : ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundLayerHandle)))));
		}
		[Export("setBackgroundLayer:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundLayer_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundLayer_Handle, value.Handle);
			}
			__mt_BackgroundLayer_var = value;
		}
	}

	public virtual CALayer ForegroundLayer
	{
		[Export("foregroundLayer")]
		get
		{
			return (CALayer)(__mt_ForegroundLayer_var = ((!IsDirectBinding) ? ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForegroundLayerHandle))) : ((CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selForegroundLayerHandle)))));
		}
		[Export("setForegroundLayer:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetForegroundLayer_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetForegroundLayer_Handle, value.Handle);
			}
			__mt_ForegroundLayer_var = value;
		}
	}

	public virtual float ZoomValue
	{
		[Export("zoomValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selZoomValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selZoomValueHandle);
		}
		[Export("setZoomValue:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetZoomValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetZoomValue_Handle, value);
			}
		}
	}

	public virtual NSViewResizingMask ContentResizingMask
	{
		[Export("contentResizingMask")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSViewResizingMask)Messaging.UInt64_objc_msgSend(base.Handle, selContentResizingMaskHandle);
			}
			return (NSViewResizingMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selContentResizingMaskHandle);
		}
		[Export("setContentResizingMask:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetContentResizingMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetContentResizingMask_Handle, (ulong)value);
			}
		}
	}

	public virtual CGSize CellSize
	{
		[Export("cellSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selCellSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selCellSizeHandle);
		}
		[Export("setCellSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetCellSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetCellSize_Handle, value);
			}
		}
	}

	public virtual CGSize IntercellSpacing
	{
		[Export("intercellSpacing")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selIntercellSpacingHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selIntercellSpacingHandle);
		}
		[Export("setIntercellSpacing:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetIntercellSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetIntercellSpacing_Handle, value);
			}
		}
	}

	public virtual ulong RowCount
	{
		[Export("numberOfRows")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selNumberOfRowsHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNumberOfRowsHandle);
		}
	}

	public virtual ulong ColumnCount
	{
		[Export("numberOfColumns")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selNumberOfColumnsHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNumberOfColumnsHandle);
		}
	}

	public virtual bool CanControlQuickLookPanel
	{
		[Export("canControlQuickLookPanel")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanControlQuickLookPanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanControlQuickLookPanelHandle);
		}
		[Export("setCanControlQuickLookPanel:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanControlQuickLookPanel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanControlQuickLookPanel_Handle, value);
			}
		}
	}

	public virtual NSIndexSet SelectionIndexes
	{
		[Export("selectionIndexes")]
		get
		{
			return (NSIndexSet)(__mt_SelectionIndexes_var = ((!IsDirectBinding) ? ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexesHandle))) : ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexesHandle)))));
		}
	}

	public virtual bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
		[Export("setAllowsMultipleSelection:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMultipleSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMultipleSelection_Handle, value);
			}
		}
	}

	public virtual bool AllowsEmptySelection
	{
		[Export("allowsEmptySelection")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEmptySelectionHandle);
		}
		[Export("setAllowsEmptySelection:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsEmptySelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsEmptySelection_Handle, value);
			}
		}
	}

	public virtual bool AllowsReordering
	{
		[Export("allowsReordering")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsReorderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsReorderingHandle);
		}
		[Export("setAllowsReordering:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsReordering_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsReordering_Handle, value);
			}
		}
	}

	public virtual bool Animates
	{
		[Export("animates")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAnimatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAnimatesHandle);
		}
		[Export("setAnimates:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAnimates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAnimates_Handle, value);
			}
		}
	}

	public virtual NSDraggingDestination DraggingDestinationDelegate
	{
		[Export("draggingDestinationDelegate")]
		get
		{
			return (NSDraggingDestination)(__mt_DraggingDestinationDelegate_var = ((!IsDirectBinding) ? ((NSDraggingDestination)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingDestinationDelegateHandle))) : ((NSDraggingDestination)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingDestinationDelegateHandle)))));
		}
		[Export("setDraggingDestinationDelegate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDraggingDestinationDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDraggingDestinationDelegate_Handle, value.Handle);
			}
			__mt_DraggingDestinationDelegate_var = value;
		}
	}

	public virtual bool AllowsDroppingOnItems
	{
		[Export("allowsDroppingOnItems")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDroppingOnItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDroppingOnItemsHandle);
		}
		[Export("setAllowsDroppingOnItems:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsDroppingOnItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsDroppingOnItems_Handle, value);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageBrowserView()
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
	public IKImageBrowserView(NSCoder coder)
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
	public IKImageBrowserView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageBrowserView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public IKImageBrowserView(CGRect frame)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frame);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frame);
		}
	}

	[Export("reloadData")]
	public virtual void ReloadData()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("newCellForRepresentedItem:")]
	public virtual IKImageBrowserCell NewCell(IKImageBrowserItem representedItem)
	{
		if (representedItem == null)
		{
			throw new ArgumentNullException("representedItem");
		}
		if (IsDirectBinding)
		{
			return (IKImageBrowserCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewCellForRepresentedItem_Handle, representedItem.Handle));
		}
		return (IKImageBrowserCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewCellForRepresentedItem_Handle, representedItem.Handle));
	}

	[Export("cellForItemAtIndex:")]
	public virtual IKImageBrowserCell GetCellAt(int itemIndex)
	{
		if (IsDirectBinding)
		{
			return (IKImageBrowserCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selCellForItemAtIndex_Handle, itemIndex));
		}
		return (IKImageBrowserCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selCellForItemAtIndex_Handle, itemIndex));
	}

	[Export("scrollIndexToVisible:")]
	public virtual void ScrollIndexToVisible(int index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selScrollIndexToVisible_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selScrollIndexToVisible_Handle, index);
		}
	}

	[Export("indexOfItemAtPoint:")]
	public virtual long GetIndexOfItem(CGPoint point)
	{
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_CGPoint(base.Handle, selIndexOfItemAtPoint_Handle, point);
		}
		return Messaging.Int64_objc_msgSendSuper_CGPoint(base.SuperHandle, selIndexOfItemAtPoint_Handle, point);
	}

	[Export("itemFrameAtIndex:")]
	public virtual CGRect GetItemFrame(long index)
	{
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selItemFrameAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selItemFrameAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("visibleItemIndexes")]
	public virtual NSIndexSet GetVisibleItemIndexes()
	{
		if (IsDirectBinding)
		{
			return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVisibleItemIndexesHandle));
		}
		return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisibleItemIndexesHandle));
	}

	[Export("rowIndexesInRect:")]
	public virtual NSIndexSet GetRowIndexes(CGRect rect)
	{
		if (IsDirectBinding)
		{
			return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selRowIndexesInRect_Handle, rect));
		}
		return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selRowIndexesInRect_Handle, rect));
	}

	[Export("columnIndexesInRect:")]
	public virtual NSIndexSet GetColumnIndexes(CGRect rect)
	{
		if (IsDirectBinding)
		{
			return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selColumnIndexesInRect_Handle, rect));
		}
		return (NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selColumnIndexesInRect_Handle, rect));
	}

	[Export("rectOfColumn:")]
	public virtual CGRect GetRectOfColumn(ulong columnIndex)
	{
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_UInt64(out retval, base.Handle, selRectOfColumn_Handle, columnIndex);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_UInt64(out retval, base.SuperHandle, selRectOfColumn_Handle, columnIndex);
		}
		return retval;
	}

	[Export("rectOfRow:")]
	public virtual CGRect GetRectOfRow(ulong rowIndex)
	{
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_UInt64(out retval, base.Handle, selRectOfRow_Handle, rowIndex);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_UInt64(out retval, base.SuperHandle, selRectOfRow_Handle, rowIndex);
		}
		return retval;
	}

	[Export("setSelectionIndexes:byExtendingSelection:")]
	public virtual void SelectItemsAt(NSIndexSet indexes, bool extendSelection)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetSelectionIndexesByExtendingSelection_Handle, indexes.Handle, extendSelection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetSelectionIndexesByExtendingSelection_Handle, indexes.Handle, extendSelection);
		}
	}

	[Export("expandGroupAtIndex:")]
	public virtual void ExpandGroup(int index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selExpandGroupAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selExpandGroupAtIndex_Handle, index);
		}
	}

	[Export("collapseGroupAtIndex:")]
	public virtual void CollapseGroup(int index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selCollapseGroupAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selCollapseGroupAtIndex_Handle, index);
		}
	}

	[Export("isGroupExpandedAtIndex:")]
	public virtual bool IsGroupExpanded(int index)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_int(base.Handle, selIsGroupExpandedAtIndex_Handle, index);
		}
		return Messaging.bool_objc_msgSendSuper_int(base.SuperHandle, selIsGroupExpandedAtIndex_Handle, index);
	}

	[Export("indexAtLocationOfDroppedItem")]
	public virtual int GetIndexAtLocationOfDroppedItem()
	{
		if (IsDirectBinding)
		{
			return Messaging.int_objc_msgSend(base.Handle, selIndexAtLocationOfDroppedItemHandle);
		}
		return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIndexAtLocationOfDroppedItemHandle);
	}

	[Export("dropOperation")]
	public virtual IKImageBrowserDropOperation DropOperation()
	{
		if (IsDirectBinding)
		{
			return (IKImageBrowserDropOperation)Messaging.int_objc_msgSend(base.Handle, selDropOperationHandle);
		}
		return (IKImageBrowserDropOperation)Messaging.int_objc_msgSendSuper(base.SuperHandle, selDropOperationHandle);
	}

	[Export("setDropIndex:dropOperation:")]
	public virtual void SetDropIndex(int index, IKImageBrowserDropOperation operation)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_int(base.Handle, selSetDropIndexDropOperation_Handle, index, (int)operation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_int(base.SuperHandle, selSetDropIndexDropOperation_Handle, index, (int)operation);
		}
	}

	private _IKImageBrowserDelegate EnsureIKImageBrowserDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _IKImageBrowserDelegate))
		{
			nSObject = (WeakDelegate = new _IKImageBrowserDelegate());
		}
		return (_IKImageBrowserDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDataSource_var = null;
			__mt_WeakDelegate_var = null;
			__mt_BackgroundLayer_var = null;
			__mt_ForegroundLayer_var = null;
			__mt_SelectionIndexes_var = null;
			__mt_DraggingDestinationDelegate_var = null;
		}
	}
}
