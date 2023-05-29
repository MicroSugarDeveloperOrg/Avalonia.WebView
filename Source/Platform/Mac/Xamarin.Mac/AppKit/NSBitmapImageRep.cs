using System;
using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSBitmapImageRep", true)]
public class NSBitmapImageRep : NSImageRep
{
	private static IntPtr selInitForIncrementalLoad = Selector.GetHandle("initForIncrementalLoad");

	private static readonly IntPtr selBitmapDataHandle = Selector.GetHandle("bitmapData");

	private static readonly IntPtr selIsPlanarHandle = Selector.GetHandle("isPlanar");

	private static readonly IntPtr selSamplesPerPixelHandle = Selector.GetHandle("samplesPerPixel");

	private static readonly IntPtr selBitsPerPixelHandle = Selector.GetHandle("bitsPerPixel");

	private static readonly IntPtr selBytesPerRowHandle = Selector.GetHandle("bytesPerRow");

	private static readonly IntPtr selBytesPerPlaneHandle = Selector.GetHandle("bytesPerPlane");

	private static readonly IntPtr selNumberOfPlanesHandle = Selector.GetHandle("numberOfPlanes");

	private static readonly IntPtr selBitmapFormatHandle = Selector.GetHandle("bitmapFormat");

	private static readonly IntPtr selTIFFRepresentationHandle = Selector.GetHandle("TIFFRepresentation");

	private static readonly IntPtr selCGImageHandle = Selector.GetHandle("CGImage");

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	private static readonly IntPtr selInitWithFocusedViewRect_Handle = Selector.GetHandle("initWithFocusedViewRect:");

	private static readonly IntPtr selInitWithBitmapDataPlanesPixelsWidePixelsHighBitsPerSampleSamplesPerPixelHasAlphaIsPlanarColorSpaceNameBytesPerRowBitsPerPixel_Handle = Selector.GetHandle("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:");

	private static readonly IntPtr selInitWithBitmapDataPlanesPixelsWidePixelsHighBitsPerSampleSamplesPerPixelHasAlphaIsPlanarColorSpaceNameBitmapFormatBytesPerRowBitsPerPixel_Handle = Selector.GetHandle("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:");

	private static readonly IntPtr selInitWithCGImage_Handle = Selector.GetHandle("initWithCGImage:");

	private static readonly IntPtr selInitWithCIImage_Handle = Selector.GetHandle("initWithCIImage:");

	private static readonly IntPtr selImageRepsWithData_Handle = Selector.GetHandle("imageRepsWithData:");

	private static readonly IntPtr selImageRepWithData_Handle = Selector.GetHandle("imageRepWithData:");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr selGetBitmapDataPlanes_Handle = Selector.GetHandle("getBitmapDataPlanes:");

	private static readonly IntPtr selGetCompressionFactor_Handle = Selector.GetHandle("getCompression:factor:");

	private static readonly IntPtr selSetCompressionFactor_Handle = Selector.GetHandle("setCompression:factor:");

	private static readonly IntPtr selTIFFRepresentationUsingCompressionFactor_Handle = Selector.GetHandle("TIFFRepresentationUsingCompression:factor:");

	private static readonly IntPtr selTIFFRepresentationOfImageRepsInArray_Handle = Selector.GetHandle("TIFFRepresentationOfImageRepsInArray:");

	private static readonly IntPtr selTIFFRepresentationOfImageRepsInArrayUsingCompressionFactor_Handle = Selector.GetHandle("TIFFRepresentationOfImageRepsInArray:usingCompression:factor:");

	private static readonly IntPtr selLocalizedNameForTIFFCompressionType_Handle = Selector.GetHandle("localizedNameForTIFFCompressionType:");

	private static readonly IntPtr selCanBeCompressedUsing_Handle = Selector.GetHandle("canBeCompressedUsing:");

	private static readonly IntPtr selColorizeByMappingGrayToColorBlackMappingWhiteMapping_Handle = Selector.GetHandle("colorizeByMappingGray:toColor:blackMapping:whiteMapping:");

	private static readonly IntPtr selIncrementalLoadFromDataComplete_Handle = Selector.GetHandle("incrementalLoadFromData:complete:");

	private static readonly IntPtr selSetColorAtXY_Handle = Selector.GetHandle("setColor:atX:y:");

	private static readonly IntPtr selColorAtXY_Handle = Selector.GetHandle("colorAtX:y:");

	private static readonly IntPtr selBitmapImageRepByConvertingToColorSpaceRenderingIntent_Handle = Selector.GetHandle("bitmapImageRepByConvertingToColorSpace:renderingIntent:");

	private static readonly IntPtr selBitmapImageRepByRetaggingWithColorSpace_Handle = Selector.GetHandle("bitmapImageRepByRetaggingWithColorSpace:");

	private static readonly IntPtr selRepresentationUsingTypeProperties_Handle = Selector.GetHandle("representationUsingType:properties:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSBitmapImageRep");

	private object __mt_TiffRepresentation_var;

	private object __mt_ColorSpace_var;

	private static NSString _CompressionMethod;

	private static NSString _CompressionFactor;

	private static NSString _DitherTransparency;

	private static NSString _RGBColorTable;

	private static NSString _Interlaced;

	private static NSString _ColorSyncProfileData;

	private static NSString _FrameCount;

	private static NSString _CurrentFrame;

	private static NSString _CurrentFrameDuration;

	private static NSString _LoopCount;

	private static NSString _Gamma;

	private static NSString _Progressive;

	private static NSString _EXIFData;

	private static NSString _FallbackBackgroundColor;

	public override IntPtr ClassHandle => class_ptr;

	public virtual IntPtr BitmapData
	{
		[Export("bitmapData")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selBitmapDataHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBitmapDataHandle);
		}
	}

	public virtual bool IsPlanar
	{
		[Export("isPlanar")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlanarHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlanarHandle);
		}
	}

	public virtual long SamplesPerPixel
	{
		[Export("samplesPerPixel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selSamplesPerPixelHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSamplesPerPixelHandle);
		}
	}

	public virtual long BitsPerPixel
	{
		[Export("bitsPerPixel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selBitsPerPixelHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBitsPerPixelHandle);
		}
	}

	public virtual long BytesPerRow
	{
		[Export("bytesPerRow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selBytesPerRowHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBytesPerRowHandle);
		}
	}

	public virtual long BytesPerPlane
	{
		[Export("bytesPerPlane")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selBytesPerPlaneHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBytesPerPlaneHandle);
		}
	}

	public virtual long Planes
	{
		[Export("numberOfPlanes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfPlanesHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfPlanesHandle);
		}
	}

	public virtual NSBitmapFormat BitmapFormat
	{
		[Export("bitmapFormat")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBitmapFormat)Messaging.UInt64_objc_msgSend(base.Handle, selBitmapFormatHandle);
			}
			return (NSBitmapFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBitmapFormatHandle);
		}
	}

	public virtual NSData TiffRepresentation
	{
		[Export("TIFFRepresentation")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSData)(__mt_TiffRepresentation_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTIFFRepresentationHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTIFFRepresentationHandle)))));
		}
	}

	public new virtual CGImage CGImage
	{
		[Export("CGImage")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return new CGImage(Messaging.IntPtr_objc_msgSend(base.Handle, selCGImageHandle));
			}
			return new CGImage(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGImageHandle));
		}
	}

	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_ColorSpace_var = ((!IsDirectBinding) ? ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle))) : ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle)))));
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

	private NSBitmapImageRep(NSObjectFlag a, NSObjectFlag b)
		: base(a)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, selInitForIncrementalLoad);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitForIncrementalLoad);
		}
	}

	public static NSBitmapImageRep IncrementalLoader()
	{
		return new NSBitmapImageRep(NSObjectFlag.Empty, NSObjectFlag.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSBitmapImageRep(NSCoder coder)
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
	public NSBitmapImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSBitmapImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFocusedViewRect:")]
	public NSBitmapImageRep(CGRect rect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFocusedViewRect_Handle, rect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFocusedViewRect_Handle, rect);
		}
	}

	[Export("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bytesPerRow:bitsPerPixel:")]
	public NSBitmapImageRep(IntPtr planes, long width, long height, long bps, long spp, bool alpha, bool isPlanar, string colorSpaceName, long rBytes, long pBits)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (colorSpaceName == null)
		{
			throw new ArgumentNullException("colorSpaceName");
		}
		IntPtr arg = NSString.CreateNative(colorSpaceName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Int64_Int64_Int64_Int64_bool_bool_IntPtr_Int64_Int64(base.Handle, selInitWithBitmapDataPlanesPixelsWidePixelsHighBitsPerSampleSamplesPerPixelHasAlphaIsPlanarColorSpaceNameBytesPerRowBitsPerPixel_Handle, planes, width, height, bps, spp, alpha, isPlanar, arg, rBytes, pBits);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64_Int64_Int64_bool_bool_IntPtr_Int64_Int64(base.SuperHandle, selInitWithBitmapDataPlanesPixelsWidePixelsHighBitsPerSampleSamplesPerPixelHasAlphaIsPlanarColorSpaceNameBytesPerRowBitsPerPixel_Handle, planes, width, height, bps, spp, alpha, isPlanar, arg, rBytes, pBits);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:")]
	public NSBitmapImageRep(IntPtr planes, long width, long height, long bps, long spp, bool alpha, bool isPlanar, string colorSpaceName, NSBitmapFormat bitmapFormat, long rBytes, long pBits)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (colorSpaceName == null)
		{
			throw new ArgumentNullException("colorSpaceName");
		}
		IntPtr arg = NSString.CreateNative(colorSpaceName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Int64_Int64_Int64_Int64_bool_bool_IntPtr_UInt64_Int64_Int64(base.Handle, selInitWithBitmapDataPlanesPixelsWidePixelsHighBitsPerSampleSamplesPerPixelHasAlphaIsPlanarColorSpaceNameBitmapFormatBytesPerRowBitsPerPixel_Handle, planes, width, height, bps, spp, alpha, isPlanar, arg, (ulong)bitmapFormat, rBytes, pBits);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64_Int64_Int64_bool_bool_IntPtr_UInt64_Int64_Int64(base.SuperHandle, selInitWithBitmapDataPlanesPixelsWidePixelsHighBitsPerSampleSamplesPerPixelHasAlphaIsPlanarColorSpaceNameBitmapFormatBytesPerRowBitsPerPixel_Handle, planes, width, height, bps, spp, alpha, isPlanar, arg, (ulong)bitmapFormat, rBytes, pBits);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithCGImage:")]
	public NSBitmapImageRep(CGImage cgImage)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGImage_Handle, cgImage.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGImage_Handle, cgImage.Handle);
		}
	}

	[Export("initWithCIImage:")]
	public NSBitmapImageRep(CIImage ciImage)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (ciImage == null)
		{
			throw new ArgumentNullException("ciImage");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCIImage_Handle, ciImage.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCIImage_Handle, ciImage.Handle);
		}
	}

	[Export("imageRepsWithData:")]
	public static NSImageRep[] ImageRepsWithData(NSData data)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepsWithData_Handle, data.Handle));
	}

	[Export("imageRepWithData:")]
	public static NSImageRep ImageRepFromData(NSData data)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return (NSImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithData_Handle, data.Handle));
	}

	[Export("initWithData:")]
	public NSBitmapImageRep(NSData data)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle);
		}
	}

	[Export("getBitmapDataPlanes:")]
	public virtual void GetBitmapDataPlanes(IntPtr data)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetBitmapDataPlanes_Handle, data);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetBitmapDataPlanes_Handle, data);
		}
	}

	[Export("getCompression:factor:")]
	public virtual void GetCompressionFactor(out NSTiffCompression compression, out double factor)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_NSTiffCompression_out_Double(base.Handle, selGetCompressionFactor_Handle, out compression, out factor);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_NSTiffCompression_out_Double(base.SuperHandle, selGetCompressionFactor_Handle, out compression, out factor);
		}
	}

	[Export("setCompression:factor:")]
	public virtual void SetCompressionFactor(NSTiffCompression compression, double factor)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_Double(base.Handle, selSetCompressionFactor_Handle, (ulong)compression, factor);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_Double(base.SuperHandle, selSetCompressionFactor_Handle, (ulong)compression, factor);
		}
	}

	[Export("TIFFRepresentationUsingCompression:factor:")]
	public virtual NSData TiffRepresentationUsingCompressionFactor(NSTiffCompression comp, double factor)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_Double(base.Handle, selTIFFRepresentationUsingCompressionFactor_Handle, (ulong)comp, factor));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_Double(base.SuperHandle, selTIFFRepresentationUsingCompressionFactor_Handle, (ulong)comp, factor));
	}

	[Export("TIFFRepresentationOfImageRepsInArray:")]
	public static NSData ImagesAsTiff(NSImageRep[] imageReps)
	{
		NSApplication.EnsureUIThread();
		if (imageReps == null)
		{
			throw new ArgumentNullException("imageReps");
		}
		NSArray nSArray = NSArray.FromNSObjects(imageReps);
		NSData result = (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTIFFRepresentationOfImageRepsInArray_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("TIFFRepresentationOfImageRepsInArray:usingCompression:factor:")]
	public static NSData ImagesAsTiff(NSImageRep[] imageReps, NSTiffCompression comp, double factor)
	{
		NSApplication.EnsureUIThread();
		if (imageReps == null)
		{
			throw new ArgumentNullException("imageReps");
		}
		NSArray nSArray = NSArray.FromNSObjects(imageReps);
		NSData result = (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_Double(class_ptr, selTIFFRepresentationOfImageRepsInArrayUsingCompressionFactor_Handle, nSArray.Handle, (ulong)comp, factor));
		nSArray.Dispose();
		return result;
	}

	[Export("localizedNameForTIFFCompressionType:")]
	public static string LocalizedNameForTiffCompressionType(NSTiffCompression compression)
	{
		NSApplication.EnsureUIThread();
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selLocalizedNameForTIFFCompressionType_Handle, (ulong)compression));
	}

	[Export("canBeCompressedUsing:")]
	public virtual bool CanBeCompressedUsing(NSTiffCompression compression)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt64(base.Handle, selCanBeCompressedUsing_Handle, (ulong)compression);
		}
		return Messaging.bool_objc_msgSendSuper_UInt64(base.SuperHandle, selCanBeCompressedUsing_Handle, (ulong)compression);
	}

	[Export("colorizeByMappingGray:toColor:blackMapping:whiteMapping:")]
	public virtual void Colorize(double midPoint, NSColor midPointColor, NSColor shadowColor, NSColor lightColor)
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_IntPtr_IntPtr_IntPtr(base.Handle, selColorizeByMappingGrayToColorBlackMappingWhiteMapping_Handle, midPoint, midPointColor.Handle, shadowColor.Handle, lightColor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_IntPtr_IntPtr_IntPtr(base.SuperHandle, selColorizeByMappingGrayToColorBlackMappingWhiteMapping_Handle, midPoint, midPointColor.Handle, shadowColor.Handle, lightColor.Handle);
		}
	}

	[Export("incrementalLoadFromData:complete:")]
	public virtual long IncrementalLoad(NSData data, bool complete)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr_bool(base.Handle, selIncrementalLoadFromDataComplete_Handle, data.Handle, complete);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selIncrementalLoadFromDataComplete_Handle, data.Handle, complete);
	}

	[Export("setColor:atX:y:")]
	public virtual void SetColorAt(NSColor color, long x, long y)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_Int64(base.Handle, selSetColorAtXY_Handle, color.Handle, x, y);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_Int64(base.SuperHandle, selSetColorAtXY_Handle, color.Handle, x, y);
		}
	}

	[Export("colorAtX:y:")]
	public virtual NSColor ColorAt(long x, long y)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_Int64(base.Handle, selColorAtXY_Handle, x, y));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selColorAtXY_Handle, x, y));
	}

	[Export("bitmapImageRepByConvertingToColorSpace:renderingIntent:")]
	public virtual NSBitmapImageRep ConvertingToColorSpace(NSColorSpace targetSpace, NSColorRenderingIntent renderingIntent)
	{
		NSApplication.EnsureUIThread();
		if (targetSpace == null)
		{
			throw new ArgumentNullException("targetSpace");
		}
		if (IsDirectBinding)
		{
			return (NSBitmapImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Int64(base.Handle, selBitmapImageRepByConvertingToColorSpaceRenderingIntent_Handle, targetSpace.Handle, (long)renderingIntent));
		}
		return (NSBitmapImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selBitmapImageRepByConvertingToColorSpaceRenderingIntent_Handle, targetSpace.Handle, (long)renderingIntent));
	}

	[Export("bitmapImageRepByRetaggingWithColorSpace:")]
	public virtual NSBitmapImageRep RetaggedWithColorSpace(NSColorSpace newSpace)
	{
		NSApplication.EnsureUIThread();
		if (newSpace == null)
		{
			throw new ArgumentNullException("newSpace");
		}
		if (IsDirectBinding)
		{
			return (NSBitmapImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selBitmapImageRepByRetaggingWithColorSpace_Handle, newSpace.Handle));
		}
		return (NSBitmapImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selBitmapImageRepByRetaggingWithColorSpace_Handle, newSpace.Handle));
	}

	[Export("representationUsingType:properties:")]
	public virtual NSData RepresentationUsingTypeProperties(NSBitmapImageFileType storageType, NSDictionary properties)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selRepresentationUsingTypeProperties_Handle, (ulong)storageType, properties?.Handle ?? IntPtr.Zero));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selRepresentationUsingTypeProperties_Handle, (ulong)storageType, properties?.Handle ?? IntPtr.Zero));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TiffRepresentation_var = null;
			__mt_ColorSpace_var = null;
		}
	}
}
