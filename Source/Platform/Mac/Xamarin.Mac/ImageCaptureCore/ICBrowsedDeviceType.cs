using System;
using ObjCRuntime;

namespace ImageCaptureCore;

[Flags]
[Native]
public enum ICBrowsedDeviceType : ulong
{
	None = 0uL,
	Camera = 1uL,
	Scanner = 2uL,
	Local = 0x100uL,
	Shared = 0x200uL,
	Bonjour = 0x400uL,
	Bluetooth = 0x800uL,
	Remote = 0xFE00uL
}
