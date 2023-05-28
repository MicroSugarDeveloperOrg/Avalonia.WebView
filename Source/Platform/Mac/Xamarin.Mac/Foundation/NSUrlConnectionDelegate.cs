using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSURLConnectionDelegate", false)]
[Model]
public class NSUrlConnectionDelegate : NSObject, INSUrlConnectionDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlConnectionDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlConnectionDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlConnectionDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("connection:canAuthenticateAgainstProtectionSpace:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanAuthenticateAgainstProtectionSpace(NSUrlConnection connection, NSUrlProtectionSpace protectionSpace)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didCancelAuthenticationChallenge:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CanceledAuthenticationChallenge(NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connectionShouldUseCredentialStorage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ConnectionShouldUseCredentialStorage(NSUrlConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FailedWithError(NSUrlConnection connection, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didReceiveAuthenticationChallenge:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedAuthenticationChallenge(NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:willSendRequestForAuthenticationChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillSendRequestForAuthenticationChallenge(NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
