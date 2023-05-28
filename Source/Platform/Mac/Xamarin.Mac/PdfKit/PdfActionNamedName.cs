using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum PdfActionNamedName : long
{
	None,
	NextPage,
	PreviousPage,
	FirstPage,
	LastPage,
	GoBack,
	GoForward,
	GoToPage,
	Find,
	Print,
	ZoomIn,
	ZoomOut
}
