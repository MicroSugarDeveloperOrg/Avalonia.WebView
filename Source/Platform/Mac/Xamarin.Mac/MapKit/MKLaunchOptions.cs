using CoreLocation;
using Foundation;

namespace MapKit;

public class MKLaunchOptions
{
	public MKDirectionsMode? DirectionsMode { get; set; }

	public MKMapType? MapType { get; set; }

	public CLLocationCoordinate2D? MapCenter { get; set; }

	public MKCoordinateSpan? MapSpan { get; set; }

	public bool? ShowTraffic { get; set; }

	[iOS(7, 0)]
	public MKMapCamera Camera { get; set; }

	internal NSDictionary ToDictionary()
	{
		int num = 0;
		if (DirectionsMode.HasValue)
		{
			num++;
		}
		if (MapType.HasValue)
		{
			num++;
		}
		if (MapCenter.HasValue)
		{
			num++;
		}
		if (MapSpan.HasValue)
		{
			num++;
		}
		if (ShowTraffic.HasValue)
		{
			num++;
		}
		if (Camera != null)
		{
			num++;
		}
		if (num == 0)
		{
			return null;
		}
		NSObject[] array = new NSObject[num];
		NSObject[] array2 = new NSObject[num];
		int num2 = 0;
		if (DirectionsMode.HasValue)
		{
			array[num2] = MKMapItem.MKLaunchOptionsDirectionsModeKey;
			NSString nSString = MKMapItem.MKLaunchOptionsDirectionsModeDriving;
			switch (DirectionsMode.Value)
			{
			case MKDirectionsMode.Driving:
				nSString = MKMapItem.MKLaunchOptionsDirectionsModeDriving;
				break;
			case MKDirectionsMode.Transit:
				nSString = MKMapItem.MKLaunchOptionsDirectionsModeTransit;
				break;
			case MKDirectionsMode.Walking:
				nSString = MKMapItem.MKLaunchOptionsDirectionsModeWalking;
				break;
			case MKDirectionsMode.Default:
				nSString = MKMapItem.MKLaunchOptionsDirectionsModeDefault;
				break;
			}
			array2[num2++] = nSString;
		}
		if (MapType.HasValue)
		{
			array[num2] = MKMapItem.MKLaunchOptionsMapTypeKey;
			array2[num2++] = new NSNumber((int)MapType.Value);
		}
		if (MapCenter.HasValue)
		{
			array[num2] = MKMapItem.MKLaunchOptionsMapCenterKey;
			array2[num2++] = NSValue.FromMKCoordinate(MapCenter.Value);
		}
		if (MapSpan.HasValue)
		{
			array[num2] = MKMapItem.MKLaunchOptionsMapSpanKey;
			array2[num2++] = NSValue.FromMKCoordinateSpan(MapSpan.Value);
		}
		if (ShowTraffic.HasValue)
		{
			array[num2] = MKMapItem.MKLaunchOptionsShowsTrafficKey;
			array2[num2++] = new NSNumber(ShowTraffic.Value);
		}
		if (Camera != null)
		{
			array[num2] = MKMapItem.MKLaunchOptionsCameraKey;
			array2[num2++] = Camera;
		}
		return NSDictionary.FromObjectsAndKeys(array2, array);
	}
}
