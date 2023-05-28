namespace CoreFoundation;

public enum CFMessagePortSendRequestStatus
{
	Success = 0,
	SendTimeout = -1,
	ReceiveTimeout = -2,
	IsInvalid = -3,
	TransportError = -4,
	BecameInvalidError = -5
}
