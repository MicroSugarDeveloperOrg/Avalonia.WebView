using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

public static class IKDeviceBrowserViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEncounterError(this IIKDeviceBrowserViewDelegate This, IKDeviceBrowserView deviceBrowserView, NSError error)
	{
		if (deviceBrowserView == null)
		{
			throw new ArgumentNullException("deviceBrowserView");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("deviceBrowserView:didEncounterError:"), deviceBrowserView.Handle, error.Handle);
	}
}
