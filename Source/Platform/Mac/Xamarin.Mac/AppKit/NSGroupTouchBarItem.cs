using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSGroupTouchBarItem", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public class NSGroupTouchBarItem : NSTouchBarItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlertStyleGroupItemWithIdentifier_ = "alertStyleGroupItemWithIdentifier:";

	private static readonly IntPtr selAlertStyleGroupItemWithIdentifier_Handle = Selector.GetHandle("alertStyleGroupItemWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomizationLabel = "customizationLabel";

	private static readonly IntPtr selCustomizationLabelHandle = Selector.GetHandle("customizationLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEffectiveCompressionOptions = "effectiveCompressionOptions";

	private static readonly IntPtr selEffectiveCompressionOptionsHandle = Selector.GetHandle("effectiveCompressionOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupItemWithIdentifier_Items_ = "groupItemWithIdentifier:items:";

	private static readonly IntPtr selGroupItemWithIdentifier_Items_Handle = Selector.GetHandle("groupItemWithIdentifier:items:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupItemWithIdentifier_Items_AllowedCompressionOptions_ = "groupItemWithIdentifier:items:allowedCompressionOptions:";

	private static readonly IntPtr selGroupItemWithIdentifier_Items_AllowedCompressionOptions_Handle = Selector.GetHandle("groupItemWithIdentifier:items:allowedCompressionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupTouchBar = "groupTouchBar";

	private static readonly IntPtr selGroupTouchBarHandle = Selector.GetHandle("groupTouchBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupUserInterfaceLayoutDirection = "groupUserInterfaceLayoutDirection";

	private static readonly IntPtr selGroupUserInterfaceLayoutDirectionHandle = Selector.GetHandle("groupUserInterfaceLayoutDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ = "initWithIdentifier:";

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredItemWidth = "preferredItemWidth";

	private static readonly IntPtr selPreferredItemWidthHandle = Selector.GetHandle("preferredItemWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefersEqualWidths = "prefersEqualWidths";

	private static readonly IntPtr selPrefersEqualWidthsHandle = Selector.GetHandle("prefersEqualWidths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrioritizedCompressionOptions = "prioritizedCompressionOptions";

	private static readonly IntPtr selPrioritizedCompressionOptionsHandle = Selector.GetHandle("prioritizedCompressionOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomizationLabel_ = "setCustomizationLabel:";

	private static readonly IntPtr selSetCustomizationLabel_Handle = Selector.GetHandle("setCustomizationLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroupTouchBar_ = "setGroupTouchBar:";

	private static readonly IntPtr selSetGroupTouchBar_Handle = Selector.GetHandle("setGroupTouchBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroupUserInterfaceLayoutDirection_ = "setGroupUserInterfaceLayoutDirection:";

	private static readonly IntPtr selSetGroupUserInterfaceLayoutDirection_Handle = Selector.GetHandle("setGroupUserInterfaceLayoutDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredItemWidth_ = "setPreferredItemWidth:";

	private static readonly IntPtr selSetPreferredItemWidth_Handle = Selector.GetHandle("setPreferredItemWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrefersEqualWidths_ = "setPrefersEqualWidths:";

	private static readonly IntPtr selSetPrefersEqualWidths_Handle = Selector.GetHandle("setPrefersEqualWidths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrioritizedCompressionOptions_ = "setPrioritizedCompressionOptions:";

	private static readonly IntPtr selSetPrioritizedCompressionOptions_Handle = Selector.GetHandle("setPrioritizedCompressionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSGroupTouchBarItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string CustomizationLabel
	{
		[Export("customizationLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomizationLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomizationLabelHandle));
		}
		[Export("setCustomizationLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomizationLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomizationLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSUserInterfaceCompressionOptions EffectiveCompressionOptions
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("effectiveCompressionOptions")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(base.Handle, selEffectiveCompressionOptionsHandle));
			}
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEffectiveCompressionOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTouchBar GroupTouchBar
	{
		[Export("groupTouchBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupTouchBarHandle));
			}
			return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupTouchBarHandle));
		}
		[Export("setGroupTouchBar:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGroupTouchBar_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGroupTouchBar_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSUserInterfaceLayoutDirection GroupUserInterfaceLayoutDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("groupUserInterfaceLayoutDirection", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSend(base.Handle, selGroupUserInterfaceLayoutDirectionHandle);
			}
			return (NSUserInterfaceLayoutDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selGroupUserInterfaceLayoutDirectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setGroupUserInterfaceLayoutDirection:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetGroupUserInterfaceLayoutDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetGroupUserInterfaceLayoutDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual nfloat PreferredItemWidth
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("preferredItemWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPreferredItemWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPreferredItemWidthHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setPreferredItemWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetPreferredItemWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetPreferredItemWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool PrefersEqualWidths
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("prefersEqualWidths")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPrefersEqualWidthsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrefersEqualWidthsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setPrefersEqualWidths:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPrefersEqualWidths_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPrefersEqualWidths_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSUserInterfaceCompressionOptions[] PrioritizedCompressionOptions
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("prioritizedCompressionOptions", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrioritizedCompressionOptionsHandle));
			}
			return NSArray.ArrayFromHandle<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrioritizedCompressionOptionsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setPrioritizedCompressionOptions:", ArgumentSemantic.Copy)]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrioritizedCompressionOptions_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrioritizedCompressionOptions_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSGroupTouchBarItem(NSCoder coder)
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
	protected NSGroupTouchBarItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGroupTouchBarItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSGroupTouchBarItem(string identifier)
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

	[Export("alertStyleGroupItemWithIdentifier:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGroupTouchBarItem CreateAlertStyleGroupItem(string identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSGroupTouchBarItem nSObject = Runtime.GetNSObject<NSGroupTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAlertStyleGroupItemWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("groupItemWithIdentifier:items:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGroupTouchBarItem CreateGroupItem(string identifier, NSTouchBarItem[] items)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSArray nSArray = NSArray.FromNSObjects(items);
		NSGroupTouchBarItem nSObject = Runtime.GetNSObject<NSGroupTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selGroupItemWithIdentifier_Items_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}

	[Export("groupItemWithIdentifier:items:allowedCompressionOptions:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGroupTouchBarItem CreateGroupItem(string identifier, NSTouchBarItem[] items, NSUserInterfaceCompressionOptions allowedCompressionOptions)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		if (allowedCompressionOptions == null)
		{
			throw new ArgumentNullException("allowedCompressionOptions");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSArray nSArray = NSArray.FromNSObjects(items);
		NSGroupTouchBarItem nSObject = Runtime.GetNSObject<NSGroupTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selGroupItemWithIdentifier_Items_AllowedCompressionOptions_Handle, arg, nSArray.Handle, allowedCompressionOptions.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}
}
