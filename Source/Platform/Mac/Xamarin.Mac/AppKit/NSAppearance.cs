using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAppearance", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class NSAppearance : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsVibrancy = "allowsVibrancy";

	private static readonly IntPtr selAllowsVibrancyHandle = Selector.GetHandle("allowsVibrancy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppearanceNamed_ = "appearanceNamed:";

	private static readonly IntPtr selAppearanceNamed_Handle = Selector.GetHandle("appearanceNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBestMatchFromAppearancesWithNames_ = "bestMatchFromAppearancesWithNames:";

	private static readonly IntPtr selBestMatchFromAppearancesWithNames_Handle = Selector.GetHandle("bestMatchFromAppearancesWithNames:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentAppearance = "currentAppearance";

	private static readonly IntPtr selCurrentAppearanceHandle = Selector.GetHandle("currentAppearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAppearanceNamed_Bundle_ = "initWithAppearanceNamed:bundle:";

	private static readonly IntPtr selInitWithAppearanceNamed_Bundle_Handle = Selector.GetHandle("initWithAppearanceNamed:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentAppearance_ = "setCurrentAppearance:";

	private static readonly IntPtr selSetCurrentAppearance_Handle = Selector.GetHandle("setCurrentAppearance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAppearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameAccessibilityHighContrastAqua;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameAccessibilityHighContrastDarkAqua;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameAccessibilityHighContrastVibrantDark;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameAccessibilityHighContrastVibrantLight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameAqua;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameDarkAqua;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameLightContent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameVibrantDark;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameVibrantLight;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AllowsVibrancy
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("allowsVibrancy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsVibrancyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsVibrancyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppearance CurrentAppearance
	{
		[Export("currentAppearance")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentAppearanceHandle));
		}
		[Export("setCurrentAppearance:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetCurrentAppearance_Handle, value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string Name
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("name")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[Field("NSAppearanceNameAccessibilityHighContrastAqua", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString NameAccessibilityHighContrastAqua
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_NameAccessibilityHighContrastAqua == null)
			{
				_NameAccessibilityHighContrastAqua = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameAccessibilityHighContrastAqua");
			}
			return _NameAccessibilityHighContrastAqua;
		}
	}

	[Field("NSAppearanceNameAccessibilityHighContrastDarkAqua", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString NameAccessibilityHighContrastDarkAqua
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_NameAccessibilityHighContrastDarkAqua == null)
			{
				_NameAccessibilityHighContrastDarkAqua = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameAccessibilityHighContrastDarkAqua");
			}
			return _NameAccessibilityHighContrastDarkAqua;
		}
	}

	[Field("NSAppearanceNameAccessibilityHighContrastVibrantDark", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString NameAccessibilityHighContrastVibrantDark
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_NameAccessibilityHighContrastVibrantDark == null)
			{
				_NameAccessibilityHighContrastVibrantDark = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameAccessibilityHighContrastVibrantDark");
			}
			return _NameAccessibilityHighContrastVibrantDark;
		}
	}

	[Field("NSAppearanceNameAccessibilityHighContrastVibrantLight", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString NameAccessibilityHighContrastVibrantLight
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_NameAccessibilityHighContrastVibrantLight == null)
			{
				_NameAccessibilityHighContrastVibrantLight = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameAccessibilityHighContrastVibrantLight");
			}
			return _NameAccessibilityHighContrastVibrantLight;
		}
	}

	[Field("NSAppearanceNameAqua", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString NameAqua
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_NameAqua == null)
			{
				_NameAqua = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameAqua");
			}
			return _NameAqua;
		}
	}

	[Field("NSAppearanceNameDarkAqua", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString NameDarkAqua
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_NameDarkAqua == null)
			{
				_NameDarkAqua = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameDarkAqua");
			}
			return _NameDarkAqua;
		}
	}

	[Field("NSAppearanceNameLightContent", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString NameLightContent
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_NameLightContent == null)
			{
				_NameLightContent = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameLightContent");
			}
			return _NameLightContent;
		}
	}

	[Field("NSAppearanceNameVibrantDark", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString NameVibrantDark
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_NameVibrantDark == null)
			{
				_NameVibrantDark = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameVibrantDark");
			}
			return _NameVibrantDark;
		}
	}

	[Field("NSAppearanceNameVibrantLight", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString NameVibrantLight
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_NameVibrantLight == null)
			{
				_NameVibrantLight = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameVibrantLight");
			}
			return _NameVibrantLight;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAppearance()
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
	public NSAppearance(NSCoder coder)
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
	protected NSAppearance(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAppearance(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAppearanceNamed:bundle:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAppearance(string name, NSBundle? bundle)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAppearanceNamed_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithAppearanceNamed:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAppearanceNamed_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithAppearanceNamed:bundle:");
		}
		NSString.ReleaseNative(arg);
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

	[Export("bestMatchFromAppearancesWithNames:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? FindBestMatch(string[] appearances)
	{
		NSApplication.EnsureUIThread();
		if (appearances == null)
		{
			throw new ArgumentNullException("appearances");
		}
		NSArray nSArray = NSArray.FromStrings(appearances);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selBestMatchFromAppearancesWithNames_Handle, nSArray.Handle)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selBestMatchFromAppearancesWithNames_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("appearanceNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppearance GetAppearance(NSString name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAppearanceNamed_Handle, name.Handle));
	}
}
