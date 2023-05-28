using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WebOpenPanelResultListenerWrapper : BaseWrapper, IWebOpenPanelResultListener, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public WebOpenPanelResultListenerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
