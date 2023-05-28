using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextTable", true)]
public class NSTextTable : NSTextBlock
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_ = "boundsRectForBlock:contentRect:inRect:textContainer:characterRange:";

	private static readonly IntPtr selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_Handle = Selector.GetHandle("boundsRectForBlock:contentRect:inRect:textContainer:characterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapsesBorders = "collapsesBorders";

	private static readonly IntPtr selCollapsesBordersHandle = Selector.GetHandle("collapsesBorders");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawBackgroundForBlock_WithFrame_InView_CharacterRange_LayoutManager_ = "drawBackgroundForBlock:withFrame:inView:characterRange:layoutManager:";

	private static readonly IntPtr selDrawBackgroundForBlock_WithFrame_InView_CharacterRange_LayoutManager_Handle = Selector.GetHandle("drawBackgroundForBlock:withFrame:inView:characterRange:layoutManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHidesEmptyCells = "hidesEmptyCells";

	private static readonly IntPtr selHidesEmptyCellsHandle = Selector.GetHandle("hidesEmptyCells");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAlgorithm = "layoutAlgorithm";

	private static readonly IntPtr selLayoutAlgorithmHandle = Selector.GetHandle("layoutAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColumns = "numberOfColumns";

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_ = "rectForBlock:layoutAtPoint:inRect:textContainer:characterRange:";

	private static readonly IntPtr selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_Handle = Selector.GetHandle("rectForBlock:layoutAtPoint:inRect:textContainer:characterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollapsesBorders_ = "setCollapsesBorders:";

	private static readonly IntPtr selSetCollapsesBorders_Handle = Selector.GetHandle("setCollapsesBorders:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidesEmptyCells_ = "setHidesEmptyCells:";

	private static readonly IntPtr selSetHidesEmptyCells_Handle = Selector.GetHandle("setHidesEmptyCells:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayoutAlgorithm_ = "setLayoutAlgorithm:";

	private static readonly IntPtr selSetLayoutAlgorithm_Handle = Selector.GetHandle("setLayoutAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfColumns_ = "setNumberOfColumns:";

	private static readonly IntPtr selSetNumberOfColumns_Handle = Selector.GetHandle("setNumberOfColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextTable");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CollapsesBorders
	{
		[Export("collapsesBorders")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCollapsesBordersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCollapsesBordersHandle);
		}
		[Export("setCollapsesBorders:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCollapsesBorders_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCollapsesBorders_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Columns
	{
		[Export("numberOfColumns")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfColumnsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfColumnsHandle);
		}
		[Export("setNumberOfColumns:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetNumberOfColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNumberOfColumns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HidesEmptyCells
	{
		[Export("hidesEmptyCells")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHidesEmptyCellsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHidesEmptyCellsHandle);
		}
		[Export("setHidesEmptyCells:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidesEmptyCells_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidesEmptyCells_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextTableLayoutAlgorithm LayoutAlgorithm
	{
		[Export("layoutAlgorithm")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextTableLayoutAlgorithm)Messaging.UInt64_objc_msgSend(base.Handle, selLayoutAlgorithmHandle);
			}
			return (NSTextTableLayoutAlgorithm)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLayoutAlgorithmHandle);
		}
		[Export("setLayoutAlgorithm:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLayoutAlgorithm_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLayoutAlgorithm_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextTable()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTextTable(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTextTable(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextTable(IntPtr handle)
		: base(handle)
	{
	}

	[Export("drawBackgroundForBlock:withFrame:inView:characterRange:layoutManager:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr_NSRange_IntPtr(base.Handle, selDrawBackgroundForBlock_WithFrame_InView_CharacterRange_LayoutManager_Handle, block.Handle, frameRect, controlView.Handle, charRange, layoutManager.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr_NSRange_IntPtr(base.SuperHandle, selDrawBackgroundForBlock_WithFrame_InView_CharacterRange_LayoutManager_Handle, block.Handle, frameRect, controlView.Handle, charRange, layoutManager.Handle);
		}
	}

	[Export("boundsRectForBlock:contentRect:inRect:textContainer:characterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_CGRect_IntPtr_NSRange(out retval, base.Handle, selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_Handle, block.Handle, contentRect, rect, textContainer.Handle, charRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_CGRect_IntPtr_NSRange(out retval, base.SuperHandle, selBoundsRectForBlock_ContentRect_InRect_TextContainer_CharacterRange_Handle, block.Handle, contentRect, rect, textContainer.Handle, charRange);
		}
		return retval;
	}

	[Export("rectForBlock:layoutAtPoint:inRect:textContainer:characterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGPoint_CGRect_IntPtr_NSRange(out retval, base.Handle, selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_Handle, block.Handle, startingPoint, rect, textContainer.Handle, charRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGPoint_CGRect_IntPtr_NSRange(out retval, base.SuperHandle, selRectForBlock_LayoutAtPoint_InRect_TextContainer_CharacterRange_Handle, block.Handle, startingPoint, rect, textContainer.Handle, charRange);
		}
		return retval;
	}
}
