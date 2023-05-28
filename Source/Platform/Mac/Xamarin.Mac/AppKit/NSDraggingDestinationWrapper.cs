using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSDraggingDestinationWrapper : BaseWrapper, INSDraggingDestination, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSDraggingDestinationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
