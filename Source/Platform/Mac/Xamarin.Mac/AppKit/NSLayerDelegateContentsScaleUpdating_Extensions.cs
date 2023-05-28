using System;
using CoreAnimation;
using ObjCRuntime;

namespace AppKit;

public static class NSLayerDelegateContentsScaleUpdating_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldInheritContentsScale(this INSLayerDelegateContentsScaleUpdating This, CALayer layer, nfloat newScale, NSWindow fromWindow)
	{
		NSApplication.EnsureUIThread();
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (fromWindow == null)
		{
			throw new ArgumentNullException("fromWindow");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nfloat_IntPtr(This.Handle, Selector.GetHandle("layer:shouldInheritContentsScale:fromWindow:"), layer.Handle, newScale, fromWindow.Handle);
	}
}
