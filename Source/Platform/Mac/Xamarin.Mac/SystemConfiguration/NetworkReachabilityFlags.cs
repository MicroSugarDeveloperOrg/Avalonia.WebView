using System;

namespace SystemConfiguration;

[Flags]
public enum NetworkReachabilityFlags
{
	TransientConnection = 1,
	Reachable = 2,
	ConnectionRequired = 4,
	ConnectionOnTraffic = 8,
	InterventionRequired = 0x10,
	ConnectionOnDemand = 0x20,
	IsLocalAddress = 0x10000,
	IsDirect = 0x20000,
	ConnectionAutomatic = 8
}
