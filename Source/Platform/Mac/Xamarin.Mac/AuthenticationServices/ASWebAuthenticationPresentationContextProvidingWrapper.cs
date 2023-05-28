using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

internal sealed class ASWebAuthenticationPresentationContextProvidingWrapper : BaseWrapper, IASWebAuthenticationPresentationContextProviding, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ASWebAuthenticationPresentationContextProvidingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("presentationAnchorForWebAuthenticationSession:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSWindow GetPresentationAnchor(ASWebAuthenticationSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("presentationAnchorForWebAuthenticationSession:"), session.Handle));
	}
}
