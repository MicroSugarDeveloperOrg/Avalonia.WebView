using ObjCRuntime;

namespace CoreWlan;

[Native]
public enum CWEventType : long
{
	None = 0L,
	PowerDidChange = 1L,
	SsidDidChange = 2L,
	BssidDidChange = 3L,
	CountryCodeDidChange = 4L,
	LinkDidChange = 5L,
	LinkQualityDidChange = 6L,
	ModeDidChange = 7L,
	ScanCacheUpdated = 8L,
	VirtualInterfaceStateChanged = 9L,
	RangingReportEvent = 10L,
	Unknown = long.MaxValue
}
