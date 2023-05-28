using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSharingServicePickerDelegateWrapper : BaseWrapper, INSSharingServicePickerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSSharingServicePickerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
