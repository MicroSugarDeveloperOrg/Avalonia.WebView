using System;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

internal sealed class NWTcpConnectionAuthenticationDelegateWrapper : BaseWrapper, INWTcpConnectionAuthenticationDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NWTcpConnectionAuthenticationDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
