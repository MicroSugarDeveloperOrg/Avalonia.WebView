using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDraggingDestination", true)]
[Model]
public class NSDraggingDestination : NSObject
{
	public virtual bool WantsPeriodicDraggingUpdates
	{
		[Export("wantsPeriodicDraggingUpdates")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDraggingDestination()
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
	public NSDraggingDestination(NSCoder coder)
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
	public NSDraggingDestination(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDraggingDestination(IntPtr handle)
		: base(handle)
	{
	}

	[Export("draggingEntered:")]
	public virtual NSDragOperation DraggingEntered(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggingUpdated:")]
	public virtual NSDragOperation DraggingUpdated(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggingExited:")]
	public virtual void DraggingExited(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("prepareForDragOperation:")]
	public virtual bool PrepareForDragOperation(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("performDragOperation:")]
	public virtual bool PerformDragOperation(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("concludeDragOperation:")]
	public virtual void ConcludeDragOperation(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggingEnded:")]
	public virtual void DraggingEnded(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
