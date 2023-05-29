using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSToolbar", true)]
public class NSToolbar : NSObject
{
	[Register]
	private sealed class _NSToolbarDelegate : NSToolbarDelegate
	{
		internal NSToolbarWillInsert willInsertItem;

		internal NSToolbarIdentifiers defaultItemIdentifiers;

		internal NSToolbarIdentifiers allowedItemIdentifiers;

		internal NSToolbarIdentifiers selectableItemIdentifiers;

		internal EventHandler willAddItem;

		internal EventHandler didRemoveItem;

		[Preserve(Conditional = true)]
		public override NSToolbarItem WillInsertItem(NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
		{
			return willInsertItem?.Invoke(toolbar, itemIdentifier, willBeInserted);
		}

		[Preserve(Conditional = true)]
		public override string[] DefaultItemIdentifiers(NSToolbar toolbar)
		{
			return defaultItemIdentifiers?.Invoke(toolbar);
		}

		[Preserve(Conditional = true)]
		public override string[] AllowedItemIdentifiers(NSToolbar toolbar)
		{
			return allowedItemIdentifiers?.Invoke(toolbar);
		}

		[Preserve(Conditional = true)]
		public override string[] SelectableItemIdentifiers(NSToolbar toolbar)
		{
			return selectableItemIdentifiers?.Invoke(toolbar);
		}

		[Preserve(Conditional = true)]
		public override void WillAddItem(NSNotification notification)
		{
			willAddItem?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidRemoveItem(NSNotification notification)
		{
			didRemoveItem?.Invoke(notification, EventArgs.Empty);
		}
	}

	private static readonly IntPtr selCustomizationPaletteIsRunningHandle = Selector.GetHandle("customizationPaletteIsRunning");

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	private static readonly IntPtr selItemsHandle = Selector.GetHandle("items");

	private static readonly IntPtr selVisibleItemsHandle = Selector.GetHandle("visibleItems");

	private static readonly IntPtr selConfigurationDictionaryHandle = Selector.GetHandle("configurationDictionary");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selIsVisibleHandle = Selector.GetHandle("isVisible");

	private static readonly IntPtr selSetVisible_Handle = Selector.GetHandle("setVisible:");

	private static readonly IntPtr selDisplayModeHandle = Selector.GetHandle("displayMode");

	private static readonly IntPtr selSetDisplayMode_Handle = Selector.GetHandle("setDisplayMode:");

	private static readonly IntPtr selSelectedItemIdentifierHandle = Selector.GetHandle("selectedItemIdentifier");

	private static readonly IntPtr selSetSelectedItemIdentifier_Handle = Selector.GetHandle("setSelectedItemIdentifier:");

	private static readonly IntPtr selSizeModeHandle = Selector.GetHandle("sizeMode");

	private static readonly IntPtr selSetSizeMode_Handle = Selector.GetHandle("setSizeMode:");

	private static readonly IntPtr selShowsBaselineSeparatorHandle = Selector.GetHandle("showsBaselineSeparator");

	private static readonly IntPtr selSetShowsBaselineSeparator_Handle = Selector.GetHandle("setShowsBaselineSeparator:");

	private static readonly IntPtr selAllowsUserCustomizationHandle = Selector.GetHandle("allowsUserCustomization");

	private static readonly IntPtr selSetAllowsUserCustomization_Handle = Selector.GetHandle("setAllowsUserCustomization:");

	private static readonly IntPtr selAutosavesConfigurationHandle = Selector.GetHandle("autosavesConfiguration");

	private static readonly IntPtr selSetAutosavesConfiguration_Handle = Selector.GetHandle("setAutosavesConfiguration:");

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	private static readonly IntPtr selInsertItemWithItemIdentifierAtIndex_Handle = Selector.GetHandle("insertItemWithItemIdentifier:atIndex:");

	private static readonly IntPtr selRemoveItemAtIndex_Handle = Selector.GetHandle("removeItemAtIndex:");

	private static readonly IntPtr selRunCustomizationPalette_Handle = Selector.GetHandle("runCustomizationPalette:");

	private static readonly IntPtr selSetConfigurationFromDictionary_Handle = Selector.GetHandle("setConfigurationFromDictionary:");

	private static readonly IntPtr selValidateVisibleItemsHandle = Selector.GetHandle("validateVisibleItems");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSToolbar");

	private object __mt_Items_var;

	private object __mt_VisibleItems_var;

	private object __mt_ConfigurationDictionary_var;

	private object __mt_WeakDelegate_var;

	private static NSString _NSToolbarSeparatorItemIdentifier;

	private static NSString _NSToolbarSpaceItemIdentifier;

	private static NSString _NSToolbarFlexibleSpaceItemIdentifier;

	private static NSString _NSToolbarShowColorsItemIdentifier;

	private static NSString _NSToolbarShowFontsItemIdentifier;

	private static NSString _NSToolbarCustomizeToolbarItemIdentifier;

	private static NSString _NSToolbarPrintItemIdentifier;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool IsCustomizationPaletteRunning
	{
		[Export("customizationPaletteIsRunning")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCustomizationPaletteIsRunningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCustomizationPaletteIsRunningHandle);
		}
	}

	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	public virtual NSToolbarItem[] Items
	{
		[Export("items")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSToolbarItem[])(__mt_Items_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemsHandle)) : NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemsHandle))));
		}
	}

	public virtual NSToolbarItem[] VisibleItems
	{
		[Export("visibleItems")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSToolbarItem[])(__mt_VisibleItems_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisibleItemsHandle)) : NSArray.ArrayFromHandle<NSToolbarItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selVisibleItemsHandle))));
		}
	}

	public virtual NSDictionary ConfigurationDictionary
	{
		[Export("configurationDictionary")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_ConfigurationDictionary_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationDictionaryHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationDictionaryHandle)))));
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
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
			__mt_WeakDelegate_var = value;
		}
	}

	public NSToolbarDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSToolbarDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual bool Visible
	{
		[Export("isVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVisibleHandle);
		}
		[Export("setVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVisible_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVisible_Handle, value);
			}
		}
	}

	public virtual NSToolbarDisplayMode DisplayMode
	{
		[Export("displayMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSToolbarDisplayMode)Messaging.UInt64_objc_msgSend(base.Handle, selDisplayModeHandle);
			}
			return (NSToolbarDisplayMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDisplayModeHandle);
		}
		[Export("setDisplayMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDisplayMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDisplayMode_Handle, (ulong)value);
			}
		}
	}

	public virtual string SelectedItemIdentifier
	{
		[Export("selectedItemIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual NSToolbarSizeMode SizeMode
	{
		[Export("sizeMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSToolbarSizeMode)Messaging.UInt64_objc_msgSend(base.Handle, selSizeModeHandle);
			}
			return (NSToolbarSizeMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSizeModeHandle);
		}
		[Export("setSizeMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSizeMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSizeMode_Handle, (ulong)value);
			}
		}
	}

	public virtual bool ShowsBaselineSeparator
	{
		[Export("showsBaselineSeparator")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsBaselineSeparatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsBaselineSeparatorHandle);
		}
		[Export("setShowsBaselineSeparator:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsBaselineSeparator_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsBaselineSeparator_Handle, value);
			}
		}
	}

	public virtual bool AllowsUserCustomization
	{
		[Export("allowsUserCustomization")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsUserCustomizationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsUserCustomizationHandle);
		}
		[Export("setAllowsUserCustomization:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsUserCustomization_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsUserCustomization_Handle, value);
			}
		}
	}

	public virtual bool AutosavesConfiguration
	{
		[Export("autosavesConfiguration")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosavesConfigurationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosavesConfigurationHandle);
		}
		[Export("setAutosavesConfiguration:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutosavesConfiguration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutosavesConfiguration_Handle, value);
			}
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

	public NSToolbarWillInsert WillInsertItem
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

	public NSToolbarIdentifiers DefaultItemIdentifiers
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

	public NSToolbarIdentifiers AllowedItemIdentifiers
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

	public NSToolbarIdentifiers SelectableItemIdentifiers
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSToolbar()
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
	public NSToolbar(NSCoder coder)
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
	public NSToolbar(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSToolbar(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	public NSToolbar(string identifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("insertItemWithItemIdentifier:atIndex:")]
	public virtual void InsertItem(string itemIdentifier, long index)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selInsertItemWithItemIdentifierAtIndex_Handle, arg, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInsertItemWithItemIdentifierAtIndex_Handle, arg, index);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeItemAtIndex:")]
	public virtual void RemoveItem(long index)
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
	}

	[Export("runCustomizationPalette:")]
	public virtual void RunCustomizationPalette(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRunCustomizationPalette_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunCustomizationPalette_Handle, sender.Handle);
		}
	}

	[Export("setConfigurationFromDictionary:")]
	public virtual void SetConfigurationFromDictionary(NSDictionary configDict)
	{
		NSApplication.EnsureUIThread();
		if (configDict == null)
		{
			throw new ArgumentNullException("configDict");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConfigurationFromDictionary_Handle, configDict.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConfigurationFromDictionary_Handle, configDict.Handle);
		}
	}

	[Export("validateVisibleItems")]
	public virtual void ValidateVisibleItems()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateVisibleItemsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateVisibleItemsHandle);
		}
	}

	private _NSToolbarDelegate EnsureNSToolbarDelegate()
	{
		NSToolbarDelegate nSToolbarDelegate = Delegate;
		if (nSToolbarDelegate == null || !(nSToolbarDelegate is _NSToolbarDelegate))
		{
			nSToolbarDelegate = (Delegate = new _NSToolbarDelegate());
		}
		return (_NSToolbarDelegate)nSToolbarDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Items_var = null;
			__mt_VisibleItems_var = null;
			__mt_ConfigurationDictionary_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
