using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTableViewDataSourceWrapper : BaseWrapper, INSTableViewDataSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTableViewDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
