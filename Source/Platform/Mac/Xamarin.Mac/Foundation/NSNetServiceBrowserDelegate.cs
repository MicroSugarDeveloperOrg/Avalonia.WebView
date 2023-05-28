using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSNetServiceBrowserDelegate", false)]
[Model]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class NSNetServiceBrowserDelegate : NSObject, INSNetServiceBrowserDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNetServiceBrowserDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSNetServiceBrowserDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSNetServiceBrowserDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("netServiceBrowser:didRemoveDomain:moreComing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DomainRemoved(NSNetServiceBrowser sender, string domain, bool moreComing)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowser:didFindDomain:moreComing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FoundDomain(NSNetServiceBrowser sender, string domain, bool moreComing)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowser:didFindService:moreComing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FoundService(NSNetServiceBrowser sender, NSNetService service, bool moreComing)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowser:didNotSearch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NotSearched(NSNetServiceBrowser sender, NSDictionary errors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowserWillSearch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SearchStarted(NSNetServiceBrowser sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowserDidStopSearch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SearchStopped(NSNetServiceBrowser sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowser:didRemoveService:moreComing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ServiceRemoved(NSNetServiceBrowser sender, NSNetService service, bool moreComing)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
