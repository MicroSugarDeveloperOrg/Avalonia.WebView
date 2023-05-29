using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextFieldDelegate", true)]
[Model]
public class NSTextFieldDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextFieldDelegate()
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
	public NSTextFieldDelegate(NSCoder coder)
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
	public NSTextFieldDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextFieldDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("control:textShouldBeginEditing:")]
	public virtual bool TextShouldBeginEditing(NSControl control, NSText fieldEditor)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:textShouldEndEditing:")]
	public virtual bool TextShouldEndEditing(NSControl control, NSText fieldEditor)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:didFailToFormatString:errorDescription:")]
	public virtual bool DidFailToFormatString(NSControl control, string str, string error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:didFailToValidatePartialString:errorDescription:")]
	public virtual void DidFailToValidatePartialString(NSControl control, string str, string error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:isValidObject:")]
	public virtual bool IsValidObject(NSControl control, NSObject objectToValidate)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:textView:doCommandBySelector:")]
	public virtual bool DoCommandBySelector(NSControl control, NSTextView textView, Selector commandSelector)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:textView:completions:forPartialWordRange:indexOfSelectedItem:")]
	public virtual string[] GetCompletions(NSControl control, NSTextView textView, string[] words, NSRange charRange, long index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("controlTextDidEndEditing:")]
	public virtual void EditingEnded(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("controlTextDidChange:")]
	public virtual void Changed(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("controlTextDidBeginEditing:")]
	public virtual void EditingBegan(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
