using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVContentKeySessionDelegateWrapper : BaseWrapper, IAVContentKeySessionDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVContentKeySessionDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("contentKeySession:didProvideContentKeyRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidProvideContentKeyRequest(AVContentKeySession session, AVContentKeyRequest keyRequest)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (keyRequest == null)
		{
			throw new ArgumentNullException("keyRequest");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("contentKeySession:didProvideContentKeyRequest:"), session.Handle, keyRequest.Handle);
	}
}
