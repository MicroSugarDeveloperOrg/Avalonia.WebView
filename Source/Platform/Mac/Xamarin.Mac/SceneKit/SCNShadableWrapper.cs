using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNShadableWrapper : BaseWrapper, ISCNShadable, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNShadableWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
