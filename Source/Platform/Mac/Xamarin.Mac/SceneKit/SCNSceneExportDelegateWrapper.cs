using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNSceneExportDelegateWrapper : BaseWrapper, ISCNSceneExportDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNSceneExportDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
