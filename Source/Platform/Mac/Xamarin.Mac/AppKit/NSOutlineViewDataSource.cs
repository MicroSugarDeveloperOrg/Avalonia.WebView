using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSOutlineViewDataSource", false)]
[Model]
public class NSOutlineViewDataSource : NSObject, INSOutlineViewDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOutlineViewDataSource()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSOutlineViewDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOutlineViewDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("outlineView:acceptDrop:item:childIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptDrop(NSOutlineView outlineView, NSDraggingInfo info, NSObject? item, nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:draggingSession:endedAtPoint:operation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingSessionEnded(NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSDragOperation operation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:draggingSession:willBeginAtPoint:forItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingSessionWillBegin(NSOutlineView outlineView, NSDraggingSession session, CGPoint screenPoint, NSArray draggedItems)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] FilesDropped(NSOutlineView outlineView, NSUrl dropDestination, NSArray items)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:child:ofItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetChild(NSOutlineView outlineView, nint childIndex, NSObject? item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:numberOfChildrenOfItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetChildrenCount(NSOutlineView outlineView, NSObject? item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:objectValueForTableColumn:byItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetObjectValue(NSOutlineView outlineView, NSTableColumn? tableColumn, NSObject? item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:isItemExpandable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ItemExpandable(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:itemForPersistentObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ItemForPersistentObject(NSOutlineView outlineView, NSObject theObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:writeItems:toPasteboard:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool OutlineViewwriteItemstoPasteboard(NSOutlineView outlineView, NSArray items, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:pasteboardWriterForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSPasteboardWriting PasteboardWriterForItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:persistentObjectForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject PersistentObjectForItem(NSOutlineView outlineView, NSObject? item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:setObjectValue:forTableColumn:byItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetObjectValue(NSOutlineView outlineView, NSObject? theObject, NSTableColumn? tableColumn, NSObject? item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:sortDescriptorsDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SortDescriptorsChanged(NSOutlineView outlineView, NSSortDescriptor[] oldDescriptors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:updateDraggingItemsForDrag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateDraggingItemsForDrag(NSOutlineView outlineView, NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:validateDrop:proposedItem:proposedChildIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation ValidateDrop(NSOutlineView outlineView, NSDraggingInfo info, NSObject? item, nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
