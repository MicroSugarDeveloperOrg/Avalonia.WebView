using ObjCRuntime;

namespace CoreData;

[Native]
public enum ValidationErrorType : ulong
{
	ManagedObjectValidation = 1550uL,
	MultipleErrors = 1560uL,
	MissingMandatoryProperty = 1570uL,
	RelationshipLacksMinimumCount = 1580uL,
	RelationshipExceedsMaximumCount = 1590uL,
	RelationshipDeniedDelete = 1600uL,
	NumberTooLarge = 1610uL,
	NumberTooSmall = 1620uL,
	DateTooLate = 1630uL,
	DateTooSoon = 1640uL,
	InvalidDate = 1650uL,
	StringTooLong = 1660uL,
	StringTooShort = 1670uL,
	StringPatternMatching = 1680uL,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	InvalidUri = 1690uL
}
