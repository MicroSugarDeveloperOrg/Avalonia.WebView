using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Native]
public enum MTLPixelFormat : ulong
{
    Invalid = 0uL,
    A8Unorm = 1uL,
    R8Unorm = 10uL,
    R8Unorm_sRGB = 11uL,
    R8Snorm = 12uL,
    R8Uint = 13uL,
    R8Sint = 14uL,
    R16Unorm = 20uL,
    R16Snorm = 22uL,
    R16Uint = 23uL,
    R16Sint = 24uL,
    R16Float = 25uL,
    RG8Unorm = 30uL,
    RG8Snorm = 32uL,
    RG8Uint = 33uL,
    RG8Sint = 34uL,
    R32Uint = 53uL,
    R32Sint = 54uL,
    R32Float = 55uL,
    RG16Unorm = 60uL,
    RG16Snorm = 62uL,
    RG16Uint = 63uL,
    RG16Sint = 64uL,
    RG16Float = 65uL,
    RGBA8Unorm = 70uL,
    RGBA8Unorm_sRGB = 71uL,
    RGBA8Snorm = 72uL,
    RGBA8Uint = 73uL,
    RGBA8Sint = 74uL,
    BGRA8Unorm = 80uL,
    BGRA8Unorm_sRGB = 81uL,
    RGB10A2Unorm = 90uL,
    RGB10A2Uint = 91uL,
    RG11B10Float = 92uL,
    RGB9E5Float = 93uL,
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
    BGR10A2Unorm = 94uL,
    RG32Uint = 103uL,
    RG32Sint = 104uL,
    RG32Float = 105uL,
    RGBA16Unorm = 110uL,
    RGBA16Snorm = 112uL,
    RGBA16Uint = 113uL,
    RGBA16Sint = 114uL,
    RGBA16Float = 115uL,
    RGBA32Uint = 123uL,
    RGBA32Sint = 124uL,
    RGBA32Float = 125uL,
    BC1RGBA = 130uL,
    BC1_RGBA_sRGB = 131uL,
    BC2RGBA = 132uL,
    BC2_RGBA_sRGB = 133uL,
    BC3RGBA = 134uL,
    BC3_RGBA_sRGB = 135uL,
    BC4_RUnorm = 140uL,
    BC4_RSnorm = 141uL,
    BC5_RGUnorm = 142uL,
    BC5_RGSnorm = 143uL,
    BC6H_RGBFloat = 150uL,
    BC6H_RGBUFloat = 151uL,
    BC7_RGBAUnorm = 152uL,
    BC7_RGBAUnorm_sRGB = 153uL,
    GBGR422 = 240uL,
    BGRG422 = 241uL,
    Depth32Float = 252uL,
    Stencil8 = 253uL,
    Depth24Unorm_Stencil8 = 255uL,
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    Depth32Float_Stencil8 = 260uL,
    [Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    X32_Stencil8 = 261uL,
    [Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
    X24_Stencil8 = 262uL
}