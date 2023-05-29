using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOutlineViewDataSource", true)]
[Model]
public class NSOutlineViewDataSource : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOutlineViewDataSource()
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
	public NSOutlineViewDataSource(NSCoder coder)
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
	public NSOutlineViewDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOutlineViewDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("outlineView:child:ofItem:")]
	public virtual NSObject GetChild(NSOutlineView outlineView, long childIndex, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:isItemExpandable:")]
	public virtual bool ItemExpandable(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:numberOfChildrenOfItem:")]
	public virtual long GetChildrenCount(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:objectValueForTableColumn:byItem:")]
	public virtual NSObject GetObjectValue(NSOutlineView outlineView, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:setObjectValue:forTableColumn:byItem:")]
	public virtual void SetObjectValue(NSOutlineView outlineView, NSObject theObject, NSTableColumn tableColumn, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:itemForPersistentObject:")]
	public virtual NSObject ItemForPersistentObject(NSOutlineView outlineView, NSObject theObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:persistentObjectForItem:")]
	public virtual NSObject PersistentObjectForItem(NSOutlineView outlineView, NSObject item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:sortDescriptorsDidChange:")]
	public virtual void SortDescriptorsChanged(NSOutlineView outlineView, NSSortDescriptor[] oldDescriptors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:writeItems:toPasteboard:")]
	public virtual bool OutlineViewwriteItemstoPasteboard(NSOutlineView outlineView, NSArray items, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:validateDrop:proposedItem:proposedChildIndex:")]
	public virtual NSDragOperation ValidateDrop(NSOutlineView outlineView, NSDraggingInfo info, NSObject item, long index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:acceptDrop:item:childIndex:")]
	public virtual bool AcceptDrop(NSOutlineView outlineView, NSDraggingInfo info, NSObject item, long index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("outlineView:namesOfPromisedFilesDroppedAtDestination:forDraggedItems:")]
	public virtual string[] FilesDropped(NSOutlineView outlineView, NSUrl dropDestination, NSArray items)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
