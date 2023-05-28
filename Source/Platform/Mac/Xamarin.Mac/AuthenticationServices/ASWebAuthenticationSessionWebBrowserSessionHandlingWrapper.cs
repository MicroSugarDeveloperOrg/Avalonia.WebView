using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

internal sealed class ASWebAuthenticationSessionWebBrowserSessionHandlingWrapper : BaseWrapper, IASWebAuthenticationSessionWebBrowserSessionHandling, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ASWebAuthenticationSessionWebBrowserSessionHandlingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("beginHandlingWebAuthenticationSessionRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void BeginHandlingWebAuthenticationSessionRequest(ASWebAuthenticationSessionRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("beginHandlingWebAuthenticationSessionRequest:"), request.Handle);
	}

	[Export("cancelWebAuthenticationSessionRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CancelWebAuthenticationSessionRequest(ASWebAuthenticationSessionRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("cancelWebAuthenticationSessionRequest:"), request.Handle);
	}
}
