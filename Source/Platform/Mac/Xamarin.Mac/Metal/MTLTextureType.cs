using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLTextureType : ulong
{
    k1D,
    k1DArray,
    k2D,
    k2DArray,
    k2DMultisample,
    kCube,
    kCubeArray,
    k3D,
    [Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
    k2DMultisampleArray,
    [Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
    kTextureBuffer
}
