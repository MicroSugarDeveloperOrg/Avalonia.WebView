using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public enum NSStringTransform
{
    LatinToKatakana,
    LatinToHiragana,
    LatinToHangul,
    LatinToArabic,
    LatinToHebrew,
    LatinToThai,
    LatinToCyrillic,
    LatinToGreek,
    ToLatin,
    MandarinToLatin,
    HiraganaToKatakana,
    FullwidthToHalfwidth,
    ToXmlHex,
    ToUnicodeName,
    StripCombiningMarks,
    StripDiacritics
}
