using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNAnimationProtocolWrapper : BaseWrapper, ISCNAnimationProtocol, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNAnimationProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
