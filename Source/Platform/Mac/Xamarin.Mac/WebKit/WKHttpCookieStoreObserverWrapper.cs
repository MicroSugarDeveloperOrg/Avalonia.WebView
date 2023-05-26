using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WKHttpCookieStoreObserverWrapper : BaseWrapper, IWKHttpCookieStoreObserver, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public WKHttpCookieStoreObserverWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
