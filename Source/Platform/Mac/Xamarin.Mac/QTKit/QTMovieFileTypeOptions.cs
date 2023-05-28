using System;

namespace QTKit;

[Flags]
public enum QTMovieFileTypeOptions : uint
{
	StillImageTypes = 1u,
	TranslatableTypes = 2u,
	AggressiveTypes = 4u,
	DynamicTypes = 8u,
	CommonTypes = 0u,
	AllTypes = 0xFFFFu
}
