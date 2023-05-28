using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSPathStyle : long
{
	Standard,
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	NavigationBar,
	PopUp
}
