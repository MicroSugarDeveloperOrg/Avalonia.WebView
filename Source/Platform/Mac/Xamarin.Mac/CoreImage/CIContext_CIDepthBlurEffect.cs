using System;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace CoreImage;

public static class CIContext_CIDepthBlurEffect
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthBlurEffectFilterForImage_DisparityImage_PortraitEffectsMatte_HairSemanticSegmentation_Orientation_Options_ = "depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:hairSemanticSegmentation:orientation:options:";

	private static readonly IntPtr selDepthBlurEffectFilterForImage_DisparityImage_PortraitEffectsMatte_HairSemanticSegmentation_Orientation_Options_Handle = Selector.GetHandle("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:hairSemanticSegmentation:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthBlurEffectFilterForImage_DisparityImage_PortraitEffectsMatte_Orientation_Options_ = "depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:orientation:options:";

	private static readonly IntPtr selDepthBlurEffectFilterForImage_DisparityImage_PortraitEffectsMatte_Orientation_Options_Handle = Selector.GetHandle("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:orientation:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthBlurEffectFilterForImageData_Options_ = "depthBlurEffectFilterForImageData:options:";

	private static readonly IntPtr selDepthBlurEffectFilterForImageData_Options_Handle = Selector.GetHandle("depthBlurEffectFilterForImageData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthBlurEffectFilterForImageURL_Options_ = "depthBlurEffectFilterForImageURL:options:";

	private static readonly IntPtr selDepthBlurEffectFilterForImageURL_Options_Handle = Selector.GetHandle("depthBlurEffectFilterForImageURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("CIContext");

	[Export("depthBlurEffectFilterForImageURL:options:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter? GetDepthBlurEffectFilter(this CIContext This, NSUrl url, NSDictionary? options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, selDepthBlurEffectFilterForImageURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("depthBlurEffectFilterForImageData:options:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter? GetDepthBlurEffectFilter(this CIContext This, NSData data, NSDictionary? options)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, selDepthBlurEffectFilterForImageData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:orientation:options:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter? GetDepthBlurEffectFilter(this CIContext This, CIImage image, CIImage disparityImage, CIImage? portraitEffectsMatte, CGImagePropertyOrientation orientation, NSDictionary? options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (disparityImage == null)
		{
			throw new ArgumentNullException("disparityImage");
		}
		return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int_IntPtr(This.Handle, selDepthBlurEffectFilterForImage_DisparityImage_PortraitEffectsMatte_Orientation_Options_Handle, image.Handle, disparityImage.Handle, portraitEffectsMatte?.Handle ?? IntPtr.Zero, (int)orientation, options?.Handle ?? IntPtr.Zero));
	}

	[Export("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:hairSemanticSegmentation:orientation:options:")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter? GetDepthBlurEffectFilter(this CIContext This, CIImage image, CIImage disparityImage, CIImage? portraitEffectsMatte, CIImage? hairSemanticSegmentation, CGImagePropertyOrientation orientation, NSDictionary? options)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (disparityImage == null)
		{
			throw new ArgumentNullException("disparityImage");
		}
		return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_int_IntPtr(This.Handle, selDepthBlurEffectFilterForImage_DisparityImage_PortraitEffectsMatte_HairSemanticSegmentation_Orientation_Options_Handle, image.Handle, disparityImage.Handle, portraitEffectsMatte?.Handle ?? IntPtr.Zero, hairSemanticSegmentation?.Handle ?? IntPtr.Zero, (int)orientation, options?.Handle ?? IntPtr.Zero));
	}
}
