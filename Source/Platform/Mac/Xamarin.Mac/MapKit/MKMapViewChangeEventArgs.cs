using System;

namespace MapKit;

public class MKMapViewChangeEventArgs : EventArgs
{
	public bool Animated { get; set; }

	public MKMapViewChangeEventArgs(bool animated)
	{
		Animated = animated;
	}
}
