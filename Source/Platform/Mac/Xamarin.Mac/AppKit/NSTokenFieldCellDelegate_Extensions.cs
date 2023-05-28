using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSTokenFieldCellDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSArray GetCompletionStrings(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, string substring, nint tokenIndex, ref nint selectedIndex)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (substring == null)
		{
			throw new ArgumentNullException("substring");
		}
		IntPtr intPtr = NSString.CreateNative(substring);
		NSArray nSObject = Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint_ref_nint(This.Handle, Selector.GetHandle("tokenFieldCell:completionsForSubstring:indexOfToken:indexOfSelectedItem:"), tokenFieldCell.Handle, intPtr, tokenIndex, ref selectedIndex));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSArray ShouldAddObjects(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject[] tokens, nuint index)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (tokens == null)
		{
			throw new ArgumentNullException("tokens");
		}
		NSArray nSArray = NSArray.FromNSObjects(tokens);
		NSArray nSObject = Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("tokenFieldCell:shouldAddObjects:atIndex:"), tokenFieldCell.Handle, nSArray.Handle, index));
		nSArray.Dispose();
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetDisplayString(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenFieldCell:displayStringForRepresentedObject:"), tokenFieldCell.Handle, representedObject.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetEditingString(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenFieldCell:editingStringForRepresentedObject:"), tokenFieldCell.Handle, representedObject.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetRepresentedObject(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, string editingString)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (editingString == null)
		{
			throw new ArgumentNullException("editingString");
		}
		IntPtr intPtr = NSString.CreateNative(editingString);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenFieldCell:representedObjectForEditingString:"), tokenFieldCell.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteRepresentedObjects(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject[] objects, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenFieldCell:writeRepresentedObjects:toPasteboard:"), tokenFieldCell.Handle, nSArray.Handle, pboard.Handle);
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] Read(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenFieldCell:readFromPasteboard:"), tokenFieldCell.Handle, pboard.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMenu GetMenu(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenFieldCell:menuForRepresentedObject:"), tokenFieldCell.Handle, representedObject.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool HasMenu(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenFieldCell:hasMenuForRepresentedObject:"), tokenFieldCell.Handle, representedObject.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTokenStyle GetStyle(this INSTokenFieldCellDelegate This, NSTokenFieldCell tokenFieldCell, NSObject representedObject)
	{
		NSApplication.EnsureUIThread();
		if (tokenFieldCell == null)
		{
			throw new ArgumentNullException("tokenFieldCell");
		}
		if (representedObject == null)
		{
			throw new ArgumentNullException("representedObject");
		}
		return (NSTokenStyle)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("tokenFieldCell:styleForRepresentedObject:"), tokenFieldCell.Handle, representedObject.Handle);
	}
}
