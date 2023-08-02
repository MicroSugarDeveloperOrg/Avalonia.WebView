using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSURLConnectionDelegate", true)]
[Model]
public class NSUrlConnectionDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlConnectionDelegate()
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
	public NSUrlConnectionDelegate(NSCoder coder)
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
	public NSUrlConnectionDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlConnectionDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("connection:willSendRequest:redirectResponse:")]
	public virtual NSUrlRequest WillSendRequest(NSUrlConnection connection, NSUrlRequest request, NSUrlResponse response)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:canAuthenticateAgainstProtectionSpace:")]
	public virtual bool CanAuthenticateAgainstProtectionSpace(NSUrlConnection connection, NSUrlProtectionSpace protectionSpace)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:needNewBodyStream:")]
	public virtual NSInputStream NeedNewBodyStream(NSUrlConnection connection, NSUrlRequest request)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didReceiveAuthenticationChallenge:")]
	public virtual void ReceivedAuthenticationChallenge(NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didCancelAuthenticationChallenge:")]
	public virtual void CanceledAuthenticationChallenge(NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connectionShouldUseCredentialStorage:")]
	public virtual bool ConnectionShouldUseCredentialStorage(NSUrlConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didReceiveResponse:")]
	public virtual void ReceivedResponse(NSUrlConnection connection, NSUrlResponse response)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didReceiveData:")]
	public virtual void ReceivedData(NSUrlConnection connection, NSData data)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:")]
	public virtual void SentBodyData(NSUrlConnection connection, long bytesWritten, long totalBytesWritten, long totalBytesExpectedToWrite)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connectionDidFinishLoading:")]
	public virtual void FinishedLoading(NSUrlConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didFailWithError:")]
	public virtual void FailedWithError(NSUrlConnection connection, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:willCacheResponse:")]
	public virtual NSCachedUrlResponse WillCacheResponse(NSUrlConnection connection, NSCachedUrlResponse cachedResponse)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
