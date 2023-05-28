using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSMenuDelegate", false)]
[Model]
public abstract class NSMenuDelegate : NSObject, INSMenuDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSMenuDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSMenuDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMenuDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("confinementRectForMenu:onScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConfinementRectForMenu(NSMenu menu, NSScreen screen)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menuHasKeyEquivalent:forEvent:target:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasKeyEquivalentForEvent(NSMenu menu, NSEvent theEvent, NSObject target, Selector action)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menuDidClose:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MenuDidClose(NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfItemsInMenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MenuItemCount(NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menu:willHighlightItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void MenuWillHighlightItem(NSMenu menu, NSMenuItem item);

	[Export("menuWillOpen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MenuWillOpen(NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menuNeedsUpdate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NeedsUpdate(NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menu:updateItem:atIndex:shouldCancel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UpdateItem(NSMenu menu, NSMenuItem item, nint atIndex, bool shouldCancel)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
