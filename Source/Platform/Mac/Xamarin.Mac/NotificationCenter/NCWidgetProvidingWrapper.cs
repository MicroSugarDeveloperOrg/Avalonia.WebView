using System;
using Foundation;
using ObjCRuntime;

namespace NotificationCenter;

internal sealed class NCWidgetProvidingWrapper : BaseWrapper, INCWidgetProviding, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NCWidgetProvidingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
