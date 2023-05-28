using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

internal sealed class MKLocalSearchCompleterDelegateWrapper : BaseWrapper, IMKLocalSearchCompleterDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MKLocalSearchCompleterDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
