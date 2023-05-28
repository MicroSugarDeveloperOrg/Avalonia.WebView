using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKChallengeEventHandlerDelegateWrapper : BaseWrapper, IGKChallengeEventHandlerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKChallengeEventHandlerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
