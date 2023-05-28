using System;
using Foundation;
using ObjCRuntime;

namespace QTKit;

internal sealed class QTCaptureDecompressedVideoOutputDelegateWrapper : BaseWrapper, IQTCaptureDecompressedVideoOutputDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public QTCaptureDecompressedVideoOutputDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
