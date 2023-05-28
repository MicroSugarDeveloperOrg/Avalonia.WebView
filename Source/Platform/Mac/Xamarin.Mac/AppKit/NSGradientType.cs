using ObjCRuntime;

namespace AppKit;

[Native]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "The GradientType property is unused, and setting it has no effect.")]
public enum NSGradientType : ulong
{
	None,
	ConcaveWeak,
	ConcaveStrong,
	ConvexWeak,
	ConvexStrong
}
