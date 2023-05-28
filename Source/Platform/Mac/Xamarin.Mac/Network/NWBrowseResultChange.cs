using System;
using ObjCRuntime;

namespace Network;

[Flags]
[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public enum NWBrowseResultChange : ulong
{
	Invalid = 0uL,
	Identical = 1uL,
	ResultAdded = 2uL,
	ResultRemoved = 4uL,
	TxtRecordChanged = 0x20uL,
	InterfaceAdded = 8uL,
	InterfaceRemoved = 0x10uL
}
