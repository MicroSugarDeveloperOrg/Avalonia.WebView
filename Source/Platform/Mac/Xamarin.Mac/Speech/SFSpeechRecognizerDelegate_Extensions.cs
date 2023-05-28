using System;
using ObjCRuntime;

namespace Speech;

public static class SFSpeechRecognizerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AvailabilityDidChange(this ISFSpeechRecognizerDelegate This, SFSpeechRecognizer speechRecognizer, bool available)
	{
		if (speechRecognizer == null)
		{
			throw new ArgumentNullException("speechRecognizer");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("speechRecognizer:availabilityDidChange:"), speechRecognizer.Handle, available);
	}
}
