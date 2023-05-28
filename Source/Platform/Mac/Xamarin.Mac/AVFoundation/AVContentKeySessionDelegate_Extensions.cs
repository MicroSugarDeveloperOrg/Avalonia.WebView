using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVContentKeySessionDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidProvideRenewingContentKeyRequest(this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (keyRequest == null)
		{
			throw new ArgumentNullException("keyRequest");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contentKeySession:didProvideRenewingContentKeyRequest:"), session.Handle, keyRequest.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidProvidePersistableContentKeyRequest(this IAVContentKeySessionDelegate This, AVContentKeySession session, AVPersistableContentKeyRequest keyRequest)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (keyRequest == null)
		{
			throw new ArgumentNullException("keyRequest");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contentKeySession:didProvidePersistableContentKeyRequest:"), session.Handle, keyRequest.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFail(this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest, NSError err)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (keyRequest == null)
		{
			throw new ArgumentNullException("keyRequest");
		}
		if (err == null)
		{
			throw new ArgumentNullException("err");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contentKeySession:contentKeyRequest:didFailWithError:"), session.Handle, keyRequest.Handle, err.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldRetryContentKeyRequest(this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest, string retryReason)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (keyRequest == null)
		{
			throw new ArgumentNullException("keyRequest");
		}
		if (retryReason == null)
		{
			throw new ArgumentNullException("retryReason");
		}
		IntPtr intPtr = NSString.CreateNative(retryReason);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contentKeySession:shouldRetryContentKeyRequest:reason:"), session.Handle, keyRequest.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChange(this IAVContentKeySessionDelegate This, AVContentKeySession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("contentKeySessionContentProtectionSessionIdentifierDidChange:"), session.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidUpdate(this IAVContentKeySessionDelegate This, AVContentKeySession session, NSData persistableContentKey, NSObject keyIdentifier)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (persistableContentKey == null)
		{
			throw new ArgumentNullException("persistableContentKey");
		}
		if (keyIdentifier == null)
		{
			throw new ArgumentNullException("keyIdentifier");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contentKeySession:didUpdatePersistableContentKey:forContentKeyIdentifier:"), session.Handle, persistableContentKey.Handle, keyIdentifier.Handle);
	}

	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidSucceed(this IAVContentKeySessionDelegate This, AVContentKeySession session, AVContentKeyRequest keyRequest)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (keyRequest == null)
		{
			throw new ArgumentNullException("keyRequest");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("contentKeySession:contentKeyRequestDidSucceed:"), session.Handle, keyRequest.Handle);
	}

	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidGenerateExpiredSessionReport(this IAVContentKeySessionDelegate This, AVContentKeySession session)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("contentKeySessionDidGenerateExpiredSessionReport:"), session.Handle);
	}
}
