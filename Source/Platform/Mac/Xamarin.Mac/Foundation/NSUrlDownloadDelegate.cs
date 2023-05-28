using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Protocol(Name = "NSURLDownloadDelegate")]
[Register("NSUrlDownloadDelegate", false)]
[Model]
public class NSUrlDownloadDelegate : NSObject, INSUrlDownloadDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlDownloadDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlDownloadDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlDownloadDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("download:didCancelAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CanceledAuthenticationChallenge(NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didCreateDestination:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CreatedDestination(NSUrlDownload download, string path)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:decideDestinationWithSuggestedFilename:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecideDestination(NSUrlDownload download, string suggestedFilename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:shouldDecodeSourceDataOfMIMEType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DecodeSourceData(NSUrlDownload download, string encodingType)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("downloadDidBegin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DownloadBegan(NSUrlDownload download)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedWithError(NSUrlDownload download, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("downloadDidFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Finished(NSUrlDownload download)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didReceiveAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedAuthenticationChallenge(NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didReceiveDataOfLength:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedData(NSUrlDownload download, nuint length)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:didReceiveResponse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedResponse(NSUrlDownload download, NSUrlResponse response)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:willResumeWithResponse:fromByte:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resume(NSUrlDownload download, NSUrlResponse response, long startingByte)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("download:willSendRequest:redirectResponse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequest WillSendRequest(NSUrlDownload download, NSUrlRequest request, NSUrlResponse redirectResponse)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
