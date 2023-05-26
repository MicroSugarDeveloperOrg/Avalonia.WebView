using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WKUrlSchemeTaskWrapper : BaseWrapper, IWKUrlSchemeTask, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlRequest Request
	{
		[Export("request", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("request")));
		}
	}

	[Preserve(Conditional = true)]
	public WKUrlSchemeTaskWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("didReceiveResponse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidReceiveResponse(NSUrlResponse response)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("didReceiveResponse:"), response.Handle);
	}

	[Export("didReceiveData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidReceiveData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("didReceiveData:"), data.Handle);
	}

	[Export("didFinish")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFinish()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("didFinish"));
	}

	[Export("didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFailWithError(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("didFailWithError:"), error.Handle);
	}
}
