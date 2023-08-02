using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

[Register("CLLocationManager", true)]
public class CLLocationManager : NSObject
{
	[Register]
	private sealed class _CLLocationManagerDelegate : CLLocationManagerDelegate
	{
		internal EventHandler<CLLocationUpdatedEventArgs> updatedLocation;

		internal CLLocationManagerEventArgs shouldDisplayHeadingCalibration;

		internal EventHandler<NSErrorEventArgs> failed;

		internal EventHandler<CLAuthorizationChangedEventArgs> authorizationChanged;

		internal EventHandler<CLLocationsUpdatedEventArgs> locationsUpdated;

		internal EventHandler locationUpdatesPaused;

		internal EventHandler locationUpdatesResumed;

		internal EventHandler<NSErrorEventArgs> deferredUpdatesFinished;

		[Preserve(Conditional = true)]
		public override void UpdatedLocation(CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
		{
			EventHandler<CLLocationUpdatedEventArgs> eventHandler = updatedLocation;
			if (eventHandler != null)
			{
				CLLocationUpdatedEventArgs e = new CLLocationUpdatedEventArgs(newLocation, oldLocation);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool ShouldDisplayHeadingCalibration(CLLocationManager manager)
		{
			return shouldDisplayHeadingCalibration?.Invoke(manager) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void Failed(CLLocationManager manager, NSError error)
		{
			EventHandler<NSErrorEventArgs> eventHandler = failed;
			if (eventHandler != null)
			{
				NSErrorEventArgs e = new NSErrorEventArgs(error);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void AuthorizationChanged(CLLocationManager manager, CLAuthorizationStatus status)
		{
			EventHandler<CLAuthorizationChangedEventArgs> eventHandler = authorizationChanged;
			if (eventHandler != null)
			{
				CLAuthorizationChangedEventArgs e = new CLAuthorizationChangedEventArgs(status);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void LocationsUpdated(CLLocationManager manager, CLLocation[] locations)
		{
			EventHandler<CLLocationsUpdatedEventArgs> eventHandler = locationsUpdated;
			if (eventHandler != null)
			{
				CLLocationsUpdatedEventArgs e = new CLLocationsUpdatedEventArgs(locations);
				eventHandler(manager, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void LocationUpdatesPaused(CLLocationManager manager)
		{
			locationUpdatesPaused?.Invoke(manager, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void LocationUpdatesResumed(CLLocationManager manager)
		{
			locationUpdatesResumed?.Invoke(manager, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DeferredUpdatesFinished(CLLocationManager manager, NSError error)
		{
			EventHandler<NSErrorEventArgs> eventHandler = deferredUpdatesFinished;
			if (eventHandler != null)
			{
				NSErrorEventArgs e = new NSErrorEventArgs(error);
				eventHandler(manager, e);
			}
		}
	}

	private const bool use_static_variants = true;

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selLocationServicesEnabledHandle = Selector.GetHandle("locationServicesEnabled");

	private static readonly IntPtr selDistanceFilterHandle = Selector.GetHandle("distanceFilter");

	private static readonly IntPtr selSetDistanceFilter_Handle = Selector.GetHandle("setDistanceFilter:");

	private static readonly IntPtr selDesiredAccuracyHandle = Selector.GetHandle("desiredAccuracy");

	private static readonly IntPtr selSetDesiredAccuracy_Handle = Selector.GetHandle("setDesiredAccuracy:");

	private static readonly IntPtr selLocationHandle = Selector.GetHandle("location");

	private static readonly IntPtr selStartUpdatingLocationHandle = Selector.GetHandle("startUpdatingLocation");

	private static readonly IntPtr selStopUpdatingLocationHandle = Selector.GetHandle("stopUpdatingLocation");

	private static readonly IntPtr class_ptr = Class.GetHandle("CLLocationManager");

	private object __mt_WeakDelegate_var;

	private object __mt_Location_var;

	public static bool LocationServicesEnabled => _LocationServicesEnabledStatic;

	public override IntPtr ClassHandle => class_ptr;

	public CLLocationManagerDelegate Delegate
	{
		get
		{
			return WeakDelegate as CLLocationManagerDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual bool _LocationServicesEnabledInstance
	{
		[Export("locationServicesEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLocationServicesEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLocationServicesEnabledHandle);
		}
	}

	public virtual double DistanceFilter
	{
		[Export("distanceFilter", ArgumentSemantic.Assign)]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDistanceFilterHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDistanceFilterHandle);
		}
		[Export("setDistanceFilter:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDistanceFilter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDistanceFilter_Handle, value);
			}
		}
	}

	public virtual double DesiredAccuracy
	{
		[Export("desiredAccuracy", ArgumentSemantic.Assign)]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDesiredAccuracyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDesiredAccuracyHandle);
		}
		[Export("setDesiredAccuracy:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDesiredAccuracy_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDesiredAccuracy_Handle, value);
			}
		}
	}

	public virtual CLLocation Location
	{
		[Export("location")]
		get
		{
			return (CLLocation)(__mt_Location_var = ((!IsDirectBinding) ? ((CLLocation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocationHandle))) : ((CLLocation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLocationHandle)))));
		}
	}

	[Since(4, 0)]
	internal static bool _LocationServicesEnabledStatic
	{
		[Export("locationServicesEnabled")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selLocationServicesEnabledHandle);
		}
	}

	public CLLocationManagerEventArgs ShouldDisplayHeadingCalibration
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

	[Obsolete("Deprecated in iOS 6.0", false)]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CLLocationManager()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CLLocationManager(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CLLocationManager(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CLLocationManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("startUpdatingLocation")]
	public virtual void StartUpdatingLocation()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartUpdatingLocationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartUpdatingLocationHandle);
		}
	}

	[Export("stopUpdatingLocation")]
	public virtual void StopUpdatingLocation()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopUpdatingLocationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopUpdatingLocationHandle);
		}
	}

	private _CLLocationManagerDelegate EnsureCLLocationManagerDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _CLLocationManagerDelegate))
		{
			nSObject = (WeakDelegate = new _CLLocationManagerDelegate());
		}
		return (_CLLocationManagerDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_Location_var = null;
		}
	}
}
