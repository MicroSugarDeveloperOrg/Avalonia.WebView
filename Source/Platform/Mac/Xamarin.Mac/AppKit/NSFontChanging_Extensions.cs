using System;
using ObjCRuntime;

namespace AppKit;

public static class NSFontChanging_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ChangeFont(this INSFontChanging This, NSFontManager? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("changeFont:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontPanelModeMask GetValidModes(this INSFontChanging This, NSFontPanel fontPanel)
	{
		NSApplication.EnsureUIThread();
		if (fontPanel == null)
		{
			throw new ArgumentNullException("fontPanel");
		}
		return (NSFontPanelModeMask)Messaging.UInt64_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("validModesForFontPanel:"), fontPanel.Handle);
	}
}
