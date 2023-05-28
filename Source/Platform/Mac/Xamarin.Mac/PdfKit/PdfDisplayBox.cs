using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum PdfDisplayBox : long
{
	Media,
	Crop,
	Bleed,
	Trim,
	Art
}
