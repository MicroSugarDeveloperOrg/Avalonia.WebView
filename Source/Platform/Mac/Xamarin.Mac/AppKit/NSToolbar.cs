using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSToolbar", true)]
public class NSToolbar : NSObject
{
	[Register]
	internal class _NSToolbarDelegate : NSObject, INSToolbarDelegate, INativeObject, IDisposable
	{
		internal NSToolbarIdentifiers? allowedItemIdentifiers;

		internal NSToolbarIdentifiers? defaultItemIdentifiers;

		internal EventHandler? didRemoveItem;

		internal NSToolbarIdentifiers? selectableItemIdentifiers;

		internal EventHandler? willAddItem;

		internal NSToolbarWillInsert? willInsertItem;

		public _NSToolbarDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("toolbarAllowedItemIdentifiers:")]
		public string[] AllowedItemIdentifiers(NSToolbar toolbar)
		{
			return allowedItemIdentifiers?.Invoke(toolbar);
		}

		[Preserve(Conditional = true)]
		[Export("toolbarDefaultItemIdentifiers:")]
		public string[] DefaultItemIdentifiers(NSToolbar toolbar)
		{
			return defaultItemIdentifiers?.Invoke(toolbar);
		}

		[Preserve(Conditional = true)]
		[Export("toolbarDidRemoveItem:")]
		public void DidRemoveItem(NSNotification notification)
		{
			didRemoveItem?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("toolbarSelectableItemIdentifiers:")]
		public string[] SelectableItemIdentifiers(NSToolbar toolbar)
		{
			return selectableItemIdentifiers?.Invoke(toolbar);
		}

		[Preserve(Conditional = true)]
		[Export("toolbarWillAddItem:")]
		public void WillAddItem(NSNotification notification)
		{
			willAddItem?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:")]
		public NSToolbarItem WillInsertItem(NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
		{
			return willInsertItem?.Invoke(toolbar, itemIdentifier, willBeInserted);
		}
	}

	public static class Notifications
	{
		public static NSObject ObserveNSToolbarDidRemoveItem(EventHandler<NSToolbarItemEventArgs> handler)
		{
			EventHandler<NSToolbarItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NSToolbarDidRemoveItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSToolbarItemEventArgs(notification));
			});
		}

		public static NSObject ObserveNSToolbarDidRemoveItem(NSObject objectToObserve, EventHandler<NSToolbarItemEventArgs> handler)
		{
			EventHandler<NSToolbarItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NSToolbarDidRemoveItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSToolbarItemEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveNSToolbarWillAddItem(EventHandler<NSToolbarItemEventArgs> handler)
		{
			EventHandler<NSToolbarItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NSToolbarWillAddItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSToolbarItemEventArgs(notification));
			});
		}

		public static NSObject ObserveNSToolbarWillAddItem(NSObject objectToObserve, EventHandler<NSToolbarItemEventArgs> handler)
		{
			EventHandler<NSToolbarItemEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NSToolbarWillAddItemNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSToolbarItemEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsExtensionItems = "allowsExtensionItems";

	private static readonly IntPtr selAllowsExtensionItemsHandle = Selector.GetHandle("allowsExtensionItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsUserCustomization = "allowsUserCustomization";

	private static readonly IntPtr selAllowsUserCustomizationHandle = Selector.GetHandle("allowsUserCustomization");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosavesConfiguration = "autosavesConfiguration";

	private static readonly IntPtr selAutosavesConfigurationHandle = Selector.GetHandle("autosavesConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenteredItemIdentifier = "centeredItemIdentifier";

	private static readonly IntPtr selCenteredItemIdentifierHandle = Selector.GetHandle("centeredItemIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfigurationDictionary = "configurationDictionary";

	private static readonly IntPtr selConfigurationDictionaryHandle = Selector.GetHandle("configurationDictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomizationPaletteIsRunning = "customizationPaletteIsRunning";

	private static readonly IntPtr selCustomizationPaletteIsRunningHandle = Selector.GetHandle("customizationPaletteIsRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayMode = "displayMode";

	private static readonly IntPtr selDisplayModeHandle = Selector.GetHandle("displayMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ = "initWithIdentifier:";

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItemWithItemIdentifier_AtIndex_ = "insertItemWithItemIdentifier:atIndex:";

	private static readonly IntPtr selInsertItemWithItemIdentifier_AtIndex_Handle = Selector.GetHandle("insertItemWithItemIdentifier:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVisible = "isVisible";

	private static readonly IntPtr selIsVisibleHandle = Selector.GetHandle("isVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItems = "items";

	private static readonly IntPtr selItemsHandle = Selector.GetHandle("items");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemAtIndex_ = "removeItemAtIndex:";

	private static readonly IntPtr selRemoveItemAtIndex_Handle = Selector.GetHandle("removeItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunCustomizationPalette_ = "runCustomizationPalette:";

	private static readonly IntPtr selRunCustomizationPalette_Handle = Selector.GetHandle("runCustomizationPalette:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedItemIdentifier = "selectedItemIdentifier";

	private static readonly IntPtr selSelectedItemIdentifierHandle = Selector.GetHandle("selectedItemIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsExtensionItems_ = "setAllowsExtensionItems:";

	private static readonly IntPtr selSetAllowsExtensionItems_Handle = Selector.GetHandle("setAllowsExtensionItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsUserCustomization_ = "setAllowsUserCustomization:";

	private static readonly IntPtr selSetAllowsUserCustomization_Handle = Selector.GetHandle("setAllowsUserCustomization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosavesConfiguration_ = "setAutosavesConfiguration:";

	private static readonly IntPtr selSetAutosavesConfiguration_Handle = Selector.GetHandle("setAutosavesConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCenteredItemIdentifier_ = "setCenteredItemIdentifier:";

	private static readonly IntPtr selSetCenteredItemIdentifier_Handle = Selector.GetHandle("setCenteredItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConfigurationFromDictionary_ = "setConfigurationFromDictionary:";

	private static readonly IntPtr selSetConfigurationFromDictionary_Handle = Selector.GetHandle("setConfigurationFromDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayMode_ = "setDisplayMode:";

	private static readonly IntPtr selSetDisplayMode_Handle = Selector.GetHandle("setDisplayMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedItemIdentifier_ = "setSelectedItemIdentifier:";

	private static readonly IntPtr selSetSelectedItemIdentifier_Handle = Selector.GetHandle("setSelectedItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsBaselineSeparator_ = "setShowsBaselineSeparator:";

	private static readonly IntPtr selSetShowsBaselineSeparator_Handle = Selector.GetHandle("setShowsBaselineSeparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSizeMode_ = "setSizeMode:";

	private static readonly IntPtr selSetSizeMode_Handle = Selector.GetHandle("setSizeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVisible_ = "setVisible:";

	private static readonly IntPtr selSetVisible_Handle = Selector.GetHandle("setVisible:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsBaselineSeparator = "showsBaselineSeparator";

	private static readonly IntPtr selShowsBaselineSeparatorHandle = Selector.GetHandle("showsBaselineSeparator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeMode = "sizeMode";

	private static readonly IntPtr selSizeModeHandle = Selector.GetHandle("sizeMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateVisibleItems = "validateVisibleItems";

	private static readonly IntPtr selValidateVisibleItemsHandle = Selector.GetHandle("validateVisibleItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleItems = "visibleItems";

	private static readonly IntPtr selVisibleItemsHandle = Selector.GetHandle("visibleItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSToolbar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarCloudSharingItemIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarCustomizeToolbarItemIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarDidRemoveItemNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarFlexibleSpaceItemIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarPrintItemIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarSeparatorItemIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarShowColorsItemIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarShowFontsItemIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarSpaceItemIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarToggleSidebarItemIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSToolbarWillAddItemNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AllowsExtensionItems
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("allowsExtensionItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsExtensionItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsExtensionItemsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAllowsExtensionItems:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsExtensionItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsExtensionItems_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsUserCustomization
	{
		[Export("allowsUserCustomization")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsUserCustomizationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsUserCustomizationHandle);
		}
		[Export("setAllowsUserCustomization:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsUserCustomization_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsUserCustomization_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutosavesConfiguration
	{
		[Export("autosavesConfiguration")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosavesConfigurationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosavesConfigurationHandle);
		}
		[Export("setAutosavesConfiguration:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosavesConfiguration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosavesConfiguration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual string? CenteredItemIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("centeredItemIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCenteredItemIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCenteredItemIdentifierHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setCenteredItemIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCenteredItemIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCenteredItemIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ConfigurationDictionary
	{
		[Export("configurationDictionary")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationDictionaryHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationDictionaryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSToolbarDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSToolbarDelegate;
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
	public virtual NSToolbarDisplayMode DisplayMode
	{
		[Export("displayMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSToolbarDisplayMode)Messaging.UInt64_objc_msgSend(base.Handle, selDisplayModeHandle);
			}
			return (NSToolbarDisplayMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDisplayModeHandle);
		}
		[Export("setDisplayMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDisplayMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDisplayMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCustomizationPaletteRunning
	{
		[Export("customizationPaletteIsRunning")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCustomizationPaletteIsRunningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCustomizationPaletteIsRunningHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSToolbarItem[] Items
	{
		[Export("items")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SelectedItemIdentifier
	{
		[Export("selectedItemIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedItemIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedItemIdentifierHandle));
		}
		[Export("setSelectedItemIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedItemIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedItemIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsBaselineSeparator
	{
		[Export("showsBaselineSeparator")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsBaselineSeparatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsBaselineSeparatorHandle);
		}
		[Export("setShowsBaselineSeparator:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsBaselineSeparator_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsBaselineSeparator_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSToolbarSizeMode SizeMode
	{
		[Export("sizeMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSToolbarSizeMode)Messaging.UInt64_objc_msgSend(base.Handle, selSizeModeHandle);
			}
			return (NSToolbarSizeMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSizeModeHandle);
		}
		[Export("setSizeMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSizeMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSizeMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Visible
	{
		[Export("isVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVisibleHandle);
		}
		[Export("setVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVisible_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSToolbarItem[] VisibleItems
	{
		[Export("visibleItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selVisibleItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisibleItemsHandle));
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

	[Field("NSToolbarCloudSharingItemIdentifier", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString NSToolbarCloudSharingItemIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_NSToolbarCloudSharingItemIdentifier == null)
			{
				_NSToolbarCloudSharingItemIdentifier = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarCloudSharingItemIdentifier");
			}
			return _NSToolbarCloudSharingItemIdentifier;
		}
	}

	[Field("NSToolbarCustomizeToolbarItemIdentifier", "AppKit")]
	public static NSString NSToolbarCustomizeToolbarItemIdentifier
	{
		get
		{
			if (_NSToolbarCustomizeToolbarItemIdentifier == null)
			{
				_NSToolbarCustomizeToolbarItemIdentifier = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarCustomizeToolbarItemIdentifier");
			}
			return _NSToolbarCustomizeToolbarItemIdentifier;
		}
	}

	[Field("NSToolbarDidRemoveItemNotification", "AppKit")]
	[Advice("Use NSToolbar.Notifications.ObserveNSToolbarDidRemoveItem helper method instead.")]
	public static NSString NSToolbarDidRemoveItemNotification
	{
		get
		{
			if (_NSToolbarDidRemoveItemNotification == null)
			{
				_NSToolbarDidRemoveItemNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarDidRemoveItemNotification");
			}
			return _NSToolbarDidRemoveItemNotification;
		}
	}

	[Field("NSToolbarFlexibleSpaceItemIdentifier", "AppKit")]
	public static NSString NSToolbarFlexibleSpaceItemIdentifier
	{
		get
		{
			if (_NSToolbarFlexibleSpaceItemIdentifier == null)
			{
				_NSToolbarFlexibleSpaceItemIdentifier = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarFlexibleSpaceItemIdentifier");
			}
			return _NSToolbarFlexibleSpaceItemIdentifier;
		}
	}

	[Field("NSToolbarPrintItemIdentifier", "AppKit")]
	public static NSString NSToolbarPrintItemIdentifier
	{
		get
		{
			if (_NSToolbarPrintItemIdentifier == null)
			{
				_NSToolbarPrintItemIdentifier = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarPrintItemIdentifier");
			}
			return _NSToolbarPrintItemIdentifier;
		}
	}

	[Field("NSToolbarSeparatorItemIdentifier", "AppKit")]
	public static NSString NSToolbarSeparatorItemIdentifier
	{
		get
		{
			if (_NSToolbarSeparatorItemIdentifier == null)
			{
				_NSToolbarSeparatorItemIdentifier = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarSeparatorItemIdentifier");
			}
			return _NSToolbarSeparatorItemIdentifier;
		}
	}

	[Field("NSToolbarShowColorsItemIdentifier", "AppKit")]
	public static NSString NSToolbarShowColorsItemIdentifier
	{
		get
		{
			if (_NSToolbarShowColorsItemIdentifier == null)
			{
				_NSToolbarShowColorsItemIdentifier = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarShowColorsItemIdentifier");
			}
			return _NSToolbarShowColorsItemIdentifier;
		}
	}

	[Field("NSToolbarShowFontsItemIdentifier", "AppKit")]
	public static NSString NSToolbarShowFontsItemIdentifier
	{
		get
		{
			if (_NSToolbarShowFontsItemIdentifier == null)
			{
				_NSToolbarShowFontsItemIdentifier = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarShowFontsItemIdentifier");
			}
			return _NSToolbarShowFontsItemIdentifier;
		}
	}

	[Field("NSToolbarSpaceItemIdentifier", "AppKit")]
	public static NSString NSToolbarSpaceItemIdentifier
	{
		get
		{
			if (_NSToolbarSpaceItemIdentifier == null)
			{
				_NSToolbarSpaceItemIdentifier = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarSpaceItemIdentifier");
			}
			return _NSToolbarSpaceItemIdentifier;
		}
	}

	[Field("NSToolbarToggleSidebarItemIdentifier", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString NSToolbarToggleSidebarItemIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_NSToolbarToggleSidebarItemIdentifier == null)
			{
				_NSToolbarToggleSidebarItemIdentifier = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarToggleSidebarItemIdentifier");
			}
			return _NSToolbarToggleSidebarItemIdentifier;
		}
	}

	[Field("NSToolbarWillAddItemNotification", "AppKit")]
	[Advice("Use NSToolbar.Notifications.ObserveNSToolbarWillAddItem helper method instead.")]
	public static NSString NSToolbarWillAddItemNotification
	{
		get
		{
			if (_NSToolbarWillAddItemNotification == null)
			{
				_NSToolbarWillAddItemNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolbarWillAddItemNotification");
			}
			return _NSToolbarWillAddItemNotification;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSToolbarDelegate);

	public NSToolbarIdentifiers? AllowedItemIdentifiers
	{
		get
		{
			return EnsureNSToolbarDelegate().allowedItemIdentifiers;
		}
		set
		{
			EnsureNSToolbarDelegate().allowedItemIdentifiers = value;
		}
	}

	public NSToolbarIdentifiers? DefaultItemIdentifiers
	{
		get
		{
			return EnsureNSToolbarDelegate().defaultItemIdentifiers;
		}
		set
		{
			EnsureNSToolbarDelegate().defaultItemIdentifiers = value;
		}
	}

	public NSToolbarIdentifiers? SelectableItemIdentifiers
	{
		get
		{
			return EnsureNSToolbarDelegate().selectableItemIdentifiers;
		}
		set
		{
			EnsureNSToolbarDelegate().selectableItemIdentifiers = value;
		}
	}

	public NSToolbarWillInsert? WillInsertItem
	{
		get
		{
			return EnsureNSToolbarDelegate().willInsertItem;
		}
		set
		{
			EnsureNSToolbarDelegate().willInsertItem = value;
		}
	}

	public event EventHandler DidRemoveItem
	{
		add
		{
			_NSToolbarDelegate nSToolbarDelegate = EnsureNSToolbarDelegate();
			nSToolbarDelegate.didRemoveItem = (EventHandler)System.Delegate.Combine(nSToolbarDelegate.didRemoveItem, value);
		}
		remove
		{
			_NSToolbarDelegate nSToolbarDelegate = EnsureNSToolbarDelegate();
			nSToolbarDelegate.didRemoveItem = (EventHandler)System.Delegate.Remove(nSToolbarDelegate.didRemoveItem, value);
		}
	}

	public event EventHandler WillAddItem
	{
		add
		{
			_NSToolbarDelegate nSToolbarDelegate = EnsureNSToolbarDelegate();
			nSToolbarDelegate.willAddItem = (EventHandler)System.Delegate.Combine(nSToolbarDelegate.willAddItem, value);
		}
		remove
		{
			_NSToolbarDelegate nSToolbarDelegate = EnsureNSToolbarDelegate();
			nSToolbarDelegate.willAddItem = (EventHandler)System.Delegate.Remove(nSToolbarDelegate.willAddItem, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSToolbar(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSToolbar(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSToolbar()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSToolbar(string identifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("insertItemWithItemIdentifier:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertItem(string itemIdentifier, nint index)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertItemWithItemIdentifier_AtIndex_Handle, arg, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertItemWithItemIdentifier_AtIndex_Handle, arg, index);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItem(nint index)
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

	[Export("runCustomizationPalette:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunCustomizationPalette(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRunCustomizationPalette_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunCustomizationPalette_Handle, sender.Handle);
		}
	}

	[Export("setConfigurationFromDictionary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetConfigurationFromDictionary(NSDictionary configDict)
	{
		NSApplication.EnsureUIThread();
		if (configDict == null)
		{
			throw new ArgumentNullException("configDict");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConfigurationFromDictionary_Handle, configDict.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConfigurationFromDictionary_Handle, configDict.Handle);
		}
	}

	[Export("validateVisibleItems")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ValidateVisibleItems()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateVisibleItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateVisibleItemsHandle);
		}
	}

	internal virtual _NSToolbarDelegate CreateInternalEventDelegateType()
	{
		return new _NSToolbarDelegate();
	}

	internal _NSToolbarDelegate EnsureNSToolbarDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSToolbarDelegate nSToolbarDelegate = Delegate as _NSToolbarDelegate;
		if (nSToolbarDelegate == null)
		{
			nSToolbarDelegate = (_NSToolbarDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSToolbarDelegate;
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
