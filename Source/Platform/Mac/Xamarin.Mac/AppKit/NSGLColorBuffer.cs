using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public enum NSGLColorBuffer : uint
{
	Front = 1028u,
	Back = 1029u,
	Aux0 = 1033u
}
