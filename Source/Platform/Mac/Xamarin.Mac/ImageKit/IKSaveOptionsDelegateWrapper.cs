using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

internal sealed class IKSaveOptionsDelegateWrapper : BaseWrapper, IIKSaveOptionsDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public IKSaveOptionsDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
