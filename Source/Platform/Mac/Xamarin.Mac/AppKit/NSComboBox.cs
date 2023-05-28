using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSComboBox", true)]
public class NSComboBox : NSTextField
{
	[Register]
	internal class _NSComboBoxDelegate : _NSTextFieldDelegate, INSComboBoxDelegate, INativeObject, IDisposable, INSTextFieldDelegate
	{
		internal EventHandler? selectionChanged;

		internal EventHandler? selectionIsChanging;

		internal EventHandler? willDismiss;

		internal EventHandler? willPopUp;

		public _NSComboBoxDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("comboBoxSelectionDidChange:")]
		public void SelectionChanged(NSNotification notification)
		{
			selectionChanged?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("comboBoxSelectionIsChanging:")]
		public void SelectionIsChanging(NSNotification notification)
		{
			selectionIsChanging?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("comboBoxWillDismiss:")]
		public void WillDismiss(NSNotification notification)
		{
			willDismiss?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("comboBoxWillPopUp:")]
		public void WillPopUp(NSNotification notification)
		{
			willPopUp?.Invoke(notification, EventArgs.Empty);
		}
	}

	public new static class Notifications
	{
		public static NSObject ObserveSelectionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveSelectionIsChanging(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionIsChangingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectionIsChanging(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectionIsChangingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillDismiss(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillDismissNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillDismiss(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillDismissNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillPopUp(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillPopUpNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillPopUp(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillPopUpNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddItemWithObjectValue_ = "addItemWithObjectValue:";

	private static readonly IntPtr selAddItemWithObjectValue_Handle = Selector.GetHandle("addItemWithObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddItemsWithObjectValues_ = "addItemsWithObjectValues:";

	private static readonly IntPtr selAddItemsWithObjectValues_Handle = Selector.GetHandle("addItemsWithObjectValues:");

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
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSComboBox");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_DataSource_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectionIsChangingNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillDismissNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillPopUpNotification;

	public NSObject this[nint index] => GetItemObject(index);

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
	public virtual INSComboBoxDataSource? DataSource
	{
		[Export("dataSource", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			INSComboBoxDataSource iNSComboBoxDataSource = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSComboBoxDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle), owns: false) : Runtime.GetINativeObject<INSComboBoxDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle), owns: false));
			MarkDirty();
			__mt_DataSource_var = iNSComboBoxDataSource;
			return iNSComboBoxDataSource;
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
	public new INSComboBoxDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSComboBoxDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
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

	[Field("NSComboBoxSelectionDidChangeNotification", "AppKit")]
	[Advice("Use NSComboBox.Notifications.ObserveSelectionDidChange helper method instead.")]
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
	[Advice("Use NSComboBox.Notifications.ObserveSelectionIsChanging helper method instead.")]
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
	[Advice("Use NSComboBox.Notifications.ObserveWillDismiss helper method instead.")]
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
	[Advice("Use NSComboBox.Notifications.ObserveWillPopUp helper method instead.")]
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

	internal override Type GetInternalEventDelegateType => typeof(_NSComboBoxDelegate);

	public event EventHandler SelectionChanged
	{
		add
		{
			_NSComboBoxDelegate nSComboBoxDelegate = EnsureNSComboBoxDelegate();
			nSComboBoxDelegate.selectionChanged = (EventHandler)System.Delegate.Combine(nSComboBoxDelegate.selectionChanged, value);
		}
		remove
		{
			_NSComboBoxDelegate nSComboBoxDelegate = EnsureNSComboBoxDelegate();
			nSComboBoxDelegate.selectionChanged = (EventHandler)System.Delegate.Remove(nSComboBoxDelegate.selectionChanged, value);
		}
	}

	public event EventHandler SelectionIsChanging
	{
		add
		{
			_NSComboBoxDelegate nSComboBoxDelegate = EnsureNSComboBoxDelegate();
			nSComboBoxDelegate.selectionIsChanging = (EventHandler)System.Delegate.Combine(nSComboBoxDelegate.selectionIsChanging, value);
		}
		remove
		{
			_NSComboBoxDelegate nSComboBoxDelegate = EnsureNSComboBoxDelegate();
			nSComboBoxDelegate.selectionIsChanging = (EventHandler)System.Delegate.Remove(nSComboBoxDelegate.selectionIsChanging, value);
		}
	}

	public event EventHandler WillDismiss
	{
		add
		{
			_NSComboBoxDelegate nSComboBoxDelegate = EnsureNSComboBoxDelegate();
			nSComboBoxDelegate.willDismiss = (EventHandler)System.Delegate.Combine(nSComboBoxDelegate.willDismiss, value);
		}
		remove
		{
			_NSComboBoxDelegate nSComboBoxDelegate = EnsureNSComboBoxDelegate();
			nSComboBoxDelegate.willDismiss = (EventHandler)System.Delegate.Remove(nSComboBoxDelegate.willDismiss, value);
		}
	}

	public event EventHandler WillPopUp
	{
		add
		{
			_NSComboBoxDelegate nSComboBoxDelegate = EnsureNSComboBoxDelegate();
			nSComboBoxDelegate.willPopUp = (EventHandler)System.Delegate.Combine(nSComboBoxDelegate.willPopUp, value);
		}
		remove
		{
			_NSComboBoxDelegate nSComboBoxDelegate = EnsureNSComboBoxDelegate();
			nSComboBoxDelegate.willPopUp = (EventHandler)System.Delegate.Remove(nSComboBoxDelegate.willPopUp, value);
		}
	}

	[Obsolete("Use GetItemObject instead.")]
	public virtual NSComboBox GetItem(nint index)
	{
		return (NSComboBox)GetItemObject(index);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSComboBox()
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
	public NSComboBox(NSCoder coder)
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
	protected NSComboBox(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSComboBox(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSComboBox(CGRect frameRect)
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
	public virtual NSObject GetItemObject(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemObjectValueAtIndex_Handle, index));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemObjectValueAtIndex_Handle, index));
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

	internal override _NSTextFieldDelegate CreateInternalEventDelegateType()
	{
		return new _NSComboBoxDelegate();
	}

	internal _NSComboBoxDelegate EnsureNSComboBoxDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSComboBoxDelegate nSComboBoxDelegate = Delegate as _NSComboBoxDelegate;
		if (nSComboBoxDelegate == null)
		{
			nSComboBoxDelegate = (_NSComboBoxDelegate)(Delegate = (_NSComboBoxDelegate)CreateInternalEventDelegateType());
		}
		return nSComboBoxDelegate;
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
