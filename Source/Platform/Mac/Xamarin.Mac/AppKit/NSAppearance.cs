using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAppearance", true)]
public class NSAppearance : NSObject
{
	private static readonly IntPtr selCurrentAppearanceHandle = Selector.GetHandle("currentAppearance");

	private static readonly IntPtr selSetCurrentAppearance_Handle = Selector.GetHandle("setCurrentAppearance:");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selAllowsVibrancyHandle = Selector.GetHandle("allowsVibrancy");

	private static readonly IntPtr selAppearanceNamed_Handle = Selector.GetHandle("appearanceNamed:");

	private static readonly IntPtr selInitWithAppearanceNamedBundle_Handle = Selector.GetHandle("initWithAppearanceNamed:bundle:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAppearance");

	private static object __mt_CurrentAppearance_var_static;

	private object __mt_Name_var;

	private static NSString _NameAqua;

	private static NSString _NameLightContent;

	private static NSString _NameVibrantDark;

	private static NSString _NameVibrantLight;

	public override IntPtr ClassHandle => class_ptr;

	public static NSAppearance CurrentAppearance
	{
		[Export("currentAppearance")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAppearance)(__mt_CurrentAppearance_var_static = (NSAppearance)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentAppearanceHandle)));
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

	public virtual NSString Name
	{
		[Export("name")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSString)(__mt_Name_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle)))));
		}
	}

	public virtual bool AllowsVibrancy
	{
		[Export("allowsVibrancy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsVibrancyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsVibrancyHandle);
		}
	}

	[Field("NSAppearanceNameAqua", "AppKit")]
	public static NSString NameAqua
	{
		get
		{
			if (_NameAqua == null)
			{
				_NameAqua = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameAqua");
			}
			return _NameAqua;
		}
	}

	[Field("NSAppearanceNameLightContent", "AppKit")]
	public static NSString NameLightContent
	{
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
	public static NSString NameVibrantDark
	{
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
	public static NSString NameVibrantLight
	{
		get
		{
			if (_NameVibrantLight == null)
			{
				_NameVibrantLight = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAppearanceNameVibrantLight");
			}
			return _NameVibrantLight;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAppearance()
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
	public NSAppearance(NSCoder coder)
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
	public NSAppearance(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAppearance(IntPtr handle)
		: base(handle)
	{
	}

	[Export("appearanceNamed:")]
	public static NSAppearance GetAppearance(NSString name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return (NSAppearance)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAppearanceNamed_Handle, name.Handle));
	}

	[Export("initWithAppearanceNamed:bundle:")]
	public NSAppearance(NSString name, NSBundle bundle)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (bundle == null)
		{
			throw new ArgumentNullException("bundle");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAppearanceNamedBundle_Handle, name.Handle, bundle.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAppearanceNamedBundle_Handle, name.Handle, bundle.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Name_var = null;
		}
	}
}
