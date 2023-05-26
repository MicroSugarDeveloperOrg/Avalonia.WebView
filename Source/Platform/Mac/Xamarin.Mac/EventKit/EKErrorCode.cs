using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKErrorCode : long
{
	EventNotMutable,
	NoCalendar,
	NoStartDate,
	NoEndDate,
	DatesInverted,
	InternalFailure,
	CalendarReadOnly,
	DurationGreaterThanRecurrence,
	AlarmGreaterThanRecurrence,
	StartDateTooFarInFuture,
	StartDateCollidesWithOtherOccurrence,
	ObjectBelongsToDifferentStore,
	InvitesCannotBeMoved,
	InvalidSpan,
	CalendarHasNoSource,
	CalendarSourceCannotBeModified,
	CalendarIsImmutable,
	SourceDoesNotAllowCalendarAddDelete,
	RecurringReminderRequiresDueDate,
	StructuredLocationsNotSupported,
	ReminderLocationsNotSupported,
	AlarmProximityNotSupported,
	CalendarDoesNotAllowEvents,
	CalendarDoesNotAllowReminders,
	SourceDoesNotAllowReminders,
	SourceDoesNotAllowEvents,
	PriorityIsInvalid,
	InvalidEntityType,
	ProcedureAlarmsNotMutable,
	EventStoreNotAuthorized,
	OSNotSupported,
	InvalidInviteReplyCalendar,
	NotificationsCollectionFlagNotSet,
	SourceMismatch,
	NotificationCollectionMismatch,
	NotificationSavedWithoutCollection
}
