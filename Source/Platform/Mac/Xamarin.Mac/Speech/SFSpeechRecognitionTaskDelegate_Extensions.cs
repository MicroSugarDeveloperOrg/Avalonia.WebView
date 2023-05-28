using System;
using ObjCRuntime;

namespace Speech;

public static class SFSpeechRecognitionTaskDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDetectSpeech(this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task)
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("speechRecognitionDidDetectSpeech:"), task.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidHypothesizeTranscription(this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, SFTranscription transcription)
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (transcription == null)
		{
			throw new ArgumentNullException("transcription");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechRecognitionTask:didHypothesizeTranscription:"), task.Handle, transcription.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishRecognition(this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, SFSpeechRecognitionResult recognitionResult)
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (recognitionResult == null)
		{
			throw new ArgumentNullException("recognitionResult");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechRecognitionTask:didFinishRecognition:"), task.Handle, recognitionResult.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FinishedReadingAudio(this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task)
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("speechRecognitionTaskFinishedReadingAudio:"), task.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WasCancelled(this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task)
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("speechRecognitionTaskWasCancelled:"), task.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishSuccessfully(this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, bool successfully)
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("speechRecognitionTask:didFinishSuccessfully:"), task.Handle, successfully);
	}
}
