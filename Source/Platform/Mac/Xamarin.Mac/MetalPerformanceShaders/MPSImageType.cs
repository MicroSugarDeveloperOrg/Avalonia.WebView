using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[TV(11, 3)]
[Mac(10, 13, 4)]
[iOS(11, 3)]
public enum MPSImageType : uint
{
	Type2d = 0u,
	Type2dArray = 1u,
	Array2d = 2u,
	Array2dArray = 3u,
	ArrayMask = 1u,
	BatchMask = 2u,
	TypeMask = 3u,
	NoAlpha = 4u,
	TexelFormatMask = 56u,
	TexelFormatShift = 3u,
	TexelFormatStandard = 0u,
	TexelFormatUnorm8 = 8u,
	TexelFormatFloat16 = 16u,
	TexelFormatBFloat16 = 24u,
	BitCount = 6u,
	Mask = 63u,
	Type2dNoAlpha = 4u,
	Type2dArrayNoAlpha = 5u,
	Array2dNoAlpha = 6u,
	Array2dArrayNoAlpha = 7u,
	DestTextureType = 63u,
	Src0TextureType = 63u,
	Src1TextureType = 1u,
	Src2TextureType = 0u,
	Src3TextureType = 0u,
	Src4TextureType = 0u
}
