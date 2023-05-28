using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

internal sealed class ASWebAuthenticationSessionRequestDelegateWrapper : BaseWrapper, IASWebAuthenticationSessionRequestDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ASWebAuthenticationSessionRequestDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
