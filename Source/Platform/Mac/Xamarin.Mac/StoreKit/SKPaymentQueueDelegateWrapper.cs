using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

internal sealed class SKPaymentQueueDelegateWrapper : BaseWrapper, ISKPaymentQueueDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SKPaymentQueueDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
