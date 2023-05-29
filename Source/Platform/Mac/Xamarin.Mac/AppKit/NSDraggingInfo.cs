using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDragDestination", true)]
public class NSDraggingInfo : NSObject
{
	private static readonly IntPtr selDraggingDestinationWindowHandle = Selector.GetHandle("draggingDestinationWindow");

	private static readonly IntPtr selDraggingSourceOperationMaskHandle = Selector.GetHandle("draggingSourceOperationMask");

	private static readonly IntPtr selDraggingLocationHandle = Selector.GetHandle("draggingLocation");

	private static readonly IntPtr selDraggedImageLocationHandle = Selector.GetHandle("draggedImageLocation");

	private static readonly IntPtr selDraggedImageHandle = Selector.GetHandle("draggedImage");

	private static readonly IntPtr selDraggingPasteboardHandle = Selector.GetHandle("draggingPasteboard");

	private static readonly IntPtr selDraggingSourceHandle = Selector.GetHandle("draggingSource");

	private static readonly IntPtr selDraggingSequenceNumberHandle = Selector.GetHandle("draggingSequenceNumber");

	private static readonly IntPtr selAnimatesToDestinationHandle = Selector.GetHandle("animatesToDestination");

	private static readonly IntPtr selSetAnimatesToDestination_Handle = Selector.GetHandle("setAnimatesToDestination:");

	private static readonly IntPtr selNumberOfValidItemsForDropHandle = Selector.GetHandle("numberOfValidItemsForDrop");

	private static readonly IntPtr selSetNumberOfValidItemsForDrop_Handle = Selector.GetHandle("setNumberOfValidItemsForDrop:");

	private static readonly IntPtr selDraggingFormationHandle = Selector.GetHandle("draggingFormation");

	private static readonly IntPtr selSetDraggingFormation_Handle = Selector.GetHandle("setDraggingFormation:");

	private static readonly IntPtr selSlideDraggedImageTo_Handle = Selector.GetHandle("slideDraggedImageTo:");

	private static readonly IntPtr selNamesOfPromisedFilesDroppedAtDestination_Handle = Selector.GetHandle("namesOfPromisedFilesDroppedAtDestination:");

	private static readonly IntPtr selEnumerateDraggingItemsWithOptionsForViewClassesSearchOptionsUsingBlock_Handle = Selector.GetHandle("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDragDestination");

	private object __mt_DraggingDestinationWindow_var;

	private object __mt_DraggedImage_var;

	private object __mt_DraggingPasteboard_var;

	private object __mt_DraggingSource_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSWindow DraggingDestinationWindow
	{
		[Export("draggingDestinationWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow)(__mt_DraggingDestinationWindow_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingDestinationWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingDestinationWindowHandle)))));
		}
	}

	public virtual NSDragOperation DraggingSourceOperationMask
	{
		[Export("draggingSourceOperationMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSDragOperation)Messaging.UInt64_objc_msgSend(base.Handle, selDraggingSourceOperationMaskHandle);
			}
			return (NSDragOperation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDraggingSourceOperationMaskHandle);
		}
	}

	public virtual CGPoint DraggingLocation
	{
		[Export("draggingLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selDraggingLocationHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selDraggingLocationHandle);
		}
	}

	public virtual CGPoint DraggedImageLocation
	{
		[Export("draggedImageLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selDraggedImageLocationHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selDraggedImageLocationHandle);
		}
	}

	public virtual NSImage DraggedImage
	{
		[Export("draggedImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_DraggedImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggedImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggedImageHandle)))));
		}
	}

	public virtual NSPasteboard DraggingPasteboard
	{
		[Export("draggingPasteboard")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPasteboard)(__mt_DraggingPasteboard_var = ((!IsDirectBinding) ? ((NSPasteboard)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingPasteboardHandle))) : ((NSPasteboard)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingPasteboardHandle)))));
		}
	}

	public virtual NSObject DraggingSource
	{
		[Export("draggingSource")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_DraggingSource_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingSourceHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingSourceHandle))));
		}
	}

	public virtual long DraggingSequenceNumber
	{
		[Export("draggingSequenceNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selDraggingSequenceNumberHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingSequenceNumberHandle);
		}
	}

	public virtual bool AnimatesToDestination
	{
		[Export("animatesToDestination")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAnimatesToDestinationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAnimatesToDestinationHandle);
		}
		[Export("setAnimatesToDestination:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAnimatesToDestination_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAnimatesToDestination_Handle, value);
			}
		}
	}

	public virtual long NumberOfValidItemsForDrop
	{
		[Export("numberOfValidItemsForDrop")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfValidItemsForDropHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfValidItemsForDropHandle);
		}
		[Export("setNumberOfValidItemsForDrop:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetNumberOfValidItemsForDrop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetNumberOfValidItemsForDrop_Handle, value);
			}
		}
	}

	public virtual NSDraggingFormation DraggingFormation
	{
		[Export("draggingFormation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSDraggingFormation)Messaging.Int64_objc_msgSend(base.Handle, selDraggingFormationHandle);
			}
			return (NSDraggingFormation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingFormationHandle);
		}
		[Export("setDraggingFormation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDraggingFormation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDraggingFormation_Handle, (long)value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDraggingInfo()
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
	public NSDraggingInfo(NSCoder coder)
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
	public NSDraggingInfo(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDraggingInfo(IntPtr handle)
		: base(handle)
	{
	}

	[Export("slideDraggedImageTo:")]
	public virtual void SlideDraggedImageTo(CGPoint screenPoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selSlideDraggedImageTo_Handle, screenPoint);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSlideDraggedImageTo_Handle, screenPoint);
		}
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	public virtual string[] PromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		NSApplication.EnsureUIThread();
		if (dropDestination == null)
		{
			throw new ArgumentNullException("dropDestination");
		}
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamesOfPromisedFilesDroppedAtDestination_Handle, dropDestination.Handle));
	}

	[Export("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:")]
	public unsafe virtual void EnumerateDraggingItems(NSDraggingItemEnumerationOptions enumOpts, NSView view, NSPasteboardReading[] classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (classArray == null)
		{
			throw new ArgumentNullException("classArray");
		}
		if (searchOptions == null)
		{
			throw new ArgumentNullException("searchOptions");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		NSArray nSArray = NSArray.FromNSObjects(classArray);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSDraggingEnumerator.Handler, enumerator);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEnumerateDraggingItemsWithOptionsForViewClassesSearchOptionsUsingBlock_Handle, (ulong)enumOpts, view.Handle, nSArray.Handle, searchOptions.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEnumerateDraggingItemsWithOptionsForViewClassesSearchOptionsUsingBlock_Handle, (ulong)enumOpts, view.Handle, nSArray.Handle, searchOptions.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DraggingDestinationWindow_var = null;
			__mt_DraggedImage_var = null;
			__mt_DraggingPasteboard_var = null;
			__mt_DraggingSource_var = null;
		}
	}
}
