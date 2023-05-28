using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public enum AVMediaTypes
{
	Video,
	Audio,
	Text,
	ClosedCaption,
	Subtitle,
	Timecode,
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Always 'null'.")]
	[Obsoleted(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Always 'null'.")]
	TimedMetadata,
	Muxed,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	MetadataObject,
	Metadata,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	DepthData
}
