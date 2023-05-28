using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSTableViewDataSource", false)]
[Model]
public class NSTableViewDataSource : NSObject, INSTableViewDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableViewDataSource()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTableViewDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTableViewDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("tableView:acceptDrop:row:dropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptDrop(NSTableView tableView, NSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:draggingSession:endedAtPoint:operation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingSessionEnded(NSTableView tableView, NSDraggingSession draggingSession, CGPoint endedAtScreenPoint, NSDragOperation operation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:draggingSession:willBeginAtPoint:forRowIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingSessionWillBegin(NSTableView tableView, NSDraggingSession draggingSession, CGPoint willBeginAtScreenPoint, NSIndexSet rowIndexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:namesOfPromisedFilesDroppedAtDestination:forDraggedRowsWithIndexes:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSFilePromiseReceiver' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] FilesDropped(NSTableView tableView, NSUrl dropDestination, NSIndexSet indexSet)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:objectValueForTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetObjectValue(NSTableView tableView, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:pasteboardWriterForRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSPasteboardWriting GetPasteboardWriterForRow(NSTableView tableView, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfRowsInTableView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetRowCount(NSTableView tableView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:setObjectValue:forTableColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetObjectValue(NSTableView tableView, NSObject theObject, NSTableColumn tableColumn, nint row)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:sortDescriptorsDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SortDescriptorsChanged(NSTableView tableView, NSSortDescriptor[] oldDescriptors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:updateDraggingItemsForDrag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateDraggingItems(NSTableView tableView, NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:validateDrop:proposedRow:proposedDropOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation ValidateDrop(NSTableView tableView, NSDraggingInfo info, nint row, NSTableViewDropOperation dropOperation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tableView:writeRowsWithIndexes:toPasteboard:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the 'GetPasteboardWriterForRow' method instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteRows(NSTableView tableView, NSIndexSet rowIndexes, NSPasteboard pboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
