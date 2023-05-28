using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASAuthorizationProviderExtensionAuthorizationRequest", true)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
public class ASAuthorizationProviderExtensionAuthorizationRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationOptions = "authorizationOptions";

	private static readonly IntPtr selAuthorizationOptionsHandle = Selector.GetHandle("authorizationOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallerBundleIdentifier = "callerBundleIdentifier";

	private static readonly IntPtr selCallerBundleIdentifierHandle = Selector.GetHandle("callerBundleIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComplete = "complete";

	private static readonly IntPtr selCompleteHandle = Selector.GetHandle("complete");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompleteWithError_ = "completeWithError:";

	private static readonly IntPtr selCompleteWithError_Handle = Selector.GetHandle("completeWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompleteWithHTTPAuthorizationHeaders_ = "completeWithHTTPAuthorizationHeaders:";

	private static readonly IntPtr selCompleteWithHTTPAuthorizationHeaders_Handle = Selector.GetHandle("completeWithHTTPAuthorizationHeaders:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompleteWithHTTPResponse_HttpBody_ = "completeWithHTTPResponse:httpBody:";

	private static readonly IntPtr selCompleteWithHTTPResponse_HttpBody_Handle = Selector.GetHandle("completeWithHTTPResponse:httpBody:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoNotHandle = "doNotHandle";

	private static readonly IntPtr selDoNotHandleHandle = Selector.GetHandle("doNotHandle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtensionData = "extensionData";

	private static readonly IntPtr selExtensionDataHandle = Selector.GetHandle("extensionData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHttpBody = "httpBody";

	private static readonly IntPtr selHttpBodyHandle = Selector.GetHandle("httpBody");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHttpHeaders = "httpHeaders";

	private static readonly IntPtr selHttpHeadersHandle = Selector.GetHandle("httpHeaders");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentAuthorizationViewControllerWithCompletion_ = "presentAuthorizationViewControllerWithCompletion:";

	private static readonly IntPtr selPresentAuthorizationViewControllerWithCompletion_Handle = Selector.GetHandle("presentAuthorizationViewControllerWithCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRealm = "realm";

	private static readonly IntPtr selRealmHandle = Selector.GetHandle("realm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestedOperation = "requestedOperation";

	private static readonly IntPtr selRequestedOperationHandle = Selector.GetHandle("requestedOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrl = "url";

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASAuthorizationProviderExtensionAuthorizationRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary AuthorizationOptions
	{
		[Export("authorizationOptions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAuthorizationOptionsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAuthorizationOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CallerBundleIdentifier
	{
		[Export("callerBundleIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCallerBundleIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCallerBundleIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ExtensionData
	{
		[Export("extensionData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selExtensionDataHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtensionDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData HttpBody
	{
		[Export("httpBody")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selHttpBodyHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHttpBodyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSString> HttpHeaders
	{
		[Export("httpHeaders")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSString>>(Messaging.IntPtr_objc_msgSend(base.Handle, selHttpHeadersHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSString>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHttpHeadersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Realm
	{
		[Export("realm")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRealmHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRealmHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ASAuthorizationProviderAuthorizationOperation RequestedOperation => ASAuthorizationProviderAuthorizationOperationExtensions.GetValue(WeakRequestedOperation);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("url")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString WeakRequestedOperation
	{
		[Export("requestedOperation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestedOperationHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestedOperationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ASAuthorizationProviderExtensionAuthorizationRequest()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ASAuthorizationProviderExtensionAuthorizationRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASAuthorizationProviderExtensionAuthorizationRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("complete")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Complete()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCompleteHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCompleteHandle);
		}
	}

	[Export("completeWithHTTPAuthorizationHeaders:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Complete(NSDictionary<NSString, NSString> httpAuthorizationHeaders)
	{
		if (httpAuthorizationHeaders == null)
		{
			throw new ArgumentNullException("httpAuthorizationHeaders");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCompleteWithHTTPAuthorizationHeaders_Handle, httpAuthorizationHeaders.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompleteWithHTTPAuthorizationHeaders_Handle, httpAuthorizationHeaders.Handle);
		}
	}

	[Export("completeWithHTTPResponse:httpBody:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Complete(NSHttpUrlResponse httpResponse, NSData? httpBody)
	{
		if (httpResponse == null)
		{
			throw new ArgumentNullException("httpResponse");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selCompleteWithHTTPResponse_HttpBody_Handle, httpResponse.Handle, httpBody?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCompleteWithHTTPResponse_HttpBody_Handle, httpResponse.Handle, httpBody?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("completeWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Complete(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCompleteWithError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompleteWithError_Handle, error.Handle);
		}
	}

	[Export("doNotHandle")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DoNotHandle()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDoNotHandleHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDoNotHandleHandle);
		}
	}

	[Export("presentAuthorizationViewControllerWithCompletion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PresentAuthorizationViewController([BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V4.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentAuthorizationViewControllerWithCompletion_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentAuthorizationViewControllerWithCompletion_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<Tuple<bool, NSError>> PresentAuthorizationViewControllerAsync()
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		PresentAuthorizationViewController(delegate(bool arg1_, NSError arg2_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(arg1_, arg2_));
		});
		return tcs.Task;
	}
}
