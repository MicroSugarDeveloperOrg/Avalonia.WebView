using System;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public enum AVAssetExportSessionPreset
{
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	LowQuality = 0,
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	MediumQuality = 1,
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	HighestQuality = 2,
	Preset640x480 = 3,
	Preset960x540 = 4,
	Preset1280x720 = 5,
	Preset1920x1080 = 6,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	Preset3840x2160 = 7,
	AppleM4A = 8,
	Passthrough = 9,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Obsolete("Use 'AVOutputSettingsPreset.PresetHevc1920x1080' instead.", false)]
	PresetHevc1920x1080 = 11,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Obsolete("Use 'AVOutputSettingsPreset.PresetHevc3840x2160' instead.", false)]
	PresetHevc3840x2160 = 12
}
