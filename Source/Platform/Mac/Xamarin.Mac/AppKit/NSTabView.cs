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
	internal class _NSTabViewDelegate : NSObject, INSTabViewDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSTabViewItemEventArgs>? didSelect;

		internal EventHandler? numberOfItemsChanged;

		internal NSTabViewPredicate? shouldSelectTabViewItem;

		internal EventHandler<NSTabViewItemEventArgs>? willSelect;

		public _NSTabViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("tabView:didSelectTabViewItem:")]
		public void DidSelect(NSTabView tabView, NSTabViewItem item)
		{
			EventHandler<NSTabViewItemEventArgs> eventHandler = didSelect;
			if (eventHandler != null)
			{
				NSTabViewItemEventArgs e = new NSTabViewItemEventArgs(item);
				eventHandler(tabView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("tabViewDidChangeNumberOfTabViewItems:")]
		public void NumberOfItemsChanged(NSTabView tabView)
		{
			numberOfItemsChanged?.Invoke(tabView, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("tabView:shouldSelectTabViewItem:")]
		public bool ShouldSelectTabViewItem(NSTabView tabView, NSTabViewItem item)
		{
			return shouldSelectTabViewItem?.Invoke(tabView, item) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("tabView:willSelectTabViewItem:")]
		public void WillSelect(NSTabView tabView, NSTabViewItem item)
		{
			EventHandler<NSTabViewItemEventArgs> eventHandler = willSelect;
			if (eventHandler != null)
			{
				NSTabViewItemEventArgs e = new NSTabViewItemEventArgs(item);
				eventHandler(tabView, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTabViewItem_ = "addTabViewItem:";

	private static readonly IntPtr selAddTabViewItem_Handle = Selector.GetHandle("addTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsTruncatedLabels = "allowsTruncatedLabels";

	private static readonly IntPtr selAllowsTruncatedLabelsHandle = Selector.GetHandle("allowsTruncatedLabels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentRect = "contentRect";

	private static readonly IntPtr selContentRectHandle = Selector.GetHandle("contentRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlSize = "controlSize";

	private static readonly IntPtr selControlSizeHandle = Selector.GetHandle("controlSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlTint = "controlTint";

	private static readonly IntPtr selControlTintHandle = Selector.GetHandle("controlTint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsBackground = "drawsBackground";

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFont = "font";

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfTabViewItem_ = "indexOfTabViewItem:";

	private static readonly IntPtr selIndexOfTabViewItem_Handle = Selector.GetHandle("indexOfTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfTabViewItemWithIdentifier_ = "indexOfTabViewItemWithIdentifier:";

	private static readonly IntPtr selIndexOfTabViewItemWithIdentifier_Handle = Selector.GetHandle("indexOfTabViewItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertTabViewItem_AtIndex_ = "insertTabViewItem:atIndex:";

	private static readonly IntPtr selInsertTabViewItem_AtIndex_Handle = Selector.GetHandle("insertTabViewItem:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumSize = "minimumSize";

	private static readonly IntPtr selMinimumSizeHandle = Selector.GetHandle("minimumSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfTabViewItems = "numberOfTabViewItems";

	private static readonly IntPtr selNumberOfTabViewItemsHandle = Selector.GetHandle("numberOfTabViewItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTabViewItem_ = "removeTabViewItem:";

	private static readonly IntPtr selRemoveTabViewItem_Handle = Selector.GetHandle("removeTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectFirstTabViewItem_ = "selectFirstTabViewItem:";

	private static readonly IntPtr selSelectFirstTabViewItem_Handle = Selector.GetHandle("selectFirstTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectLastTabViewItem_ = "selectLastTabViewItem:";

	private static readonly IntPtr selSelectLastTabViewItem_Handle = Selector.GetHandle("selectLastTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectNextTabViewItem_ = "selectNextTabViewItem:";

	private static readonly IntPtr selSelectNextTabViewItem_Handle = Selector.GetHandle("selectNextTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectPreviousTabViewItem_ = "selectPreviousTabViewItem:";

	private static readonly IntPtr selSelectPreviousTabViewItem_Handle = Selector.GetHandle("selectPreviousTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectTabViewItem_ = "selectTabViewItem:";

	private static readonly IntPtr selSelectTabViewItem_Handle = Selector.GetHandle("selectTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectTabViewItemAtIndex_ = "selectTabViewItemAtIndex:";

	private static readonly IntPtr selSelectTabViewItemAtIndex_Handle = Selector.GetHandle("selectTabViewItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectTabViewItemWithIdentifier_ = "selectTabViewItemWithIdentifier:";

	private static readonly IntPtr selSelectTabViewItemWithIdentifier_Handle = Selector.GetHandle("selectTabViewItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedTabViewItem = "selectedTabViewItem";

	private static readonly IntPtr selSelectedTabViewItemHandle = Selector.GetHandle("selectedTabViewItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsTruncatedLabels_ = "setAllowsTruncatedLabels:";

	private static readonly IntPtr selSetAllowsTruncatedLabels_Handle = Selector.GetHandle("setAllowsTruncatedLabels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlSize_ = "setControlSize:";

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlTint_ = "setControlTint:";

	private static readonly IntPtr selSetControlTint_Handle = Selector.GetHandle("setControlTint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsBackground_ = "setDrawsBackground:";

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFont_ = "setFont:";

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabPosition_ = "setTabPosition:";

	private static readonly IntPtr selSetTabPosition_Handle = Selector.GetHandle("setTabPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabViewBorderType_ = "setTabViewBorderType:";

	private static readonly IntPtr selSetTabViewBorderType_Handle = Selector.GetHandle("setTabViewBorderType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabViewItems_ = "setTabViewItems:";

	private static readonly IntPtr selSetTabViewItems_Handle = Selector.GetHandle("setTabViewItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabViewType_ = "setTabViewType:";

	private static readonly IntPtr selSetTabViewType_Handle = Selector.GetHandle("setTabViewType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabPosition = "tabPosition";

	private static readonly IntPtr selTabPositionHandle = Selector.GetHandle("tabPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabViewBorderType = "tabViewBorderType";

	private static readonly IntPtr selTabViewBorderTypeHandle = Selector.GetHandle("tabViewBorderType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabViewItemAtIndex_ = "tabViewItemAtIndex:";

	private static readonly IntPtr selTabViewItemAtIndex_Handle = Selector.GetHandle("tabViewItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabViewItemAtPoint_ = "tabViewItemAtPoint:";

	private static readonly IntPtr selTabViewItemAtPoint_Handle = Selector.GetHandle("tabViewItemAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabViewItems = "tabViewItems";

	private static readonly IntPtr selTabViewItemsHandle = Selector.GetHandle("tabViewItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabViewType = "tabViewType";

	private static readonly IntPtr selTabViewTypeHandle = Selector.GetHandle("tabViewType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeSelectedTabViewItemFromSender_ = "takeSelectedTabViewItemFromSender:";

	private static readonly IntPtr selTakeSelectedTabViewItemFromSender_Handle = Selector.GetHandle("takeSelectedTabViewItemFromSender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTabView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsTruncatedLabels
	{
		[Export("allowsTruncatedLabels")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsTruncatedLabelsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsTruncatedLabelsHandle);
		}
		[Export("setAllowsTruncatedLabels:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsTruncatedLabels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsTruncatedLabels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSTabViewBorderType BorderType
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("tabViewBorderType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTabViewBorderType)Messaging.UInt64_objc_msgSend(base.Handle, selTabViewBorderTypeHandle);
			}
			return (NSTabViewBorderType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTabViewBorderTypeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setTabViewBorderType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTabViewBorderType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTabViewBorderType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ContentRect
	{
		[Export("contentRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSControlSize ControlSize
	{
		[Export("controlSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSControlSize)Messaging.UInt64_objc_msgSend(base.Handle, selControlSizeHandle);
			}
			return (NSControlSize)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlSizeHandle);
		}
		[Export("setControlSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlSize_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlSize_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "The 'ControlTint' property is not honored on 10.14.")]
	public virtual NSControlTint ControlTint
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "The 'ControlTint' property is not honored on 10.14.")]
		[Export("controlTint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSControlTint)Messaging.UInt64_objc_msgSend(base.Handle, selControlTintHandle);
			}
			return (NSControlTint)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlTintHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "The 'ControlTint' property is not honored on 10.14.")]
		[Export("setControlTint:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlTint_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlTint_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Count
	{
		[Export("numberOfTabViewItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfTabViewItemsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfTabViewItemsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSTabViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSTabViewDelegate;
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
	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont Font
	{
		[Export("font", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle));
			}
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle));
		}
		[Export("setFont:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTabViewItem[] Items
	{
		[Export("tabViewItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSTabViewItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabViewItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSTabViewItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabViewItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MinimumSize
	{
		[Export("minimumSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinimumSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinimumSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTabViewItem Selected
	{
		[Export("selectedTabViewItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTabViewItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedTabViewItemHandle));
			}
			return Runtime.GetNSObject<NSTabViewItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedTabViewItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSTabPosition TabPosition
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("tabPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTabPosition)Messaging.UInt64_objc_msgSend(base.Handle, selTabPositionHandle);
			}
			return (NSTabPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTabPositionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setTabPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTabPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTabPosition_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTabViewType TabViewType
	{
		[Export("tabViewType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTabViewType)Messaging.UInt64_objc_msgSend(base.Handle, selTabViewTypeHandle);
			}
			return (NSTabViewType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTabViewTypeHandle);
		}
		[Export("setTabViewType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTabViewType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTabViewType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSTabViewDelegate);

	public NSTabViewPredicate? ShouldSelectTabViewItem
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTabView()
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
	public NSTabView(NSCoder coder)
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
	protected NSTabView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTabView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTabView(CGRect frameRect)
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

	[Export("addTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(NSTabViewItem tabViewItem)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTabViewItem_Handle, tabViewItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTabViewItem_Handle, tabViewItem.Handle);
		}
	}

	[Export("indexOfTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(NSTabViewItem tabViewItem)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfTabViewItem_Handle, tabViewItem.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfTabViewItem_Handle, tabViewItem.Handle);
	}

	[Export("indexOfTabViewItemWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(NSObject identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfTabViewItemWithIdentifier_Handle, identifier.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfTabViewItemWithIdentifier_Handle, identifier.Handle);
	}

	[Export("insertTabViewItem:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSTabViewItem tabViewItem, nint index)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertTabViewItem_AtIndex_Handle, tabViewItem.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertTabViewItem_AtIndex_Handle, tabViewItem.Handle, index);
		}
	}

	[Export("tabViewItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTabViewItem Item(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTabViewItem>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selTabViewItemAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSTabViewItem>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selTabViewItemAtIndex_Handle, index));
	}

	[Export("removeTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(NSTabViewItem tabViewItem)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTabViewItem_Handle, tabViewItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTabViewItem_Handle, tabViewItem.Handle);
		}
	}

	[Export("selectTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Select(NSTabViewItem tabViewItem)
	{
		NSApplication.EnsureUIThread();
		if (tabViewItem == null)
		{
			throw new ArgumentNullException("tabViewItem");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectTabViewItem_Handle, tabViewItem.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectTabViewItem_Handle, tabViewItem.Handle);
		}
	}

	[Export("selectTabViewItemWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Select(NSObject identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectTabViewItemWithIdentifier_Handle, identifier.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectTabViewItemWithIdentifier_Handle, identifier.Handle);
		}
	}

	[Export("selectTabViewItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectAt(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selSelectTabViewItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSelectTabViewItemAtIndex_Handle, index);
		}
	}

	[Export("selectFirstTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectFirst(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectFirstTabViewItem_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectFirstTabViewItem_Handle, sender.Handle);
		}
	}

	[Export("selectLastTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectLast(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectLastTabViewItem_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectLastTabViewItem_Handle, sender.Handle);
		}
	}

	[Export("selectNextTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectNext(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNextTabViewItem_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNextTabViewItem_Handle, sender.Handle);
		}
	}

	[Export("selectPreviousTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectPrevious(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectPreviousTabViewItem_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectPreviousTabViewItem_Handle, sender.Handle);
		}
	}

	[Export("setTabViewItems:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetItems(NSTabViewItem[] items)
	{
		NSApplication.EnsureUIThread();
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTabViewItems_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTabViewItems_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("tabViewItemAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTabViewItem TabViewItemAtPoint(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTabViewItem>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selTabViewItemAtPoint_Handle, point));
		}
		return Runtime.GetNSObject<NSTabViewItem>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selTabViewItemAtPoint_Handle, point));
	}

	[Export("takeSelectedTabViewItemFromSender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TakeSelectedTabViewItemFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeSelectedTabViewItemFromSender_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeSelectedTabViewItemFromSender_Handle, sender.Handle);
		}
	}

	internal virtual _NSTabViewDelegate CreateInternalEventDelegateType()
	{
		return new _NSTabViewDelegate();
	}

	internal _NSTabViewDelegate EnsureNSTabViewDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSTabViewDelegate nSTabViewDelegate = Delegate as _NSTabViewDelegate;
		if (nSTabViewDelegate == null)
		{
			nSTabViewDelegate = (_NSTabViewDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSTabViewDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
