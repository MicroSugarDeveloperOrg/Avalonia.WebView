using System;
using System.ComponentModel;
using System.Diagnostics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSDraggingDestination", false)]
[Model]
public class NSDraggingDestination : NSObject, INSDraggingDestination, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual bool WantsPeriodicDraggingUpdates
	{
		[Export("wantsPeriodicDraggingUpdates")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDraggingDestination()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSDraggingDestination(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDraggingDestination(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("concludeDragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConcludeDragOperation(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggingEnded:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingEnded(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggingEntered:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingEntered(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggingExited:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingExited(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggingUpdated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingUpdated(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("performDragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PerformDragOperation(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("prepareForDragOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PrepareForDragOperation(NSDraggingInfo sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
