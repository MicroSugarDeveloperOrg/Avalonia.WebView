namespace CoreText;

public enum CTFontManagerError
{
	None = 0,
	FileNotFount = 101,
	InsufficientPermissions = 102,
	UnrecognizedFormat = 103,
	InvalidFontData = 104,
	AlreadyRegistered = 105,
	NotRegistered = 201,
	InUse = 202,
	SystemRequired = 202
}
