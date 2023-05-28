using System;
using ObjCRuntime;

namespace StoreKit;

[Native]
public enum SKError : long
{
	Unknown = 0L,
	ClientInvalid = 1L,
	PaymentCancelled = 2L,
	PaymentInvalid = 3L,
	PaymentNotAllowed = 4L,
	ProductNotAvailable = 5L,
	CloudServicePermissionDenied = 6L,
	CloudServiceNetworkConnectionFailed = 7L,
	CloudServiceRevoked = 8L,
	[Obsolete("Use 'SKError.CloudServiceRevoked' instead.", false)]
	Revoked = 8L,
	PrivacyAcknowledgementRequired = 9L,
	UnauthorizedRequestData = 10L,
	InvalidOfferIdentifier = 11L,
	InvalidSignature = 12L,
	MissingOfferParams = 13L,
	InvalidOfferPrice = 14L
}
