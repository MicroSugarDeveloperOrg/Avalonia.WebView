using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNCameraControllerDelegateWrapper : BaseWrapper, ISCNCameraControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNCameraControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
