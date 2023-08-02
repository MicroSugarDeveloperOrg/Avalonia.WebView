using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUrlDownloadDelegate", true)]
[Model]
public class NSUrlDownloadDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlDownloadDelegate()
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
	public NSUrlDownloadDelegate(NSCoder coder)
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
	public NSUrlDownloadDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlDownloadDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("downloadDidBegin:")]
	public virtual void DownloadBegan(NSUrlDownload download)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:willSendRequest:redirectResponse:")]
	public virtual NSUrlRequest WillSendRequest(NSUrlDownload download, NSUrlRequest request, NSUrlResponse redirectResponse)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didReceiveAuthenticationChallenge:")]
	public virtual void ReceivedAuthenticationChallenge(NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didCancelAuthenticationChallenge:")]
	public virtual void CanceledAuthenticationChallenge(NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didReceiveResponse:")]
	public virtual void ReceivedResponse(NSUrlDownload download, NSUrlResponse response)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:willResumeWithResponse:fromByte:")]
	public virtual void Resume(NSUrlDownload download, NSUrlResponse response, long startingByte)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didReceiveDataOfLength:")]
	public virtual void ReceivedData(NSUrlDownload download, uint length)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:shouldDecodeSourceDataOfMIMEType:")]
	public virtual bool DecodeSourceData(NSUrlDownload download, string encodingType)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:decideDestinationWithSuggestedFilename:")]
	public virtual void DecideDestination(NSUrlDownload download, string suggestedFilename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didCreateDestination:")]
	public virtual void CreatedDestination(NSUrlDownload download, string path)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("downloadDidFinish:")]
	public virtual void Finished(NSUrlDownload download)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didFailWithError:")]
	public virtual void FailedWithError(NSUrlDownload download, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
