using System;
using ObjCRuntime;

namespace AppKit;

public static class NSPasteboardTypeOwner_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PasteboardChangedOwner(this INSPasteboardTypeOwner This, NSPasteboard sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pasteboardChangedOwner:"), sender.Handle);
	}
}
