using ObjCRuntime;

namespace AudioToolbox;

[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
public enum AudioSessionActiveFlags : uint
{
	NotifyOthersOnDeactivation = 1u
}
