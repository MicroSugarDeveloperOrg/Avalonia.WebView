using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNetService", true)]
public class NSNetService : NSObject
{
	[Register]
	private sealed class _NSNetServiceDelegate : NSNetServiceDelegate
	{
		internal EventHandler willPublish;

		internal EventHandler published;

		internal EventHandler<NSNetServiceErrorEventArgs> publishFailure;

		internal EventHandler willResolve;

		internal EventHandler addressResolved;

		internal EventHandler<NSNetServiceErrorEventArgs> resolveFailure;

		internal EventHandler stopped;

		internal EventHandler<NSNetServiceDataEventArgs> updatedTxtRecordData;

		[Preserve(Conditional = true)]
		public override void WillPublish(NSNetService sender)
		{
			willPublish?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void Published(NSNetService sender)
		{
			published?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void PublishFailure(NSNetService sender, NSDictionary errors)
		{
			EventHandler<NSNetServiceErrorEventArgs> eventHandler = publishFailure;
			if (eventHandler != null)
			{
				NSNetServiceErrorEventArgs e = new NSNetServiceErrorEventArgs(errors);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void WillResolve(NSNetService sender)
		{
			willResolve?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void AddressResolved(NSNetService sender)
		{
			addressResolved?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void ResolveFailure(NSNetService sender, NSDictionary errors)
		{
			EventHandler<NSNetServiceErrorEventArgs> eventHandler = resolveFailure;
			if (eventHandler != null)
			{
				NSNetServiceErrorEventArgs e = new NSNetServiceErrorEventArgs(errors);
				eventHandler(sender, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void Stopped(NSNetService sender)
		{
			stopped?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void UpdatedTxtRecordData(NSNetService sender, NSData data)
		{
			EventHandler<NSNetServiceDataEventArgs> eventHandler = updatedTxtRecordData;
			if (eventHandler != null)
			{
				NSNetServiceDataEventArgs e = new NSNetServiceDataEventArgs(data);
				eventHandler(sender, e);
			}
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selDomainHandle = Selector.GetHandle("domain");

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selAddressesHandle = Selector.GetHandle("addresses");

	private static readonly IntPtr selPortHandle = Selector.GetHandle("port");

	private static readonly IntPtr selHostNameHandle = Selector.GetHandle("hostName");

	private static readonly IntPtr selInitWithDomainTypeNamePort_Handle = Selector.GetHandle("initWithDomain:type:name:port:");

	private static readonly IntPtr selInitWithDomainTypeName_Handle = Selector.GetHandle("initWithDomain:type:name:");

	private static readonly IntPtr selScheduleInRunLoopForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	private static readonly IntPtr selRemoveFromRunLoopForMode_Handle = Selector.GetHandle("removeFromRunLoop:forMode:");

	private static readonly IntPtr selPublishHandle = Selector.GetHandle("publish");

	private static readonly IntPtr selPublishWithOptions_Handle = Selector.GetHandle("publishWithOptions:");

	private static readonly IntPtr selResolveHandle = Selector.GetHandle("resolve");

	private static readonly IntPtr selResolveWithTimeout_Handle = Selector.GetHandle("resolveWithTimeout:");

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	private static readonly IntPtr selDictionaryFromTXTRecordData_Handle = Selector.GetHandle("dictionaryFromTXTRecordData:");

	private static readonly IntPtr selDataFromTXTRecordDictionary_Handle = Selector.GetHandle("dataFromTXTRecordDictionary:");

	private static readonly IntPtr selGetInputStreamOutputStream_Handle = Selector.GetHandle("getInputStream:outputStream:");

	private static readonly IntPtr selTXTRecordDataHandle = Selector.GetHandle("TXTRecordData");

	private static readonly IntPtr selSetTXTRecordData_Handle = Selector.GetHandle("setTXTRecordData:");

	private static readonly IntPtr selStartMonitoringHandle = Selector.GetHandle("startMonitoring");

	private static readonly IntPtr selStopMonitoringHandle = Selector.GetHandle("stopMonitoring");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSNetService");

	private object __mt_WeakDelegate_var;

	private object __mt_Addresses_var;

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

	public NSNetServiceDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSNetServiceDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual string Domain
	{
		[Export("domain")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainHandle));
		}
	}

	public virtual string Type
	{
		[Export("type")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual NSData[] Addresses
	{
		[Export("addresses")]
		get
		{
			return (NSData[])(__mt_Addresses_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAddressesHandle)) : NSArray.ArrayFromHandle<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selAddressesHandle))));
		}
	}

	public virtual int Port
	{
		[Export("port")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPortHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPortHandle);
		}
	}

	public virtual string HostName
	{
		[Export("hostName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHostNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostNameHandle));
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNetService()
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
	public NSNetService(NSCoder coder)
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
	public NSNetService(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNetService(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDomain:type:name:port:")]
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int(base.Handle, selInitWithDomainTypeNamePort_Handle, arg, arg2, arg3, port);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int(base.SuperHandle, selInitWithDomainTypeNamePort_Handle, arg, arg2, arg3, port);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("initWithDomain:type:name:")]
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithDomainTypeName_Handle, arg, arg2, arg3);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithDomainTypeName_Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
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

	[Export("publish")]
	public virtual void Publish()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPublishHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPublishHandle);
		}
	}

	[Export("publishWithOptions:")]
	public virtual void Publish(NSNetServiceOptions options)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selPublishWithOptions_Handle, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selPublishWithOptions_Handle, (ulong)options);
		}
	}

	[Export("resolve")]
	[Obsolete("Deprecated in iOS 2.0 / OSX 10.4, use Resolve(double)", false)]
	public virtual void Resolve()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResolveHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResolveHandle);
		}
	}

	[Export("resolveWithTimeout:")]
	public virtual void Resolve(double timeOut)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selResolveWithTimeout_Handle, timeOut);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selResolveWithTimeout_Handle, timeOut);
		}
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

	[Export("dictionaryFromTXTRecordData:")]
	public static NSDictionary DictionaryFromTxtRecord(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDictionaryFromTXTRecordData_Handle, data.Handle));
	}

	[Export("dataFromTXTRecordDictionary:")]
	public static NSData DataFromTxtRecord(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataFromTXTRecordDictionary_Handle, dictionary.Handle));
	}

	[Export("getInputStream:outputStream:")]
	internal virtual bool GetStreams(IntPtr ptrToInputStorage, IntPtr ptrToOutputStorage)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetInputStreamOutputStream_Handle, ptrToInputStorage, ptrToOutputStorage);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetInputStreamOutputStream_Handle, ptrToInputStorage, ptrToOutputStorage);
	}

	[Export("TXTRecordData")]
	public virtual NSData GetTxtRecordData()
	{
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTXTRecordDataHandle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTXTRecordDataHandle));
	}

	[Export("setTXTRecordData:")]
	public virtual bool SetTxtRecordData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetTXTRecordData_Handle, data.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTXTRecordData_Handle, data.Handle);
	}

	[Export("startMonitoring")]
	public virtual void StartMonitoring()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartMonitoringHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartMonitoringHandle);
		}
	}

	[Export("stopMonitoring")]
	public virtual void StopMonitoring()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopMonitoringHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopMonitoringHandle);
		}
	}

	private _NSNetServiceDelegate EnsureNSNetServiceDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSNetServiceDelegate))
		{
			nSObject = (WeakDelegate = new _NSNetServiceDelegate());
		}
		return (_NSNetServiceDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_Addresses_var = null;
		}
	}
}
