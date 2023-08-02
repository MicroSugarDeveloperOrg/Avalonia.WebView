using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSImageDelegate", true)]
[Model]
public class NSImageDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSImageDelegate()
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
	public NSImageDelegate(NSCoder coder)
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
	public NSImageDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSImageDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("imageDidNotDraw:inRect:")]
	public virtual NSImage ImageDidNotDraw(NSObject sender, CGRect aRect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("image:willLoadRepresentation:")]
	public virtual void WillLoadRepresentation(NSImage image, NSImageRep rep)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("image:didLoadRepresentationHeader:")]
	public virtual void DidLoadRepresentationHeader(NSImage image, NSImageRep rep)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("image:didLoadPartOfRepresentation:withValidRows:")]
	public virtual void DidLoadPartOfRepresentation(NSImage image, NSImageRep rep, long rows)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("image:didLoadRepresentation:withStatus:")]
	public virtual void DidLoadRepresentation(NSImage image, NSImageRep rep, NSImageLoadStatus status)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
