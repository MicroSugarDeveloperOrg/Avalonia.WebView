using System;
using ObjCRuntime;

namespace Foundation;

public static class NSNetServiceBrowserDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SearchStarted(this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("netServiceBrowserWillSearch:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SearchStopped(this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("netServiceBrowserDidStopSearch:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void NotSearched(this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, NSDictionary errors)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (errors == null)
		{
			throw new ArgumentNullException("errors");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("netServiceBrowser:didNotSearch:"), sender.Handle, errors.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FoundDomain(this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, string domain, bool moreComing)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		IntPtr intPtr = NSString.CreateNative(domain);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("netServiceBrowser:didFindDomain:moreComing:"), sender.Handle, intPtr, moreComing);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FoundService(this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, NSNetService service, bool moreComing)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("netServiceBrowser:didFindService:moreComing:"), sender.Handle, service.Handle, moreComing);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DomainRemoved(this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, string domain, bool moreComing)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		IntPtr intPtr = NSString.CreateNative(domain);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("netServiceBrowser:didRemoveDomain:moreComing:"), sender.Handle, intPtr, moreComing);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ServiceRemoved(this INSNetServiceBrowserDelegate This, NSNetServiceBrowser sender, NSNetService service, bool moreComing)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("netServiceBrowser:didRemoveService:moreComing:"), sender.Handle, service.Handle, moreComing);
	}
}
