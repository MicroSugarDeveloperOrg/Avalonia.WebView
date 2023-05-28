using System;
using System.ComponentModel;
using AVFoundation;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

[Register("SNAudioStreamAnalyzer", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class SNAudioStreamAnalyzer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRequest_WithObserver_Error_ = "addRequest:withObserver:error:";

	private static readonly IntPtr selAddRequest_WithObserver_Error_Handle = Selector.GetHandle("addRequest:withObserver:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnalyzeAudioBuffer_AtAudioFramePosition_ = "analyzeAudioBuffer:atAudioFramePosition:";

	private static readonly IntPtr selAnalyzeAudioBuffer_AtAudioFramePosition_Handle = Selector.GetHandle("analyzeAudioBuffer:atAudioFramePosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompleteAnalysis = "completeAnalysis";

	private static readonly IntPtr selCompleteAnalysisHandle = Selector.GetHandle("completeAnalysis");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFormat_ = "initWithFormat:";

	private static readonly IntPtr selInitWithFormat_Handle = Selector.GetHandle("initWithFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllRequests = "removeAllRequests";

	private static readonly IntPtr selRemoveAllRequestsHandle = Selector.GetHandle("removeAllRequests");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRequest_ = "removeRequest:";

	private static readonly IntPtr selRemoveRequest_Handle = Selector.GetHandle("removeRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SNAudioStreamAnalyzer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SNAudioStreamAnalyzer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SNAudioStreamAnalyzer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFormat:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SNAudioStreamAnalyzer(AVAudioFormat format)
		: base(NSObjectFlag.Empty)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFormat_Handle, format.Handle), "initWithFormat:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFormat_Handle, format.Handle), "initWithFormat:");
		}
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

	[Export("analyzeAudioBuffer:atAudioFramePosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Analyze(AVAudioBuffer audioBuffer, long audioFramePosition)
	{
		if (audioBuffer == null)
		{
			throw new ArgumentNullException("audioBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAnalyzeAudioBuffer_AtAudioFramePosition_Handle, audioBuffer.Handle, audioFramePosition);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAnalyzeAudioBuffer_AtAudioFramePosition_Handle, audioBuffer.Handle, audioFramePosition);
		}
	}

	[Export("completeAnalysis")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CompleteAnalysis()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCompleteAnalysisHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCompleteAnalysisHandle);
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
