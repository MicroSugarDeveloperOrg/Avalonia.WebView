using System;
using ObjCRuntime;

namespace QuickLookThumbnailing;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum QLThumbnailGenerationRequestRepresentationTypes : ulong
{
	None = 0uL,
	Icon = 1uL,
	LowQualityThumbnail = 2uL,
	Thumbnail = 4uL,
	All = ulong.MaxValue
}
