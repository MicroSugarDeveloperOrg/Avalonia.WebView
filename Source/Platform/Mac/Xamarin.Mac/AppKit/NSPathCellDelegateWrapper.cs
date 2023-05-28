using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSPathCellDelegateWrapper : BaseWrapper, INSPathCellDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPathCellDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
