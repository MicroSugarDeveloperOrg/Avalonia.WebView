using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSDatePickerCellDelegateWrapper : BaseWrapper, INSDatePickerCellDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSDatePickerCellDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
