using System.ComponentModel;
using System.Diagnostics;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSCollectionView", true)]
public class NSCollectionView : NSView, INSDraggingDestination, INativeObject, IDisposable, INSDraggingSource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsEmptySelection = "allowsEmptySelection";

	private static readonly IntPtr selAllowsEmptySelectionHandle = Selector.GetHandle("allowsEmptySelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsMultipleSelection = "allowsMultipleSelection";

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColors = "backgroundColors";

	private static readonly IntPtr selBackgroundColorsHandle = Selector.GetHandle("backgroundColors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundView = "backgroundView";

	private static readonly IntPtr selBackgroundViewHandle = Selector.GetHandle("backgroundView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundViewScrollsWithContent = "backgroundViewScrollsWithContent";

	private static readonly IntPtr selBackgroundViewScrollsWithContentHandle = Selector.GetHandle("backgroundViewScrollsWithContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionViewLayout = "collectionViewLayout";

	private static readonly IntPtr selCollectionViewLayoutHandle = Selector.GetHandle("collectionViewLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConcludeDragOperation_ = "concludeDragOperation:";

	private static readonly IntPtr selConcludeDragOperation_Handle = Selector.GetHandle("concludeDragOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContent = "content";

	private static readonly IntPtr selContentHandle = Selector.GetHandle("content");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteItemsAtIndexPaths_ = "deleteItemsAtIndexPaths:";

	private static readonly IntPtr selDeleteItemsAtIndexPaths_Handle = Selector.GetHandle("deleteItemsAtIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteSections_ = "deleteSections:";

	private static readonly IntPtr selDeleteSections_Handle = Selector.GetHandle("deleteSections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeselectAll_ = "deselectAll:";

	private static readonly IntPtr selDeselectAll_Handle = Selector.GetHandle("deselectAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeselectItemsAtIndexPaths_ = "deselectItemsAtIndexPaths:";

	private static readonly IntPtr selDeselectItemsAtIndexPaths_Handle = Selector.GetHandle("deselectItemsAtIndexPaths:");

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
	private const string selDraggingEnded_ = "draggingEnded:";

	private static readonly IntPtr selDraggingEnded_Handle = Selector.GetHandle("draggingEnded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingEntered_ = "draggingEntered:";

	private static readonly IntPtr selDraggingEntered_Handle = Selector.GetHandle("draggingEntered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingExited_ = "draggingExited:";

	private static readonly IntPtr selDraggingExited_Handle = Selector.GetHandle("draggingExited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingImageForItemsAtIndexPaths_WithEvent_Offset_ = "draggingImageForItemsAtIndexPaths:withEvent:offset:";

	private static readonly IntPtr selDraggingImageForItemsAtIndexPaths_WithEvent_Offset_Handle = Selector.GetHandle("draggingImageForItemsAtIndexPaths:withEvent:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingSourceOperationMaskForLocal_ = "draggingSourceOperationMaskForLocal:";

	private static readonly IntPtr selDraggingSourceOperationMaskForLocal_Handle = Selector.GetHandle("draggingSourceOperationMaskForLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingUpdated_ = "draggingUpdated:";

	private static readonly IntPtr selDraggingUpdated_Handle = Selector.GetHandle("draggingUpdated:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameForItemAtIndex_ = "frameForItemAtIndex:";

	private static readonly IntPtr selFrameForItemAtIndex_Handle = Selector.GetHandle("frameForItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameForItemAtIndex_WithNumberOfItems_ = "frameForItemAtIndex:withNumberOfItems:";

	private static readonly IntPtr selFrameForItemAtIndex_WithNumberOfItems_Handle = Selector.GetHandle("frameForItemAtIndex:withNumberOfItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoreModifierKeysWhileDragging = "ignoreModifierKeysWhileDragging";

	private static readonly IntPtr selIgnoreModifierKeysWhileDraggingHandle = Selector.GetHandle("ignoreModifierKeysWhileDragging");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathForItem_ = "indexPathForItem:";

	private static readonly IntPtr selIndexPathForItem_Handle = Selector.GetHandle("indexPathForItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathForItemAtPoint_ = "indexPathForItemAtPoint:";

	private static readonly IntPtr selIndexPathForItemAtPoint_Handle = Selector.GetHandle("indexPathForItemAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathsForVisibleItems = "indexPathsForVisibleItems";

	private static readonly IntPtr selIndexPathsForVisibleItemsHandle = Selector.GetHandle("indexPathsForVisibleItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathsForVisibleSupplementaryElementsOfKind_ = "indexPathsForVisibleSupplementaryElementsOfKind:";

	private static readonly IntPtr selIndexPathsForVisibleSupplementaryElementsOfKind_Handle = Selector.GetHandle("indexPathsForVisibleSupplementaryElementsOfKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItemsAtIndexPaths_ = "insertItemsAtIndexPaths:";

	private static readonly IntPtr selInsertItemsAtIndexPaths_Handle = Selector.GetHandle("insertItemsAtIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertSections_ = "insertSections:";

	private static readonly IntPtr selInsertSections_Handle = Selector.GetHandle("insertSections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFirstResponder = "isFirstResponder";

	private static readonly IntPtr selIsFirstResponderHandle = Selector.GetHandle("isFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelectable = "isSelectable";

	private static readonly IntPtr selIsSelectableHandle = Selector.GetHandle("isSelectable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtIndex_ = "itemAtIndex:";

	private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtIndexPath_ = "itemAtIndexPath:";

	private static readonly IntPtr selItemAtIndexPath_Handle = Selector.GetHandle("itemAtIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemPrototype = "itemPrototype";

	private static readonly IntPtr selItemPrototypeHandle = Selector.GetHandle("itemPrototype");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForItemAtIndexPath_ = "layoutAttributesForItemAtIndexPath:";

	private static readonly IntPtr selLayoutAttributesForItemAtIndexPath_Handle = Selector.GetHandle("layoutAttributesForItemAtIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForSupplementaryElementOfKind_AtIndexPath_ = "layoutAttributesForSupplementaryElementOfKind:atIndexPath:";

	private static readonly IntPtr selLayoutAttributesForSupplementaryElementOfKind_AtIndexPath_Handle = Selector.GetHandle("layoutAttributesForSupplementaryElementOfKind:atIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeItemWithIdentifier_ForIndexPath_ = "makeItemWithIdentifier:forIndexPath:";

	private static readonly IntPtr selMakeItemWithIdentifier_ForIndexPath_Handle = Selector.GetHandle("makeItemWithIdentifier:forIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeSupplementaryViewOfKind_WithIdentifier_ForIndexPath_ = "makeSupplementaryViewOfKind:withIdentifier:forIndexPath:";

	private static readonly IntPtr selMakeSupplementaryViewOfKind_WithIdentifier_ForIndexPath_Handle = Selector.GetHandle("makeSupplementaryViewOfKind:withIdentifier:forIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxItemSize = "maxItemSize";

	private static readonly IntPtr selMaxItemSizeHandle = Selector.GetHandle("maxItemSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxNumberOfColumns = "maxNumberOfColumns";

	private static readonly IntPtr selMaxNumberOfColumnsHandle = Selector.GetHandle("maxNumberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxNumberOfRows = "maxNumberOfRows";

	private static readonly IntPtr selMaxNumberOfRowsHandle = Selector.GetHandle("maxNumberOfRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinItemSize = "minItemSize";

	private static readonly IntPtr selMinItemSizeHandle = Selector.GetHandle("minItemSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveItemAtIndexPath_ToIndexPath_ = "moveItemAtIndexPath:toIndexPath:";

	private static readonly IntPtr selMoveItemAtIndexPath_ToIndexPath_Handle = Selector.GetHandle("moveItemAtIndexPath:toIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveSection_ToSection_ = "moveSection:toSection:";

	private static readonly IntPtr selMoveSection_ToSection_Handle = Selector.GetHandle("moveSection:toSection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamesOfPromisedFilesDroppedAtDestination_ = "namesOfPromisedFilesDroppedAtDestination:";

	private static readonly IntPtr selNamesOfPromisedFilesDroppedAtDestination_Handle = Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewItemForRepresentedObject_ = "newItemForRepresentedObject:";

	private static readonly IntPtr selNewItemForRepresentedObject_Handle = Selector.GetHandle("newItemForRepresentedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfItemsInSection_ = "numberOfItemsInSection:";

	private static readonly IntPtr selNumberOfItemsInSection_Handle = Selector.GetHandle("numberOfItemsInSection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfSections = "numberOfSections";

	private static readonly IntPtr selNumberOfSectionsHandle = Selector.GetHandle("numberOfSections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformBatchUpdates_CompletionHandler_ = "performBatchUpdates:completionHandler:";

	private static readonly IntPtr selPerformBatchUpdates_CompletionHandler_Handle = Selector.GetHandle("performBatchUpdates:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformDragOperation_ = "performDragOperation:";

	private static readonly IntPtr selPerformDragOperation_Handle = Selector.GetHandle("performDragOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefetchDataSource = "prefetchDataSource";

	private static readonly IntPtr selPrefetchDataSourceHandle = Selector.GetHandle("prefetchDataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForDragOperation_ = "prepareForDragOperation:";

	private static readonly IntPtr selPrepareForDragOperation_Handle = Selector.GetHandle("prepareForDragOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterClass_ForItemWithIdentifier_ = "registerClass:forItemWithIdentifier:";

	private static readonly IntPtr selRegisterClass_ForItemWithIdentifier_Handle = Selector.GetHandle("registerClass:forItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterClass_ForSupplementaryViewOfKind_WithIdentifier_ = "registerClass:forSupplementaryViewOfKind:withIdentifier:";

	private static readonly IntPtr selRegisterClass_ForSupplementaryViewOfKind_WithIdentifier_Handle = Selector.GetHandle("registerClass:forSupplementaryViewOfKind:withIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterNib_ForItemWithIdentifier_ = "registerNib:forItemWithIdentifier:";

	private static readonly IntPtr selRegisterNib_ForItemWithIdentifier_Handle = Selector.GetHandle("registerNib:forItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterNib_ForSupplementaryViewOfKind_WithIdentifier_ = "registerNib:forSupplementaryViewOfKind:withIdentifier:";

	private static readonly IntPtr selRegisterNib_ForSupplementaryViewOfKind_WithIdentifier_Handle = Selector.GetHandle("registerNib:forSupplementaryViewOfKind:withIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadData = "reloadData";

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadItemsAtIndexPaths_ = "reloadItemsAtIndexPaths:";

	private static readonly IntPtr selReloadItemsAtIndexPaths_Handle = Selector.GetHandle("reloadItemsAtIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadSections_ = "reloadSections:";

	private static readonly IntPtr selReloadSections_Handle = Selector.GetHandle("reloadSections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollToItemsAtIndexPaths_ScrollPosition_ = "scrollToItemsAtIndexPaths:scrollPosition:";

	private static readonly IntPtr selScrollToItemsAtIndexPaths_ScrollPosition_Handle = Selector.GetHandle("scrollToItemsAtIndexPaths:scrollPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectAll_ = "selectAll:";

	private static readonly IntPtr selSelectAll_Handle = Selector.GetHandle("selectAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectItemsAtIndexPaths_ScrollPosition_ = "selectItemsAtIndexPaths:scrollPosition:";

	private static readonly IntPtr selSelectItemsAtIndexPaths_ScrollPosition_Handle = Selector.GetHandle("selectItemsAtIndexPaths:scrollPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionIndexPaths = "selectionIndexPaths";

	private static readonly IntPtr selSelectionIndexPathsHandle = Selector.GetHandle("selectionIndexPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionIndexes = "selectionIndexes";

	private static readonly IntPtr selSelectionIndexesHandle = Selector.GetHandle("selectionIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsEmptySelection_ = "setAllowsEmptySelection:";

	private static readonly IntPtr selSetAllowsEmptySelection_Handle = Selector.GetHandle("setAllowsEmptySelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsMultipleSelection_ = "setAllowsMultipleSelection:";

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColors_ = "setBackgroundColors:";

	private static readonly IntPtr selSetBackgroundColors_Handle = Selector.GetHandle("setBackgroundColors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundView_ = "setBackgroundView:";

	private static readonly IntPtr selSetBackgroundView_Handle = Selector.GetHandle("setBackgroundView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundViewScrollsWithContent_ = "setBackgroundViewScrollsWithContent:";

	private static readonly IntPtr selSetBackgroundViewScrollsWithContent_Handle = Selector.GetHandle("setBackgroundViewScrollsWithContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollectionViewLayout_ = "setCollectionViewLayout:";

	private static readonly IntPtr selSetCollectionViewLayout_Handle = Selector.GetHandle("setCollectionViewLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContent_ = "setContent:";

	private static readonly IntPtr selSetContent_Handle = Selector.GetHandle("setContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataSource_ = "setDataSource:";

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingSourceOperationMask_ForLocal_ = "setDraggingSourceOperationMask:forLocal:";

	private static readonly IntPtr selSetDraggingSourceOperationMask_ForLocal_Handle = Selector.GetHandle("setDraggingSourceOperationMask:forLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetItemPrototype_ = "setItemPrototype:";

	private static readonly IntPtr selSetItemPrototype_Handle = Selector.GetHandle("setItemPrototype:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxItemSize_ = "setMaxItemSize:";

	private static readonly IntPtr selSetMaxItemSize_Handle = Selector.GetHandle("setMaxItemSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxNumberOfColumns_ = "setMaxNumberOfColumns:";

	private static readonly IntPtr selSetMaxNumberOfColumns_Handle = Selector.GetHandle("setMaxNumberOfColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxNumberOfRows_ = "setMaxNumberOfRows:";

	private static readonly IntPtr selSetMaxNumberOfRows_Handle = Selector.GetHandle("setMaxNumberOfRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinItemSize_ = "setMinItemSize:";

	private static readonly IntPtr selSetMinItemSize_Handle = Selector.GetHandle("setMinItemSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrefetchDataSource_ = "setPrefetchDataSource:";

	private static readonly IntPtr selSetPrefetchDataSource_Handle = Selector.GetHandle("setPrefetchDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectable_ = "setSelectable:";

	private static readonly IntPtr selSetSelectable_Handle = Selector.GetHandle("setSelectable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionIndexPaths_ = "setSelectionIndexPaths:";

	private static readonly IntPtr selSetSelectionIndexPaths_Handle = Selector.GetHandle("setSelectionIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionIndexes_ = "setSelectionIndexes:";

	private static readonly IntPtr selSetSelectionIndexes_Handle = Selector.GetHandle("setSelectionIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupplementaryViewForElementKind_AtIndexPath_ = "supplementaryViewForElementKind:atIndexPath:";

	private static readonly IntPtr selSupplementaryViewForElementKind_AtIndexPath_Handle = Selector.GetHandle("supplementaryViewForElementKind:atIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToggleSectionCollapse_ = "toggleSectionCollapse:";

	private static readonly IntPtr selToggleSectionCollapse_Handle = Selector.GetHandle("toggleSectionCollapse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleItems = "visibleItems";

	private static readonly IntPtr selVisibleItemsHandle = Selector.GetHandle("visibleItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleSupplementaryViewsOfKind_ = "visibleSupplementaryViewsOfKind:";

	private static readonly IntPtr selVisibleSupplementaryViewsOfKind_Handle = Selector.GetHandle("visibleSupplementaryViewsOfKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsPeriodicDraggingUpdates = "wantsPeriodicDraggingUpdates";

	private static readonly IntPtr selWantsPeriodicDraggingUpdatesHandle = Selector.GetHandle("wantsPeriodicDraggingUpdates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_DataSource_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_PrefetchDataSource_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool AllowsEmptySelection
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("allowsEmptySelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEmptySelectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAllowsEmptySelection:")]
		set
		{
			NSApplication.EnsureUIThread();
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
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
		[Export("setAllowsMultipleSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
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
	public virtual NSColor[]? BackgroundColors
	{
		[Export("backgroundColors", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorsHandle));
			}
			return NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorsHandle));
		}
		[Export("setBackgroundColors:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSView? BackgroundView
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("backgroundView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundViewHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setBackgroundView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool BackgroundViewScrollsWithContent
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("backgroundViewScrollsWithContent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBackgroundViewScrollsWithContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBackgroundViewScrollsWithContentHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setBackgroundViewScrollsWithContent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBackgroundViewScrollsWithContent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBackgroundViewScrollsWithContent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSCollectionViewLayout? CollectionViewLayout
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("collectionViewLayout", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionViewLayout>(Messaging.IntPtr_objc_msgSend(base.Handle, selCollectionViewLayoutHandle));
			}
			return Runtime.GetNSObject<NSCollectionViewLayout>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollectionViewLayoutHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setCollectionViewLayout:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCollectionViewLayout_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCollectionViewLayout_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Content
	{
		[Export("content", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentHandle));
		}
		[Export("setContent:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContent_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContent_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual INSCollectionViewDataSource? DataSource
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("dataSource", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSCollectionViewDataSource iNSCollectionViewDataSource = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSCollectionViewDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle), owns: false) : Runtime.GetINativeObject<INSCollectionViewDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle), owns: false));
			MarkDirty();
			__mt_DataSource_var = iNSCollectionViewDataSource;
			return iNSCollectionViewDataSource;
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
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
			__mt_DataSource_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSCollectionViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSCollectionViewDelegate;
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
	public virtual bool IgnoreModifierKeysWhileDragging
	{
		[Export("ignoreModifierKeysWhileDragging")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoreModifierKeysWhileDraggingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoreModifierKeysWhileDraggingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSSet<NSIndexPath> IndexPathsForVisibleItems
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("indexPathsForVisibleItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet<NSIndexPath>>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexPathsForVisibleItemsHandle));
			}
			return Runtime.GetNSObject<NSSet<NSIndexPath>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexPathsForVisibleItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFirstResponder
	{
		[Export("isFirstResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFirstResponderHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFirstResponderHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'RegisterNib' or 'RegisterClassForItem' instead.")]
	public virtual NSCollectionViewItem ItemPrototype
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'RegisterNib' or 'RegisterClassForItem' instead.")]
		[Export("itemPrototype", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemPrototypeHandle));
			}
			return Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemPrototypeHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'RegisterNib' or 'RegisterClassForItem' instead.")]
		[Export("setItemPrototype:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetItemPrototype_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetItemPrototype_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumItemSize' instead.")]
	public virtual CGSize MaxItemSize
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumItemSize' instead.")]
		[Export("maxItemSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaxItemSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaxItemSizeHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumItemSize' instead.")]
		[Export("setMaxItemSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaxItemSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaxItemSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumNumberOfColumns' instead.")]
	public virtual nint MaxNumberOfColumns
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumNumberOfColumns' instead.")]
		[Export("maxNumberOfColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaxNumberOfColumnsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaxNumberOfColumnsHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumNumberOfColumns' instead.")]
		[Export("setMaxNumberOfColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaxNumberOfColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaxNumberOfColumns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumNumberOfRows' instead.")]
	public virtual nint MaxNumberOfRows
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumNumberOfRows' instead.")]
		[Export("maxNumberOfRows")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaxNumberOfRowsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaxNumberOfRowsHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MaximumNumberOfRows' instead.")]
		[Export("setMaxNumberOfRows:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaxNumberOfRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaxNumberOfRows_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MinimumItemSize' instead.")]
	public virtual CGSize MinItemSize
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MinimumItemSize' instead.")]
		[Export("minItemSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinItemSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinItemSizeHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Set a NSCollectionViewGridLayout on CollectionViewLayout and set its 'MinimumItemSize' instead.")]
		[Export("setMinItemSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMinItemSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMinItemSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nint NumberOfSections
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("numberOfSections")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfSectionsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfSectionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual INSCollectionViewPrefetching? PrefetchDataSource
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("prefetchDataSource", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSCollectionViewPrefetching iNSCollectionViewPrefetching = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSCollectionViewPrefetching>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrefetchDataSourceHandle), owns: false) : Runtime.GetINativeObject<INSCollectionViewPrefetching>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrefetchDataSourceHandle), owns: false));
			MarkDirty();
			__mt_PrefetchDataSource_var = iNSCollectionViewPrefetching;
			return iNSCollectionViewPrefetching;
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setPrefetchDataSource:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrefetchDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrefetchDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_PrefetchDataSource_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Selectable
	{
		[Export("isSelectable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectableHandle);
		}
		[Export("setSelectable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSSet SelectionIndexPaths
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("selectionIndexPaths", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexPathsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexPathsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setSelectionIndexPaths:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexPaths_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexPaths_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SelectionIndexes
	{
		[Export("selectionIndexes", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexesHandle));
		}
		[Export("setSelectionIndexes:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSCollectionViewItem[] VisibleItems
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("visibleItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selVisibleItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisibleItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public new virtual bool WantsPeriodicDraggingUpdates
	{
		[Export("wantsPeriodicDraggingUpdates")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsPeriodicDraggingUpdatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsPeriodicDraggingUpdatesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
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

	public void RegisterClassForItem(Type itemClass, string identifier)
	{
		_RegisterClassForItem((itemClass == null) ? IntPtr.Zero : ObjCRuntime.Class.GetHandle(itemClass), identifier);
	}

	public void RegisterClassForSupplementaryView(Type viewClass, NSString kind, string identifier)
	{
		_RegisterClassForSupplementaryView((viewClass == null) ? IntPtr.Zero : ObjCRuntime.Class.GetHandle(viewClass), kind, identifier);
	}

	[Mac(10, 11)]
	[Obsolete("Use 'GetLayoutAttributes' instead.")]
	public virtual NSCollectionViewLayoutAttributes GetLayoutAttributest(string kind, NSIndexPath indexPath)
	{
		return GetLayoutAttributes(kind, indexPath);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionView()
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
	public NSCollectionView(NSCoder coder)
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
	protected NSCollectionView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCollectionView(CGRect frameRect)
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

	[Export("concludeDragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void ConcludeDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selConcludeDragOperation_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selConcludeDragOperation_Handle, sender.Handle);
		}
	}

	[Export("deleteItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteItems(NSSet<NSIndexPath> indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
	}

	[Export("deleteSections:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteSections(NSIndexSet sections)
	{
		NSApplication.EnsureUIThread();
		if (sections == null)
		{
			throw new ArgumentNullException("sections");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteSections_Handle, sections.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteSections_Handle, sections.Handle);
		}
	}

	[Export("deselectAll:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeselectAll(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeselectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeselectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("deselectItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeselectItems(NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeselectItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeselectItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
	}

	[Export("draggedImage:beganAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageBeganAt(NSImage image, CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
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
		NSApplication.EnsureUIThread();
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
		NSApplication.EnsureUIThread();
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
		NSApplication.EnsureUIThread();
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

	[Export("draggingEnded:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void DraggingEnded(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDraggingEnded_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingEnded_Handle, sender.Handle);
		}
	}

	[Export("draggingEntered:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSDragOperation DraggingEntered(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selDraggingEntered_Handle, sender.Handle);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingEntered_Handle, sender.Handle);
	}

	[Export("draggingExited:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void DraggingExited(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDraggingExited_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingExited_Handle, sender.Handle);
		}
	}

	[Export("draggingSourceOperationMaskForLocal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingSourceOperationMaskForLocal(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_bool(base.Handle, selDraggingSourceOperationMaskForLocal_Handle, flag);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_bool(base.SuperHandle, selDraggingSourceOperationMaskForLocal_Handle, flag);
	}

	[Export("draggingUpdated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSDragOperation DraggingUpdated(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			return (NSDragOperation)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selDraggingUpdated_Handle, sender.Handle);
		}
		return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDraggingUpdated_Handle, sender.Handle);
	}

	[Export("frameForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect FrameForItemAtIndex(nint index)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selFrameForItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selFrameForItemAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("frameForItemAtIndex:withNumberOfItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect FrameForItemAtIndex(nint index, nint numberOfItems)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint_nint(out retval, base.Handle, selFrameForItemAtIndex_WithNumberOfItems_Handle, index, numberOfItems);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint_nint(out retval, base.SuperHandle, selFrameForItemAtIndex_WithNumberOfItems_Handle, index, numberOfItems);
		}
		return retval;
	}

	[Export("draggingImageForItemsAtIndexPaths:withEvent:offset:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage GetDraggingImage(NSSet<NSIndexPath> indexPaths, NSEvent theEvent, ref CGPoint dragImageOffset)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_CGPoint(base.Handle, selDraggingImageForItemsAtIndexPaths_WithEvent_Offset_Handle, indexPaths.Handle, theEvent.Handle, ref dragImageOffset));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_CGPoint(base.SuperHandle, selDraggingImageForItemsAtIndexPaths_WithEvent_Offset_Handle, indexPaths.Handle, theEvent.Handle, ref dragImageOffset));
	}

	[Export("indexPathForItem:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath? GetIndexPath(NSCollectionViewItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIndexPathForItem_Handle, item.Handle));
		}
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexPathForItem_Handle, item.Handle));
	}

	[Export("indexPathForItemAtPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath? GetIndexPath(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selIndexPathForItemAtPoint_Handle, point));
		}
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selIndexPathForItemAtPoint_Handle, point));
	}

	[Export("indexPathsForVisibleSupplementaryElementsOfKind:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet GetIndexPaths(string elementKind)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		IntPtr arg = NSString.CreateNative(elementKind);
		NSSet result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexPathsForVisibleSupplementaryElementsOfKind_Handle, arg)) : Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIndexPathsForVisibleSupplementaryElementsOfKind_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("itemAtIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewItem? GetItem(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemAtIndexPath_Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemAtIndexPath_Handle, indexPath.Handle));
	}

	[Export("layoutAttributesForItemAtIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributes(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLayoutAttributesForItemAtIndexPath_Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLayoutAttributesForItemAtIndexPath_Handle, indexPath.Handle));
	}

	[Export("layoutAttributesForSupplementaryElementOfKind:atIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributes(string kind, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (kind == null)
		{
			throw new ArgumentNullException("kind");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		IntPtr arg = NSString.CreateNative(kind);
		NSCollectionViewLayoutAttributes result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLayoutAttributesForSupplementaryElementOfKind_AtIndexPath_Handle, arg, indexPath.Handle)) : Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLayoutAttributesForSupplementaryElementOfKind_AtIndexPath_Handle, arg, indexPath.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("numberOfItemsInSection:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetNumberOfItems(nint section)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selNumberOfItemsInSection_Handle, section);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selNumberOfItemsInSection_Handle, section);
	}

	[Export("supplementaryViewForElementKind:atIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSCollectionViewElement? GetSupplementaryView(NSString elementKind, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<INSCollectionViewElement>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selSupplementaryViewForElementKind_AtIndexPath_Handle, elementKind.Handle, indexPath.Handle), owns: false);
		}
		return Runtime.GetINativeObject<INSCollectionViewElement>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSupplementaryViewForElementKind_AtIndexPath_Handle, elementKind.Handle, indexPath.Handle), owns: false);
	}

	[Export("visibleSupplementaryViewsOfKind:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSCollectionViewElement[] GetVisibleSupplementaryViews(NSString elementKind)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<INSCollectionViewElement>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selVisibleSupplementaryViewsOfKind_Handle, elementKind.Handle));
		}
		return NSArray.ArrayFromHandle<INSCollectionViewElement>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selVisibleSupplementaryViewsOfKind_Handle, elementKind.Handle));
	}

	[Export("insertItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertItems(NSSet<NSIndexPath> indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
	}

	[Export("insertSections:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSections(NSIndexSet sections)
	{
		NSApplication.EnsureUIThread();
		if (sections == null)
		{
			throw new ArgumentNullException("sections");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertSections_Handle, sections.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertSections_Handle, sections.Handle);
		}
	}

	[Export("itemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewItem ItemAtIndex(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemAtIndex_Handle, index));
	}

	[Export("makeItemWithIdentifier:forIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewItem MakeItem(string identifier, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSCollectionViewItem result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMakeItemWithIdentifier_ForIndexPath_Handle, arg, indexPath.Handle)) : Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selMakeItemWithIdentifier_ForIndexPath_Handle, arg, indexPath.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("makeSupplementaryViewOfKind:withIdentifier:forIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView MakeSupplementaryView(NSString elementKind, string identifier, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSView result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMakeSupplementaryViewOfKind_WithIdentifier_ForIndexPath_Handle, elementKind.Handle, arg, indexPath.Handle)) : Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selMakeSupplementaryViewOfKind_WithIdentifier_ForIndexPath_Handle, elementKind.Handle, arg, indexPath.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("moveItemAtIndexPath:toIndexPath:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveItem(NSIndexPath indexPath, NSIndexPath newIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (newIndexPath == null)
		{
			throw new ArgumentNullException("newIndexPath");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveItemAtIndexPath_ToIndexPath_Handle, indexPath.Handle, newIndexPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveItemAtIndexPath_ToIndexPath_Handle, indexPath.Handle, newIndexPath.Handle);
		}
	}

	[Export("moveSection:toSection:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveSection(nint section, nint newSection)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selMoveSection_ToSection_Handle, section, newSection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selMoveSection_ToSection_Handle, section, newSection);
		}
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use NSFilePromiseProvider objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
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

	[Export("newItemForRepresentedObject:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSCollectionViewDataSource.GetItem()' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSCollectionViewItem NewItemForRepresentedObject(NSObject obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		NSCollectionViewItem nSCollectionViewItem = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewItemForRepresentedObject_Handle, obj.Handle)) : Runtime.GetNSObject<NSCollectionViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewItemForRepresentedObject_Handle, obj.Handle)));
		if (nSCollectionViewItem != null)
		{
			Messaging.void_objc_msgSend(nSCollectionViewItem.Handle, Selector.GetHandle("release"));
		}
		return nSCollectionViewItem;
	}

	[Export("performBatchUpdates:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformBatchUpdates([BlockProxy(typeof(Trampolines.NIDAction))] Action updates, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (updates == null)
		{
			throw new ArgumentNullException("updates");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, updates);
		BlockLiteral blockLiteral2 = default(BlockLiteral);
		BlockLiteral* ptr2 = &blockLiteral2;
		blockLiteral2.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPerformBatchUpdates_CompletionHandler_Handle, (IntPtr)ptr, (IntPtr)ptr2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPerformBatchUpdates_CompletionHandler_Handle, (IntPtr)ptr, (IntPtr)ptr2);
		}
		ptr->CleanupBlock();
		ptr2->CleanupBlock();
	}

	[Export("performDragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool PerformDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformDragOperation_Handle, sender.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformDragOperation_Handle, sender.Handle);
	}

	[Export("prepareForDragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool PrepareForDragOperation(NSDraggingInfo sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPrepareForDragOperation_Handle, sender.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareForDragOperation_Handle, sender.Handle);
	}

	[Export("registerNib:forItemWithIdentifier:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterNib(NSNib? nib, string identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterNib_ForItemWithIdentifier_Handle, nib?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterNib_ForItemWithIdentifier_Handle, nib?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("registerNib:forSupplementaryViewOfKind:withIdentifier:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterNib(NSNib? nib, NSString kind, string identifier)
	{
		NSApplication.EnsureUIThread();
		if (kind == null)
		{
			throw new ArgumentNullException("kind");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRegisterNib_ForSupplementaryViewOfKind_WithIdentifier_Handle, nib?.Handle ?? IntPtr.Zero, kind.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRegisterNib_ForSupplementaryViewOfKind_WithIdentifier_Handle, nib?.Handle ?? IntPtr.Zero, kind.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("reloadData")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadData()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("reloadItemsAtIndexPaths:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadItems(NSSet<NSIndexPath> indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
	}

	[Export("reloadSections:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadSections(NSIndexSet sections)
	{
		NSApplication.EnsureUIThread();
		if (sections == null)
		{
			throw new ArgumentNullException("sections");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadSections_Handle, sections.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadSections_Handle, sections.Handle);
		}
	}

	[Export("scrollToItemsAtIndexPaths:scrollPosition:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollToItems(NSSet<NSIndexPath> indexPaths, NSCollectionViewScrollPosition scrollPosition)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selScrollToItemsAtIndexPaths_ScrollPosition_Handle, indexPaths.Handle, (ulong)scrollPosition);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selScrollToItemsAtIndexPaths_ScrollPosition_Handle, indexPaths.Handle, (ulong)scrollPosition);
		}
	}

	[Export("selectAll:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectAll(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectAll_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("selectItemsAtIndexPaths:scrollPosition:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectItems(NSSet indexPaths, NSCollectionViewScrollPosition scrollPosition)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selSelectItemsAtIndexPaths_ScrollPosition_Handle, indexPaths.Handle, (ulong)scrollPosition);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selSelectItemsAtIndexPaths_ScrollPosition_Handle, indexPaths.Handle, (ulong)scrollPosition);
		}
	}

	[Export("setDraggingSourceOperationMask:forLocal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDraggingSource(NSDragOperation dragOperationMask, bool localDestination)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_bool(base.Handle, selSetDraggingSourceOperationMask_ForLocal_Handle, (ulong)dragOperationMask, localDestination);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_bool(base.SuperHandle, selSetDraggingSourceOperationMask_ForLocal_Handle, (ulong)dragOperationMask, localDestination);
		}
	}

	[Export("toggleSectionCollapse:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ToggleSectionCollapse(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToggleSectionCollapse_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToggleSectionCollapse_Handle, sender.Handle);
		}
	}

	[Export("registerClass:forItemWithIdentifier:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _RegisterClassForItem(IntPtr itemClass, string identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterClass_ForItemWithIdentifier_Handle, itemClass, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterClass_ForItemWithIdentifier_Handle, itemClass, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("registerClass:forSupplementaryViewOfKind:withIdentifier:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _RegisterClassForSupplementaryView(IntPtr viewClass, NSString kind, string identifier)
	{
		NSApplication.EnsureUIThread();
		if (kind == null)
		{
			throw new ArgumentNullException("kind");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRegisterClass_ForSupplementaryViewOfKind_WithIdentifier_Handle, viewClass, kind.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRegisterClass_ForSupplementaryViewOfKind_WithIdentifier_Handle, viewClass, kind.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DataSource_var = null;
			__mt_PrefetchDataSource_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
