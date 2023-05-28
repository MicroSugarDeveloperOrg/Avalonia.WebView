using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSPrintingPageOrder : long
{
	Descending = -1L,
	Special,
	Ascending,
	Unknown
}
