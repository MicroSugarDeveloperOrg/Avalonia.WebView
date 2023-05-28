using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSStandardKeyBindingRespondingWrapper : BaseWrapper, INSStandardKeyBindingResponding, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSStandardKeyBindingRespondingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
