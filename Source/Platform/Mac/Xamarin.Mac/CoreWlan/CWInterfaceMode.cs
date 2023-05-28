using ObjCRuntime;

namespace CoreWlan;

[Native]
public enum CWInterfaceMode : ulong
{
	None,
	Station,
	Ibss,
	HostAP
}
