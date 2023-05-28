using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLProtocol", true)]
public abstract class NSUrlProtocol : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCachedResponse = "cachedResponse";

	private static readonly IntPtr selCachedResponseHandle = Selector.GetHandle("cachedResponse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInitWithRequest_ = "canInitWithRequest:";

	private static readonly IntPtr selCanInitWithRequest_Handle = Selector.GetHandle("canInitWithRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanonicalRequestForRequest_ = "canonicalRequestForRequest:";

	private static readonly IntPtr selCanonicalRequestForRequest_Handle = Selector.GetHandle("canonicalRequestForRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClient = "client";

	private static readonly IntPtr selClientHandle = Selector.GetHandle("client");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRequest_CachedResponse_Client_ = "initWithRequest:cachedResponse:client:";

	private static readonly IntPtr selInitWithRequest_CachedResponse_Client_Handle = Selector.GetHandle("initWithRequest:cachedResponse:client:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyForKey_InRequest_ = "propertyForKey:inRequest:";

	private static readonly IntPtr selPropertyForKey_InRequest_Handle = Selector.GetHandle("propertyForKey:inRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterClass_ = "registerClass:";

	private static readonly IntPtr selRegisterClass_Handle = Selector.GetHandle("registerClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovePropertyForKey_InRequest_ = "removePropertyForKey:inRequest:";

	private static readonly IntPtr selRemovePropertyForKey_InRequest_Handle = Selector.GetHandle("removePropertyForKey:inRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequest = "request";

	private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestIsCacheEquivalent_ToRequest_ = "requestIsCacheEquivalent:toRequest:";

	private static readonly IntPtr selRequestIsCacheEquivalent_ToRequest_Handle = Selector.GetHandle("requestIsCacheEquivalent:toRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProperty_ForKey_InRequest_ = "setProperty:forKey:inRequest:";

	private static readonly IntPtr selSetProperty_ForKey_InRequest_Handle = Selector.GetHandle("setProperty:forKey:inRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartLoading = "startLoading";

	private static readonly IntPtr selStartLoadingHandle = Selector.GetHandle("startLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopLoading = "stopLoading";

	private static readonly IntPtr selStopLoadingHandle = Selector.GetHandle("stopLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnregisterClass_ = "unregisterClass:";

	private static readonly IntPtr selUnregisterClass_Handle = Selector.GetHandle("unregisterClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLProtocol");

	[Obsolete("Use 'Client' instead.")]
	public virtual NSObject WeakClient
	{
		get
		{
			INSUrlProtocolClient client = Client;
			if (client == null)
			{
				return null;
			}
			if (client is NSObject result)
			{
				return result;
			}
			return Runtime.GetNSObject(client.Handle);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCachedUrlResponse CachedResponse
	{
		[Export("cachedResponse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCachedUrlResponse>(Messaging.IntPtr_objc_msgSend(base.Handle, selCachedResponseHandle));
			}
			return Runtime.GetNSObject<NSCachedUrlResponse>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCachedResponseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSUrlProtocolClient Client
	{
		[Export("client")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<INSUrlProtocolClient>(Messaging.IntPtr_objc_msgSend(base.Handle, selClientHandle), owns: false);
			}
			return Runtime.GetINativeObject<INSUrlProtocolClient>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClientHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequest Request
	{
		[Export("request")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestHandle));
			}
			return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	[Obsolete("Use the overload that takes an 'INSUrlProtocolClient' instead.")]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithRequest_CachedResponse_Client_Handle, request.Handle, cachedResponse?.Handle ?? IntPtr.Zero, client.Handle), "initWithRequest:cachedResponse:client:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithRequest_CachedResponse_Client_Handle, request.Handle, cachedResponse?.Handle ?? IntPtr.Zero, client.Handle), "initWithRequest:cachedResponse:client:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlProtocol()
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
	protected NSUrlProtocol(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlProtocol(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRequest:cachedResponse:client:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlProtocol(NSUrlRequest request, NSCachedUrlResponse? cachedResponse, INSUrlProtocolClient client)
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithRequest_CachedResponse_Client_Handle, request.Handle, cachedResponse?.Handle ?? IntPtr.Zero, client.Handle), "initWithRequest:cachedResponse:client:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithRequest_CachedResponse_Client_Handle, request.Handle, cachedResponse?.Handle ?? IntPtr.Zero, client.Handle), "initWithRequest:cachedResponse:client:");
		}
	}

	[Export("canInitWithRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanInitWithRequest(NSUrlRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithRequest_Handle, request.Handle);
	}

	[Export("canonicalRequestForRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlRequest GetCanonicalRequest(NSUrlRequest forRequest)
	{
		if (forRequest == null)
		{
			throw new ArgumentNullException("forRequest");
		}
		return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCanonicalRequestForRequest_Handle, forRequest.Handle));
	}

	[Export("propertyForKey:inRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPropertyForKey_InRequest_Handle, arg, inRequest.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("requestIsCacheEquivalent:toRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(class_ptr, selRequestIsCacheEquivalent_ToRequest_Handle, first.Handle, second.Handle);
	}

	[Export("registerClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool RegisterClass(Class protocolClass)
	{
		if (protocolClass == null)
		{
			throw new ArgumentNullException("protocolClass");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selRegisterClass_Handle, protocolClass.Handle);
	}

	[Export("removePropertyForKey:inRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selRemovePropertyForKey_InRequest_Handle, arg, request.Handle);
		NSString.ReleaseNative(arg);
	}

	[Export("setProperty:forKey:inRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetProperty(NSObject? value, string key, NSMutableUrlRequest inRequest)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSetProperty_ForKey_InRequest_Handle, value?.Handle ?? IntPtr.Zero, arg, inRequest.Handle);
		NSString.ReleaseNative(arg);
	}

	[Export("startLoading")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartLoading()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartLoadingHandle);
		}
	}

	[Export("stopLoading")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopLoading()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopLoadingHandle);
		}
	}

	[Export("unregisterClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UnregisterClass(Class protocolClass)
	{
		if (protocolClass == null)
		{
			throw new ArgumentNullException("protocolClass");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selUnregisterClass_Handle, protocolClass.Handle);
	}
}
