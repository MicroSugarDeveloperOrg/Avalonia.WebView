using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlDownloadDelegateWrapper : BaseWrapper, INSUrlDownloadDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSUrlDownloadDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
