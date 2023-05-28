using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNAvoidOccluderConstraintDelegateWrapper : BaseWrapper, ISCNAvoidOccluderConstraintDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNAvoidOccluderConstraintDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
