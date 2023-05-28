using System;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

public static class SNResultsObserving_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFail(this ISNResultsObserving This, ISNRequest request, NSError error)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidComplete(this ISNResultsObserving This, ISNRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("requestDidComplete:"), request.Handle);
	}
}
