using ObjCRuntime;

namespace CoreWlan;

[Native]
public enum CWStatus : long
{
	Ok = 0L,
	EAPOL = 1L,
	InvalidParameter = -3900L,
	NoMemory = -3901L,
	Unknown = -3902L,
	NotSupported = -3903L,
	InvalidFormat = -3904L,
	Timeout = -3905L,
	UnspecifiedFailure = -3906L,
	UnsupportedCapabilities = -3907L,
	ReassociationDenied = -3908L,
	AssociationDenied = -3909L,
	AuthenticationAlgorithmUnsupported = -3910L,
	InvalidAuthenticationSequenceNumber = -3911L,
	ChallengeFailure = -3912L,
	APFull = -3913L,
	UnsupportedRateSet = -3914L,
	ShortSlotUnsupported = -3915L,
	DSSSOFDMUnsupported = -3916L,
	InvalidInformationElement = -3917L,
	InvalidGroupCipher = -3918L,
	InvalidPairwiseCipher = -3919L,
	InvalidAKMP = -3920L,
	UnsupportedRSNVersion = -3921L,
	InvalidRSNCapabilities = -3922L,
	CipherSuiteRejected = -3923L,
	InvalidPMK = -3924L,
	SupplicantTimeout = -3925L,
	HTFeaturesNotSupported = -3926L,
	PCOTransitionTimeNotSupported = -3927L,
	ReferenceNotBound = -3928L,
	IPCFailure = -3929L,
	OperationNotPermitted = -3930L,
	Status = -3931L
}
