using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

internal sealed class CAAnimationDelegateWrapper : BaseWrapper, ICAAnimationDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CAAnimationDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
