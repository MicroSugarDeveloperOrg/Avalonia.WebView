using System;
using Foundation;
using ObjCRuntime;

namespace SafariServices;

internal sealed class SFSafariExtensionHandlingWrapper : BaseWrapper, ISFSafariExtensionHandling, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SFSafariExtensionHandlingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
