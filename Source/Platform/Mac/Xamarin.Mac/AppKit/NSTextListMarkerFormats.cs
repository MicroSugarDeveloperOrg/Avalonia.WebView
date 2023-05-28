using ObjCRuntime;

namespace AppKit;

public enum NSTextListMarkerFormats
{
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Box,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Check,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Circle,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Diamond,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Disc,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Hyphen,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Square,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	LowercaseHexadecimal,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	UppercaseHexadecimal,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Octal,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	LowercaseAlpha,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	UppercaseAlpha,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	LowercaseLatin,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	UppercaseLatin,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	LowercaseRoman,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	UppercaseRoman,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Decimal
}
