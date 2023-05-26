using System;
using Foundation;

namespace AppKit;

public class NSDatePickerValidatorEventArgs : EventArgs
{
	public NSDate ProposedDateValue { get; set; }

	public double ProposedTimeInterval { get; set; }

	public NSDatePickerValidatorEventArgs(NSDate proposedDateValue, double proposedTimeInterval)
	{
		ProposedDateValue = proposedDateValue;
		ProposedTimeInterval = proposedTimeInterval;
	}
}
