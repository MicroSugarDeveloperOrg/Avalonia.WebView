using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WebUIDelegateWrapper : BaseWrapper, IWebUIDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public WebUIDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
