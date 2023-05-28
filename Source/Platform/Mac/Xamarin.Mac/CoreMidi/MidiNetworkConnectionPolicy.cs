using ObjCRuntime;

namespace CoreMidi;

[Native]
public enum MidiNetworkConnectionPolicy : ulong
{
	NoOne,
	HostsInContactsList,
	Anyone
}
