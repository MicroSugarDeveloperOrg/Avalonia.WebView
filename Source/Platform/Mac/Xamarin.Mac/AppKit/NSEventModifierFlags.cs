using System;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum NSEventModifierFlags : ulong
{
	CapsLock = 0x10000uL,
	Shift = 0x20000uL,
	Control = 0x40000uL,
	Option = 0x80000uL,
	Command = 0x100000uL,
	NumericPad = 0x200000uL,
	Help = 0x400000uL,
	Function = 0x800000uL,
	DeviceIndependentFlagsMask = 0xFFFF0000uL
}
