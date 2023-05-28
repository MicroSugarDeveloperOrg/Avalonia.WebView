using ObjCRuntime;

namespace GameKit;

[Native]
public enum GKMatchType : ulong
{
	PeerToPeer,
	Hosted,
	TurnBased
}
