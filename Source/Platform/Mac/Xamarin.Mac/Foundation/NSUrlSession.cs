using System;
using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLSession", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class NSUrlSession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguration = "configuration";

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataTaskWithRequest_ = "dataTaskWithRequest:";

	private static readonly IntPtr selDataTaskWithRequest_Handle = Selector.GetHandle("dataTaskWithRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataTaskWithRequest_CompletionHandler_ = "dataTaskWithRequest:completionHandler:";

	private static readonly IntPtr selDataTaskWithRequest_CompletionHandler_Handle = Selector.GetHandle("dataTaskWithRequest:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataTaskWithURL_ = "dataTaskWithURL:";

	private static readonly IntPtr selDataTaskWithURL_Handle = Selector.GetHandle("dataTaskWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataTaskWithURL_CompletionHandler_ = "dataTaskWithURL:completionHandler:";

	private static readonly IntPtr selDataTaskWithURL_CompletionHandler_Handle = Selector.GetHandle("dataTaskWithURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegateQueue = "delegateQueue";

	private static readonly IntPtr selDelegateQueueHandle = Selector.GetHandle("delegateQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadTaskWithRequest_ = "downloadTaskWithRequest:";

	private static readonly IntPtr selDownloadTaskWithRequest_Handle = Selector.GetHandle("downloadTaskWithRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadTaskWithRequest_CompletionHandler_ = "downloadTaskWithRequest:completionHandler:";

	private static readonly IntPtr selDownloadTaskWithRequest_CompletionHandler_Handle = Selector.GetHandle("downloadTaskWithRequest:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadTaskWithResumeData_ = "downloadTaskWithResumeData:";

	private static readonly IntPtr selDownloadTaskWithResumeData_Handle = Selector.GetHandle("downloadTaskWithResumeData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadTaskWithResumeData_CompletionHandler_ = "downloadTaskWithResumeData:completionHandler:";

	private static readonly IntPtr selDownloadTaskWithResumeData_CompletionHandler_Handle = Selector.GetHandle("downloadTaskWithResumeData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadTaskWithURL_ = "downloadTaskWithURL:";

	private static readonly IntPtr selDownloadTaskWithURL_Handle = Selector.GetHandle("downloadTaskWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadTaskWithURL_CompletionHandler_ = "downloadTaskWithURL:completionHandler:";

	private static readonly IntPtr selDownloadTaskWithURL_CompletionHandler_Handle = Selector.GetHandle("downloadTaskWithURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishTasksAndInvalidate = "finishTasksAndInvalidate";

	private static readonly IntPtr selFinishTasksAndInvalidateHandle = Selector.GetHandle("finishTasksAndInvalidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlushWithCompletionHandler_ = "flushWithCompletionHandler:";

	private static readonly IntPtr selFlushWithCompletionHandler_Handle = Selector.GetHandle("flushWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAllTasksWithCompletionHandler_ = "getAllTasksWithCompletionHandler:";

	private static readonly IntPtr selGetAllTasksWithCompletionHandler_Handle = Selector.GetHandle("getAllTasksWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetTasksWithCompletionHandler_ = "getTasksWithCompletionHandler:";

	private static readonly IntPtr selGetTasksWithCompletionHandler_Handle = Selector.GetHandle("getTasksWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateAndCancel = "invalidateAndCancel";

	private static readonly IntPtr selInvalidateAndCancelHandle = Selector.GetHandle("invalidateAndCancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithCompletionHandler_ = "resetWithCompletionHandler:";

	private static readonly IntPtr selResetWithCompletionHandler_Handle = Selector.GetHandle("resetWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSessionDescription = "sessionDescription";

	private static readonly IntPtr selSessionDescriptionHandle = Selector.GetHandle("sessionDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSessionWithConfiguration_ = "sessionWithConfiguration:";

	private static readonly IntPtr selSessionWithConfiguration_Handle = Selector.GetHandle("sessionWithConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSessionWithConfiguration_Delegate_DelegateQueue_ = "sessionWithConfiguration:delegate:delegateQueue:";

	private static readonly IntPtr selSessionWithConfiguration_Delegate_DelegateQueue_Handle = Selector.GetHandle("sessionWithConfiguration:delegate:delegateQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSessionDescription_ = "setSessionDescription:";

	private static readonly IntPtr selSetSessionDescription_Handle = Selector.GetHandle("setSessionDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedSession = "sharedSession";

	private static readonly IntPtr selSharedSessionHandle = Selector.GetHandle("sharedSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStreamTaskWithHostName_Port_ = "streamTaskWithHostName:port:";

	private static readonly IntPtr selStreamTaskWithHostName_Port_Handle = Selector.GetHandle("streamTaskWithHostName:port:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStreamTaskWithNetService_ = "streamTaskWithNetService:";

	private static readonly IntPtr selStreamTaskWithNetService_Handle = Selector.GetHandle("streamTaskWithNetService:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUploadTaskWithRequest_FromData_ = "uploadTaskWithRequest:fromData:";

	private static readonly IntPtr selUploadTaskWithRequest_FromData_Handle = Selector.GetHandle("uploadTaskWithRequest:fromData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUploadTaskWithRequest_FromData_CompletionHandler_ = "uploadTaskWithRequest:fromData:completionHandler:";

	private static readonly IntPtr selUploadTaskWithRequest_FromData_CompletionHandler_Handle = Selector.GetHandle("uploadTaskWithRequest:fromData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUploadTaskWithRequest_FromFile_ = "uploadTaskWithRequest:fromFile:";

	private static readonly IntPtr selUploadTaskWithRequest_FromFile_Handle = Selector.GetHandle("uploadTaskWithRequest:fromFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUploadTaskWithRequest_FromFile_CompletionHandler_ = "uploadTaskWithRequest:fromFile:completionHandler:";

	private static readonly IntPtr selUploadTaskWithRequest_FromFile_CompletionHandler_Handle = Selector.GetHandle("uploadTaskWithRequest:fromFile:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUploadTaskWithStreamedRequest_ = "uploadTaskWithStreamedRequest:";

	private static readonly IntPtr selUploadTaskWithStreamedRequest_Handle = Selector.GetHandle("uploadTaskWithStreamedRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebSocketTaskWithRequest_ = "webSocketTaskWithRequest:";

	private static readonly IntPtr selWebSocketTaskWithRequest_Handle = Selector.GetHandle("webSocketTaskWithRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebSocketTaskWithURL_ = "webSocketTaskWithURL:";

	private static readonly IntPtr selWebSocketTaskWithURL_Handle = Selector.GetHandle("webSocketTaskWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebSocketTaskWithURL_Protocols_ = "webSocketTaskWithURL:protocols:";

	private static readonly IntPtr selWebSocketTaskWithURL_Protocols_Handle = Selector.GetHandle("webSocketTaskWithURL:protocols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLSession");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionConfiguration Configuration
	{
		[Export("configuration", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlSessionConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationHandle));
			}
			return Runtime.GetNSObject<NSUrlSessionConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSUrlSessionDelegate Delegate => WeakDelegate as INSUrlSessionDelegate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOperationQueue DelegateQueue
	{
		[Export("delegateQueue", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateQueueHandle));
			}
			return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateQueueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SessionDescription
	{
		[Export("sessionDescription", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSessionDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSessionDescriptionHandle));
		}
		[Export("setSessionDescription:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSessionDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSessionDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlSession SharedSession
	{
		[Export("sharedSession", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSUrlSession>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedSessionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("streamTaskWithHostName:port:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionStreamTask CreateBidirectionalStream(string hostname, nint port)
	{
		if (hostname == null)
		{
			throw new ArgumentNullException("hostname");
		}
		IntPtr arg = NSString.CreateNative(hostname);
		NSUrlSessionStreamTask result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrlSessionStreamTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selStreamTaskWithHostName_Port_Handle, arg, port)) : Runtime.GetNSObject<NSUrlSessionStreamTask>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(base.Handle, selStreamTaskWithHostName_Port_Handle, arg, port)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("streamTaskWithNetService:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionStreamTask CreateBidirectionalStream(NSNetService service)
	{
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrlSessionStreamTask>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStreamTaskWithNetService_Handle, service.Handle));
		}
		return Runtime.GetNSObject<NSUrlSessionStreamTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStreamTaskWithNetService_Handle, service.Handle));
	}

	[Export("dataTaskWithRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionDataTask CreateDataTask(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<NSUrlSessionDataTask>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataTaskWithRequest_Handle, request.Handle), forced_type: true, owns: false);
		}
		return Runtime.GetINativeObject<NSUrlSessionDataTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataTaskWithRequest_Handle, request.Handle), forced_type: true, owns: false);
	}

	[Export("dataTaskWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionDataTask CreateDataTask(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<NSUrlSessionDataTask>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataTaskWithURL_Handle, url.Handle), forced_type: true, owns: false);
		}
		return Runtime.GetINativeObject<NSUrlSessionDataTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataTaskWithURL_Handle, url.Handle), forced_type: true, owns: false);
	}

	[Export("dataTaskWithRequest:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSUrlSessionDataTask CreateDataTask(NSUrlRequest request, [BlockProxy(typeof(Trampolines.NIDNSUrlSessionResponse))] NSUrlSessionResponse? completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlSessionResponse.Handler, completionHandler);
		}
		NSUrlSessionDataTask result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<NSUrlSessionDataTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDataTaskWithRequest_CompletionHandler_Handle, request.Handle, (IntPtr)ptr), forced_type: true, owns: false) : Runtime.GetINativeObject<NSUrlSessionDataTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDataTaskWithRequest_CompletionHandler_Handle, request.Handle, (IntPtr)ptr), forced_type: true, owns: false));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDataTaskRequest> CreateDataTaskAsync(NSUrlRequest request)
	{
		TaskCompletionSource<NSUrlSessionDataTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDataTaskRequest>();
		NSUrlSessionDataTask nSUrlSessionDataTask = CreateDataTask(request, delegate(NSData data_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDataTaskRequest(data_, response_));
			}
		});
		nSUrlSessionDataTask.Resume();
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDataTaskRequest> CreateDataTaskAsync(NSUrlRequest request, out NSUrlSessionDataTask result)
	{
		TaskCompletionSource<NSUrlSessionDataTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDataTaskRequest>();
		result = CreateDataTask(request, delegate(NSData data_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDataTaskRequest(data_, response_));
			}
		});
		return tcs.Task;
	}

	[Export("dataTaskWithURL:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSUrlSessionDataTask CreateDataTask(NSUrl url, [BlockProxy(typeof(Trampolines.NIDNSUrlSessionResponse))] NSUrlSessionResponse? completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlSessionResponse.Handler, completionHandler);
		}
		NSUrlSessionDataTask result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<NSUrlSessionDataTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDataTaskWithURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr), forced_type: true, owns: false) : Runtime.GetINativeObject<NSUrlSessionDataTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDataTaskWithURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr), forced_type: true, owns: false));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDataTaskRequest> CreateDataTaskAsync(NSUrl url)
	{
		TaskCompletionSource<NSUrlSessionDataTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDataTaskRequest>();
		NSUrlSessionDataTask nSUrlSessionDataTask = CreateDataTask(url, delegate(NSData data_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDataTaskRequest(data_, response_));
			}
		});
		nSUrlSessionDataTask.Resume();
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDataTaskRequest> CreateDataTaskAsync(NSUrl url, out NSUrlSessionDataTask result)
	{
		TaskCompletionSource<NSUrlSessionDataTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDataTaskRequest>();
		result = CreateDataTask(url, delegate(NSData data_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDataTaskRequest(data_, response_));
			}
		});
		return tcs.Task;
	}

	[Export("downloadTaskWithRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionDownloadTask CreateDownloadTask(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDownloadTaskWithRequest_Handle, request.Handle), forced_type: true, owns: false);
		}
		return Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDownloadTaskWithRequest_Handle, request.Handle), forced_type: true, owns: false);
	}

	[Export("downloadTaskWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionDownloadTask CreateDownloadTask(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDownloadTaskWithURL_Handle, url.Handle), forced_type: true, owns: false);
		}
		return Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDownloadTaskWithURL_Handle, url.Handle), forced_type: true, owns: false);
	}

	[Export("downloadTaskWithResumeData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionDownloadTask CreateDownloadTask(NSData resumeData)
	{
		if (resumeData == null)
		{
			throw new ArgumentNullException("resumeData");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDownloadTaskWithResumeData_Handle, resumeData.Handle), forced_type: true, owns: false);
		}
		return Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDownloadTaskWithResumeData_Handle, resumeData.Handle), forced_type: true, owns: false);
	}

	[Export("downloadTaskWithRequest:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSUrlSessionDownloadTask CreateDownloadTask(NSUrlRequest request, [BlockProxy(typeof(Trampolines.NIDNSUrlDownloadSessionResponse))] NSUrlDownloadSessionResponse? completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlDownloadSessionResponse.Handler, completionHandler);
		}
		NSUrlSessionDownloadTask result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDownloadTaskWithRequest_CompletionHandler_Handle, request.Handle, (IntPtr)ptr), forced_type: true, owns: false) : Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDownloadTaskWithRequest_CompletionHandler_Handle, request.Handle, (IntPtr)ptr), forced_type: true, owns: false));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDownloadTaskRequest> CreateDownloadTaskAsync(NSUrlRequest request)
	{
		TaskCompletionSource<NSUrlSessionDownloadTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDownloadTaskRequest>();
		NSUrlSessionDownloadTask nSUrlSessionDownloadTask = CreateDownloadTask(request, delegate(NSUrl location_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDownloadTaskRequest(location_, response_));
			}
		});
		nSUrlSessionDownloadTask.Resume();
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDownloadTaskRequest> CreateDownloadTaskAsync(NSUrlRequest request, out NSUrlSessionDownloadTask result)
	{
		TaskCompletionSource<NSUrlSessionDownloadTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDownloadTaskRequest>();
		result = CreateDownloadTask(request, delegate(NSUrl location_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDownloadTaskRequest(location_, response_));
			}
		});
		return tcs.Task;
	}

	[Export("downloadTaskWithURL:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSUrlSessionDownloadTask CreateDownloadTask(NSUrl url, [BlockProxy(typeof(Trampolines.NIDNSUrlDownloadSessionResponse))] NSUrlDownloadSessionResponse? completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlDownloadSessionResponse.Handler, completionHandler);
		}
		NSUrlSessionDownloadTask result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDownloadTaskWithURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr), forced_type: true, owns: false) : Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDownloadTaskWithURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr), forced_type: true, owns: false));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDownloadTaskRequest> CreateDownloadTaskAsync(NSUrl url)
	{
		TaskCompletionSource<NSUrlSessionDownloadTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDownloadTaskRequest>();
		NSUrlSessionDownloadTask nSUrlSessionDownloadTask = CreateDownloadTask(url, delegate(NSUrl location_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDownloadTaskRequest(location_, response_));
			}
		});
		nSUrlSessionDownloadTask.Resume();
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDownloadTaskRequest> CreateDownloadTaskAsync(NSUrl url, out NSUrlSessionDownloadTask result)
	{
		TaskCompletionSource<NSUrlSessionDownloadTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDownloadTaskRequest>();
		result = CreateDownloadTask(url, delegate(NSUrl location_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDownloadTaskRequest(location_, response_));
			}
		});
		return tcs.Task;
	}

	[Export("downloadTaskWithResumeData:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSUrlSessionDownloadTask CreateDownloadTaskFromResumeData(NSData resumeData, [BlockProxy(typeof(Trampolines.NIDNSUrlDownloadSessionResponse))] NSUrlDownloadSessionResponse? completionHandler)
	{
		if (resumeData == null)
		{
			throw new ArgumentNullException("resumeData");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlDownloadSessionResponse.Handler, completionHandler);
		}
		NSUrlSessionDownloadTask result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDownloadTaskWithResumeData_CompletionHandler_Handle, resumeData.Handle, (IntPtr)ptr), forced_type: true, owns: false) : Runtime.GetINativeObject<NSUrlSessionDownloadTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDownloadTaskWithResumeData_CompletionHandler_Handle, resumeData.Handle, (IntPtr)ptr), forced_type: true, owns: false));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDownloadTaskRequest> CreateDownloadTaskFromResumeDataAsync(NSData resumeData)
	{
		TaskCompletionSource<NSUrlSessionDownloadTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDownloadTaskRequest>();
		NSUrlSessionDownloadTask nSUrlSessionDownloadTask = CreateDownloadTaskFromResumeData(resumeData, delegate(NSUrl location_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDownloadTaskRequest(location_, response_));
			}
		});
		nSUrlSessionDownloadTask.Resume();
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDownloadTaskRequest> CreateDownloadTaskFromResumeDataAsync(NSData resumeData, out NSUrlSessionDownloadTask result)
	{
		TaskCompletionSource<NSUrlSessionDownloadTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDownloadTaskRequest>();
		result = CreateDownloadTaskFromResumeData(resumeData, delegate(NSUrl location_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDownloadTaskRequest(location_, response_));
			}
		});
		return tcs.Task;
	}

	[Export("uploadTaskWithRequest:fromFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionUploadTask CreateUploadTask(NSUrlRequest request, NSUrl fileURL)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (fileURL == null)
		{
			throw new ArgumentNullException("fileURL");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selUploadTaskWithRequest_FromFile_Handle, request.Handle, fileURL.Handle), forced_type: true, owns: false);
		}
		return Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUploadTaskWithRequest_FromFile_Handle, request.Handle, fileURL.Handle), forced_type: true, owns: false);
	}

	[Export("uploadTaskWithRequest:fromData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionUploadTask CreateUploadTask(NSUrlRequest request, NSData bodyData)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (bodyData == null)
		{
			throw new ArgumentNullException("bodyData");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selUploadTaskWithRequest_FromData_Handle, request.Handle, bodyData.Handle), forced_type: true, owns: false);
		}
		return Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUploadTaskWithRequest_FromData_Handle, request.Handle, bodyData.Handle), forced_type: true, owns: false);
	}

	[Export("uploadTaskWithStreamedRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionUploadTask CreateUploadTask(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUploadTaskWithStreamedRequest_Handle, request.Handle), forced_type: true, owns: false);
		}
		return Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUploadTaskWithStreamedRequest_Handle, request.Handle), forced_type: true, owns: false);
	}

	[Export("uploadTaskWithRequest:fromFile:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSUrlSessionUploadTask CreateUploadTask(NSUrlRequest request, NSUrl fileURL, [BlockProxy(typeof(Trampolines.NIDNSUrlSessionResponse))] NSUrlSessionResponse completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (fileURL == null)
		{
			throw new ArgumentNullException("fileURL");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlSessionResponse.Handler, completionHandler);
		NSUrlSessionUploadTask result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selUploadTaskWithRequest_FromFile_CompletionHandler_Handle, request.Handle, fileURL.Handle, (IntPtr)ptr), forced_type: true, owns: false) : Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selUploadTaskWithRequest_FromFile_CompletionHandler_Handle, request.Handle, fileURL.Handle, (IntPtr)ptr), forced_type: true, owns: false));
		ptr->CleanupBlock();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDataTaskRequest> CreateUploadTaskAsync(NSUrlRequest request, NSUrl fileURL)
	{
		TaskCompletionSource<NSUrlSessionDataTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDataTaskRequest>();
		NSUrlSessionUploadTask nSUrlSessionUploadTask = CreateUploadTask(request, fileURL, delegate(NSData data_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDataTaskRequest(data_, response_));
			}
		});
		nSUrlSessionUploadTask.Resume();
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDataTaskRequest> CreateUploadTaskAsync(NSUrlRequest request, NSUrl fileURL, out NSUrlSessionUploadTask result)
	{
		TaskCompletionSource<NSUrlSessionDataTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDataTaskRequest>();
		result = CreateUploadTask(request, fileURL, delegate(NSData data_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDataTaskRequest(data_, response_));
			}
		});
		return tcs.Task;
	}

	[Export("uploadTaskWithRequest:fromData:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSUrlSessionUploadTask CreateUploadTask(NSUrlRequest request, NSData bodyData, [BlockProxy(typeof(Trampolines.NIDNSUrlSessionResponse))] NSUrlSessionResponse completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (bodyData == null)
		{
			throw new ArgumentNullException("bodyData");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlSessionResponse.Handler, completionHandler);
		NSUrlSessionUploadTask result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selUploadTaskWithRequest_FromData_CompletionHandler_Handle, request.Handle, bodyData.Handle, (IntPtr)ptr), forced_type: true, owns: false) : Runtime.GetINativeObject<NSUrlSessionUploadTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selUploadTaskWithRequest_FromData_CompletionHandler_Handle, request.Handle, bodyData.Handle, (IntPtr)ptr), forced_type: true, owns: false));
		ptr->CleanupBlock();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDataTaskRequest> CreateUploadTaskAsync(NSUrlRequest request, NSData bodyData)
	{
		TaskCompletionSource<NSUrlSessionDataTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDataTaskRequest>();
		NSUrlSessionUploadTask nSUrlSessionUploadTask = CreateUploadTask(request, bodyData, delegate(NSData data_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDataTaskRequest(data_, response_));
			}
		});
		nSUrlSessionUploadTask.Resume();
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionDataTaskRequest> CreateUploadTaskAsync(NSUrlRequest request, NSData bodyData, out NSUrlSessionUploadTask result)
	{
		TaskCompletionSource<NSUrlSessionDataTaskRequest> tcs = new TaskCompletionSource<NSUrlSessionDataTaskRequest>();
		result = CreateUploadTask(request, bodyData, delegate(NSData data_, NSUrlResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionDataTaskRequest(data_, response_));
			}
		});
		return tcs.Task;
	}

	[Export("webSocketTaskWithURL:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionWebSocketTask CreateWebSocketTask(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrlSessionWebSocketTask>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWebSocketTaskWithURL_Handle, url.Handle));
		}
		return Runtime.GetNSObject<NSUrlSessionWebSocketTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWebSocketTaskWithURL_Handle, url.Handle));
	}

	[Export("webSocketTaskWithURL:protocols:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionWebSocketTask CreateWebSocketTask(NSUrl url, string[] protocols)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (protocols == null)
		{
			throw new ArgumentNullException("protocols");
		}
		NSArray nSArray = NSArray.FromStrings(protocols);
		NSUrlSessionWebSocketTask result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrlSessionWebSocketTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWebSocketTaskWithURL_Protocols_Handle, url.Handle, nSArray.Handle)) : Runtime.GetNSObject<NSUrlSessionWebSocketTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selWebSocketTaskWithURL_Protocols_Handle, url.Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("webSocketTaskWithRequest:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionWebSocketTask CreateWebSocketTask(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrlSessionWebSocketTask>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWebSocketTaskWithRequest_Handle, request.Handle));
		}
		return Runtime.GetNSObject<NSUrlSessionWebSocketTask>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWebSocketTaskWithRequest_Handle, request.Handle));
	}

	[Export("finishTasksAndInvalidate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishTasksAndInvalidate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinishTasksAndInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinishTasksAndInvalidateHandle);
		}
	}

	[Export("flushWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Flush([BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlushWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlushWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task FlushAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Flush(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("sessionWithConfiguration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlSession FromConfiguration(NSUrlSessionConfiguration configuration)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		return Runtime.GetNSObject<NSUrlSession>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSessionWithConfiguration_Handle, configuration.Handle));
	}

	[Obsolete("Use the overload with a 'INSUrlSessionDelegate' parameter.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlSession FromConfiguration(NSUrlSessionConfiguration configuration, NSUrlSessionDelegate sessionDelegate, NSOperationQueue delegateQueue)
	{
		return FromWeakConfiguration(configuration, sessionDelegate, delegateQueue);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlSession FromConfiguration(NSUrlSessionConfiguration configuration, INSUrlSessionDelegate sessionDelegate, NSOperationQueue delegateQueue)
	{
		return FromWeakConfiguration(configuration, (NSObject)sessionDelegate, delegateQueue);
	}

	[Export("sessionWithConfiguration:delegate:delegateQueue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlSession FromWeakConfiguration(NSUrlSessionConfiguration configuration, NSObject? weakDelegate, NSOperationQueue? delegateQueue)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		return Runtime.GetNSObject<NSUrlSession>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSessionWithConfiguration_Delegate_DelegateQueue_Handle, configuration.Handle, weakDelegate?.Handle ?? IntPtr.Zero, delegateQueue?.Handle ?? IntPtr.Zero));
	}

	[Export("getAllTasksWithCompletionHandler:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetAllTasks([BlockProxy(typeof(Trampolines.NIDNSUrlSessionAllPendingTasks))] NSUrlSessionAllPendingTasks completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlSessionAllPendingTasks.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetAllTasksWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetAllTasksWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionTask[]> GetAllTasksAsync()
	{
		TaskCompletionSource<NSUrlSessionTask[]> tcs = new TaskCompletionSource<NSUrlSessionTask[]>();
		GetAllTasks(delegate(NSUrlSessionTask[] tasks_)
		{
			tcs.SetResult(tasks_);
		});
		return tcs.Task;
	}

	[Export("getTasksWithCompletionHandler:")]
	[Obsolete("Use GetTasks2 instead. This method may throw spurious InvalidCastExceptions, in particular for backgrounded tasks.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetTasks([BlockProxy(typeof(Trampolines.NIDNSUrlSessionPendingTasks))] NSUrlSessionPendingTasks completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlSessionPendingTasks.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetTasksWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetTasksWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Obsolete("Use GetTasks2 instead. This method may throw spurious InvalidCastExceptions, in particular for backgrounded tasks.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionActiveTasks> GetTasksAsync()
	{
		TaskCompletionSource<NSUrlSessionActiveTasks> tcs = new TaskCompletionSource<NSUrlSessionActiveTasks>();
		GetTasks(delegate(NSUrlSessionDataTask[] dataTasks_, NSUrlSessionUploadTask[] uploadTasks_, NSUrlSessionDownloadTask[] downloadTasks_)
		{
			tcs.SetResult(new NSUrlSessionActiveTasks(dataTasks_, uploadTasks_, downloadTasks_));
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void GetTasks2([BlockProxy(typeof(Trampolines.NIDNSUrlSessionPendingTasks2))] NSUrlSessionPendingTasks2 completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlSessionPendingTasks2.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetTasksWithCompletionHandler_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<NSUrlSessionActiveTasks2> GetTasks2Async()
	{
		TaskCompletionSource<NSUrlSessionActiveTasks2> tcs = new TaskCompletionSource<NSUrlSessionActiveTasks2>();
		GetTasks2(delegate(NSUrlSessionTask[] dataTasks_, NSUrlSessionTask[] uploadTasks_, NSUrlSessionTask[] downloadTasks_)
		{
			tcs.SetResult(new NSUrlSessionActiveTasks2(dataTasks_, uploadTasks_, downloadTasks_));
		});
		return tcs.Task;
	}

	[Export("invalidateAndCancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateAndCancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateAndCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateAndCancelHandle);
		}
	}

	[Export("resetWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Reset([BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResetWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResetWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ResetAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Reset(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}
}
