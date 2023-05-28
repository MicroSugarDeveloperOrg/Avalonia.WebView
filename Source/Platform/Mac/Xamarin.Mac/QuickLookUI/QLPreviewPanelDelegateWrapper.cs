using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

internal sealed class QLPreviewPanelDelegateWrapper : BaseWrapper, IQLPreviewPanelDelegate, INativeObject, IDisposable, INSWindowDelegate
{
	[Preserve(Conditional = true)]
	public QLPreviewPanelDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
