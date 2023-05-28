using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum PdfLineStyle : long
{
	None,
	Square,
	Circle,
	Diamond,
	OpenArrow,
	ClosedArrow
}
