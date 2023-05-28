using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKInviteEventListenerWrapper : BaseWrapper, IGKInviteEventListener, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKInviteEventListenerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
