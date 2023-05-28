using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSTextFieldDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool TextShouldBeginEditing(this INSTextFieldDelegate This, NSControl control, NSText fieldEditor)
	{
		NSApplication.EnsureUIThread();
		if (control == null)
		{
			throw new ArgumentNullException("control");
		}
		if (fieldEditor == null)
		{
			throw new ArgumentNullException("fieldEditor");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("control:textShouldBeginEditing:"), control.Handle, fieldEditor.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool TextShouldEndEditing(this INSTextFieldDelegate This, NSControl control, NSText fieldEditor)
	{
		NSApplication.EnsureUIThread();
		if (control == null)
		{
			throw new ArgumentNullException("control");
		}
		if (fieldEditor == null)
		{
			throw new ArgumentNullException("fieldEditor");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("control:textShouldEndEditing:"), control.Handle, fieldEditor.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool DidFailToFormatString(this INSTextFieldDelegate This, NSControl control, string str, string error)
	{
		NSApplication.EnsureUIThread();
		if (control == null)
		{
			throw new ArgumentNullException("control");
		}
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		IntPtr intPtr = NSString.CreateNative(str);
		IntPtr intPtr2 = NSString.CreateNative(error);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("control:didFailToFormatString:errorDescription:"), control.Handle, intPtr, intPtr2);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFailToValidatePartialString(this INSTextFieldDelegate This, NSControl control, string str, string error)
	{
		NSApplication.EnsureUIThread();
		if (control == null)
		{
			throw new ArgumentNullException("control");
		}
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		IntPtr intPtr = NSString.CreateNative(str);
		IntPtr intPtr2 = NSString.CreateNative(error);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("control:didFailToValidatePartialString:errorDescription:"), control.Handle, intPtr, intPtr2);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsValidObject(this INSTextFieldDelegate This, NSControl control, NSObject objectToValidate)
	{
		NSApplication.EnsureUIThread();
		if (control == null)
		{
			throw new ArgumentNullException("control");
		}
		if (objectToValidate == null)
		{
			throw new ArgumentNullException("objectToValidate");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("control:isValidObject:"), control.Handle, objectToValidate.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool DoCommandBySelector(this INSTextFieldDelegate This, NSControl control, NSTextView textView, Selector commandSelector)
	{
		NSApplication.EnsureUIThread();
		if (control == null)
		{
			throw new ArgumentNullException("control");
		}
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (commandSelector == null)
		{
			throw new ArgumentNullException("commandSelector");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("control:textView:doCommandBySelector:"), control.Handle, textView.Handle, commandSelector.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetCompletions(this INSTextFieldDelegate This, NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index)
	{
		NSApplication.EnsureUIThread();
		if (control == null)
		{
			throw new ArgumentNullException("control");
		}
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (words == null)
		{
			throw new ArgumentNullException("words");
		}
		NSArray nSArray = NSArray.FromStrings(words);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange_ref_nint(This.Handle, Selector.GetHandle("control:textView:completions:forPartialWordRange:indexOfSelectedItem:"), control.Handle, textView.Handle, nSArray.Handle, charRange, ref index));
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EditingEnded(this INSTextFieldDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("controlTextDidEndEditing:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Changed(this INSTextFieldDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("controlTextDidChange:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EditingBegan(this INSTextFieldDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("controlTextDidBeginEditing:"), notification.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[]? GetCandidates(this INSTextFieldDelegate This, NSTextField textField, NSTextView textView, NSRange selectedRange)
	{
		NSApplication.EnsureUIThread();
		if (textField == null)
		{
			throw new ArgumentNullException("textField");
		}
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_NSRange(This.Handle, Selector.GetHandle("textField:textView:candidatesForSelectedRange:"), textField.Handle, textView.Handle, selectedRange));
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult[] GetTextCheckingResults(this INSTextFieldDelegate This, NSTextField textField, NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
	{
		NSApplication.EnsureUIThread();
		if (textField == null)
		{
			throw new ArgumentNullException("textField");
		}
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (candidates == null)
		{
			throw new ArgumentNullException("candidates");
		}
		NSArray nSArray = NSArray.FromNSObjects(candidates);
		NSTextCheckingResult[] result = NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange(This.Handle, Selector.GetHandle("textField:textView:candidates:forSelectedRange:"), textField.Handle, textView.Handle, nSArray.Handle, selectedRange));
		nSArray.Dispose();
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldSelectCandidate(this INSTextFieldDelegate This, NSTextField textField, NSTextView textView, nuint index)
	{
		NSApplication.EnsureUIThread();
		if (textField == null)
		{
			throw new ArgumentNullException("textField");
		}
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("textField:textView:shouldSelectCandidateAtIndex:"), textField.Handle, textView.Handle, index);
	}
}
