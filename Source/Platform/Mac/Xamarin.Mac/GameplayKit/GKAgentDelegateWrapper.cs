using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

internal sealed class GKAgentDelegateWrapper : BaseWrapper, IGKAgentDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKAgentDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
