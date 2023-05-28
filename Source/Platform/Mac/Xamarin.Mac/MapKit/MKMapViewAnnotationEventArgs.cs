using System;

namespace MapKit;

public class MKMapViewAnnotationEventArgs : EventArgs
{
	public MKAnnotationView[] Views { get; set; }

	public MKMapViewAnnotationEventArgs(MKAnnotationView[] views)
	{
		Views = views;
	}
}
