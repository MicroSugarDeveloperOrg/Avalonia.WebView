using System;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CFStringTransformExtensions
{
	private static IntPtr[] values = new IntPtr[16];

	[Field("kCFStringTransformStripCombiningMarks", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformStripCombiningMarks
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformStripCombiningMarks", storage);
			}
		}
	}

	[Field("kCFStringTransformToLatin", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformToLatin
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformToLatin", storage);
			}
		}
	}

	[Field("kCFStringTransformFullwidthHalfwidth", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformFullwidthHalfwidth
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformFullwidthHalfwidth", storage);
			}
		}
	}

	[Field("kCFStringTransformLatinKatakana", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformLatinKatakana
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformLatinKatakana", storage);
			}
		}
	}

	[Field("kCFStringTransformLatinHiragana", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformLatinHiragana
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformLatinHiragana", storage);
			}
		}
	}

	[Field("kCFStringTransformHiraganaKatakana", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformHiraganaKatakana
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformHiraganaKatakana", storage);
			}
		}
	}

	[Field("kCFStringTransformMandarinLatin", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformMandarinLatin
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformMandarinLatin", storage);
			}
		}
	}

	[Field("kCFStringTransformLatinHangul", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformLatinHangul
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformLatinHangul", storage);
			}
		}
	}

	[Field("kCFStringTransformLatinArabic", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformLatinArabic
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformLatinArabic", storage);
			}
		}
	}

	[Field("kCFStringTransformLatinHebrew", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformLatinHebrew
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformLatinHebrew", storage);
			}
		}
	}

	[Field("kCFStringTransformLatinThai", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformLatinThai
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformLatinThai", storage);
			}
		}
	}

	[Field("kCFStringTransformLatinCyrillic", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformLatinCyrillic
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformLatinCyrillic", storage);
			}
		}
	}

	[Field("kCFStringTransformLatinGreek", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformLatinGreek
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformLatinGreek", storage);
			}
		}
	}

	[Field("kCFStringTransformToXMLHex", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformToXMLHex
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformToXMLHex", storage);
			}
		}
	}

	[Field("kCFStringTransformToUnicodeName", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformToUnicodeName
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformToUnicodeName", storage);
			}
		}
	}

	[Field("kCFStringTransformStripDiacritics", "CoreFoundation")]
	internal unsafe static IntPtr kCFStringTransformStripDiacritics
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.CoreFoundation.Handle, "kCFStringTransformStripDiacritics", storage);
			}
		}
	}

	public static NSString? GetConstant(this CFStringTransform self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kCFStringTransformStripCombiningMarks;
			break;
		case 1:
			zero = kCFStringTransformToLatin;
			break;
		case 2:
			zero = kCFStringTransformFullwidthHalfwidth;
			break;
		case 3:
			zero = kCFStringTransformLatinKatakana;
			break;
		case 4:
			zero = kCFStringTransformLatinHiragana;
			break;
		case 5:
			zero = kCFStringTransformHiraganaKatakana;
			break;
		case 6:
			zero = kCFStringTransformMandarinLatin;
			break;
		case 7:
			zero = kCFStringTransformLatinHangul;
			break;
		case 8:
			zero = kCFStringTransformLatinArabic;
			break;
		case 9:
			zero = kCFStringTransformLatinHebrew;
			break;
		case 10:
			zero = kCFStringTransformLatinThai;
			break;
		case 11:
			zero = kCFStringTransformLatinCyrillic;
			break;
		case 12:
			zero = kCFStringTransformLatinGreek;
			break;
		case 13:
			zero = kCFStringTransformToXMLHex;
			break;
		case 14:
			zero = kCFStringTransformToUnicodeName;
			break;
		case 15:
			zero = kCFStringTransformStripDiacritics;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CFStringTransform GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kCFStringTransformStripCombiningMarks))
		{
			return CFStringTransform.StripCombiningMarks;
		}
		if (constant.IsEqualTo(kCFStringTransformToLatin))
		{
			return CFStringTransform.ToLatin;
		}
		if (constant.IsEqualTo(kCFStringTransformFullwidthHalfwidth))
		{
			return CFStringTransform.FullwidthHalfwidth;
		}
		if (constant.IsEqualTo(kCFStringTransformLatinKatakana))
		{
			return CFStringTransform.LatinKatakana;
		}
		if (constant.IsEqualTo(kCFStringTransformLatinHiragana))
		{
			return CFStringTransform.LatinHiragana;
		}
		if (constant.IsEqualTo(kCFStringTransformHiraganaKatakana))
		{
			return CFStringTransform.HiraganaKatakana;
		}
		if (constant.IsEqualTo(kCFStringTransformMandarinLatin))
		{
			return CFStringTransform.MandarinLatin;
		}
		if (constant.IsEqualTo(kCFStringTransformLatinHangul))
		{
			return CFStringTransform.LatinHangul;
		}
		if (constant.IsEqualTo(kCFStringTransformLatinArabic))
		{
			return CFStringTransform.LatinArabic;
		}
		if (constant.IsEqualTo(kCFStringTransformLatinHebrew))
		{
			return CFStringTransform.LatinHebrew;
		}
		if (constant.IsEqualTo(kCFStringTransformLatinThai))
		{
			return CFStringTransform.LatinThai;
		}
		if (constant.IsEqualTo(kCFStringTransformLatinCyrillic))
		{
			return CFStringTransform.LatinCyrillic;
		}
		if (constant.IsEqualTo(kCFStringTransformLatinGreek))
		{
			return CFStringTransform.LatinGreek;
		}
		if (constant.IsEqualTo(kCFStringTransformToXMLHex))
		{
			return CFStringTransform.ToXmlHex;
		}
		if (constant.IsEqualTo(kCFStringTransformToUnicodeName))
		{
			return CFStringTransform.ToUnicodeName;
		}
		if (constant.IsEqualTo(kCFStringTransformStripDiacritics))
		{
			return CFStringTransform.StripDiacritics;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
