using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKParticipantScheduleStatus : long
{
	None,
	Pending,
	Sent,
	Delivered,
	RecipientNotRecognized,
	NoPrivileges,
	DeliveryFailed,
	CannotDeliver,
	RecipientNotAllowed
}
