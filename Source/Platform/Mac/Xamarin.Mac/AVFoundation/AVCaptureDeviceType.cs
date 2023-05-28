using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public enum AVCaptureDeviceType
{
	BuiltInMicrophone,
	BuiltInWideAngleCamera,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	BuiltInTelephotoCamera,
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 2, PlatformArchitecture.None, "Use 'BuiltInDualCamera' instead.")]
	BuiltInDuoCamera,
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	BuiltInDualCamera,
	[Introduced(PlatformName.iOS, 11, 1, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	BuiltInTrueDepthCamera,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	BuiltInUltraWideCamera,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	BuiltInTripleCamera,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	BuiltInDualWideCamera,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	ExternalUnknown
}
