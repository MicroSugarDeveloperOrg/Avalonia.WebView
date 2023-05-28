using ObjCRuntime;

namespace AppKit;

[Mac(10, 13)]
[Native]
public enum NSAccessibilityCustomRotorType : long
{
	Custom,
	Any,
	Annotation,
	BoldText,
	Heading,
	HeadingLevel1,
	HeadingLevel2,
	HeadingLevel3,
	HeadingLevel4,
	HeadingLevel5,
	HeadingLevel6,
	Image,
	ItalicText,
	Landmark,
	Link,
	List,
	MisspelledWord,
	Table,
	TextField,
	UnderlinedText,
	VisitedLink
}
