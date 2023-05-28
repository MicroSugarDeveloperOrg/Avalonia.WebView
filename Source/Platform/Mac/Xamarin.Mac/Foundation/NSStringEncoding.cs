using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSStringEncoding : ulong
{
	ASCIIStringEncoding = 1uL,
	NEXTSTEP = 2uL,
	JapaneseEUC = 3uL,
	UTF8 = 4uL,
	ISOLatin1 = 5uL,
	Symbol = 6uL,
	NonLossyASCII = 7uL,
	ShiftJIS = 8uL,
	ISOLatin2 = 9uL,
	Unicode = 10uL,
	WindowsCP1251 = 11uL,
	WindowsCP1252 = 12uL,
	WindowsCP1253 = 13uL,
	WindowsCP1254 = 14uL,
	WindowsCP1250 = 15uL,
	ISO2022JP = 21uL,
	MacOSRoman = 30uL,
	UTF16BigEndian = 2415919360uL,
	UTF16LittleEndian = 2483028224uL,
	UTF32 = 2348810496uL,
	UTF32BigEndian = 2550137088uL,
	UTF32LittleEndian = 2617245952uL
}
