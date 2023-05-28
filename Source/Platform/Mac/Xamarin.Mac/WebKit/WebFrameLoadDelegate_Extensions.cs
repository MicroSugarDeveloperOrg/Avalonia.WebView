using System;
using AppKit;
using Foundation;
using JavaScriptCore;
using ObjCRuntime;

namespace WebKit;

public static class WebFrameLoadDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StartedProvisionalLoad(this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didStartProvisionalLoadForFrame:"), sender.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedServerRedirectForProvisionalLoad(this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didReceiveServerRedirectForProvisionalLoadForFrame:"), sender.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedProvisionalLoad(this IWebFrameLoadDelegate This, WebView sender, NSError error, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didFailProvisionalLoadWithError:forFrame:"), sender.Handle, error.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CommitedLoad(this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didCommitLoadForFrame:"), sender.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedTitle(this IWebFrameLoadDelegate This, WebView sender, string title, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		IntPtr intPtr = NSString.CreateNative(title);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didReceiveTitle:forFrame:"), sender.Handle, intPtr, forFrame.Handle);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedIcon(this IWebFrameLoadDelegate This, WebView sender, NSImage image, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didReceiveIcon:forFrame:"), sender.Handle, image.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FinishedLoad(this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didFinishLoadForFrame:"), sender.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedLoadWithError(this IWebFrameLoadDelegate This, WebView sender, NSError error, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didFailLoadWithError:forFrame:"), sender.Handle, error.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ChangedLocationWithinPage(this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didChangeLocationWithinPageForFrame:"), sender.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillPerformClientRedirect(this IWebFrameLoadDelegate This, WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (toUrl == null)
		{
			throw new ArgumentNullException("toUrl");
		}
		if (fireDate == null)
		{
			throw new ArgumentNullException("fireDate");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:"), sender.Handle, toUrl.Handle, secondsDelay, fireDate.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CanceledClientRedirect(this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didCancelClientRedirectForFrame:"), sender.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillCloseFrame(this IWebFrameLoadDelegate This, WebView sender, WebFrame forFrame)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:willCloseFrame:"), sender.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ClearedWindowObject(this IWebFrameLoadDelegate This, WebView webView, WebScriptObject windowObject, WebFrame forFrame)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (windowObject == null)
		{
			throw new ArgumentNullException("windowObject");
		}
		if (forFrame == null)
		{
			throw new ArgumentNullException("forFrame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didClearWindowObject:forFrame:"), webView.Handle, windowObject.Handle, forFrame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WindowScriptObjectAvailable(this IWebFrameLoadDelegate This, WebView webView, WebScriptObject windowScriptObject)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (windowScriptObject == null)
		{
			throw new ArgumentNullException("windowScriptObject");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:windowScriptObjectAvailable:"), webView.Handle, windowScriptObject.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCreateJavaScriptContext(this IWebFrameLoadDelegate This, WebView webView, JSContext context, WebFrame frame)
	{
		if (webView == null)
		{
			throw new ArgumentNullException("webView");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (frame == null)
		{
			throw new ArgumentNullException("frame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("webView:didCreateJavaScriptContext:forFrame:"), webView.Handle, context.Handle, frame.Handle);
	}
}
