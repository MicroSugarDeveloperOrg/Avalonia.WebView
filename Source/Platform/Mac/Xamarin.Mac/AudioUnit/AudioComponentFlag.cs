using System;

namespace AudioUnit;

[Flags]
public enum AudioComponentFlag
{
	Unsearchable = 1,
	SandboxSafe = 2,
	IsV3AudioUnit = 4,
	RequiresAsyncInstantiation = 8,
	CanLoadInProcess = 0x10
}
