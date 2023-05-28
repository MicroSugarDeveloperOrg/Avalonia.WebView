using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTouchBarDelegateWrapper : BaseWrapper, INSTouchBarDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTouchBarDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
