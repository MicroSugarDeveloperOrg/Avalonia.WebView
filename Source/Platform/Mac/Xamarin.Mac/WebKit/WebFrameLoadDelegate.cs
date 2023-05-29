using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebFrameLoadDelegate", true)]
[Model]
public class WebFrameLoadDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebFrameLoadDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WebFrameLoadDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebFrameLoadDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebFrameLoadDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("webView:didStartProvisionalLoadForFrame:")]
	public virtual void StartedProvisionalLoad(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didReceiveServerRedirectForProvisionalLoadForFrame:")]
	public virtual void ReceivedServerRedirectForProvisionalLoad(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didFailProvisionalLoadWithError:forFrame:")]
	public virtual void FailedProvisionalLoad(WebView sender, NSError error, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didCommitLoadForFrame:")]
	public virtual void CommitedLoad(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didReceiveTitle:forFrame:")]
	public virtual void ReceivedTitle(WebView sender, string title, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didReceiveIcon:forFrame:")]
	public virtual void ReceivedIcon(WebView sender, NSImage image, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didFinishLoadForFrame:")]
	public virtual void FinishedLoad(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didFailLoadWithError:forFrame:")]
	public virtual void FailedLoadWithError(WebView sender, NSError error, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didChangeLocationWithinPageForFrame:")]
	public virtual void ChangedLocationWithinPage(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:")]
	public virtual void WillPerformClientRedirect(WebView sender, NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didCancelClientRedirectForFrame:")]
	public virtual void CanceledClientRedirect(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:willCloseFrame:")]
	public virtual void WillCloseFrame(WebView sender, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:didClearWindowObject:forFrame:")]
	public virtual void ClearedWindowObject(WebView webView, WebScriptObject windowObject, WebFrame forFrame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:windowScriptObjectAvailable:")]
	public virtual void WindowScriptObjectAvailable(WebView webView, WebScriptObject windowScriptObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
