using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

internal sealed class CALayerDelegateWrapper : BaseWrapper, ICALayerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CALayerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
