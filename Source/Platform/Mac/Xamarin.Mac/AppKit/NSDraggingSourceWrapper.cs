using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSDraggingSourceWrapper : BaseWrapper, INSDraggingSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSDraggingSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
