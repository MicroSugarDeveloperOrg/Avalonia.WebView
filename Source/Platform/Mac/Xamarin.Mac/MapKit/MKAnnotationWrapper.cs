using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

internal sealed class MKAnnotationWrapper : BaseWrapper, IMKAnnotation, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CLLocationCoordinate2D Coordinate
	{
		[Export("coordinate")]
		get
		{
			return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, Selector.GetHandle("coordinate"));
		}
	}

	[Preserve(Conditional = true)]
	public MKAnnotationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
