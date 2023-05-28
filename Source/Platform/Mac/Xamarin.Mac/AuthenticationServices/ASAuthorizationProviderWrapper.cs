using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

internal sealed class ASAuthorizationProviderWrapper : BaseWrapper, IASAuthorizationProvider, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ASAuthorizationProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
