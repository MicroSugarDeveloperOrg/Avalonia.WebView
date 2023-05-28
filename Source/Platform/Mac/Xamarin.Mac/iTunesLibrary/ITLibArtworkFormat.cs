using ObjCRuntime;

namespace iTunesLibrary;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Native]
public enum ITLibArtworkFormat : ulong
{
	None,
	Bitmap,
	Jpeg,
	Jpeg2000,
	Gif,
	Png,
	Bmp,
	Tiff,
	Pict
}
