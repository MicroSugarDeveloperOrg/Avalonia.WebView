using System;
using ObjCRuntime;

namespace Foundation;

public static class NSURLAuthenticationChallengeSender_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PerformDefaultHandling(this INSURLAuthenticationChallengeSender This, NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("performDefaultHandlingForAuthenticationChallenge:"), challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RejectProtectionSpaceAndContinue(this INSURLAuthenticationChallengeSender This, NSUrlAuthenticationChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("rejectProtectionSpaceAndContinueWithChallenge:"), challenge.Handle);
	}
}
