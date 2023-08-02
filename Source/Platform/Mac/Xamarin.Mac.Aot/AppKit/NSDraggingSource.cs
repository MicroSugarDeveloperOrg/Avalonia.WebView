using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDraggingSource", true)]
[Model]
public class NSDraggingSource : NSObject
{
	public virtual bool IgnoreModifierKeysWhileDragging
	{
		[Export("ignoreModifierKeysWhileDragging")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDraggingSource()
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
	public NSDraggingSource(NSCoder coder)
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
	public NSDraggingSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDraggingSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("draggingSourceOperationMaskForLocal:")]
	public virtual NSDragOperation DraggingSourceOperationMaskForLocal(bool flag)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggedImage:beganAt:")]
	public virtual void DraggedImageBeganAt(NSImage image, CGPoint screenPoint)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggedImage:endedAt:operation:")]
	public virtual void DraggedImageEndedAtOperation(NSImage image, CGPoint screenPoint, NSDragOperation operation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggedImage:movedTo:")]
	public virtual void DraggedImageMovedTo(NSImage image, CGPoint screenPoint)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggedImage:endedAt:deposited:")]
	[Obsolete("On 10.1 and newer, use DraggedImageEndedAtOperation() instead", false)]
	public virtual void DraggedImageEndedAtDeposited(NSImage image, CGPoint screenPoint, bool deposited)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
