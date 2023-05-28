using ObjCRuntime;

namespace ImageCaptureCore;

[Native]
public enum ICDeviceLocationType : ulong
{
	Local = 0x100uL,
	Shared = 0x200uL,
	Bonjour = 0x400uL,
	Bluetooth = 0x800uL
}
