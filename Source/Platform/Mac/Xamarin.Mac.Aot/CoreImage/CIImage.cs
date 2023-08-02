using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIImage", true)]
public class CIImage : NSObject
{
	private static readonly IntPtr selEmptyImageHandle = Selector.GetHandle("emptyImage");

	private static readonly IntPtr selExtentHandle = Selector.GetHandle("extent");

	private static readonly IntPtr selPropertiesHandle = Selector.GetHandle("properties");

	private static readonly IntPtr selImageWithCGImage_Handle = Selector.GetHandle("imageWithCGImage:");

	private static readonly IntPtr selImageWithCGImageOptions_Handle = Selector.GetHandle("imageWithCGImage:options:");

	private static readonly IntPtr selImageWithCGLayer_Handle = Selector.GetHandle("imageWithCGLayer:");

	private static readonly IntPtr selImageWithCGLayerOptions_Handle = Selector.GetHandle("imageWithCGLayer:options:");

	private static readonly IntPtr selImageWithBitmapDataBytesPerRowSizeFormatColorSpace_Handle = Selector.GetHandle("imageWithBitmapData:bytesPerRow:size:format:colorSpace:");

	private static readonly IntPtr selImageWithTextureSizeFlippedColorSpace_Handle = Selector.GetHandle("imageWithTexture:size:flipped:colorSpace:");

	private static readonly IntPtr selImageWithContentsOfURL_Handle = Selector.GetHandle("imageWithContentsOfURL:");

	private static readonly IntPtr selImageWithContentsOfURLOptions_Handle = Selector.GetHandle("imageWithContentsOfURL:options:");

	private static readonly IntPtr selImageWithData_Handle = Selector.GetHandle("imageWithData:");

	private static readonly IntPtr selImageWithDataOptions_Handle = Selector.GetHandle("imageWithData:options:");

	private static readonly IntPtr selImageWithCVImageBuffer_Handle = Selector.GetHandle("imageWithCVImageBuffer:");

	private static readonly IntPtr selImageWithCVImageBufferOptions_Handle = Selector.GetHandle("imageWithCVImageBuffer:options:");

	private static readonly IntPtr selImageWithColor_Handle = Selector.GetHandle("imageWithColor:");

	private static readonly IntPtr selInitWithCGImage_Handle = Selector.GetHandle("initWithCGImage:");

	private static readonly IntPtr selInitWithCGImageOptions_Handle = Selector.GetHandle("initWithCGImage:options:");

	private static readonly IntPtr selInitWithCGLayer_Handle = Selector.GetHandle("initWithCGLayer:");

	private static readonly IntPtr selInitWithCGLayerOptions_Handle = Selector.GetHandle("initWithCGLayer:options:");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr selInitWithDataOptions_Handle = Selector.GetHandle("initWithData:options:");

	private static readonly IntPtr selInitWithBitmapDataBytesPerRowSizeFormatColorSpace_Handle = Selector.GetHandle("initWithBitmapData:bytesPerRow:size:format:colorSpace:");

	private static readonly IntPtr selInitWithTextureSizeFlippedColorSpace_Handle = Selector.GetHandle("initWithTexture:size:flipped:colorSpace:");

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	private static readonly IntPtr selInitWithContentsOfURLOptions_Handle = Selector.GetHandle("initWithContentsOfURL:options:");

	private static readonly IntPtr selInitWithCVImageBuffer_Handle = Selector.GetHandle("initWithCVImageBuffer:");

	private static readonly IntPtr selInitWithCVImageBufferOptions_Handle = Selector.GetHandle("initWithCVImageBuffer:options:");

	private static readonly IntPtr selInitWithColor_Handle = Selector.GetHandle("initWithColor:");

	private static readonly IntPtr selInitWithBitmapImageRep_Handle = Selector.GetHandle("initWithBitmapImageRep:");

	private static readonly IntPtr selDrawAtPointFromRectOperationFraction_Handle = Selector.GetHandle("drawAtPoint:fromRect:operation:fraction:");

	private static readonly IntPtr selDrawInRectFromRectOperationFraction_Handle = Selector.GetHandle("drawInRect:fromRect:operation:fraction:");

	private static readonly IntPtr selImageByApplyingTransform_Handle = Selector.GetHandle("imageByApplyingTransform:");

	private static readonly IntPtr selImageByCroppingToRect_Handle = Selector.GetHandle("imageByCroppingToRect:");

	private static readonly IntPtr selAutoAdjustmentFiltersHandle = Selector.GetHandle("autoAdjustmentFilters");

	private static readonly IntPtr selAutoAdjustmentFiltersWithOptions_Handle = Selector.GetHandle("autoAdjustmentFiltersWithOptions:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIImage");

	private static object __mt_EmptyImage_var_static;

	private object __mt_WeakProperties_var;

	private static NSString _AutoAdjustFeaturesKey;

	private static NSString _AutoAdjustRedEyeKey;

	private static NSString _AutoAdjustEnhanceKey;

	private static NSString _ImagePropertyOrientation;

	private static NSString _CIImageColorSpaceKey;

	private static NSString _CIImagePropertiesKey;

	public override IntPtr ClassHandle => class_ptr;

	public static CIImage EmptyImage
	{
		[Export("emptyImage")]
		get
		{
			return (CIImage)(__mt_EmptyImage_var_static = (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selEmptyImageHandle)));
		}
	}

	public virtual CGRect Extent
	{
		[Export("extent")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtentHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtentHandle);
			}
			return retval;
		}
	}

	[Since(5, 0)]
	internal virtual NSDictionary WeakProperties
	{
		[Export("properties")]
		get
		{
			return (NSDictionary)(__mt_WeakProperties_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesHandle)))));
		}
	}

	[Since(5, 0)]
	public CGImageProperties Properties
	{
		get
		{
			NSDictionary weakProperties = WeakProperties;
			if (weakProperties != null)
			{
				return new CGImageProperties(weakProperties);
			}
			return null;
		}
	}

	[Field("kCIFormatARGB8", "CoreImage")]
	public static long FormatARGB8 => Dlfcn.GetInt64(Libraries.CoreImage.Handle, "kCIFormatARGB8");

	[Field("kCIFormatRGBA16", "CoreImage")]
	public static long FormatRGBA16 => Dlfcn.GetInt64(Libraries.CoreImage.Handle, "kCIFormatRGBA16");

	[Field("kCIFormatRGBAf", "CoreImage")]
	public static long FormatRGBAf => Dlfcn.GetInt64(Libraries.CoreImage.Handle, "kCIFormatRGBAf");

	[Field("kCIFormatRGBAh", "CoreImage")]
	public static long FormatRGBAh => Dlfcn.GetInt64(Libraries.CoreImage.Handle, "kCIFormatRGBAh");

	[Field("kCIImageAutoAdjustFeatures", "CoreImage")]
	[MountainLion]
	internal static NSString AutoAdjustFeaturesKey
	{
		[MountainLion]
		get
		{
			if (_AutoAdjustFeaturesKey == null)
			{
				_AutoAdjustFeaturesKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAutoAdjustFeatures");
			}
			return _AutoAdjustFeaturesKey;
		}
	}

	[Field("kCIImageAutoAdjustRedEye", "CoreImage")]
	[MountainLion]
	internal static NSString AutoAdjustRedEyeKey
	{
		[MountainLion]
		get
		{
			if (_AutoAdjustRedEyeKey == null)
			{
				_AutoAdjustRedEyeKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAutoAdjustRedEye");
			}
			return _AutoAdjustRedEyeKey;
		}
	}

	[Field("kCIImageAutoAdjustEnhance", "CoreImage")]
	[MountainLion]
	internal static NSString AutoAdjustEnhanceKey
	{
		[MountainLion]
		get
		{
			if (_AutoAdjustEnhanceKey == null)
			{
				_AutoAdjustEnhanceKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAutoAdjustEnhance");
			}
			return _AutoAdjustEnhanceKey;
		}
	}

	[Field("kCGImagePropertyOrientation", "ImageIO")]
	internal static NSString ImagePropertyOrientation
	{
		get
		{
			if (_ImagePropertyOrientation == null)
			{
				_ImagePropertyOrientation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyOrientation");
			}
			return _ImagePropertyOrientation;
		}
	}

	[Field("kCIImageColorSpace", "CoreImage")]
	internal static NSString CIImageColorSpaceKey
	{
		get
		{
			if (_CIImageColorSpaceKey == null)
			{
				_CIImageColorSpaceKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageColorSpace");
			}
			return _CIImageColorSpaceKey;
		}
	}

	[Field("kCIImageProperties", "CoreImage")]
	[MountainLion]
	internal static NSString CIImagePropertiesKey
	{
		[MountainLion]
		get
		{
			if (_CIImagePropertiesKey == null)
			{
				_CIImagePropertiesKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageProperties");
			}
			return _CIImagePropertiesKey;
		}
	}

	private static CIFilter[] WrapFilters(NSArray filters)
	{
		if (filters == null)
		{
			return new CIFilter[0];
		}
		ulong count = filters.Count;
		if (count == 0L)
		{
			return new CIFilter[0];
		}
		CIFilter[] array = new CIFilter[count];
		for (ulong num = 0uL; num < count; num++)
		{
			IntPtr filterHandle = filters.ValueAt(num);
			string filterName = CIFilter.GetFilterName(filterHandle);
			array[num] = CIFilter.FromName(filterName, filterHandle);
		}
		return array;
	}

	public static CIImage FromCGImage(CGImage image, CGColorSpace colorSpace)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		using NSArray objects = NSArray.FromIntPtrs(new IntPtr[1] { colorSpace.Handle });
		using NSArray keys = NSArray.FromIntPtrs(new IntPtr[1] { CIImageColorSpaceKey.Handle });
		using NSDictionary d = NSDictionary.FromObjectsAndKeysInternal(objects, keys);
		return FromCGImage(image, d);
	}

	public CIFilter[] GetAutoAdjustmentFilters()
	{
		return WrapFilters(_GetAutoAdjustmentFilters());
	}

	public CIFilter[] GetAutoAdjustmentFilters(CIAutoAdjustmentFilterOptions options)
	{
		if (options == null)
		{
			return GetAutoAdjustmentFilters();
		}
		NSDictionary nSDictionary = options.ToDictionary();
		if (nSDictionary == null)
		{
			return GetAutoAdjustmentFilters();
		}
		return WrapFilters(_GetAutoAdjustmentFilters(nSDictionary));
	}

	public static implicit operator CIImage(CGImage image)
	{
		return FromCGImage(image);
	}

	internal static long CIFormatToInt(CIFormat format)
	{
		return format switch
		{
			CIFormat.ARGB8 => FormatARGB8, 
			CIFormat.RGBAh => FormatRGBAh, 
			CIFormat.RGBA16 => FormatRGBA16, 
			CIFormat.RGBAf => FormatRGBAf, 
			_ => throw new ArgumentOutOfRangeException("format"), 
		};
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIImage(NSCoder coder)
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
	public CIImage(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIImage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("imageWithCGImage:")]
	public static CIImage FromCGImage(CGImage image)
	{
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithCGImage_Handle, image.Handle));
	}

	[Export("imageWithCGImage:options:")]
	public static CIImage FromCGImage(CGImage image, NSDictionary d)
	{
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithCGImageOptions_Handle, image.Handle, d?.Handle ?? IntPtr.Zero));
	}

	public static CIImage FromCGImage(CGImage image, CIImageInitializationOptionsWithMetadata options)
	{
		return FromCGImage(image, options?.Dictionary);
	}

	[Export("imageWithCGLayer:")]
	public static CIImage FromLayer(CGLayer layer)
	{
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithCGLayer_Handle, layer.Handle));
	}

	[Export("imageWithCGLayer:options:")]
	public static CIImage FromLayer(CGLayer layer, NSDictionary options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithCGLayerOptions_Handle, layer.Handle, options.Handle));
	}

	[Export("imageWithBitmapData:bytesPerRow:size:format:colorSpace:")]
	public static CIImage FromData(NSData bitmapData, long bytesPerRow, CGSize size, long pixelFormat, CGColorSpace colorSpace)
	{
		if (bitmapData == null)
		{
			throw new ArgumentNullException("bitmapData");
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_CGSize_Int64_IntPtr(class_ptr, selImageWithBitmapDataBytesPerRowSizeFormatColorSpace_Handle, bitmapData.Handle, bytesPerRow, size, pixelFormat, colorSpace?.Handle ?? IntPtr.Zero));
	}

	[Export("imageWithTexture:size:flipped:colorSpace:")]
	public static CIImage ImageWithTexture(ulong glTextureName, CGSize size, bool flipped, CGColorSpace colorspace)
	{
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_CGSize_bool_IntPtr(class_ptr, selImageWithTextureSizeFlippedColorSpace_Handle, glTextureName, size, flipped, colorspace.Handle));
	}

	[Export("imageWithContentsOfURL:")]
	public static CIImage FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithContentsOfURL_Handle, url.Handle));
	}

	[Export("imageWithContentsOfURL:options:")]
	public static CIImage FromUrl(NSUrl url, NSDictionary d)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithContentsOfURLOptions_Handle, url.Handle, d?.Handle ?? IntPtr.Zero));
	}

	public static CIImage FromUrl(NSUrl url, CIImageInitializationOptions options)
	{
		return FromUrl(url, options?.Dictionary);
	}

	[Export("imageWithData:")]
	public static CIImage FromData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithData_Handle, data.Handle));
	}

	[Export("imageWithData:options:")]
	public static CIImage FromData(NSData data, NSDictionary d)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithDataOptions_Handle, data.Handle, d?.Handle ?? IntPtr.Zero));
	}

	public static CIImage FromData(NSData data, CIImageInitializationOptionsWithMetadata options)
	{
		return FromData(data, options?.Dictionary);
	}

	[Export("imageWithCVImageBuffer:")]
	public static CIImage FromImageBuffer(CVImageBuffer imageBuffer)
	{
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithCVImageBuffer_Handle, imageBuffer.Handle));
	}

	[Export("imageWithCVImageBuffer:options:")]
	public static CIImage FromImageBuffer(CVImageBuffer imageBuffer, NSDictionary dict)
	{
		if (dict == null)
		{
			throw new ArgumentNullException("dict");
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithCVImageBufferOptions_Handle, imageBuffer.Handle, dict.Handle));
	}

	[Export("imageWithColor:")]
	public static CIImage ImageWithColor(CIColor color)
	{
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithColor_Handle, color.Handle));
	}

	[Export("initWithCGImage:")]
	public CIImage(CGImage image)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGImage_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGImage_Handle, image.Handle);
		}
	}

	[Export("initWithCGImage:options:")]
	public CIImage(CGImage image, NSDictionary d)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCGImageOptions_Handle, image.Handle, d?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCGImageOptions_Handle, image.Handle, d?.Handle ?? IntPtr.Zero);
		}
	}

	public CIImage(CGImage image, CIImageInitializationOptionsWithMetadata options)
		: this(image, options?.Dictionary)
	{
	}

	[Export("initWithCGLayer:")]
	public CIImage(CGLayer layer)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGLayer_Handle, layer.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGLayer_Handle, layer.Handle);
		}
	}

	[Export("initWithCGLayer:options:")]
	public CIImage(CGLayer layer, NSDictionary d)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCGLayerOptions_Handle, layer.Handle, d?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCGLayerOptions_Handle, layer.Handle, d?.Handle ?? IntPtr.Zero);
		}
	}

	public CIImage(CGLayer layer, CIImageInitializationOptions options)
		: this(layer, options?.Dictionary)
	{
	}

	[Export("initWithData:")]
	public CIImage(NSData data)
		: base(NSObjectFlag.Empty)
	{
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

	[Export("initWithData:options:")]
	public CIImage(NSData data, NSDictionary d)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDataOptions_Handle, data.Handle, d?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDataOptions_Handle, data.Handle, d?.Handle ?? IntPtr.Zero);
		}
	}

	public CIImage(NSData data, CIImageInitializationOptionsWithMetadata options)
		: this(data, options?.Dictionary)
	{
	}

	[Export("initWithBitmapData:bytesPerRow:size:format:colorSpace:")]
	public CIImage(NSData d, long bytesPerRow, CGSize size, long pixelFormat, CGColorSpace colorSpace)
		: base(NSObjectFlag.Empty)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Int64_CGSize_Int64_IntPtr(base.Handle, selInitWithBitmapDataBytesPerRowSizeFormatColorSpace_Handle, d.Handle, bytesPerRow, size, pixelFormat, colorSpace.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_CGSize_Int64_IntPtr(base.SuperHandle, selInitWithBitmapDataBytesPerRowSizeFormatColorSpace_Handle, d.Handle, bytesPerRow, size, pixelFormat, colorSpace.Handle);
		}
	}

	[Export("initWithTexture:size:flipped:colorSpace:")]
	public CIImage(long glTextureName, CGSize size, bool flipped, CGColorSpace colorSpace)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_Int64_CGSize_bool_IntPtr(base.Handle, selInitWithTextureSizeFlippedColorSpace_Handle, glTextureName, size, flipped, colorSpace.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_Int64_CGSize_bool_IntPtr(base.SuperHandle, selInitWithTextureSizeFlippedColorSpace_Handle, glTextureName, size, flipped, colorSpace.Handle);
		}
	}

	[Export("initWithContentsOfURL:")]
	public CIImage(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, url.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, url.Handle);
		}
	}

	[Export("initWithContentsOfURL:options:")]
	public CIImage(NSUrl url, NSDictionary d)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithContentsOfURLOptions_Handle, url.Handle, d?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithContentsOfURLOptions_Handle, url.Handle, d?.Handle ?? IntPtr.Zero);
		}
	}

	public CIImage(NSUrl url, CIImageInitializationOptions options)
		: this(url, options?.Dictionary)
	{
	}

	[Export("initWithCVImageBuffer:")]
	public CIImage(CVImageBuffer imageBuffer)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCVImageBuffer_Handle, imageBuffer.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCVImageBuffer_Handle, imageBuffer.Handle);
		}
	}

	[Export("initWithCVImageBuffer:options:")]
	public CIImage(CVImageBuffer imageBuffer, NSDictionary dict)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCVImageBufferOptions_Handle, imageBuffer.Handle, dict?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCVImageBufferOptions_Handle, imageBuffer.Handle, dict?.Handle ?? IntPtr.Zero);
		}
	}

	public CIImage(CVImageBuffer imageBuffer, CIImageInitializationOptions options)
		: this(imageBuffer, options?.Dictionary)
	{
	}

	[Export("initWithColor:")]
	public CIImage(CIColor color)
		: base(NSObjectFlag.Empty)
	{
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithColor_Handle, color.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithColor_Handle, color.Handle);
		}
	}

	[Export("initWithBitmapImageRep:")]
	public CIImage(NSImageRep imageRep)
		: base(NSObjectFlag.Empty)
	{
		if (imageRep == null)
		{
			throw new ArgumentNullException("imageRep");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithBitmapImageRep_Handle, imageRep.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithBitmapImageRep_Handle, imageRep.Handle);
		}
	}

	[Export("drawAtPoint:fromRect:operation:fraction:")]
	public virtual void Draw(CGPoint point, CGRect srcRect, NSCompositingOperation op, double delta)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGRect_UInt64_Double(base.Handle, selDrawAtPointFromRectOperationFraction_Handle, point, srcRect, (ulong)op, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGRect_UInt64_Double(base.SuperHandle, selDrawAtPointFromRectOperationFraction_Handle, point, srcRect, (ulong)op, delta);
		}
	}

	[Export("drawInRect:fromRect:operation:fraction:")]
	public virtual void Draw(CGRect dstRect, CGRect srcRect, NSCompositingOperation op, double delta)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_UInt64_Double(base.Handle, selDrawInRectFromRectOperationFraction_Handle, dstRect, srcRect, (ulong)op, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_UInt64_Double(base.SuperHandle, selDrawInRectFromRectOperationFraction_Handle, dstRect, srcRect, (ulong)op, delta);
		}
	}

	[Export("imageByApplyingTransform:")]
	public virtual CIImage ImageByApplyingTransform(CGAffineTransform matrix)
	{
		if (IsDirectBinding)
		{
			return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGAffineTransform(base.Handle, selImageByApplyingTransform_Handle, matrix));
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selImageByApplyingTransform_Handle, matrix));
	}

	[Export("imageByCroppingToRect:")]
	public virtual CIImage ImageByCroppingToRect(CGRect r)
	{
		if (IsDirectBinding)
		{
			return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selImageByCroppingToRect_Handle, r));
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selImageByCroppingToRect_Handle, r));
	}

	[Export("autoAdjustmentFilters")]
	internal virtual NSArray _GetAutoAdjustmentFilters()
	{
		if (IsDirectBinding)
		{
			return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAutoAdjustmentFiltersHandle));
		}
		return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutoAdjustmentFiltersHandle));
	}

	[Export("autoAdjustmentFiltersWithOptions:")]
	internal virtual NSArray _GetAutoAdjustmentFilters(NSDictionary opts)
	{
		if (opts == null)
		{
			throw new ArgumentNullException("opts");
		}
		if (IsDirectBinding)
		{
			return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAutoAdjustmentFiltersWithOptions_Handle, opts.Handle));
		}
		return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAutoAdjustmentFiltersWithOptions_Handle, opts.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakProperties_var = null;
		}
	}
}
