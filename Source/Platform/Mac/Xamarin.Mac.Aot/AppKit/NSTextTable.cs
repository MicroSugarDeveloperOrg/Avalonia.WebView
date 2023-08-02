using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextTable", true)]
public class NSTextTable : NSTextBlock
{
	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	private static readonly IntPtr selSetNumberOfColumns_Handle = Selector.GetHandle("setNumberOfColumns:");

	private static readonly IntPtr selLayoutAlgorithmHandle = Selector.GetHandle("layoutAlgorithm");

	private static readonly IntPtr selSetLayoutAlgorithm_Handle = Selector.GetHandle("setLayoutAlgorithm:");

	private static readonly IntPtr selCollapsesBordersHandle = Selector.GetHandle("collapsesBorders");

	private static readonly IntPtr selSetCollapsesBorders_Handle = Selector.GetHandle("setCollapsesBorders:");

	private static readonly IntPtr selHidesEmptyCellsHandle = Selector.GetHandle("hidesEmptyCells");

	private static readonly IntPtr selSetHidesEmptyCells_Handle = Selector.GetHandle("setHidesEmptyCells:");

	private static readonly IntPtr selRectForBlockLayoutAtPointInRectTextContainerCharacterRange_Handle = Selector.GetHandle("rectForBlock:layoutAtPoint:inRect:textContainer:characterRange:");

	private static readonly IntPtr selBoundsRectForBlockContentRectInRectTextContainerCharacterRange_Handle = Selector.GetHandle("boundsRectForBlock:contentRect:inRect:textContainer:characterRange:");

	private static readonly IntPtr selDrawBackgroundForBlockWithFrameInViewCharacterRangeLayoutManager_Handle = Selector.GetHandle("drawBackgroundForBlock:withFrame:inView:characterRange:layoutManager:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextTable");

	public override IntPtr ClassHandle => class_ptr;

	public virtual long Columns
	{
		[Export("numberOfColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfColumnsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfColumnsHandle);
		}
		[Export("setNumberOfColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetNumberOfColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetNumberOfColumns_Handle, value);
			}
		}
	}

	public virtual NSTextTableLayoutAlgorithm LayoutAlgorithm
	{
		[Export("layoutAlgorithm")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextTableLayoutAlgorithm)Messaging.UInt64_objc_msgSend(base.Handle, selLayoutAlgorithmHandle);
			}
			return (NSTextTableLayoutAlgorithm)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLayoutAlgorithmHandle);
		}
		[Export("setLayoutAlgorithm:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLayoutAlgorithm_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLayoutAlgorithm_Handle, (ulong)value);
			}
		}
	}

	public virtual bool CollapsesBorders
	{
		[Export("collapsesBorders")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCollapsesBordersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCollapsesBordersHandle);
		}
		[Export("setCollapsesBorders:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCollapsesBorders_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCollapsesBorders_Handle, value);
			}
		}
	}

	public virtual bool HidesEmptyCells
	{
		[Export("hidesEmptyCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHidesEmptyCellsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHidesEmptyCellsHandle);
		}
		[Export("setHidesEmptyCells:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidesEmptyCells_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidesEmptyCells_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextTable()
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
	public NSTextTable(NSCoder coder)
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
	public NSTextTable(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextTable(IntPtr handle)
		: base(handle)
	{
	}

	[Export("rectForBlock:layoutAtPoint:inRect:textContainer:characterRange:")]
	public virtual CGRect GetRectForBlock(NSTextTableBlock block, CGPoint startingPoint, CGRect rect, NSTextContainer textContainer, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGPoint_CGRect_IntPtr_NSRange(out retval, base.Handle, selRectForBlockLayoutAtPointInRectTextContainerCharacterRange_Handle, block.Handle, startingPoint, rect, textContainer.Handle, charRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGPoint_CGRect_IntPtr_NSRange(out retval, base.SuperHandle, selRectForBlockLayoutAtPointInRectTextContainerCharacterRange_Handle, block.Handle, startingPoint, rect, textContainer.Handle, charRange);
		}
		return retval;
	}

	[Export("boundsRectForBlock:contentRect:inRect:textContainer:characterRange:")]
	public virtual CGRect GetBoundsRect(NSTextTableBlock block, CGRect contentRect, CGRect rect, NSTextContainer textContainer, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_CGRect_IntPtr_NSRange(out retval, base.Handle, selBoundsRectForBlockContentRectInRectTextContainerCharacterRange_Handle, block.Handle, contentRect, rect, textContainer.Handle, charRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_CGRect_IntPtr_NSRange(out retval, base.SuperHandle, selBoundsRectForBlockContentRectInRectTextContainerCharacterRange_Handle, block.Handle, contentRect, rect, textContainer.Handle, charRange);
		}
		return retval;
	}

	[Export("drawBackgroundForBlock:withFrame:inView:characterRange:layoutManager:")]
	public virtual void DrawBackground(NSTextTableBlock block, CGRect frameRect, NSView controlView, NSRange charRange, NSLayoutManager layoutManager)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr_NSRange_IntPtr(base.Handle, selDrawBackgroundForBlockWithFrameInViewCharacterRangeLayoutManager_Handle, block.Handle, frameRect, controlView.Handle, charRange, layoutManager.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr_NSRange_IntPtr(base.SuperHandle, selDrawBackgroundForBlockWithFrameInViewCharacterRangeLayoutManager_Handle, block.Handle, frameRect, controlView.Handle, charRange, layoutManager.Handle);
		}
	}
}
