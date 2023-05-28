using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNSceneRendererDelegateWrapper : BaseWrapper, ISCNSceneRendererDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNSceneRendererDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
