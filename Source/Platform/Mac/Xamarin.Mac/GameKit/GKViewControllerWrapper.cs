using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKViewControllerWrapper : BaseWrapper, IGKViewController, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKViewControllerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
