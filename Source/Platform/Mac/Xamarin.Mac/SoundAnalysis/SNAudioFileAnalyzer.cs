using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

[Register("SNAudioFileAnalyzer", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class SNAudioFileAnalyzer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRequest_WithObserver_Error_ = "addRequest:withObserver:error:";

	private static readonly IntPtr selAddRequest_WithObserver_Error_Handle = Selector.GetHandle("addRequest:withObserver:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnalyze = "analyze";

	private static readonly IntPtr selAnalyzeHandle = Selector.GetHandle("analyze");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnalyzeWithCompletionHandler_ = "analyzeWithCompletionHandler:";

	private static readonly IntPtr selAnalyzeWithCompletionHandler_Handle = Selector.GetHandle("analyzeWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelAnalysis = "cancelAnalysis";

	private static readonly IntPtr selCancelAnalysisHandle = Selector.GetHandle("cancelAnalysis");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Error_ = "initWithURL:error:";

	private static readonly IntPtr selInitWithURL_Error_Handle = Selector.GetHandle("initWithURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllRequests = "removeAllRequests";

	private static readonly IntPtr selRemoveAllRequestsHandle = Selector.GetHandle("removeAllRequests");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRequest_ = "removeRequest:";

	private static readonly IntPtr selRemoveRequest_Handle = Selector.GetHandle("removeRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SNAudioFileAnalyzer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SNAudioFileAnalyzer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SNAudioFileAnalyzer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SNAudioFileAnalyzer(NSUrl url, out NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithURL_Error_Handle, url.Handle, ref arg), "initWithURL:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithURL_Error_Handle, url.Handle, ref arg), "initWithURL:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("addRequest:withObserver:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AddRequest(ISNRequest request, ISNResultsObserving observer, out NSError? error)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selAddRequest_WithObserver_Error_Handle, request.Handle, observer.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selAddRequest_WithObserver_Error_Handle, request.Handle, observer.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("analyze")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Analyze()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAnalyzeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAnalyzeHandle);
		}
	}

	[Export("analyzeWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Analyze([BlockProxy(typeof(Trampolines.NIDSNAudioFileAnalyzerAnalyzeHandler))] SNAudioFileAnalyzerAnalyzeHandler completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSNAudioFileAnalyzerAnalyzeHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAnalyzeWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnalyzeWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> AnalyzeAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Analyze(delegate(bool didReachEndOfFile_)
		{
			tcs.SetResult(didReachEndOfFile_);
		});
		return tcs.Task;
	}

	[Export("cancelAnalysis")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelAnalysis()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelAnalysisHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelAnalysisHandle);
		}
	}

	[Export("removeAllRequests")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllRequests()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllRequestsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllRequestsHandle);
		}
	}

	[Export("removeRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRequest(ISNRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveRequest_Handle, request.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveRequest_Handle, request.Handle);
		}
	}
}
