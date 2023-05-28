using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTextViewDelegateWrapper : BaseWrapper, INSTextViewDelegate, INativeObject, IDisposable, INSTextDelegate
{
	[Preserve(Conditional = true)]
	public NSTextViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
