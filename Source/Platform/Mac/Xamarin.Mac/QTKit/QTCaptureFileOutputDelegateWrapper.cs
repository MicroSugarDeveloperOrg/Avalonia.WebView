using System;
using Foundation;
using ObjCRuntime;

namespace QTKit;

internal sealed class QTCaptureFileOutputDelegateWrapper : BaseWrapper, IQTCaptureFileOutputDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public QTCaptureFileOutputDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
