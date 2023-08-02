using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSStream", true)]
public class NSStream : NSObject
{
	[Register]
	private sealed class _NSStreamDelegate : NSStreamDelegate
	{
		internal EventHandler<NSStreamEventArgs> handleEvent;

		[Preserve(Conditional = true)]
		public override void HandleEvent(NSStream theStream, NSStreamEvent streamEvent)
		{
			EventHandler<NSStreamEventArgs> eventHandler = handleEvent;
			if (eventHandler != null)
			{
				NSStreamEventArgs e = new NSStreamEventArgs(streamEvent);
				eventHandler(theStream, e);
			}
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selStreamStatusHandle = Selector.GetHandle("streamStatus");

	private static readonly IntPtr selStreamErrorHandle = Selector.GetHandle("streamError");

	private static readonly IntPtr selOpenHandle = Selector.GetHandle("open");

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	private static readonly IntPtr selPropertyForKey_Handle = Selector.GetHandle("propertyForKey:");

	private static readonly IntPtr selSetPropertyForKey_Handle = Selector.GetHandle("setProperty:forKey:");

	private static readonly IntPtr selScheduleInRunLoopForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	private static readonly IntPtr selRemoveFromRunLoopForMode_Handle = Selector.GetHandle("removeFromRunLoop:forMode:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSStream");

	private object __mt_WeakDelegate_var;

	private object __mt_Error_var;

	private static NSString _SocketSecurityLevelKey;

	private static NSString _SocketSecurityLevelNone;

	private static NSString _SocketSecurityLevelSslV2;

	private static NSString _SocketSecurityLevelSslV3;

	private static NSString _SocketSecurityLevelTlsV1;

	private static NSString _SocketSecurityLevelNegotiatedSsl;

	private static NSString _SocksProxyConfigurationKey;

	private static NSString _SocksProxyHostKey;

	private static NSString _SocksProxyPortKey;

	private static NSString _SocksProxyVersionKey;

	private static NSString _SocksProxyUserKey;

	private static NSString _SocksProxyPasswordKey;

	private static NSString _SocksProxyVersion4;

	private static NSString _SocksProxyVersion5;

	private static NSString _DataWrittenToMemoryStreamKey;

	private static NSString _FileCurrentOffsetKey;

	private static NSString _SocketSslErrorDomain;

	private static NSString _SocksErrorDomain;

	private static NSString _NetworkServiceType;

	private static NSString _NetworkServiceTypeVoIP;

	private static NSString _NetworkServiceTypeVideo;

	private static NSString _NetworkServiceTypeBackground;

	private static NSString _NetworkServiceTypeVoice;

	public NSObject this[NSString key]
	{
		get
		{
			return PropertyForKey(key);
		}
		set
		{
			SetPropertyForKey(value, key);
		}
	}

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

	public NSStreamDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSStreamDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSStreamStatus Status
	{
		[Export("streamStatus")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSStreamStatus)Messaging.UInt64_objc_msgSend(base.Handle, selStreamStatusHandle);
			}
			return (NSStreamStatus)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStreamStatusHandle);
		}
	}

	public virtual NSError Error
	{
		[Export("streamError")]
		get
		{
			return (NSError)(__mt_Error_var = ((!IsDirectBinding) ? ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStreamErrorHandle))) : ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStreamErrorHandle)))));
		}
	}

	[Field("NSStreamSocketSecurityLevelKey", "Foundation")]
	public static NSString SocketSecurityLevelKey
	{
		get
		{
			if (_SocketSecurityLevelKey == null)
			{
				_SocketSecurityLevelKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelKey");
			}
			return _SocketSecurityLevelKey;
		}
	}

	[Field("NSStreamSocketSecurityLevelNone", "Foundation")]
	public static NSString SocketSecurityLevelNone
	{
		get
		{
			if (_SocketSecurityLevelNone == null)
			{
				_SocketSecurityLevelNone = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelNone");
			}
			return _SocketSecurityLevelNone;
		}
	}

	[Field("NSStreamSocketSecurityLevelSSLv2", "Foundation")]
	public static NSString SocketSecurityLevelSslV2
	{
		get
		{
			if (_SocketSecurityLevelSslV2 == null)
			{
				_SocketSecurityLevelSslV2 = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelSSLv2");
			}
			return _SocketSecurityLevelSslV2;
		}
	}

	[Field("NSStreamSocketSecurityLevelSSLv3", "Foundation")]
	public static NSString SocketSecurityLevelSslV3
	{
		get
		{
			if (_SocketSecurityLevelSslV3 == null)
			{
				_SocketSecurityLevelSslV3 = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelSSLv3");
			}
			return _SocketSecurityLevelSslV3;
		}
	}

	[Field("NSStreamSocketSecurityLevelTLSv1", "Foundation")]
	public static NSString SocketSecurityLevelTlsV1
	{
		get
		{
			if (_SocketSecurityLevelTlsV1 == null)
			{
				_SocketSecurityLevelTlsV1 = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelTLSv1");
			}
			return _SocketSecurityLevelTlsV1;
		}
	}

	[Field("NSStreamSocketSecurityLevelNegotiatedSSL", "Foundation")]
	public static NSString SocketSecurityLevelNegotiatedSsl
	{
		get
		{
			if (_SocketSecurityLevelNegotiatedSsl == null)
			{
				_SocketSecurityLevelNegotiatedSsl = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelNegotiatedSSL");
			}
			return _SocketSecurityLevelNegotiatedSsl;
		}
	}

	[Field("NSStreamSOCKSProxyConfigurationKey", "Foundation")]
	public static NSString SocksProxyConfigurationKey
	{
		get
		{
			if (_SocksProxyConfigurationKey == null)
			{
				_SocksProxyConfigurationKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSProxyConfigurationKey");
			}
			return _SocksProxyConfigurationKey;
		}
	}

	[Field("NSStreamSOCKSProxyHostKey", "Foundation")]
	public static NSString SocksProxyHostKey
	{
		get
		{
			if (_SocksProxyHostKey == null)
			{
				_SocksProxyHostKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSProxyHostKey");
			}
			return _SocksProxyHostKey;
		}
	}

	[Field("NSStreamSOCKSProxyPortKey", "Foundation")]
	public static NSString SocksProxyPortKey
	{
		get
		{
			if (_SocksProxyPortKey == null)
			{
				_SocksProxyPortKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSProxyPortKey");
			}
			return _SocksProxyPortKey;
		}
	}

	[Field("NSStreamSOCKSProxyVersionKey", "Foundation")]
	public static NSString SocksProxyVersionKey
	{
		get
		{
			if (_SocksProxyVersionKey == null)
			{
				_SocksProxyVersionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSProxyVersionKey");
			}
			return _SocksProxyVersionKey;
		}
	}

	[Field("NSStreamSOCKSProxyUserKey", "Foundation")]
	public static NSString SocksProxyUserKey
	{
		get
		{
			if (_SocksProxyUserKey == null)
			{
				_SocksProxyUserKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSProxyUserKey");
			}
			return _SocksProxyUserKey;
		}
	}

	[Field("NSStreamSOCKSProxyPasswordKey", "Foundation")]
	public static NSString SocksProxyPasswordKey
	{
		get
		{
			if (_SocksProxyPasswordKey == null)
			{
				_SocksProxyPasswordKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSProxyPasswordKey");
			}
			return _SocksProxyPasswordKey;
		}
	}

	[Field("NSStreamSOCKSProxyVersion4", "Foundation")]
	public static NSString SocksProxyVersion4
	{
		get
		{
			if (_SocksProxyVersion4 == null)
			{
				_SocksProxyVersion4 = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSProxyVersion4");
			}
			return _SocksProxyVersion4;
		}
	}

	[Field("NSStreamSOCKSProxyVersion5", "Foundation")]
	public static NSString SocksProxyVersion5
	{
		get
		{
			if (_SocksProxyVersion5 == null)
			{
				_SocksProxyVersion5 = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSProxyVersion5");
			}
			return _SocksProxyVersion5;
		}
	}

	[Field("NSStreamDataWrittenToMemoryStreamKey", "Foundation")]
	public static NSString DataWrittenToMemoryStreamKey
	{
		get
		{
			if (_DataWrittenToMemoryStreamKey == null)
			{
				_DataWrittenToMemoryStreamKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamDataWrittenToMemoryStreamKey");
			}
			return _DataWrittenToMemoryStreamKey;
		}
	}

	[Field("NSStreamFileCurrentOffsetKey", "Foundation")]
	public static NSString FileCurrentOffsetKey
	{
		get
		{
			if (_FileCurrentOffsetKey == null)
			{
				_FileCurrentOffsetKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamFileCurrentOffsetKey");
			}
			return _FileCurrentOffsetKey;
		}
	}

	[Field("NSStreamSocketSSLErrorDomain", "Foundation")]
	public static NSString SocketSslErrorDomain
	{
		get
		{
			if (_SocketSslErrorDomain == null)
			{
				_SocketSslErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSocketSSLErrorDomain");
			}
			return _SocketSslErrorDomain;
		}
	}

	[Field("NSStreamSOCKSErrorDomain", "Foundation")]
	public static NSString SocksErrorDomain
	{
		get
		{
			if (_SocksErrorDomain == null)
			{
				_SocksErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSErrorDomain");
			}
			return _SocksErrorDomain;
		}
	}

	[Field("NSStreamNetworkServiceType", "Foundation")]
	public static NSString NetworkServiceType
	{
		get
		{
			if (_NetworkServiceType == null)
			{
				_NetworkServiceType = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamNetworkServiceType");
			}
			return _NetworkServiceType;
		}
	}

	[Field("NSStreamNetworkServiceTypeVoIP", "Foundation")]
	public static NSString NetworkServiceTypeVoIP
	{
		get
		{
			if (_NetworkServiceTypeVoIP == null)
			{
				_NetworkServiceTypeVoIP = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeVoIP");
			}
			return _NetworkServiceTypeVoIP;
		}
	}

	[Field("NSStreamNetworkServiceTypeVideo", "Foundation")]
	public static NSString NetworkServiceTypeVideo
	{
		get
		{
			if (_NetworkServiceTypeVideo == null)
			{
				_NetworkServiceTypeVideo = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeVideo");
			}
			return _NetworkServiceTypeVideo;
		}
	}

	[Field("NSStreamNetworkServiceTypeBackground", "Foundation")]
	public static NSString NetworkServiceTypeBackground
	{
		get
		{
			if (_NetworkServiceTypeBackground == null)
			{
				_NetworkServiceTypeBackground = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeBackground");
			}
			return _NetworkServiceTypeBackground;
		}
	}

	[Field("NSStreamNetworkServiceTypeVoice", "Foundation")]
	public static NSString NetworkServiceTypeVoice
	{
		get
		{
			if (_NetworkServiceTypeVoice == null)
			{
				_NetworkServiceTypeVoice = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeVoice");
			}
			return _NetworkServiceTypeVoice;
		}
	}

	public event EventHandler<NSStreamEventArgs> OnEvent
	{
		add
		{
			_NSStreamDelegate nSStreamDelegate = EnsureNSStreamDelegate();
			nSStreamDelegate.handleEvent = (EventHandler<NSStreamEventArgs>)System.Delegate.Combine(nSStreamDelegate.handleEvent, value);
		}
		remove
		{
			_NSStreamDelegate nSStreamDelegate = EnsureNSStreamDelegate();
			nSStreamDelegate.handleEvent = (EventHandler<NSStreamEventArgs>)System.Delegate.Remove(nSStreamDelegate.handleEvent, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSStream()
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
	public NSStream(NSCoder coder)
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
	public NSStream(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSStream(IntPtr handle)
		: base(handle)
	{
	}

	[Export("open")]
	public virtual void Open()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selOpenHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selOpenHandle);
		}
	}

	[Export("close")]
	public virtual void Close()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("propertyForKey:")]
	internal virtual NSObject PropertyForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPropertyForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPropertyForKey_Handle, key.Handle));
	}

	[Export("setProperty:forKey:")]
	internal virtual bool SetPropertyForKey(NSObject property, NSString key)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetPropertyForKey_Handle, property.Handle, key.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetPropertyForKey_Handle, property.Handle, key.Handle);
	}

	[Export("scheduleInRunLoop:forMode:")]
	public virtual void Schedule(NSRunLoop aRunLoop, string mode)
	{
		if (aRunLoop == null)
		{
			throw new ArgumentNullException("aRunLoop");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		IntPtr arg = NSString.CreateNative(mode);
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
	public virtual void Unschedule(NSRunLoop aRunLoop, string mode)
	{
		if (aRunLoop == null)
		{
			throw new ArgumentNullException("aRunLoop");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		IntPtr arg = NSString.CreateNative(mode);
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

	private _NSStreamDelegate EnsureNSStreamDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSStreamDelegate))
		{
			nSObject = (WeakDelegate = new _NSStreamDelegate());
		}
		return (_NSStreamDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_Error_var = null;
		}
	}
}
