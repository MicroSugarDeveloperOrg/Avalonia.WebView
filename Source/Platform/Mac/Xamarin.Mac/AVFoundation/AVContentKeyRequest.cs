using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVContentKeyRequest", true)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVContentKeyRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanProvidePersistableContentKey = "canProvidePersistableContentKey";

	private static readonly IntPtr selCanProvidePersistableContentKeyHandle = Selector.GetHandle("canProvidePersistableContentKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitializationData = "initializationData";

	private static readonly IntPtr selInitializationDataHandle = Selector.GetHandle("initializationData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_CompletionHandler_ = "makeStreamingContentKeyRequestDataForApp:contentIdentifier:options:completionHandler:";

	private static readonly IntPtr selMakeStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_CompletionHandler_Handle = Selector.GetHandle("makeStreamingContentKeyRequestDataForApp:contentIdentifier:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessContentKeyResponse_ = "processContentKeyResponse:";

	private static readonly IntPtr selProcessContentKeyResponse_Handle = Selector.GetHandle("processContentKeyResponse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessContentKeyResponseError_ = "processContentKeyResponseError:";

	private static readonly IntPtr selProcessContentKeyResponseError_Handle = Selector.GetHandle("processContentKeyResponseError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRespondByRequestingPersistableContentKeyRequestAndReturnError_ = "respondByRequestingPersistableContentKeyRequestAndReturnError:";

	private static readonly IntPtr selRespondByRequestingPersistableContentKeyRequestAndReturnError_Handle = Selector.GetHandle("respondByRequestingPersistableContentKeyRequestAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVContentKeyRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProtocolVersions;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RequiresValidationDataInSecureTokenKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool CanProvidePersistableContentKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("canProvidePersistableContentKey")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanProvidePersistableContentKeyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanProvidePersistableContentKeyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual NSError? Error
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("error")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual NSObject? Identifier
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual NSData? InitializationData
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("initializationData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selInitializationDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitializationDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	public virtual NSDictionary<NSString, NSObject> Options
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		[Export("options", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selOptionsHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVContentKeyRequestStatus Status
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVContentKeyRequestStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVContentKeyRequestStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[Field("AVContentKeyRequestProtocolVersionsKey", "AVFoundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public static NSString ProtocolVersions
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			if (_ProtocolVersions == null)
			{
				_ProtocolVersions = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVContentKeyRequestProtocolVersionsKey");
			}
			return _ProtocolVersions;
		}
	}

	[Field("AVContentKeyRequestRequiresValidationDataInSecureTokenKey", "AVFoundation")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString RequiresValidationDataInSecureTokenKey
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RequiresValidationDataInSecureTokenKey == null)
			{
				_RequiresValidationDataInSecureTokenKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVContentKeyRequestRequiresValidationDataInSecureTokenKey");
			}
			return _RequiresValidationDataInSecureTokenKey;
		}
	}

	[Obsolete("This API is not available on this platform.")]
	public virtual void RespondByRequestingPersistableContentKeyRequest()
	{
		throw new NotImplementedException();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVContentKeyRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVContentKeyRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("makeStreamingContentKeyRequestDataForApp:contentIdentifier:options:completionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void MakeStreamingContentKeyRequestData(NSData appIdentifier, NSData? contentIdentifier, NSDictionary<NSString, NSObject>? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> handler)
	{
		if (appIdentifier == null)
		{
			throw new ArgumentNullException("appIdentifier");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selMakeStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_CompletionHandler_Handle, appIdentifier.Handle, contentIdentifier?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMakeStreamingContentKeyRequestDataForApp_ContentIdentifier_Options_CompletionHandler_Handle, appIdentifier.Handle, contentIdentifier?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> MakeStreamingContentKeyRequestDataAsync(NSData appIdentifier, NSData? contentIdentifier, NSDictionary<NSString, NSObject>? options)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		MakeStreamingContentKeyRequestData(appIdentifier, contentIdentifier, options, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("processContentKeyResponse:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Process(AVContentKeyResponse keyResponse)
	{
		if (keyResponse == null)
		{
			throw new ArgumentNullException("keyResponse");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selProcessContentKeyResponse_Handle, keyResponse.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selProcessContentKeyResponse_Handle, keyResponse.Handle);
		}
	}

	[Export("processContentKeyResponseError:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Process(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selProcessContentKeyResponseError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selProcessContentKeyResponseError_Handle, error.Handle);
		}
	}

	[Export("respondByRequestingPersistableContentKeyRequestAndReturnError:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RespondByRequestingPersistableContentKeyRequest(out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selRespondByRequestingPersistableContentKeyRequestAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selRespondByRequestingPersistableContentKeyRequestAndReturnError_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
