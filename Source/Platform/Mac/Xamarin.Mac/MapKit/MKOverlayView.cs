using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace MapKit;

public class MKOverlayView
{
	[DllImport("/System/Library/Frameworks/MapKit.framework/MapKit")]
	[TV(9, 2)]
	[Mac(10, 9)]
	public static extern nfloat MKRoadWidthAtZoomScale(nfloat zoomScale);
}
