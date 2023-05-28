using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSplitViewDelegateWrapper : BaseWrapper, INSSplitViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSSplitViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
