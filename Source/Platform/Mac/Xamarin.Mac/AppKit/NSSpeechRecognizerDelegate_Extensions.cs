using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSSpeechRecognizerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRecognizeCommand(this INSSpeechRecognizerDelegate This, NSSpeechRecognizer sender, string command)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr intPtr = NSString.CreateNative(command);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("speechRecognizer:didRecognizeCommand:"), sender.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}
}
