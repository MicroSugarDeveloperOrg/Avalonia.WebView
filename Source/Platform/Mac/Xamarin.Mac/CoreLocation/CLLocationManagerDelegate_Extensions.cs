using System;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

public static class CLLocationManagerDelegate_Extensions
{
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdatedLocation(this ICLLocationManagerDelegate This, CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		if (newLocation == null)
		{
			throw new ArgumentNullException("newLocation");
		}
		if (oldLocation == null)
		{
			throw new ArgumentNullException("oldLocation");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("locationManager:didUpdateToLocation:fromLocation:"), manager.Handle, newLocation.Handle, oldLocation.Handle);
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldDisplayHeadingCalibration(this ICLLocationManagerDelegate This, CLLocationManager manager)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("locationManagerShouldDisplayHeadingCalibration:"), manager.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Failed(this ICLLocationManagerDelegate This, CLLocationManager manager, NSError error)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("locationManager:didFailWithError:"), manager.Handle, error.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegionEntered(this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion region)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("locationManager:didEnterRegion:"), manager.Handle, region.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegionLeft(this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion region)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("locationManager:didExitRegion:"), manager.Handle, region.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MonitoringFailed(this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion? region, NSError error)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("locationManager:monitoringDidFailForRegion:withError:"), manager.Handle, region?.Handle ?? IntPtr.Zero, error.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStartMonitoringForRegion(this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegion region)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("locationManager:didStartMonitoringForRegion:"), manager.Handle, region.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDetermineState(this ICLLocationManagerDelegate This, CLLocationManager manager, CLRegionState state, CLRegion region)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(This.Handle, Selector.GetHandle("locationManager:didDetermineState:forRegion:"), manager.Handle, (long)state, region.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AuthorizationChanged(this ICLLocationManagerDelegate This, CLLocationManager manager, CLAuthorizationStatus status)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt32(This.Handle, Selector.GetHandle("locationManager:didChangeAuthorizationStatus:"), manager.Handle, (uint)status);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LocationsUpdated(this ICLLocationManagerDelegate This, CLLocationManager manager, CLLocation[] locations)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		if (locations == null)
		{
			throw new ArgumentNullException("locations");
		}
		NSArray nSArray = NSArray.FromNSObjects(locations);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("locationManager:didUpdateLocations:"), manager.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LocationUpdatesPaused(this ICLLocationManagerDelegate This, CLLocationManager manager)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("locationManagerDidPauseLocationUpdates:"), manager.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LocationUpdatesResumed(this ICLLocationManagerDelegate This, CLLocationManager manager)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("locationManagerDidResumeLocationUpdates:"), manager.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeferredUpdatesFinished(this ICLLocationManagerDelegate This, CLLocationManager manager, NSError? error)
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("locationManager:didFinishDeferredUpdatesWithError:"), manager.Handle, error?.Handle ?? IntPtr.Zero);
	}
}
