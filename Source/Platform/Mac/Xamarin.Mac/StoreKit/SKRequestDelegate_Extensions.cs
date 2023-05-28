using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

public static class SKRequestDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RequestFinished(this ISKRequestDelegate This, SKRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("requestDidFinish:"), request.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RequestFailed(this ISKRequestDelegate This, SKRequest request, NSError error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("request:didFailWithError:"), request.Handle, error.Handle);
	}
}
