using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorSpace", true)]
public class NSColorSpace : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGColorSpace = "CGColorSpace";

	private static readonly IntPtr selCGColorSpaceHandle = Selector.GetHandle("CGColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selICCProfileData = "ICCProfileData";

	private static readonly IntPtr selICCProfileDataHandle = Selector.GetHandle("ICCProfileData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdobeRGB1998ColorSpace = "adobeRGB1998ColorSpace";

	private static readonly IntPtr selAdobeRGB1998ColorSpaceHandle = Selector.GetHandle("adobeRGB1998ColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableColorSpacesWithModel_ = "availableColorSpacesWithModel:";

	private static readonly IntPtr selAvailableColorSpacesWithModel_Handle = Selector.GetHandle("availableColorSpacesWithModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpaceModel = "colorSpaceModel";

	private static readonly IntPtr selColorSpaceModelHandle = Selector.GetHandle("colorSpaceModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSyncProfile = "colorSyncProfile";

	private static readonly IntPtr selColorSyncProfileHandle = Selector.GetHandle("colorSyncProfile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceCMYKColorSpace = "deviceCMYKColorSpace";

	private static readonly IntPtr selDeviceCMYKColorSpaceHandle = Selector.GetHandle("deviceCMYKColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceGrayColorSpace = "deviceGrayColorSpace";

	private static readonly IntPtr selDeviceGrayColorSpaceHandle = Selector.GetHandle("deviceGrayColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceRGBColorSpace = "deviceRGBColorSpace";

	private static readonly IntPtr selDeviceRGBColorSpaceHandle = Selector.GetHandle("deviceRGBColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayP3ColorSpace = "displayP3ColorSpace";

	private static readonly IntPtr selDisplayP3ColorSpaceHandle = Selector.GetHandle("displayP3ColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendedGenericGamma22GrayColorSpace = "extendedGenericGamma22GrayColorSpace";

	private static readonly IntPtr selExtendedGenericGamma22GrayColorSpaceHandle = Selector.GetHandle("extendedGenericGamma22GrayColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendedSRGBColorSpace = "extendedSRGBColorSpace";

	private static readonly IntPtr selExtendedSRGBColorSpaceHandle = Selector.GetHandle("extendedSRGBColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenericCMYKColorSpace = "genericCMYKColorSpace";

	private static readonly IntPtr selGenericCMYKColorSpaceHandle = Selector.GetHandle("genericCMYKColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenericGamma22GrayColorSpace = "genericGamma22GrayColorSpace";

	private static readonly IntPtr selGenericGamma22GrayColorSpaceHandle = Selector.GetHandle("genericGamma22GrayColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenericGrayColorSpace = "genericGrayColorSpace";

	private static readonly IntPtr selGenericGrayColorSpaceHandle = Selector.GetHandle("genericGrayColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenericRGBColorSpace = "genericRGBColorSpace";

	private static readonly IntPtr selGenericRGBColorSpaceHandle = Selector.GetHandle("genericRGBColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGColorSpace_ = "initWithCGColorSpace:";

	private static readonly IntPtr selInitWithCGColorSpace_Handle = Selector.GetHandle("initWithCGColorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithICCProfileData_ = "initWithICCProfileData:";

	private static readonly IntPtr selInitWithICCProfileData_Handle = Selector.GetHandle("initWithICCProfileData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedName = "localizedName";

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColorComponents = "numberOfColorComponents";

	private static readonly IntPtr selNumberOfColorComponentsHandle = Selector.GetHandle("numberOfColorComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSRGBColorSpace = "sRGBColorSpace";

	private static readonly IntPtr selSRGBColorSpaceHandle = Selector.GetHandle("sRGBColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CalibratedBlack;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CalibratedRGB;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CalibratedWhite;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Custom;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeviceBlack;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeviceCMYK;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeviceRGB;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeviceWhite;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Named;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Pattern;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace AdobeRGB1998ColorSpace
	{
		[Export("adobeRGB1998ColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selAdobeRGB1998ColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ColorComponents
	{
		[Export("numberOfColorComponents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfColorComponentsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfColorComponentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColorSpace ColorSpace
	{
		[Export("CGColorSpace")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGColorSpaceHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGColorSpaceHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColorSpaceModel ColorSpaceModel
	{
		[Export("colorSpaceModel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSColorSpaceModel)Messaging.Int64_objc_msgSend(base.Handle, selColorSpaceModelHandle);
			}
			return (NSColorSpaceModel)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selColorSpaceModelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr ColorSyncProfile
	{
		[Export("colorSyncProfile")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selColorSyncProfileHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSyncProfileHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace DeviceCMYKColorSpace
	{
		[Export("deviceCMYKColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selDeviceCMYKColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace DeviceGrayColorSpace
	{
		[Export("deviceGrayColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selDeviceGrayColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace DeviceRGBColorSpace
	{
		[Export("deviceRGBColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selDeviceRGBColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSColorSpace DisplayP3ColorSpace
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("displayP3ColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selDisplayP3ColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSColorSpace ExtendedGenericGamma22GrayColorSpace
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("extendedGenericGamma22GrayColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selExtendedGenericGamma22GrayColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSColorSpace ExtendedSRgbColorSpace
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("extendedSRGBColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selExtendedSRGBColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace GenericCMYKColorSpace
	{
		[Export("genericCMYKColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selGenericCMYKColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace GenericGamma22GrayColorSpace
	{
		[Export("genericGamma22GrayColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selGenericGamma22GrayColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace GenericGrayColorSpace
	{
		[Export("genericGrayColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selGenericGrayColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace GenericRGBColorSpace
	{
		[Export("genericRGBColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selGenericRGBColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData ICCProfileData
	{
		[Export("ICCProfileData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selICCProfileDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selICCProfileDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedName
	{
		[Export("localizedName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace SRGBColorSpace
	{
		[Export("sRGBColorSpace")]
		get
		{
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(class_ptr, selSRGBColorSpaceHandle));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSColorSpace()
		: base(NSObjectFlag.Empty)
	{
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
	public NSColorSpace(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected NSColorSpace(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSColorSpace(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithICCProfileData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSColorSpace(NSData iccData)
		: base(NSObjectFlag.Empty)
	{
		if (iccData == null)
		{
			throw new ArgumentNullException("iccData");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithICCProfileData_Handle, iccData.Handle), "initWithICCProfileData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithICCProfileData_Handle, iccData.Handle), "initWithICCProfileData:");
		}
	}

	[Export("initWithCGColorSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSColorSpace(CGColorSpace cgColorSpace)
		: base(NSObjectFlag.Empty)
	{
		if (cgColorSpace == null)
		{
			throw new ArgumentNullException("cgColorSpace");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGColorSpace_Handle, cgColorSpace.Handle), "initWithCGColorSpace:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGColorSpace_Handle, cgColorSpace.Handle), "initWithCGColorSpace:");
		}
	}

	[Export("availableColorSpacesWithModel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColorSpace[] AvailableColorSpacesWithModel(NSColorSpaceModel model)
	{
		return NSArray.ArrayFromHandle<NSColorSpace>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selAvailableColorSpacesWithModel_Handle, (long)model));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
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
}
