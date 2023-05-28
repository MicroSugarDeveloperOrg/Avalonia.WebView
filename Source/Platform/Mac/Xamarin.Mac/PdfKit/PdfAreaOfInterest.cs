using System;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum PdfAreaOfInterest : long
{
	NoArea = 0L,
	PageArea = 1L,
	TextArea = 2L,
	AnnotationArea = 4L,
	LinkArea = 8L,
	ControlArea = 0x10L,
	TextFieldArea = 0x20L,
	IconArea = 0x40L,
	PopupArea = 0x80L,
	ImageArea = 0x100L
}
