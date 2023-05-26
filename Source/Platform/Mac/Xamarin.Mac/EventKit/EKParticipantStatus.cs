using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKParticipantStatus : long
{
	Unknown,
	Pending,
	Accepted,
	Declined,
	Tentative,
	Delegated,
	Completed,
	InProcess
}
