using System;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CVImageBufferYCbCrMatrixExtensions
{
	private static IntPtr[] values = new IntPtr[6];

	[Field("kCVImageBufferYCbCrMatrix_ITU_R_709_2", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_ITU_R_709_2
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_ITU_R_709_2", storage);
			}
		}
	}

	[Field("kCVImageBufferYCbCrMatrix_ITU_R_601_4", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_ITU_R_601_4
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_ITU_R_601_4", storage);
			}
		}
	}

	[Field("kCVImageBufferYCbCrMatrix_SMPTE_240M_1995", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_SMPTE_240M_1995
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_SMPTE_240M_1995", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferYCbCrMatrix_DCI_P3", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_DCI_P3
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_DCI_P3", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferYCbCrMatrix_P3_D65", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_P3_D65
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_P3_D65", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferYCbCrMatrix_ITU_R_2020", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferYCbCrMatrix_ITU_R_2020
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrix_ITU_R_2020", storage);
			}
		}
	}

	public static NSString? GetConstant(this CVImageBufferYCbCrMatrix self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 3:
			zero = kCVImageBufferYCbCrMatrix_ITU_R_709_2;
			break;
		case 4:
			zero = kCVImageBufferYCbCrMatrix_ITU_R_601_4;
			break;
		case 5:
			zero = kCVImageBufferYCbCrMatrix_SMPTE_240M_1995;
			break;
		case 6:
			zero = kCVImageBufferYCbCrMatrix_DCI_P3;
			break;
		case 7:
			zero = kCVImageBufferYCbCrMatrix_P3_D65;
			break;
		case 8:
			zero = kCVImageBufferYCbCrMatrix_ITU_R_2020;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CVImageBufferYCbCrMatrix GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return CVImageBufferYCbCrMatrix.Unknown;
		}
		if (constant.IsEqualTo(kCVImageBufferYCbCrMatrix_ITU_R_709_2))
		{
			return CVImageBufferYCbCrMatrix.ItuR709_2;
		}
		if (constant.IsEqualTo(kCVImageBufferYCbCrMatrix_ITU_R_601_4))
		{
			return CVImageBufferYCbCrMatrix.ItuR601_4;
		}
		if (constant.IsEqualTo(kCVImageBufferYCbCrMatrix_SMPTE_240M_1995))
		{
			return CVImageBufferYCbCrMatrix.Smpte240M1995;
		}
		if (constant.IsEqualTo(kCVImageBufferYCbCrMatrix_DCI_P3))
		{
			return CVImageBufferYCbCrMatrix.DciP3;
		}
		if (constant.IsEqualTo(kCVImageBufferYCbCrMatrix_P3_D65))
		{
			return CVImageBufferYCbCrMatrix.P3D65;
		}
		if (constant.IsEqualTo(kCVImageBufferYCbCrMatrix_ITU_R_2020))
		{
			return CVImageBufferYCbCrMatrix.ItuR2020;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
