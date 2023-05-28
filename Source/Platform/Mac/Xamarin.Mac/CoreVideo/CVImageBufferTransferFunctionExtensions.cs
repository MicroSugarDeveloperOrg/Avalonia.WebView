using System;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CVImageBufferTransferFunctionExtensions
{
	private static IntPtr[] values = new IntPtr[9];

	[Field("kCVImageBufferTransferFunction_ITU_R_709_2", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferTransferFunction_ITU_R_709_2
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_ITU_R_709_2", storage);
			}
		}
	}

	[Field("kCVImageBufferTransferFunction_SMPTE_240M_1995", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferTransferFunction_SMPTE_240M_1995
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_SMPTE_240M_1995", storage);
			}
		}
	}

	[Field("kCVImageBufferTransferFunction_UseGamma", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferTransferFunction_UseGamma
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_UseGamma", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferTransferFunction_ITU_R_2020", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferTransferFunction_ITU_R_2020
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_ITU_R_2020", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferTransferFunction_SMPTE_ST_428_1", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferTransferFunction_SMPTE_ST_428_1
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_SMPTE_ST_428_1", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferTransferFunction_sRGB", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferTransferFunction_sRGB
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_sRGB", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferTransferFunction_ITU_R_2100_HLG", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferTransferFunction_ITU_R_2100_HLG
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_ITU_R_2100_HLG", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferTransferFunction_Linear", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferTransferFunction_Linear
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunction_Linear", storage);
			}
		}
	}

	public static NSString? GetConstant(this CVImageBufferTransferFunction self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 3:
			zero = kCVImageBufferTransferFunction_ITU_R_709_2;
			break;
		case 4:
			zero = kCVImageBufferTransferFunction_SMPTE_240M_1995;
			break;
		case 5:
			zero = kCVImageBufferTransferFunction_UseGamma;
			break;
		case 6:
			zero = kCVImageBufferTransferFunction_ITU_R_2020;
			break;
		case 7:
			zero = kCVImageBufferTransferFunction_SMPTE_ST_428_1;
			break;
		case 8:
			zero = kCVImageBufferTransferFunction_sRGB;
			break;
		case 9:
			zero = kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ;
			break;
		case 10:
			zero = kCVImageBufferTransferFunction_ITU_R_2100_HLG;
			break;
		case 11:
			zero = kCVImageBufferTransferFunction_Linear;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CVImageBufferTransferFunction GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return CVImageBufferTransferFunction.Unknown;
		}
		if (constant.IsEqualTo(kCVImageBufferTransferFunction_ITU_R_709_2))
		{
			return CVImageBufferTransferFunction.ItuR709_2;
		}
		if (constant.IsEqualTo(kCVImageBufferTransferFunction_SMPTE_240M_1995))
		{
			return CVImageBufferTransferFunction.Smpte240M1995;
		}
		if (constant.IsEqualTo(kCVImageBufferTransferFunction_UseGamma))
		{
			return CVImageBufferTransferFunction.UseGamma;
		}
		if (constant.IsEqualTo(kCVImageBufferTransferFunction_ITU_R_2020))
		{
			return CVImageBufferTransferFunction.ItuR2020;
		}
		if (constant.IsEqualTo(kCVImageBufferTransferFunction_SMPTE_ST_428_1))
		{
			return CVImageBufferTransferFunction.SmpteST428_1;
		}
		if (constant.IsEqualTo(kCVImageBufferTransferFunction_sRGB))
		{
			return CVImageBufferTransferFunction.SRgb;
		}
		if (constant.IsEqualTo(kCVImageBufferTransferFunction_SMPTE_ST_2084_PQ))
		{
			return CVImageBufferTransferFunction.SmpteST2084PQ;
		}
		if (constant.IsEqualTo(kCVImageBufferTransferFunction_ITU_R_2100_HLG))
		{
			return CVImageBufferTransferFunction.ItuR2100Hlg;
		}
		if (constant.IsEqualTo(kCVImageBufferTransferFunction_Linear))
		{
			return CVImageBufferTransferFunction.Linear;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
