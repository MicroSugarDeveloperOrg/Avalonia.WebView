using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class AVMetadataObjectTypeExtensions
{
	private static IntPtr[] values = new IntPtr[18];

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeFace", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeFace
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeFace", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeAztecCode", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeAztecCode
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeAztecCode", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeCode128Code", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeCode128Code
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode128Code", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeCode39Code", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeCode39Code
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode39Code", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeCode39Mod43Code", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeCode39Mod43Code
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode39Mod43Code", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeCode93Code", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeCode93Code
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode93Code", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeEAN13Code", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeEAN13Code
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeEAN13Code", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeEAN8Code", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeEAN8Code
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeEAN8Code", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypePDF417Code", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypePDF417Code
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypePDF417Code", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeQRCode", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeQRCode
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeQRCode", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeUPCECode", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeUPCECode
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeUPCECode", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeInterleaved2of5Code", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeInterleaved2of5Code
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeInterleaved2of5Code", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeITF14Code", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeITF14Code
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeITF14Code", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeDataMatrixCode", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeDataMatrixCode
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeDataMatrixCode", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeCatBody", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeCatBody
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCatBody", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeDogBody", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeDogBody
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeDogBody", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeHumanBody", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeHumanBody
	{
		get
		{
			fixed (IntPtr* storage = &values[16])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeHumanBody", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Field("AVMetadataObjectTypeSalientObject", "AVFoundation")]
	internal unsafe static IntPtr AVMetadataObjectTypeSalientObject
	{
		get
		{
			fixed (IntPtr* storage = &values[17])
			{
				return Dlfcn.CachePointer(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeSalientObject", storage);
			}
		}
	}

	public static NSString? GetConstant(this AVMetadataObjectType self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch (self)
		{
		case AVMetadataObjectType.None:
		case AVMetadataObjectType.Face:
		case AVMetadataObjectType.AztecCode:
		case AVMetadataObjectType.Face | AVMetadataObjectType.AztecCode:
		case AVMetadataObjectType.Code128Code:
		case AVMetadataObjectType.Face | AVMetadataObjectType.Code128Code:
		case AVMetadataObjectType.AztecCode | AVMetadataObjectType.Code128Code:
		case AVMetadataObjectType.Face | AVMetadataObjectType.AztecCode | AVMetadataObjectType.Code128Code:
		case AVMetadataObjectType.Code39Code:
		{
			AVMetadataObjectType num = self - 1;
			if (num <= (AVMetadataObjectType.Face | AVMetadataObjectType.AztecCode))
			{
				switch (num)
				{
				case AVMetadataObjectType.None:
					ptr = AVMetadataObjectTypeFace;
					goto end_IL_0012;
				case AVMetadataObjectType.Face:
					ptr = AVMetadataObjectTypeAztecCode;
					goto end_IL_0012;
				case AVMetadataObjectType.Face | AVMetadataObjectType.AztecCode:
					ptr = AVMetadataObjectTypeCode128Code;
					goto end_IL_0012;
				case AVMetadataObjectType.AztecCode:
					goto end_IL_0012;
				}
			}
			if (self == AVMetadataObjectType.Code39Code)
			{
				ptr = AVMetadataObjectTypeCode39Code;
			}
			break;
		}
		case AVMetadataObjectType.Code39Mod43Code:
			ptr = AVMetadataObjectTypeCode39Mod43Code;
			break;
		case AVMetadataObjectType.Code93Code:
			ptr = AVMetadataObjectTypeCode93Code;
			break;
		case AVMetadataObjectType.EAN13Code:
			ptr = AVMetadataObjectTypeEAN13Code;
			break;
		case AVMetadataObjectType.EAN8Code:
			ptr = AVMetadataObjectTypeEAN8Code;
			break;
		case AVMetadataObjectType.PDF417Code:
			ptr = AVMetadataObjectTypePDF417Code;
			break;
		case AVMetadataObjectType.QRCode:
			ptr = AVMetadataObjectTypeQRCode;
			break;
		case AVMetadataObjectType.UPCECode:
			ptr = AVMetadataObjectTypeUPCECode;
			break;
		case AVMetadataObjectType.Interleaved2of5Code:
			ptr = AVMetadataObjectTypeInterleaved2of5Code;
			break;
		case AVMetadataObjectType.ITF14Code:
			ptr = AVMetadataObjectTypeITF14Code;
			break;
		case AVMetadataObjectType.DataMatrixCode:
			ptr = AVMetadataObjectTypeDataMatrixCode;
			break;
		case AVMetadataObjectType.CatBody:
			ptr = AVMetadataObjectTypeCatBody;
			break;
		case AVMetadataObjectType.DogBody:
			ptr = AVMetadataObjectTypeDogBody;
			break;
		case AVMetadataObjectType.HumanBody:
			ptr = AVMetadataObjectTypeHumanBody;
			break;
		case AVMetadataObjectType.SalientObject:
			{
				ptr = AVMetadataObjectTypeSalientObject;
				break;
			}
			end_IL_0012:
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static AVMetadataObjectType GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return AVMetadataObjectType.None;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeFace))
		{
			return AVMetadataObjectType.Face;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeAztecCode))
		{
			return AVMetadataObjectType.AztecCode;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeCode128Code))
		{
			return AVMetadataObjectType.Code128Code;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeCode39Code))
		{
			return AVMetadataObjectType.Code39Code;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeCode39Mod43Code))
		{
			return AVMetadataObjectType.Code39Mod43Code;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeCode93Code))
		{
			return AVMetadataObjectType.Code93Code;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeEAN13Code))
		{
			return AVMetadataObjectType.EAN13Code;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeEAN8Code))
		{
			return AVMetadataObjectType.EAN8Code;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypePDF417Code))
		{
			return AVMetadataObjectType.PDF417Code;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeQRCode))
		{
			return AVMetadataObjectType.QRCode;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeUPCECode))
		{
			return AVMetadataObjectType.UPCECode;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeInterleaved2of5Code))
		{
			return AVMetadataObjectType.Interleaved2of5Code;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeITF14Code))
		{
			return AVMetadataObjectType.ITF14Code;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeDataMatrixCode))
		{
			return AVMetadataObjectType.DataMatrixCode;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeCatBody))
		{
			return AVMetadataObjectType.CatBody;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeDogBody))
		{
			return AVMetadataObjectType.DogBody;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeHumanBody))
		{
			return AVMetadataObjectType.HumanBody;
		}
		if (constant.IsEqualTo(AVMetadataObjectTypeSalientObject))
		{
			return AVMetadataObjectType.SalientObject;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
