using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLDataType : ulong
{
	None = 0uL,
	Struct = 1uL,
	Array = 2uL,
	Float = 3uL,
	Float2 = 4uL,
	Float3 = 5uL,
	Float4 = 6uL,
	Float2x2 = 7uL,
	Float2x3 = 8uL,
	Float2x4 = 9uL,
	Float3x2 = 10uL,
	Float3x3 = 11uL,
	Float3x4 = 12uL,
	Float4x2 = 13uL,
	Float4x3 = 14uL,
	Float4x4 = 15uL,
	Half = 16uL,
	Half2 = 17uL,
	Half3 = 18uL,
	Half4 = 19uL,
	Half2x2 = 20uL,
	Half2x3 = 21uL,
	Half2x4 = 22uL,
	Half3x2 = 23uL,
	Half3x3 = 24uL,
	Half3x4 = 25uL,
	Half4x2 = 26uL,
	Half4x3 = 27uL,
	Half4x4 = 28uL,
	Int = 29uL,
	Int2 = 30uL,
	Int3 = 31uL,
	Int4 = 32uL,
	UInt = 33uL,
	UInt2 = 34uL,
	UInt3 = 35uL,
	UInt4 = 36uL,
	Short = 37uL,
	Short2 = 38uL,
	Short3 = 39uL,
	Short4 = 40uL,
	UShort = 41uL,
	UShort2 = 42uL,
	UShort3 = 43uL,
	UShort4 = 44uL,
	Char = 45uL,
	Char2 = 46uL,
	Char3 = 47uL,
	Char4 = 48uL,
	UChar = 49uL,
	UChar2 = 50uL,
	UChar3 = 51uL,
	UChar4 = 52uL,
	Bool = 53uL,
	Bool2 = 54uL,
	Bool3 = 55uL,
	Bool4 = 56uL,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Texture = 58uL,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Sampler = 59uL,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Pointer = 60uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	R8Unorm = 62uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	R8Snorm = 63uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	R16Unorm = 64uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	R16Snorm = 65uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rg8Unorm = 66uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rg8Snorm = 67uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rg16Unorm = 68uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rg16Snorm = 69uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rgba8Unorm = 70uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rgba8Unorm_sRgb = 71uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rgba8Snorm = 72uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rgba16Unorm = 73uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rgba16Snorm = 74uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rgb10A2Unorm = 75uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rg11B10Float = 76uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	Rgb9E5Float = 77uL,
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	RenderPipeline = 78uL,
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	IndirectCommandBuffer = 80uL
}
