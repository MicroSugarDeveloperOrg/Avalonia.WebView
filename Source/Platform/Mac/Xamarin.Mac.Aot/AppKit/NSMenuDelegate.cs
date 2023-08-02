using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMenuDelegate", true)]
[Model]
public abstract class NSMenuDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMenuDelegate()
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
	public NSMenuDelegate(NSCoder coder)
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
	public NSMenuDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMenuDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("menuNeedsUpdate:")]
	public virtual void NeedsUpdate(NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfItemsInMenu:")]
	public virtual long MenuItemCount(NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menu:updateItem:atIndex:shouldCancel:")]
	public virtual bool UpdateItem(NSMenu menu, NSMenuItem item, long atIndex, bool shouldCancel)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menuHasKeyEquivalent:forEvent:target:action:")]
	public virtual bool HasKeyEquivalentForEvent(NSMenu menu, NSEvent theEvent, NSObject target, Selector action)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menuWillOpen:")]
	public virtual void MenuWillOpen(NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menuDidClose:")]
	public virtual void MenuDidClose(NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("menu:willHighlightItem:")]
	public abstract void MenuWillHighlightItem(NSMenu menu, NSMenuItem item);

	[Export("confinementRectForMenu:onScreen:")]
	public virtual CGRect ConfinementRectForMenu(NSMenu menu, NSScreen screen)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
