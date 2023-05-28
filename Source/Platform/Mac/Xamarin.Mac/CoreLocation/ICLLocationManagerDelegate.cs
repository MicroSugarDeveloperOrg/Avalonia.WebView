using System;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

[Protocol(Name = "CLLocationManagerDelegate", WrapperType = typeof(CLLocationManagerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedLocation", Selector = "locationManager:didUpdateToLocation:fromLocation:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(CLLocation),
	typeof(CLLocation)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDisplayHeadingCalibration", Selector = "locationManagerShouldDisplayHeadingCalibration:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(CLLocationManager) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Failed", Selector = "locationManager:didFailWithError:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegionEntered", Selector = "locationManager:didEnterRegion:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(CLRegion)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegionLeft", Selector = "locationManager:didExitRegion:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(CLRegion)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MonitoringFailed", Selector = "locationManager:monitoringDidFailForRegion:withError:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(CLRegion),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartMonitoringForRegion", Selector = "locationManager:didStartMonitoringForRegion:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(CLRegion)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDetermineState", Selector = "locationManager:didDetermineState:forRegion:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(CLRegionState),
	typeof(CLRegion)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AuthorizationChanged", Selector = "locationManager:didChangeAuthorizationStatus:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(CLAuthorizationStatus)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocationsUpdated", Selector = "locationManager:didUpdateLocations:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(CLLocation[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocationUpdatesPaused", Selector = "locationManagerDidPauseLocationUpdates:", ParameterType = new Type[] { typeof(CLLocationManager) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocationUpdatesResumed", Selector = "locationManagerDidResumeLocationUpdates:", ParameterType = new Type[] { typeof(CLLocationManager) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeferredUpdatesFinished", Selector = "locationManager:didFinishDeferredUpdatesWithError:", ParameterType = new Type[]
{
	typeof(CLLocationManager),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface ICLLocationManagerDelegate : INativeObject, IDisposable
{
}
