using System;
using ObjCRuntime;

namespace CoreAudioKit;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Flags]
public enum AUGenericViewDisplayFlags : uint
{
	TitleDisplay = 1u,
	PropertiesDisplay = 2u,
	ParametersDisplay = 4u
}
