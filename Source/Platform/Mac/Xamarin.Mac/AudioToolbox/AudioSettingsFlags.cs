using System;
using ObjCRuntime;

namespace AudioToolbox;

[Flags]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[NoWatch]
[TV(10, 0)]
[Mac(10, 12)]
[iOS(10, 0)]
public enum AudioSettingsFlags : uint
{
	ExpertParameter = 1u,
	InvisibleParameter = 2u,
	MetaParameter = 4u,
	UserInterfaceParameter = 8u
}
