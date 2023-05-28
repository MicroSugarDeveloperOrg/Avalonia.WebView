using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

public static class ASWebAuthenticationSessionRequestDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidComplete(this IASWebAuthenticationSessionRequestDelegate This, ASWebAuthenticationSessionRequest authenticationSessionRequest, NSUrl callbackUrl)
	{
		if (authenticationSessionRequest == null)
		{
			throw new ArgumentNullException("authenticationSessionRequest");
		}
		if (callbackUrl == null)
		{
			throw new ArgumentNullException("callbackUrl");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("authenticationSessionRequest:didCompleteWithCallbackURL:"), authenticationSessionRequest.Handle, callbackUrl.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCancel(this IASWebAuthenticationSessionRequestDelegate This, ASWebAuthenticationSessionRequest authenticationSessionRequest, NSError error)
	{
		if (authenticationSessionRequest == null)
		{
			throw new ArgumentNullException("authenticationSessionRequest");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("authenticationSessionRequest:didCancelWithError:"), authenticationSessionRequest.Handle, error.Handle);
	}
}
