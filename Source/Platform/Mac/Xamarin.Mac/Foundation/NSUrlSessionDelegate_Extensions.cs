using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlSessionDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBecomeInvalid(this INSUrlSessionDelegate This, NSUrlSession session, NSError error)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:didBecomeInvalidWithError:"), session.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DidReceiveChallenge(this INSUrlSessionDelegate This, NSUrlSession session, NSUrlAuthenticationChallenge challenge, [BlockProxy(typeof(Trampolines.NIDActionArity2V44))] Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V44.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:didReceiveChallenge:completionHandler:"), session.Handle, challenge.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishEventsForBackgroundSession(this INSUrlSessionDelegate This, NSUrlSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("URLSessionDidFinishEventsForBackgroundURLSession:"), session.Handle);
	}
}
