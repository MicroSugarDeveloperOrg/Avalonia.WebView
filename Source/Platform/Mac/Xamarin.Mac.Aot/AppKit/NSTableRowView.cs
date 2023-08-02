using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableRowView", true)]
public class NSTableRowView : NSView
{
	private static readonly IntPtr selSelectionHighlightStyleHandle = Selector.GetHandle("selectionHighlightStyle");

	private static readonly IntPtr selSetSelectionHighlightStyle_Handle = Selector.GetHandle("setSelectionHighlightStyle:");

	private static readonly IntPtr selIsEmphasizedHandle = Selector.GetHandle("isEmphasized");

	private static readonly IntPtr selSetEmphasized_Handle = Selector.GetHandle("setEmphasized:");

	private static readonly IntPtr selIsGroupRowStyleHandle = Selector.GetHandle("isGroupRowStyle");

	private static readonly IntPtr selSetGroupRowStyle_Handle = Selector.GetHandle("setGroupRowStyle:");

	private static readonly IntPtr selIsSelectedHandle = Selector.GetHandle("isSelected");

	private static readonly IntPtr selSetSelected_Handle = Selector.GetHandle("setSelected:");

	private static readonly IntPtr selIsFloatingHandle = Selector.GetHandle("isFloating");

	private static readonly IntPtr selSetFloating_Handle = Selector.GetHandle("setFloating:");

	private static readonly IntPtr selDraggingDestinationFeedbackStyleHandle = Selector.GetHandle("draggingDestinationFeedbackStyle");

	private static readonly IntPtr selSetDraggingDestinationFeedbackStyle_Handle = Selector.GetHandle("setDraggingDestinationFeedbackStyle:");

	private static readonly IntPtr selIndentationForDropOperationHandle = Selector.GetHandle("indentationForDropOperation");

	private static readonly IntPtr selSetIndentationForDropOperation_Handle = Selector.GetHandle("setIndentationForDropOperation:");

	private static readonly IntPtr selInteriorBackgroundStyleHandle = Selector.GetHandle("interiorBackgroundStyle");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	private static readonly IntPtr selIsTargetForDropOperationHandle = Selector.GetHandle("isTargetForDropOperation");

	private static readonly IntPtr selSetTargetForDropOperation_Handle = Selector.GetHandle("setTargetForDropOperation:");

	private static readonly IntPtr selDrawBackgroundInRect_Handle = Selector.GetHandle("drawBackgroundInRect:");

	private static readonly IntPtr selDrawSelectionInRect_Handle = Selector.GetHandle("drawSelectionInRect:");

	private static readonly IntPtr selDrawSeparatorInRect_Handle = Selector.GetHandle("drawSeparatorInRect:");

	private static readonly IntPtr selDrawDraggingDestinationFeedbackInRect_Handle = Selector.GetHandle("drawDraggingDestinationFeedbackInRect:");

	private static readonly IntPtr selViewAtColumn_Handle = Selector.GetHandle("viewAtColumn:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTableRowView");

	private object __mt_BackgroundColor_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSTableViewSelectionHighlightStyle SelectionHighlightStyle
	{
		[Export("selectionHighlightStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableViewSelectionHighlightStyle)Messaging.Int64_objc_msgSend(base.Handle, selSelectionHighlightStyleHandle);
			}
			return (NSTableViewSelectionHighlightStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectionHighlightStyleHandle);
		}
		[Export("setSelectionHighlightStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSelectionHighlightStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSelectionHighlightStyle_Handle, (long)value);
			}
		}
	}

	public virtual bool Emphasized
	{
		[Export("isEmphasized")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEmphasizedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEmphasizedHandle);
		}
		[Export("setEmphasized:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEmphasized_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEmphasized_Handle, value);
			}
		}
	}

	public virtual bool GroupRowStyle
	{
		[Export("isGroupRowStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsGroupRowStyleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsGroupRowStyleHandle);
		}
		[Export("setGroupRowStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGroupRowStyle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGroupRowStyle_Handle, value);
			}
		}
	}

	public virtual bool Selected
	{
		[Export("isSelected")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectedHandle);
		}
		[Export("setSelected:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelected_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelected_Handle, value);
			}
		}
	}

	public virtual bool Floating
	{
		[Export("isFloating")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFloatingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFloatingHandle);
		}
		[Export("setFloating:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFloating_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFloating_Handle, value);
			}
		}
	}

	public virtual NSTableViewDraggingDestinationFeedbackStyle DraggingDestinationFeedbackStyle
	{
		[Export("draggingDestinationFeedbackStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableViewDraggingDestinationFeedbackStyle)Messaging.Int64_objc_msgSend(base.Handle, selDraggingDestinationFeedbackStyleHandle);
			}
			return (NSTableViewDraggingDestinationFeedbackStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingDestinationFeedbackStyleHandle);
		}
		[Export("setDraggingDestinationFeedbackStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDraggingDestinationFeedbackStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDraggingDestinationFeedbackStyle_Handle, (long)value);
			}
		}
	}

	public virtual double IndentationForDropOperation
	{
		[Export("indentationForDropOperation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selIndentationForDropOperationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selIndentationForDropOperationHandle);
		}
		[Export("setIndentationForDropOperation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetIndentationForDropOperation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetIndentationForDropOperation_Handle, value);
			}
		}
	}

	public virtual NSBackgroundStyle InteriorBackgroundStyle
	{
		[Export("interiorBackgroundStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBackgroundStyle)Messaging.Int64_objc_msgSend(base.Handle, selInteriorBackgroundStyleHandle);
			}
			return (NSBackgroundStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selInteriorBackgroundStyleHandle);
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual long NumberOfColumns
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
	}

	public virtual bool TargetForDropOperation
	{
		[Export("isTargetForDropOperation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTargetForDropOperationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTargetForDropOperationHandle);
		}
		[Export("setTargetForDropOperation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTargetForDropOperation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTargetForDropOperation_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableRowView()
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
	public NSTableRowView(NSCoder coder)
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
	public NSTableRowView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTableRowView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("drawBackgroundInRect:")]
	public virtual void DrawBackground(CGRect dirtyRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawBackgroundInRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawBackgroundInRect_Handle, dirtyRect);
		}
	}

	[Export("drawSelectionInRect:")]
	public virtual void DrawSelection(CGRect dirtyRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawSelectionInRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawSelectionInRect_Handle, dirtyRect);
		}
	}

	[Export("drawSeparatorInRect:")]
	public virtual void DrawSeparator(CGRect dirtyRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawSeparatorInRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawSeparatorInRect_Handle, dirtyRect);
		}
	}

	[Export("drawDraggingDestinationFeedbackInRect:")]
	public virtual void DrawDraggingDestinationFeedback(CGRect dirtyRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawDraggingDestinationFeedbackInRect_Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawDraggingDestinationFeedbackInRect_Handle, dirtyRect);
		}
	}

	[Export("viewAtColumn:")]
	public virtual NSView ViewAtColumn(long column)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selViewAtColumn_Handle, column));
		}
		return (NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selViewAtColumn_Handle, column));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_BackgroundColor_var = null;
		}
	}
}
