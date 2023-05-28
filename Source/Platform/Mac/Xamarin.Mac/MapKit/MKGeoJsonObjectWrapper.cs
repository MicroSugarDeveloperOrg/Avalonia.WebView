using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

internal sealed class MKGeoJsonObjectWrapper : BaseWrapper, IMKGeoJsonObject, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MKGeoJsonObjectWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
