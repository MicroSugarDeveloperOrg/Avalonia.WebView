using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKMatchDelegateWrapper : BaseWrapper, IGKMatchDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKMatchDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
