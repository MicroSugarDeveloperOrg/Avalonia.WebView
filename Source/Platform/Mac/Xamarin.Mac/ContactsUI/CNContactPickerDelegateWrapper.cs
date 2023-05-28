using System;
using Foundation;
using ObjCRuntime;

namespace ContactsUI;

internal sealed class CNContactPickerDelegateWrapper : BaseWrapper, ICNContactPickerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CNContactPickerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
