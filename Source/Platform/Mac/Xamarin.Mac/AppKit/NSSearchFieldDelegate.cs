using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSSearchFieldDelegate", false)]
[Model]
public class NSSearchFieldDelegate : NSObject, INSSearchFieldDelegate, INativeObject, IDisposable, INSTextFieldDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSearchFieldDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSearchFieldDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSearchFieldDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("controlTextDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Changed(NSNotification notification)
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

	[Export("controlTextDidBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EditingBegan(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("controlTextDidEndEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EditingEnded(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textField:textView:candidatesForSelectedRange:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[]? GetCandidates(NSTextField textField, NSTextView textView, NSRange selectedRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:textView:completions:forPartialWordRange:indexOfSelectedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetCompletions(NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textField:textView:candidates:forSelectedRange:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingResult[] GetTextCheckingResults(NSTextField textField, NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("control:isValidObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValidObject(NSControl control, NSObject objectToValidate)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("searchFieldDidEndSearching:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SearchingEnded(NSSearchField sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("searchFieldDidStartSearching:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SearchingStarted(NSSearchField sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textField:textView:shouldSelectCandidateAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSelectCandidate(NSTextField textField, NSTextView textView, nuint index)
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
