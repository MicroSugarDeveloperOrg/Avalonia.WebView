using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSSplitViewDelegate", false)]
[Model]
public class NSSplitViewDelegate : NSObject, INSSplitViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSplitViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSplitViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSplitViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("splitView:canCollapseSubview:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanCollapse(NSSplitView splitView, NSView subview)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:constrainSplitPosition:ofSubviewAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ConstrainSplitPosition(NSSplitView splitView, nfloat proposedPosition, nint subviewDividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitViewDidResizeSubviews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidResizeSubviews(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:additionalEffectiveRectOfDividerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetAdditionalEffectiveRect(NSSplitView splitView, nint dividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetEffectiveRect(NSSplitView splitView, CGRect proposedEffectiveRect, CGRect drawnRect, nint dividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:resizeSubviewsWithOldSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resize(NSSplitView splitView, CGSize oldSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:constrainMaxCoordinate:ofSubviewAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat SetMaxCoordinateOfSubview(NSSplitView splitView, nfloat proposedMaximumPosition, nint subviewDividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:constrainMinCoordinate:ofSubviewAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat SetMinCoordinateOfSubview(NSSplitView splitView, nfloat proposedMinimumPosition, nint subviewDividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:shouldAdjustSizeOfSubview:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldAdjustSize(NSSplitView splitView, NSView view)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "This delegate method is never called.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCollapseForDoubleClick(NSSplitView splitView, NSView subview, nint doubleClickAtDividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:shouldHideDividerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldHideDivider(NSSplitView splitView, nint dividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitViewWillResizeSubviews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SplitViewWillResizeSubviews(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
