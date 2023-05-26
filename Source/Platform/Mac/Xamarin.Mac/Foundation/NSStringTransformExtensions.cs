using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation;
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NSStringTransformExtensions
{
    private static IntPtr[] values = new IntPtr[16];

    [Field("NSStringTransformLatinToKatakana", "Foundation")]
    internal unsafe static IntPtr NSStringTransformLatinToKatakana
    {
        get
        {
            fixed (IntPtr* storage = &values[0])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformLatinToKatakana", storage);
            }
        }
    }

    [Field("NSStringTransformLatinToHiragana", "Foundation")]
    internal unsafe static IntPtr NSStringTransformLatinToHiragana
    {
        get
        {
            fixed (IntPtr* storage = &values[1])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformLatinToHiragana", storage);
            }
        }
    }

    [Field("NSStringTransformLatinToHangul", "Foundation")]
    internal unsafe static IntPtr NSStringTransformLatinToHangul
    {
        get
        {
            fixed (IntPtr* storage = &values[2])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformLatinToHangul", storage);
            }
        }
    }

    [Field("NSStringTransformLatinToArabic", "Foundation")]
    internal unsafe static IntPtr NSStringTransformLatinToArabic
    {
        get
        {
            fixed (IntPtr* storage = &values[3])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformLatinToArabic", storage);
            }
        }
    }

    [Field("NSStringTransformLatinToHebrew", "Foundation")]
    internal unsafe static IntPtr NSStringTransformLatinToHebrew
    {
        get
        {
            fixed (IntPtr* storage = &values[4])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformLatinToHebrew", storage);
            }
        }
    }

    [Field("NSStringTransformLatinToThai", "Foundation")]
    internal unsafe static IntPtr NSStringTransformLatinToThai
    {
        get
        {
            fixed (IntPtr* storage = &values[5])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformLatinToThai", storage);
            }
        }
    }

    [Field("NSStringTransformLatinToCyrillic", "Foundation")]
    internal unsafe static IntPtr NSStringTransformLatinToCyrillic
    {
        get
        {
            fixed (IntPtr* storage = &values[6])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformLatinToCyrillic", storage);
            }
        }
    }

    [Field("NSStringTransformLatinToGreek", "Foundation")]
    internal unsafe static IntPtr NSStringTransformLatinToGreek
    {
        get
        {
            fixed (IntPtr* storage = &values[7])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformLatinToGreek", storage);
            }
        }
    }

    [Field("NSStringTransformToLatin", "Foundation")]
    internal unsafe static IntPtr NSStringTransformToLatin
    {
        get
        {
            fixed (IntPtr* storage = &values[8])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformToLatin", storage);
            }
        }
    }

    [Field("NSStringTransformMandarinToLatin", "Foundation")]
    internal unsafe static IntPtr NSStringTransformMandarinToLatin
    {
        get
        {
            fixed (IntPtr* storage = &values[9])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformMandarinToLatin", storage);
            }
        }
    }

    [Field("NSStringTransformHiraganaToKatakana", "Foundation")]
    internal unsafe static IntPtr NSStringTransformHiraganaToKatakana
    {
        get
        {
            fixed (IntPtr* storage = &values[10])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformHiraganaToKatakana", storage);
            }
        }
    }

    [Field("NSStringTransformFullwidthToHalfwidth", "Foundation")]
    internal unsafe static IntPtr NSStringTransformFullwidthToHalfwidth
    {
        get
        {
            fixed (IntPtr* storage = &values[11])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformFullwidthToHalfwidth", storage);
            }
        }
    }

    [Field("NSStringTransformToXMLHex", "Foundation")]
    internal unsafe static IntPtr NSStringTransformToXMLHex
    {
        get
        {
            fixed (IntPtr* storage = &values[12])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformToXMLHex", storage);
            }
        }
    }

    [Field("NSStringTransformToUnicodeName", "Foundation")]
    internal unsafe static IntPtr NSStringTransformToUnicodeName
    {
        get
        {
            fixed (IntPtr* storage = &values[13])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformToUnicodeName", storage);
            }
        }
    }

    [Field("NSStringTransformStripCombiningMarks", "Foundation")]
    internal unsafe static IntPtr NSStringTransformStripCombiningMarks
    {
        get
        {
            fixed (IntPtr* storage = &values[14])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformStripCombiningMarks", storage);
            }
        }
    }

    [Field("NSStringTransformStripDiacritics", "Foundation")]
    internal unsafe static IntPtr NSStringTransformStripDiacritics
    {
        get
        {
            fixed (IntPtr* storage = &values[15])
            {
                return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSStringTransformStripDiacritics", storage);
            }
        }
    }

    public static NSString? GetConstant(this NSStringTransform self)
    {
        IntPtr ptr = IntPtr.Zero;
        switch ((int)self)
        {
            case 0:
                ptr = NSStringTransformLatinToKatakana;
                break;
            case 1:
                ptr = NSStringTransformLatinToHiragana;
                break;
            case 2:
                ptr = NSStringTransformLatinToHangul;
                break;
            case 3:
                ptr = NSStringTransformLatinToArabic;
                break;
            case 4:
                ptr = NSStringTransformLatinToHebrew;
                break;
            case 5:
                ptr = NSStringTransformLatinToThai;
                break;
            case 6:
                ptr = NSStringTransformLatinToCyrillic;
                break;
            case 7:
                ptr = NSStringTransformLatinToGreek;
                break;
            case 8:
                ptr = NSStringTransformToLatin;
                break;
            case 9:
                ptr = NSStringTransformMandarinToLatin;
                break;
            case 10:
                ptr = NSStringTransformHiraganaToKatakana;
                break;
            case 11:
                ptr = NSStringTransformFullwidthToHalfwidth;
                break;
            case 12:
                ptr = NSStringTransformToXMLHex;
                break;
            case 13:
                ptr = NSStringTransformToUnicodeName;
                break;
            case 14:
                ptr = NSStringTransformStripCombiningMarks;
                break;
            case 15:
                ptr = NSStringTransformStripDiacritics;
                break;
        }
        return (NSString)Runtime.GetNSObject(ptr);
    }

    public static NSStringTransform GetValue(NSString constant)
    {
        if (constant == null)
        {
            throw new ArgumentNullException("constant");
        }
        if (constant.IsEqualTo(NSStringTransformLatinToKatakana))
        {
            return NSStringTransform.LatinToKatakana;
        }
        if (constant.IsEqualTo(NSStringTransformLatinToHiragana))
        {
            return NSStringTransform.LatinToHiragana;
        }
        if (constant.IsEqualTo(NSStringTransformLatinToHangul))
        {
            return NSStringTransform.LatinToHangul;
        }
        if (constant.IsEqualTo(NSStringTransformLatinToArabic))
        {
            return NSStringTransform.LatinToArabic;
        }
        if (constant.IsEqualTo(NSStringTransformLatinToHebrew))
        {
            return NSStringTransform.LatinToHebrew;
        }
        if (constant.IsEqualTo(NSStringTransformLatinToThai))
        {
            return NSStringTransform.LatinToThai;
        }
        if (constant.IsEqualTo(NSStringTransformLatinToCyrillic))
        {
            return NSStringTransform.LatinToCyrillic;
        }
        if (constant.IsEqualTo(NSStringTransformLatinToGreek))
        {
            return NSStringTransform.LatinToGreek;
        }
        if (constant.IsEqualTo(NSStringTransformToLatin))
        {
            return NSStringTransform.ToLatin;
        }
        if (constant.IsEqualTo(NSStringTransformMandarinToLatin))
        {
            return NSStringTransform.MandarinToLatin;
        }
        if (constant.IsEqualTo(NSStringTransformHiraganaToKatakana))
        {
            return NSStringTransform.HiraganaToKatakana;
        }
        if (constant.IsEqualTo(NSStringTransformFullwidthToHalfwidth))
        {
            return NSStringTransform.FullwidthToHalfwidth;
        }
        if (constant.IsEqualTo(NSStringTransformToXMLHex))
        {
            return NSStringTransform.ToXmlHex;
        }
        if (constant.IsEqualTo(NSStringTransformToUnicodeName))
        {
            return NSStringTransform.ToUnicodeName;
        }
        if (constant.IsEqualTo(NSStringTransformStripCombiningMarks))
        {
            return NSStringTransform.StripCombiningMarks;
        }
        if (constant.IsEqualTo(NSStringTransformStripDiacritics))
        {
            return NSStringTransform.StripDiacritics;
        }
        throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
    }
}
