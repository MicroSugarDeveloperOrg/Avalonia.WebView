using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

public static class ASAuthorizationControllerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidComplete(this IASAuthorizationControllerDelegate This, ASAuthorizationController controller, ASAuthorization authorization)
	{
		if (controller == null)
		{
			throw new ArgumentNullException("controller");
		}
		if (authorization == null)
		{
			throw new ArgumentNullException("authorization");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("authorizationController:didCompleteWithAuthorization:"), controller.Handle, authorization.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidComplete(this IASAuthorizationControllerDelegate This, ASAuthorizationController controller, NSError error)
	{
		if (controller == null)
		{
			throw new ArgumentNullException("controller");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("authorizationController:didCompleteWithError:"), controller.Handle, error.Handle);
	}
}
