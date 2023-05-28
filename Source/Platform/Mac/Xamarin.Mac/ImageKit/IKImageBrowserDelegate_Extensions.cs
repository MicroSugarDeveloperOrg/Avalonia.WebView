using System;
using AppKit;
using ObjCRuntime;

namespace ImageKit;

public static class IKImageBrowserDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectionDidChange(this IIKImageBrowserDelegate This, IKImageBrowserView browser)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("imageBrowserSelectionDidChange:"), browser.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CellWasDoubleClicked(this IIKImageBrowserDelegate This, IKImageBrowserView browser, nint index)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		Messaging.void_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("imageBrowser:cellWasDoubleClickedAtIndex:"), browser.Handle, index);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CellWasRightClicked(this IIKImageBrowserDelegate This, IKImageBrowserView browser, nint index, NSEvent nsevent)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (nsevent == null)
		{
			throw new ArgumentNullException("nsevent");
		}
		Messaging.void_objc_msgSend_IntPtr_nint_IntPtr(This.Handle, Selector.GetHandle("imageBrowser:cellWasRightClickedAtIndex:withEvent:"), browser.Handle, index, nsevent.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void BackgroundWasRightClicked(this IIKImageBrowserDelegate This, IKImageBrowserView browser, NSEvent nsevent)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (nsevent == null)
		{
			throw new ArgumentNullException("nsevent");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("imageBrowser:backgroundWasRightClickedWithEvent:"), browser.Handle, nsevent.Handle);
	}
}
