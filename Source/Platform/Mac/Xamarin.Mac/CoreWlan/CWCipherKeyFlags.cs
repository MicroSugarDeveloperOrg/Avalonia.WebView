using ObjCRuntime;

namespace CoreWlan;

[Native]
public enum CWCipherKeyFlags : ulong
{
	None = 0uL,
	Unicast = 2uL,
	Multicast = 4uL,
	Tx = 8uL,
	Rx = 0x10uL
}
