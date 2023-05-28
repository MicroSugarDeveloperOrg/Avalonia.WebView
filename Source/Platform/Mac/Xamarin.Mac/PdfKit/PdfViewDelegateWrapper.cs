using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

internal sealed class PdfViewDelegateWrapper : BaseWrapper, IPdfViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public PdfViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
