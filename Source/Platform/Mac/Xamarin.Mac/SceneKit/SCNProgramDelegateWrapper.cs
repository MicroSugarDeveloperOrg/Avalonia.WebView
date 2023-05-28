using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNProgramDelegateWrapper : BaseWrapper, ISCNProgramDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNProgramDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
