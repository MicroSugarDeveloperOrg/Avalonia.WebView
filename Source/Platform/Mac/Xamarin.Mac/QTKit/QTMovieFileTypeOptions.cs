using System;

namespace QTKit;

[Flags]
public enum QTMovieFileTypeOptions
{
	StillImageTypes = 1,
	TranslatableTypes = 2,
	AggressiveTypes = 4,
	DynamicTypes = 8,
	CommonTypes = 0,
	AllTypes = 0xFFFF
}
