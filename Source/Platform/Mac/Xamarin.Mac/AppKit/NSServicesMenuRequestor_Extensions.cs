using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSServicesMenuRequestor_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteSelectionToPasteboard(this INSServicesMenuRequestor This, NSPasteboard pboard, string[] types)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromStrings(types);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("writeSelectionToPasteboard:types:"), pboard.Handle, nSArray.Handle);
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadSelectionFromPasteboard(this INSServicesMenuRequestor This, NSPasteboard pboard)
	{
		NSApplication.EnsureUIThread();
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("readSelectionFromPasteboard:"), pboard.Handle);
	}
}
