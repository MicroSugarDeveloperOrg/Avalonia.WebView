using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorPickerTouchBarItem", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public class NSColorPickerTouchBarItem : NSTouchBarItem
{
	private NSObject target;

	private Selector action;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAction = "action";

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedColorSpaces = "allowedColorSpaces";

	private static readonly IntPtr selAllowedColorSpacesHandle = Selector.GetHandle("allowedColorSpaces");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor = "color";

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorList = "colorList";

	private static readonly IntPtr selColorListHandle = Selector.GetHandle("colorList");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorPickerWithIdentifier_ = "colorPickerWithIdentifier:";

	private static readonly IntPtr selColorPickerWithIdentifier_Handle = Selector.GetHandle("colorPickerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorPickerWithIdentifier_ButtonImage_ = "colorPickerWithIdentifier:buttonImage:";

	private static readonly IntPtr selColorPickerWithIdentifier_ButtonImage_Handle = Selector.GetHandle("colorPickerWithIdentifier:buttonImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomizationLabel = "customizationLabel";

	private static readonly IntPtr selCustomizationLabelHandle = Selector.GetHandle("customizationLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ = "initWithIdentifier:";

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAction_ = "setAction:";

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowedColorSpaces_ = "setAllowedColorSpaces:";

	private static readonly IntPtr selSetAllowedColorSpaces_Handle = Selector.GetHandle("setAllowedColorSpaces:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor_ = "setColor:";

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorList_ = "setColorList:";

	private static readonly IntPtr selSetColorList_Handle = Selector.GetHandle("setColorList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomizationLabel_ = "setCustomizationLabel:";

	private static readonly IntPtr selSetCustomizationLabel_Handle = Selector.GetHandle("setCustomizationLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsAlpha_ = "setShowsAlpha:";

	private static readonly IntPtr selSetShowsAlpha_Handle = Selector.GetHandle("setShowsAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsAlpha = "showsAlpha";

	private static readonly IntPtr selShowsAlphaHandle = Selector.GetHandle("showsAlpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeColorPickerWithIdentifier_ = "strokeColorPickerWithIdentifier:";

	private static readonly IntPtr selStrokeColorPickerWithIdentifier_Handle = Selector.GetHandle("strokeColorPickerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextColorPickerWithIdentifier_ = "textColorPickerWithIdentifier:";

	private static readonly IntPtr selTextColorPickerWithIdentifier_Handle = Selector.GetHandle("textColorPickerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSColorPickerTouchBarItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Target_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector? Action
	{
		[Export("action", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle));
		}
		[Export("setAction:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSColorSpace[]? AllowedColorSpaces
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("allowedColorSpaces", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSColorSpace>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedColorSpacesHandle));
			}
			return NSArray.ArrayFromHandle<NSColorSpace>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedColorSpacesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setAllowedColorSpaces:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAllowedColorSpaces_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAllowedColorSpaces_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor Color
	{
		[Export("color", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle));
		}
		[Export("setColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColorList ColorList
	{
		[Export("colorList", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColorList>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorListHandle));
			}
			return Runtime.GetNSObject<NSColorList>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorListHandle));
		}
		[Export("setColorList:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorList_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorList_Handle, value.Handle);
			}
		}
	}

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
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsAlpha
	{
		[Export("showsAlpha")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsAlphaHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsAlphaHandle);
		}
		[Export("setShowsAlpha:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsAlpha_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Target
	{
		[Export("target", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle)));
			MarkDirty();
			__mt_Target_var = nSObject;
			return nSObject;
		}
		[Export("setTarget:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Target_var = value;
		}
	}

	public event EventHandler Activated
	{
		add
		{
			target = ActionDispatcher.SetupAction(Target, value);
			action = ActionDispatcher.Action;
			MarkDirty();
			Target = target;
			Action = action;
		}
		remove
		{
			ActionDispatcher.RemoveAction(Target, value);
			target = null;
			action = null;
			MarkDirty();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSColorPickerTouchBarItem(NSCoder coder)
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
	protected NSColorPickerTouchBarItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSColorPickerTouchBarItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSColorPickerTouchBarItem(string identifier)
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

	[Export("colorPickerWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorPickerTouchBarItem CreateColorPicker(string identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSColorPickerTouchBarItem nSObject = Runtime.GetNSObject<NSColorPickerTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorPickerWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("colorPickerWithIdentifier:buttonImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorPickerTouchBarItem CreateColorPicker(string identifier, NSImage image)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSColorPickerTouchBarItem nSObject = Runtime.GetNSObject<NSColorPickerTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selColorPickerWithIdentifier_ButtonImage_Handle, arg, image.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("strokeColorPickerWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorPickerTouchBarItem CreateStrokeColorPicker(string identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSColorPickerTouchBarItem nSObject = Runtime.GetNSObject<NSColorPickerTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selStrokeColorPickerWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("textColorPickerWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorPickerTouchBarItem CreateTextColorPicker(string identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSColorPickerTouchBarItem nSObject = Runtime.GetNSObject<NSColorPickerTouchBarItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextColorPickerWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Target_var = null;
		}
	}
}
