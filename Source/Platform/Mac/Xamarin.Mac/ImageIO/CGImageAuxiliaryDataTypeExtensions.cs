using System;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CGImageAuxiliaryDataTypeExtensions
{
	private static IntPtr[] values = new IntPtr[6];

	[Field("kCGImageAuxiliaryDataTypeDepth", "ImageIO")]
	internal unsafe static IntPtr kCGImageAuxiliaryDataTypeDepth
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeDepth", storage);
			}
		}
	}

	[Field("kCGImageAuxiliaryDataTypeDisparity", "ImageIO")]
	internal unsafe static IntPtr kCGImageAuxiliaryDataTypeDisparity
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeDisparity", storage);
			}
		}
	}

	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Field("kCGImageAuxiliaryDataTypePortraitEffectsMatte", "ImageIO")]
	internal unsafe static IntPtr kCGImageAuxiliaryDataTypePortraitEffectsMatte
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypePortraitEffectsMatte", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Field("kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte", "ImageIO")]
	internal unsafe static IntPtr kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Field("kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte", "ImageIO")]
	internal unsafe static IntPtr kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Field("kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte", "ImageIO")]
	internal unsafe static IntPtr kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.ImageIO.Handle, "kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte", storage);
			}
		}
	}

	public static NSString? GetConstant(this CGImageAuxiliaryDataType self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kCGImageAuxiliaryDataTypeDepth;
			break;
		case 1:
			zero = kCGImageAuxiliaryDataTypeDisparity;
			break;
		case 2:
			zero = kCGImageAuxiliaryDataTypePortraitEffectsMatte;
			break;
		case 3:
			zero = kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte;
			break;
		case 4:
			zero = kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte;
			break;
		case 5:
			zero = kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CGImageAuxiliaryDataType GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kCGImageAuxiliaryDataTypeDepth))
		{
			return CGImageAuxiliaryDataType.Depth;
		}
		if (constant.IsEqualTo(kCGImageAuxiliaryDataTypeDisparity))
		{
			return CGImageAuxiliaryDataType.Disparity;
		}
		if (constant.IsEqualTo(kCGImageAuxiliaryDataTypePortraitEffectsMatte))
		{
			return CGImageAuxiliaryDataType.PortraitEffectsMatte;
		}
		if (constant.IsEqualTo(kCGImageAuxiliaryDataTypeSemanticSegmentationHairMatte))
		{
			return CGImageAuxiliaryDataType.SemanticSegmentationHairMatte;
		}
		if (constant.IsEqualTo(kCGImageAuxiliaryDataTypeSemanticSegmentationSkinMatte))
		{
			return CGImageAuxiliaryDataType.SemanticSegmentationSkinMatte;
		}
		if (constant.IsEqualTo(kCGImageAuxiliaryDataTypeSemanticSegmentationTeethMatte))
		{
			return CGImageAuxiliaryDataType.SemanticSegmentationTeethMatte;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
