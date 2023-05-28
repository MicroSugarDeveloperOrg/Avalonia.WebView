using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVContentKeySession", true)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVContentKeySession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentKeySessionWithKeySystem_ = "contentKeySessionWithKeySystem:";

	private static readonly IntPtr selContentKeySessionWithKeySystem_Handle = Selector.GetHandle("contentKeySessionWithKeySystem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentKeySessionWithKeySystem_StorageDirectoryAtURL_ = "contentKeySessionWithKeySystem:storageDirectoryAtURL:";

	private static readonly IntPtr selContentKeySessionWithKeySystem_StorageDirectoryAtURL_Handle = Selector.GetHandle("contentKeySessionWithKeySystem:storageDirectoryAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentProtectionSessionIdentifier = "contentProtectionSessionIdentifier";

	private static readonly IntPtr selContentProtectionSessionIdentifierHandle = Selector.GetHandle("contentProtectionSessionIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegateQueue = "delegateQueue";

	private static readonly IntPtr selDelegateQueueHandle = Selector.GetHandle("delegateQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpire = "expire";

	private static readonly IntPtr selExpireHandle = Selector.GetHandle("expire");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateAllPersistableContentKeysForApp_Options_CompletionHandler_ = "invalidateAllPersistableContentKeysForApp:options:completionHandler:";

	private static readonly IntPtr selInvalidateAllPersistableContentKeysForApp_Options_CompletionHandler_Handle = Selector.GetHandle("invalidateAllPersistableContentKeysForApp:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidatePersistableContentKey_Options_CompletionHandler_ = "invalidatePersistableContentKey:options:completionHandler:";

	private static readonly IntPtr selInvalidatePersistableContentKey_Options_CompletionHandler_Handle = Selector.GetHandle("invalidatePersistableContentKey:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeySystem = "keySystem";

	private static readonly IntPtr selKeySystemHandle = Selector.GetHandle("keySystem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeSecureTokenForExpirationDateOfPersistableContentKey_CompletionHandler_ = "makeSecureTokenForExpirationDateOfPersistableContentKey:completionHandler:";

	private static readonly IntPtr selMakeSecureTokenForExpirationDateOfPersistableContentKey_CompletionHandler_Handle = Selector.GetHandle("makeSecureTokenForExpirationDateOfPersistableContentKey:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPendingExpiredSessionReportsWithAppIdentifier_StorageDirectoryAtURL_ = "pendingExpiredSessionReportsWithAppIdentifier:storageDirectoryAtURL:";

	private static readonly IntPtr selPendingExpiredSessionReportsWithAppIdentifier_StorageDirectoryAtURL_Handle = Selector.GetHandle("pendingExpiredSessionReportsWithAppIdentifier:storageDirectoryAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessContentKeyRequestWithIdentifier_InitializationData_Options_ = "processContentKeyRequestWithIdentifier:initializationData:options:";

	private static readonly IntPtr selProcessContentKeyRequestWithIdentifier_InitializationData_Options_Handle = Selector.GetHandle("processContentKeyRequestWithIdentifier:initializationData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovePendingExpiredSessionReports_WithAppIdentifier_StorageDirectoryAtURL_ = "removePendingExpiredSessionReports:withAppIdentifier:storageDirectoryAtURL:";

	private static readonly IntPtr selRemovePendingExpiredSessionReports_WithAppIdentifier_StorageDirectoryAtURL_Handle = Selector.GetHandle("removePendingExpiredSessionReports:withAppIdentifier:storageDirectoryAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenewExpiringResponseDataForContentKeyRequest_ = "renewExpiringResponseDataForContentKeyRequest:";

	private static readonly IntPtr selRenewExpiringResponseDataForContentKeyRequest_Handle = Selector.GetHandle("renewExpiringResponseDataForContentKeyRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_Queue_ = "setDelegate:queue:";

	private static readonly IntPtr selSetDelegate_Queue_Handle = Selector.GetHandle("setDelegate:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStorageURL = "storageURL";

	private static readonly IntPtr selStorageURLHandle = Selector.GetHandle("storageURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVContentKeySession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? ContentProtectionSessionIdentifier
	{
		[Export("contentProtectionSessionIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentProtectionSessionIdentifierHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentProtectionSessionIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IAVContentKeySessionDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			IAVContentKeySessionDelegate iAVContentKeySessionDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IAVContentKeySessionDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<IAVContentKeySessionDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iAVContentKeySessionDelegate;
			return iAVContentKeySessionDelegate;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DispatchQueue? DelegateQueue
	{
		[Export("delegateQueue")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateQueueHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateQueueHandle));
			return (intPtr == IntPtr.Zero) ? null : new DispatchQueue(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVContentKeySystem KeySystem => AVContentKeySystemExtensions.GetValue(KeySystemConstant);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSString KeySystemConstant
	{
		[Export("keySystem")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selKeySystemHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeySystemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? StorageUrl
	{
		[Export("storageURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selStorageURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStorageURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVContentKeySession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVContentKeySession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("contentKeySessionWithKeySystem:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVContentKeySession Create(string keySystem)
	{
		if (keySystem == null)
		{
			throw new ArgumentNullException("keySystem");
		}
		IntPtr arg = NSString.CreateNative(keySystem);
		AVContentKeySession nSObject = Runtime.GetNSObject<AVContentKeySession>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContentKeySessionWithKeySystem_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("contentKeySessionWithKeySystem:storageDirectoryAtURL:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVContentKeySession Create(NSString keySystem, NSUrl storageUrl)
	{
		if (keySystem == null)
		{
			throw new ArgumentNullException("keySystem");
		}
		if (storageUrl == null)
		{
			throw new ArgumentNullException("storageUrl");
		}
		return Runtime.GetNSObject<AVContentKeySession>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selContentKeySessionWithKeySystem_StorageDirectoryAtURL_Handle, keySystem.Handle, storageUrl.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVContentKeySession Create(AVContentKeySystem keySystem, NSUrl storageUrl)
	{
		return Create(keySystem.GetConstant(), storageUrl);
	}

	[Export("expire")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Expire()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selExpireHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selExpireHandle);
		}
	}

	[Export("pendingExpiredSessionReportsWithAppIdentifier:storageDirectoryAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary[] GetPendingExpiredSessionReports(NSData appIdentifier, NSUrl storageUrl)
	{
		if (appIdentifier == null)
		{
			throw new ArgumentNullException("appIdentifier");
		}
		if (storageUrl == null)
		{
			throw new ArgumentNullException("storageUrl");
		}
		return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPendingExpiredSessionReportsWithAppIdentifier_StorageDirectoryAtURL_Handle, appIdentifier.Handle, storageUrl.Handle));
	}

	[Export("invalidateAllPersistableContentKeysForApp:options:completionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void InvalidateAllPersistableContentKeys(NSData appIdentifier, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> handler)
	{
		if (appIdentifier == null)
		{
			throw new ArgumentNullException("appIdentifier");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInvalidateAllPersistableContentKeysForApp_Options_CompletionHandler_Handle, appIdentifier.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInvalidateAllPersistableContentKeysForApp_Options_CompletionHandler_Handle, appIdentifier.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> InvalidateAllPersistableContentKeysAsync(NSData appIdentifier, NSDictionary? options)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		InvalidateAllPersistableContentKeys(appIdentifier, options, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("invalidatePersistableContentKey:options:completionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void InvalidatePersistableContentKey(NSData persistableContentKeyData, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> handler)
	{
		if (persistableContentKeyData == null)
		{
			throw new ArgumentNullException("persistableContentKeyData");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInvalidatePersistableContentKey_Options_CompletionHandler_Handle, persistableContentKeyData.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInvalidatePersistableContentKey_Options_CompletionHandler_Handle, persistableContentKeyData.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> InvalidatePersistableContentKeyAsync(NSData persistableContentKeyData, NSDictionary? options)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		InvalidatePersistableContentKey(persistableContentKeyData, options, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("makeSecureTokenForExpirationDateOfPersistableContentKey:completionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void MakeSecureToken(NSData persistableContentKeyData, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> handler)
	{
		if (persistableContentKeyData == null)
		{
			throw new ArgumentNullException("persistableContentKeyData");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMakeSecureTokenForExpirationDateOfPersistableContentKey_CompletionHandler_Handle, persistableContentKeyData.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMakeSecureTokenForExpirationDateOfPersistableContentKey_CompletionHandler_Handle, persistableContentKeyData.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> MakeSecureTokenAsync(NSData persistableContentKeyData)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		MakeSecureToken(persistableContentKeyData, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("processContentKeyRequestWithIdentifier:initializationData:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ProcessContentKeyRequest(NSObject? identifier, NSData? initializationData, NSDictionary<NSString, NSObject>? options)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selProcessContentKeyRequestWithIdentifier_InitializationData_Options_Handle, identifier?.Handle ?? IntPtr.Zero, initializationData?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selProcessContentKeyRequestWithIdentifier_InitializationData_Options_Handle, identifier?.Handle ?? IntPtr.Zero, initializationData?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("removePendingExpiredSessionReports:withAppIdentifier:storageDirectoryAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemovePendingExpiredSessionReports(NSDictionary[] expiredSessionReports, NSData appIdentifier, NSUrl storageUrl)
	{
		if (expiredSessionReports == null)
		{
			throw new ArgumentNullException("expiredSessionReports");
		}
		if (appIdentifier == null)
		{
			throw new ArgumentNullException("appIdentifier");
		}
		if (storageUrl == null)
		{
			throw new ArgumentNullException("storageUrl");
		}
		NSArray nSArray = NSArray.FromNSObjects(expiredSessionReports);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRemovePendingExpiredSessionReports_WithAppIdentifier_StorageDirectoryAtURL_Handle, nSArray.Handle, appIdentifier.Handle, storageUrl.Handle);
		nSArray.Dispose();
	}

	[Export("renewExpiringResponseDataForContentKeyRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RenewExpiringResponseData(AVContentKeyRequest contentKeyRequest)
	{
		if (contentKeyRequest == null)
		{
			throw new ArgumentNullException("contentKeyRequest");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRenewExpiringResponseDataForContentKeyRequest_Handle, contentKeyRequest.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRenewExpiringResponseDataForContentKeyRequest_Handle, contentKeyRequest.Handle);
		}
	}

	[Export("setDelegate:queue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDelegate(IAVContentKeySessionDelegate? newDelegate, DispatchQueue? delegateQueue)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDelegate_Queue_Handle, newDelegate?.Handle ?? IntPtr.Zero, (delegateQueue == null) ? IntPtr.Zero : delegateQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDelegate_Queue_Handle, newDelegate?.Handle ?? IntPtr.Zero, (delegateQueue == null) ? IntPtr.Zero : delegateQueue.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
