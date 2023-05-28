using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Native]
public enum INCallCapability : long
{
	Unknown,
	AudioCall,
	VideoCall
}
