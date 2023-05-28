using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

internal sealed class IKImageBrowserDelegateWrapper : BaseWrapper, IIKImageBrowserDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public IKImageBrowserDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
