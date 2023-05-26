using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSURLSessionTaskDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class NSUrlSessionTaskDelegate : NSUrlSessionDelegate, INSUrlSessionTaskDelegate, INativeObject, IDisposable, INSUrlSessionDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlSessionTaskDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionTaskDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionTaskDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("URLSession:task:didCompleteWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCompleteWithError(NSUrlSession session, NSUrlSessionTask task, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:task:didFinishCollectingMetrics:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishCollectingMetrics(NSUrlSession session, NSUrlSessionTask task, NSUrlSessionTaskMetrics metrics)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:task:didReceiveChallenge:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveChallenge(NSUrlSession session, NSUrlSessionTask task, NSUrlAuthenticationChallenge challenge, [BlockProxy(typeof(Trampolines.NIDActionArity2V44))] Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:task:didSendBodyData:totalBytesSent:totalBytesExpectedToSend:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSendBodyData(NSUrlSession session, NSUrlSessionTask task, long bytesSent, long totalBytesSent, long totalBytesExpectedToSend)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:task:needNewBodyStream:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NeedNewBodyStream(NSUrlSession session, NSUrlSessionTask task, [BlockProxy(typeof(Trampolines.NIDActionArity1V41))] Action<NSInputStream> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:taskIsWaitingForConnectivity:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TaskIsWaitingForConnectivity(NSUrlSession session, NSUrlSessionTask task)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:task:willBeginDelayedRequest:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillBeginDelayedRequest(NSUrlSession session, NSUrlSessionTask task, NSUrlRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity2V45))] Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillPerformHttpRedirection(NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response, NSUrlRequest newRequest, [BlockProxy(typeof(Trampolines.NIDActionArity1V40))] Action<NSUrlRequest> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
