using System;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

public static class QLPreviewPanelDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool HandleEvent(this IQLPreviewPanelDelegate This, QLPreviewPanel panel, NSEvent theEvent)
	{
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("previewPanel:handleEvent:"), panel.Handle, theEvent.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect SourceFrameOnScreenForPreviewItem(this IQLPreviewPanelDelegate This, QLPreviewPanel panel, IQLPreviewItem item)
	{
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (item != null)
		{
			if (!(item is NSObject))
			{
				throw new ArgumentException("The object passed of type " + item.GetType()?.ToString() + " does not derive from NSObject");
			}
			Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr(out var retval, This.Handle, Selector.GetHandle("previewPanel:sourceFrameOnScreenForPreviewItem:"), panel.Handle, item.Handle);
			return retval;
		}
		throw new ArgumentNullException("item");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject TransitionImageForPreviewItem(this IQLPreviewPanelDelegate This, QLPreviewPanel panel, IQLPreviewItem item, CGRect contentRect)
	{
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (item != null)
		{
			if (!(item is NSObject))
			{
				throw new ArgumentException("The object passed of type " + item.GetType()?.ToString() + " does not derive from NSObject");
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGRect(This.Handle, Selector.GetHandle("previewPanel:transitionImageForPreviewItem:contentRect:"), panel.Handle, item.Handle, contentRect));
		}
		throw new ArgumentNullException("item");
	}
}
