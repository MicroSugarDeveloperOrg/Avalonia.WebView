using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSControlTextEditingDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool TextShouldBeginEditing(this INSControlTextEditingDelegate This, NSControl control, NSText fieldEditor)
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
	public static bool TextShouldEndEditing(this INSControlTextEditingDelegate This, NSControl control, NSText fieldEditor)
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
	public static bool DidFailToFormatString(this INSControlTextEditingDelegate This, NSControl control, string str, string error)
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
	public static void DidFailToValidatePartialString(this INSControlTextEditingDelegate This, NSControl control, string str, string error)
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
	public static bool IsValidObject(this INSControlTextEditingDelegate This, NSControl control, NSObject objectToValidate)
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
	public static bool DoCommandBySelector(this INSControlTextEditingDelegate This, NSControl control, NSTextView textView, Selector commandSelector)
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
	public static string[] GetCompletions(this INSControlTextEditingDelegate This, NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index)
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
	public static void ControlTextDidBeginEditing(this INSControlTextEditingDelegate This, NSNotification obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("controlTextDidBeginEditing:"), obj.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ControlTextDidEndEditing(this INSControlTextEditingDelegate This, NSNotification obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("controlTextDidEndEditing:"), obj.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ControlTextDidChange(this INSControlTextEditingDelegate This, NSNotification obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("controlTextDidChange:"), obj.Handle);
	}
}
