using System;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

internal sealed class QLPreviewItemWrapper : BaseWrapper, IQLPreviewItem, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public QLPreviewItemWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
