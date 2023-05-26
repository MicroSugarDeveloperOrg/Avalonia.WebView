using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSharingServiceDelegate", true)]
[Model]
[MountainLion]
public class NSSharingServiceDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSharingServiceDelegate()
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
	public NSSharingServiceDelegate(NSCoder coder)
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
	public NSSharingServiceDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSharingServiceDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("sharingService:willShareItems:")]
	public virtual void WillShareItems(NSSharingService sharingService, NSObject[] items)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:didFailToShareItems:error:")]
	public virtual void DidFailToShareItems(NSSharingService sharingService, NSObject[] items, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:didShareItems:")]
	public virtual void DidShareItems(NSSharingService sharingService, NSObject[] items)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:sourceFrameOnScreenForShareItem:")]
	public virtual CGRect SourceFrameOnScreenForShareItem(NSSharingService sharingService, NSPasteboardWriting item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:transitionImageForShareItem:contentRect:")]
	public virtual NSImage TransitionImageForShareItem(NSSharingService sharingService, NSPasteboardWriting item, CGRect contentRect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:sourceWindowForShareItems:sharingContentScope:")]
	public virtual NSWindow SourceWindowForShareItems(NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
