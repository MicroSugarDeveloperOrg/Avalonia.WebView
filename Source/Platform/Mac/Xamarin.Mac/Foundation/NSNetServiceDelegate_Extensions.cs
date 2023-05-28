using System;
using ObjCRuntime;

namespace Foundation;

public static class NSNetServiceDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillPublish(this INSNetServiceDelegate This, NSNetService sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("netServiceWillPublish:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Published(this INSNetServiceDelegate This, NSNetService sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("netServiceDidPublish:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PublishFailure(this INSNetServiceDelegate This, NSNetService sender, NSDictionary errors)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (errors == null)
		{
			throw new ArgumentNullException("errors");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("netService:didNotPublish:"), sender.Handle, errors.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillResolve(this INSNetServiceDelegate This, NSNetService sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("netServiceWillResolve:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AddressResolved(this INSNetServiceDelegate This, NSNetService sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("netServiceDidResolveAddress:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ResolveFailure(this INSNetServiceDelegate This, NSNetService sender, NSDictionary errors)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (errors == null)
		{
			throw new ArgumentNullException("errors");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("netService:didNotResolve:"), sender.Handle, errors.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Stopped(this INSNetServiceDelegate This, NSNetService sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("netServiceDidStop:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdatedTxtRecordData(this INSNetServiceDelegate This, NSNetService sender, NSData data)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("netService:didUpdateTXTRecordData:"), sender.Handle, data.Handle);
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidAcceptConnection(this INSNetServiceDelegate This, NSNetService sender, NSInputStream inputStream, NSOutputStream outputStream)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (inputStream == null)
		{
			throw new ArgumentNullException("inputStream");
		}
		if (outputStream == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("netService:didAcceptConnectionWithInputStream:outputStream:"), sender.Handle, inputStream.Handle, outputStream.Handle);
	}
}
