using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum NSUrlSessionWebSocketCloseCode : long
{
	Invalid = 0L,
	NormalClosure = 1000L,
	GoingAway = 1001L,
	ProtocolError = 1002L,
	UnsupportedData = 1003L,
	NoStatusReceived = 1005L,
	AbnormalClosure = 1006L,
	InvalidFramePayloadData = 1007L,
	PolicyViolation = 1008L,
	MessageTooBig = 1009L,
	MandatoryExtensionMissing = 1010L,
	InternalServerError = 1011L,
	TlsHandshakeFailure = 1015L
}
