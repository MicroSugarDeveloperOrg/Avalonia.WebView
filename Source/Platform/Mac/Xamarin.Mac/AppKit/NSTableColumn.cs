using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableColumn", true)]
public class NSTableColumn : NSObject
{
	private static readonly IntPtr selTableViewHandle = Selector.GetHandle("tableView");

	private static readonly IntPtr selSetTableView_Handle = Selector.GetHandle("setTableView:");

	private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

	private static readonly IntPtr selSetWidth_Handle = Selector.GetHandle("setWidth:");

	private static readonly IntPtr selMinWidthHandle = Selector.GetHandle("minWidth");

	private static readonly IntPtr selSetMinWidth_Handle = Selector.GetHandle("setMinWidth:");

	private static readonly IntPtr selMaxWidthHandle = Selector.GetHandle("maxWidth");

	private static readonly IntPtr selSetMaxWidth_Handle = Selector.GetHandle("setMaxWidth:");

	private static readonly IntPtr selHeaderCellHandle = Selector.GetHandle("headerCell");

	private static readonly IntPtr selSetHeaderCell_Handle = Selector.GetHandle("setHeaderCell:");

	private static readonly IntPtr selDataCellHandle = Selector.GetHandle("dataCell");

	private static readonly IntPtr selSetDataCell_Handle = Selector.GetHandle("setDataCell:");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selSortDescriptorPrototypeHandle = Selector.GetHandle("sortDescriptorPrototype");

	private static readonly IntPtr selSetSortDescriptorPrototype_Handle = Selector.GetHandle("setSortDescriptorPrototype:");

	private static readonly IntPtr selResizingMaskHandle = Selector.GetHandle("resizingMask");

	private static readonly IntPtr selSetResizingMask_Handle = Selector.GetHandle("setResizingMask:");

	private static readonly IntPtr selHeaderToolTipHandle = Selector.GetHandle("headerToolTip");

	private static readonly IntPtr selSetHeaderToolTip_Handle = Selector.GetHandle("setHeaderToolTip:");

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	private static readonly IntPtr selDataCellForRow_Handle = Selector.GetHandle("dataCellForRow:");

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTableColumn");

	private object __mt_TableView_var;

	private object __mt_HeaderCell_var;

	private object __mt_DataCell_var;

	private object __mt_SortDescriptorPrototype_var;

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual double Width
	{
		[Export("width")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selWidthHandle);
		}
		[Export("setWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetWidth_Handle, value);
			}
		}
	}

	public virtual double MinWidth
	{
		[Export("minWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinWidthHandle);
		}
		[Export("setMinWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinWidth_Handle, value);
			}
		}
	}

	public virtual double MaxWidth
	{
		[Export("maxWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMaxWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMaxWidthHandle);
		}
		[Export("setMaxWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMaxWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMaxWidth_Handle, value);
			}
		}
	}

	public virtual NSCell HeaderCell
	{
		[Export("headerCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCell)(__mt_HeaderCell_var = ((!IsDirectBinding) ? ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHeaderCellHandle))) : ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHeaderCellHandle)))));
		}
		[Export("setHeaderCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHeaderCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHeaderCell_Handle, value.Handle);
			}
			__mt_HeaderCell_var = value;
		}
	}

	public virtual NSCell DataCell
	{
		[Export("dataCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCell)(__mt_DataCell_var = ((!IsDirectBinding) ? ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataCellHandle))) : ((NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataCellHandle)))));
		}
		[Export("setDataCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataCell_Handle, value.Handle);
			}
			__mt_DataCell_var = value;
		}
	}

	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	public virtual NSSortDescriptor SortDescriptorPrototype
	{
		[Export("sortDescriptorPrototype")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSSortDescriptor)(__mt_SortDescriptorPrototype_var = ((!IsDirectBinding) ? ((NSSortDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorPrototypeHandle))) : ((NSSortDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorPrototypeHandle)))));
		}
		[Export("setSortDescriptorPrototype:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptorPrototype_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptorPrototype_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_SortDescriptorPrototype_var = value;
		}
	}

	public virtual NSTableColumnResizing ResizingMask
	{
		[Export("resizingMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableColumnResizing)Messaging.UInt64_objc_msgSend(base.Handle, selResizingMaskHandle);
			}
			return (NSTableColumnResizing)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResizingMaskHandle);
		}
		[Export("setResizingMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetResizingMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetResizingMask_Handle, (ulong)value);
			}
		}
	}

	public virtual string HeaderToolTip
	{
		[Export("headerToolTip")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHeaderToolTipHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHeaderToolTipHandle));
		}
		[Export("setHeaderToolTip:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHeaderToolTip_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHeaderToolTip_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableColumn()
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
	public NSTableColumn(NSCoder coder)
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
	public NSTableColumn(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTableColumn(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	public NSTableColumn(string identifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithIdentifier:")]
	public NSTableColumn(NSString identifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, identifier.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, identifier.Handle);
		}
	}

	[Export("initWithIdentifier:")]
	[Obsolete("", false)]
	public NSTableColumn(NSObject identifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, identifier.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, identifier.Handle);
		}
	}

	[Export("dataCellForRow:")]
	public virtual NSCell DataCellForRow(long row)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selDataCellForRow_Handle, row));
		}
		return (NSCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selDataCellForRow_Handle, row));
	}

	[Export("sizeToFit")]
	public virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TableView_var = null;
			__mt_HeaderCell_var = null;
			__mt_DataCell_var = null;
			__mt_SortDescriptorPrototype_var = null;
		}
	}
}
