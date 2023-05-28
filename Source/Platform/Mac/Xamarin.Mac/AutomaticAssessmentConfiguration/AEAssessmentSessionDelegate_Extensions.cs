using System;
using Foundation;
using ObjCRuntime;

namespace AutomaticAssessmentConfiguration;

[Advice("This API is not available when using UIKit on macOS.")]
public static class AEAssessmentSessionDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBegin(this IAEAssessmentSessionDelegate This, AEAssessmentSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("assessmentSessionDidBegin:"), session.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedToBegin(this IAEAssessmentSessionDelegate This, AEAssessmentSession session, NSError error)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("assessmentSession:failedToBeginWithError:"), session.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WasInterrupted(this IAEAssessmentSessionDelegate This, AEAssessmentSession session, NSError error)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("assessmentSession:wasInterruptedWithError:"), session.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEnd(this IAEAssessmentSessionDelegate This, AEAssessmentSession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("assessmentSessionDidEnd:"), session.Handle);
	}
}
