using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using AppKit;
using CoreFoundation;
using CoreServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSStream", true)]
public class NSStream : NSObject
{
	[Register]
	internal class _NSStreamDelegate : NSObject, INSStreamDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSStreamEventArgs>? handleEvent;

		public _NSStreamDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("stream:handleEvent:")]
		public void HandleEvent(NSStream theStream, NSStreamEvent streamEvent)
		{
			EventHandler<NSStreamEventArgs> eventHandler = handleEvent;
			if (eventHandler != null)
			{
				NSStreamEventArgs e = new NSStreamEventArgs(streamEvent);
				eventHandler(theStream, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClose = "close";

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetBoundStreamsWithBufferSize_InputStream_OutputStream_ = "getBoundStreamsWithBufferSize:inputStream:outputStream:";

	private static readonly IntPtr selGetBoundStreamsWithBufferSize_InputStream_OutputStream_Handle = Selector.GetHandle("getBoundStreamsWithBufferSize:inputStream:outputStream:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetStreamsToHostWithName_Port_InputStream_OutputStream_ = "getStreamsToHostWithName:port:inputStream:outputStream:";

	private static readonly IntPtr selGetStreamsToHostWithName_Port_InputStream_OutputStream_Handle = Selector.GetHandle("getStreamsToHostWithName:port:inputStream:outputStream:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpen = "open";

	private static readonly IntPtr selOpenHandle = Selector.GetHandle("open");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyForKey_ = "propertyForKey:";

	private static readonly IntPtr selPropertyForKey_Handle = Selector.GetHandle("propertyForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromRunLoop_ForMode_ = "removeFromRunLoop:forMode:";

	private static readonly IntPtr selRemoveFromRunLoop_ForMode_Handle = Selector.GetHandle("removeFromRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleInRunLoop_ForMode_ = "scheduleInRunLoop:forMode:";

	private static readonly IntPtr selScheduleInRunLoop_ForMode_Handle = Selector.GetHandle("scheduleInRunLoop:forMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProperty_ForKey_ = "setProperty:forKey:";

	private static readonly IntPtr selSetProperty_ForKey_Handle = Selector.GetHandle("setProperty:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStreamError = "streamError";

	private static readonly IntPtr selStreamErrorHandle = Selector.GetHandle("streamError");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStreamStatus = "streamStatus";

	private static readonly IntPtr selStreamStatusHandle = Selector.GetHandle("streamStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSStream");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataWrittenToMemoryStreamKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileCurrentOffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NetworkServiceType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NetworkServiceTypeBackground;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NetworkServiceTypeCallSignaling;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NetworkServiceTypeVideo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NetworkServiceTypeVoIP;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NetworkServiceTypeVoice;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocketSecurityLevelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocketSecurityLevelNegotiatedSsl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocketSecurityLevelNone;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocketSecurityLevelSslV2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocketSecurityLevelSslV3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocketSecurityLevelTlsV1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocketSslErrorDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocksErrorDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocksProxyConfigurationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocksProxyHostKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocksProxyPasswordKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocksProxyPortKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocksProxyUserKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocksProxyVersion4;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocksProxyVersion5;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SocksProxyVersionKey;

	public NSObject this[NSString key]
	{
		get
		{
			return GetProperty(key);
		}
		set
		{
			SetProperty(value, key);
		}
	}

	public NSStreamSocksOptions SocksOptions
	{
		get
		{
			if (!(this[SocksProxyConfigurationKey] is NSDictionary nSDictionary))
			{
				return null;
			}
			NSStreamSocksOptions nSStreamSocksOptions = new NSStreamSocksOptions();
			NSString nSString = nSDictionary[SocksProxyHostKey] as NSString;
			NSNumber nSNumber = nSDictionary[SocksProxyPortKey] as NSNumber;
			NSString nSString2 = nSDictionary[SocksProxyVersionKey] as NSString;
			NSString nSString3 = nSDictionary[SocksProxyUserKey] as NSString;
			NSString nSString4 = nSDictionary[SocksProxyPasswordKey] as NSString;
			if (nSString != null)
			{
				nSStreamSocksOptions.HostName = nSString;
			}
			if (nSNumber != null)
			{
				nSStreamSocksOptions.HostPort = nSNumber.Int32Value;
			}
			if (nSString2 != null)
			{
				nSStreamSocksOptions.Version = ((nSString2 == SocksProxyVersion4) ? 4 : ((nSString2 == SocksProxyVersion5) ? 5 : (-1)));
			}
			if (nSString3 != null)
			{
				nSStreamSocksOptions.Username = nSString3;
			}
			if (nSString4 != null)
			{
				nSStreamSocksOptions.Password = nSString4;
			}
			return nSStreamSocksOptions;
		}
		set
		{
			if (value == null)
			{
				this[SocksProxyConfigurationKey] = null;
				return;
			}
			NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
			if (value.HostName != null)
			{
				nSMutableDictionary[SocksProxyHostKey] = new NSString(value.HostName);
			}
			if (value.HostPort != 0)
			{
				nSMutableDictionary[SocksProxyPortKey] = new NSNumber(value.HostPort);
			}
			if (value.Version == 4)
			{
				nSMutableDictionary[SocksProxyVersionKey] = SocksProxyVersion4;
			}
			if (value.Version == 5)
			{
				nSMutableDictionary[SocksProxyVersionKey] = SocksProxyVersion5;
			}
			if (value.Username != null)
			{
				nSMutableDictionary[SocksProxyUserKey] = new NSString(value.Username);
			}
			if (value.Password != null)
			{
				nSMutableDictionary[SocksProxyPasswordKey] = new NSString(value.Password);
			}
			this[SocksProxyConfigurationKey] = nSMutableDictionary;
		}
	}

	public NSStreamSocketSecurityLevel SocketSecurityLevel
	{
		get
		{
			NSString nSString = this[SocketSecurityLevelKey] as NSString;
			if (nSString == SocketSecurityLevelNone)
			{
				return NSStreamSocketSecurityLevel.None;
			}
			if (nSString == SocketSecurityLevelSslV2)
			{
				return NSStreamSocketSecurityLevel.SslV2;
			}
			if (nSString == SocketSecurityLevelSslV3)
			{
				return NSStreamSocketSecurityLevel.SslV3;
			}
			if (nSString == SocketSecurityLevelTlsV1)
			{
				return NSStreamSocketSecurityLevel.TlsV1;
			}
			if (nSString == SocketSecurityLevelNegotiatedSsl)
			{
				return NSStreamSocketSecurityLevel.NegotiatedSsl;
			}
			return NSStreamSocketSecurityLevel.Unknown;
		}
		set
		{
			NSString nSString = null;
			switch (value)
			{
			case NSStreamSocketSecurityLevel.None:
				nSString = SocketSecurityLevelNone;
				break;
			case NSStreamSocketSecurityLevel.SslV2:
				nSString = SocketSecurityLevelSslV2;
				break;
			case NSStreamSocketSecurityLevel.SslV3:
				nSString = SocketSecurityLevelSslV3;
				break;
			case NSStreamSocketSecurityLevel.TlsV1:
				nSString = SocketSecurityLevelTlsV1;
				break;
			case NSStreamSocketSecurityLevel.NegotiatedSsl:
				nSString = SocketSecurityLevelNegotiatedSsl;
				break;
			}
			if (nSString != null)
			{
				this[SocketSecurityLevelKey] = nSString;
			}
		}
	}

	public NSData DataWrittenToMemoryStream => this[DataWrittenToMemoryStreamKey] as NSData;

	public NSNumber FileCurrentOffset => this[FileCurrentOffsetKey] as NSNumber;

	public NSStreamServiceType ServiceType
	{
		get
		{
			NSString nSString = this[NetworkServiceType] as NSString;
			if (nSString == NetworkServiceTypeBackground)
			{
				return NSStreamServiceType.Background;
			}
			if (nSString == NetworkServiceTypeVideo)
			{
				return NSStreamServiceType.Video;
			}
			if (nSString == NetworkServiceTypeVoice)
			{
				return NSStreamServiceType.Voice;
			}
			if (nSString == NetworkServiceTypeVoIP)
			{
				return NSStreamServiceType.VoIP;
			}
			return NSStreamServiceType.Default;
		}
		set
		{
			NSString value2 = null;
			switch (value)
			{
			case NSStreamServiceType.Background:
				value2 = NetworkServiceTypeBackground;
				break;
			case NSStreamServiceType.Video:
				value2 = NetworkServiceTypeVideo;
				break;
			case NSStreamServiceType.Voice:
				value2 = NetworkServiceTypeVoIP;
				break;
			case NSStreamServiceType.VoIP:
				value2 = NetworkServiceTypeVoIP;
				break;
			}
			this[NetworkServiceType] = value2;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSStreamDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSStreamDelegate;
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
	public virtual NSError Error
	{
		[Export("streamError")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selStreamErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStreamErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSStreamStatus Status
	{
		[Export("streamStatus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSStreamStatus)Messaging.UInt64_objc_msgSend(base.Handle, selStreamStatusHandle);
			}
			return (NSStreamStatus)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStreamStatusHandle);
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

	[Field("NSStreamDataWrittenToMemoryStreamKey", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamNetworkServiceType", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamNetworkServiceTypeBackground", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamNetworkServiceTypeCallSignaling", "Foundation")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static NSString NetworkServiceTypeCallSignaling
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_NetworkServiceTypeCallSignaling == null)
			{
				_NetworkServiceTypeCallSignaling = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeCallSignaling");
			}
			return _NetworkServiceTypeCallSignaling;
		}
	}

	[Field("NSStreamNetworkServiceTypeVideo", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamNetworkServiceTypeVoIP", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamNetworkServiceTypeVoice", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSocketSecurityLevelKey", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSocketSecurityLevelNegotiatedSSL", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSocketSecurityLevelNone", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSocketSSLErrorDomain", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSOCKSProxyConfigurationKey", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSOCKSProxyPasswordKey", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSOCKSProxyPortKey", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSOCKSProxyUserKey", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSOCKSProxyVersion4", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	[Field("NSStreamSOCKSProxyVersionKey", "Foundation")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
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

	internal virtual Type GetInternalEventDelegateType => typeof(_NSStreamDelegate);

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

	private static void AssignStreams(IntPtr read, IntPtr write, out NSInputStream readStream, out NSOutputStream writeStream)
	{
		readStream = Runtime.GetNSObject<NSInputStream>(read);
		writeStream = Runtime.GetNSObject<NSOutputStream>(write);
	}

	public static void CreatePairWithSocket(CFSocket socket, out NSInputStream readStream, out NSOutputStream writeStream)
	{
		if (socket == null)
		{
			throw new ArgumentNullException("socket");
		}
		CFStream.CFStreamCreatePairWithSocket(IntPtr.Zero, socket.GetNative(), out var readStream2, out var writeStream2);
		AssignStreams(readStream2, writeStream2, out readStream, out writeStream);
	}

	public static void CreatePairWithPeerSocketSignature(AddressFamily family, SocketType type, ProtocolType proto, IPEndPoint endpoint, out NSInputStream readStream, out NSOutputStream writeStream)
	{
		using CFSocketAddress address = new CFSocketAddress(endpoint);
		CFSocketSignature sig = new CFSocketSignature(family, type, proto, address);
		CFStream.CFStreamCreatePairWithPeerSocketSignature(IntPtr.Zero, ref sig, out var readStream2, out var writeStream2);
		AssignStreams(readStream2, writeStream2, out readStream, out writeStream);
	}

	public static void CreatePairWithSocketToHost(IPEndPoint endpoint, out NSInputStream readStream, out NSOutputStream writeStream)
	{
		using CFHost cFHost = CFHost.Create(endpoint);
		CFStream.CFStreamCreatePairWithSocketToCFHost(IntPtr.Zero, cFHost.Handle, endpoint.Port, out var readStream2, out var writeStream2);
		AssignStreams(readStream2, writeStream2, out readStream, out writeStream);
	}

	public static void CreateBoundPair(out NSInputStream readStream, out NSOutputStream writeStream, nint bufferSize)
	{
		CFStream.CFStreamCreateBoundPair(IntPtr.Zero, out var readStream2, out var writeStream2, bufferSize);
		AssignStreams(readStream2, writeStream2, out readStream, out writeStream);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSStream()
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
	protected NSStream(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSStream(IntPtr handle)
		: base(handle)
	{
	}

	[Export("close")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Close()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("getBoundStreamsWithBufferSize:inputStream:outputStream:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void GetBoundStreams(nuint bufferSize, out NSInputStream inputStream, out NSOutputStream outputStream)
	{
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		Messaging.void_objc_msgSend_nuint_ref_IntPtr_ref_IntPtr(class_ptr, selGetBoundStreamsWithBufferSize_InputStream_OutputStream_Handle, bufferSize, ref arg, ref arg2);
		inputStream = Runtime.GetNSObject<NSInputStream>(arg);
		outputStream = Runtime.GetNSObject<NSOutputStream>(arg2);
	}

	[Export("propertyForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSObject GetProperty(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPropertyForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPropertyForKey_Handle, key.Handle));
	}

	[Export("getStreamsToHostWithName:port:inputStream:outputStream:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void GetStreamsToHost(string hostname, nint port, out NSInputStream inputStream, out NSOutputStream outputStream)
	{
		if (hostname == null)
		{
			throw new ArgumentNullException("hostname");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(hostname);
		Messaging.void_objc_msgSend_IntPtr_nint_ref_IntPtr_ref_IntPtr(class_ptr, selGetStreamsToHostWithName_Port_InputStream_OutputStream_Handle, arg3, port, ref arg, ref arg2);
		NSString.ReleaseNative(arg3);
		inputStream = Runtime.GetNSObject<NSInputStream>(arg);
		outputStream = Runtime.GetNSObject<NSOutputStream>(arg2);
	}

	[Export("open")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Open()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selOpenHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selOpenHandle);
		}
	}

	[Export("scheduleInRunLoop:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	public void Schedule(NSRunLoop aRunLoop, NSRunLoopMode mode)
	{
		Schedule(aRunLoop, mode.GetConstant());
	}

	[Export("setProperty:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetProperty(NSObject? property, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetProperty_ForKey_Handle, property?.Handle ?? IntPtr.Zero, key.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetProperty_ForKey_Handle, property?.Handle ?? IntPtr.Zero, key.Handle);
	}

	[Export("removeFromRunLoop:forMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	public void Unschedule(NSRunLoop aRunLoop, NSRunLoopMode mode)
	{
		Unschedule(aRunLoop, mode.GetConstant());
	}

	internal virtual _NSStreamDelegate CreateInternalEventDelegateType()
	{
		return new _NSStreamDelegate();
	}

	internal _NSStreamDelegate EnsureNSStreamDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSStreamDelegate nSStreamDelegate = Delegate as _NSStreamDelegate;
		if (nSStreamDelegate == null)
		{
			nSStreamDelegate = (_NSStreamDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSStreamDelegate;
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
