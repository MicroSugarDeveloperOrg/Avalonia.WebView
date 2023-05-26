using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKParticipantType : long
{
	Unknown,
	Person,
	Room,
	Resource,
	Group
}
