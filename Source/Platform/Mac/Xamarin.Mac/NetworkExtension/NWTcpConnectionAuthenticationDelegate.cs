using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Security;

namespace NetworkExtension;

[Protocol]
[Register("NWTCPConnectionAuthenticationDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NWTcpConnectionAuthenticationDelegate : NSObject, INWTcpConnectionAuthenticationDelegate, INativeObject, IDisposable
{
	[Obsolete("Use 'NWTcpConnectionAuthenticationDelegate_Extensions.EvaluateTrustAsync' instead.")]
	public virtual Task<SecTrust> EvaluateTrustAsync(NWTcpConnection connection, NSArray peerCertificateChain)
	{
		return NWTcpConnectionAuthenticationDelegate_Extensions.EvaluateTrustAsync(this, connection, peerCertificateChain);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NWTcpConnectionAuthenticationDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NWTcpConnectionAuthenticationDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NWTcpConnectionAuthenticationDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("evaluateTrustForConnection:peerCertificateChain:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EvaluateTrust(NWTcpConnection connection, NSArray peerCertificateChain, [BlockProxy(typeof(Trampolines.NIDActionArity1V68))] Action<SecTrust> completion)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("provideIdentityForConnection:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ProvideIdentity(NWTcpConnection connection, [BlockProxy(typeof(Trampolines.NIDActionArity2V76))] Action<SecIdentity, NSArray> completion)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("shouldEvaluateTrustForConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEvaluateTrust(NWTcpConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("shouldProvideIdentityForConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldProvideIdentity(NWTcpConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
