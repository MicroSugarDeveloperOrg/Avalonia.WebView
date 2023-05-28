using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSStackViewDelegateWrapper : BaseWrapper, INSStackViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSStackViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
