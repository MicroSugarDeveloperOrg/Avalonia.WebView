using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

internal sealed class MKOverlayWrapper : BaseWrapper, IMKOverlay, INativeObject, IDisposable, IMKAnnotation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKMapRect BoundingMapRect
	{
		[Export("boundingMapRect")]
		get
		{
			Messaging.MKMapRect_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("boundingMapRect"));
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public CLLocationCoordinate2D Coordinate
	{
		[Export("coordinate")]
		get
		{
			return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, Selector.GetHandle("coordinate"));
		}
	}

	[Preserve(Conditional = true)]
	public MKOverlayWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
