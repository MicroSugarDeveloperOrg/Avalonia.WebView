using ObjCRuntime;

namespace CoreLocation;

public enum CLError
{
	LocationUnknown,
	Denied,
	Network,
	HeadingFailure,
	[Since(4, 0)]
	RegionMonitoringDenied,
	[Since(4, 0)]
	RegionMonitoringFailure,
	[Since(4, 0)]
	RegionMonitoringSetupDelayed,
	RegionMonitoringResponseDelayed,
	GeocodeFoundNoResult,
	GeocodeFoundPartialResult,
	GeocodeCanceled,
	DeferredFailed,
	DeferredNotUpdatingLocation,
	DeferredAccuracyTooLow,
	DeferredDistanceFiltered,
	DeferredCanceled
}
