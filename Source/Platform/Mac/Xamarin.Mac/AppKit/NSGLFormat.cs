using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public enum NSGLFormat : uint
{
	RGB = 6407u,
	RGBA = 6408u,
	DepthComponent = 6402u
}
