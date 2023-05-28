using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSURLConnectionDataDelegate", false)]
[Model]
public class NSUrlConnectionDataDelegate : NSUrlConnectionDelegate, INSUrlConnectionDataDelegate, INativeObject, IDisposable, INSUrlConnectionDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlConnectionDataDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlConnectionDataDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlConnectionDataDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("connectionDidFinishLoading:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishedLoading(NSUrlConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:needNewBodyStream:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSInputStream NeedNewBodyStream(NSUrlConnection connection, NSUrlRequest request)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didReceiveData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedData(NSUrlConnection connection, NSData data)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didReceiveResponse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedResponse(NSUrlConnection connection, NSUrlResponse response)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SentBodyData(NSUrlConnection connection, nint bytesWritten, nint totalBytesWritten, nint totalBytesExpectedToWrite)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:willCacheResponse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCachedUrlResponse WillCacheResponse(NSUrlConnection connection, NSCachedUrlResponse cachedResponse)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:willSendRequest:redirectResponse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequest WillSendRequest(NSUrlConnection connection, NSUrlRequest request, NSUrlResponse response)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
