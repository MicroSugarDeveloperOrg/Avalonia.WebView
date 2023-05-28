using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSDatePickerCellDelegate", WrapperType = typeof(NSDatePickerCellDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateProposedDateValue", Selector = "datePickerCell:validateProposedDateValue:timeInterval:", ParameterType = new Type[]
{
	typeof(NSDatePickerCell),
	typeof(NSDate),
	typeof(double)
}, ParameterByRef = new bool[] { false, true, false })]
public interface INSDatePickerCellDelegate : INativeObject, IDisposable
{
}
