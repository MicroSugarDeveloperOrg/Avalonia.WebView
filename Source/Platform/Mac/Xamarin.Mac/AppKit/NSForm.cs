using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSForm", true)]
public class NSForm : NSMatrix
{
	private static readonly IntPtr selIndexOfSelectedItemHandle = Selector.GetHandle("indexOfSelectedItem");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selInitWithFrameModePrototypeNumberOfRowsNumberOfColumns_Handle = Selector.GetHandle("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");

	private static readonly IntPtr selInitWithFrameModeCellClassNumberOfRowsNumberOfColumns_Handle = Selector.GetHandle("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");

	private static readonly IntPtr selSetEntryWidth_Handle = Selector.GetHandle("setEntryWidth:");

	private static readonly IntPtr selSetInterlineSpacing_Handle = Selector.GetHandle("setInterlineSpacing:");

	private static readonly IntPtr selSetBordered_Handle = Selector.GetHandle("setBordered:");

	private static readonly IntPtr selSetBezeled_Handle = Selector.GetHandle("setBezeled:");

	private static readonly IntPtr selSetTitleAlignment_Handle = Selector.GetHandle("setTitleAlignment:");

	private static readonly IntPtr selSetTextAlignment_Handle = Selector.GetHandle("setTextAlignment:");

	private static readonly IntPtr selSetTitleFont_Handle = Selector.GetHandle("setTitleFont:");

	private static readonly IntPtr selSetTextFont_Handle = Selector.GetHandle("setTextFont:");

	private static readonly IntPtr selCellAtIndex_Handle = Selector.GetHandle("cellAtIndex:");

	private static readonly IntPtr selDrawCellAtIndex_Handle = Selector.GetHandle("drawCellAtIndex:");

	private static readonly IntPtr selAddEntry_Handle = Selector.GetHandle("addEntry:");

	private static readonly IntPtr selInsertEntryAtIndex_Handle = Selector.GetHandle("insertEntry:atIndex:");

	private static readonly IntPtr selRemoveEntryAtIndex_Handle = Selector.GetHandle("removeEntryAtIndex:");

	private static readonly IntPtr selIndexOfCellWithTag_Handle = Selector.GetHandle("indexOfCellWithTag:");

	private static readonly IntPtr selSelectTextAtIndex_Handle = Selector.GetHandle("selectTextAtIndex:");

	private static readonly IntPtr selSetFrameSize_Handle = Selector.GetHandle("setFrameSize:");

	private static readonly IntPtr selSetTitleBaseWritingDirection_Handle = Selector.GetHandle("setTitleBaseWritingDirection:");

	private static readonly IntPtr selSetTextBaseWritingDirection_Handle = Selector.GetHandle("setTextBaseWritingDirection:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSForm");

	public override IntPtr ClassHandle => class_ptr;

	public virtual long SelectedItemIndex
	{
		[Export("indexOfSelectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selIndexOfSelectedItemHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selIndexOfSelectedItemHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSForm()
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
	public NSForm(NSCoder coder)
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
	public NSForm(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSForm(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSForm(CGRect frameRect)
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

	[Export("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:")]
	public NSForm(CGRect frameRect, NSMatrixMode aMode, NSCell aCell, long rowsHigh, long colsWide)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_int_IntPtr_Int64_Int64(base.Handle, selInitWithFrameModePrototypeNumberOfRowsNumberOfColumns_Handle, frameRect, (int)aMode, aCell.Handle, rowsHigh, colsWide);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_int_IntPtr_Int64_Int64(base.SuperHandle, selInitWithFrameModePrototypeNumberOfRowsNumberOfColumns_Handle, frameRect, (int)aMode, aCell.Handle, rowsHigh, colsWide);
		}
	}

	[Export("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:")]
	public NSForm(CGRect frameRect, NSMatrixMode aMode, Class factoryId, long rowsHigh, long colsWide)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_int_IntPtr_Int64_Int64(base.Handle, selInitWithFrameModeCellClassNumberOfRowsNumberOfColumns_Handle, frameRect, (int)aMode, factoryId.Handle, rowsHigh, colsWide);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_int_IntPtr_Int64_Int64(base.SuperHandle, selInitWithFrameModeCellClassNumberOfRowsNumberOfColumns_Handle, frameRect, (int)aMode, factoryId.Handle, rowsHigh, colsWide);
		}
	}

	[Export("setEntryWidth:")]
	public virtual void SetEntryWidth(double width)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selSetEntryWidth_Handle, width);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetEntryWidth_Handle, width);
		}
	}

	[Export("setInterlineSpacing:")]
	public virtual void SetInterlineSpacing(double spacing)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selSetInterlineSpacing_Handle, spacing);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetInterlineSpacing_Handle, spacing);
		}
	}

	[Export("setBordered:")]
	public virtual void SetBordered(bool bordered)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetBordered_Handle, bordered);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBordered_Handle, bordered);
		}
	}

	[Export("setBezeled:")]
	public virtual void SetBezeled(bool bezeled)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetBezeled_Handle, bezeled);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBezeled_Handle, bezeled);
		}
	}

	[Export("setTitleAlignment:")]
	public virtual void SetTitleAlignment(NSTextAlignment mode)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTitleAlignment_Handle, (ulong)mode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTitleAlignment_Handle, (ulong)mode);
		}
	}

	[Export("setTextAlignment:")]
	public virtual void SetTextAlignment(NSTextAlignment mode)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTextAlignment_Handle, (ulong)mode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTextAlignment_Handle, (ulong)mode);
		}
	}

	[Export("setTitleFont:")]
	public virtual void SetTitleFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleFont_Handle, fontObj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleFont_Handle, fontObj.Handle);
		}
	}

	[Export("setTextFont:")]
	public virtual void SetTextFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextFont_Handle, fontObj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextFont_Handle, fontObj.Handle);
		}
	}

	[Export("cellAtIndex:")]
	public virtual NSObject CellAtIndex(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selCellAtIndex_Handle, index));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selCellAtIndex_Handle, index));
	}

	[Export("drawCellAtIndex:")]
	public virtual void DrawCellAtIndex(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selDrawCellAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selDrawCellAtIndex_Handle, index);
		}
	}

	[Export("addEntry:")]
	public virtual NSFormCell AddEntry(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSFormCell result = ((!IsDirectBinding) ? ((NSFormCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddEntry_Handle, arg))) : ((NSFormCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAddEntry_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("insertEntry:atIndex:")]
	public virtual NSFormCell InsertEntryatIndex(string title, long index)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSFormCell result = ((!IsDirectBinding) ? ((NSFormCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInsertEntryAtIndex_Handle, arg, index))) : ((NSFormCell)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Int64(base.Handle, selInsertEntryAtIndex_Handle, arg, index))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeEntryAtIndex:")]
	public virtual void RemoveEntryAtIndex(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveEntryAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveEntryAtIndex_Handle, index);
		}
	}

	[Export("indexOfCellWithTag:")]
	public virtual long IndexOfCellWithTag(long aTag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selIndexOfCellWithTag_Handle, aTag);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selIndexOfCellWithTag_Handle, aTag);
	}

	[Export("selectTextAtIndex:")]
	public virtual void SelectTextAtIndex(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSelectTextAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSelectTextAtIndex_Handle, index);
		}
	}

	[Export("setFrameSize:")]
	public new virtual void SetFrameSize(CGSize newSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetFrameSize_Handle, newSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetFrameSize_Handle, newSize);
		}
	}

	[Export("setTitleBaseWritingDirection:")]
	public virtual void SetTitleBaseWritingDirection(NSWritingDirection writingDirection)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetTitleBaseWritingDirection_Handle, (long)writingDirection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTitleBaseWritingDirection_Handle, (long)writingDirection);
		}
	}

	[Export("setTextBaseWritingDirection:")]
	public virtual void SetTextBaseWritingDirection(NSWritingDirection writingDirection)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetTextBaseWritingDirection_Handle, (long)writingDirection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTextBaseWritingDirection_Handle, (long)writingDirection);
		}
	}
}
