using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTextDelegateWrapper : BaseWrapper, INSTextDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTextDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
