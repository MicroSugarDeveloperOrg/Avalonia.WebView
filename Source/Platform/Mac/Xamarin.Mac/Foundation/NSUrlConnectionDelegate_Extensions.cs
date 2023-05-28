using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlConnectionDelegate_Extensions
{
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanAuthenticateAgainstProtectionSpace(this INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlProtectionSpace protectionSpace)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (protectionSpace == null)
		{
			throw new ArgumentNullException("protectionSpace");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:canAuthenticateAgainstProtectionSpace:"), connection.Handle, protectionSpace.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedAuthenticationChallenge(this INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:didReceiveAuthenticationChallenge:"), connection.Handle, challenge.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use 'WillSendRequestForAuthenticationChallenge' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CanceledAuthenticationChallenge(this INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:didCancelAuthenticationChallenge:"), connection.Handle, challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ConnectionShouldUseCredentialStorage(this INSUrlConnectionDelegate This, NSUrlConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("connectionShouldUseCredentialStorage:"), connection.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedWithError(this INSUrlConnectionDelegate This, NSUrlConnection connection, NSError error)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:didFailWithError:"), connection.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillSendRequestForAuthenticationChallenge(this INSUrlConnectionDelegate This, NSUrlConnection connection, NSUrlAuthenticationChallenge challenge)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:willSendRequestForAuthenticationChallenge:"), connection.Handle, challenge.Handle);
	}
}
