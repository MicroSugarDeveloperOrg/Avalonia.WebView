using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

internal sealed class MKMapViewDelegateWrapper : BaseWrapper, IMKMapViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MKMapViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
