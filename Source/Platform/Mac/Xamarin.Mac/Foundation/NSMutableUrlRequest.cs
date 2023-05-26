using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableURLRequest", true)]
public class NSMutableUrlRequest : NSUrlRequest
{
	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	private static readonly IntPtr selCachePolicyHandle = Selector.GetHandle("cachePolicy");

	private static readonly IntPtr selSetCachePolicy_Handle = Selector.GetHandle("setCachePolicy:");

	private static readonly IntPtr selTimeoutIntervalHandle = Selector.GetHandle("timeoutInterval");

	private static readonly IntPtr selSetTimeoutInterval_Handle = Selector.GetHandle("setTimeoutInterval:");

	private static readonly IntPtr selMainDocumentURLHandle = Selector.GetHandle("mainDocumentURL");

	private static readonly IntPtr selSetMainDocumentURL_Handle = Selector.GetHandle("setMainDocumentURL:");

	private static readonly IntPtr selHTTPMethodHandle = Selector.GetHandle("HTTPMethod");

	private static readonly IntPtr selSetHTTPMethod_Handle = Selector.GetHandle("setHTTPMethod:");

	private static readonly IntPtr selAllHTTPHeaderFieldsHandle = Selector.GetHandle("allHTTPHeaderFields");

	private static readonly IntPtr selSetAllHTTPHeaderFields_Handle = Selector.GetHandle("setAllHTTPHeaderFields:");

	private static readonly IntPtr selHTTPBodyHandle = Selector.GetHandle("HTTPBody");

	private static readonly IntPtr selSetHTTPBody_Handle = Selector.GetHandle("setHTTPBody:");

	private static readonly IntPtr selHTTPBodyStreamHandle = Selector.GetHandle("HTTPBodyStream");

	private static readonly IntPtr selSetHTTPBodyStream_Handle = Selector.GetHandle("setHTTPBodyStream:");

	private static readonly IntPtr selHTTPShouldHandleCookiesHandle = Selector.GetHandle("HTTPShouldHandleCookies");

	private static readonly IntPtr selSetHTTPShouldHandleCookies_Handle = Selector.GetHandle("setHTTPShouldHandleCookies:");

	private static readonly IntPtr selNetworkServiceTypeHandle = Selector.GetHandle("networkServiceType");

	private static readonly IntPtr selSetNetworkServiceType_Handle = Selector.GetHandle("setNetworkServiceType:");

	private static readonly IntPtr selAllowsCellularAccessHandle = Selector.GetHandle("allowsCellularAccess");

	private static readonly IntPtr selSetAllowsCellularAccess_Handle = Selector.GetHandle("setAllowsCellularAccess:");

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	private static readonly IntPtr selInitWithURLCachePolicyTimeoutInterval_Handle = Selector.GetHandle("initWithURL:cachePolicy:timeoutInterval:");

	private static readonly IntPtr selSetValueForHTTPHeaderField_Handle = Selector.GetHandle("setValue:forHTTPHeaderField:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableURLRequest");

	private object __mt_Url_var;

	private object __mt_MainDocumentURL_var;

	private object __mt_Headers_var;

	private object __mt_Body_var;

	private object __mt_BodyStream_var;

	public new string this[string key]
	{
		get
		{
			return Header(key);
		}
		set
		{
			_SetValue(value, key);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public new virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle)))));
		}
		[Export("setURL:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, value.Handle);
			}
			__mt_Url_var = value;
		}
	}

	public new virtual NSUrlRequestCachePolicy CachePolicy
	{
		[Export("cachePolicy")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSUrlRequestCachePolicy)Messaging.UInt64_objc_msgSend(base.Handle, selCachePolicyHandle);
			}
			return (NSUrlRequestCachePolicy)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCachePolicyHandle);
		}
		[Export("setCachePolicy:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCachePolicy_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCachePolicy_Handle, (ulong)value);
			}
		}
	}

	public new virtual double TimeoutInterval
	{
		[Export("timeoutInterval")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeoutIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeoutIntervalHandle);
		}
		[Export("setTimeoutInterval:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeoutInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeoutInterval_Handle, value);
			}
		}
	}

	public new virtual NSUrl MainDocumentURL
	{
		[Export("mainDocumentURL")]
		get
		{
			return (NSUrl)(__mt_MainDocumentURL_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainDocumentURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMainDocumentURLHandle)))));
		}
		[Export("setMainDocumentURL:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMainDocumentURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMainDocumentURL_Handle, value.Handle);
			}
			__mt_MainDocumentURL_var = value;
		}
	}

	public new virtual string HttpMethod
	{
		[Export("HTTPMethod")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPMethodHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPMethodHandle));
		}
		[Export("setHTTPMethod:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHTTPMethod_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHTTPMethod_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public new virtual NSDictionary Headers
	{
		[Export("allHTTPHeaderFields")]
		get
		{
			return (NSDictionary)(__mt_Headers_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllHTTPHeaderFieldsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAllHTTPHeaderFieldsHandle)))));
		}
		[Export("setAllHTTPHeaderFields:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAllHTTPHeaderFields_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAllHTTPHeaderFields_Handle, value.Handle);
			}
			__mt_Headers_var = value;
		}
	}

	public new virtual NSData Body
	{
		[Export("HTTPBody")]
		get
		{
			return (NSData)(__mt_Body_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPBodyHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPBodyHandle)))));
		}
		[Export("setHTTPBody:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHTTPBody_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHTTPBody_Handle, value.Handle);
			}
			__mt_Body_var = value;
		}
	}

	public new virtual NSInputStream BodyStream
	{
		[Export("HTTPBodyStream")]
		get
		{
			return (NSInputStream)(__mt_BodyStream_var = ((!IsDirectBinding) ? ((NSInputStream)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPBodyStreamHandle))) : ((NSInputStream)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPBodyStreamHandle)))));
		}
		[Export("setHTTPBodyStream:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHTTPBodyStream_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHTTPBodyStream_Handle, value.Handle);
			}
			__mt_BodyStream_var = value;
		}
	}

	public new virtual bool ShouldHandleCookies
	{
		[Export("HTTPShouldHandleCookies")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHTTPShouldHandleCookiesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHTTPShouldHandleCookiesHandle);
		}
		[Export("setHTTPShouldHandleCookies:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHTTPShouldHandleCookies_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHTTPShouldHandleCookies_Handle, value);
			}
		}
	}

	public new virtual NSUrlRequestNetworkServiceType NetworkServiceType
	{
		[Export("networkServiceType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSUrlRequestNetworkServiceType)Messaging.UInt64_objc_msgSend(base.Handle, selNetworkServiceTypeHandle);
			}
			return (NSUrlRequestNetworkServiceType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNetworkServiceTypeHandle);
		}
		[Export("setNetworkServiceType:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetNetworkServiceType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetNetworkServiceType_Handle, (ulong)value);
			}
		}
	}

	public new virtual bool AllowsCellularAccess
	{
		[Export("allowsCellularAccess")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCellularAccessHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCellularAccessHandle);
		}
		[Export("setAllowsCellularAccess:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsCellularAccess_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsCellularAccess_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableUrlRequest()
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
	public NSMutableUrlRequest(NSCoder coder)
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
	public NSMutableUrlRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableUrlRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	public NSMutableUrlRequest(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle);
		}
	}

	[Export("initWithURL:cachePolicy:timeoutInterval:")]
	public NSMutableUrlRequest(NSUrl url, NSUrlRequestCachePolicy cachePolicy, double timeoutInterval)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_Double(base.Handle, selInitWithURLCachePolicyTimeoutInterval_Handle, url.Handle, (ulong)cachePolicy, timeoutInterval);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_Double(base.SuperHandle, selInitWithURLCachePolicyTimeoutInterval_Handle, url.Handle, (ulong)cachePolicy, timeoutInterval);
		}
	}

	[Export("setValue:forHTTPHeaderField:")]
	internal virtual void _SetValue(string value, string field)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		IntPtr arg = NSString.CreateNative(value);
		IntPtr arg2 = NSString.CreateNative(field);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValueForHTTPHeaderField_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValueForHTTPHeaderField_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Url_var = null;
			__mt_MainDocumentURL_var = null;
			__mt_Headers_var = null;
			__mt_Body_var = null;
			__mt_BodyStream_var = null;
		}
	}
}
