using ObjCRuntime;

namespace AVKit;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Native]
public enum AVPlayerViewTrimResult : long
{
	OKButton,
	CancelButton
}
