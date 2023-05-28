using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSDraggingSource", false)]
[Model]
public class NSDraggingSource : NSObject, INSDraggingSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IgnoreModifierKeysWhileDragging
	{
		[Export("ignoreModifierKeysWhileDragging")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDraggingSource()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSDraggingSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDraggingSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("draggedImage:beganAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageBeganAt(NSImage image, CGPoint screenPoint)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggedImage:endedAt:deposited:")]
	[Deprecated(PlatformName.MacOSX, 10, 1, PlatformArchitecture.All, "Use DraggedImageEndedAtOperation instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageEndedAtDeposited(NSImage image, CGPoint screenPoint, bool deposited)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggedImage:endedAt:operation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageEndedAtOperation(NSImage image, CGPoint screenPoint, NSDragOperation operation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggedImage:movedTo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedImageMovedTo(NSImage image, CGPoint screenPoint)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("draggingSourceOperationMaskForLocal:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation DraggingSourceOperationMaskForLocal(bool flag)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("namesOfPromisedFilesDroppedAtDestination:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use NSFilePromiseProvider objects instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] NamesOfPromisedFilesDroppedAtDestination(NSUrl dropDestination)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
