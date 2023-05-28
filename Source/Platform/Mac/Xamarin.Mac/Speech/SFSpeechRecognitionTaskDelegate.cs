using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Speech;

[Protocol]
[Register("SFSpeechRecognitionTaskDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class SFSpeechRecognitionTaskDelegate : NSObject, ISFSpeechRecognitionTaskDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SFSpeechRecognitionTaskDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SFSpeechRecognitionTaskDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SFSpeechRecognitionTaskDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("speechRecognitionDidDetectSpeech:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDetectSpeech(SFSpeechRecognitionTask task)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechRecognitionTask:didFinishRecognition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishRecognition(SFSpeechRecognitionTask task, SFSpeechRecognitionResult recognitionResult)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechRecognitionTask:didFinishSuccessfully:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishSuccessfully(SFSpeechRecognitionTask task, bool successfully)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechRecognitionTask:didHypothesizeTranscription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidHypothesizeTranscription(SFSpeechRecognitionTask task, SFTranscription transcription)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechRecognitionTaskFinishedReadingAudio:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishedReadingAudio(SFSpeechRecognitionTask task)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechRecognitionTaskWasCancelled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WasCancelled(SFSpeechRecognitionTask task)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
