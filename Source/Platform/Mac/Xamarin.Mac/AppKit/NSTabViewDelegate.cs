using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTabViewDelegate", true)]
[Model]
public class NSTabViewDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTabViewDelegate()
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
	public NSTabViewDelegate(NSCoder coder)
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
	public NSTabViewDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTabViewDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("tabView:shouldSelectTabViewItem:")]
	public virtual bool ShouldSelectTabViewItem(NSTabView tabView, NSTabViewItem item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tabView:willSelectTabViewItem:")]
	public virtual void WillSelect(NSTabView tabView, NSTabViewItem item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tabView:didSelectTabViewItem:")]
	public virtual void DidSelect(NSTabView tabView, NSTabViewItem item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("tabViewDidChangeNumberOfTabViewItems:")]
	public virtual void NumberOfItemsChanged(NSTabView tabView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
