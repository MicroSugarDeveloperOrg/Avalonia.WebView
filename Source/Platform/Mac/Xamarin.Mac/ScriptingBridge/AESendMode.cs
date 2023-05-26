using System;

namespace ScriptingBridge;

[Flags]
public enum AESendMode
{
	NoReply = 1,
	QueueReply = 2,
	WaitReply = 3,
	DontReconnect = 0x80,
	WantReceipt = 0x200,
	NeverInteract = 0x10,
	CanInteract = 0x20,
	AlwaysInteract = 0x30,
	CanSwitchLayer = 0x40,
	DontRecord = 0x1000,
	DontExecute = 0x2000,
	ProcessNonReplyEvents = 0x8000
}
