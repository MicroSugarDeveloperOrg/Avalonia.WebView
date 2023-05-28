using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public enum NWWebSocketCloseCode
{
	NormalClosure = 1000,
	GoingAway = 1001,
	ProtocolError = 1002,
	UnsupportedData = 1003,
	NoStatusReceived = 1005,
	AbnormalClosure = 1006,
	InvalidFramePayloadData = 1007,
	PolicyViolation = 1008,
	MessageTooBig = 1009,
	MandatoryExtension = 1010,
	InternalServerError = 1011,
	TlsHandshake = 1015
}
