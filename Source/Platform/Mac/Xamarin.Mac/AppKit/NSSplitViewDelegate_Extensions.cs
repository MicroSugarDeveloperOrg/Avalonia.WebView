using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSSplitViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanCollapse(this INSSplitViewDelegate This, NSSplitView splitView, NSView subview)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (subview == null)
		{
			throw new ArgumentNullException("subview");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("splitView:canCollapseSubview:"), splitView.Handle, subview.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "This delegate method is never called.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldCollapseForDoubleClick(this INSSplitViewDelegate This, NSSplitView splitView, NSView subview, nint doubleClickAtDividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (subview == null)
		{
			throw new ArgumentNullException("subview");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:"), splitView.Handle, subview.Handle, doubleClickAtDividerIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat SetMinCoordinateOfSubview(this INSSplitViewDelegate This, NSSplitView splitView, nfloat proposedMinimumPosition, nint subviewDividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nfloat_nint(This.Handle, Selector.GetHandle("splitView:constrainMinCoordinate:ofSubviewAt:"), splitView.Handle, proposedMinimumPosition, subviewDividerIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat SetMaxCoordinateOfSubview(this INSSplitViewDelegate This, NSSplitView splitView, nfloat proposedMaximumPosition, nint subviewDividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nfloat_nint(This.Handle, Selector.GetHandle("splitView:constrainMaxCoordinate:ofSubviewAt:"), splitView.Handle, proposedMaximumPosition, subviewDividerIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat ConstrainSplitPosition(this INSSplitViewDelegate This, NSSplitView splitView, nfloat proposedPosition, nint subviewDividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_nfloat_nint(This.Handle, Selector.GetHandle("splitView:constrainSplitPosition:ofSubviewAt:"), splitView.Handle, proposedPosition, subviewDividerIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Resize(this INSSplitViewDelegate This, NSSplitView splitView, CGSize oldSize)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		Messaging.void_objc_msgSend_IntPtr_CGSize(This.Handle, Selector.GetHandle("splitView:resizeSubviewsWithOldSize:"), splitView.Handle, oldSize);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldAdjustSize(this INSSplitViewDelegate This, NSSplitView splitView, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("splitView:shouldAdjustSizeOfSubview:"), splitView.Handle, view.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldHideDivider(this INSSplitViewDelegate This, NSSplitView splitView, nint dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("splitView:shouldHideDividerAtIndex:"), splitView.Handle, dividerIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect GetEffectiveRect(this INSSplitViewDelegate This, NSSplitView splitView, CGRect proposedEffectiveRect, CGRect drawnRect, nint dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_CGRect_nint(out var retval, This.Handle, Selector.GetHandle("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:"), splitView.Handle, proposedEffectiveRect, drawnRect, dividerIndex);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect GetAdditionalEffectiveRect(this INSSplitViewDelegate This, NSSplitView splitView, nint dividerIndex)
	{
		NSApplication.EnsureUIThread();
		if (splitView == null)
		{
			throw new ArgumentNullException("splitView");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_nint(out var retval, This.Handle, Selector.GetHandle("splitView:additionalEffectiveRectOfDividerAtIndex:"), splitView.Handle, dividerIndex);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SplitViewWillResizeSubviews(this INSSplitViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("splitViewWillResizeSubviews:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidResizeSubviews(this INSSplitViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("splitViewDidResizeSubviews:"), notification.Handle);
	}
}
