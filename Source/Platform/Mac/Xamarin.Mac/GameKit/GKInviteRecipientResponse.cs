using ObjCRuntime;

namespace GameKit;

[Native]
public enum GKInviteRecipientResponse : long
{
	Accepted,
	Declined,
	Failed,
	Incompatible,
	UnableToConnect,
	NoAnswer
}
