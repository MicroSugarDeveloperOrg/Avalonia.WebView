using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public enum NSGLTextureCubeMap : uint
{
	None = 0u,
	PositiveX = 34069u,
	PositiveY = 34071u,
	PositiveZ = 34073u,
	NegativeX = 34070u,
	NegativeY = 34071u,
	NegativeZ = 34074u
}
