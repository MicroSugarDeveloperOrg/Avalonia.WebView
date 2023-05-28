using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSDatePickerCellDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ValidateProposedDateValue(this INSDatePickerCellDelegate This, NSDatePickerCell aDatePickerCell, ref NSDate proposedDateValue, double proposedTimeInterval)
	{
		NSApplication.EnsureUIThread();
		if (aDatePickerCell == null)
		{
			throw new ArgumentNullException("aDatePickerCell");
		}
		IntPtr arg = ((proposedDateValue == null) ? IntPtr.Zero : proposedDateValue.Handle);
		Messaging.void_objc_msgSend_IntPtr_ref_IntPtr_Double(This.Handle, Selector.GetHandle("datePickerCell:validateProposedDateValue:timeInterval:"), aDatePickerCell.Handle, ref arg, proposedTimeInterval);
		proposedDateValue = Runtime.GetNSObject<NSDate>(arg);
	}
}
