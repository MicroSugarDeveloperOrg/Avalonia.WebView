using System;

namespace ScriptingBridge;

[Flags]
public enum LSLaunchFlags : uint
{
	LaunchDefaults = 1u,
	LaunchAndPrint = 2u,
	LaunchReserved2 = 4u,
	LaunchReserved3 = 8u,
	LaunchReserved4 = 0x10u,
	LaunchReserved5 = 0x20u,
	LaunchAndDisplayErrors = 0x40u,
	LaunchInhibitBGOnly = 0x80u,
	LaunchDontAddToRecents = 0x100u,
	LaunchDontSwitch = 0x200u,
	LaunchNoParams = 0x800u,
	LaunchAsync = 0x10000u,
	LaunchStartClassic = 0x20000u,
	LaunchInClassic = 0x40000u,
	LaunchNewInstance = 0x80000u,
	LaunchAndHide = 0x100000u,
	LaunchAndHideOthers = 0x200000u,
	LaunchHasUntrustedContents = 0x400000u
}
