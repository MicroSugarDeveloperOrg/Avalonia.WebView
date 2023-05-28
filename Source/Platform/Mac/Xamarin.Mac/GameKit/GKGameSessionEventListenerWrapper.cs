using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKGameSessionEventListenerWrapper : BaseWrapper, IGKGameSessionEventListener, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKGameSessionEventListenerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
