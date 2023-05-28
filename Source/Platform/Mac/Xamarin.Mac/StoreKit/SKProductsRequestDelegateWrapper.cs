using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

internal sealed class SKProductsRequestDelegateWrapper : BaseWrapper, ISKProductsRequestDelegate, INativeObject, IDisposable, ISKRequestDelegate
{
	[Preserve(Conditional = true)]
	public SKProductsRequestDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("productsRequest:didReceiveResponse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ReceivedResponse(SKProductsRequest request, SKProductsResponse response)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("productsRequest:didReceiveResponse:"), request.Handle, response.Handle);
	}
}
