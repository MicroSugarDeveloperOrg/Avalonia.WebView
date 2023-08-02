using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextTableBlock", true)]
public class NSTextTableBlock : NSTextBlock
{
	private static readonly IntPtr selTableHandle = Selector.GetHandle("table");

	private static readonly IntPtr selStartingRowHandle = Selector.GetHandle("startingRow");

	private static readonly IntPtr selRowSpanHandle = Selector.GetHandle("rowSpan");

	private static readonly IntPtr selStartingColumnHandle = Selector.GetHandle("startingColumn");

	private static readonly IntPtr selColumnSpanHandle = Selector.GetHandle("columnSpan");

	private static readonly IntPtr selInitWithTableStartingRowRowSpanStartingColumnColumnSpan_Handle = Selector.GetHandle("initWithTable:startingRow:rowSpan:startingColumn:columnSpan:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextTableBlock");

	private object __mt_Table_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSTextTable Table
	{
		[Export("table")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextTable)(__mt_Table_var = ((!IsDirectBinding) ? ((NSTextTable)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTableHandle))) : ((NSTextTable)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTableHandle)))));
		}
	}

	public virtual long StartingRow
	{
		[Export("startingRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selStartingRowHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStartingRowHandle);
		}
	}

	public virtual long RowSpan
	{
		[Export("rowSpan")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selRowSpanHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRowSpanHandle);
		}
	}

	public virtual long StartingColumn
	{
		[Export("startingColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selStartingColumnHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStartingColumnHandle);
		}
	}

	public virtual long ColumnSpan
	{
		[Export("columnSpan")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selColumnSpanHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selColumnSpanHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextTableBlock()
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
	public NSTextTableBlock(NSCoder coder)
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
	public NSTextTableBlock(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextTableBlock(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTable:startingRow:rowSpan:startingColumn:columnSpan:")]
	public NSTextTableBlock(NSTextTable table, long row, long rowSpan, long col, long colSpan)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Int64_Int64_Int64_Int64(base.Handle, selInitWithTableStartingRowRowSpanStartingColumnColumnSpan_Handle, table.Handle, row, rowSpan, col, colSpan);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64_Int64_Int64(base.SuperHandle, selInitWithTableStartingRowRowSpanStartingColumnColumnSpan_Handle, table.Handle, row, rowSpan, col, colSpan);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Table_var = null;
		}
	}
}
