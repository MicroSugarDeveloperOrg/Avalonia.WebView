using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Native]
public enum CBATTError : long
{
	Success,
	InvalidHandle,
	ReadNotPermitted,
	WriteNotPermitted,
	InvalidPdu,
	InsufficientAuthentication,
	RequestNotSupported,
	InvalidOffset,
	InsufficientAuthorization,
	PrepareQueueFull,
	AttributeNotFound,
	AttributeNotLong,
	InsufficientEncryptionKeySize,
	InvalidAttributeValueLength,
	UnlikelyError,
	InsufficientEncryption,
	UnsupportedGroupType,
	InsufficientResources
}
