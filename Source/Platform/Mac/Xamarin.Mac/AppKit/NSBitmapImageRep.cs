using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSBitmapImageRep", true)]
public class NSBitmapImageRep : NSImageRep, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	private static IntPtr selInitForIncrementalLoad = Selector.GetHandle("initForIncrementalLoad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGImage = "CGImage";

	private static readonly IntPtr selCGImageHandle = Selector.GetHandle("CGImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTIFFRepresentation = "TIFFRepresentation";

	private static readonly IntPtr selTIFFRepresentationHandle = Selector.GetHandle("TIFFRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTIFFRepresentationOfImageRepsInArray_ = "TIFFRepresentationOfImageRepsInArray:";

	private static readonly IntPtr selTIFFRepresentationOfImageRepsInArray_Handle = Selector.GetHandle("TIFFRepresentationOfImageRepsInArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTIFFRepresentationOfImageRepsInArray_UsingCompression_Factor_ = "TIFFRepresentationOfImageRepsInArray:usingCompression:factor:";

	private static readonly IntPtr selTIFFRepresentationOfImageRepsInArray_UsingCompression_Factor_Handle = Selector.GetHandle("TIFFRepresentationOfImageRepsInArray:usingCompression:factor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTIFFRepresentationUsingCompression_Factor_ = "TIFFRepresentationUsingCompression:factor:";

	private static readonly IntPtr selTIFFRepresentationUsingCompression_Factor_Handle = Selector.GetHandle("TIFFRepresentationUsingCompression:factor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitmapData = "bitmapData";

	private static readonly IntPtr selBitmapDataHandle = Selector.GetHandle("bitmapData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitmapFormat = "bitmapFormat";

	private static readonly IntPtr selBitmapFormatHandle = Selector.GetHandle("bitmapFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitmapImageRepByConvertingToColorSpace_RenderingIntent_ = "bitmapImageRepByConvertingToColorSpace:renderingIntent:";

	private static readonly IntPtr selBitmapImageRepByConvertingToColorSpace_RenderingIntent_Handle = Selector.GetHandle("bitmapImageRepByConvertingToColorSpace:renderingIntent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitmapImageRepByRetaggingWithColorSpace_ = "bitmapImageRepByRetaggingWithColorSpace:";

	private static readonly IntPtr selBitmapImageRepByRetaggingWithColorSpace_Handle = Selector.GetHandle("bitmapImageRepByRetaggingWithColorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitsPerPixel = "bitsPerPixel";

	private static readonly IntPtr selBitsPerPixelHandle = Selector.GetHandle("bitsPerPixel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerPlane = "bytesPerPlane";

	private static readonly IntPtr selBytesPerPlaneHandle = Selector.GetHandle("bytesPerPlane");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerRow = "bytesPerRow";

	private static readonly IntPtr selBytesPerRowHandle = Selector.GetHandle("bytesPerRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanBeCompressedUsing_ = "canBeCompressedUsing:";

	private static readonly IntPtr selCanBeCompressedUsing_Handle = Selector.GetHandle("canBeCompressedUsing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorAtX_Y_ = "colorAtX:y:";

	private static readonly IntPtr selColorAtX_Y_Handle = Selector.GetHandle("colorAtX:y:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpace = "colorSpace";

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorizeByMappingGray_ToColor_BlackMapping_WhiteMapping_ = "colorizeByMappingGray:toColor:blackMapping:whiteMapping:";

	private static readonly IntPtr selColorizeByMappingGray_ToColor_BlackMapping_WhiteMapping_Handle = Selector.GetHandle("colorizeByMappingGray:toColor:blackMapping:whiteMapping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetBitmapDataPlanes_ = "getBitmapDataPlanes:";

	private static readonly IntPtr selGetBitmapDataPlanes_Handle = Selector.GetHandle("getBitmapDataPlanes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCompression_Factor_ = "getCompression:factor:";

	private static readonly IntPtr selGetCompression_Factor_Handle = Selector.GetHandle("getCompression:factor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepWithData_ = "imageRepWithData:";

	private static readonly IntPtr selImageRepWithData_Handle = Selector.GetHandle("imageRepWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepsWithData_ = "imageRepsWithData:";

	private static readonly IntPtr selImageRepsWithData_Handle = Selector.GetHandle("imageRepsWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncrementalLoadFromData_Complete_ = "incrementalLoadFromData:complete:";

	private static readonly IntPtr selIncrementalLoadFromData_Complete_Handle = Selector.GetHandle("incrementalLoadFromData:complete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel_ = "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:";

	private static readonly IntPtr selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel_Handle = Selector.GetHandle("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BytesPerRow_BitsPerPixel_ = "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:";

	private static readonly IntPtr selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BytesPerRow_BitsPerPixel_Handle = Selector.GetHandle("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGImage_ = "initWithCGImage:";

	private static readonly IntPtr selInitWithCGImage_Handle = Selector.GetHandle("initWithCGImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCIImage_ = "initWithCIImage:";

	private static readonly IntPtr selInitWithCIImage_Handle = Selector.GetHandle("initWithCIImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_ = "initWithData:";

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFocusedViewRect_ = "initWithFocusedViewRect:";

	private static readonly IntPtr selInitWithFocusedViewRect_Handle = Selector.GetHandle("initWithFocusedViewRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlanar = "isPlanar";

	private static readonly IntPtr selIsPlanarHandle = Selector.GetHandle("isPlanar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedNameForTIFFCompressionType_ = "localizedNameForTIFFCompressionType:";

	private static readonly IntPtr selLocalizedNameForTIFFCompressionType_Handle = Selector.GetHandle("localizedNameForTIFFCompressionType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfPlanes = "numberOfPlanes";

	private static readonly IntPtr selNumberOfPlanesHandle = Selector.GetHandle("numberOfPlanes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentationUsingType_Properties_ = "representationUsingType:properties:";

	private static readonly IntPtr selRepresentationUsingType_Properties_Handle = Selector.GetHandle("representationUsingType:properties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSamplesPerPixel = "samplesPerPixel";

	private static readonly IntPtr selSamplesPerPixelHandle = Selector.GetHandle("samplesPerPixel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor_AtX_Y_ = "setColor:atX:y:";

	private static readonly IntPtr selSetColor_AtX_Y_Handle = Selector.GetHandle("setColor:atX:y:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompression_Factor_ = "setCompression:factor:";

	private static readonly IntPtr selSetCompression_Factor_Handle = Selector.GetHandle("setCompression:factor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBitmapImageRep");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorSyncProfileData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CompressionFactor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CompressionMethod;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CurrentFrame;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CurrentFrameDuration;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DitherTransparency;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EXIFData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FallbackBackgroundColor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FrameCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Gamma;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Interlaced;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LoopCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Progressive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RGBColorTable;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr BitmapData
	{
		[Export("bitmapData")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selBitmapDataHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBitmapDataHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBitmapFormat BitmapFormat
	{
		[Export("bitmapFormat")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSBitmapFormat)Messaging.UInt64_objc_msgSend(base.Handle, selBitmapFormatHandle);
			}
			return (NSBitmapFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBitmapFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BitsPerPixel
	{
		[Export("bitsPerPixel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBitsPerPixelHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBitsPerPixelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BytesPerPlane
	{
		[Export("bytesPerPlane")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBytesPerPlaneHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBytesPerPlaneHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BytesPerRow
	{
		[Export("bytesPerRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBytesPerRowHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBytesPerRowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGImage CGImage
	{
		[Export("CGImage")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGImageHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGImageHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			}
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsPlanar
	{
		[Export("isPlanar")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlanarHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlanarHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Planes
	{
		[Export("numberOfPlanes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfPlanesHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfPlanesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SamplesPerPixel
	{
		[Export("samplesPerPixel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSamplesPerPixelHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSamplesPerPixelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData TiffRepresentation
	{
		[Export("TIFFRepresentation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selTIFFRepresentationHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTIFFRepresentationHandle));
		}
	}

	[Field("NSImageColorSyncProfileData", "AppKit")]
	public static NSString ColorSyncProfileData
	{
		get
		{
			if (_ColorSyncProfileData == null)
			{
				_ColorSyncProfileData = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageColorSyncProfileData");
			}
			return _ColorSyncProfileData;
		}
	}

	[Field("NSImageCompressionFactor", "AppKit")]
	public static NSString CompressionFactor
	{
		get
		{
			if (_CompressionFactor == null)
			{
				_CompressionFactor = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageCompressionFactor");
			}
			return _CompressionFactor;
		}
	}

	[Field("NSImageCompressionMethod", "AppKit")]
	public static NSString CompressionMethod
	{
		get
		{
			if (_CompressionMethod == null)
			{
				_CompressionMethod = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageCompressionMethod");
			}
			return _CompressionMethod;
		}
	}

	[Field("NSImageCurrentFrame", "AppKit")]
	public static NSString CurrentFrame
	{
		get
		{
			if (_CurrentFrame == null)
			{
				_CurrentFrame = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageCurrentFrame");
			}
			return _CurrentFrame;
		}
	}

	[Field("NSImageCurrentFrameDuration", "AppKit")]
	public static NSString CurrentFrameDuration
	{
		get
		{
			if (_CurrentFrameDuration == null)
			{
				_CurrentFrameDuration = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageCurrentFrameDuration");
			}
			return _CurrentFrameDuration;
		}
	}

	[Field("NSImageDitherTransparency", "AppKit")]
	public static NSString DitherTransparency
	{
		get
		{
			if (_DitherTransparency == null)
			{
				_DitherTransparency = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageDitherTransparency");
			}
			return _DitherTransparency;
		}
	}

	[Field("NSImageEXIFData", "AppKit")]
	public static NSString EXIFData
	{
		get
		{
			if (_EXIFData == null)
			{
				_EXIFData = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageEXIFData");
			}
			return _EXIFData;
		}
	}

	[Field("NSImageFallbackBackgroundColor", "AppKit")]
	public static NSString FallbackBackgroundColor
	{
		get
		{
			if (_FallbackBackgroundColor == null)
			{
				_FallbackBackgroundColor = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageFallbackBackgroundColor");
			}
			return _FallbackBackgroundColor;
		}
	}

	[Field("NSImageFrameCount", "AppKit")]
	public static NSString FrameCount
	{
		get
		{
			if (_FrameCount == null)
			{
				_FrameCount = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageFrameCount");
			}
			return _FrameCount;
		}
	}

	[Field("NSImageGamma", "AppKit")]
	public static NSString Gamma
	{
		get
		{
			if (_Gamma == null)
			{
				_Gamma = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageGamma");
			}
			return _Gamma;
		}
	}

	[Field("NSImageInterlaced", "AppKit")]
	public static NSString Interlaced
	{
		get
		{
			if (_Interlaced == null)
			{
				_Interlaced = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageInterlaced");
			}
			return _Interlaced;
		}
	}

	[Field("NSImageLoopCount", "AppKit")]
	public static NSString LoopCount
	{
		get
		{
			if (_LoopCount == null)
			{
				_LoopCount = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageLoopCount");
			}
			return _LoopCount;
		}
	}

	[Field("NSImageProgressive", "AppKit")]
	public static NSString Progressive
	{
		get
		{
			if (_Progressive == null)
			{
				_Progressive = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageProgressive");
			}
			return _Progressive;
		}
	}

	[Field("NSImageRGBColorTable", "AppKit")]
	public static NSString RGBColorTable
	{
		get
		{
			if (_RGBColorTable == null)
			{
				_RGBColorTable = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageRGBColorTable");
			}
			return _RGBColorTable;
		}
	}

	private NSBitmapImageRep(NSObjectFlag a, NSObjectFlag b)
		: base(a)
	{
		if (base.IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, selInitForIncrementalLoad);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitForIncrementalLoad);
		}
	}

	public NSData RepresentationUsingTypeProperties(NSBitmapImageFileType storageType)
	{
		return RepresentationUsingTypeProperties(storageType, null);
	}

	public static NSBitmapImageRep IncrementalLoader()
	{
		return new NSBitmapImageRep(NSObjectFlag.Empty, NSObjectFlag.Empty);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSBitmapImageRep(NSCoder coder)
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
	protected NSBitmapImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBitmapImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFocusedViewRect:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSView.CacheDisplay()' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBitmapImageRep(CGRect rect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFocusedViewRect_Handle, rect), "initWithFocusedViewRect:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFocusedViewRect_Handle, rect), "initWithFocusedViewRect:");
		}
	}

	[Export("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBitmapImageRep(IntPtr planes, nint width, nint height, nint bps, nint spp, bool alpha, bool isPlanar, string colorSpaceName, nint rBytes, nint pBits)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (colorSpaceName == null)
		{
			throw new ArgumentNullException("colorSpaceName");
		}
		IntPtr arg = NSString.CreateNative(colorSpaceName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint_nint_nint_bool_bool_IntPtr_nint_nint(base.Handle, selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BytesPerRow_BitsPerPixel_Handle, planes, width, height, bps, spp, alpha, isPlanar, arg, rBytes, pBits), "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_nint_nint_nint_bool_bool_IntPtr_nint_nint(base.SuperHandle, selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BytesPerRow_BitsPerPixel_Handle, planes, width, height, bps, spp, alpha, isPlanar, arg, rBytes, pBits), "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBitmapImageRep(IntPtr planes, nint width, nint height, nint bps, nint spp, bool alpha, bool isPlanar, string colorSpaceName, NSBitmapFormat bitmapFormat, nint rBytes, nint pBits)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (colorSpaceName == null)
		{
			throw new ArgumentNullException("colorSpaceName");
		}
		IntPtr arg = NSString.CreateNative(colorSpaceName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint_nint_nint_bool_bool_IntPtr_UInt64_nint_nint(base.Handle, selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel_Handle, planes, width, height, bps, spp, alpha, isPlanar, arg, (ulong)bitmapFormat, rBytes, pBits), "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_nint_nint_nint_bool_bool_IntPtr_UInt64_nint_nint(base.SuperHandle, selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel_Handle, planes, width, height, bps, spp, alpha, isPlanar, arg, (ulong)bitmapFormat, rBytes, pBits), "initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithCGImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBitmapImageRep(CGImage cgImage)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (cgImage == null)
		{
			throw new ArgumentNullException("cgImage");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGImage_Handle, cgImage.Handle), "initWithCGImage:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGImage_Handle, cgImage.Handle), "initWithCGImage:");
		}
	}

	[Export("initWithCIImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBitmapImageRep(CIImage ciImage)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (ciImage == null)
		{
			throw new ArgumentNullException("ciImage");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCIImage_Handle, ciImage.Handle), "initWithCIImage:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCIImage_Handle, ciImage.Handle), "initWithCIImage:");
		}
	}

	[Export("initWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSBitmapImageRep(NSData data)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
	}

	[Export("canBeCompressedUsing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanBeCompressedUsing(NSTiffCompression compression)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt64(base.Handle, selCanBeCompressedUsing_Handle, (ulong)compression);
		}
		return Messaging.bool_objc_msgSendSuper_UInt64(base.SuperHandle, selCanBeCompressedUsing_Handle, (ulong)compression);
	}

	[Export("colorAtX:y:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor ColorAt(nint x, nint y)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, selColorAtX_Y_Handle, x, y));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_nint_nint(base.SuperHandle, selColorAtX_Y_Handle, x, y));
	}

	[Export("colorizeByMappingGray:toColor:blackMapping:whiteMapping:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Colorize(nfloat midPoint, NSColor midPointColor, NSColor shadowColor, NSColor lightColor)
	{
		NSApplication.EnsureUIThread();
		if (midPointColor == null)
		{
			throw new ArgumentNullException("midPointColor");
		}
		if (shadowColor == null)
		{
			throw new ArgumentNullException("shadowColor");
		}
		if (lightColor == null)
		{
			throw new ArgumentNullException("lightColor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_IntPtr_IntPtr_IntPtr(base.Handle, selColorizeByMappingGray_ToColor_BlackMapping_WhiteMapping_Handle, midPoint, midPointColor.Handle, shadowColor.Handle, lightColor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_IntPtr_IntPtr_IntPtr(base.SuperHandle, selColorizeByMappingGray_ToColor_BlackMapping_WhiteMapping_Handle, midPoint, midPointColor.Handle, shadowColor.Handle, lightColor.Handle);
		}
	}

	[Export("bitmapImageRepByConvertingToColorSpace:renderingIntent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBitmapImageRep ConvertingToColorSpace(NSColorSpace targetSpace, NSColorRenderingIntent renderingIntent)
	{
		NSApplication.EnsureUIThread();
		if (targetSpace == null)
		{
			throw new ArgumentNullException("targetSpace");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSBitmapImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr_Int64(base.Handle, selBitmapImageRepByConvertingToColorSpace_RenderingIntent_Handle, targetSpace.Handle, (long)renderingIntent));
		}
		return Runtime.GetNSObject<NSBitmapImageRep>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selBitmapImageRepByConvertingToColorSpace_RenderingIntent_Handle, targetSpace.Handle, (long)renderingIntent));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
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

	[Export("getBitmapDataPlanes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetBitmapDataPlanes(IntPtr data)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetBitmapDataPlanes_Handle, data);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetBitmapDataPlanes_Handle, data);
		}
	}

	[Export("getCompression:factor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetCompressionFactor(out NSTiffCompression compression, out float factor)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_NSTiffCompression_out_Single(base.Handle, selGetCompression_Factor_Handle, out compression, out factor);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_NSTiffCompression_out_Single(base.SuperHandle, selGetCompression_Factor_Handle, out compression, out factor);
		}
	}

	[Export("imageRepWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImageRep ImageRepFromData(NSData data)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithData_Handle, data.Handle));
	}

	[Export("imageRepsWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImageRep[] ImageRepsWithData(NSData data)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepsWithData_Handle, data.Handle));
	}

	[Export("TIFFRepresentationOfImageRepsInArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData ImagesAsTiff(NSImageRep[] imageReps)
	{
		NSApplication.EnsureUIThread();
		if (imageReps == null)
		{
			throw new ArgumentNullException("imageReps");
		}
		NSArray nSArray = NSArray.FromNSObjects(imageReps);
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTIFFRepresentationOfImageRepsInArray_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("TIFFRepresentationOfImageRepsInArray:usingCompression:factor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData ImagesAsTiff(NSImageRep[] imageReps, NSTiffCompression comp, float factor)
	{
		NSApplication.EnsureUIThread();
		if (imageReps == null)
		{
			throw new ArgumentNullException("imageReps");
		}
		NSArray nSArray = NSArray.FromNSObjects(imageReps);
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_float(class_ptr, selTIFFRepresentationOfImageRepsInArray_UsingCompression_Factor_Handle, nSArray.Handle, (ulong)comp, factor));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("incrementalLoadFromData:complete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IncrementalLoad(NSData data, bool complete)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr_bool(base.Handle, selIncrementalLoadFromData_Complete_Handle, data.Handle, complete);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selIncrementalLoadFromData_Complete_Handle, data.Handle, complete);
	}

	[Export("localizedNameForTIFFCompressionType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizedNameForTiffCompressionType(NSTiffCompression compression)
	{
		NSApplication.EnsureUIThread();
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selLocalizedNameForTIFFCompressionType_Handle, (ulong)compression));
	}

	[Export("representationUsingType:properties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData RepresentationUsingTypeProperties(NSBitmapImageFileType storageType, NSDictionary? properties)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selRepresentationUsingType_Properties_Handle, (ulong)storageType, properties?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selRepresentationUsingType_Properties_Handle, (ulong)storageType, properties?.Handle ?? IntPtr.Zero));
	}

	[Export("bitmapImageRepByRetaggingWithColorSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBitmapImageRep RetaggedWithColorSpace(NSColorSpace newSpace)
	{
		NSApplication.EnsureUIThread();
		if (newSpace == null)
		{
			throw new ArgumentNullException("newSpace");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSBitmapImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selBitmapImageRepByRetaggingWithColorSpace_Handle, newSpace.Handle));
		}
		return Runtime.GetNSObject<NSBitmapImageRep>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selBitmapImageRepByRetaggingWithColorSpace_Handle, newSpace.Handle));
	}

	[Export("setColor:atX:y:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetColorAt(NSColor color, nint x, nint y)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint_nint(base.Handle, selSetColor_AtX_Y_Handle, color.Handle, x, y);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint_nint(base.SuperHandle, selSetColor_AtX_Y_Handle, color.Handle, x, y);
		}
	}

	[Export("setCompression:factor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCompressionFactor(NSTiffCompression compression, float factor)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_float(base.Handle, selSetCompression_Factor_Handle, (ulong)compression, factor);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_float(base.SuperHandle, selSetCompression_Factor_Handle, (ulong)compression, factor);
		}
	}

	[Export("TIFFRepresentationUsingCompression:factor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData TiffRepresentationUsingCompressionFactor(NSTiffCompression comp, float factor)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_UInt64_float(base.Handle, selTIFFRepresentationUsingCompression_Factor_Handle, (ulong)comp, factor));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_UInt64_float(base.SuperHandle, selTIFFRepresentationUsingCompression_Factor_Handle, (ulong)comp, factor));
	}
}
