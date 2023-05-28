using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetResourceLoadingRequest", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetResourceLoadingRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentInformationRequest = "contentInformationRequest";

	private static readonly IntPtr selContentInformationRequestHandle = Selector.GetHandle("contentInformationRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataRequest = "dataRequest";

	private static readonly IntPtr selDataRequestHandle = Selector.GetHandle("dataRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishLoading = "finishLoading";

	private static readonly IntPtr selFinishLoadingHandle = Selector.GetHandle("finishLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishLoadingWithError_ = "finishLoadingWithError:";

	private static readonly IntPtr selFinishLoadingWithError_Handle = Selector.GetHandle("finishLoadingWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishLoadingWithResponse_Data_Redirect_ = "finishLoadingWithResponse:data:redirect:";

	private static readonly IntPtr selFinishLoadingWithResponse_Data_Redirect_Handle = Selector.GetHandle("finishLoadingWithResponse:data:redirect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCancelled = "isCancelled";

	private static readonly IntPtr selIsCancelledHandle = Selector.GetHandle("isCancelled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFinished = "isFinished";

	private static readonly IntPtr selIsFinishedHandle = Selector.GetHandle("isFinished");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentContentKeyFromKeyVendorResponse_Options_Error_ = "persistentContentKeyFromKeyVendorResponse:options:error:";

	private static readonly IntPtr selPersistentContentKeyFromKeyVendorResponse_Options_Error_Handle = Selector.GetHandle("persistentContentKeyFromKeyVendorResponse:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedirect = "redirect";

	private static readonly IntPtr selRedirectHandle = Selector.GetHandle("redirect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequest = "request";

	private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestor = "requestor";

	private static readonly IntPtr selRequestorHandle = Selector.GetHandle("requestor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResponse = "response";

	private static readonly IntPtr selResponseHandle = Selector.GetHandle("response");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRedirect_ = "setRedirect:";

	private static readonly IntPtr selSetRedirect_Handle = Selector.GetHandle("setRedirect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResponse_ = "setResponse:";

	private static readonly IntPtr selSetResponse_Handle = Selector.GetHandle("setResponse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_Error_ = "streamingContentKeyRequestDataForApp:contentIdentifier:options:error:";

	private static readonly IntPtr selStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_Error_Handle = Selector.GetHandle("streamingContentKeyRequestDataForApp:contentIdentifier:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetResourceLoadingRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StreamingContentKeyRequestRequiresPersistentKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual AVAssetResourceLoadingContentInformationRequest? ContentInformationRequest
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("contentInformationRequest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetResourceLoadingContentInformationRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentInformationRequestHandle));
			}
			return Runtime.GetNSObject<AVAssetResourceLoadingContentInformationRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentInformationRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual AVAssetResourceLoadingDataRequest? DataRequest
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("dataRequest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetResourceLoadingDataRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataRequestHandle));
			}
			return Runtime.GetNSObject<AVAssetResourceLoadingDataRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool Finished
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("isFinished")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFinishedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFinishedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool IsCancelled
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("isCancelled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCancelledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCancelledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSUrlRequest? Redirect
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("redirect", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selRedirectHandle));
			}
			return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRedirectHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setRedirect:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRedirect_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRedirect_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequest Request
	{
		[Export("request")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestHandle));
			}
			return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual AVAssetResourceLoadingRequestor Requestor
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("requestor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetResourceLoadingRequestor>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestorHandle));
			}
			return Runtime.GetNSObject<AVAssetResourceLoadingRequestor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSUrlResponse? Response
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("response", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlResponse>(Messaging.IntPtr_objc_msgSend(base.Handle, selResponseHandle));
			}
			return Runtime.GetNSObject<NSUrlResponse>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResponseHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setResponse:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetResponse_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetResponse_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[Field("AVAssetResourceLoadingRequestStreamingContentKeyRequestRequiresPersistentKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public static NSString StreamingContentKeyRequestRequiresPersistentKey
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			if (_StreamingContentKeyRequestRequiresPersistentKey == null)
			{
				_StreamingContentKeyRequestRequiresPersistentKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetResourceLoadingRequestStreamingContentKeyRequestRequiresPersistentKey");
			}
			return _StreamingContentKeyRequestRequiresPersistentKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetResourceLoadingRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetResourceLoadingRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("finishLoadingWithResponse:data:redirect:")]
	[Introduced(PlatformName.iOS, 6, 0, PlatformArchitecture.All, "Use the 'Response', 'Redirect' properties and the 'AVAssetResourceLoadingDataRequest.Responds' and 'AVAssetResourceLoadingRequest.FinishLoading' methods instead.")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, "Use the 'Response', 'Redirect' properties and the 'AVAssetResourceLoadingDataRequest.Responds' and 'AVAssetResourceLoadingRequest.FinishLoading' methods instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishLoading(NSUrlResponse? usingResponse, NSData? data, NSUrlRequest? redirect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selFinishLoadingWithResponse_Data_Redirect_Handle, usingResponse?.Handle ?? IntPtr.Zero, data?.Handle ?? IntPtr.Zero, redirect?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selFinishLoadingWithResponse_Data_Redirect_Handle, usingResponse?.Handle ?? IntPtr.Zero, data?.Handle ?? IntPtr.Zero, redirect?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("finishLoading")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishLoading()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinishLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinishLoadingHandle);
		}
	}

	[Export("finishLoadingWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishLoadingWithError(NSError? error)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFinishLoadingWithError_Handle, error?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinishLoadingWithError_Handle, error?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("persistentContentKeyFromKeyVendorResponse:options:error:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetPersistentContentKey(NSData keyVendorResponse, NSDictionary<NSString, NSObject>? options, out NSError error)
	{
		if (keyVendorResponse == null)
		{
			throw new ArgumentNullException("keyVendorResponse");
		}
		IntPtr arg = IntPtr.Zero;
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPersistentContentKeyFromKeyVendorResponse_Options_Error_Handle, keyVendorResponse.Handle, options?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPersistentContentKeyFromKeyVendorResponse_Options_Error_Handle, keyVendorResponse.Handle, options?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("streamingContentKeyRequestDataForApp:contentIdentifier:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetStreamingContentKey(NSData appIdentifier, NSData contentIdentifier, NSDictionary? options, out NSError error)
	{
		if (appIdentifier == null)
		{
			throw new ArgumentNullException("appIdentifier");
		}
		if (contentIdentifier == null)
		{
			throw new ArgumentNullException("contentIdentifier");
		}
		IntPtr arg = IntPtr.Zero;
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_Error_Handle, appIdentifier.Handle, contentIdentifier.Handle, options?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_Error_Handle, appIdentifier.Handle, contentIdentifier.Handle, options?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
