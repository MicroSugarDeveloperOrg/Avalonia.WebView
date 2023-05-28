using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVVideoCompositionValidationHandlingWrapper : BaseWrapper, IAVVideoCompositionValidationHandling, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVVideoCompositionValidationHandlingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
