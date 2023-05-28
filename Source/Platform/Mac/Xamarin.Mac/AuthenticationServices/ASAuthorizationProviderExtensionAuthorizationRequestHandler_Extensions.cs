using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Advice("This API is not available when using UIKit on macOS.")]
public static class ASAuthorizationProviderExtensionAuthorizationRequestHandler_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CancelAuthorization(this IASAuthorizationProviderExtensionAuthorizationRequestHandler This, ASAuthorizationProviderExtensionAuthorizationRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("cancelAuthorizationWithRequest:"), request.Handle);
	}
}
