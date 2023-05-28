using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

internal sealed class ASAuthorizationControllerDelegateWrapper : BaseWrapper, IASAuthorizationControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ASAuthorizationControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
