using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKChallengeListenerWrapper : BaseWrapper, IGKChallengeListener, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKChallengeListenerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
