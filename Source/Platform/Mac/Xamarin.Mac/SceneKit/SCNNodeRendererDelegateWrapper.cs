using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNNodeRendererDelegateWrapper : BaseWrapper, ISCNNodeRendererDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNNodeRendererDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
