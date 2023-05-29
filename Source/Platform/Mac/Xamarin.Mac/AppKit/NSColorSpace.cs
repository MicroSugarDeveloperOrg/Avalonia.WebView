using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorSpace", true)]
public class NSColorSpace : NSObject
{
	private static readonly IntPtr selICCProfileDataHandle = Selector.GetHandle("ICCProfileData");

	private static readonly IntPtr selColorSyncProfileHandle = Selector.GetHandle("colorSyncProfile");

	private static readonly IntPtr selCGColorSpaceHandle = Selector.GetHandle("CGColorSpace");

	private static readonly IntPtr selNumberOfColorComponentsHandle = Selector.GetHandle("numberOfColorComponents");

	private static readonly IntPtr selColorSpaceModelHandle = Selector.GetHandle("colorSpaceModel");

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	private static readonly IntPtr selGenericRGBColorSpaceHandle = Selector.GetHandle("genericRGBColorSpace");

	private static readonly IntPtr selGenericGrayColorSpaceHandle = Selector.GetHandle("genericGrayColorSpace");

	private static readonly IntPtr selGenericCMYKColorSpaceHandle = Selector.GetHandle("genericCMYKColorSpace");

	private static readonly IntPtr selDeviceRGBColorSpaceHandle = Selector.GetHandle("deviceRGBColorSpace");

	private static readonly IntPtr selDeviceGrayColorSpaceHandle = Selector.GetHandle("deviceGrayColorSpace");

	private static readonly IntPtr selDeviceCMYKColorSpaceHandle = Selector.GetHandle("deviceCMYKColorSpace");

	private static readonly IntPtr selSRGBColorSpaceHandle = Selector.GetHandle("sRGBColorSpace");

	private static readonly IntPtr selGenericGamma22GrayColorSpaceHandle = Selector.GetHandle("genericGamma22GrayColorSpace");

	private static readonly IntPtr selAdobeRGB1998ColorSpaceHandle = Selector.GetHandle("adobeRGB1998ColorSpace");

	private static readonly IntPtr selInitWithICCProfileData_Handle = Selector.GetHandle("initWithICCProfileData:");

	private static readonly IntPtr selInitWithCGColorSpace_Handle = Selector.GetHandle("initWithCGColorSpace:");

	private static readonly IntPtr selAvailableColorSpacesWithModel_Handle = Selector.GetHandle("availableColorSpacesWithModel:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSColorSpace");

	private object __mt_ICCProfileData_var;

	private static object __mt_GenericRGBColorSpace_var_static;

	private static object __mt_GenericGrayColorSpace_var_static;

	private static object __mt_GenericCMYKColorSpace_var_static;

	private static object __mt_DeviceRGBColorSpace_var_static;

	private static object __mt_DeviceGrayColorSpace_var_static;

	private static object __mt_DeviceCMYKColorSpace_var_static;

	private static object __mt_SRGBColorSpace_var_static;

	private static object __mt_GenericGamma22GrayColorSpace_var_static;

	private static object __mt_AdobeRGB1998ColorSpace_var_static;

	private static NSString _CalibratedWhite;

	private static NSString _CalibratedBlack;

	private static NSString _CalibratedRGB;

	private static NSString _DeviceWhite;

	private static NSString _DeviceBlack;

	private static NSString _DeviceRGB;

	private static NSString _DeviceCMYK;

	private static NSString _Named;

	private static NSString _Pattern;

	private static NSString _Custom;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSData ICCProfileData
	{
		[Export("ICCProfileData")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSData)(__mt_ICCProfileData_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selICCProfileDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selICCProfileDataHandle)))));
		}
	}

	public virtual IntPtr ColorSyncProfile
	{
		[Export("colorSyncProfile")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selColorSyncProfileHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSyncProfileHandle);
		}
	}

	public virtual CGColorSpace ColorSpace
	{
		[Export("CGColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return new CGColorSpace(Messaging.IntPtr_objc_msgSend(base.Handle, selCGColorSpaceHandle));
			}
			return new CGColorSpace(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGColorSpaceHandle));
		}
	}

	public virtual int ColorComponents
	{
		[Export("numberOfColorComponents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfColorComponentsHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfColorComponentsHandle);
		}
	}

	public virtual NSColorSpaceModel ColorSpaceModel
	{
		[Export("colorSpaceModel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSColorSpaceModel)Messaging.Int64_objc_msgSend(base.Handle, selColorSpaceModelHandle);
			}
			return (NSColorSpaceModel)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selColorSpaceModelHandle);
		}
	}

	public virtual string LocalizedName
	{
		[Export("localizedName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	public static NSColorSpace GenericRGBColorSpace
	{
		[Export("genericRGBColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_GenericRGBColorSpace_var_static = (NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selGenericRGBColorSpaceHandle)));
		}
	}

	public static NSColorSpace GenericGrayColorSpace
	{
		[Export("genericGrayColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_GenericGrayColorSpace_var_static = (NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selGenericGrayColorSpaceHandle)));
		}
	}

	public static NSColorSpace GenericCMYKColorSpace
	{
		[Export("genericCMYKColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_GenericCMYKColorSpace_var_static = (NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selGenericCMYKColorSpaceHandle)));
		}
	}

	public static NSColorSpace DeviceRGBColorSpace
	{
		[Export("deviceRGBColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_DeviceRGBColorSpace_var_static = (NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDeviceRGBColorSpaceHandle)));
		}
	}

	public static NSColorSpace DeviceGrayColorSpace
	{
		[Export("deviceGrayColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_DeviceGrayColorSpace_var_static = (NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDeviceGrayColorSpaceHandle)));
		}
	}

	public static NSColorSpace DeviceCMYKColorSpace
	{
		[Export("deviceCMYKColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_DeviceCMYKColorSpace_var_static = (NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDeviceCMYKColorSpaceHandle)));
		}
	}

	public static NSColorSpace SRGBColorSpace
	{
		[Export("sRGBColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_SRGBColorSpace_var_static = (NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSRGBColorSpaceHandle)));
		}
	}

	public static NSColorSpace GenericGamma22GrayColorSpace
	{
		[Export("genericGamma22GrayColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_GenericGamma22GrayColorSpace_var_static = (NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selGenericGamma22GrayColorSpaceHandle)));
		}
	}

	public static NSColorSpace AdobeRGB1998ColorSpace
	{
		[Export("adobeRGB1998ColorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_AdobeRGB1998ColorSpace_var_static = (NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAdobeRGB1998ColorSpaceHandle)));
		}
	}

	[Field("NSCalibratedWhiteColorSpace", "AppKit")]
	public static NSString CalibratedWhite
	{
		get
		{
			if (_CalibratedWhite == null)
			{
				_CalibratedWhite = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSCalibratedWhiteColorSpace");
			}
			return _CalibratedWhite;
		}
	}

	[Field("NSCalibratedBlackColorSpace", "AppKit")]
	public static NSString CalibratedBlack
	{
		get
		{
			if (_CalibratedBlack == null)
			{
				_CalibratedBlack = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSCalibratedBlackColorSpace");
			}
			return _CalibratedBlack;
		}
	}

	[Field("NSCalibratedRGBColorSpace", "AppKit")]
	public static NSString CalibratedRGB
	{
		get
		{
			if (_CalibratedRGB == null)
			{
				_CalibratedRGB = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSCalibratedRGBColorSpace");
			}
			return _CalibratedRGB;
		}
	}

	[Field("NSDeviceWhiteColorSpace", "AppKit")]
	public static NSString DeviceWhite
	{
		get
		{
			if (_DeviceWhite == null)
			{
				_DeviceWhite = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSDeviceWhiteColorSpace");
			}
			return _DeviceWhite;
		}
	}

	[Field("NSDeviceBlackColorSpace", "AppKit")]
	public static NSString DeviceBlack
	{
		get
		{
			if (_DeviceBlack == null)
			{
				_DeviceBlack = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSDeviceBlackColorSpace");
			}
			return _DeviceBlack;
		}
	}

	[Field("NSDeviceRGBColorSpace", "AppKit")]
	public static NSString DeviceRGB
	{
		get
		{
			if (_DeviceRGB == null)
			{
				_DeviceRGB = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSDeviceRGBColorSpace");
			}
			return _DeviceRGB;
		}
	}

	[Field("NSDeviceCMYKColorSpace", "AppKit")]
	public static NSString DeviceCMYK
	{
		get
		{
			if (_DeviceCMYK == null)
			{
				_DeviceCMYK = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSDeviceCMYKColorSpace");
			}
			return _DeviceCMYK;
		}
	}

	[Field("NSNamedColorSpace", "AppKit")]
	public static NSString Named
	{
		get
		{
			if (_Named == null)
			{
				_Named = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSNamedColorSpace");
			}
			return _Named;
		}
	}

	[Field("NSPatternColorSpace", "AppKit")]
	public static NSString Pattern
	{
		get
		{
			if (_Pattern == null)
			{
				_Pattern = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPatternColorSpace");
			}
			return _Pattern;
		}
	}

	[Field("NSCustomColorSpace", "AppKit")]
	public static NSString Custom
	{
		get
		{
			if (_Custom == null)
			{
				_Custom = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSCustomColorSpace");
			}
			return _Custom;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSColorSpace()
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
	public NSColorSpace(NSCoder coder)
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
	public NSColorSpace(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSColorSpace(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithICCProfileData:")]
	public NSColorSpace(NSData iccData)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (iccData == null)
		{
			throw new ArgumentNullException("iccData");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithICCProfileData_Handle, iccData.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithICCProfileData_Handle, iccData.Handle);
		}
	}

	[Export("initWithCGColorSpace:")]
	public NSColorSpace(CGColorSpace cgColorSpace)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGColorSpace_Handle, cgColorSpace.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGColorSpace_Handle, cgColorSpace.Handle);
		}
	}

	[Export("availableColorSpacesWithModel:")]
	public static NSColorSpace[] AvailableColorSpacesWithModel(NSColorSpaceModel model)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSColorSpace>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selAvailableColorSpacesWithModel_Handle, (long)model));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ICCProfileData_var = null;
		}
	}
}
