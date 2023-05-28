using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

internal sealed class ASAuthorizationProviderExtensionAuthorizationRequestHandlerWrapper : BaseWrapper, IASAuthorizationProviderExtensionAuthorizationRequestHandler, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ASAuthorizationProviderExtensionAuthorizationRequestHandlerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("beginAuthorizationWithRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void BeginAuthorization(ASAuthorizationProviderExtensionAuthorizationRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("beginAuthorizationWithRequest:"), request.Handle);
	}
}
