using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSearchFieldDelegateWrapper : BaseWrapper, INSSearchFieldDelegate, INativeObject, IDisposable, INSTextFieldDelegate
{
	[Preserve(Conditional = true)]
	public NSSearchFieldDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
