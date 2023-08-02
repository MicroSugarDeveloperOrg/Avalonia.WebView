namespace Security;

public enum AuthorizationStatus
{
	Success = 0,
	InvalidSet = -60001,
	InvalidRef = -60002,
	InvalidTag = -60003,
	InvalidPointer = -60004,
	Denied = -60005,
	Canceled = -60006,
	InteractionNotAllowed = -60007,
	Internal = -60008,
	ExternalizeNotAllowed = -60009,
	InternalizeNotAllowed = -60010,
	InvalidFlags = -60011,
	ToolExecuteFailure = -60031,
	ToolEnvironmentError = -60032,
	BadAddress = -60033
}
