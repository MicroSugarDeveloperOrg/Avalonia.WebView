using ObjCRuntime;

namespace GameKit;

[Native]
public enum GKVoiceChatPlayerState : long
{
	Connected,
	Disconnected,
	Speaking,
	Silent,
	Connecting
}
