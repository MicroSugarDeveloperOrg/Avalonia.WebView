using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSComboBoxDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject ObjectValueForItem(this INSComboBoxDataSource This, NSComboBox comboBox, nint index)
	{
		NSApplication.EnsureUIThread();
		if (comboBox == null)
		{
			throw new ArgumentNullException("comboBox");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("comboBox:objectValueForItemAtIndex:"), comboBox.Handle, index));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint ItemCount(this INSComboBoxDataSource This, NSComboBox comboBox)
	{
		NSApplication.EnsureUIThread();
		if (comboBox == null)
		{
			throw new ArgumentNullException("comboBox");
		}
		return Messaging.nint_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("numberOfItemsInComboBox:"), comboBox.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string CompletedString(this INSComboBoxDataSource This, NSComboBox comboBox, string uncompletedString)
	{
		NSApplication.EnsureUIThread();
		if (comboBox == null)
		{
			throw new ArgumentNullException("comboBox");
		}
		if (uncompletedString == null)
		{
			throw new ArgumentNullException("uncompletedString");
		}
		IntPtr intPtr = NSString.CreateNative(uncompletedString);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("comboBox:completedString:"), comboBox.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint IndexOfItem(this INSComboBoxDataSource This, NSComboBox comboBox, string value)
	{
		NSApplication.EnsureUIThread();
		if (comboBox == null)
		{
			throw new ArgumentNullException("comboBox");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr intPtr = NSString.CreateNative(value);
		nint result = Messaging.nint_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("comboBox:indexOfItemWithStringValue:"), comboBox.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}
}
