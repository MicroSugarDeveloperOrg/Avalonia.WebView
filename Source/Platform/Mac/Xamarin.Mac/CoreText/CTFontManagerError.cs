using ObjCRuntime;

namespace CoreText;

[Native]
public enum CTFontManagerError : long
{
	None = 0L,
	FileNotFount = 101L,
	InsufficientPermissions = 102L,
	UnrecognizedFormat = 103L,
	InvalidFontData = 104L,
	AlreadyRegistered = 105L,
	ExceededResourceLimit = 106L,
	AssetNotFound = 107L,
	NotRegistered = 201L,
	InUse = 202L,
	SystemRequired = 203L,
	RegistrationFailed = 301L,
	MissingEntitlement = 302L,
	InsufficientInfo = 303L,
	CancelledByUser = 304L,
	DuplicatedName = 305L,
	InvalidFilePath = 306L
}
