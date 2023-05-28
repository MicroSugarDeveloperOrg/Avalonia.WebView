using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVSpeechSynthesizerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStartSpeechUtterance(this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		if (synthesizer == null)
		{
			throw new ArgumentNullException("synthesizer");
		}
		if (utterance == null)
		{
			throw new ArgumentNullException("utterance");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechSynthesizer:didStartSpeechUtterance:"), synthesizer.Handle, utterance.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishSpeechUtterance(this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		if (synthesizer == null)
		{
			throw new ArgumentNullException("synthesizer");
		}
		if (utterance == null)
		{
			throw new ArgumentNullException("utterance");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechSynthesizer:didFinishSpeechUtterance:"), synthesizer.Handle, utterance.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidPauseSpeechUtterance(this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		if (synthesizer == null)
		{
			throw new ArgumentNullException("synthesizer");
		}
		if (utterance == null)
		{
			throw new ArgumentNullException("utterance");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechSynthesizer:didPauseSpeechUtterance:"), synthesizer.Handle, utterance.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidContinueSpeechUtterance(this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		if (synthesizer == null)
		{
			throw new ArgumentNullException("synthesizer");
		}
		if (utterance == null)
		{
			throw new ArgumentNullException("utterance");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechSynthesizer:didContinueSpeechUtterance:"), synthesizer.Handle, utterance.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCancelSpeechUtterance(this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		if (synthesizer == null)
		{
			throw new ArgumentNullException("synthesizer");
		}
		if (utterance == null)
		{
			throw new ArgumentNullException("utterance");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechSynthesizer:didCancelSpeechUtterance:"), synthesizer.Handle, utterance.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillSpeakRangeOfSpeechString(this IAVSpeechSynthesizerDelegate This, AVSpeechSynthesizer synthesizer, NSRange characterRange, AVSpeechUtterance utterance)
	{
		if (synthesizer == null)
		{
			throw new ArgumentNullException("synthesizer");
		}
		if (utterance == null)
		{
			throw new ArgumentNullException("utterance");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange_IntPtr(This.Handle, Selector.GetHandle("speechSynthesizer:willSpeakRangeOfSpeechString:utterance:"), synthesizer.Handle, characterRange, utterance.Handle);
	}
}
