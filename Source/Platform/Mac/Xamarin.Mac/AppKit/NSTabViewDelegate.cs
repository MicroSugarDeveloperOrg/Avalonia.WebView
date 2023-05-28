using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSTabViewDelegate", false)]
[Model]
public class NSTabViewDelegate : NSObject, INSTabViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTabViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTabViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTabViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("tabView:didSelectTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSelect(NSTabView tabView, NSTabViewItem item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tabViewDidChangeNumberOfTabViewItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NumberOfItemsChanged(NSTabView tabView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tabView:shouldSelectTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSelectTabViewItem(NSTabView tabView, NSTabViewItem item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tabView:willSelectTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillSelect(NSTabView tabView, NSTabViewItem item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
