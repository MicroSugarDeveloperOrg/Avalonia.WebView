using System;

namespace MapKit;

public class MKUserLocationEventArgs : EventArgs
{
	public MKUserLocation UserLocation { get; set; }

	public MKUserLocationEventArgs(MKUserLocation userLocation)
	{
		UserLocation = userLocation;
	}
}
