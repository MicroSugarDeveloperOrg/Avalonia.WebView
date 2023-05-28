using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSTabViewController", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSTabViewController : NSViewController, INSTabViewDelegate, INativeObject, IDisposable, INSToolbarDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTabViewItem_ = "addTabViewItem:";

	private static readonly IntPtr selAddTabViewItem_Handle = Selector.GetHandle("addTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPropagateSelectedChildViewControllerTitle = "canPropagateSelectedChildViewControllerTitle";

	private static readonly IntPtr selCanPropagateSelectedChildViewControllerTitleHandle = Selector.GetHandle("canPropagateSelectedChildViewControllerTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertTabViewItem_AtIndex_ = "insertTabViewItem:atIndex:";

	private static readonly IntPtr selInsertTabViewItem_AtIndex_Handle = Selector.GetHandle("insertTabViewItem:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTabViewItem_ = "removeTabViewItem:";

	private static readonly IntPtr selRemoveTabViewItem_Handle = Selector.GetHandle("removeTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegmentedControl = "segmentedControl";

	private static readonly IntPtr selSegmentedControlHandle = Selector.GetHandle("segmentedControl");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedTabViewItemIndex = "selectedTabViewItemIndex";

	private static readonly IntPtr selSelectedTabViewItemIndexHandle = Selector.GetHandle("selectedTabViewItemIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanPropagateSelectedChildViewControllerTitle_ = "setCanPropagateSelectedChildViewControllerTitle:";

	private static readonly IntPtr selSetCanPropagateSelectedChildViewControllerTitle_Handle = Selector.GetHandle("setCanPropagateSelectedChildViewControllerTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSegmentedControl_ = "setSegmentedControl:";

	private static readonly IntPtr selSetSegmentedControl_Handle = Selector.GetHandle("setSegmentedControl:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedTabViewItemIndex_ = "setSelectedTabViewItemIndex:";

	private static readonly IntPtr selSetSelectedTabViewItemIndex_Handle = Selector.GetHandle("setSelectedTabViewItemIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabStyle_ = "setTabStyle:";

	private static readonly IntPtr selSetTabStyle_Handle = Selector.GetHandle("setTabStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabView_ = "setTabView:";

	private static readonly IntPtr selSetTabView_Handle = Selector.GetHandle("setTabView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabViewItems_ = "setTabViewItems:";

	private static readonly IntPtr selSetTabViewItems_Handle = Selector.GetHandle("setTabViewItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransitionOptions_ = "setTransitionOptions:";

	private static readonly IntPtr selSetTransitionOptions_Handle = Selector.GetHandle("setTransitionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabStyle = "tabStyle";

	private static readonly IntPtr selTabStyleHandle = Selector.GetHandle("tabStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabView = "tabView";

	private static readonly IntPtr selTabViewHandle = Selector.GetHandle("tabView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabView_DidSelectTabViewItem_ = "tabView:didSelectTabViewItem:";

	private static readonly IntPtr selTabView_DidSelectTabViewItem_Handle = Selector.GetHandle("tabView:didSelectTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabView_ShouldSelectTabViewItem_ = "tabView:shouldSelectTabViewItem:";

	private static readonly IntPtr selTabView_ShouldSelectTabViewItem_Handle = Selector.GetHandle("tabView:shouldSelectTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabView_WillSelectTabViewItem_ = "tabView:willSelectTabViewItem:";

	private static readonly IntPtr selTabView_WillSelectTabViewItem_Handle = Selector.GetHandle("tabView:willSelectTabViewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabViewDidChangeNumberOfTabViewItems_ = "tabViewDidChangeNumberOfTabViewItems:";

	private static readonly IntPtr selTabViewDidChangeNumberOfTabViewItems_Handle = Selector.GetHandle("tabViewDidChangeNumberOfTabViewItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabViewItemForViewController_ = "tabViewItemForViewController:";

	private static readonly IntPtr selTabViewItemForViewController_Handle = Selector.GetHandle("tabViewItemForViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabViewItems = "tabViewItems";

	private static readonly IntPtr selTabViewItemsHandle = Selector.GetHandle("tabViewItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbar_ItemForItemIdentifier_WillBeInsertedIntoToolbar_ = "toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:";

	private static readonly IntPtr selToolbar_ItemForItemIdentifier_WillBeInsertedIntoToolbar_Handle = Selector.GetHandle("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbarAllowedItemIdentifiers_ = "toolbarAllowedItemIdentifiers:";

	private static readonly IntPtr selToolbarAllowedItemIdentifiers_Handle = Selector.GetHandle("toolbarAllowedItemIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbarDefaultItemIdentifiers_ = "toolbarDefaultItemIdentifiers:";

	private static readonly IntPtr selToolbarDefaultItemIdentifiers_Handle = Selector.GetHandle("toolbarDefaultItemIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbarDidRemoveItem_ = "toolbarDidRemoveItem:";

	private static readonly IntPtr selToolbarDidRemoveItem_Handle = Selector.GetHandle("toolbarDidRemoveItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbarSelectableItemIdentifiers_ = "toolbarSelectableItemIdentifiers:";

	private static readonly IntPtr selToolbarSelectableItemIdentifiers_Handle = Selector.GetHandle("toolbarSelectableItemIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbarWillAddItem_ = "toolbarWillAddItem:";

	private static readonly IntPtr selToolbarWillAddItem_Handle = Selector.GetHandle("toolbarWillAddItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransitionOptions = "transitionOptions";

	private static readonly IntPtr selTransitionOptionsHandle = Selector.GetHandle("transitionOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTabViewController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPropagateSelectedChildViewControllerTitle
	{
		[Export("canPropagateSelectedChildViewControllerTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPropagateSelectedChildViewControllerTitleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPropagateSelectedChildViewControllerTitleHandle);
		}
		[Export("setCanPropagateSelectedChildViewControllerTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanPropagateSelectedChildViewControllerTitle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanPropagateSelectedChildViewControllerTitle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsoleted(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSSegmentedControl SegmentedControl
	{
		[Obsoleted(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("segmentedControl", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSegmentedControl>(Messaging.IntPtr_objc_msgSend(base.Handle, selSegmentedControlHandle));
			}
			return Runtime.GetNSObject<NSSegmentedControl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSegmentedControlHandle));
		}
		[Obsoleted(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setSegmentedControl:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSegmentedControl_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSegmentedControl_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedTabViewItemIndex
	{
		[Export("selectedTabViewItemIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSelectedTabViewItemIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSelectedTabViewItemIndexHandle);
		}
		[Export("setSelectedTabViewItemIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSelectedTabViewItemIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSelectedTabViewItemIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTabViewControllerTabStyle TabStyle
	{
		[Export("tabStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTabViewControllerTabStyle)Messaging.Int64_objc_msgSend(base.Handle, selTabStyleHandle);
			}
			return (NSTabViewControllerTabStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTabStyleHandle);
		}
		[Export("setTabStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTabStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTabStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTabView TabView
	{
		[Export("tabView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTabView>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabViewHandle));
			}
			return Runtime.GetNSObject<NSTabView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabViewHandle));
		}
		[Export("setTabView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTabView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTabView_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTabViewItem[] TabViewItems
	{
		[Export("tabViewItems", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSTabViewItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabViewItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSTabViewItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabViewItemsHandle));
		}
		[Export("setTabViewItems:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewControllerTransitionOptions TransitionOptions
	{
		[Export("transitionOptions")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSViewControllerTransitionOptions)Messaging.UInt64_objc_msgSend(base.Handle, selTransitionOptionsHandle);
			}
			return (NSViewControllerTransitionOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTransitionOptionsHandle);
		}
		[Export("setTransitionOptions:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTransitionOptions_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTransitionOptions_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTabViewController()
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
	public NSTabViewController(NSCoder coder)
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
	protected NSTabViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTabViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTabViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTabViewItem(NSTabViewItem tabViewItem)
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

	[Export("toolbarAllowedItemIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual string[] AllowedItemIdentifiers(NSToolbar toolbar)
	{
		NSApplication.EnsureUIThread();
		if (toolbar == null)
		{
			throw new ArgumentNullException("toolbar");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selToolbarAllowedItemIdentifiers_Handle, toolbar.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selToolbarAllowedItemIdentifiers_Handle, toolbar.Handle));
	}

	[Export("toolbarDefaultItemIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual string[] DefaultItemIdentifiers(NSToolbar toolbar)
	{
		NSApplication.EnsureUIThread();
		if (toolbar == null)
		{
			throw new ArgumentNullException("toolbar");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selToolbarDefaultItemIdentifiers_Handle, toolbar.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selToolbarDefaultItemIdentifiers_Handle, toolbar.Handle));
	}

	[Export("toolbarDidRemoveItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRemoveItem(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToolbarDidRemoveItem_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToolbarDidRemoveItem_Handle, notification.Handle);
		}
	}

	[Export("tabView:didSelectTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void DidSelect(NSTabView tabView, NSTabViewItem item)
	{
		NSApplication.EnsureUIThread();
		if (tabView == null)
		{
			throw new ArgumentNullException("tabView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selTabView_DidSelectTabViewItem_Handle, tabView.Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTabView_DidSelectTabViewItem_Handle, tabView.Handle, item.Handle);
		}
	}

	[Export("tabViewItemForViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTabViewItem GetTabViewItem(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTabViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTabViewItemForViewController_Handle, viewController.Handle));
		}
		return Runtime.GetNSObject<NSTabViewItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTabViewItemForViewController_Handle, viewController.Handle));
	}

	[Export("insertTabViewItem:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertTabViewItem(NSTabViewItem tabViewItem, nint index)
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

	[Export("tabViewDidChangeNumberOfTabViewItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NumberOfItemsChanged(NSTabView tabView)
	{
		NSApplication.EnsureUIThread();
		if (tabView == null)
		{
			throw new ArgumentNullException("tabView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTabViewDidChangeNumberOfTabViewItems_Handle, tabView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTabViewDidChangeNumberOfTabViewItems_Handle, tabView.Handle);
		}
	}

	[Export("removeTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTabViewItem(NSTabViewItem tabViewItem)
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

	[Export("toolbarSelectableItemIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual string[] SelectableItemIdentifiers(NSToolbar toolbar)
	{
		NSApplication.EnsureUIThread();
		if (toolbar == null)
		{
			throw new ArgumentNullException("toolbar");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selToolbarSelectableItemIdentifiers_Handle, toolbar.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selToolbarSelectableItemIdentifiers_Handle, toolbar.Handle));
	}

	[Export("tabView:shouldSelectTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual bool ShouldSelectTabViewItem(NSTabView tabView, NSTabViewItem item)
	{
		NSApplication.EnsureUIThread();
		if (tabView == null)
		{
			throw new ArgumentNullException("tabView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTabView_ShouldSelectTabViewItem_Handle, tabView.Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTabView_ShouldSelectTabViewItem_Handle, tabView.Handle, item.Handle);
	}

	[Export("toolbarWillAddItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillAddItem(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selToolbarWillAddItem_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selToolbarWillAddItem_Handle, notification.Handle);
		}
	}

	[Export("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual NSToolbarItem WillInsertItem(NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
	{
		NSApplication.EnsureUIThread();
		if (toolbar == null)
		{
			throw new ArgumentNullException("toolbar");
		}
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		NSToolbarItem result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSToolbarItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selToolbar_ItemForItemIdentifier_WillBeInsertedIntoToolbar_Handle, toolbar.Handle, arg, willBeInserted)) : Runtime.GetNSObject<NSToolbarItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selToolbar_ItemForItemIdentifier_WillBeInsertedIntoToolbar_Handle, toolbar.Handle, arg, willBeInserted)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("tabView:willSelectTabViewItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void WillSelect(NSTabView tabView, NSTabViewItem item)
	{
		NSApplication.EnsureUIThread();
		if (tabView == null)
		{
			throw new ArgumentNullException("tabView");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selTabView_WillSelectTabViewItem_Handle, tabView.Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTabView_WillSelectTabViewItem_Handle, tabView.Handle, item.Handle);
		}
	}
}
