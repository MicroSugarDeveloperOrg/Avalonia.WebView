using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTabView", true)]
public class NSTabView : NSView
{
	[Register]
	private sealed class _NSTabViewDelegate : NSTabViewDelegate
	{
		internal NSTabViewPredicate shouldSelectTabViewItem;

		internal EventHandler<NSTabViewItemEventArgs> willSelect;

		internal EventHandler<NSTabViewItemEventArgs> didSelect;

		internal EventHandler numberOfItemsChanged;

		[Preserve(Conditional = true)]
		public override bool ShouldSelectTabViewItem(NSTabView tabView, NSTabViewItem item)
		{
			return shouldSelectTabViewItem?.Invoke(tabView, item) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void WillSelect(NSTabView tabView, NSTabViewItem item)
		{
			EventHandler<NSTabViewItemEventArgs> eventHandler = willSelect;
			if (eventHandler != null)
			{
				NSTabViewItemEventArgs e = new NSTabViewItemEventArgs(item);
				eventHandler(tabView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidSelect(NSTabView tabView, NSTabViewItem item)
		{
			EventHandler<NSTabViewItemEventArgs> eventHandler = didSelect;
			if (eventHandler != null)
			{
				NSTabViewItemEventArgs e = new NSTabViewItemEventArgs(item);
				eventHandler(tabView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void NumberOfItemsChanged(NSTabView tabView)
		{
			numberOfItemsChanged?.Invoke(tabView, EventArgs.Empty);
		}
	}

	private static readonly IntPtr selSelectedTabViewItemHandle = Selector.GetHandle("selectedTabViewItem");

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	private static readonly IntPtr selTabViewTypeHandle = Selector.GetHandle("tabViewType");

	private static readonly IntPtr selSetTabViewType_Handle = Selector.GetHandle("setTabViewType:");

	private static readonly IntPtr selTabViewItemsHandle = Selector.GetHandle("tabViewItems");

	private static readonly IntPtr selAllowsTruncatedLabelsHandle = Selector.GetHandle("allowsTruncatedLabels");

	private static readonly IntPtr selSetAllowsTruncatedLabels_Handle = Selector.GetHandle("setAllowsTruncatedLabels:");

	private static readonly IntPtr selMinimumSizeHandle = Selector.GetHandle("minimumSize");

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	private static readonly IntPtr selControlTintHandle = Selector.GetHandle("controlTint");

	private static readonly IntPtr selSetControlTint_Handle = Selector.GetHandle("setControlTint:");

	private static readonly IntPtr selControlSizeHandle = Selector.GetHandle("controlSize");

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selContentRectHandle = Selector.GetHandle("contentRect");

	private static readonly IntPtr selNumberOfTabViewItemsHandle = Selector.GetHandle("numberOfTabViewItems");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selSelectTabViewItem_Handle = Selector.GetHandle("selectTabViewItem:");

	private static readonly IntPtr selSelectTabViewItemAtIndex_Handle = Selector.GetHandle("selectTabViewItemAtIndex:");

	private static readonly IntPtr selSelectTabViewItemWithIdentifier_Handle = Selector.GetHandle("selectTabViewItemWithIdentifier:");

	private static readonly IntPtr selTakeSelectedTabViewItemFromSender_Handle = Selector.GetHandle("takeSelectedTabViewItemFromSender:");

	private static readonly IntPtr selSelectFirstTabViewItem_Handle = Selector.GetHandle("selectFirstTabViewItem:");

	private static readonly IntPtr selSelectLastTabViewItem_Handle = Selector.GetHandle("selectLastTabViewItem:");

	private static readonly IntPtr selSelectNextTabViewItem_Handle = Selector.GetHandle("selectNextTabViewItem:");

	private static readonly IntPtr selSelectPreviousTabViewItem_Handle = Selector.GetHandle("selectPreviousTabViewItem:");

	private static readonly IntPtr selAddTabViewItem_Handle = Selector.GetHandle("addTabViewItem:");

	private static readonly IntPtr selInsertTabViewItemAtIndex_Handle = Selector.GetHandle("insertTabViewItem:atIndex:");

	private static readonly IntPtr selRemoveTabViewItem_Handle = Selector.GetHandle("removeTabViewItem:");

	private static readonly IntPtr selTabViewItemAtPoint_Handle = Selector.GetHandle("tabViewItemAtPoint:");

	private static readonly IntPtr selIndexOfTabViewItem_Handle = Selector.GetHandle("indexOfTabViewItem:");

	private static readonly IntPtr selTabViewItemAtIndex_Handle = Selector.GetHandle("tabViewItemAtIndex:");

	private static readonly IntPtr selIndexOfTabViewItemWithIdentifier_Handle = Selector.GetHandle("indexOfTabViewItemWithIdentifier:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTabView");

	private object __mt_Selected_var;

	private object __mt_Font_var;

	private object __mt_Items_var;

	private object __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSTabViewItem Selected
	{
		[Export("selectedTabViewItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTabViewItem)(__mt_Selected_var = ((!IsDirectBinding) ? ((NSTabViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedTabViewItemHandle))) : ((NSTabViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedTabViewItemHandle)))));
		}
	}

	public virtual NSFont Font
	{
		[Export("font")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFont)(__mt_Font_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle)))));
		}
		[Export("setFont:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, value.Handle);
			}
			__mt_Font_var = value;
		}
	}

	public virtual NSTabViewType TabViewType
	{
		[Export("tabViewType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTabViewType)Messaging.UInt64_objc_msgSend(base.Handle, selTabViewTypeHandle);
			}
			return (NSTabViewType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTabViewTypeHandle);
		}
		[Export("setTabViewType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTabViewType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTabViewType_Handle, (ulong)value);
			}
		}
	}

	public virtual NSTabViewItem[] Items
	{
		[Export("tabViewItems")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTabViewItem[])(__mt_Items_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSTabViewItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabViewItemsHandle)) : NSArray.ArrayFromHandle<NSTabViewItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabViewItemsHandle))));
		}
	}

	public virtual bool AllowsTruncatedLabels
	{
		[Export("allowsTruncatedLabels")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsTruncatedLabelsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsTruncatedLabelsHandle);
		}
		[Export("setAllowsTruncatedLabels:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsTruncatedLabels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsTruncatedLabels_Handle, value);
			}
		}
	}

	public virtual CGSize MinimumSize
	{
		[Export("minimumSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinimumSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinimumSizeHandle);
		}
	}

	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	public virtual NSControlTint ControlTint
	{
		[Export("controlTint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSControlTint)Messaging.UInt64_objc_msgSend(base.Handle, selControlTintHandle);
			}
			return (NSControlTint)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlTintHandle);
		}
		[Export("setControlTint:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlTint_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlTint_Handle, (ulong)value);
			}
		}
	}

	public virtual NSControlSize ControlSize
	{
		[Export("controlSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSControlSize)Messaging.UInt64_objc_msgSend(base.Handle, selControlSizeHandle);
			}
			return (NSControlSize)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlSizeHandle);
		}
		[Export("setControlSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlSize_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlSize_Handle, (ulong)value);
			}
		}
	}

	public virtual NSTabViewDelegate Delegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTabViewDelegate)(__mt_Delegate_var = ((!IsDirectBinding) ? ((NSTabViewDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle))) : ((NSTabViewDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_Delegate_var = value;
		}
	}

	public virtual CGRect ContentRect
	{
		[Export("contentRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selContentRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContentRectHandle);
			}
			return retval;
		}
	}

	public virtual long Count
	{
		[Export("numberOfTabViewItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfTabViewItemsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfTabViewItemsHandle);
		}
	}

	public NSTabViewPredicate ShouldSelectTabViewItem
	{
		get
		{
			return EnsureNSTabViewDelegate().shouldSelectTabViewItem;
		}
		set
		{
			EnsureNSTabViewDelegate().shouldSelectTabViewItem = value;
		}
	}

	public event EventHandler<NSTabViewItemEventArgs> WillSelect
	{
		add
		{
			_NSTabViewDelegate nSTabViewDelegate = EnsureNSTabViewDelegate();
			nSTabViewDelegate.willSelect = (EventHandler<NSTabViewItemEventArgs>)System.Delegate.Combine(nSTabViewDelegate.willSelect, value);
		}
		remove
		{
			_NSTabViewDelegate nSTabViewDelegate = EnsureNSTabViewDelegate();
			nSTabViewDelegate.willSelect = (EventHandler<NSTabViewItemEventArgs>)System.Delegate.Remove(nSTabViewDelegate.willSelect, value);
		}
	}

	public event EventHandler<NSTabViewItemEventArgs> DidSelect
	{
		add
		{
			_NSTabViewDelegate nSTabViewDelegate = EnsureNSTabViewDelegate();
			nSTabViewDelegate.didSelect = (EventHandler<NSTabViewItemEventArgs>)System.Delegate.Combine(nSTabViewDelegate.didSelect, value);
		}
		remove
		{
			_NSTabViewDelegate nSTabViewDelegate = EnsureNSTabViewDelegate();
			nSTabViewDelegate.didSelect = (EventHandler<NSTabViewItemEventArgs>)System.Delegate.Remove(nSTabViewDelegate.didSelect, value);
		}
	}

	public event EventHandler NumberOfItemsChanged
	{
		add
		{
			_NSTabViewDelegate nSTabViewDelegate = EnsureNSTabViewDelegate();
			nSTabViewDelegate.numberOfItemsChanged = (EventHandler)System.Delegate.Combine(nSTabViewDelegate.numberOfItemsChanged, value);
		}
		remove
		{
			_NSTabViewDelegate nSTabViewDelegate = EnsureNSTabViewDelegate();
			nSTabViewDelegate.numberOfItemsChanged = (EventHandler)System.Delegate.Remove(nSTabViewDelegate.numberOfItemsChanged, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTabView()
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
	public NSTabView(NSCoder coder)
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
	public NSTabView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTabView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSTabView(CGRect frameRect)
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

	[Export("selectTabViewItem:")]
	public virtual void Select(NSTabViewItem tabViewItem)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectTabViewItem_Handle, tabViewItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectTabViewItem_Handle, tabViewItem.Handle);
		}
	}

	[Export("selectTabViewItemAtIndex:")]
	public virtual void SelectAt(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSelectTabViewItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSelectTabViewItemAtIndex_Handle, index);
		}
	}

	[Export("selectTabViewItemWithIdentifier:")]
	public virtual void Select(NSObject identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectTabViewItemWithIdentifier_Handle, identifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectTabViewItemWithIdentifier_Handle, identifier.Handle);
		}
	}

	[Export("takeSelectedTabViewItemFromSender:")]
	public virtual void TakeSelectedTabViewItemFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeSelectedTabViewItemFromSender_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeSelectedTabViewItemFromSender_Handle, sender.Handle);
		}
	}

	[Export("selectFirstTabViewItem:")]
	public virtual void SelectFirst(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectFirstTabViewItem_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectFirstTabViewItem_Handle, sender.Handle);
		}
	}

	[Export("selectLastTabViewItem:")]
	public virtual void SelectLast(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectLastTabViewItem_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectLastTabViewItem_Handle, sender.Handle);
		}
	}

	[Export("selectNextTabViewItem:")]
	public virtual void SelectNext(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNextTabViewItem_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNextTabViewItem_Handle, sender.Handle);
		}
	}

	[Export("selectPreviousTabViewItem:")]
	public virtual void SelectPrevious(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectPreviousTabViewItem_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectPreviousTabViewItem_Handle, sender.Handle);
		}
	}

	[Export("addTabViewItem:")]
	public virtual void Add(NSTabViewItem tabViewItem)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTabViewItem_Handle, tabViewItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTabViewItem_Handle, tabViewItem.Handle);
		}
		_ = Items;
	}

	[Export("insertTabViewItem:atIndex:")]
	public virtual void Insert(NSTabViewItem tabViewItem, long index)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selInsertTabViewItemAtIndex_Handle, tabViewItem.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInsertTabViewItemAtIndex_Handle, tabViewItem.Handle, index);
		}
		_ = Items;
	}

	[Export("removeTabViewItem:")]
	public virtual void Remove(NSTabViewItem tabViewItem)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTabViewItem_Handle, tabViewItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTabViewItem_Handle, tabViewItem.Handle);
		}
		_ = Items;
	}

	[Export("tabViewItemAtPoint:")]
	public virtual NSTabViewItem TabViewItemAtPoint(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSTabViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selTabViewItemAtPoint_Handle, point));
		}
		return (NSTabViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selTabViewItemAtPoint_Handle, point));
	}

	[Export("indexOfTabViewItem:")]
	public virtual long IndexOf(NSTabViewItem tabViewItem)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selIndexOfTabViewItem_Handle, tabViewItem.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfTabViewItem_Handle, tabViewItem.Handle);
	}

	[Export("tabViewItemAtIndex:")]
	public virtual NSTabViewItem Item(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSTabViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selTabViewItemAtIndex_Handle, index));
		}
		return (NSTabViewItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selTabViewItemAtIndex_Handle, index));
	}

	[Export("indexOfTabViewItemWithIdentifier:")]
	public virtual long IndexOf(NSObject identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selIndexOfTabViewItemWithIdentifier_Handle, identifier.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfTabViewItemWithIdentifier_Handle, identifier.Handle);
	}

	private _NSTabViewDelegate EnsureNSTabViewDelegate()
	{
		NSTabViewDelegate nSTabViewDelegate = Delegate;
		if (nSTabViewDelegate == null || !(nSTabViewDelegate is _NSTabViewDelegate))
		{
			nSTabViewDelegate = (Delegate = new _NSTabViewDelegate());
		}
		return (_NSTabViewDelegate)nSTabViewDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Selected_var = null;
			__mt_Font_var = null;
			__mt_Items_var = null;
			__mt_Delegate_var = null;
		}
	}
}
