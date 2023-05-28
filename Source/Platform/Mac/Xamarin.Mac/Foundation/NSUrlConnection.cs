using System;
using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLConnection", true)]
public class NSUrlConnection : NSObject, INSURLAuthenticationChallengeSender, INativeObject, IDisposable
{
	private const string selSendSynchronousRequestReturningResponseError = "sendSynchronousRequest:returningResponse:error:";

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanHandleRequest_ = "canHandleRequest:";

	private static readonly IntPtr selCanHandleRequest_Handle = Selector.GetHandle("canHandleRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelAuthenticationChallenge_ = "cancelAuthenticationChallenge:";

	private static readonly IntPtr selCancelAuthenticationChallenge_Handle = Selector.GetHandle("cancelAuthenticationChallenge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectionWithRequest_Delegate_ = "connectionWithRequest:delegate:";

	private static readonly IntPtr selConnectionWithRequest_Delegate_Handle = Selector.GetHandle("connectionWithRequest:delegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContinueWithoutCredentialForAuthenticationChallenge_ = "continueWithoutCredentialForAuthenticationChallenge:";

	private static readonly IntPtr selContinueWithoutCredentialForAuthenticationChallenge_Handle = Selector.GetHandle("continueWithoutCredentialForAuthenticationChallenge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRequest_Delegate_ = "initWithRequest:delegate:";

	private static readonly IntPtr selInitWithRequest_Delegate_Handle = Selector.GetHandle("initWithRequest:delegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRequest_Delegate_StartImmediately_ = "initWithRequest:delegate:startImmediately:";

	private static readonly IntPtr selInitWithRequest_Delegate_StartImmediately_Handle = Selector.GetHandle("initWithRequest:delegate:startImmediately:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformDefaultHandlingForAuthenticationChallenge_ = "performDefaultHandlingForAuthenticationChallenge:";

	private static readonly IntPtr selPerformDefaultHandlingForAuthenticationChallenge_Handle = Selector.GetHandle("performDefaultHandlingForAuthenticationChallenge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRejectProtectionSpaceAndContinueWithChallenge_ = "rejectProtectionSpaceAndContinueWithChallenge:";

	private static readonly IntPtr selRejectProtectionSpaceAndContinueWithChallenge_Handle = Selector.GetHandle("rejectProtectionSpaceAndContinueWithChallenge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleInRunLoop_ForMode_ = "scheduleInRunLoop:forMode:";

	private static readonly IntPtr selScheduleInRunLoop_ForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendAsynchronousRequest_Queue_CompletionHandler_ = "sendAsynchronousRequest:queue:completionHandler:";

	private static readonly IntPtr selSendAsynchronousRequest_Queue_CompletionHandler_Handle = Selector.GetHandle("sendAsynchronousRequest:queue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegateQueue_ = "setDelegateQueue:";

	private static readonly IntPtr selSetDelegateQueue_Handle = Selector.GetHandle("setDelegateQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStart = "start";

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnscheduleFromRunLoop_ForMode_ = "unscheduleFromRunLoop:forMode:";

	private static readonly IntPtr selUnscheduleFromRunLoop_ForMode_Handle = Selector.GetHandle("unscheduleFromRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUseCredential_ForAuthenticationChallenge_ = "useCredential:forAuthenticationChallenge:";

	private static readonly IntPtr selUseCredential_ForAuthenticationChallenge_Handle = Selector.GetHandle("useCredential:forAuthenticationChallenge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLConnection");

	public override IntPtr ClassHandle => class_ptr;

	public unsafe static NSData SendSynchronousRequest(NSUrlRequest request, out NSUrlResponse response, out NSError error)
	{
		IntPtr zero = IntPtr.Zero;
		IntPtr zero2 = IntPtr.Zero;
		void* ptr = &zero;
		void* ptr2 = &zero2;
		IntPtr arg = (IntPtr)ptr;
		IntPtr arg2 = (IntPtr)ptr2;
		IntPtr ptr3 = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, Selector.GetHandle("sendSynchronousRequest:returningResponse:error:"), request.Handle, arg, arg2);
		if (zero != IntPtr.Zero)
		{
			response = (NSUrlResponse)Runtime.GetNSObject(zero);
		}
		else
		{
			response = null;
		}
		if (zero2 != IntPtr.Zero)
		{
			error = (NSError)Runtime.GetNSObject(zero2);
		}
		else
		{
			error = null;
		}
		return (NSData)Runtime.GetNSObject(ptr3);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlConnection()
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
	protected NSUrlConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRequest:delegate:")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlSession' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSUrlSession' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlConnection(NSUrlRequest request, INSUrlConnectionDelegate connectionDelegate)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (connectionDelegate != null)
		{
			if (!(connectionDelegate is NSObject))
			{
				throw new ArgumentException("The object passed of type " + connectionDelegate.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRequest_Delegate_Handle, request.Handle, connectionDelegate.Handle), "initWithRequest:delegate:");
			}
			else
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRequest_Delegate_Handle, request.Handle, connectionDelegate.Handle), "initWithRequest:delegate:");
			}
			return;
		}
		throw new ArgumentNullException("connectionDelegate");
	}

	[Export("initWithRequest:delegate:startImmediately:")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlSession' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSUrlSession' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlConnection(NSUrlRequest request, INSUrlConnectionDelegate connectionDelegate, bool startImmediately)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (connectionDelegate != null)
		{
			if (!(connectionDelegate is NSObject))
			{
				throw new ArgumentException("The object passed of type " + connectionDelegate.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selInitWithRequest_Delegate_StartImmediately_Handle, request.Handle, connectionDelegate.Handle, startImmediately), "initWithRequest:delegate:startImmediately:");
			}
			else
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithRequest_Delegate_StartImmediately_Handle, request.Handle, connectionDelegate.Handle, startImmediately), "initWithRequest:delegate:startImmediately:");
			}
			return;
		}
		throw new ArgumentNullException("connectionDelegate");
	}

	[Export("canHandleRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanHandleRequest(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanHandleRequest_Handle, request.Handle);
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

	[Export("cancelAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelAuthenticationChallenge(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelAuthenticationChallenge_Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelAuthenticationChallenge_Handle, challenge.Handle);
		}
	}

	[Export("continueWithoutCredentialForAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ContinueWithoutCredential(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selContinueWithoutCredentialForAuthenticationChallenge_Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selContinueWithoutCredentialForAuthenticationChallenge_Handle, challenge.Handle);
		}
	}

	[Export("connectionWithRequest:delegate:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlSession' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSUrlSession' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlConnection FromRequest(NSUrlRequest request, INSUrlConnectionDelegate connectionDelegate)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (connectionDelegate != null)
		{
			if (!(connectionDelegate is NSObject))
			{
				throw new ArgumentException("The object passed of type " + connectionDelegate.GetType()?.ToString() + " does not derive from NSObject");
			}
			return Runtime.GetNSObject<NSUrlConnection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selConnectionWithRequest_Delegate_Handle, request.Handle, connectionDelegate.Handle));
		}
		throw new ArgumentNullException("connectionDelegate");
	}

	[Export("performDefaultHandlingForAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformDefaultHandling(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformDefaultHandlingForAuthenticationChallenge_Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformDefaultHandlingForAuthenticationChallenge_Handle, challenge.Handle);
		}
	}

	[Export("rejectProtectionSpaceAndContinueWithChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RejectProtectionSpaceAndContinue(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRejectProtectionSpaceAndContinueWithChallenge_Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRejectProtectionSpaceAndContinueWithChallenge_Handle, challenge.Handle);
		}
	}

	[Export("scheduleInRunLoop:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Schedule(NSRunLoop aRunLoop, NSString forMode)
	{
		if (aRunLoop == null)
		{
			throw new ArgumentNullException("aRunLoop");
		}
		if (forMode == null)
		{
			throw new ArgumentNullException("forMode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selScheduleInRunLoop_ForMode_Handle, aRunLoop.Handle, forMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScheduleInRunLoop_ForMode_Handle, aRunLoop.Handle, forMode.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Schedule(NSRunLoop aRunLoop, NSRunLoopMode forMode)
	{
		Schedule(aRunLoop, forMode.GetConstant());
	}

	[Export("sendAsynchronousRequest:queue:completionHandler:")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlSession.CreateDataTask' instead.")]
	[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlSession.CreateDataTask' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSUrlSession.CreateDataTask' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void SendAsynchronousRequest(NSUrlRequest request, NSOperationQueue queue, [BlockProxy(typeof(Trampolines.NIDNSUrlConnectionDataResponse))] NSUrlConnectionDataResponse completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlConnectionDataResponse.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSendAsynchronousRequest_Queue_CompletionHandler_Handle, request.Handle, queue.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlSession.CreateDataTask' instead.")]
	[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlSession.CreateDataTask' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSUrlSession.CreateDataTask' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSUrlAsyncResult> SendRequestAsync(NSUrlRequest request, NSOperationQueue queue)
	{
		TaskCompletionSource<NSUrlAsyncResult> tcs = new TaskCompletionSource<NSUrlAsyncResult>();
		SendAsynchronousRequest(request, queue, delegate(NSUrlResponse response_, NSData data_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlAsyncResult(response_, data_));
			}
		});
		return tcs.Task;
	}

	[Export("setDelegateQueue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDelegateQueue(NSOperationQueue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegateQueue_Handle, queue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegateQueue_Handle, queue.Handle);
		}
	}

	[Export("start")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Start()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartHandle);
		}
	}

	[Export("unscheduleFromRunLoop:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Unschedule(NSRunLoop aRunLoop, NSString forMode)
	{
		if (aRunLoop == null)
		{
			throw new ArgumentNullException("aRunLoop");
		}
		if (forMode == null)
		{
			throw new ArgumentNullException("forMode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUnscheduleFromRunLoop_ForMode_Handle, aRunLoop.Handle, forMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUnscheduleFromRunLoop_ForMode_Handle, aRunLoop.Handle, forMode.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Unschedule(NSRunLoop aRunLoop, NSRunLoopMode forMode)
	{
		Unschedule(aRunLoop, forMode.GetConstant());
	}

	[Export("useCredential:forAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UseCredential(NSUrlCredential credential, NSUrlAuthenticationChallenge challenge)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUseCredential_ForAuthenticationChallenge_Handle, credential.Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUseCredential_ForAuthenticationChallenge_Handle, credential.Handle, challenge.Handle);
		}
	}
}
