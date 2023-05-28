using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

public static class NSUrlDownloadDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DownloadBegan(this INSUrlDownloadDelegate This, NSUrlDownload download)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("downloadDidBegin:"), download.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlRequest WillSendRequest(this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlRequest request, NSUrlResponse redirectResponse)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (redirectResponse == null)
		{
			throw new ArgumentNullException("redirectResponse");
		}
		return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("download:willSendRequest:redirectResponse:"), download.Handle, request.Handle, redirectResponse.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedAuthenticationChallenge(this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("download:didReceiveAuthenticationChallenge:"), download.Handle, challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CanceledAuthenticationChallenge(this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlAuthenticationChallenge challenge)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("download:didCancelAuthenticationChallenge:"), download.Handle, challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedResponse(this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlResponse response)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("download:didReceiveResponse:"), download.Handle, response.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Resume(this INSUrlDownloadDelegate This, NSUrlDownload download, NSUrlResponse response, long startingByte)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(This.Handle, Selector.GetHandle("download:willResumeWithResponse:fromByte:"), download.Handle, response.Handle, startingByte);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedData(this INSUrlDownloadDelegate This, NSUrlDownload download, nuint length)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("download:didReceiveDataOfLength:"), download.Handle, length);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool DecodeSourceData(this INSUrlDownloadDelegate This, NSUrlDownload download, string encodingType)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		if (encodingType == null)
		{
			throw new ArgumentNullException("encodingType");
		}
		IntPtr intPtr = NSString.CreateNative(encodingType);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("download:shouldDecodeSourceDataOfMIMEType:"), download.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DecideDestination(this INSUrlDownloadDelegate This, NSUrlDownload download, string suggestedFilename)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		if (suggestedFilename == null)
		{
			throw new ArgumentNullException("suggestedFilename");
		}
		IntPtr intPtr = NSString.CreateNative(suggestedFilename);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("download:decideDestinationWithSuggestedFilename:"), download.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CreatedDestination(this INSUrlDownloadDelegate This, NSUrlDownload download, string path)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = NSString.CreateNative(path);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("download:didCreateDestination:"), download.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Finished(this INSUrlDownloadDelegate This, NSUrlDownload download)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("downloadDidFinish:"), download.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedWithError(this INSUrlDownloadDelegate This, NSUrlDownload download, NSError error)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("download:didFailWithError:"), download.Handle, error.Handle);
	}
}
