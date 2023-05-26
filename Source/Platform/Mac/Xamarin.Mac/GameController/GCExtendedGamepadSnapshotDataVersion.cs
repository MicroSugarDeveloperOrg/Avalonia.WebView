using ObjCRuntime;

namespace GameController;

[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
[Native]
public enum GCExtendedGamepadSnapshotDataVersion : long
{
	Version1 = 256L,
	Version2
}
