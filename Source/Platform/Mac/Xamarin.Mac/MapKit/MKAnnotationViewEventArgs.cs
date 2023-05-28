using System;

namespace MapKit;

public class MKAnnotationViewEventArgs : EventArgs
{
	public MKAnnotationView View { get; set; }

	public MKAnnotationViewEventArgs(MKAnnotationView view)
	{
		View = view;
	}
}
