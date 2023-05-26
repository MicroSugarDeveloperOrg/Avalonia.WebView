using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WKScriptMessageHandlerWrapper : BaseWrapper, IWKScriptMessageHandler, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public WKScriptMessageHandlerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("userContentController:didReceiveScriptMessage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message)
	{
		if (userContentController == null)
		{
			throw new ArgumentNullException("userContentController");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("userContentController:didReceiveScriptMessage:"), userContentController.Handle, message.Handle);
	}
}
