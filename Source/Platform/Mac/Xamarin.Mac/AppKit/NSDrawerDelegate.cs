using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDrawerDelegate", true)]
[Model]
public class NSDrawerDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDrawerDelegate()
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
	public NSDrawerDelegate(NSCoder coder)
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
	public NSDrawerDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDrawerDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("drawerDidClose:")]
	public virtual void DrawerDidClose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("drawerDidOpen:")]
	public virtual void DrawerDidOpen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("drawerShouldClose:")]
	public virtual bool DrawerShouldClose(NSDrawer sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("drawerShouldOpen:")]
	public virtual bool DrawerShouldOpen(NSDrawer sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("drawerWillClose:")]
	public virtual void DrawerWillClose(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("drawerWillOpen:")]
	public virtual void DrawerWillOpen(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("drawerWillResizeContents:toSize:")]
	public virtual CGSize DrawerWillResizeContents(NSDrawer sender, CGSize toSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
