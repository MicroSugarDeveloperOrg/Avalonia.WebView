using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSeguePerformingWrapper : BaseWrapper, INSSeguePerforming, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSSeguePerformingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
