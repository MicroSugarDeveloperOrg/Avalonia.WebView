using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum PdfPrintScalingMode : long
{
	None,
	ToFit,
	DownToFit
}
