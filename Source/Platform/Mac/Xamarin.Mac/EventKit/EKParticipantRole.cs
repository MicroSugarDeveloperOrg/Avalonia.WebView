using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKParticipantRole : long
{
	Unknown,
	Required,
	Optional,
	Chair,
	NonParticipant
}
