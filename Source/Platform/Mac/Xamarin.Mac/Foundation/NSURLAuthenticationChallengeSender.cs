using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSURLAuthenticationChallengeSender")]
[Register("NSURLAuthenticationChallengeSender", false)]
[Model]
public abstract class NSURLAuthenticationChallengeSender : NSObject, INSURLAuthenticationChallengeSender, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSURLAuthenticationChallengeSender()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSURLAuthenticationChallengeSender(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSURLAuthenticationChallengeSender(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("cancelAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void CancelAuthenticationChallenge(NSUrlAuthenticationChallenge challenge);

	[Export("continueWithoutCredentialForAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void ContinueWithoutCredential(NSUrlAuthenticationChallenge challenge);

	[Export("performDefaultHandlingForAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformDefaultHandling(NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("rejectProtectionSpaceAndContinueWithChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RejectProtectionSpaceAndContinue(NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("useCredential:forAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void UseCredential(NSUrlCredential credential, NSUrlAuthenticationChallenge challenge);
}
