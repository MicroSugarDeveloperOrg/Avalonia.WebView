using System;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CVImageBufferColorPrimariesExtensions
{
	private static IntPtr[] values = new IntPtr[7];

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferColorPrimaries_DCI_P3", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferColorPrimaries_DCI_P3
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_DCI_P3", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferColorPrimaries_ITU_R_2020", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferColorPrimaries_ITU_R_2020
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_ITU_R_2020", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("kCVImageBufferColorPrimaries_P3_D65", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferColorPrimaries_P3_D65
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_P3_D65", storage);
			}
		}
	}

	[Field("kCVImageBufferColorPrimaries_ITU_R_709_2", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferColorPrimaries_ITU_R_709_2
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_ITU_R_709_2", storage);
			}
		}
	}

	[Field("kCVImageBufferColorPrimaries_EBU_3213", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferColorPrimaries_EBU_3213
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_EBU_3213", storage);
			}
		}
	}

	[Field("kCVImageBufferColorPrimaries_SMPTE_C", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferColorPrimaries_SMPTE_C
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_SMPTE_C", storage);
			}
		}
	}

	[Field("kCVImageBufferColorPrimaries_P22", "CoreVideo")]
	internal unsafe static IntPtr kCVImageBufferColorPrimaries_P22
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimaries_P22", storage);
			}
		}
	}

	public static NSString? GetConstant(this CVImageBufferColorPrimaries self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 3:
			zero = kCVImageBufferColorPrimaries_DCI_P3;
			break;
		case 4:
			zero = kCVImageBufferColorPrimaries_ITU_R_2020;
			break;
		case 5:
			zero = kCVImageBufferColorPrimaries_P3_D65;
			break;
		case 6:
			zero = kCVImageBufferColorPrimaries_ITU_R_709_2;
			break;
		case 7:
			zero = kCVImageBufferColorPrimaries_EBU_3213;
			break;
		case 8:
			zero = kCVImageBufferColorPrimaries_SMPTE_C;
			break;
		case 9:
			zero = kCVImageBufferColorPrimaries_P22;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CVImageBufferColorPrimaries GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return CVImageBufferColorPrimaries.Unknown;
		}
		if (constant.IsEqualTo(kCVImageBufferColorPrimaries_DCI_P3))
		{
			return CVImageBufferColorPrimaries.DciP3;
		}
		if (constant.IsEqualTo(kCVImageBufferColorPrimaries_ITU_R_2020))
		{
			return CVImageBufferColorPrimaries.ItuR2020;
		}
		if (constant.IsEqualTo(kCVImageBufferColorPrimaries_P3_D65))
		{
			return CVImageBufferColorPrimaries.P3D65;
		}
		if (constant.IsEqualTo(kCVImageBufferColorPrimaries_ITU_R_709_2))
		{
			return CVImageBufferColorPrimaries.ItuR709_2;
		}
		if (constant.IsEqualTo(kCVImageBufferColorPrimaries_EBU_3213))
		{
			return CVImageBufferColorPrimaries.Ebu3213;
		}
		if (constant.IsEqualTo(kCVImageBufferColorPrimaries_SMPTE_C))
		{
			return CVImageBufferColorPrimaries.SmpteC;
		}
		if (constant.IsEqualTo(kCVImageBufferColorPrimaries_P22))
		{
			return CVImageBufferColorPrimaries.P22;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
