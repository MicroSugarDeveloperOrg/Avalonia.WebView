using System;
using CoreGraphics;
using ObjCRuntime;

namespace AppKit;

public static class NSScrubberFlowLayoutDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGSize Layout(this INSScrubberFlowLayoutDelegate This, NSScrubber scrubber, NSScrubberFlowLayout layout, nint itemIndex)
	{
		NSApplication.EnsureUIThread();
		if (scrubber == null)
		{
			throw new ArgumentNullException("scrubber");
		}
		if (layout == null)
		{
			throw new ArgumentNullException("layout");
		}
		return Messaging.CGSize_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("scrubber:layout:sizeForItemAtIndex:"), scrubber.Handle, layout.Handle, itemIndex);
	}
}
