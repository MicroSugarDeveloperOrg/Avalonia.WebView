using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

internal sealed class GKSavedGameListenerWrapper : BaseWrapper, IGKSavedGameListener, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKSavedGameListenerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
