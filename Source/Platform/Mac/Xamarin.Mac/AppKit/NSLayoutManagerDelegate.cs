using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLayoutManagerDelegate", true)]
[Model]
public class NSLayoutManagerDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLayoutManagerDelegate()
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
	public NSLayoutManagerDelegate(NSCoder coder)
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
	public NSLayoutManagerDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSLayoutManagerDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layoutManagerDidInvalidateLayout:")]
	public virtual void LayoutInvalidated(NSLayoutManager sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:didCompleteLayoutForTextContainer:atEnd:")]
	public virtual void LayoutCompleted(NSLayoutManager layoutManager, NSTextContainer textContainer, bool layoutFinishedFlag)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutManager:shouldUseTemporaryAttributes:forDrawingToScreen:atCharacterIndex:effectiveRange:")]
	public virtual NSDictionary ShouldUseTemporaryAttributes(NSLayoutManager layoutManager, NSDictionary temporaryAttributes, bool drawingToScreen, long charIndex, IntPtr effectiveCharRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
