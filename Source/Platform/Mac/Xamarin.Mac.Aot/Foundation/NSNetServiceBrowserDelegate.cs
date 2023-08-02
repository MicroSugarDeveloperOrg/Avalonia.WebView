using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSNetServiceBrowserDelegate", true)]
[Model]
public class NSNetServiceBrowserDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNetServiceBrowserDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSNetServiceBrowserDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNetServiceBrowserDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNetServiceBrowserDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("netServiceBrowserWillSearch:")]
	public virtual void SearchStarted(NSNetServiceBrowser sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowserDidStopSearch:")]
	public virtual void SearchStopped(NSNetServiceBrowser sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowser:didNotSearch:")]
	public virtual void NotSearched(NSNetServiceBrowser sender, NSDictionary errors)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowser:didFindDomain:moreComing:")]
	public virtual void FoundDomain(NSNetServiceBrowser sender, string domain, bool moreComing)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowser:didFindService:moreComing:")]
	public virtual void FoundService(NSNetServiceBrowser sender, NSNetService service, bool moreComing)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowser:didRemoveDomain:moreComing:")]
	public virtual void DomainRemoved(NSNetServiceBrowser sender, string domain, bool moreComing)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("netServiceBrowser:didRemoveService:moreComing:")]
	public virtual void ServiceRemoved(NSNetServiceBrowser sender, NSNetService service, bool moreComing)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
