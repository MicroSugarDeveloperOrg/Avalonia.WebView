using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSScrubberDelegateWrapper : BaseWrapper, INSScrubberDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSScrubberDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
