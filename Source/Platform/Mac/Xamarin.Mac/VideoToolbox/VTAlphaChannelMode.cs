using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
public enum VTAlphaChannelMode
{
	StraightAlpha,
	PremultipliedAlpha
}
