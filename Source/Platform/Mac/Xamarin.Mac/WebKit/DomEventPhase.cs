using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public enum DomEventPhase : ushort
{
	Capturing = 1,
	AtTarget,
	Bubbling
}
