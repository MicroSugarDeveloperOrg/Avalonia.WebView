using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKSessionDelegateWrapper : BaseWrapper, IGKSessionDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKSessionDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
