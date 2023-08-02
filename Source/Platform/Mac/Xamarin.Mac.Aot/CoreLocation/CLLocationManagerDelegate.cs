using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

[Register("CLLocationManagerDelegate", false)]
[Model]
public class CLLocationManagerDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CLLocationManagerDelegate()
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
	public CLLocationManagerDelegate(NSCoder coder)
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
	public CLLocationManagerDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CLLocationManagerDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("locationManager:didUpdateToLocation:fromLocation:")]
	[Obsolete("Deprecated in iOS 6.0", false)]
	public virtual void UpdatedLocation(CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManagerShouldDisplayHeadingCalibration:")]
	public virtual bool ShouldDisplayHeadingCalibration(CLLocationManager manager)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didFailWithError:")]
	public virtual void Failed(CLLocationManager manager, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didChangeAuthorizationStatus:")]
	public virtual void AuthorizationChanged(CLLocationManager manager, CLAuthorizationStatus status)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didUpdateLocations:")]
	public virtual void LocationsUpdated(CLLocationManager manager, CLLocation[] locations)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManagerDidPauseLocationUpdates:")]
	public virtual void LocationUpdatesPaused(CLLocationManager manager)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManagerDidResumeLocationUpdates:")]
	public virtual void LocationUpdatesResumed(CLLocationManager manager)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("locationManager:didFinishDeferredUpdatesWithError:")]
	public virtual void DeferredUpdatesFinished(CLLocationManager manager, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
