using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

internal sealed class ASAuthorizationControllerPresentationContextProvidingWrapper : BaseWrapper, IASAuthorizationControllerPresentationContextProviding, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ASAuthorizationControllerPresentationContextProvidingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("presentationAnchorForAuthorizationController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSWindow GetPresentationAnchor(ASAuthorizationController controller)
	{
		if (controller == null)
		{
			throw new ArgumentNullException("controller");
		}
		return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("presentationAnchorForAuthorizationController:"), controller.Handle));
	}
}
