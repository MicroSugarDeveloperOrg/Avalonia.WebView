using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSComboBoxCell", true)]
public class NSComboBoxCell : NSTextFieldCell
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddItemWithObjectValue_ = "addItemWithObjectValue:";

	private static readonly IntPtr selAddItemWithObjectValue_Handle = Selector.GetHandle("addItemWithObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddItemsWithObjectValues_ = "addItemsWithObjectValues:";

	private static readonly IntPtr selAddItemsWithObjectValues_Handle = Selector.GetHandle("addItemsWithObjectValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletedString_ = "completedString:";

	private static readonly IntPtr selCompletedString_Handle = Selector.GetHandle("completedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletes = "completes";

	private static readonly IntPtr selCompletesHandle = Selector.GetHandle("completes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeselectItemAtIndex_ = "deselectItemAtIndex:";

	private static readonly IntPtr selDeselectItemAtIndex_Handle = Selector.GetHandle("deselectItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasVerticalScroller = "hasVerticalScroller";

	private static readonly IntPtr selHasVerticalScrollerHandle = Selector.GetHandle("hasVerticalScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithObjectValue_ = "indexOfItemWithObjectValue:";

	private static readonly IntPtr selIndexOfItemWithObjectValue_Handle = Selector.GetHandle("indexOfItemWithObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfSelectedItem = "indexOfSelectedItem";

	private static readonly IntPtr selIndexOfSelectedItemHandle = Selector.GetHandle("indexOfSelectedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItemWithObjectValue_AtIndex_ = "insertItemWithObjectValue:atIndex:";

	private static readonly IntPtr selInsertItemWithObjectValue_AtIndex_Handle = Selector.GetHandle("insertItemWithObjectValue:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntercellSpacing = "intercellSpacing";

	private static readonly IntPtr selIntercellSpacingHandle = Selector.GetHandle("intercellSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsButtonBordered = "isButtonBordered";

	private static readonly IntPtr selIsButtonBorderedHandle = Selector.GetHandle("isButtonBordered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemHeight = "itemHeight";

	private static readonly IntPtr selItemHeightHandle = Selector.GetHandle("itemHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemObjectValueAtIndex_ = "itemObjectValueAtIndex:";

	private static readonly IntPtr selItemObjectValueAtIndex_Handle = Selector.GetHandle("itemObjectValueAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteNumberOfItemsChanged = "noteNumberOfItemsChanged";

	private static readonly IntPtr selNoteNumberOfItemsChangedHandle = Selector.GetHandle("noteNumberOfItemsChanged");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfItems = "numberOfItems";

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfVisibleItems = "numberOfVisibleItems";

	private static readonly IntPtr selNumberOfVisibleItemsHandle = Selector.GetHandle("numberOfVisibleItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectValueOfSelectedItem = "objectValueOfSelectedItem";

	private static readonly IntPtr selObjectValueOfSelectedItemHandle = Selector.GetHandle("objectValueOfSelectedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectValues = "objectValues";

	private static readonly IntPtr selObjectValuesHandle = Selector.GetHandle("objectValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadData = "reloadData";

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllItems = "removeAllItems";

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemAtIndex_ = "removeItemAtIndex:";

	private static readonly IntPtr selRemoveItemAtIndex_Handle = Selector.GetHandle("removeItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemWithObjectValue_ = "removeItemWithObjectValue:";

	private static readonly IntPtr selRemoveItemWithObjectValue_Handle = Selector.GetHandle("removeItemWithObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollItemAtIndexToTop_ = "scrollItemAtIndexToTop:";

	private static readonly IntPtr selScrollItemAtIndexToTop_Handle = Selector.GetHandle("scrollItemAtIndexToTop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollItemAtIndexToVisible_ = "scrollItemAtIndexToVisible:";

	private static readonly IntPtr selScrollItemAtIndexToVisible_Handle = Selector.GetHandle("scrollItemAtIndexToVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectItemAtIndex_ = "selectItemAtIndex:";

	private static readonly IntPtr selSelectItemAtIndex_Handle = Selector.GetHandle("selectItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectItemWithObjectValue_ = "selectItemWithObjectValue:";

	private static readonly IntPtr selSelectItemWithObjectValue_Handle = Selector.GetHandle("selectItemWithObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetButtonBordered_ = "setButtonBordered:";

	private static readonly IntPtr selSetButtonBordered_Handle = Selector.GetHandle("setButtonBordered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompletes_ = "setCompletes:";

	private static readonly IntPtr selSetCompletes_Handle = Selector.GetHandle("setCompletes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataSource_ = "setDataSource:";

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasVerticalScroller_ = "setHasVerticalScroller:";

	private static readonly IntPtr selSetHasVerticalScroller_Handle = Selector.GetHandle("setHasVerticalScroller:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIntercellSpacing_ = "setIntercellSpacing:";

	private static readonly IntPtr selSetIntercellSpacing_Handle = Selector.GetHandle("setIntercellSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetItemHeight_ = "setItemHeight:";

	private static readonly IntPtr selSetItemHeight_Handle = Selector.GetHandle("setItemHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfVisibleItems_ = "setNumberOfVisibleItems:";

	private static readonly IntPtr selSetNumberOfVisibleItems_Handle = Selector.GetHandle("setNumberOfVisibleItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesDataSource_ = "setUsesDataSource:";

	private static readonly IntPtr selSetUsesDataSource_Handle = Selector.GetHandle("setUsesDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesDataSource = "usesDataSource";

	private static readonly IntPtr selUsesDataSourceHandle = Selector.GetHandle("usesDataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSComboBoxCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_DataSource_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ButtonBordered
	{
		[Export("isButtonBordered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsButtonBorderedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsButtonBorderedHandle);
		}
		[Export("setButtonBordered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetButtonBordered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetButtonBordered_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Completes
	{
		[Export("completes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCompletesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCompletesHandle);
		}
		[Export("setCompletes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCompletes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCompletes_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Count
	{
		[Export("numberOfItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfItemsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfItemsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSComboBoxCellDataSource? DataSource
	{
		[Export("dataSource", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			INSComboBoxCellDataSource iNSComboBoxCellDataSource = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSComboBoxCellDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle), owns: false) : Runtime.GetINativeObject<INSComboBoxCellDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle), owns: false));
			MarkDirty();
			__mt_DataSource_var = iNSComboBoxCellDataSource;
			return iNSComboBoxCellDataSource;
		}
		[Export("setDataSource:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_DataSource_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasVerticalScroller
	{
		[Export("hasVerticalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasVerticalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasVerticalScrollerHandle);
		}
		[Export("setHasVerticalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasVerticalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasVerticalScroller_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize IntercellSpacing
	{
		[Export("intercellSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selIntercellSpacingHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selIntercellSpacingHandle);
		}
		[Export("setIntercellSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetIntercellSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetIntercellSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ItemHeight
	{
		[Export("itemHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selItemHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selItemHeightHandle);
		}
		[Export("setItemHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetItemHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetItemHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedIndex
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
	public virtual NSObject SelectedValue
	{
		[Export("objectValueOfSelectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValueOfSelectedItemHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValueOfSelectedItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesDataSource
	{
		[Export("usesDataSource")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesDataSourceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesDataSourceHandle);
		}
		[Export("setUsesDataSource:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesDataSource_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesDataSource_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Values
	{
		[Export("objectValues")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValuesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValuesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint VisibleItems
	{
		[Export("numberOfVisibleItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfVisibleItemsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfVisibleItemsHandle);
		}
		[Export("setNumberOfVisibleItems:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetNumberOfVisibleItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNumberOfVisibleItems_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSComboBoxCell()
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
	public NSComboBoxCell(NSCoder coder)
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
	protected NSComboBoxCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSComboBoxCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSComboBoxCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addItemWithObjectValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItemWithObjectValue_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItemWithObjectValue_Handle, object1.Handle);
		}
	}

	[Export("addItemsWithObjectValues:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(NSObject[] items)
	{
		NSApplication.EnsureUIThread();
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItemsWithObjectValues_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItemsWithObjectValues_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("completedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CompletedString(string substring)
	{
		NSApplication.EnsureUIThread();
		if (substring == null)
		{
			throw new ArgumentNullException("substring");
		}
		IntPtr arg = NSString.CreateNative(substring);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompletedString_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCompletedString_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("deselectItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeselectItem(nint itemIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selDeselectItemAtIndex_Handle, itemIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selDeselectItemAtIndex_Handle, itemIndex);
		}
	}

	[Export("itemObjectValueAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComboBox GetItem(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSComboBox>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemObjectValueAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSComboBox>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemObjectValueAtIndex_Handle, index));
	}

	[Export("indexOfItemWithObjectValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithObjectValue_Handle, object1.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithObjectValue_Handle, object1.Handle);
	}

	[Export("insertItemWithObjectValue:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSObject object1, nint index)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertItemWithObjectValue_AtIndex_Handle, object1.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertItemWithObjectValue_AtIndex_Handle, object1.Handle, index);
		}
	}

	[Export("noteNumberOfItemsChanged")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteNumberOfItemsChanged()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selNoteNumberOfItemsChangedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selNoteNumberOfItemsChangedHandle);
		}
	}

	[Export("reloadData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadData()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("removeItemWithObjectValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItemWithObjectValue_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItemWithObjectValue_Handle, object1.Handle);
		}
	}

	[Export("removeAllItems")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAll()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllItemsHandle);
		}
	}

	[Export("removeItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAt(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveItemAtIndex_Handle, index);
		}
	}

	[Export("scrollItemAtIndexToTop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollItemAtIndexToTop(nint scrollItemIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selScrollItemAtIndexToTop_Handle, scrollItemIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selScrollItemAtIndexToTop_Handle, scrollItemIndex);
		}
	}

	[Export("scrollItemAtIndexToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollItemAtIndexToVisible(nint scrollItemIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selScrollItemAtIndexToVisible_Handle, scrollItemIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selScrollItemAtIndexToVisible_Handle, scrollItemIndex);
		}
	}

	[Export("selectItemWithObjectValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Select(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectItemWithObjectValue_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectItemWithObjectValue_Handle, object1.Handle);
		}
	}

	[Export("selectItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectItem(nint itemIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selSelectItemAtIndex_Handle, itemIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSelectItemAtIndex_Handle, itemIndex);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DataSource_var = null;
		}
	}
}
