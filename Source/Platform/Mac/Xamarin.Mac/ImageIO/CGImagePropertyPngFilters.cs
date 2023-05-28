using System;
using ObjCRuntime;

namespace ImageIO;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Flags]
public enum CGImagePropertyPngFilters
{
	No = 0,
	None = 8,
	Sub = 0x10,
	Up = 0x20,
	Average = 0x40,
	Paeth = 0x80
}
