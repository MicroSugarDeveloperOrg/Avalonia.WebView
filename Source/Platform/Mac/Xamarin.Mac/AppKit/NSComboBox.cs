using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSComboBox", true)]
public class NSComboBox : NSTextField
{
	public new static class Notifications
	{
		public static NSObject ObserveSelectionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionIsChanging(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionIsChangingNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillDismiss(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(WillDismissNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillPopUp(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(WillPopUpNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selHasVerticalScrollerHandle = Selector.GetHandle("hasVerticalScroller");

	private static readonly IntPtr selSetHasVerticalScroller_Handle = Selector.GetHandle("setHasVerticalScroller:");

	private static readonly IntPtr selIntercellSpacingHandle = Selector.GetHandle("intercellSpacing");

	private static readonly IntPtr selSetIntercellSpacing_Handle = Selector.GetHandle("setIntercellSpacing:");

	private static readonly IntPtr selItemHeightHandle = Selector.GetHandle("itemHeight");

	private static readonly IntPtr selSetItemHeight_Handle = Selector.GetHandle("setItemHeight:");

	private static readonly IntPtr selNumberOfVisibleItemsHandle = Selector.GetHandle("numberOfVisibleItems");

	private static readonly IntPtr selSetNumberOfVisibleItems_Handle = Selector.GetHandle("setNumberOfVisibleItems:");

	private static readonly IntPtr selIsButtonBorderedHandle = Selector.GetHandle("isButtonBordered");

	private static readonly IntPtr selSetButtonBordered_Handle = Selector.GetHandle("setButtonBordered:");

	private static readonly IntPtr selUsesDataSourceHandle = Selector.GetHandle("usesDataSource");

	private static readonly IntPtr selSetUsesDataSource_Handle = Selector.GetHandle("setUsesDataSource:");

	private static readonly IntPtr selIndexOfSelectedItemHandle = Selector.GetHandle("indexOfSelectedItem");

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	private static readonly IntPtr selCompletesHandle = Selector.GetHandle("completes");

	private static readonly IntPtr selSetCompletes_Handle = Selector.GetHandle("setCompletes:");

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	private static readonly IntPtr selObjectValueOfSelectedItemHandle = Selector.GetHandle("objectValueOfSelectedItem");

	private static readonly IntPtr selObjectValuesHandle = Selector.GetHandle("objectValues");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	private static readonly IntPtr selNoteNumberOfItemsChangedHandle = Selector.GetHandle("noteNumberOfItemsChanged");

	private static readonly IntPtr selScrollItemAtIndexToTop_Handle = Selector.GetHandle("scrollItemAtIndexToTop:");

	private static readonly IntPtr selScrollItemAtIndexToVisible_Handle = Selector.GetHandle("scrollItemAtIndexToVisible:");

	private static readonly IntPtr selSelectItemAtIndex_Handle = Selector.GetHandle("selectItemAtIndex:");

	private static readonly IntPtr selDeselectItemAtIndex_Handle = Selector.GetHandle("deselectItemAtIndex:");

	private static readonly IntPtr selAddItemWithObjectValue_Handle = Selector.GetHandle("addItemWithObjectValue:");

	private static readonly IntPtr selAddItemsWithObjectValues_Handle = Selector.GetHandle("addItemsWithObjectValues:");

	private static readonly IntPtr selInsertItemWithObjectValueAtIndex_Handle = Selector.GetHandle("insertItemWithObjectValue:atIndex:");

	private static readonly IntPtr selRemoveItemWithObjectValue_Handle = Selector.GetHandle("removeItemWithObjectValue:");

	private static readonly IntPtr selRemoveItemAtIndex_Handle = Selector.GetHandle("removeItemAtIndex:");

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	private static readonly IntPtr selSelectItemWithObjectValue_Handle = Selector.GetHandle("selectItemWithObjectValue:");

	private static readonly IntPtr selItemObjectValueAtIndex_Handle = Selector.GetHandle("itemObjectValueAtIndex:");

	private static readonly IntPtr selIndexOfItemWithObjectValue_Handle = Selector.GetHandle("indexOfItemWithObjectValue:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSComboBox");

	private object __mt_DataSource_var;

	private object __mt_SelectedValue_var;

	private object __mt_Values_var;

	private static NSString _SelectionDidChangeNotification;

	private static NSString _SelectionIsChangingNotification;

	private static NSString _WillDismissNotification;

	private static NSString _WillPopUpNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool HasVerticalScroller
	{
		[Export("hasVerticalScroller")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasVerticalScrollerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasVerticalScrollerHandle);
		}
		[Export("setHasVerticalScroller:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasVerticalScroller_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasVerticalScroller_Handle, value);
			}
		}
	}

	public virtual CGSize IntercellSpacing
	{
		[Export("intercellSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selIntercellSpacingHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selIntercellSpacingHandle);
		}
		[Export("setIntercellSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetIntercellSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetIntercellSpacing_Handle, value);
			}
		}
	}

	public virtual double ItemHeight
	{
		[Export("itemHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selItemHeightHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selItemHeightHandle);
		}
		[Export("setItemHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetItemHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetItemHeight_Handle, value);
			}
		}
	}

	public virtual long VisibleItems
	{
		[Export("numberOfVisibleItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfVisibleItemsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfVisibleItemsHandle);
		}
		[Export("setNumberOfVisibleItems:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetNumberOfVisibleItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetNumberOfVisibleItems_Handle, value);
			}
		}
	}

	public virtual bool ButtonBordered
	{
		[Export("isButtonBordered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsButtonBorderedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsButtonBorderedHandle);
		}
		[Export("setButtonBordered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetButtonBordered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetButtonBordered_Handle, value);
			}
		}
	}

	public virtual bool UsesDataSource
	{
		[Export("usesDataSource")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesDataSourceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesDataSourceHandle);
		}
		[Export("setUsesDataSource:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesDataSource_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesDataSource_Handle, value);
			}
		}
	}

	public virtual long SelectedIndex
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

	public virtual long Count
	{
		[Export("numberOfItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfItemsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfItemsHandle);
		}
	}

	public virtual bool Completes
	{
		[Export("completes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCompletesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCompletesHandle);
		}
		[Export("setCompletes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCompletes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCompletes_Handle, value);
			}
		}
	}

	public virtual NSComboBoxDataSource DataSource
	{
		[Export("dataSource")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSComboBoxDataSource)(__mt_DataSource_var = ((!IsDirectBinding) ? ((NSComboBoxDataSource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle))) : ((NSComboBoxDataSource)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle)))));
		}
		[Export("setDataSource:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value.Handle);
			}
			__mt_DataSource_var = value;
		}
	}

	public virtual NSObject SelectedValue
	{
		[Export("objectValueOfSelectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_SelectedValue_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValueOfSelectedItemHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValueOfSelectedItemHandle))));
		}
	}

	public virtual NSObject[] Values
	{
		[Export("objectValues")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject[])(__mt_Values_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValuesHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValuesHandle))));
		}
	}

	[Field("NSComboBoxSelectionDidChangeNotification", "AppKit")]
	public static NSString SelectionDidChangeNotification
	{
		get
		{
			if (_SelectionDidChangeNotification == null)
			{
				_SelectionDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSComboBoxSelectionDidChangeNotification");
			}
			return _SelectionDidChangeNotification;
		}
	}

	[Field("NSComboBoxSelectionIsChangingNotification", "AppKit")]
	public static NSString SelectionIsChangingNotification
	{
		get
		{
			if (_SelectionIsChangingNotification == null)
			{
				_SelectionIsChangingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSComboBoxSelectionIsChangingNotification");
			}
			return _SelectionIsChangingNotification;
		}
	}

	[Field("NSComboBoxWillDismissNotification", "AppKit")]
	public static NSString WillDismissNotification
	{
		get
		{
			if (_WillDismissNotification == null)
			{
				_WillDismissNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSComboBoxWillDismissNotification");
			}
			return _WillDismissNotification;
		}
	}

	[Field("NSComboBoxWillPopUpNotification", "AppKit")]
	public static NSString WillPopUpNotification
	{
		get
		{
			if (_WillPopUpNotification == null)
			{
				_WillPopUpNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSComboBoxWillPopUpNotification");
			}
			return _WillPopUpNotification;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSComboBox()
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
	public NSComboBox(NSCoder coder)
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
	public NSComboBox(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSComboBox(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSComboBox(CGRect frameRect)
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

	[Export("reloadData")]
	public virtual void ReloadData()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("noteNumberOfItemsChanged")]
	public virtual void NoteNumberOfItemsChanged()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selNoteNumberOfItemsChangedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selNoteNumberOfItemsChangedHandle);
		}
	}

	[Export("scrollItemAtIndexToTop:")]
	public virtual void ScrollItemAtIndexToTop(long scrollItemIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selScrollItemAtIndexToTop_Handle, scrollItemIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selScrollItemAtIndexToTop_Handle, scrollItemIndex);
		}
	}

	[Export("scrollItemAtIndexToVisible:")]
	public virtual void ScrollItemAtIndexToVisible(long scrollItemIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selScrollItemAtIndexToVisible_Handle, scrollItemIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selScrollItemAtIndexToVisible_Handle, scrollItemIndex);
		}
	}

	[Export("selectItemAtIndex:")]
	public virtual void SelectItem(long itemIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSelectItemAtIndex_Handle, itemIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSelectItemAtIndex_Handle, itemIndex);
		}
	}

	[Export("deselectItemAtIndex:")]
	public virtual void DeselectItem(long itemIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selDeselectItemAtIndex_Handle, itemIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selDeselectItemAtIndex_Handle, itemIndex);
		}
	}

	[Export("addItemWithObjectValue:")]
	public virtual void Add(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItemWithObjectValue_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItemWithObjectValue_Handle, object1.Handle);
		}
	}

	[Export("addItemsWithObjectValues:")]
	public virtual void Add(NSObject[] items)
	{
		NSApplication.EnsureUIThread();
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItemsWithObjectValues_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItemsWithObjectValues_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
		_ = Values;
	}

	[Export("insertItemWithObjectValue:atIndex:")]
	public virtual void Insert(NSObject object1, long index)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selInsertItemWithObjectValueAtIndex_Handle, object1.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInsertItemWithObjectValueAtIndex_Handle, object1.Handle, index);
		}
		_ = Values;
	}

	[Export("removeItemWithObjectValue:")]
	public virtual void Remove(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItemWithObjectValue_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItemWithObjectValue_Handle, object1.Handle);
		}
		_ = Values;
	}

	[Export("removeItemAtIndex:")]
	public virtual void RemoveAt(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveItemAtIndex_Handle, index);
		}
		_ = Values;
	}

	[Export("removeAllItems")]
	public virtual void RemoveAll()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllItemsHandle);
		}
		_ = Values;
	}

	[Export("selectItemWithObjectValue:")]
	public virtual void Select(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectItemWithObjectValue_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectItemWithObjectValue_Handle, object1.Handle);
		}
	}

	[Export("itemObjectValueAtIndex:")]
	public virtual NSComboBox GetItem(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSComboBox)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selItemObjectValueAtIndex_Handle, index));
		}
		return (NSComboBox)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selItemObjectValueAtIndex_Handle, index));
	}

	[Export("indexOfItemWithObjectValue:")]
	public virtual long IndexOf(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithObjectValue_Handle, object1.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithObjectValue_Handle, object1.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DataSource_var = null;
			__mt_SelectedValue_var = null;
			__mt_Values_var = null;
		}
	}
}
