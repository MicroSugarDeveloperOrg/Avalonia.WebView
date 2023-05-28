using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTextFieldDelegateWrapper : BaseWrapper, INSTextFieldDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTextFieldDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
