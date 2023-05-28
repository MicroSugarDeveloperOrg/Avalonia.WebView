using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSScrubberFlowLayoutDelegateWrapper : BaseWrapper, INSScrubberFlowLayoutDelegate, INativeObject, IDisposable, INSScrubberDelegate
{
	[Preserve(Conditional = true)]
	public NSScrubberFlowLayoutDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
