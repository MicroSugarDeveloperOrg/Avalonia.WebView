using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSOutlineViewDataSourceWrapper : BaseWrapper, INSOutlineViewDataSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSOutlineViewDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
