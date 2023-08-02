using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNetServiceBrowser", true)]
public class NSNetServiceBrowser : NSObject
{
	[Register]
	private sealed class _NSNetServiceBrowserDelegate : NSNetServiceBrowserDelegate
	{
		internal EventHandler searchStarted;

		internal EventHandler searchStopped;

		internal EventHandler<NSNetServiceErrorEventArgs> notSearched;

		internal EventHandler<NSNetDomainEventArgs> foundDomain;

		internal EventHandler<NSNetServiceEventArgs> foundService;

		internal EventHandler<NSNetDomainEventArgs> domainRemoved;

		internal EventHandler<NSNetServiceEventArgs> serviceRemoved;

		[Preserve(Conditional = true)]
		public override void SearchStarted(NSNetServiceBrowser sender)
		{
			searchStarted?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void SearchStopped(NSNetServiceBrowser sender)
		{
			searchStopped?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void NotSearched(NSNetServiceBrowser sender, NSDictionary errors)
		{
			EventHandler<NSNetServiceErrorEventArgs> eventHandler = notSearched;
			if (eventHandler != null)
			{
				NSNetServiceErrorEventArgs e = new NSNetServiceErrorEventArgs(errors);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void FoundDomain(NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			EventHandler<NSNetDomainEventArgs> eventHandler = foundDomain;
			if (eventHandler != null)
			{
				NSNetDomainEventArgs e = new NSNetDomainEventArgs(domain, moreComing);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void FoundService(NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			EventHandler<NSNetServiceEventArgs> eventHandler = foundService;
			if (eventHandler != null)
			{
				NSNetServiceEventArgs e = new NSNetServiceEventArgs(service, moreComing);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DomainRemoved(NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			EventHandler<NSNetDomainEventArgs> eventHandler = domainRemoved;
			if (eventHandler != null)
			{
				NSNetDomainEventArgs e = new NSNetDomainEventArgs(domain, moreComing);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void ServiceRemoved(NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			EventHandler<NSNetServiceEventArgs> eventHandler = serviceRemoved;
			if (eventHandler != null)
			{
				NSNetServiceEventArgs e = new NSNetServiceEventArgs(service, moreComing);
				eventHandler(sender, e);
			}
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selScheduleInRunLoopForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	private static readonly IntPtr selRemoveFromRunLoopForMode_Handle = Selector.GetHandle("removeFromRunLoop:forMode:");

	private static readonly IntPtr selSearchForBrowsableDomainsHandle = Selector.GetHandle("searchForBrowsableDomains");

	private static readonly IntPtr selSearchForRegistrationDomainsHandle = Selector.GetHandle("searchForRegistrationDomains");

	private static readonly IntPtr selSearchForServicesOfTypeInDomain_Handle = Selector.GetHandle("searchForServicesOfType:inDomain:");

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSNetServiceBrowser");

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSNetServiceBrowserDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSNetServiceBrowserDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public event EventHandler SearchStarted
	{
		add
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.searchStarted = (EventHandler)System.Delegate.Combine(nSNetServiceBrowserDelegate.searchStarted, value);
		}
		remove
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.searchStarted = (EventHandler)System.Delegate.Remove(nSNetServiceBrowserDelegate.searchStarted, value);
		}
	}

	public event EventHandler SearchStopped
	{
		add
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.searchStopped = (EventHandler)System.Delegate.Combine(nSNetServiceBrowserDelegate.searchStopped, value);
		}
		remove
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.searchStopped = (EventHandler)System.Delegate.Remove(nSNetServiceBrowserDelegate.searchStopped, value);
		}
	}

	public event EventHandler<NSNetServiceErrorEventArgs> NotSearched
	{
		add
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.notSearched = (EventHandler<NSNetServiceErrorEventArgs>)System.Delegate.Combine(nSNetServiceBrowserDelegate.notSearched, value);
		}
		remove
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.notSearched = (EventHandler<NSNetServiceErrorEventArgs>)System.Delegate.Remove(nSNetServiceBrowserDelegate.notSearched, value);
		}
	}

	public event EventHandler<NSNetDomainEventArgs> FoundDomain
	{
		add
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.foundDomain = (EventHandler<NSNetDomainEventArgs>)System.Delegate.Combine(nSNetServiceBrowserDelegate.foundDomain, value);
		}
		remove
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.foundDomain = (EventHandler<NSNetDomainEventArgs>)System.Delegate.Remove(nSNetServiceBrowserDelegate.foundDomain, value);
		}
	}

	public event EventHandler<NSNetServiceEventArgs> FoundService
	{
		add
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.foundService = (EventHandler<NSNetServiceEventArgs>)System.Delegate.Combine(nSNetServiceBrowserDelegate.foundService, value);
		}
		remove
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.foundService = (EventHandler<NSNetServiceEventArgs>)System.Delegate.Remove(nSNetServiceBrowserDelegate.foundService, value);
		}
	}

	public event EventHandler<NSNetDomainEventArgs> DomainRemoved
	{
		add
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.domainRemoved = (EventHandler<NSNetDomainEventArgs>)System.Delegate.Combine(nSNetServiceBrowserDelegate.domainRemoved, value);
		}
		remove
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.domainRemoved = (EventHandler<NSNetDomainEventArgs>)System.Delegate.Remove(nSNetServiceBrowserDelegate.domainRemoved, value);
		}
	}

	public event EventHandler<NSNetServiceEventArgs> ServiceRemoved
	{
		add
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.serviceRemoved = (EventHandler<NSNetServiceEventArgs>)System.Delegate.Combine(nSNetServiceBrowserDelegate.serviceRemoved, value);
		}
		remove
		{
			_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = EnsureNSNetServiceBrowserDelegate();
			nSNetServiceBrowserDelegate.serviceRemoved = (EventHandler<NSNetServiceEventArgs>)System.Delegate.Remove(nSNetServiceBrowserDelegate.serviceRemoved, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNetServiceBrowser()
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
	public NSNetServiceBrowser(NSCoder coder)
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
	public NSNetServiceBrowser(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNetServiceBrowser(IntPtr handle)
		: base(handle)
	{
	}

	[Export("scheduleInRunLoop:forMode:")]
	public virtual void Schedule(NSRunLoop aRunLoop, string forMode)
	{
		if (aRunLoop == null)
		{
			throw new ArgumentNullException("aRunLoop");
		}
		if (forMode == null)
		{
			throw new ArgumentNullException("forMode");
		}
		IntPtr arg = NSString.CreateNative(forMode);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selScheduleInRunLoopForMode_Handle, aRunLoop.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScheduleInRunLoopForMode_Handle, aRunLoop.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeFromRunLoop:forMode:")]
	public virtual void Unschedule(NSRunLoop aRunLoop, string forMode)
	{
		if (aRunLoop == null)
		{
			throw new ArgumentNullException("aRunLoop");
		}
		if (forMode == null)
		{
			throw new ArgumentNullException("forMode");
		}
		IntPtr arg = NSString.CreateNative(forMode);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveFromRunLoopForMode_Handle, aRunLoop.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveFromRunLoopForMode_Handle, aRunLoop.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("searchForBrowsableDomains")]
	public virtual void SearchForBrowsableDomains()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSearchForBrowsableDomainsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSearchForBrowsableDomainsHandle);
		}
	}

	[Export("searchForRegistrationDomains")]
	public virtual void SearchForRegistrationDomains()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSearchForRegistrationDomainsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSearchForRegistrationDomainsHandle);
		}
	}

	[Export("searchForServicesOfType:inDomain:")]
	public virtual void SearchForServices(string type, string domain)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		IntPtr arg = NSString.CreateNative(type);
		IntPtr arg2 = NSString.CreateNative(domain);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSearchForServicesOfTypeInDomain_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSearchForServicesOfTypeInDomain_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("stop")]
	public virtual void Stop()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopHandle);
		}
	}

	private _NSNetServiceBrowserDelegate EnsureNSNetServiceBrowserDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSNetServiceBrowserDelegate))
		{
			nSObject = (WeakDelegate = new _NSNetServiceBrowserDelegate());
		}
		return (_NSNetServiceBrowserDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
