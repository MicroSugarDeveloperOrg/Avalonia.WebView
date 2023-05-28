using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public enum NSGLTextureTarget : uint
{
	T2D = 3553u,
	CubeMap = 34067u,
	RectangleExt = 34037u
}
