using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLBlendFactor : ulong
{
	Zero,
	One,
	SourceColor,
	OneMinusSourceColor,
	SourceAlpha,
	OneMinusSourceAlpha,
	DestinationColor,
	OneMinusDestinationColor,
	DestinationAlpha,
	OneMinusDestinationAlpha,
	SourceAlphaSaturated,
	BlendColor,
	OneMinusBlendColor,
	BlendAlpha,
	OneMinusBlendAlpha
}
