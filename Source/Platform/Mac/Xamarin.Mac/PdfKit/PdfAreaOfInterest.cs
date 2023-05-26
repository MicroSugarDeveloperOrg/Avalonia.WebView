using System;

namespace PdfKit;

[Flags]
public enum PdfAreaOfInterest
{
	NoArea = 0,
	PageArea = 1,
	TextArea = 2,
	AnnotationArea = 4,
	LinkArea = 8,
	ControlArea = 0x10,
	TextFieldArea = 0x20,
	IconArea = 0x40,
	PopupArea = 0x80
}
