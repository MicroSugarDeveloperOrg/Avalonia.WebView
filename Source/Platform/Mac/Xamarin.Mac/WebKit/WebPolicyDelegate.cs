using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebPolicyDelegate", true)]
[Model]
public class WebPolicyDelegate : NSObject
{
	private static IntPtr selUse = Selector.GetHandle("use");

	private static IntPtr selDownload = Selector.GetHandle("download");

	private static IntPtr selIgnore = Selector.GetHandle("ignore");

	public static void DecideUse(NSObject decisionToken)
	{
		if (decisionToken == null)
		{
			throw new ArgumentNullException("token");
		}
		Messaging.void_objc_msgSend(decisionToken.Handle, selUse);
	}

	public static void DecideDownload(NSObject decisionToken)
	{
		if (decisionToken == null)
		{
			throw new ArgumentNullException("decisionToken");
		}
		Messaging.void_objc_msgSend(decisionToken.Handle, selDownload);
	}

	public static void DecideIgnore(NSObject decisionToken)
	{
		if (decisionToken == null)
		{
			throw new ArgumentNullException("decisionToken");
		}
		Messaging.void_objc_msgSend(decisionToken.Handle, selIgnore);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebPolicyDelegate()
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
	public WebPolicyDelegate(NSCoder coder)
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
	public WebPolicyDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebPolicyDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("webView:decidePolicyForNavigationAction:request:frame:decisionListener:")]
	public virtual void DecidePolicyForNavigation(WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:")]
	public virtual void DecidePolicyForNewWindow(WebView webView, NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:decidePolicyForMIMEType:request:frame:")]
	public virtual void DecidePolicyForMimeType(WebView webView, string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("webView:unableToImplementPolicyWithError:frame::")]
	public virtual void UnableToImplementPolicy(WebView webView, NSError error, WebFrame frame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
