using System;
using System.ComponentModel;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSNetServiceBrowser", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class NSNetServiceBrowser : NSObject
{
	[Register]
	internal class _NSNetServiceBrowserDelegate : NSObject, INSNetServiceBrowserDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSNetDomainEventArgs>? domainRemoved;

		internal EventHandler<NSNetDomainEventArgs>? foundDomain;

		internal EventHandler<NSNetServiceEventArgs>? foundService;

		internal EventHandler<NSNetServiceErrorEventArgs>? notSearched;

		internal EventHandler? searchStarted;

		internal EventHandler? searchStopped;

		internal EventHandler<NSNetServiceEventArgs>? serviceRemoved;

		public _NSNetServiceBrowserDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("netServiceBrowser:didRemoveDomain:moreComing:")]
		public void DomainRemoved(NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			EventHandler<NSNetDomainEventArgs> eventHandler = domainRemoved;
			if (eventHandler != null)
			{
				NSNetDomainEventArgs e = new NSNetDomainEventArgs(domain, moreComing);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("netServiceBrowser:didFindDomain:moreComing:")]
		public void FoundDomain(NSNetServiceBrowser sender, string domain, bool moreComing)
		{
			EventHandler<NSNetDomainEventArgs> eventHandler = foundDomain;
			if (eventHandler != null)
			{
				NSNetDomainEventArgs e = new NSNetDomainEventArgs(domain, moreComing);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("netServiceBrowser:didFindService:moreComing:")]
		public void FoundService(NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			EventHandler<NSNetServiceEventArgs> eventHandler = foundService;
			if (eventHandler != null)
			{
				NSNetServiceEventArgs e = new NSNetServiceEventArgs(service, moreComing);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("netServiceBrowser:didNotSearch:")]
		public void NotSearched(NSNetServiceBrowser sender, NSDictionary errors)
		{
			EventHandler<NSNetServiceErrorEventArgs> eventHandler = notSearched;
			if (eventHandler != null)
			{
				NSNetServiceErrorEventArgs e = new NSNetServiceErrorEventArgs(errors);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("netServiceBrowserWillSearch:")]
		public void SearchStarted(NSNetServiceBrowser sender)
		{
			searchStarted?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("netServiceBrowserDidStopSearch:")]
		public void SearchStopped(NSNetServiceBrowser sender)
		{
			searchStopped?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("netServiceBrowser:didRemoveService:moreComing:")]
		public void ServiceRemoved(NSNetServiceBrowser sender, NSNetService service, bool moreComing)
		{
			EventHandler<NSNetServiceEventArgs> eventHandler = serviceRemoved;
			if (eventHandler != null)
			{
				NSNetServiceEventArgs e = new NSNetServiceEventArgs(service, moreComing);
				eventHandler(sender, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesPeerToPeer = "includesPeerToPeer";

	private static readonly IntPtr selIncludesPeerToPeerHandle = Selector.GetHandle("includesPeerToPeer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromRunLoop_ForMode_ = "removeFromRunLoop:forMode:";

	private static readonly IntPtr selRemoveFromRunLoop_ForMode_Handle = Selector.GetHandle("removeFromRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleInRunLoop_ForMode_ = "scheduleInRunLoop:forMode:";

	private static readonly IntPtr selScheduleInRunLoop_ForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchForBrowsableDomains = "searchForBrowsableDomains";

	private static readonly IntPtr selSearchForBrowsableDomainsHandle = Selector.GetHandle("searchForBrowsableDomains");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchForRegistrationDomains = "searchForRegistrationDomains";

	private static readonly IntPtr selSearchForRegistrationDomainsHandle = Selector.GetHandle("searchForRegistrationDomains");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchForServicesOfType_InDomain_ = "searchForServicesOfType:inDomain:";

	private static readonly IntPtr selSearchForServicesOfType_InDomain_Handle = Selector.GetHandle("searchForServicesOfType:inDomain:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesPeerToPeer_ = "setIncludesPeerToPeer:";

	private static readonly IntPtr selSetIncludesPeerToPeer_Handle = Selector.GetHandle("setIncludesPeerToPeer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSNetServiceBrowser");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSNetServiceBrowserDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSNetServiceBrowserDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool IncludesPeerToPeer
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("includesPeerToPeer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludesPeerToPeerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludesPeerToPeerHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setIncludesPeerToPeer:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludesPeerToPeer_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludesPeerToPeer_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSNetServiceBrowserDelegate);

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNetServiceBrowser()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSNetServiceBrowser(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSNetServiceBrowser(IntPtr handle)
		: base(handle)
	{
	}

	[Export("scheduleInRunLoop:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selScheduleInRunLoop_ForMode_Handle, aRunLoop.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScheduleInRunLoop_ForMode_Handle, aRunLoop.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Schedule(NSRunLoop aRunLoop, NSRunLoopMode forMode)
	{
		Schedule(aRunLoop, forMode.GetConstant());
	}

	[Export("searchForBrowsableDomains")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SearchForBrowsableDomains()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSearchForBrowsableDomainsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSearchForBrowsableDomainsHandle);
		}
	}

	[Export("searchForRegistrationDomains")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SearchForRegistrationDomains()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSearchForRegistrationDomainsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSearchForRegistrationDomainsHandle);
		}
	}

	[Export("searchForServicesOfType:inDomain:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSearchForServicesOfType_InDomain_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSearchForServicesOfType_InDomain_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("stop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Stop()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopHandle);
		}
	}

	[Export("removeFromRunLoop:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveFromRunLoop_ForMode_Handle, aRunLoop.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveFromRunLoop_ForMode_Handle, aRunLoop.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Unschedule(NSRunLoop aRunLoop, NSRunLoopMode forMode)
	{
		Unschedule(aRunLoop, forMode.GetConstant());
	}

	internal virtual _NSNetServiceBrowserDelegate CreateInternalEventDelegateType()
	{
		return new _NSNetServiceBrowserDelegate();
	}

	internal _NSNetServiceBrowserDelegate EnsureNSNetServiceBrowserDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSNetServiceBrowserDelegate nSNetServiceBrowserDelegate = Delegate as _NSNetServiceBrowserDelegate;
		if (nSNetServiceBrowserDelegate == null)
		{
			nSNetServiceBrowserDelegate = (_NSNetServiceBrowserDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSNetServiceBrowserDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
