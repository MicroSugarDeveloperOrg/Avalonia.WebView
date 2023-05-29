namespace Security;

public enum SecTrustResult
{
	Invalid,
	Proceed,
	Confirm,
	Deny,
	Unspecified,
	RecoverableTrustFailure,
	FatalTrustFailure,
	ResultOtherError
}
