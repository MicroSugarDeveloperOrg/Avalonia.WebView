using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use NSAlertButtonReturn instead.")]
[Native]
public enum NSAlertType : long
{
	ErrorReturn = -2L,
	OtherReturn,
	AlternateReturn,
	DefaultReturn
}
