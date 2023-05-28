using System;
using System.ComponentModel;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSNetService", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class NSNetService : NSObject
{
	[Register]
	internal class _NSNetServiceDelegate : NSObject, INSNetServiceDelegate, INativeObject, IDisposable
	{
		internal EventHandler? addressResolved;

		internal EventHandler<NSNetServiceConnectionEventArgs>? didAcceptConnection;

		internal EventHandler<NSNetServiceErrorEventArgs>? publishFailure;

		internal EventHandler? published;

		internal EventHandler<NSNetServiceErrorEventArgs>? resolveFailure;

		internal EventHandler? stopped;

		internal EventHandler<NSNetServiceDataEventArgs>? updatedTxtRecordData;

		internal EventHandler? willPublish;

		internal EventHandler? willResolve;

		public _NSNetServiceDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("netServiceDidResolveAddress:")]
		public void AddressResolved(NSNetService sender)
		{
			addressResolved?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("netService:didAcceptConnectionWithInputStream:outputStream:")]
		public void DidAcceptConnection(NSNetService sender, NSInputStream inputStream, NSOutputStream outputStream)
		{
			EventHandler<NSNetServiceConnectionEventArgs> eventHandler = didAcceptConnection;
			if (eventHandler != null)
			{
				NSNetServiceConnectionEventArgs e = new NSNetServiceConnectionEventArgs(inputStream, outputStream);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("netService:didNotPublish:")]
		public void PublishFailure(NSNetService sender, NSDictionary errors)
		{
			EventHandler<NSNetServiceErrorEventArgs> eventHandler = publishFailure;
			if (eventHandler != null)
			{
				NSNetServiceErrorEventArgs e = new NSNetServiceErrorEventArgs(errors);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("netServiceDidPublish:")]
		public void Published(NSNetService sender)
		{
			published?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("netService:didNotResolve:")]
		public void ResolveFailure(NSNetService sender, NSDictionary errors)
		{
			EventHandler<NSNetServiceErrorEventArgs> eventHandler = resolveFailure;
			if (eventHandler != null)
			{
				NSNetServiceErrorEventArgs e = new NSNetServiceErrorEventArgs(errors);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("netServiceDidStop:")]
		public void Stopped(NSNetService sender)
		{
			stopped?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("netService:didUpdateTXTRecordData:")]
		public void UpdatedTxtRecordData(NSNetService sender, NSData data)
		{
			EventHandler<NSNetServiceDataEventArgs> eventHandler = updatedTxtRecordData;
			if (eventHandler != null)
			{
				NSNetServiceDataEventArgs e = new NSNetServiceDataEventArgs(data);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("netServiceWillPublish:")]
		public void WillPublish(NSNetService sender)
		{
			willPublish?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("netServiceWillResolve:")]
		public void WillResolve(NSNetService sender)
		{
			willResolve?.Invoke(sender, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTXTRecordData = "TXTRecordData";

	private static readonly IntPtr selTXTRecordDataHandle = Selector.GetHandle("TXTRecordData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddresses = "addresses";

	private static readonly IntPtr selAddressesHandle = Selector.GetHandle("addresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataFromTXTRecordDictionary_ = "dataFromTXTRecordDictionary:";

	private static readonly IntPtr selDataFromTXTRecordDictionary_Handle = Selector.GetHandle("dataFromTXTRecordDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryFromTXTRecordData_ = "dictionaryFromTXTRecordData:";

	private static readonly IntPtr selDictionaryFromTXTRecordData_Handle = Selector.GetHandle("dictionaryFromTXTRecordData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDomain = "domain";

	private static readonly IntPtr selDomainHandle = Selector.GetHandle("domain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetInputStream_OutputStream_ = "getInputStream:outputStream:";

	private static readonly IntPtr selGetInputStream_OutputStream_Handle = Selector.GetHandle("getInputStream:outputStream:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHostName = "hostName";

	private static readonly IntPtr selHostNameHandle = Selector.GetHandle("hostName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesPeerToPeer = "includesPeerToPeer";

	private static readonly IntPtr selIncludesPeerToPeerHandle = Selector.GetHandle("includesPeerToPeer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDomain_Type_Name_ = "initWithDomain:type:name:";

	private static readonly IntPtr selInitWithDomain_Type_Name_Handle = Selector.GetHandle("initWithDomain:type:name:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDomain_Type_Name_Port_ = "initWithDomain:type:name:port:";

	private static readonly IntPtr selInitWithDomain_Type_Name_Port_Handle = Selector.GetHandle("initWithDomain:type:name:port:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPort = "port";

	private static readonly IntPtr selPortHandle = Selector.GetHandle("port");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPublish = "publish";

	private static readonly IntPtr selPublishHandle = Selector.GetHandle("publish");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPublishWithOptions_ = "publishWithOptions:";

	private static readonly IntPtr selPublishWithOptions_Handle = Selector.GetHandle("publishWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromRunLoop_ForMode_ = "removeFromRunLoop:forMode:";

	private static readonly IntPtr selRemoveFromRunLoop_ForMode_Handle = Selector.GetHandle("removeFromRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolve = "resolve";

	private static readonly IntPtr selResolveHandle = Selector.GetHandle("resolve");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveWithTimeout_ = "resolveWithTimeout:";

	private static readonly IntPtr selResolveWithTimeout_Handle = Selector.GetHandle("resolveWithTimeout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleInRunLoop_ForMode_ = "scheduleInRunLoop:forMode:";

	private static readonly IntPtr selScheduleInRunLoop_ForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludesPeerToPeer_ = "setIncludesPeerToPeer:";

	private static readonly IntPtr selSetIncludesPeerToPeer_Handle = Selector.GetHandle("setIncludesPeerToPeer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTXTRecordData_ = "setTXTRecordData:";

	private static readonly IntPtr selSetTXTRecordData_Handle = Selector.GetHandle("setTXTRecordData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartMonitoring = "startMonitoring";

	private static readonly IntPtr selStartMonitoringHandle = Selector.GetHandle("startMonitoring");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopMonitoring = "stopMonitoring";

	private static readonly IntPtr selStopMonitoringHandle = Selector.GetHandle("stopMonitoring");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSNetService");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public virtual NSData TxtRecordData
	{
		get
		{
			return GetTxtRecordData();
		}
		set
		{
			SetTxtRecordData(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData[] Addresses
	{
		[Export("addresses", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selAddressesHandle));
			}
			return NSArray.ArrayFromHandle<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAddressesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSNetServiceDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSNetServiceDelegate;
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
	public virtual string Domain
	{
		[Export("domain", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string HostName
	{
		[Export("hostName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHostNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostNameHandle));
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
	public virtual string Name
	{
		[Export("name", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Port
	{
		[Export("port")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPortHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPortHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Type
	{
		[Export("type", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
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

	internal virtual Type GetInternalEventDelegateType => typeof(_NSNetServiceDelegate);

	public event EventHandler AddressResolved
	{
		add
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.addressResolved = (EventHandler)System.Delegate.Combine(nSNetServiceDelegate.addressResolved, value);
		}
		remove
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.addressResolved = (EventHandler)System.Delegate.Remove(nSNetServiceDelegate.addressResolved, value);
		}
	}

	public event EventHandler<NSNetServiceConnectionEventArgs> DidAcceptConnection
	{
		add
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.didAcceptConnection = (EventHandler<NSNetServiceConnectionEventArgs>)System.Delegate.Combine(nSNetServiceDelegate.didAcceptConnection, value);
		}
		remove
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.didAcceptConnection = (EventHandler<NSNetServiceConnectionEventArgs>)System.Delegate.Remove(nSNetServiceDelegate.didAcceptConnection, value);
		}
	}

	public event EventHandler<NSNetServiceErrorEventArgs> PublishFailure
	{
		add
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.publishFailure = (EventHandler<NSNetServiceErrorEventArgs>)System.Delegate.Combine(nSNetServiceDelegate.publishFailure, value);
		}
		remove
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.publishFailure = (EventHandler<NSNetServiceErrorEventArgs>)System.Delegate.Remove(nSNetServiceDelegate.publishFailure, value);
		}
	}

	public event EventHandler Published
	{
		add
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.published = (EventHandler)System.Delegate.Combine(nSNetServiceDelegate.published, value);
		}
		remove
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.published = (EventHandler)System.Delegate.Remove(nSNetServiceDelegate.published, value);
		}
	}

	public event EventHandler<NSNetServiceErrorEventArgs> ResolveFailure
	{
		add
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.resolveFailure = (EventHandler<NSNetServiceErrorEventArgs>)System.Delegate.Combine(nSNetServiceDelegate.resolveFailure, value);
		}
		remove
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.resolveFailure = (EventHandler<NSNetServiceErrorEventArgs>)System.Delegate.Remove(nSNetServiceDelegate.resolveFailure, value);
		}
	}

	public event EventHandler Stopped
	{
		add
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.stopped = (EventHandler)System.Delegate.Combine(nSNetServiceDelegate.stopped, value);
		}
		remove
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.stopped = (EventHandler)System.Delegate.Remove(nSNetServiceDelegate.stopped, value);
		}
	}

	public event EventHandler<NSNetServiceDataEventArgs> UpdatedTxtRecordData
	{
		add
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.updatedTxtRecordData = (EventHandler<NSNetServiceDataEventArgs>)System.Delegate.Combine(nSNetServiceDelegate.updatedTxtRecordData, value);
		}
		remove
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.updatedTxtRecordData = (EventHandler<NSNetServiceDataEventArgs>)System.Delegate.Remove(nSNetServiceDelegate.updatedTxtRecordData, value);
		}
	}

	public event EventHandler WillPublish
	{
		add
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.willPublish = (EventHandler)System.Delegate.Combine(nSNetServiceDelegate.willPublish, value);
		}
		remove
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.willPublish = (EventHandler)System.Delegate.Remove(nSNetServiceDelegate.willPublish, value);
		}
	}

	public event EventHandler WillResolve
	{
		add
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.willResolve = (EventHandler)System.Delegate.Combine(nSNetServiceDelegate.willResolve, value);
		}
		remove
		{
			_NSNetServiceDelegate nSNetServiceDelegate = EnsureNSNetServiceDelegate();
			nSNetServiceDelegate.willResolve = (EventHandler)System.Delegate.Remove(nSNetServiceDelegate.willResolve, value);
		}
	}

	[Obsolete("This constructor does not create a valid instance of the type")]
	public NSNetService()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSNetService(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSNetService(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDomain:type:name:port:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNetService(string domain, string type, string name, int port)
		: base(NSObjectFlag.Empty)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(domain);
		IntPtr arg2 = NSString.CreateNative(type);
		IntPtr arg3 = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int(base.Handle, selInitWithDomain_Type_Name_Port_Handle, arg, arg2, arg3, port), "initWithDomain:type:name:port:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int(base.SuperHandle, selInitWithDomain_Type_Name_Port_Handle, arg, arg2, arg3, port), "initWithDomain:type:name:port:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("initWithDomain:type:name:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNetService(string domain, string type, string name)
		: base(NSObjectFlag.Empty)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(domain);
		IntPtr arg2 = NSString.CreateNative(type);
		IntPtr arg3 = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithDomain_Type_Name_Handle, arg, arg2, arg3), "initWithDomain:type:name:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithDomain_Type_Name_Handle, arg, arg2, arg3), "initWithDomain:type:name:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("dataFromTXTRecordDictionary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData DataFromTxtRecord(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataFromTXTRecordDictionary_Handle, dictionary.Handle));
	}

	[Export("dictionaryFromTXTRecordData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary DictionaryFromTxtRecord(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryFromTXTRecordData_Handle, data.Handle));
	}

	[Export("getInputStream:outputStream:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetStreams(out NSInputStream inputStream, out NSOutputStream outputStream)
	{
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_ref_IntPtr(base.SuperHandle, selGetInputStream_OutputStream_Handle, ref arg, ref arg2) : Messaging.bool_objc_msgSend_ref_IntPtr_ref_IntPtr(base.Handle, selGetInputStream_OutputStream_Handle, ref arg, ref arg2));
		inputStream = Runtime.GetNSObject<NSInputStream>(arg);
		outputStream = Runtime.GetNSObject<NSOutputStream>(arg2);
		return result;
	}

	[Export("TXTRecordData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetTxtRecordData()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selTXTRecordDataHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTXTRecordDataHandle));
	}

	[Export("publish")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Publish()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPublishHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPublishHandle);
		}
	}

	[Export("publishWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Publish(NSNetServiceOptions options)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selPublishWithOptions_Handle, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selPublishWithOptions_Handle, (ulong)options);
		}
	}

	[Export("resolve")]
	[Deprecated(PlatformName.iOS, 2, 0, PlatformArchitecture.None, "Use 'Resolve (double)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 4, PlatformArchitecture.None, "Use 'Resolve (double)' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resolve()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResolveHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResolveHandle);
		}
	}

	[Export("resolveWithTimeout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resolve(double timeOut)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selResolveWithTimeout_Handle, timeOut);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selResolveWithTimeout_Handle, timeOut);
		}
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

	[Export("setTXTRecordData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetTxtRecordData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetTXTRecordData_Handle, data.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTXTRecordData_Handle, data.Handle);
	}

	[Export("startMonitoring")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartMonitoring()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartMonitoringHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartMonitoringHandle);
		}
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

	[Export("stopMonitoring")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopMonitoring()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopMonitoringHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopMonitoringHandle);
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

	internal virtual _NSNetServiceDelegate CreateInternalEventDelegateType()
	{
		return new _NSNetServiceDelegate();
	}

	internal _NSNetServiceDelegate EnsureNSNetServiceDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSNetServiceDelegate nSNetServiceDelegate = Delegate as _NSNetServiceDelegate;
		if (nSNetServiceDelegate == null)
		{
			nSNetServiceDelegate = (_NSNetServiceDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSNetServiceDelegate;
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
