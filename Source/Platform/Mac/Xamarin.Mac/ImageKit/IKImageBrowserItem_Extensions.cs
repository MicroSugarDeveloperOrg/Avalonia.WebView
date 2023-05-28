using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

public static class IKImageBrowserItem_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetImageVersion(this IIKImageBrowserItem This)
	{
		return Messaging.nint_objc_msgSend(This.Handle, Selector.GetHandle("imageVersion"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetImageTitle(this IIKImageBrowserItem This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("imageTitle")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetImageSubtitle(this IIKImageBrowserItem This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("imageSubtitle")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetIsSelectable(this IIKImageBrowserItem This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isSelectable"));
	}
}
