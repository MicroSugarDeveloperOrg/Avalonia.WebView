using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNPhysicsContactDelegateWrapper : BaseWrapper, ISCNPhysicsContactDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNPhysicsContactDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
