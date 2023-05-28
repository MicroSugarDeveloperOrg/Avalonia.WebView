using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIContext_ImageRepresentation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHEIFRepresentationOfImage_Format_ColorSpace_Options_ = "HEIFRepresentationOfImage:format:colorSpace:options:";

	private static readonly IntPtr selHEIFRepresentationOfImage_Format_ColorSpace_Options_Handle = Selector.GetHandle("HEIFRepresentationOfImage:format:colorSpace:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJPEGRepresentationOfImage_ColorSpace_Options_ = "JPEGRepresentationOfImage:colorSpace:options:";

	private static readonly IntPtr selJPEGRepresentationOfImage_ColorSpace_Options_Handle = Selector.GetHandle("JPEGRepresentationOfImage:colorSpace:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPNGRepresentationOfImage_Format_ColorSpace_Options_ = "PNGRepresentationOfImage:format:colorSpace:options:";

	private static readonly IntPtr selPNGRepresentationOfImage_Format_ColorSpace_Options_Handle = Selector.GetHandle("PNGRepresentationOfImage:format:colorSpace:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTIFFRepresentationOfImage_Format_ColorSpace_Options_ = "TIFFRepresentationOfImage:format:colorSpace:options:";

	private static readonly IntPtr selTIFFRepresentationOfImage_Format_ColorSpace_Options_Handle = Selector.GetHandle("TIFFRepresentationOfImage:format:colorSpace:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteHEIFRepresentationOfImage_ToURL_Format_ColorSpace_Options_Error_ = "writeHEIFRepresentationOfImage:toURL:format:colorSpace:options:error:";

	private static readonly IntPtr selWriteHEIFRepresentationOfImage_ToURL_Format_ColorSpace_Options_Error_Handle = Selector.GetHandle("writeHEIFRepresentationOfImage:toURL:format:colorSpace:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteJPEGRepresentationOfImage_ToURL_ColorSpace_Options_Error_ = "writeJPEGRepresentationOfImage:toURL:colorSpace:options:error:";

	private static readonly IntPtr selWriteJPEGRepresentationOfImage_ToURL_ColorSpace_Options_Error_Handle = Selector.GetHandle("writeJPEGRepresentationOfImage:toURL:colorSpace:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritePNGRepresentationOfImage_ToURL_Format_ColorSpace_Options_Error_ = "writePNGRepresentationOfImage:toURL:format:colorSpace:options:error:";

	private static readonly IntPtr selWritePNGRepresentationOfImage_ToURL_Format_ColorSpace_Options_Error_Handle = Selector.GetHandle("writePNGRepresentationOfImage:toURL:format:colorSpace:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteTIFFRepresentationOfImage_ToURL_Format_ColorSpace_Options_Error_ = "writeTIFFRepresentationOfImage:toURL:format:colorSpace:options:error:";

	private static readonly IntPtr selWriteTIFFRepresentationOfImage_ToURL_Format_ColorSpace_Options_Error_Handle = Selector.GetHandle("writeTIFFRepresentationOfImage:toURL:format:colorSpace:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("CIContext");

	[Export("HEIFRepresentationOfImage:format:colorSpace:options:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetHeifRepresentation(this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, NSDictionary options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr(This.Handle, selHEIFRepresentationOfImage_Format_ColorSpace_Options_Handle, image.Handle, (int)format, colorSpace.Handle, options.Handle));
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetHeifRepresentation(this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options)
	{
		return This.GetHeifRepresentation(image, format, colorSpace, options.GetDictionary());
	}

	[Export("JPEGRepresentationOfImage:colorSpace:options:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetJpegRepresentation(this CIContext This, CIImage image, CGColorSpace colorSpace, NSDictionary options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, selJPEGRepresentationOfImage_ColorSpace_Options_Handle, image.Handle, colorSpace.Handle, options.Handle));
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetJpegRepresentation(this CIContext This, CIImage image, CGColorSpace colorSpace, CIImageRepresentationOptions options)
	{
		return This.GetJpegRepresentation(image, colorSpace, options.GetDictionary());
	}

	[Export("PNGRepresentationOfImage:format:colorSpace:options:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetPngRepresentation(this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, NSDictionary options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr(This.Handle, selPNGRepresentationOfImage_Format_ColorSpace_Options_Handle, image.Handle, (int)format, colorSpace.Handle, options.Handle));
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetPngRepresentation(this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options)
	{
		return This.GetPngRepresentation(image, format, colorSpace, options.GetDictionary());
	}

	[Export("TIFFRepresentationOfImage:format:colorSpace:options:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetTiffRepresentation(this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, NSDictionary options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr(This.Handle, selTIFFRepresentationOfImage_Format_ColorSpace_Options_Handle, image.Handle, (int)format, colorSpace.Handle, options.Handle));
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetTiffRepresentation(this CIContext This, CIImage image, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options)
	{
		return This.GetTiffRepresentation(image, format, colorSpace, options.GetDictionary());
	}

	[Export("writeHEIFRepresentationOfImage:toURL:format:colorSpace:options:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteHeifRepresentation(this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, NSDictionary options, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_ref_IntPtr(This.Handle, selWriteHEIFRepresentationOfImage_ToURL_Format_ColorSpace_Options_Error_Handle, image.Handle, url.Handle, (int)format, colorSpace.Handle, options.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteHeifRepresentation(this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError? error)
	{
		return This.WriteHeifRepresentation(image, url, format, colorSpace, options.GetDictionary(), out error);
	}

	[Export("writeJPEGRepresentationOfImage:toURL:colorSpace:options:error:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteJpegRepresentation(this CIContext This, CIImage image, NSUrl url, CGColorSpace colorSpace, NSDictionary options, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(This.Handle, selWriteJPEGRepresentationOfImage_ToURL_ColorSpace_Options_Error_Handle, image.Handle, url.Handle, colorSpace.Handle, options.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteJpegRepresentation(this CIContext This, CIImage image, NSUrl url, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError? error)
	{
		return This.WriteJpegRepresentation(image, url, colorSpace, options.GetDictionary(), out error);
	}

	[Export("writePNGRepresentationOfImage:toURL:format:colorSpace:options:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WritePngRepresentation(this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, NSDictionary options, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_ref_IntPtr(This.Handle, selWritePNGRepresentationOfImage_ToURL_Format_ColorSpace_Options_Error_Handle, image.Handle, url.Handle, (int)format, colorSpace.Handle, options.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WritePngRepresentation(this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError? error)
	{
		return This.WritePngRepresentation(image, url, format, colorSpace, options.GetDictionary(), out error);
	}

	[Export("writeTIFFRepresentationOfImage:toURL:format:colorSpace:options:error:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteTiffRepresentation(this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, NSDictionary options, out NSError error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_ref_IntPtr(This.Handle, selWriteTIFFRepresentationOfImage_ToURL_Format_ColorSpace_Options_Error_Handle, image.Handle, url.Handle, (int)format, colorSpace.Handle, options.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteTiffRepresentation(this CIContext This, CIImage image, NSUrl url, CIFormat format, CGColorSpace colorSpace, CIImageRepresentationOptions options, out NSError error)
	{
		return This.WriteTiffRepresentation(image, url, format, colorSpace, options.GetDictionary(), out error);
	}
}
