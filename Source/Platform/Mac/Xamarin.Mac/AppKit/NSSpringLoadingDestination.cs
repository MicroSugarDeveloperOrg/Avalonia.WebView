using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSSpringLoadingDestination", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public abstract class NSSpringLoadingDestination : NSObject, INSSpringLoadingDestination, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSSpringLoadingDestination()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSpringLoadingDestination(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSpringLoadingDestination(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("springLoadingActivated:draggingInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void Activated(bool activated, NSDraggingInfo draggingInfo);

	[Export("draggingEnded:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggingEnded(NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("springLoadingEntered:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSpringLoadingOptions Entered(NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("springLoadingExited:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Exited(NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("springLoadingHighlightChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void HighlightChanged(NSDraggingInfo draggingInfo);

	[Export("springLoadingUpdated:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSpringLoadingOptions Updated(NSDraggingInfo draggingInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
