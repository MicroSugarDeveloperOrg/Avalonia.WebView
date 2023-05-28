using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSURLAuthenticationChallengeSenderWrapper : BaseWrapper, INSURLAuthenticationChallengeSender, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSURLAuthenticationChallengeSenderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("useCredential:forAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void UseCredential(NSUrlCredential credential, NSUrlAuthenticationChallenge challenge)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("useCredential:forAuthenticationChallenge:"), credential.Handle, challenge.Handle);
	}

	[Export("continueWithoutCredentialForAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ContinueWithoutCredential(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("continueWithoutCredentialForAuthenticationChallenge:"), challenge.Handle);
	}

	[Export("cancelAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CancelAuthenticationChallenge(NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("cancelAuthenticationChallenge:"), challenge.Handle);
	}
}
