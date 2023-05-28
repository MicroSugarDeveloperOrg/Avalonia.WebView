using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

internal sealed class GKGameModelPlayerWrapper : BaseWrapper, IGKGameModelPlayer, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKGameModelPlayerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
