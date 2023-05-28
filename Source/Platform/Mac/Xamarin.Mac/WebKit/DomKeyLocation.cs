using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public enum DomKeyLocation : uint
{
	Standard,
	Left,
	Right,
	NumberPad
}
