using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSComboBoxCellDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject ObjectValueForItem(this INSComboBoxCellDataSource This, NSComboBoxCell comboBox, nint index)
	{
		NSApplication.EnsureUIThread();
		if (comboBox == null)
		{
			throw new ArgumentNullException("comboBox");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("comboBoxCell:objectValueForItemAtIndex:"), comboBox.Handle, index));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint ItemCount(this INSComboBoxCellDataSource This, NSComboBoxCell comboBox)
	{
		NSApplication.EnsureUIThread();
		if (comboBox == null)
		{
			throw new ArgumentNullException("comboBox");
		}
		return Messaging.nint_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("numberOfItemsInComboBoxCell:"), comboBox.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string CompletedString(this INSComboBoxCellDataSource This, NSComboBoxCell comboBox, string uncompletedString)
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
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("comboBoxCell:completedString:"), comboBox.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint IndexOfItem(this INSComboBoxCellDataSource This, NSComboBoxCell comboBox, string value)
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
		nuint result = Messaging.nuint_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("comboBoxCell:indexOfItemWithStringValue:"), comboBox.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}
}
