using ObjCRuntime;

namespace CoreLocation;

[Native]
public enum CLError : long
{
	LocationUnknown,
	Denied,
	Network,
	HeadingFailure,
	RegionMonitoringDenied,
	RegionMonitoringFailure,
	RegionMonitoringSetupDelayed,
	RegionMonitoringResponseDelayed,
	GeocodeFoundNoResult,
	GeocodeFoundPartialResult,
	GeocodeCanceled,
	DeferredFailed,
	DeferredNotUpdatingLocation,
	DeferredAccuracyTooLow,
	DeferredDistanceFiltered,
	DeferredCanceled,
	RangingFailure,
	RangingUnavailable
}
