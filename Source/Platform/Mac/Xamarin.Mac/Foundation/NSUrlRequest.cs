using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLRequest", true)]
public class NSUrlRequest : NSObject
{
	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selCachePolicyHandle = Selector.GetHandle("cachePolicy");

	private static readonly IntPtr selTimeoutIntervalHandle = Selector.GetHandle("timeoutInterval");

	private static readonly IntPtr selMainDocumentURLHandle = Selector.GetHandle("mainDocumentURL");

	private static readonly IntPtr selNetworkServiceTypeHandle = Selector.GetHandle("networkServiceType");

	private static readonly IntPtr selAllowsCellularAccessHandle = Selector.GetHandle("allowsCellularAccess");

	private static readonly IntPtr selHTTPMethodHandle = Selector.GetHandle("HTTPMethod");

	private static readonly IntPtr selAllHTTPHeaderFieldsHandle = Selector.GetHandle("allHTTPHeaderFields");

	private static readonly IntPtr selHTTPBodyHandle = Selector.GetHandle("HTTPBody");

	private static readonly IntPtr selHTTPBodyStreamHandle = Selector.GetHandle("HTTPBodyStream");

	private static readonly IntPtr selHTTPShouldHandleCookiesHandle = Selector.GetHandle("HTTPShouldHandleCookies");

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	private static readonly IntPtr selInitWithURLCachePolicyTimeoutInterval_Handle = Selector.GetHandle("initWithURL:cachePolicy:timeoutInterval:");

	private static readonly IntPtr selRequestWithURL_Handle = Selector.GetHandle("requestWithURL:");

	private static readonly IntPtr selValueForHTTPHeaderField_Handle = Selector.GetHandle("valueForHTTPHeaderField:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLRequest");

	private object __mt_Url_var;

	private object __mt_MainDocumentURL_var;

	private object __mt_Headers_var;

	private object __mt_Body_var;

	private object __mt_BodyStream_var;

	public string this[string key] => Header(key);

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle)))));
		}
	}

	public virtual NSUrlRequestCachePolicy CachePolicy
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
	}

	public virtual double TimeoutInterval
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
	}

	public virtual NSUrl MainDocumentURL
	{
		[Export("mainDocumentURL")]
		get
		{
			return (NSUrl)(__mt_MainDocumentURL_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainDocumentURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMainDocumentURLHandle)))));
		}
	}

	public virtual NSUrlRequestNetworkServiceType NetworkServiceType
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
	}

	public virtual bool AllowsCellularAccess
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
	}

	public virtual string HttpMethod
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
	}

	public virtual NSDictionary Headers
	{
		[Export("allHTTPHeaderFields")]
		get
		{
			return (NSDictionary)(__mt_Headers_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllHTTPHeaderFieldsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAllHTTPHeaderFieldsHandle)))));
		}
	}

	public virtual NSData Body
	{
		[Export("HTTPBody")]
		get
		{
			return (NSData)(__mt_Body_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPBodyHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPBodyHandle)))));
		}
	}

	public virtual NSInputStream BodyStream
	{
		[Export("HTTPBodyStream")]
		get
		{
			return (NSInputStream)(__mt_BodyStream_var = ((!IsDirectBinding) ? ((NSInputStream)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHTTPBodyStreamHandle))) : ((NSInputStream)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selHTTPBodyStreamHandle)))));
		}
	}

	public virtual bool ShouldHandleCookies
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
	}

	public override string ToString()
	{
		if (Url == null)
		{
			return base.ToString();
		}
		return Url.AbsoluteString;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlRequest()
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
	public NSUrlRequest(NSCoder coder)
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
	public NSUrlRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	public NSUrlRequest(NSUrl url)
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
	public NSUrlRequest(NSUrl url, NSUrlRequestCachePolicy cachePolicy, double timeoutInterval)
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

	[Export("requestWithURL:")]
	public static NSUrlRequest FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (NSUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRequestWithURL_Handle, url.Handle));
	}

	[Export("valueForHTTPHeaderField:")]
	internal virtual string Header(string field)
	{
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		IntPtr arg = NSString.CreateNative(field);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForHTTPHeaderField_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForHTTPHeaderField_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
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
