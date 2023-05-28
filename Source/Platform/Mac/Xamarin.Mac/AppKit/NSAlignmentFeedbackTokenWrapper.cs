using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAlignmentFeedbackTokenWrapper : BaseWrapper, INSAlignmentFeedbackToken, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSAlignmentFeedbackTokenWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
