using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public enum CTFontFormat : uint
{
	Unrecognized,
	OpenTypePostScript,
	OpenTypeTrueType,
	TrueType,
	PostScript,
	Bitmap
}
