using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLProtocol", true)]
public abstract class NSUrlProtocol : NSObject
{
	private NSUrlProtocolClient client;

	private static readonly IntPtr selClientHandle = Selector.GetHandle("client");

	private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

	private static readonly IntPtr selCachedResponseHandle = Selector.GetHandle("cachedResponse");

	private static readonly IntPtr selInitWithRequestCachedResponseClient_Handle = Selector.GetHandle("initWithRequest:cachedResponse:client:");

	private static readonly IntPtr selCanInitWithRequest_Handle = Selector.GetHandle("canInitWithRequest:");

	private static readonly IntPtr selCanonicalRequestForRequest_Handle = Selector.GetHandle("canonicalRequestForRequest:");

	private static readonly IntPtr selRequestIsCacheEquivalentToRequest_Handle = Selector.GetHandle("requestIsCacheEquivalent:toRequest:");

	private static readonly IntPtr selStartLoadingHandle = Selector.GetHandle("startLoading");

	private static readonly IntPtr selStopLoadingHandle = Selector.GetHandle("stopLoading");

	private static readonly IntPtr selPropertyForKeyInRequest_Handle = Selector.GetHandle("propertyForKey:inRequest:");

	private static readonly IntPtr selSetPropertyForKeyInRequest_Handle = Selector.GetHandle("setProperty:forKey:inRequest:");

	private static readonly IntPtr selRemovePropertyForKeyInRequest_Handle = Selector.GetHandle("removePropertyForKey:inRequest:");

	private static readonly IntPtr selRegisterClass_Handle = Selector.GetHandle("registerClass:");

	private static readonly IntPtr selUnregisterClass_Handle = Selector.GetHandle("unregisterClass:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLProtocol");

	private object __mt_WeakClient_var;

	private object __mt_Request_var;

	private object __mt_CachedResponse_var;

	public NSUrlProtocolClient Client
	{
		get
		{
			if (client == null)
			{
				client = new NSUrlProtocolClient(WeakClient.Handle);
			}
			return client;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject WeakClient
	{
		[Export("client")]
		get
		{
			return (NSObject)(__mt_WeakClient_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClientHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selClientHandle))));
		}
	}

	public virtual NSUrlRequest Request
	{
		[Export("request")]
		get
		{
			return (NSUrlRequest)(__mt_Request_var = ((!IsDirectBinding) ? ((NSUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestHandle))) : ((NSUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestHandle)))));
		}
	}

	public virtual NSCachedUrlResponse CachedResponse
	{
		[Export("cachedResponse")]
		get
		{
			return (NSCachedUrlResponse)(__mt_CachedResponse_var = ((!IsDirectBinding) ? ((NSCachedUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCachedResponseHandle))) : ((NSCachedUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCachedResponseHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlProtocol()
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
	public NSUrlProtocol(NSCoder coder)
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
	public NSUrlProtocol(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlProtocol(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRequest:cachedResponse:client:")]
	public NSUrlProtocol(NSUrlRequest request, NSCachedUrlResponse cachedResponse, NSUrlProtocolClient client)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (client == null)
		{
			throw new ArgumentNullException("client");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithRequestCachedResponseClient_Handle, request.Handle, cachedResponse?.Handle ?? IntPtr.Zero, client.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithRequestCachedResponseClient_Handle, request.Handle, cachedResponse?.Handle ?? IntPtr.Zero, client.Handle);
		}
	}

	[Export("canInitWithRequest:")]
	public static bool CanInitWithRequest(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithRequest_Handle, request.Handle);
	}

	[Export("canonicalRequestForRequest:")]
	public static NSUrlRequest GetCanonicalRequest(NSUrlRequest forRequest)
	{
		if (forRequest == null)
		{
			throw new ArgumentNullException("forRequest");
		}
		return (NSUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCanonicalRequestForRequest_Handle, forRequest.Handle));
	}

	[Export("requestIsCacheEquivalent:toRequest:")]
	public static bool IsRequestCacheEquivalent(NSUrlRequest first, NSUrlRequest second)
	{
		if (first == null)
		{
			throw new ArgumentNullException("first");
		}
		if (second == null)
		{
			throw new ArgumentNullException("second");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(class_ptr, selRequestIsCacheEquivalentToRequest_Handle, first.Handle, second.Handle);
	}

	[Export("startLoading")]
	public virtual void StartLoading()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartLoadingHandle);
		}
	}

	[Export("stopLoading")]
	public virtual void StopLoading()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopLoadingHandle);
		}
	}

	[Export("propertyForKey:inRequest:")]
	public static NSObject GetProperty(string key, NSUrlRequest inRequest)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (inRequest == null)
		{
			throw new ArgumentNullException("inRequest");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPropertyForKeyInRequest_Handle, arg, inRequest.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("setProperty:forKey:inRequest:")]
	public static void SetProperty(NSObject value, string key, NSMutableUrlRequest inRequest)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (inRequest == null)
		{
			throw new ArgumentNullException("inRequest");
		}
		IntPtr arg = NSString.CreateNative(key);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSetPropertyForKeyInRequest_Handle, value?.Handle ?? IntPtr.Zero, arg, inRequest.Handle);
		NSString.ReleaseNative(arg);
	}

	[Export("removePropertyForKey:inRequest:")]
	public static void RemoveProperty(string propertyKey, NSMutableUrlRequest request)
	{
		if (propertyKey == null)
		{
			throw new ArgumentNullException("propertyKey");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr arg = NSString.CreateNative(propertyKey);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selRemovePropertyForKeyInRequest_Handle, arg, request.Handle);
		NSString.ReleaseNative(arg);
	}

	[Export("registerClass:")]
	public static bool RegisterClass(Class protocolClass)
	{
		if (protocolClass == null)
		{
			throw new ArgumentNullException("protocolClass");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selRegisterClass_Handle, protocolClass.Handle);
	}

	[Export("unregisterClass:")]
	public static void UnregisterClass(Class protocolClass)
	{
		if (protocolClass == null)
		{
			throw new ArgumentNullException("protocolClass");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selUnregisterClass_Handle, protocolClass.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakClient_var = null;
			__mt_Request_var = null;
			__mt_CachedResponse_var = null;
		}
	}
}
