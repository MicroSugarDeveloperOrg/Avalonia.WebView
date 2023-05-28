using ObjCRuntime;

namespace ImageIO;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public enum CGImageMetadataErrors
{
	Unknown,
	UnsupportedFormat,
	BadArgument,
	ConflictingArguments,
	PrefixConflict
}
