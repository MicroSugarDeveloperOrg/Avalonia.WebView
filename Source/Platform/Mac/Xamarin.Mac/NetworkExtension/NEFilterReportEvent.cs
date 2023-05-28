using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum NEFilterReportEvent : long
{
	NewFlow = 1L,
	DataDecision,
	FlowClosed
}
