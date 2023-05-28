using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTokenFieldDelegateWrapper : BaseWrapper, INSTokenFieldDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTokenFieldDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
