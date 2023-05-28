using System;

namespace ObjCRuntime;

[Flags]
public enum LinkTarget
{
	Simulator = 1,
	i386 = 1,
	ArmV6 = 2,
	ArmV7 = 4,
	Thumb = 8,
	ArmV7s = 0x10,
	Arm64 = 0x20,
	Simulator64 = 0x40,
	x86_64 = 0x40
}
