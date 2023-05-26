using System;

namespace Accounts;

public enum ACErrorCode
{
	Unknown = 1,
	AccountMissingRequiredProperty = 2,
	AccountAuthenticationFailed = 3,
	AccountTypeInvalid = 4,
	AccountAlreadyExits = 5,
	AccountNotFound = 6,
	PermissionDenied = 7,
	AccessInfoInvalid = 8,
	ClientPermissionDenied = 9,
	AccessDeniedByProtectionPolicy = 10,
	CredentialNotFound = 11,
	FetchCredentialFailed = 12,
	StoreCredentialFailed = 13,
	RemoveCredentialFailed = 14,
	UpdatingNonexistentAccount = 15,
	InvalidClientBundleID = 16,
	DeniedByPlugin = 17,
	CoreDataSaveFailed = 18,
	FailedSerializingAccountInfo = 19,
	InvalidCommand = 20,
	[Obsolete("Use 'MissingTransportMessageId'.", false)]
	MissingMessageID = 21,
	MissingTransportMessageId = 21,
	CredentialItemNotFound = 22,
	CredentialItemNotExpired = 23
}
