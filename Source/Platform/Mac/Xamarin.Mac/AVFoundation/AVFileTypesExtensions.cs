using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVFileTypesExtensions
{
	private static IntPtr[] values = new IntPtr[21];

	[Field("AVFileTypeQuickTimeMovie", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeQuickTimeMovie
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeQuickTimeMovie", storage);
			}
		}
	}

	[Field("AVFileTypeMPEG4", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeMPEG4
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeMPEG4", storage);
			}
		}
	}

	[Field("AVFileTypeAppleM4V", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeAppleM4V
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeAppleM4V", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("AVFileType3GPP", "AVFoundation")]
	internal unsafe static IntPtr AVFileType3GPP
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileType3GPP", storage);
			}
		}
	}

	[Field("AVFileTypeAppleM4A", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeAppleM4A
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeAppleM4A", storage);
			}
		}
	}

	[Field("AVFileTypeCoreAudioFormat", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeCoreAudioFormat
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeCoreAudioFormat", storage);
			}
		}
	}

	[Field("AVFileTypeWAVE", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeWAVE
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeWAVE", storage);
			}
		}
	}

	[Field("AVFileTypeAIFF", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeAIFF
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeAIFF", storage);
			}
		}
	}

	[Field("AVFileTypeAIFC", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeAIFC
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeAIFC", storage);
			}
		}
	}

	[Field("AVFileTypeAMR", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeAMR
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeAMR", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("AVFileType3GPP2", "AVFoundation")]
	internal unsafe static IntPtr AVFileType3GPP2
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileType3GPP2", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Field("AVFileTypeMPEGLayer3", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeMPEGLayer3
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeMPEGLayer3", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Field("AVFileTypeSunAU", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeSunAU
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeSunAU", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Field("AVFileTypeAC3", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeAC3
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeAC3", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Field("AVFileTypeEnhancedAC3", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeEnhancedAC3
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeEnhancedAC3", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVFileTypeJPEG", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeJPEG
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeJPEG", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVFileTypeDNG", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeDNG
	{
		get
		{
			fixed (IntPtr* storage = &values[16])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeDNG", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVFileTypeHEIC", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeHEIC
	{
		get
		{
			fixed (IntPtr* storage = &values[17])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeHEIC", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVFileTypeAVCI", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeAVCI
	{
		get
		{
			fixed (IntPtr* storage = &values[18])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeAVCI", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVFileTypeHEIF", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeHEIF
	{
		get
		{
			fixed (IntPtr* storage = &values[19])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeHEIF", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("AVFileTypeTIFF", "AVFoundation")]
	internal unsafe static IntPtr AVFileTypeTIFF
	{
		get
		{
			fixed (IntPtr* storage = &values[20])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVFileTypeTIFF", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVFileTypes self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = AVFileTypeQuickTimeMovie;
			break;
		case 1:
			ptr = AVFileTypeMPEG4;
			break;
		case 2:
			ptr = AVFileTypeAppleM4V;
			break;
		case 3:
			ptr = AVFileType3GPP;
			break;
		case 4:
			ptr = AVFileTypeAppleM4A;
			break;
		case 5:
			ptr = AVFileTypeCoreAudioFormat;
			break;
		case 6:
			ptr = AVFileTypeWAVE;
			break;
		case 7:
			ptr = AVFileTypeAIFF;
			break;
		case 8:
			ptr = AVFileTypeAIFC;
			break;
		case 9:
			ptr = AVFileTypeAMR;
			break;
		case 10:
			ptr = AVFileType3GPP2;
			break;
		case 11:
			ptr = AVFileTypeMPEGLayer3;
			break;
		case 12:
			ptr = AVFileTypeSunAU;
			break;
		case 13:
			ptr = AVFileTypeAC3;
			break;
		case 14:
			ptr = AVFileTypeEnhancedAC3;
			break;
		case 15:
			ptr = AVFileTypeJPEG;
			break;
		case 16:
			ptr = AVFileTypeDNG;
			break;
		case 17:
			ptr = AVFileTypeHEIC;
			break;
		case 18:
			ptr = AVFileTypeAVCI;
			break;
		case 19:
			ptr = AVFileTypeHEIF;
			break;
		case 20:
			ptr = AVFileTypeTIFF;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVFileTypes GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(AVFileTypeQuickTimeMovie))
		{
			return AVFileTypes.QuickTimeMovie;
		}
		if (constant.IsEqualTo(AVFileTypeMPEG4))
		{
			return AVFileTypes.Mpeg4;
		}
		if (constant.IsEqualTo(AVFileTypeAppleM4V))
		{
			return AVFileTypes.AppleM4V;
		}
		if (constant.IsEqualTo(AVFileType3GPP))
		{
			return AVFileTypes.ThreeGpp;
		}
		if (constant.IsEqualTo(AVFileTypeAppleM4A))
		{
			return AVFileTypes.AppleM4a;
		}
		if (constant.IsEqualTo(AVFileTypeCoreAudioFormat))
		{
			return AVFileTypes.CoreAudioFormat;
		}
		if (constant.IsEqualTo(AVFileTypeWAVE))
		{
			return AVFileTypes.Wave;
		}
		if (constant.IsEqualTo(AVFileTypeAIFF))
		{
			return AVFileTypes.Aiff;
		}
		if (constant.IsEqualTo(AVFileTypeAIFC))
		{
			return AVFileTypes.Aifc;
		}
		if (constant.IsEqualTo(AVFileTypeAMR))
		{
			return AVFileTypes.Amr;
		}
		if (constant.IsEqualTo(AVFileType3GPP2))
		{
			return AVFileTypes.ThreeGpp2;
		}
		if (constant.IsEqualTo(AVFileTypeMPEGLayer3))
		{
			return AVFileTypes.MpegLayer3;
		}
		if (constant.IsEqualTo(AVFileTypeSunAU))
		{
			return AVFileTypes.SunAU;
		}
		if (constant.IsEqualTo(AVFileTypeAC3))
		{
			return AVFileTypes.AC3;
		}
		if (constant.IsEqualTo(AVFileTypeEnhancedAC3))
		{
			return AVFileTypes.EnhancedAC3;
		}
		if (constant.IsEqualTo(AVFileTypeJPEG))
		{
			return AVFileTypes.Jpeg;
		}
		if (constant.IsEqualTo(AVFileTypeDNG))
		{
			return AVFileTypes.Dng;
		}
		if (constant.IsEqualTo(AVFileTypeHEIC))
		{
			return AVFileTypes.Heic;
		}
		if (constant.IsEqualTo(AVFileTypeAVCI))
		{
			return AVFileTypes.Avci;
		}
		if (constant.IsEqualTo(AVFileTypeHEIF))
		{
			return AVFileTypes.Heif;
		}
		if (constant.IsEqualTo(AVFileTypeTIFF))
		{
			return AVFileTypes.Tiff;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
