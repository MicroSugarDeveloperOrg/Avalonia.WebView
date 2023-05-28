using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WebDownloadDelegateWrapper : BaseWrapper, IWebDownloadDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public WebDownloadDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
