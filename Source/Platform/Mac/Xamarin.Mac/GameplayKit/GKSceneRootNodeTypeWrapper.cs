using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

internal sealed class GKSceneRootNodeTypeWrapper : BaseWrapper, IGKSceneRootNodeType, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKSceneRootNodeTypeWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
