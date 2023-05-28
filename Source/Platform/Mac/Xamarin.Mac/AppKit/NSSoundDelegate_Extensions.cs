using System;
using ObjCRuntime;

namespace AppKit;

public static class NSSoundDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishPlaying(this INSSoundDelegate This, NSSound sound, bool finished)
	{
		NSApplication.EnsureUIThread();
		if (sound == null)
		{
			throw new ArgumentNullException("sound");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("sound:didFinishPlaying:"), sound.Handle, finished);
	}
}
