using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSplitViewDelegate", true)]
[Model]
public class NSSplitViewDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSplitViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSplitViewDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSplitViewDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSplitViewDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("splitView:canCollapseSubview:")]
	public virtual bool CanCollapse(NSSplitView splitView, NSView subview)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:")]
	public virtual bool ShouldCollapseForDoubleClick(NSSplitView splitView, NSView subview, long doubleClickAtDividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:constrainMinCoordinate:ofSubviewAt:")]
	public virtual double SetMinCoordinateOfSubview(NSSplitView splitView, double proposedMinimumPosition, long subviewDividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:constrainMaxCoordinate:ofSubviewAt:")]
	public virtual double SetMaxCoordinateOfSubview(NSSplitView splitView, double proposedMaximumPosition, long subviewDividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:constrainSplitPosition:ofSubviewAt:")]
	public virtual double ConstrainSplitPosition(NSSplitView splitView, double proposedPosition, long subviewDividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:resizeSubviewsWithOldSize:")]
	public virtual void Resize(NSSplitView splitView, CGSize oldSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:shouldAdjustSizeOfSubview:")]
	public virtual bool ShouldAdjustSize(NSSplitView splitView, NSView view)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:shouldHideDividerAtIndex:")]
	public virtual bool ShouldHideDivider(NSSplitView splitView, long dividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:")]
	public virtual CGRect GetEffectiveRect(NSSplitView splitView, CGRect proposedEffectiveRect, CGRect drawnRect, long dividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitView:additionalEffectiveRectOfDividerAtIndex:")]
	public virtual CGRect GetAdditionalEffectiveRect(NSSplitView splitView, long dividerIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitViewWillResizeSubviews:")]
	public virtual void SplitViewWillResizeSubviews(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("splitViewDidResizeSubviews:")]
	public virtual void DidResizeSubviews(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
