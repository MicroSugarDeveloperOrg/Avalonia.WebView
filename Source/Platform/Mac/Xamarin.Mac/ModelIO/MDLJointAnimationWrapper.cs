using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

internal sealed class MDLJointAnimationWrapper : BaseWrapper, IMDLJointAnimation, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MDLJointAnimationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
