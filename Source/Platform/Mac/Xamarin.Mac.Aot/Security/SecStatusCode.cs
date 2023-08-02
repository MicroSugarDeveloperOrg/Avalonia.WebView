namespace Security;

public enum SecStatusCode
{
	Success = 0,
	Unimplemented = -4,
	Param = -50,
	Allocate = -108,
	NotAvailable = -25291,
	ReadOnly = -25292,
	AuthFailed = -25293,
	NoSuchKeyChain = -25294,
	InvalidKeyChain = -25295,
	DuplicateKeyChain = -25296,
	DuplicateItem = -25299,
	ItemNotFound = -25300,
	InteractionNotAllowed = -25308,
	Decode = -26275
}
