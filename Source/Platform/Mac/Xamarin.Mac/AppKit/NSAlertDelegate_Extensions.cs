using System;
using ObjCRuntime;

namespace AppKit;

public static class NSAlertDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShowHelp(this INSAlertDelegate This, NSAlert alert)
	{
		NSApplication.EnsureUIThread();
		if (alert == null)
		{
			throw new ArgumentNullException("alert");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("alertShowHelp:"), alert.Handle);
	}
}
