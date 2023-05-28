using System;
using ObjCRuntime;

namespace NaturalLanguage;

[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum NLTaggerOptions : ulong
{
	OmitWords = 1uL,
	OmitPunctuation = 2uL,
	OmitWhitespace = 4uL,
	OmitOther = 8uL,
	JoinNames = 0x10uL,
	JoinContractions = 0x20uL
}
