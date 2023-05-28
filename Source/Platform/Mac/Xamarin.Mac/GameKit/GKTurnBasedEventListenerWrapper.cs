using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKTurnBasedEventListenerWrapper : BaseWrapper, IGKTurnBasedEventListener, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKTurnBasedEventListenerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
