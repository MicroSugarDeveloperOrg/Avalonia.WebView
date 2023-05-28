using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSPopUpButtonCell", true)]
public class NSPopUpButtonCell : NSMenuItemCell, INSMenuItemValidation, INativeObject, IDisposable
{
	public new static class Notifications
	{
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
	private const string selAddItemWithTitle_ = "addItemWithTitle:";

	private static readonly IntPtr selAddItemWithTitle_Handle = Selector.GetHandle("addItemWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddItemsWithTitles_ = "addItemsWithTitles:";

	private static readonly IntPtr selAddItemsWithTitles_Handle = Selector.GetHandle("addItemsWithTitles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAltersStateOfSelectedItem = "altersStateOfSelectedItem";

	private static readonly IntPtr selAltersStateOfSelectedItemHandle = Selector.GetHandle("altersStateOfSelectedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrowPosition = "arrowPosition";

	private static readonly IntPtr selArrowPositionHandle = Selector.GetHandle("arrowPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachPopUpWithFrame_InView_ = "attachPopUpWithFrame:inView:";

	private static readonly IntPtr selAttachPopUpWithFrame_InView_Handle = Selector.GetHandle("attachPopUpWithFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoenablesItems = "autoenablesItems";

	private static readonly IntPtr selAutoenablesItemsHandle = Selector.GetHandle("autoenablesItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDismissPopUp = "dismissPopUp";

	private static readonly IntPtr selDismissPopUpHandle = Selector.GetHandle("dismissPopUp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItem_ = "indexOfItem:";

	private static readonly IntPtr selIndexOfItem_Handle = Selector.GetHandle("indexOfItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithRepresentedObject_ = "indexOfItemWithRepresentedObject:";

	private static readonly IntPtr selIndexOfItemWithRepresentedObject_Handle = Selector.GetHandle("indexOfItemWithRepresentedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithTag_ = "indexOfItemWithTag:";

	private static readonly IntPtr selIndexOfItemWithTag_Handle = Selector.GetHandle("indexOfItemWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithTarget_AndAction_ = "indexOfItemWithTarget:andAction:";

	private static readonly IntPtr selIndexOfItemWithTarget_AndAction_Handle = Selector.GetHandle("indexOfItemWithTarget:andAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfItemWithTitle_ = "indexOfItemWithTitle:";

	private static readonly IntPtr selIndexOfItemWithTitle_Handle = Selector.GetHandle("indexOfItemWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfSelectedItem = "indexOfSelectedItem";

	private static readonly IntPtr selIndexOfSelectedItemHandle = Selector.GetHandle("indexOfSelectedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitImageCell_ = "initImageCell:";

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_PullsDown_ = "initTextCell:pullsDown:";

	private static readonly IntPtr selInitTextCell_PullsDown_Handle = Selector.GetHandle("initTextCell:pullsDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItemWithTitle_AtIndex_ = "insertItemWithTitle:atIndex:";

	private static readonly IntPtr selInsertItemWithTitle_AtIndex_Handle = Selector.GetHandle("insertItemWithTitle:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemArray = "itemArray";

	private static readonly IntPtr selItemArrayHandle = Selector.GetHandle("itemArray");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtIndex_ = "itemAtIndex:";

	private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemTitleAtIndex_ = "itemTitleAtIndex:";

	private static readonly IntPtr selItemTitleAtIndex_Handle = Selector.GetHandle("itemTitleAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemTitles = "itemTitles";

	private static readonly IntPtr selItemTitlesHandle = Selector.GetHandle("itemTitles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemWithTitle_ = "itemWithTitle:";

	private static readonly IntPtr selItemWithTitle_Handle = Selector.GetHandle("itemWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastItem = "lastItem";

	private static readonly IntPtr selLastItemHandle = Selector.GetHandle("lastItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenu = "menu";

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfItems = "numberOfItems";

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectValue = "objectValue";

	private static readonly IntPtr selObjectValueHandle = Selector.GetHandle("objectValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformClickWithFrame_InView_ = "performClickWithFrame:inView:";

	private static readonly IntPtr selPerformClickWithFrame_InView_Handle = Selector.GetHandle("performClickWithFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredEdge = "preferredEdge";

	private static readonly IntPtr selPreferredEdgeHandle = Selector.GetHandle("preferredEdge");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPullsDown = "pullsDown";

	private static readonly IntPtr selPullsDownHandle = Selector.GetHandle("pullsDown");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllItems = "removeAllItems";

	private static readonly IntPtr selRemoveAllItemsHandle = Selector.GetHandle("removeAllItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemAtIndex_ = "removeItemAtIndex:";

	private static readonly IntPtr selRemoveItemAtIndex_Handle = Selector.GetHandle("removeItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemWithTitle_ = "removeItemWithTitle:";

	private static readonly IntPtr selRemoveItemWithTitle_Handle = Selector.GetHandle("removeItemWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectItem_ = "selectItem:";

	private static readonly IntPtr selSelectItem_Handle = Selector.GetHandle("selectItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectItemAtIndex_ = "selectItemAtIndex:";

	private static readonly IntPtr selSelectItemAtIndex_Handle = Selector.GetHandle("selectItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectItemWithTag_ = "selectItemWithTag:";

	private static readonly IntPtr selSelectItemWithTag_Handle = Selector.GetHandle("selectItemWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectItemWithTitle_ = "selectItemWithTitle:";

	private static readonly IntPtr selSelectItemWithTitle_Handle = Selector.GetHandle("selectItemWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedItem = "selectedItem";

	private static readonly IntPtr selSelectedItemHandle = Selector.GetHandle("selectedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAltersStateOfSelectedItem_ = "setAltersStateOfSelectedItem:";

	private static readonly IntPtr selSetAltersStateOfSelectedItem_Handle = Selector.GetHandle("setAltersStateOfSelectedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArrowPosition_ = "setArrowPosition:";

	private static readonly IntPtr selSetArrowPosition_Handle = Selector.GetHandle("setArrowPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoenablesItems_ = "setAutoenablesItems:";

	private static readonly IntPtr selSetAutoenablesItems_Handle = Selector.GetHandle("setAutoenablesItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenu_ = "setMenu:";

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObjectValue_ = "setObjectValue:";

	private static readonly IntPtr selSetObjectValue_Handle = Selector.GetHandle("setObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredEdge_ = "setPreferredEdge:";

	private static readonly IntPtr selSetPreferredEdge_Handle = Selector.GetHandle("setPreferredEdge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPullsDown_ = "setPullsDown:";

	private static readonly IntPtr selSetPullsDown_Handle = Selector.GetHandle("setPullsDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesItemFromMenu_ = "setUsesItemFromMenu:";

	private static readonly IntPtr selSetUsesItemFromMenu_Handle = Selector.GetHandle("setUsesItemFromMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeTitleAndSelectedItem = "synchronizeTitleAndSelectedItem";

	private static readonly IntPtr selSynchronizeTitleAndSelectedItemHandle = Selector.GetHandle("synchronizeTitleAndSelectedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleOfSelectedItem = "titleOfSelectedItem";

	private static readonly IntPtr selTitleOfSelectedItemHandle = Selector.GetHandle("titleOfSelectedItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesItemFromMenu = "usesItemFromMenu";

	private static readonly IntPtr selUsesItemFromMenuHandle = Selector.GetHandle("usesItemFromMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateMenuItem_ = "validateMenuItem:";

	private static readonly IntPtr selValidateMenuItem_Handle = Selector.GetHandle("validateMenuItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPopUpButtonCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillPopUpNotification;

	public NSMenuItem this[nint idx] => ItemAt(idx);

	public NSMenuItem this[string title] => ItemWithTitle(title);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AltersStateOfSelectedItem
	{
		[Export("altersStateOfSelectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAltersStateOfSelectedItemHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAltersStateOfSelectedItemHandle);
		}
		[Export("setAltersStateOfSelectedItem:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAltersStateOfSelectedItem_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAltersStateOfSelectedItem_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPopUpArrowPosition ArrowPosition
	{
		[Export("arrowPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPopUpArrowPosition)Messaging.UInt64_objc_msgSend(base.Handle, selArrowPositionHandle);
			}
			return (NSPopUpArrowPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selArrowPositionHandle);
		}
		[Export("setArrowPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetArrowPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetArrowPosition_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutoenablesItems
	{
		[Export("autoenablesItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoenablesItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoenablesItemsHandle);
		}
		[Export("setAutoenablesItems:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoenablesItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoenablesItems_Handle, value);
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
	public virtual string[] ItemTitles
	{
		[Export("itemTitles")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selItemTitlesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemTitlesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem[] Items
	{
		[Export("itemArray")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemArrayHandle));
			}
			return NSArray.ArrayFromHandle<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemArrayHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem LastItem
	{
		[Export("lastItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastItemHandle));
			}
			return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSMenu? Menu
	{
		[Export("menu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle));
			}
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle));
		}
		[Export("setMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject ObjectValue
	{
		[Export("objectValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValueHandle));
		}
		[Export("setObjectValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectValue_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRectEdge PreferredEdge
	{
		[Export("preferredEdge")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSRectEdge)Messaging.UInt64_objc_msgSend(base.Handle, selPreferredEdgeHandle);
			}
			return (NSRectEdge)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPreferredEdgeHandle);
		}
		[Export("setPreferredEdge:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPreferredEdge_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPreferredEdge_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PullsDown
	{
		[Export("pullsDown")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPullsDownHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPullsDownHandle);
		}
		[Export("setPullsDown:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPullsDown_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPullsDown_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem SelectedItem
	{
		[Export("selectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedItemHandle));
			}
			return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedItemHandle));
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
	public virtual string TitleOfSelectedItem
	{
		[Export("titleOfSelectedItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleOfSelectedItemHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleOfSelectedItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesItemFromMenu
	{
		[Export("usesItemFromMenu")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesItemFromMenuHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesItemFromMenuHandle);
		}
		[Export("setUsesItemFromMenu:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesItemFromMenu_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesItemFromMenu_Handle, value);
			}
		}
	}

	[Field("NSPopUpButtonCellWillPopUpNotification", "AppKit")]
	[Advice("Use NSPopUpButtonCell.Notifications.ObserveWillPopUp helper method instead.")]
	public static NSString WillPopUpNotification
	{
		get
		{
			if (_WillPopUpNotification == null)
			{
				_WillPopUpNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPopUpButtonCellWillPopUpNotification");
			}
			return _WillPopUpNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPopUpButtonCell()
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
	public NSPopUpButtonCell(NSCoder coder)
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
	protected NSPopUpButtonCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPopUpButtonCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPopUpButtonCell(string aString)
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

	[Export("initImageCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPopUpButtonCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
	}

	[Export("initTextCell:pullsDown:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPopUpButtonCell(string stringValue, bool pullDown)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (stringValue == null)
		{
			throw new ArgumentNullException("stringValue");
		}
		IntPtr arg = NSString.CreateNative(stringValue);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitTextCell_PullsDown_Handle, arg, pullDown), "initTextCell:pullsDown:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitTextCell_PullsDown_Handle, arg, pullDown), "initTextCell:pullsDown:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addItemWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddItem(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItemWithTitle_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItemWithTitle_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addItemsWithTitles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddItems(string[] itemTitles)
	{
		NSApplication.EnsureUIThread();
		if (itemTitles == null)
		{
			throw new ArgumentNullException("itemTitles");
		}
		NSArray nSArray = NSArray.FromStrings(itemTitles);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddItemsWithTitles_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddItemsWithTitles_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("attachPopUpWithFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AttachPopUp(CGRect cellFrame, NSView inView)
	{
		NSApplication.EnsureUIThread();
		if (inView == null)
		{
			throw new ArgumentNullException("inView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selAttachPopUpWithFrame_InView_Handle, cellFrame, inView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selAttachPopUpWithFrame_InView_Handle, cellFrame, inView.Handle);
		}
	}

	[Export("dismissPopUp")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DismissPopUp()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDismissPopUpHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDismissPopUpHandle);
		}
	}

	[Export("itemTitleAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetItemTitle(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemTitleAtIndex_Handle, index));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemTitleAtIndex_Handle, index));
	}

	[Export("indexOfItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(NSMenuItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfItem_Handle, item.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItem_Handle, item.Handle);
	}

	[Export("indexOfItemWithRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfItemWithRepresentedObject(NSObject obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithRepresentedObject_Handle, obj.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithRepresentedObject_Handle, obj.Handle);
	}

	[Export("indexOfItemWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfItemWithTag(nint tag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selIndexOfItemWithTag_Handle, tag);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selIndexOfItemWithTag_Handle, tag);
	}

	[Export("indexOfItemWithTarget:andAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfItemWithTargetandAction(NSObject target, Selector actionSelector)
	{
		NSApplication.EnsureUIThread();
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (actionSelector == null)
		{
			throw new ArgumentNullException("actionSelector");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr_IntPtr(base.Handle, selIndexOfItemWithTarget_AndAction_Handle, target.Handle, actionSelector.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIndexOfItemWithTarget_AndAction_Handle, target.Handle, actionSelector.Handle);
	}

	[Export("indexOfItemWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfItemWithTitle(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfItemWithTitle_Handle, arg) : Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfItemWithTitle_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("insertItemWithTitle:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertItem(string title, nint index)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertItemWithTitle_AtIndex_Handle, arg, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertItemWithTitle_AtIndex_Handle, arg, index);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("itemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem ItemAt(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemAtIndex_Handle, index));
	}

	[Export("itemWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenuItem ItemWithTitle(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSMenuItem result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemWithTitle_Handle, arg)) : Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemWithTitle_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("performClickWithFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformClick(CGRect withFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selPerformClickWithFrame_InView_Handle, withFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selPerformClickWithFrame_InView_Handle, withFrame, controlView.Handle);
		}
	}

	[Export("removeAllItems")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllItems()
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

	[Export("removeItemWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItem(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItemWithTitle_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItemWithTitle_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItemAt(nint index)
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

	[Export("selectItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectItem(NSMenuItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectItem_Handle, item.Handle);
		}
	}

	[Export("selectItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectItemAt(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selSelectItemAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSelectItemAtIndex_Handle, index);
		}
	}

	[Export("selectItemWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectItemWithTag(nint tag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selSelectItemWithTag_Handle, tag);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selSelectItemWithTag_Handle, tag);
	}

	[Export("selectItemWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectItemWithTitle(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectItemWithTitle_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectItemWithTitle_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTitle(string aString)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("synchronizeTitleAndSelectedItem")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SynchronizeTitleAndSelectedItem()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSynchronizeTitleAndSelectedItemHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSynchronizeTitleAndSelectedItemHandle);
		}
	}

	[Export("validateMenuItem:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateMenuItem(NSMenuItem menuItem)
	{
		NSApplication.EnsureUIThread();
		if (menuItem == null)
		{
			throw new ArgumentNullException("menuItem");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateMenuItem_Handle, menuItem.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateMenuItem_Handle, menuItem.Handle);
	}
}
