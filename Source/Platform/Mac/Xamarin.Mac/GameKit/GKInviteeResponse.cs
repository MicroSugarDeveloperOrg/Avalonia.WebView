using ObjCRuntime;

namespace GameKit;

[Native]
public enum GKInviteeResponse : long
{
	Accepted,
	Declined,
	Failed,
	Incompatible,
	UnableToConnect,
	NoAnswer
}
