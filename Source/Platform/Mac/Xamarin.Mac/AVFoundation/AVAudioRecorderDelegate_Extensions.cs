using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVAudioRecorderDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FinishedRecording(this IAVAudioRecorderDelegate This, AVAudioRecorder recorder, bool flag)
	{
		if (recorder == null)
		{
			throw new ArgumentNullException("recorder");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("audioRecorderDidFinishRecording:successfully:"), recorder.Handle, flag);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EncoderError(this IAVAudioRecorderDelegate This, AVAudioRecorder recorder, NSError? error)
	{
		if (recorder == null)
		{
			throw new ArgumentNullException("recorder");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("audioRecorderEncodeErrorDidOccur:error:"), recorder.Handle, error?.Handle ?? IntPtr.Zero);
	}
}
