using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSPopoverDelegate", false)]
[Model]
public class NSPopoverDelegate : NSObject, INSPopoverDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPopoverDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPopoverDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPopoverDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("popoverDidClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidClose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("popoverDidDetach:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDetach(NSPopover popover)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("popoverDidShow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidShow(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("detachableWindowForPopover:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow GetDetachableWindowForPopover(NSPopover popover)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("popoverShouldClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldClose(NSPopover popover)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("popoverWillClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillClose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("popoverWillShow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillShow(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
