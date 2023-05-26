using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WKUrlSchemeHandlerWrapper : BaseWrapper, IWKUrlSchemeHandler, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public WKUrlSchemeHandlerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("webView:startURLSchemeTask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void StartUrlSchemeTask(WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (urlSchemeTask == null)
		{
			throw new ArgumentNullException("urlSchemeTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("webView:startURLSchemeTask:"), webView.Handle, urlSchemeTask.Handle);
	}

	[Export("webView:stopURLSchemeTask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void StopUrlSchemeTask(WKWebView webView, IWKUrlSchemeTask urlSchemeTask)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (urlSchemeTask == null)
		{
			throw new ArgumentNullException("urlSchemeTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("webView:stopURLSchemeTask:"), webView.Handle, urlSchemeTask.Handle);
	}
}
