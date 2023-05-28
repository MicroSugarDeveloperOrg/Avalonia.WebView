using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSTokenFieldDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetCompletionStrings(this INSTokenFieldDelegate This, NSTokenField tokenField, string substring, nint tokenIndex, nint selectedIndex)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (substring == null)
		{
			throw new ArgumentNullException("substring");
		}
		IntPtr intPtr = NSString.CreateNative(substring);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint_nint(This.Handle, Selector.GetHandle("tokenField:completionsForSubstring:indexOfToken:indexOfSelectedItem:"), tokenField.Handle, intPtr, tokenIndex, selectedIndex));
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSArray ShouldAddObjects(this INSTokenFieldDelegate This, NSTokenField tokenField, NSArray tokens, nuint index)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (tokens == null)
		{
			throw new ArgumentNullException("tokens");
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("tokenField:shouldAddObjects:atIndex:"), tokenField.Handle, tokens.Handle, index));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetDisplayString(this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenField:displayStringForRepresentedObject:"), tokenField.Handle, representedObject.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetEditingString(this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenField:editingStringForRepresentedObject:"), tokenField.Handle, representedObject.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetRepresentedObject(this INSTokenFieldDelegate This, NSTokenField tokenField, string editingString)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (editingString == null)
		{
			throw new ArgumentNullException("editingString");
		}
		IntPtr intPtr = NSString.CreateNative(editingString);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenField:representedObjectForEditingString:"), tokenField.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteRepresented(this INSTokenFieldDelegate This, NSTokenField tokenField, NSArray objects, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenField:writeRepresentedObjects:toPasteboard:"), tokenField.Handle, objects.Handle, pboard.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] Read(this INSTokenFieldDelegate This, NSTokenField tokenField, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenField:readFromPasteboard:"), tokenField.Handle, pboard.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMenu GetMenu(this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenField:menuForRepresentedObject:"), tokenField.Handle, representedObject.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool HasMenu(this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenField:hasMenuForRepresentedObject:"), tokenField.Handle, representedObject.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTokenStyle GetStyle(this INSTokenFieldDelegate This, NSTokenField tokenField, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenField == null)
		{
			throw new ArgumentNullException("tokenField");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return (NSTokenStyle)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenField:styleForRepresentedObject:"), tokenField.Handle, representedObject.Handle);
	}
}
