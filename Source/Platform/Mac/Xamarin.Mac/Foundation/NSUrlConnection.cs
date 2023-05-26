using System;
using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLConnection", true)]
public class NSUrlConnection : NSObject
{
	private const string selSendSynchronousRequestReturningResponseError = "sendSynchronousRequest:returningResponse:error:";

	private static readonly IntPtr selCanHandleRequest_Handle = Selector.GetHandle("canHandleRequest:");

	private static readonly IntPtr selConnectionWithRequestDelegate_Handle = Selector.GetHandle("connectionWithRequest:delegate:");

	private static readonly IntPtr selInitWithRequestDelegate_Handle = Selector.GetHandle("initWithRequest:delegate:");

	private static readonly IntPtr selInitWithRequestDelegateStartImmediately_Handle = Selector.GetHandle("initWithRequest:delegate:startImmediately:");

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	private static readonly IntPtr selScheduleInRunLoopForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	private static readonly IntPtr selUnscheduleFromRunLoopForMode_Handle = Selector.GetHandle("unscheduleFromRunLoop:forMode:");

	private static readonly IntPtr selUseCredentialForAuthenticationChallenge_Handle = Selector.GetHandle("useCredential:forAuthenticationChallenge:");

	private static readonly IntPtr selContinueWithoutCredentialForAuthenticationChallenge_Handle = Selector.GetHandle("continueWithoutCredentialForAuthenticationChallenge:");

	private static readonly IntPtr selCancelAuthenticationChallenge_Handle = Selector.GetHandle("cancelAuthenticationChallenge:");

	private static readonly IntPtr selPerformDefaultHandlingForAuthenticationChallenge_Handle = Selector.GetHandle("performDefaultHandlingForAuthenticationChallenge:");

	private static readonly IntPtr selRejectProtectionSpaceAndContinueWithChallenge_Handle = Selector.GetHandle("rejectProtectionSpaceAndContinueWithChallenge:");

	private static readonly IntPtr selSetDelegateQueue_Handle = Selector.GetHandle("setDelegateQueue:");

	private static readonly IntPtr selSendAsynchronousRequestQueueCompletionHandler_Handle = Selector.GetHandle("sendAsynchronousRequest:queue:completionHandler:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLConnection");

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

	[Advice("Use Schedule (NSRunLoop, NSString) instead")]
	public virtual void Schedule(NSRunLoop aRunLoop, string forMode)
	{
		if (aRunLoop == null)
		{
			throw new ArgumentNullException("aRunLoop");
		}
		if (forMode == null)
		{
			throw new ArgumentNullException("forMode");
		}
		IntPtr arg = NSString.CreateNative(forMode);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selScheduleInRunLoopForMode_Handle, aRunLoop.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScheduleInRunLoopForMode_Handle, aRunLoop.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Advice("Use Unschedule (NSRunLoop, NSString) instead")]
	public virtual void Unschedule(NSRunLoop aRunLoop, string forMode)
	{
		if (aRunLoop == null)
		{
			throw new ArgumentNullException("aRunLoop");
		}
		if (forMode == null)
		{
			throw new ArgumentNullException("forMode");
		}
		IntPtr arg = NSString.CreateNative(forMode);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUnscheduleFromRunLoopForMode_Handle, aRunLoop.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUnscheduleFromRunLoopForMode_Handle, aRunLoop.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlConnection()
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
	public NSUrlConnection(NSCoder coder)
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
	public NSUrlConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canHandleRequest:")]
	public static bool CanHandleRequest(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanHandleRequest_Handle, request.Handle);
	}

	[Export("connectionWithRequest:delegate:")]
	public static NSUrlConnection FromRequest(NSUrlRequest request, NSUrlConnectionDelegate connectionDelegate)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (connectionDelegate == null)
		{
			throw new ArgumentNullException("connectionDelegate");
		}
		return (NSUrlConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selConnectionWithRequestDelegate_Handle, request.Handle, connectionDelegate.Handle));
	}

	[Export("initWithRequest:delegate:")]
	public NSUrlConnection(NSUrlRequest request, NSUrlConnectionDelegate connectionDelegate)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (connectionDelegate == null)
		{
			throw new ArgumentNullException("connectionDelegate");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRequestDelegate_Handle, request.Handle, connectionDelegate.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRequestDelegate_Handle, request.Handle, connectionDelegate.Handle);
		}
	}

	[Export("initWithRequest:delegate:startImmediately:")]
	public NSUrlConnection(NSUrlRequest request, NSUrlConnectionDelegate connectionDelegate, bool startImmediately)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (connectionDelegate == null)
		{
			throw new ArgumentNullException("connectionDelegate");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selInitWithRequestDelegateStartImmediately_Handle, request.Handle, connectionDelegate.Handle, startImmediately);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithRequestDelegateStartImmediately_Handle, request.Handle, connectionDelegate.Handle, startImmediately);
		}
	}

	[Export("start")]
	public virtual void Start()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartHandle);
		}
	}

	[Export("cancel")]
	public virtual void Cancel()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("scheduleInRunLoop:forMode:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selScheduleInRunLoopForMode_Handle, aRunLoop.Handle, forMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScheduleInRunLoopForMode_Handle, aRunLoop.Handle, forMode.Handle);
		}
	}

	[Export("unscheduleFromRunLoop:forMode:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUnscheduleFromRunLoopForMode_Handle, aRunLoop.Handle, forMode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUnscheduleFromRunLoopForMode_Handle, aRunLoop.Handle, forMode.Handle);
		}
	}

	[Export("useCredential:forAuthenticationChallenge:")]
	public virtual void UseCredentials(NSUrlCredential credential, NSUrlAuthenticationChallenge challenge)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUseCredentialForAuthenticationChallenge_Handle, credential.Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUseCredentialForAuthenticationChallenge_Handle, credential.Handle, challenge.Handle);
		}
	}

	[Export("continueWithoutCredentialForAuthenticationChallenge:")]
	public virtual void ContinueWithoutCredentialForAuthenticationChallenge(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selContinueWithoutCredentialForAuthenticationChallenge_Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selContinueWithoutCredentialForAuthenticationChallenge_Handle, challenge.Handle);
		}
	}

	[Export("cancelAuthenticationChallenge:")]
	public virtual void CancelAuthenticationChallenge(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelAuthenticationChallenge_Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelAuthenticationChallenge_Handle, challenge.Handle);
		}
	}

	[Export("performDefaultHandlingForAuthenticationChallenge:")]
	public virtual void PerformDefaultHandlingForChallenge(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformDefaultHandlingForAuthenticationChallenge_Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformDefaultHandlingForAuthenticationChallenge_Handle, challenge.Handle);
		}
	}

	[Export("rejectProtectionSpaceAndContinueWithChallenge:")]
	public virtual void RejectProtectionSpaceAndContinueWithChallenge(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRejectProtectionSpaceAndContinueWithChallenge_Handle, challenge.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRejectProtectionSpaceAndContinueWithChallenge_Handle, challenge.Handle);
		}
	}

	[Export("setDelegateQueue:")]
	public virtual void SetDelegateQueue(NSOperationQueue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegateQueue_Handle, queue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegateQueue_Handle, queue.Handle);
		}
	}

	[Export("sendAsynchronousRequest:queue:completionHandler:")]
	public unsafe static void SendAsynchronousRequest(NSUrlRequest request, NSOperationQueue queue, NSUrlConnectionDataResponse completionHandler)
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
		blockLiteral.SetupBlock(Trampolines.SDNSUrlConnectionDataResponse.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSendAsynchronousRequestQueueCompletionHandler_Handle, request.Handle, queue.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	public static Task<NSUrlAsyncResult> SendRequestAsync(NSUrlRequest request, NSOperationQueue queue)
	{
		TaskCompletionSource<NSUrlAsyncResult> tcs = new TaskCompletionSource<NSUrlAsyncResult>();
		SendAsynchronousRequest(request, queue, delegate(NSUrlResponse response, NSData data, NSError error)
		{
			if (error != null)
			{
				tcs.SetException(new NSErrorException(error));
			}
			else
			{
				tcs.SetResult(new NSUrlAsyncResult(response, data));
			}
		});
		return tcs.Task;
	}
}
