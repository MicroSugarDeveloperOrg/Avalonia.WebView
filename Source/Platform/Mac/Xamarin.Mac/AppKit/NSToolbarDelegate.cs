using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSToolbarDelegate", false)]
[Model]
public class NSToolbarDelegate : NSObject, INSToolbarDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSToolbarDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSToolbarDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSToolbarDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("toolbarAllowedItemIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AllowedItemIdentifiers(NSToolbar toolbar)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("toolbarDefaultItemIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] DefaultItemIdentifiers(NSToolbar toolbar)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("toolbarDidRemoveItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRemoveItem(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("toolbarSelectableItemIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] SelectableItemIdentifiers(NSToolbar toolbar)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("toolbarWillAddItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillAddItem(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSToolbarItem WillInsertItem(NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
