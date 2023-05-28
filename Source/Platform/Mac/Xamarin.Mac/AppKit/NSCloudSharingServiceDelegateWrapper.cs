using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCloudSharingServiceDelegateWrapper : BaseWrapper, INSCloudSharingServiceDelegate, INativeObject, IDisposable, INSSharingServiceDelegate
{
	[Preserve(Conditional = true)]
	public NSCloudSharingServiceDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
