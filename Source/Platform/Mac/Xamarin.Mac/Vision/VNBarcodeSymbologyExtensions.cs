using System;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class VNBarcodeSymbologyExtensions
{
	private static IntPtr[] values = new IntPtr[17];

	[Field("VNBarcodeSymbologyAztec", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyAztec
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyAztec", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyCode39", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyCode39
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyCode39", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyCode39Checksum", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyCode39Checksum
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyCode39Checksum", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyCode39FullASCII", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyCode39FullASCII
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyCode39FullASCII", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyCode39FullASCIIChecksum", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyCode39FullASCIIChecksum
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyCode39FullASCIIChecksum", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyCode93", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyCode93
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyCode93", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyCode93i", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyCode93i
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyCode93i", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyCode128", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyCode128
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyCode128", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyDataMatrix", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyDataMatrix
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyDataMatrix", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyEAN8", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyEAN8
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyEAN8", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyEAN13", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyEAN13
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyEAN13", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyI2of5", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyI2of5
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyI2of5", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyI2of5Checksum", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyI2of5Checksum
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyI2of5Checksum", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyITF14", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyITF14
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyITF14", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyPDF417", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyPDF417
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyPDF417", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyQR", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyQR
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyQR", storage);
			}
		}
	}

	[Field("VNBarcodeSymbologyUPCE", "Vision")]
	internal unsafe static IntPtr VNBarcodeSymbologyUPCE
	{
		get
		{
			fixed (IntPtr* storage = &values[16])
			{
				return Dlfcn.CachePointer(Libraries.Vision.Handle, "VNBarcodeSymbologyUPCE", storage);
			}
		}
	}

	public static NSString[] GetConstants(this VNBarcodeSymbology[] self)
	{
		if (self == null)
		{
			throw new ArgumentNullException("self");
		}
		NSString[] array = new NSString[self.Length];
		for (int i = 0; i < self.Length; i++)
		{
			array[i] = self[i].GetConstant();
		}
		return array;
	}

	public static VNBarcodeSymbology[] GetValues(NSString[] constants)
	{
		if (constants == null)
		{
			throw new ArgumentNullException("constants");
		}
		VNBarcodeSymbology[] array = new VNBarcodeSymbology[constants.Length];
		for (int i = 0; i < constants.Length; i++)
		{
			array[i] = GetValue(constants[i]);
		}
		return array;
	}

	public static NSString? GetConstant(this VNBarcodeSymbology self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = VNBarcodeSymbologyAztec;
			break;
		case 1:
			ptr = VNBarcodeSymbologyCode39;
			break;
		case 2:
			ptr = VNBarcodeSymbologyCode39Checksum;
			break;
		case 3:
			ptr = VNBarcodeSymbologyCode39FullASCII;
			break;
		case 4:
			ptr = VNBarcodeSymbologyCode39FullASCIIChecksum;
			break;
		case 5:
			ptr = VNBarcodeSymbologyCode93;
			break;
		case 6:
			ptr = VNBarcodeSymbologyCode93i;
			break;
		case 7:
			ptr = VNBarcodeSymbologyCode128;
			break;
		case 8:
			ptr = VNBarcodeSymbologyDataMatrix;
			break;
		case 9:
			ptr = VNBarcodeSymbologyEAN8;
			break;
		case 10:
			ptr = VNBarcodeSymbologyEAN13;
			break;
		case 11:
			ptr = VNBarcodeSymbologyI2of5;
			break;
		case 12:
			ptr = VNBarcodeSymbologyI2of5Checksum;
			break;
		case 13:
			ptr = VNBarcodeSymbologyITF14;
			break;
		case 14:
			ptr = VNBarcodeSymbologyPDF417;
			break;
		case 15:
			ptr = VNBarcodeSymbologyQR;
			break;
		case 16:
			ptr = VNBarcodeSymbologyUPCE;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static VNBarcodeSymbology GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyAztec))
		{
			return VNBarcodeSymbology.Aztec;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyCode39))
		{
			return VNBarcodeSymbology.Code39;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyCode39Checksum))
		{
			return VNBarcodeSymbology.Code39Checksum;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyCode39FullASCII))
		{
			return VNBarcodeSymbology.Code39FullAscii;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyCode39FullASCIIChecksum))
		{
			return VNBarcodeSymbology.Code39FullAsciiChecksum;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyCode93))
		{
			return VNBarcodeSymbology.Code93;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyCode93i))
		{
			return VNBarcodeSymbology.Code93i;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyCode128))
		{
			return VNBarcodeSymbology.Code128;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyDataMatrix))
		{
			return VNBarcodeSymbology.DataMatrix;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyEAN8))
		{
			return VNBarcodeSymbology.Ean8;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyEAN13))
		{
			return VNBarcodeSymbology.Ean13;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyI2of5))
		{
			return VNBarcodeSymbology.I2OF5;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyI2of5Checksum))
		{
			return VNBarcodeSymbology.I2OF5Checksum;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyITF14))
		{
			return VNBarcodeSymbology.Itf14;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyPDF417))
		{
			return VNBarcodeSymbology.Pdf417;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyQR))
		{
			return VNBarcodeSymbology.QR;
		}
		if (constant.IsEqualTo(VNBarcodeSymbologyUPCE))
		{
			return VNBarcodeSymbology.Upce;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
