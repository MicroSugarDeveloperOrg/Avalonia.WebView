using System;
using ObjCRuntime;

namespace WebKit;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum WKAudiovisualMediaTypes : ulong
{
	None = 0uL,
	Audio = 1uL,
	Video = 2uL,
	All = ulong.MaxValue
}
