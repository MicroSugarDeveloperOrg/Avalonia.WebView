using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NSTextListMarkerFormatsExtensions
{
	private static IntPtr[] values = new IntPtr[17];

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerBox", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerBox
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerBox", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerCheck", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerCheck
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerCheck", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerCircle", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerCircle
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerCircle", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerDiamond", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerDiamond
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerDiamond", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerDisc", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerDisc
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerDisc", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerHyphen", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerHyphen
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerHyphen", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerSquare", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerSquare
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerSquare", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerLowercaseHexadecimal", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerLowercaseHexadecimal
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerLowercaseHexadecimal", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerUppercaseHexadecimal", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerUppercaseHexadecimal
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerUppercaseHexadecimal", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerOctal", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerOctal
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerOctal", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerLowercaseAlpha", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerLowercaseAlpha
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerLowercaseAlpha", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerUppercaseAlpha", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerUppercaseAlpha
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerUppercaseAlpha", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerLowercaseLatin", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerLowercaseLatin
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerLowercaseLatin", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerUppercaseLatin", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerUppercaseLatin
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerUppercaseLatin", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerLowercaseRoman", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerLowercaseRoman
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerLowercaseRoman", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerUppercaseRoman", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerUppercaseRoman
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerUppercaseRoman", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("NSTextListMarkerDecimal", "AppKit")]
	internal unsafe static IntPtr NSTextListMarkerDecimal
	{
		get
		{
			fixed (IntPtr* storage = &values[16])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTextListMarkerDecimal", storage);
			}
		}
	}

	public static NSString? GetConstant(this NSTextListMarkerFormats self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = NSTextListMarkerBox;
			break;
		case 1:
			ptr = NSTextListMarkerCheck;
			break;
		case 2:
			ptr = NSTextListMarkerCircle;
			break;
		case 3:
			ptr = NSTextListMarkerDiamond;
			break;
		case 4:
			ptr = NSTextListMarkerDisc;
			break;
		case 5:
			ptr = NSTextListMarkerHyphen;
			break;
		case 6:
			ptr = NSTextListMarkerSquare;
			break;
		case 7:
			ptr = NSTextListMarkerLowercaseHexadecimal;
			break;
		case 8:
			ptr = NSTextListMarkerUppercaseHexadecimal;
			break;
		case 9:
			ptr = NSTextListMarkerOctal;
			break;
		case 10:
			ptr = NSTextListMarkerLowercaseAlpha;
			break;
		case 11:
			ptr = NSTextListMarkerUppercaseAlpha;
			break;
		case 12:
			ptr = NSTextListMarkerLowercaseLatin;
			break;
		case 13:
			ptr = NSTextListMarkerUppercaseLatin;
			break;
		case 14:
			ptr = NSTextListMarkerLowercaseRoman;
			break;
		case 15:
			ptr = NSTextListMarkerUppercaseRoman;
			break;
		case 16:
			ptr = NSTextListMarkerDecimal;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static NSTextListMarkerFormats GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(NSTextListMarkerBox))
		{
			return NSTextListMarkerFormats.Box;
		}
		if (constant.IsEqualTo(NSTextListMarkerCheck))
		{
			return NSTextListMarkerFormats.Check;
		}
		if (constant.IsEqualTo(NSTextListMarkerCircle))
		{
			return NSTextListMarkerFormats.Circle;
		}
		if (constant.IsEqualTo(NSTextListMarkerDiamond))
		{
			return NSTextListMarkerFormats.Diamond;
		}
		if (constant.IsEqualTo(NSTextListMarkerDisc))
		{
			return NSTextListMarkerFormats.Disc;
		}
		if (constant.IsEqualTo(NSTextListMarkerHyphen))
		{
			return NSTextListMarkerFormats.Hyphen;
		}
		if (constant.IsEqualTo(NSTextListMarkerSquare))
		{
			return NSTextListMarkerFormats.Square;
		}
		if (constant.IsEqualTo(NSTextListMarkerLowercaseHexadecimal))
		{
			return NSTextListMarkerFormats.LowercaseHexadecimal;
		}
		if (constant.IsEqualTo(NSTextListMarkerUppercaseHexadecimal))
		{
			return NSTextListMarkerFormats.UppercaseHexadecimal;
		}
		if (constant.IsEqualTo(NSTextListMarkerOctal))
		{
			return NSTextListMarkerFormats.Octal;
		}
		if (constant.IsEqualTo(NSTextListMarkerLowercaseAlpha))
		{
			return NSTextListMarkerFormats.LowercaseAlpha;
		}
		if (constant.IsEqualTo(NSTextListMarkerUppercaseAlpha))
		{
			return NSTextListMarkerFormats.UppercaseAlpha;
		}
		if (constant.IsEqualTo(NSTextListMarkerLowercaseLatin))
		{
			return NSTextListMarkerFormats.LowercaseLatin;
		}
		if (constant.IsEqualTo(NSTextListMarkerUppercaseLatin))
		{
			return NSTextListMarkerFormats.UppercaseLatin;
		}
		if (constant.IsEqualTo(NSTextListMarkerLowercaseRoman))
		{
			return NSTextListMarkerFormats.LowercaseRoman;
		}
		if (constant.IsEqualTo(NSTextListMarkerUppercaseRoman))
		{
			return NSTextListMarkerFormats.UppercaseRoman;
		}
		if (constant.IsEqualTo(NSTextListMarkerDecimal))
		{
			return NSTextListMarkerFormats.Decimal;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
