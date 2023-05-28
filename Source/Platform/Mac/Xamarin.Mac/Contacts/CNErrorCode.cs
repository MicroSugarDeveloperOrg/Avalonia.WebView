using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Native]
public enum CNErrorCode : long
{
	CommunicationError = 1L,
	DataAccessError = 2L,
	AuthorizationDenied = 100L,
	NoAccessibleWritableContainers = 101L,
	UnauthorizedKeys = 102L,
	FeatureDisabledByUser = 103L,
	RecordDoesNotExist = 200L,
	InsertedRecordAlreadyExists = 201L,
	ContainmentCycle = 202L,
	ContainmentScope = 203L,
	ParentRecordDoesNotExist = 204L,
	RecordIdentifierInvalid = 205L,
	RecordNotWritable = 206L,
	ParentContainerNotWritable = 207L,
	ValidationMultipleErrors = 300L,
	ValidationTypeMismatch = 301L,
	ValidationConfigurationError = 302L,
	PredicateInvalid = 400L,
	PolicyViolation = 500L,
	ClientIdentifierInvalid = 600L,
	ClientIdentifierDoesNotExist = 601L,
	VCardMalformed = 700L,
	VCardSummarizationError = 701L
}
