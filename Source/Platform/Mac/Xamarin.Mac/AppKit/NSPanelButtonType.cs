using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use NSModalResponse instead.")]
[Native]
public enum NSPanelButtonType : long
{
	Cancel,
	Ok
}
