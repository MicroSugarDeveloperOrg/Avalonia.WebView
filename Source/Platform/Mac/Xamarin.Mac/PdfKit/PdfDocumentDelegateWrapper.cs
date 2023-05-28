using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

internal sealed class PdfDocumentDelegateWrapper : BaseWrapper, IPdfDocumentDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public PdfDocumentDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
