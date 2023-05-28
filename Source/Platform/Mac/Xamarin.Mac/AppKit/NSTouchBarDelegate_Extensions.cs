using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSTouchBarDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTouchBarItem? MakeItem(this INSTouchBarDelegate This, NSTouchBar touchBar, string identifier)
	{
		NSApplication.EnsureUIThread();
		if (touchBar == null)
		{
			throw new ArgumentNullException("touchBar");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr intPtr = NSString.CreateNative(identifier);
		NSTouchBarItem nSObject = Runtime.GetNSObject<NSTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("touchBar:makeItemForIdentifier:"), touchBar.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}
}
