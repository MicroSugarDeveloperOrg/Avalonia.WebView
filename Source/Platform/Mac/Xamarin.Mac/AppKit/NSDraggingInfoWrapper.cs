using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSDraggingInfoWrapper : BaseWrapper, INSDraggingInfo, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSDraggingInfoWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
