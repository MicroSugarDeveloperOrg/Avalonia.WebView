using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSMatrixDelegateWrapper : BaseWrapper, INSMatrixDelegate, INativeObject, IDisposable, INSControlTextEditingDelegate
{
	[Preserve(Conditional = true)]
	public NSMatrixDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
