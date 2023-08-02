using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextDelegate", true)]
[Model]
public class NSTextDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextDelegate()
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
	public NSTextDelegate(NSCoder coder)
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
	public NSTextDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("textShouldBeginEditing:")]
	public virtual bool TextShouldBeginEditing(NSText textObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textShouldEndEditing:")]
	public virtual bool TextShouldEndEditing(NSText textObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textDidBeginEditing:")]
	public virtual void TextDidBeginEditing(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textDidEndEditing:")]
	public virtual void TextDidEndEditing(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textDidChange:")]
	public virtual void TextDidChange(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
