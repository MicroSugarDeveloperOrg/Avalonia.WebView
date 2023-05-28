using System;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Security;

namespace NetworkExtension;

public static class NWTcpConnectionAuthenticationDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldProvideIdentity(this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("shouldProvideIdentityForConnection:"), connection.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ProvideIdentity(this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection, [BlockProxy(typeof(Trampolines.NIDActionArity2V76))] Action<SecIdentity, NSArray> completion)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V76.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("provideIdentityForConnection:completionHandler:"), connection.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldEvaluateTrust(this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("shouldEvaluateTrustForConnection:"), connection.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void EvaluateTrust(this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection, NSArray peerCertificateChain, [BlockProxy(typeof(Trampolines.NIDActionArity1V68))] Action<SecTrust> completion)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (peerCertificateChain == null)
		{
			throw new ArgumentNullException("peerCertificateChain");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V68.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("evaluateTrustForConnection:peerCertificateChain:completionHandler:"), connection.Handle, peerCertificateChain.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<SecTrust> EvaluateTrustAsync(this INWTcpConnectionAuthenticationDelegate This, NWTcpConnection connection, NSArray peerCertificateChain)
	{
		TaskCompletionSource<SecTrust> tcs = new TaskCompletionSource<SecTrust>();
		This.EvaluateTrust(connection, peerCertificateChain, delegate(SecTrust obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}
}
