using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public enum PdfAnnotationTextIconType
{
	Comment,
	Key,
	Note,
	Help,
	NewParagraph,
	Paragraph,
	Insert
}
