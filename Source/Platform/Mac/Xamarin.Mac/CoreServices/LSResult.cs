namespace CoreServices;

public enum LSResult
{
	Success = 0,
	AppInTrash = -10660,
	ExecutableIncorrectFormat = -10661,
	AttributeNotFound = -10662,
	AttributeNotSettable = -10663,
	IncompatibleApplicationVersion = -10664,
	NoRosettaEnvironment = -10665,
	Unknown = -10810,
	NotAnApplication = -10811,
	NotInitialized = -10812,
	DataUnavailable = -10813,
	ApplicationNotFound = -10814,
	UnknownType = -10815,
	DataTooOld = -10816,
	Data = -10817,
	LaunchInProgress = -10818,
	NotRegistered = -10819,
	AppDoesNotClaimType = -10820,
	AppDoesNotSupportSchemeWarning = -10821,
	ServerCommunication = -10822,
	CannotSetInfo = -10823,
	NoRegistrationInfo = -10824,
	IncompatibleSystemVersion = -10825,
	NoLaunchPermission = -10826,
	NoExecutable = -10827,
	NoClassicEnvironment = -10828,
	MultipleSessionsNotSupported = -10829
}
