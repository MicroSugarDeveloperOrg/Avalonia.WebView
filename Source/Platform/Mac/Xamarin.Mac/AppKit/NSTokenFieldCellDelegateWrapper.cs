using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTokenFieldCellDelegateWrapper : BaseWrapper, INSTokenFieldCellDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTokenFieldCellDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
