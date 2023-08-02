using System;

namespace AudioUnit;

[Flags]
public enum AudioUnitRenderActionFlags
{
	PreRender = 4,
	PostRender = 8,
	OutputIsSilence = 0x10,
	OfflinePreflight = 0x20,
	OfflineRender = 0x40,
	OfflineComplete = 0x80,
	PostRenderError = 0x100,
	DoNotCheckRenderArgs = 0x200
}
