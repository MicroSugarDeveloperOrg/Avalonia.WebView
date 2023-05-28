using System;
using ObjCRuntime;

namespace Foundation;

[Mac(10, 11)]
[Native]
[Flags]
public enum NSAppleEventSendOptions : ulong
{
	NoReply = 1uL,
	QueueReply = 2uL,
	WaitForReply = 3uL,
	NeverInteract = 0x10uL,
	CanInteract = 0x20uL,
	AlwaysInteract = 0x30uL,
	CanSwitchLayer = 0x40uL,
	DontRecord = 0x1000uL,
	DontExecute = 0x2000uL,
	DontAnnotate = 0x10000uL,
	DefaultOptions = 0x23uL
}
