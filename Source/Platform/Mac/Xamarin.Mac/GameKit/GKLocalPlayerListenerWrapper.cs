using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKLocalPlayerListenerWrapper : BaseWrapper, IGKLocalPlayerListener, INativeObject, IDisposable, IGKChallengeListener, IGKInviteEventListener, IGKSavedGameListener, IGKTurnBasedEventListener
{
	[Preserve(Conditional = true)]
	public GKLocalPlayerListenerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
