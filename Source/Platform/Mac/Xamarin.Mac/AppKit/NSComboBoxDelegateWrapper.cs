using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSComboBoxDelegateWrapper : BaseWrapper, INSComboBoxDelegate, INativeObject, IDisposable, INSTextFieldDelegate
{
	[Preserve(Conditional = true)]
	public NSComboBoxDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
