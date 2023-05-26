using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableHeaderView", true)]
public class NSTableHeaderView : NSView
{
	private static readonly IntPtr selDraggedColumnHandle = Selector.GetHandle("draggedColumn");

	private static readonly IntPtr selDraggedDistanceHandle = Selector.GetHandle("draggedDistance");

	private static readonly IntPtr selResizedColumnHandle = Selector.GetHandle("resizedColumn");

	private static readonly IntPtr selTableViewHandle = Selector.GetHandle("tableView");

	private static readonly IntPtr selSetTableView_Handle = Selector.GetHandle("setTableView:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selHeaderRectOfColumn_Handle = Selector.GetHandle("headerRectOfColumn:");

	private static readonly IntPtr selColumnAtPoint_Handle = Selector.GetHandle("columnAtPoint:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTableHeaderView");

	private object __mt_TableView_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual long DraggedColumn
	{
		[Export("draggedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selDraggedColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggedColumnHandle);
		}
	}

	public virtual double DraggedDistance
	{
		[Export("draggedDistance")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDraggedDistanceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDraggedDistanceHandle);
		}
	}

	public virtual long ResizedColumn
	{
		[Export("resizedColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selResizedColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selResizedColumnHandle);
		}
	}

	public virtual NSTableView TableView
	{
		[Export("tableView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTableView)(__mt_TableView_var = ((!IsDirectBinding) ? ((NSTableView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTableViewHandle))) : ((NSTableView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTableViewHandle)))));
		}
		[Export("setTableView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTableView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTableView_Handle, value.Handle);
			}
			__mt_TableView_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableHeaderView()
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
	public NSTableHeaderView(NSCoder coder)
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
	public NSTableHeaderView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTableHeaderView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSTableHeaderView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	[Export("headerRectOfColumn:")]
	public virtual CGRect GetHeaderRect(long column)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selHeaderRectOfColumn_Handle, column);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selHeaderRectOfColumn_Handle, column);
		}
		return retval;
	}

	[Export("columnAtPoint:")]
	public virtual long GetColumn(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_CGPoint(base.Handle, selColumnAtPoint_Handle, point);
		}
		return Messaging.Int64_objc_msgSendSuper_CGPoint(base.SuperHandle, selColumnAtPoint_Handle, point);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TableView_var = null;
		}
	}
}
