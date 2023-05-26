using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableHeaderCell", true)]
public class NSTableHeaderCell : NSTextFieldCell
{
	private static readonly IntPtr selDrawSortIndicatorWithFrameInViewAscendingPriority_Handle = Selector.GetHandle("drawSortIndicatorWithFrame:inView:ascending:priority:");

	private static readonly IntPtr selSortIndicatorRectForBounds_Handle = Selector.GetHandle("sortIndicatorRectForBounds:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTableHeaderCell");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableHeaderCell()
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
	public NSTableHeaderCell(NSCoder coder)
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
	public NSTableHeaderCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTableHeaderCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("drawSortIndicatorWithFrame:inView:ascending:priority:")]
	public virtual void DrawSortIndicator(CGRect cellFrame, NSView controlView, bool ascending, long priority)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_bool_Int64(base.Handle, selDrawSortIndicatorWithFrameInViewAscendingPriority_Handle, cellFrame, controlView.Handle, ascending, priority);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_bool_Int64(base.SuperHandle, selDrawSortIndicatorWithFrameInViewAscendingPriority_Handle, cellFrame, controlView.Handle, ascending, priority);
		}
	}

	[Export("sortIndicatorRectForBounds:")]
	public virtual CGRect GetSortIndicatorRect(CGRect theRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selSortIndicatorRectForBounds_Handle, theRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selSortIndicatorRectForBounds_Handle, theRect);
		}
		return retval;
	}
}
