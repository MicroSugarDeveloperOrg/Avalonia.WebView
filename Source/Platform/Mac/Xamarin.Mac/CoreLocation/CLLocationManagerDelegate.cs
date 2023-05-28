using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

[Protocol]
[Register("CLLocationManagerDelegate", false)]
[Model]
public class CLLocationManagerDelegate : NSObject, ICLLocationManagerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CLLocationManagerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CLLocationManagerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CLLocationManagerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("locationManager:didChangeAuthorizationStatus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AuthorizationChanged(CLLocationManager manager, CLAuthorizationStatus status)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didFinishDeferredUpdatesWithError:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeferredUpdatesFinished(CLLocationManager manager, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didDetermineState:forRegion:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDetermineState(CLLocationManager manager, CLRegionState state, CLRegion region)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didStartMonitoringForRegion:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStartMonitoringForRegion(CLLocationManager manager, CLRegion region)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Failed(CLLocationManager manager, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManagerDidPauseLocationUpdates:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LocationUpdatesPaused(CLLocationManager manager)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManagerDidResumeLocationUpdates:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LocationUpdatesResumed(CLLocationManager manager)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didUpdateLocations:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LocationsUpdated(CLLocationManager manager, CLLocation[] locations)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:monitoringDidFailForRegion:withError:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MonitoringFailed(CLLocationManager manager, CLRegion? region, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didEnterRegion:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegionEntered(CLLocationManager manager, CLRegion region)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didExitRegion:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegionLeft(CLLocationManager manager, CLRegion region)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManagerShouldDisplayHeadingCalibration:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldDisplayHeadingCalibration(CLLocationManager manager)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didUpdateToLocation:fromLocation:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdatedLocation(CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
