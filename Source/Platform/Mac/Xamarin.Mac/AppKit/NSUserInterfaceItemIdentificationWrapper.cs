using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSUserInterfaceItemIdentificationWrapper : BaseWrapper, INSUserInterfaceItemIdentification, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSUserInterfaceItemIdentificationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
