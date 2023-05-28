using System;
using ObjCRuntime;

namespace AVKit;

public static class AVRoutePickerViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillBeginPresentingRoutes(this IAVRoutePickerViewDelegate This, AVRoutePickerView routePickerView)
	{
		if (routePickerView == null)
		{
			throw new ArgumentNullException("routePickerView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("routePickerViewWillBeginPresentingRoutes:"), routePickerView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEndPresentingRoutes(this IAVRoutePickerViewDelegate This, AVRoutePickerView routePickerView)
	{
		if (routePickerView == null)
		{
			throw new ArgumentNullException("routePickerView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("routePickerViewDidEndPresentingRoutes:"), routePickerView.Handle);
	}
}
