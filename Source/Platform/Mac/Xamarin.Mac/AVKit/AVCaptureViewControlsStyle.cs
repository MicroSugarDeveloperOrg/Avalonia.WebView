using ObjCRuntime;

namespace AVKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum AVCaptureViewControlsStyle : long
{
	Inline = 0L,
	Floating = 1L,
	InlineDeviceSelection = 2L,
	Default = 0L
}
