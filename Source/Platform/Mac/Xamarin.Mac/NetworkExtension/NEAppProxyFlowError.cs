using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Native]
public enum NEAppProxyFlowError : long
{
	None,
	NotConnected,
	PeerReset,
	HostUnreachable,
	InvalidArgument,
	Aborted,
	Refused,
	TimedOut,
	Internal,
	DatagramTooLarge,
	ReadAlreadyPending
}
