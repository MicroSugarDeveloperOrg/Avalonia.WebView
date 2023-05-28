using System;
using Foundation;
using ObjCRuntime;

namespace QTKit;

internal sealed class QTCaptureViewDelegateWrapper : BaseWrapper, IQTCaptureViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public QTCaptureViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
