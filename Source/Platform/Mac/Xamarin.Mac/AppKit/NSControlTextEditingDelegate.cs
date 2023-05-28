using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSControlTextEditingDelegate", false)]
[Model]
public class NSControlTextEditingDelegate : NSObject, INSControlTextEditingDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSControlTextEditingDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSControlTextEditingDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSControlTextEditingDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("controlTextDidBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ControlTextDidBeginEditing(NSNotification obj)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("controlTextDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ControlTextDidChange(NSNotification obj)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("controlTextDidEndEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ControlTextDidEndEditing(NSNotification obj)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:didFailToFormatString:errorDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DidFailToFormatString(NSControl control, string str, string error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:didFailToValidatePartialString:errorDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFailToValidatePartialString(NSControl control, string str, string error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:textView:doCommandBySelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DoCommandBySelector(NSControl control, NSTextView textView, Selector commandSelector)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:textView:completions:forPartialWordRange:indexOfSelectedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetCompletions(NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:isValidObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValidObject(NSControl control, NSObject objectToValidate)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:textShouldBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TextShouldBeginEditing(NSControl control, NSText fieldEditor)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:textShouldEndEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TextShouldEndEditing(NSControl control, NSText fieldEditor)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
