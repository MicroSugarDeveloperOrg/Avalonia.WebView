using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSOpenSavePanelDelegateWrapper : BaseWrapper, INSOpenSavePanelDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSOpenSavePanelDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
