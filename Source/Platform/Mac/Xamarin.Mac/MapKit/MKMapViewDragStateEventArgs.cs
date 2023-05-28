using System;

namespace MapKit;

public class MKMapViewDragStateEventArgs : EventArgs
{
	public MKAnnotationView AnnotationView { get; set; }

	public MKAnnotationViewDragState NewState { get; set; }

	public MKAnnotationViewDragState OldState { get; set; }

	public MKMapViewDragStateEventArgs(MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
	{
		AnnotationView = annotationView;
		NewState = newState;
		OldState = oldState;
	}
}
