using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

[Register("CLLocationManager", true)]
public class CLLocationManager : NSObject
{
	[Register]
	internal class _CLLocationManagerDelegate : NSObject, ICLLocationManagerDelegate, INativeObject, IDisposable
	{
		internal EventHandler<CLAuthorizationChangedEventArgs>? authorizationChanged;

		internal EventHandler<NSErrorEventArgs>? deferredUpdatesFinished;

		internal EventHandler<CLRegionStateDeterminedEventArgs>? didDetermineState;

		internal EventHandler<CLRegionEventArgs>? didStartMonitoringForRegion;

		internal EventHandler<NSErrorEventArgs>? failed;

		internal EventHandler? locationUpdatesPaused;

		internal EventHandler? locationUpdatesResumed;

		internal EventHandler<CLLocationsUpdatedEventArgs>? locationsUpdated;

		internal EventHandler<CLRegionErrorEventArgs>? monitoringFailed;

		internal EventHandler<CLRegionEventArgs>? regionEntered;

		internal EventHandler<CLRegionEventArgs>? regionLeft;

		internal CLLocationManagerEventArgs? shouldDisplayHeadingCalibration;

		internal EventHandler<CLLocationUpdatedEventArgs>? updatedLocation;

		public _CLLocationManagerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:didChangeAuthorizationStatus:")]
		public void AuthorizationChanged(CLLocationManager manager, CLAuthorizationStatus status)
		{
			EventHandler<CLAuthorizationChangedEventArgs> eventHandler = authorizationChanged;
			if (eventHandler != null)
			{
				CLAuthorizationChangedEventArgs e = new CLAuthorizationChangedEventArgs(status);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:didFinishDeferredUpdatesWithError:")]
		public void DeferredUpdatesFinished(CLLocationManager manager, NSError? error)
		{
			EventHandler<NSErrorEventArgs> eventHandler = deferredUpdatesFinished;
			if (eventHandler != null)
			{
				NSErrorEventArgs e = new NSErrorEventArgs(error);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:didDetermineState:forRegion:")]
		public void DidDetermineState(CLLocationManager manager, CLRegionState state, CLRegion region)
		{
			EventHandler<CLRegionStateDeterminedEventArgs> eventHandler = didDetermineState;
			if (eventHandler != null)
			{
				CLRegionStateDeterminedEventArgs e = new CLRegionStateDeterminedEventArgs(state, region);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:didStartMonitoringForRegion:")]
		public void DidStartMonitoringForRegion(CLLocationManager manager, CLRegion region)
		{
			EventHandler<CLRegionEventArgs> eventHandler = didStartMonitoringForRegion;
			if (eventHandler != null)
			{
				CLRegionEventArgs e = new CLRegionEventArgs(region);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:didFailWithError:")]
		public void Failed(CLLocationManager manager, NSError error)
		{
			EventHandler<NSErrorEventArgs> eventHandler = failed;
			if (eventHandler != null)
			{
				NSErrorEventArgs e = new NSErrorEventArgs(error);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("locationManagerDidPauseLocationUpdates:")]
		public void LocationUpdatesPaused(CLLocationManager manager)
		{
			locationUpdatesPaused?.Invoke(manager, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("locationManagerDidResumeLocationUpdates:")]
		public void LocationUpdatesResumed(CLLocationManager manager)
		{
			locationUpdatesResumed?.Invoke(manager, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:didUpdateLocations:")]
		public void LocationsUpdated(CLLocationManager manager, CLLocation[] locations)
		{
			EventHandler<CLLocationsUpdatedEventArgs> eventHandler = locationsUpdated;
			if (eventHandler != null)
			{
				CLLocationsUpdatedEventArgs e = new CLLocationsUpdatedEventArgs(locations);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:monitoringDidFailForRegion:withError:")]
		public void MonitoringFailed(CLLocationManager manager, CLRegion? region, NSError error)
		{
			EventHandler<CLRegionErrorEventArgs> eventHandler = monitoringFailed;
			if (eventHandler != null)
			{
				CLRegionErrorEventArgs e = new CLRegionErrorEventArgs(region, error);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:didEnterRegion:")]
		public void RegionEntered(CLLocationManager manager, CLRegion region)
		{
			EventHandler<CLRegionEventArgs> eventHandler = regionEntered;
			if (eventHandler != null)
			{
				CLRegionEventArgs e = new CLRegionEventArgs(region);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:didExitRegion:")]
		public void RegionLeft(CLLocationManager manager, CLRegion region)
		{
			EventHandler<CLRegionEventArgs> eventHandler = regionLeft;
			if (eventHandler != null)
			{
				CLRegionEventArgs e = new CLRegionEventArgs(region);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("locationManagerShouldDisplayHeadingCalibration:")]
		public bool ShouldDisplayHeadingCalibration(CLLocationManager manager)
		{
			return shouldDisplayHeadingCalibration?.Invoke(manager) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("locationManager:didUpdateToLocation:fromLocation:")]
		public void UpdatedLocation(CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
		{
			EventHandler<CLLocationUpdatedEventArgs> eventHandler = updatedLocation;
			if (eventHandler != null)
			{
				CLLocationUpdatedEventArgs e = new CLLocationUpdatedEventArgs(newLocation, oldLocation);
				eventHandler(manager, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationStatus = "authorizationStatus";

	private static readonly IntPtr selAuthorizationStatusHandle = Selector.GetHandle("authorizationStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeferredLocationUpdatesAvailable = "deferredLocationUpdatesAvailable";

	private static readonly IntPtr selDeferredLocationUpdatesAvailableHandle = Selector.GetHandle("deferredLocationUpdatesAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDesiredAccuracy = "desiredAccuracy";

	private static readonly IntPtr selDesiredAccuracyHandle = Selector.GetHandle("desiredAccuracy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistanceFilter = "distanceFilter";

	private static readonly IntPtr selDistanceFilterHandle = Selector.GetHandle("distanceFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeadingAvailable = "headingAvailable";

	private static readonly IntPtr selHeadingAvailableHandle = Selector.GetHandle("headingAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMonitoringAvailableForClass_ = "isMonitoringAvailableForClass:";

	private static readonly IntPtr selIsMonitoringAvailableForClass_Handle = Selector.GetHandle("isMonitoringAvailableForClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocation = "location";

	private static readonly IntPtr selLocationHandle = Selector.GetHandle("location");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocationServicesEnabled = "locationServicesEnabled";

	private static readonly IntPtr selLocationServicesEnabledHandle = Selector.GetHandle("locationServicesEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumRegionMonitoringDistance = "maximumRegionMonitoringDistance";

	private static readonly IntPtr selMaximumRegionMonitoringDistanceHandle = Selector.GetHandle("maximumRegionMonitoringDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMonitoredRegions = "monitoredRegions";

	private static readonly IntPtr selMonitoredRegionsHandle = Selector.GetHandle("monitoredRegions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPurpose = "purpose";

	private static readonly IntPtr selPurposeHandle = Selector.GetHandle("purpose");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegionMonitoringAvailable = "regionMonitoringAvailable";

	private static readonly IntPtr selRegionMonitoringAvailableHandle = Selector.GetHandle("regionMonitoringAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegionMonitoringEnabled = "regionMonitoringEnabled";

	private static readonly IntPtr selRegionMonitoringEnabledHandle = Selector.GetHandle("regionMonitoringEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAlwaysAuthorization = "requestAlwaysAuthorization";

	private static readonly IntPtr selRequestAlwaysAuthorizationHandle = Selector.GetHandle("requestAlwaysAuthorization");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestLocation = "requestLocation";

	private static readonly IntPtr selRequestLocationHandle = Selector.GetHandle("requestLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestStateForRegion_ = "requestStateForRegion:";

	private static readonly IntPtr selRequestStateForRegion_Handle = Selector.GetHandle("requestStateForRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDesiredAccuracy_ = "setDesiredAccuracy:";

	private static readonly IntPtr selSetDesiredAccuracy_Handle = Selector.GetHandle("setDesiredAccuracy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDistanceFilter_ = "setDistanceFilter:";

	private static readonly IntPtr selSetDistanceFilter_Handle = Selector.GetHandle("setDistanceFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPurpose_ = "setPurpose:";

	private static readonly IntPtr selSetPurpose_Handle = Selector.GetHandle("setPurpose:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSignificantLocationChangeMonitoringAvailable = "significantLocationChangeMonitoringAvailable";

	private static readonly IntPtr selSignificantLocationChangeMonitoringAvailableHandle = Selector.GetHandle("significantLocationChangeMonitoringAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartMonitoringForRegion_ = "startMonitoringForRegion:";

	private static readonly IntPtr selStartMonitoringForRegion_Handle = Selector.GetHandle("startMonitoringForRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartMonitoringSignificantLocationChanges = "startMonitoringSignificantLocationChanges";

	private static readonly IntPtr selStartMonitoringSignificantLocationChangesHandle = Selector.GetHandle("startMonitoringSignificantLocationChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartUpdatingLocation = "startUpdatingLocation";

	private static readonly IntPtr selStartUpdatingLocationHandle = Selector.GetHandle("startUpdatingLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopMonitoringForRegion_ = "stopMonitoringForRegion:";

	private static readonly IntPtr selStopMonitoringForRegion_Handle = Selector.GetHandle("stopMonitoringForRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopMonitoringSignificantLocationChanges = "stopMonitoringSignificantLocationChanges";

	private static readonly IntPtr selStopMonitoringSignificantLocationChangesHandle = Selector.GetHandle("stopMonitoringSignificantLocationChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopUpdatingLocation = "stopUpdatingLocation";

	private static readonly IntPtr selStopUpdatingLocationHandle = Selector.GetHandle("stopUpdatingLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CLLocationManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Not used anymore. It will always return 'false'.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Not used anymore. It will always return 'false'.")]
	public static bool DeferredLocationUpdatesAvailable
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Not used anymore. It will always return 'false'.")]
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Not used anymore. It will always return 'false'.")]
		[Export("deferredLocationUpdatesAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selDeferredLocationUpdatesAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ICLLocationManagerDelegate Delegate
	{
		get
		{
			return WeakDelegate as ICLLocationManagerDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DesiredAccuracy
	{
		[Export("desiredAccuracy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDesiredAccuracyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDesiredAccuracyHandle);
		}
		[Export("setDesiredAccuracy:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDesiredAccuracy_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDesiredAccuracy_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DistanceFilter
	{
		[Export("distanceFilter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDistanceFilterHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDistanceFilterHandle);
		}
		[Export("setDistanceFilter:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDistanceFilter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDistanceFilter_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public static bool HeadingAvailable
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("headingAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selHeadingAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocation? Location
	{
		[Export("location", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocationHandle));
			}
			return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool LocationServicesEnabled
	{
		[Export("locationServicesEnabled")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selLocationServicesEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual double MaximumRegionMonitoringDistance
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("maximumRegionMonitoringDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMaximumRegionMonitoringDistanceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMaximumRegionMonitoringDistanceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual NSSet MonitoredRegions
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("monitoredRegions", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selMonitoredRegionsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMonitoredRegionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
	public virtual string? Purpose
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("purpose")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPurposeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPurposeHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("setPurpose:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPurpose_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPurpose_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'IsMonitoringAvailable' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'IsMonitoringAvailable' instead.")]
	public static bool RegionMonitoringAvailable
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'IsMonitoringAvailable' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'IsMonitoringAvailable' instead.")]
		[Export("regionMonitoringAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selRegionMonitoringAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'IsMonitoringAvailable' and 'AuthorizationStatus' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'IsMonitoringAvailable' and 'AuthorizationStatus' instead.")]
	public static bool RegionMonitoringEnabled
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'IsMonitoringAvailable' and 'AuthorizationStatus' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'IsMonitoringAvailable' and 'AuthorizationStatus' instead.")]
		[Export("regionMonitoringEnabled")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selRegionMonitoringEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static bool SignificantLocationChangeMonitoringAvailable
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("significantLocationChangeMonitoringAvailable")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selSignificantLocationChangeMonitoringAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CLAuthorizationStatus Status
	{
		[Export("authorizationStatus")]
		get
		{
			return (CLAuthorizationStatus)Messaging.UInt32_objc_msgSend(class_ptr, selAuthorizationStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("CLTimeIntervalMax", "CoreLocation")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static double MaxTimeInterval
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetDouble(Libraries.CoreLocation.Handle, "CLTimeIntervalMax");
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_CLLocationManagerDelegate);

	public CLLocationManagerEventArgs? ShouldDisplayHeadingCalibration
	{
		get
		{
			return EnsureCLLocationManagerDelegate().shouldDisplayHeadingCalibration;
		}
		set
		{
			EnsureCLLocationManagerDelegate().shouldDisplayHeadingCalibration = value;
		}
	}

	public event EventHandler<CLAuthorizationChangedEventArgs> AuthorizationChanged
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.authorizationChanged = (EventHandler<CLAuthorizationChangedEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.authorizationChanged, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.authorizationChanged = (EventHandler<CLAuthorizationChangedEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.authorizationChanged, value);
		}
	}

	public event EventHandler<NSErrorEventArgs> DeferredUpdatesFinished
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.deferredUpdatesFinished = (EventHandler<NSErrorEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.deferredUpdatesFinished, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.deferredUpdatesFinished = (EventHandler<NSErrorEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.deferredUpdatesFinished, value);
		}
	}

	public event EventHandler<CLRegionStateDeterminedEventArgs> DidDetermineState
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.didDetermineState = (EventHandler<CLRegionStateDeterminedEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.didDetermineState, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.didDetermineState = (EventHandler<CLRegionStateDeterminedEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.didDetermineState, value);
		}
	}

	public event EventHandler<CLRegionEventArgs> DidStartMonitoringForRegion
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.didStartMonitoringForRegion = (EventHandler<CLRegionEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.didStartMonitoringForRegion, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.didStartMonitoringForRegion = (EventHandler<CLRegionEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.didStartMonitoringForRegion, value);
		}
	}

	public event EventHandler<NSErrorEventArgs> Failed
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.failed = (EventHandler<NSErrorEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.failed, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.failed = (EventHandler<NSErrorEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.failed, value);
		}
	}

	public event EventHandler LocationUpdatesPaused
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.locationUpdatesPaused = (EventHandler)System.Delegate.Combine(cLLocationManagerDelegate.locationUpdatesPaused, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.locationUpdatesPaused = (EventHandler)System.Delegate.Remove(cLLocationManagerDelegate.locationUpdatesPaused, value);
		}
	}

	public event EventHandler LocationUpdatesResumed
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.locationUpdatesResumed = (EventHandler)System.Delegate.Combine(cLLocationManagerDelegate.locationUpdatesResumed, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.locationUpdatesResumed = (EventHandler)System.Delegate.Remove(cLLocationManagerDelegate.locationUpdatesResumed, value);
		}
	}

	public event EventHandler<CLLocationsUpdatedEventArgs> LocationsUpdated
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.locationsUpdated = (EventHandler<CLLocationsUpdatedEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.locationsUpdated, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.locationsUpdated = (EventHandler<CLLocationsUpdatedEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.locationsUpdated, value);
		}
	}

	public event EventHandler<CLRegionErrorEventArgs> MonitoringFailed
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.monitoringFailed = (EventHandler<CLRegionErrorEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.monitoringFailed, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.monitoringFailed = (EventHandler<CLRegionErrorEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.monitoringFailed, value);
		}
	}

	public event EventHandler<CLRegionEventArgs> RegionEntered
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.regionEntered = (EventHandler<CLRegionEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.regionEntered, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.regionEntered = (EventHandler<CLRegionEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.regionEntered, value);
		}
	}

	public event EventHandler<CLRegionEventArgs> RegionLeft
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.regionLeft = (EventHandler<CLRegionEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.regionLeft, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.regionLeft = (EventHandler<CLRegionEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.regionLeft, value);
		}
	}

	public event EventHandler<CLLocationUpdatedEventArgs> UpdatedLocation
	{
		add
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.updatedLocation = (EventHandler<CLLocationUpdatedEventArgs>)System.Delegate.Combine(cLLocationManagerDelegate.updatedLocation, value);
		}
		remove
		{
			_CLLocationManagerDelegate cLLocationManagerDelegate = EnsureCLLocationManagerDelegate();
			cLLocationManagerDelegate.updatedLocation = (EventHandler<CLLocationUpdatedEventArgs>)System.Delegate.Remove(cLLocationManagerDelegate.updatedLocation, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CLLocationManager()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CLLocationManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CLLocationManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isMonitoringAvailableForClass:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsMonitoringAvailable(Class regionClass)
	{
		if (regionClass == null)
		{
			throw new ArgumentNullException("regionClass");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selIsMonitoringAvailableForClass_Handle, regionClass.Handle);
	}

	[Export("requestAlwaysAuthorization")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestAlwaysAuthorization()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestAlwaysAuthorizationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestAlwaysAuthorizationHandle);
		}
	}

	[Export("requestLocation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestLocation()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestLocationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestLocationHandle);
		}
	}

	[Export("requestStateForRegion:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestState(CLRegion region)
	{
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRequestStateForRegion_Handle, region.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRequestStateForRegion_Handle, region.Handle);
		}
	}

	[Export("startMonitoringForRegion:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartMonitoring(CLRegion region)
	{
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartMonitoringForRegion_Handle, region.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartMonitoringForRegion_Handle, region.Handle);
		}
	}

	[Export("startMonitoringSignificantLocationChanges")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartMonitoringSignificantLocationChanges()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartMonitoringSignificantLocationChangesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartMonitoringSignificantLocationChangesHandle);
		}
	}

	[Export("startUpdatingLocation")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartUpdatingLocation()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartUpdatingLocationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartUpdatingLocationHandle);
		}
	}

	[Export("stopMonitoringForRegion:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopMonitoring(CLRegion region)
	{
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopMonitoringForRegion_Handle, region.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopMonitoringForRegion_Handle, region.Handle);
		}
	}

	[Export("stopMonitoringSignificantLocationChanges")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopMonitoringSignificantLocationChanges()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopMonitoringSignificantLocationChangesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopMonitoringSignificantLocationChangesHandle);
		}
	}

	[Export("stopUpdatingLocation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopUpdatingLocation()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopUpdatingLocationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopUpdatingLocationHandle);
		}
	}

	internal virtual _CLLocationManagerDelegate CreateInternalEventDelegateType()
	{
		return new _CLLocationManagerDelegate();
	}

	internal _CLLocationManagerDelegate EnsureCLLocationManagerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_CLLocationManagerDelegate cLLocationManagerDelegate = Delegate as _CLLocationManagerDelegate;
		if (cLLocationManagerDelegate == null)
		{
			cLLocationManagerDelegate = (_CLLocationManagerDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return cLLocationManagerDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
