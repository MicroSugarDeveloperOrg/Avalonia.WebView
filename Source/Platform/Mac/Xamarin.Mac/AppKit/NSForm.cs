using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSForm", true)]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSForm : NSMatrix
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddEntry_ = "addEntry:";

	private static readonly IntPtr selAddEntry_Handle = Selector.GetHandle("addEntry:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellAtIndex_ = "cellAtIndex:";

	private static readonly IntPtr selCellAtIndex_Handle = Selector.GetHandle("cellAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawCellAtIndex_ = "drawCellAtIndex:";

	private static readonly IntPtr selDrawCellAtIndex_Handle = Selector.GetHandle("drawCellAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfCellWithTag_ = "indexOfCellWithTag:";

	private static readonly IntPtr selIndexOfCellWithTag_Handle = Selector.GetHandle("indexOfCellWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfSelectedItem = "indexOfSelectedItem";

	private static readonly IntPtr selIndexOfSelectedItemHandle = Selector.GetHandle("indexOfSelectedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_ = "initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:";

	private static readonly IntPtr selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_Handle = Selector.GetHandle("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_ = "initWithFrame:mode:prototype:numberOfRows:numberOfColumns:";

	private static readonly IntPtr selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_Handle = Selector.GetHandle("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertEntry_AtIndex_ = "insertEntry:atIndex:";

	private static readonly IntPtr selInsertEntry_AtIndex_Handle = Selector.GetHandle("insertEntry:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredTextFieldWidth = "preferredTextFieldWidth";

	private static readonly IntPtr selPreferredTextFieldWidthHandle = Selector.GetHandle("preferredTextFieldWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveEntryAtIndex_ = "removeEntryAtIndex:";

	private static readonly IntPtr selRemoveEntryAtIndex_Handle = Selector.GetHandle("removeEntryAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectTextAtIndex_ = "selectTextAtIndex:";

	private static readonly IntPtr selSelectTextAtIndex_Handle = Selector.GetHandle("selectTextAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBezeled_ = "setBezeled:";

	private static readonly IntPtr selSetBezeled_Handle = Selector.GetHandle("setBezeled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBordered_ = "setBordered:";

	private static readonly IntPtr selSetBordered_Handle = Selector.GetHandle("setBordered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEntryWidth_ = "setEntryWidth:";

	private static readonly IntPtr selSetEntryWidth_Handle = Selector.GetHandle("setEntryWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameSize_ = "setFrameSize:";

	private static readonly IntPtr selSetFrameSize_Handle = Selector.GetHandle("setFrameSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterlineSpacing_ = "setInterlineSpacing:";

	private static readonly IntPtr selSetInterlineSpacing_Handle = Selector.GetHandle("setInterlineSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredTextFieldWidth_ = "setPreferredTextFieldWidth:";

	private static readonly IntPtr selSetPreferredTextFieldWidth_Handle = Selector.GetHandle("setPreferredTextFieldWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextAlignment_ = "setTextAlignment:";

	private static readonly IntPtr selSetTextAlignment_Handle = Selector.GetHandle("setTextAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextBaseWritingDirection_ = "setTextBaseWritingDirection:";

	private static readonly IntPtr selSetTextBaseWritingDirection_Handle = Selector.GetHandle("setTextBaseWritingDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextFont_ = "setTextFont:";

	private static readonly IntPtr selSetTextFont_Handle = Selector.GetHandle("setTextFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitleAlignment_ = "setTitleAlignment:";

	private static readonly IntPtr selSetTitleAlignment_Handle = Selector.GetHandle("setTitleAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitleBaseWritingDirection_ = "setTitleBaseWritingDirection:";

	private static readonly IntPtr selSetTitleBaseWritingDirection_Handle = Selector.GetHandle("setTitleBaseWritingDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitleFont_ = "setTitleFont:";

	private static readonly IntPtr selSetTitleFont_Handle = Selector.GetHandle("setTitleFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSForm");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat PreferredTextFieldWidth
	{
		[Export("preferredTextFieldWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPreferredTextFieldWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPreferredTextFieldWidthHandle);
		}
		[Export("setPreferredTextFieldWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetPreferredTextFieldWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetPreferredTextFieldWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedItemIndex
	{
		[Export("indexOfSelectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selIndexOfSelectedItemHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selIndexOfSelectedItemHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSForm()
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
	public NSForm(NSCoder coder)
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
	protected NSForm(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSForm(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSForm(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("initWithFrame:mode:prototype:numberOfRows:numberOfColumns:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSForm(CGRect frameRect, NSMatrixMode aMode, NSCell aCell, nint rowsHigh, nint colsWide)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aCell == null)
		{
			throw new ArgumentNullException("aCell");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_UInt64_IntPtr_nint_nint(base.Handle, selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_Handle, frameRect, (ulong)aMode, aCell.Handle, rowsHigh, colsWide), "initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_IntPtr_nint_nint(base.SuperHandle, selInitWithFrame_Mode_Prototype_NumberOfRows_NumberOfColumns_Handle, frameRect, (ulong)aMode, aCell.Handle, rowsHigh, colsWide), "initWithFrame:mode:prototype:numberOfRows:numberOfColumns:");
		}
	}

	[Export("initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSForm(CGRect frameRect, NSMatrixMode aMode, Class factoryId, nint rowsHigh, nint colsWide)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_UInt64_IntPtr_nint_nint(base.Handle, selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_Handle, frameRect, (ulong)aMode, factoryId.Handle, rowsHigh, colsWide), "initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_IntPtr_nint_nint(base.SuperHandle, selInitWithFrame_Mode_CellClass_NumberOfRows_NumberOfColumns_Handle, frameRect, (ulong)aMode, factoryId.Handle, rowsHigh, colsWide), "initWithFrame:mode:cellClass:numberOfRows:numberOfColumns:");
		}
	}

	[Export("addEntry:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFormCell AddEntry(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSFormCell result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFormCell>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddEntry_Handle, arg)) : Runtime.GetNSObject<NSFormCell>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAddEntry_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("cellAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject CellAtIndex(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selCellAtIndex_Handle, index));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selCellAtIndex_Handle, index));
	}

	[Export("drawCellAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawCellAtIndex(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selDrawCellAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selDrawCellAtIndex_Handle, index);
		}
	}

	[Export("indexOfCellWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfCellWithTag(nint aTag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selIndexOfCellWithTag_Handle, aTag);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selIndexOfCellWithTag_Handle, aTag);
	}

	[Export("insertEntry:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFormCell InsertEntryatIndex(string title, nint index)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSFormCell result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFormCell>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertEntry_AtIndex_Handle, arg, index)) : Runtime.GetNSObject<NSFormCell>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(base.Handle, selInsertEntry_AtIndex_Handle, arg, index)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeEntryAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveEntryAtIndex(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveEntryAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveEntryAtIndex_Handle, index);
		}
	}

	[Export("selectTextAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectTextAtIndex(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selSelectTextAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSelectTextAtIndex_Handle, index);
		}
	}

	[Export("setBezeled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBezeled(bool bezeled)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetBezeled_Handle, bezeled);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBezeled_Handle, bezeled);
		}
	}

	[Export("setBordered:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBordered(bool bordered)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetBordered_Handle, bordered);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBordered_Handle, bordered);
		}
	}

	[Export("setEntryWidth:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetEntryWidth(nfloat width)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, selSetEntryWidth_Handle, width);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetEntryWidth_Handle, width);
		}
	}

	[Export("setFrameSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void SetFrameSize(CGSize newSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selSetFrameSize_Handle, newSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetFrameSize_Handle, newSize);
		}
	}

	[Export("setInterlineSpacing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetInterlineSpacing(nfloat spacing)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, selSetInterlineSpacing_Handle, spacing);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetInterlineSpacing_Handle, spacing);
		}
	}

	[Export("setTextAlignment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTextAlignment(NSTextAlignment mode)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTextAlignment_Handle, (ulong)mode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTextAlignment_Handle, (ulong)mode);
		}
	}

	[Export("setTextBaseWritingDirection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTextBaseWritingDirection(NSWritingDirection writingDirection)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetTextBaseWritingDirection_Handle, (long)writingDirection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTextBaseWritingDirection_Handle, (long)writingDirection);
		}
	}

	[Export("setTextFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTextFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextFont_Handle, fontObj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextFont_Handle, fontObj.Handle);
		}
	}

	[Export("setTitleAlignment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTitleAlignment(NSTextAlignment mode)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTitleAlignment_Handle, (ulong)mode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTitleAlignment_Handle, (ulong)mode);
		}
	}

	[Export("setTitleBaseWritingDirection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTitleBaseWritingDirection(NSWritingDirection writingDirection)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetTitleBaseWritingDirection_Handle, (long)writingDirection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTitleBaseWritingDirection_Handle, (long)writingDirection);
		}
	}

	[Export("setTitleFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTitleFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleFont_Handle, fontObj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleFont_Handle, fontObj.Handle);
		}
	}
}
