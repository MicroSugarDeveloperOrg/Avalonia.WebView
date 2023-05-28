using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum PdfTextAnnotationIconType : long
{
	Comment,
	Key,
	Note,
	Help,
	NewParagraph,
	Paragraph,
	Insert
}
