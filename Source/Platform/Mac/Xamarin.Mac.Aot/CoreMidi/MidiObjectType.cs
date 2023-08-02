using System;

namespace CoreMidi;

[Flags]
internal enum MidiObjectType
{
	Other = -1,
	Device = 0,
	Entity = 1,
	Source = 2,
	Destination = 3,
	ExternalMask = 0x10,
	ExternalDevice = 0x10,
	ExternalEntity = 0x11,
	ExternalSource = 0x12,
	ExternalDestination = 0x13
}
