using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSSpeechSynthesizerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishSpeaking(this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, bool finishedSpeaking)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("speechSynthesizer:didFinishSpeaking:"), sender.Handle, finishedSpeaking);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillSpeakWord(this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, NSRange wordCharacterRange, string ofString)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (ofString == null)
		{
			throw new ArgumentNullException("ofString");
		}
		IntPtr intPtr = NSString.CreateNative(ofString);
		Messaging.void_objc_msgSend_IntPtr_NSRange_IntPtr(This.Handle, Selector.GetHandle("speechSynthesizer:willSpeakWord:ofString:"), sender.Handle, wordCharacterRange, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillSpeakPhoneme(this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, short phonemeOpcode)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_short(This.Handle, Selector.GetHandle("speechSynthesizer:willSpeakPhoneme:"), sender.Handle, phonemeOpcode);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEncounterError(this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, nuint characterIndex, string theString, string message)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (theString == null)
		{
			throw new ArgumentNullException("theString");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		IntPtr intPtr = NSString.CreateNative(theString);
		IntPtr intPtr2 = NSString.CreateNative(message);
		Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechSynthesizer:didEncounterErrorAtIndex:ofString:message:"), sender.Handle, characterIndex, intPtr, intPtr2);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEncounterSyncMessage(this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, string message)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		IntPtr intPtr = NSString.CreateNative(message);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechSynthesizer:didEncounterSyncMessage:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}
}
