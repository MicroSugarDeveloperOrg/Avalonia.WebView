using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSTiffCompression : ulong
{
	None = 1uL,
	CcittFax3 = 3uL,
	CcittFax4 = 4uL,
	Lzw = 5uL,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	Jpeg = 6uL,
	Next = 32766uL,
	PackBits = 32773uL,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	OldJpeg = 32865uL
}
