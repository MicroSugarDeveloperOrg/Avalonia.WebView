using System;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

internal sealed class CLLocationManagerDelegateWrapper : BaseWrapper, ICLLocationManagerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CLLocationManagerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
