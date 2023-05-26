using System;

namespace CoreLocation;

public class CLLocationUpdatedEventArgs : EventArgs
{
	public CLLocation NewLocation { get; set; }

	public CLLocation OldLocation { get; set; }

	public CLLocationUpdatedEventArgs(CLLocation newLocation, CLLocation oldLocation)
	{
		NewLocation = newLocation;
		OldLocation = oldLocation;
	}
}
