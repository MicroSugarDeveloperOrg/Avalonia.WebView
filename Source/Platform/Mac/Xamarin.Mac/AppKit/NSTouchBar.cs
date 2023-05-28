using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTouchBar", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public class NSTouchBar : NSObject, INSCoding, INativeObject, IDisposable
{
	[Register]
	private sealed class _NSTouchBarDelegate : NSTouchBarDelegate
	{
		internal NSTouchBarMakeItem? makeItem;

		public _NSTouchBarDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		public override NSTouchBarItem MakeItem(NSTouchBar touchBar, string identifier)
		{
			return makeItem?.Invoke(touchBar, identifier);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomizationAllowedItemIdentifiers = "customizationAllowedItemIdentifiers";

	private static readonly IntPtr selCustomizationAllowedItemIdentifiersHandle = Selector.GetHandle("customizationAllowedItemIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomizationIdentifier = "customizationIdentifier";

	private static readonly IntPtr selCustomizationIdentifierHandle = Selector.GetHandle("customizationIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomizationRequiredItemIdentifiers = "customizationRequiredItemIdentifiers";

	private static readonly IntPtr selCustomizationRequiredItemIdentifiersHandle = Selector.GetHandle("customizationRequiredItemIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultItemIdentifiers = "defaultItemIdentifiers";

	private static readonly IntPtr selDefaultItemIdentifiersHandle = Selector.GetHandle("defaultItemIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEscapeKeyReplacementItemIdentifier = "escapeKeyReplacementItemIdentifier";

	private static readonly IntPtr selEscapeKeyReplacementItemIdentifierHandle = Selector.GetHandle("escapeKeyReplacementItemIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticCustomizeTouchBarMenuItemEnabled = "isAutomaticCustomizeTouchBarMenuItemEnabled";

	private static readonly IntPtr selIsAutomaticCustomizeTouchBarMenuItemEnabledHandle = Selector.GetHandle("isAutomaticCustomizeTouchBarMenuItemEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVisible = "isVisible";

	private static readonly IntPtr selIsVisibleHandle = Selector.GetHandle("isVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemForIdentifier_ = "itemForIdentifier:";

	private static readonly IntPtr selItemForIdentifier_Handle = Selector.GetHandle("itemForIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrincipalItemIdentifier = "principalItemIdentifier";

	private static readonly IntPtr selPrincipalItemIdentifierHandle = Selector.GetHandle("principalItemIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticCustomizeTouchBarMenuItemEnabled_ = "setAutomaticCustomizeTouchBarMenuItemEnabled:";

	private static readonly IntPtr selSetAutomaticCustomizeTouchBarMenuItemEnabled_Handle = Selector.GetHandle("setAutomaticCustomizeTouchBarMenuItemEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomizationAllowedItemIdentifiers_ = "setCustomizationAllowedItemIdentifiers:";

	private static readonly IntPtr selSetCustomizationAllowedItemIdentifiers_Handle = Selector.GetHandle("setCustomizationAllowedItemIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomizationIdentifier_ = "setCustomizationIdentifier:";

	private static readonly IntPtr selSetCustomizationIdentifier_Handle = Selector.GetHandle("setCustomizationIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomizationRequiredItemIdentifiers_ = "setCustomizationRequiredItemIdentifiers:";

	private static readonly IntPtr selSetCustomizationRequiredItemIdentifiers_Handle = Selector.GetHandle("setCustomizationRequiredItemIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultItemIdentifiers_ = "setDefaultItemIdentifiers:";

	private static readonly IntPtr selSetDefaultItemIdentifiers_Handle = Selector.GetHandle("setDefaultItemIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEscapeKeyReplacementItemIdentifier_ = "setEscapeKeyReplacementItemIdentifier:";

	private static readonly IntPtr selSetEscapeKeyReplacementItemIdentifier_Handle = Selector.GetHandle("setEscapeKeyReplacementItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrincipalItemIdentifier_ = "setPrincipalItemIdentifier:";

	private static readonly IntPtr selSetPrincipalItemIdentifier_Handle = Selector.GetHandle("setPrincipalItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTemplateItems_ = "setTemplateItems:";

	private static readonly IntPtr selSetTemplateItems_Handle = Selector.GetHandle("setTemplateItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemplateItems = "templateItems";

	private static readonly IntPtr selTemplateItemsHandle = Selector.GetHandle("templateItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTouchBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static bool AutomaticCustomizeTouchBarMenuItemEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("isAutomaticCustomizeTouchBarMenuItemEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsAutomaticCustomizeTouchBarMenuItemEnabledHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setAutomaticCustomizeTouchBarMenuItemEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(class_ptr, selSetAutomaticCustomizeTouchBarMenuItemEnabled_Handle, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] CustomizationAllowedItemIdentifiers
	{
		[Export("customizationAllowedItemIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomizationAllowedItemIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomizationAllowedItemIdentifiersHandle));
		}
		[Export("setCustomizationAllowedItemIdentifiers:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomizationAllowedItemIdentifiers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomizationAllowedItemIdentifiers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? CustomizationIdentifier
	{
		[Export("customizationIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomizationIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomizationIdentifierHandle));
		}
		[Export("setCustomizationIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomizationIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomizationIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] CustomizationRequiredItemIdentifiers
	{
		[Export("customizationRequiredItemIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomizationRequiredItemIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomizationRequiredItemIdentifiersHandle));
		}
		[Export("setCustomizationRequiredItemIdentifiers:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomizationRequiredItemIdentifiers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomizationRequiredItemIdentifiers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] DefaultItemIdentifiers
	{
		[Export("defaultItemIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultItemIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultItemIdentifiersHandle));
		}
		[Export("setDefaultItemIdentifiers:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultItemIdentifiers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultItemIdentifiers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSTouchBarDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSTouchBarDelegate iNSTouchBarDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSTouchBarDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<INSTouchBarDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iNSTouchBarDelegate;
			return iNSTouchBarDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
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
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? EscapeKeyReplacementItemIdentifier
	{
		[Export("escapeKeyReplacementItemIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEscapeKeyReplacementItemIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEscapeKeyReplacementItemIdentifierHandle));
		}
		[Export("setEscapeKeyReplacementItemIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEscapeKeyReplacementItemIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEscapeKeyReplacementItemIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? PrincipalItemIdentifier
	{
		[Export("principalItemIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPrincipalItemIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrincipalItemIdentifierHandle));
		}
		[Export("setPrincipalItemIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrincipalItemIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrincipalItemIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet<NSTouchBarItem> TemplateItems
	{
		[Export("templateItems", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet<NSTouchBarItem>>(Messaging.IntPtr_objc_msgSend(base.Handle, selTemplateItemsHandle));
			}
			return Runtime.GetNSObject<NSSet<NSTouchBarItem>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTemplateItemsHandle));
		}
		[Export("setTemplateItems:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTemplateItems_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTemplateItems_Handle, value.Handle);
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
	}

	public NSTouchBarMakeItem? MakeItem
	{
		get
		{
			return EnsureNSTouchBarDelegate().makeItem;
		}
		set
		{
			EnsureNSTouchBarDelegate().makeItem = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTouchBar()
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
	public NSTouchBar(NSCoder coder)
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
	protected NSTouchBar(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTouchBar(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("itemForIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTouchBarItem GetItemForIdentifier(string identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSTouchBarItem result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSTouchBarItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemForIdentifier_Handle, arg)) : Runtime.GetNSObject<NSTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selItemForIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	private _NSTouchBarDelegate EnsureNSTouchBarDelegate()
	{
		INSTouchBarDelegate iNSTouchBarDelegate = Delegate;
		if (iNSTouchBarDelegate == null || !(iNSTouchBarDelegate is _NSTouchBarDelegate))
		{
			iNSTouchBarDelegate = (Delegate = new _NSTouchBarDelegate());
		}
		return (_NSTouchBarDelegate)iNSTouchBarDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
