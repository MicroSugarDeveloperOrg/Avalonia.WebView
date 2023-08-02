using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPopoverDelegate", true)]
[Model]
public class NSPopoverDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPopoverDelegate()
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
	public NSPopoverDelegate(NSCoder coder)
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
	public NSPopoverDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPopoverDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("popoverShouldClose:")]
	public virtual bool ShouldClose(NSPopover popover)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("detachableWindowForPopover:")]
	public virtual NSWindow GetDetachableWindowForPopover(NSPopover popover)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("popoverWillShow:")]
	public virtual void WillShow(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("popoverDidShow:")]
	public virtual void DidShow(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("popoverWillClose:")]
	public virtual void WillClose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("popoverDidClose:")]
	public virtual void DidClose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
