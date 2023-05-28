using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum PdfWidgetControlType : long
{
	Unknown = -1L,
	PushButton,
	RadioButton,
	CheckBox
}
