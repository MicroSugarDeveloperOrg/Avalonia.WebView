using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSURLSessionDataDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class NSUrlSessionDataDelegate : NSUrlSessionTaskDelegate, INSUrlSessionDataDelegate, INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlSessionDataDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionDataDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionDataDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("URLSession:dataTask:didBecomeDownloadTask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBecomeDownloadTask(NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionDownloadTask downloadTask)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:dataTask:didBecomeStreamTask:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBecomeStreamTask(NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlSessionStreamTask streamTask)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:dataTask:didReceiveData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveData(NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:dataTask:didReceiveResponse:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveResponse(NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlResponse response, [BlockProxy(typeof(Trampolines.NIDActionArity1V39))] Action<NSUrlSessionResponseDisposition> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:dataTask:willCacheResponse:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillCacheResponse(NSUrlSession session, NSUrlSessionDataTask dataTask, NSCachedUrlResponse proposedResponse, [BlockProxy(typeof(Trampolines.NIDActionArity1V36))] Action<NSCachedUrlResponse> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
