using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSTextTableBlock", true)]
public class NSTextTableBlock : NSTextBlock
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnSpan = "columnSpan";

	private static readonly IntPtr selColumnSpanHandle = Selector.GetHandle("columnSpan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTable_StartingRow_RowSpan_StartingColumn_ColumnSpan_ = "initWithTable:startingRow:rowSpan:startingColumn:columnSpan:";

	private static readonly IntPtr selInitWithTable_StartingRow_RowSpan_StartingColumn_ColumnSpan_Handle = Selector.GetHandle("initWithTable:startingRow:rowSpan:startingColumn:columnSpan:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowSpan = "rowSpan";

	private static readonly IntPtr selRowSpanHandle = Selector.GetHandle("rowSpan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartingColumn = "startingColumn";

	private static readonly IntPtr selStartingColumnHandle = Selector.GetHandle("startingColumn");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartingRow = "startingRow";

	private static readonly IntPtr selStartingRowHandle = Selector.GetHandle("startingRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTable = "table";

	private static readonly IntPtr selTableHandle = Selector.GetHandle("table");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextTableBlock");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ColumnSpan
	{
		[Export("columnSpan")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selColumnSpanHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selColumnSpanHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RowSpan
	{
		[Export("rowSpan")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRowSpanHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRowSpanHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint StartingColumn
	{
		[Export("startingColumn")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selStartingColumnHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selStartingColumnHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint StartingRow
	{
		[Export("startingRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selStartingRowHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selStartingRowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextTable Table
	{
		[Export("table")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTextTable>(Messaging.IntPtr_objc_msgSend(base.Handle, selTableHandle));
			}
			return Runtime.GetNSObject<NSTextTable>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTableHandle));
		}
	}

	[Obsolete("macOS 10.12 does not allow creation via this constructor")]
	public NSTextTableBlock()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTextTableBlock(NSCoder coder)
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
	protected NSTextTableBlock(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextTableBlock(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTable:startingRow:rowSpan:startingColumn:columnSpan:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextTableBlock(NSTextTable table, nint row, nint rowSpan, nint col, nint colSpan)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint_nint_nint(base.Handle, selInitWithTable_StartingRow_RowSpan_StartingColumn_ColumnSpan_Handle, table.Handle, row, rowSpan, col, colSpan), "initWithTable:startingRow:rowSpan:startingColumn:columnSpan:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_nint_nint_nint(base.SuperHandle, selInitWithTable_StartingRow_RowSpan_StartingColumn_ColumnSpan_Handle, table.Handle, row, rowSpan, col, colSpan), "initWithTable:startingRow:rowSpan:startingColumn:columnSpan:");
		}
	}
}
