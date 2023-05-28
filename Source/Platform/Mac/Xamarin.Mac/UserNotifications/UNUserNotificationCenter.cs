using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Register("UNUserNotificationCenter", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class UNUserNotificationCenter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddNotificationRequest_WithCompletionHandler_ = "addNotificationRequest:withCompletionHandler:";

	private static readonly IntPtr selAddNotificationRequest_WithCompletionHandler_Handle = Selector.GetHandle("addNotificationRequest:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentNotificationCenter = "currentNotificationCenter";

	private static readonly IntPtr selCurrentNotificationCenterHandle = Selector.GetHandle("currentNotificationCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDeliveredNotificationsWithCompletionHandler_ = "getDeliveredNotificationsWithCompletionHandler:";

	private static readonly IntPtr selGetDeliveredNotificationsWithCompletionHandler_Handle = Selector.GetHandle("getDeliveredNotificationsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetNotificationCategoriesWithCompletionHandler_ = "getNotificationCategoriesWithCompletionHandler:";

	private static readonly IntPtr selGetNotificationCategoriesWithCompletionHandler_Handle = Selector.GetHandle("getNotificationCategoriesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetNotificationSettingsWithCompletionHandler_ = "getNotificationSettingsWithCompletionHandler:";

	private static readonly IntPtr selGetNotificationSettingsWithCompletionHandler_Handle = Selector.GetHandle("getNotificationSettingsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetPendingNotificationRequestsWithCompletionHandler_ = "getPendingNotificationRequestsWithCompletionHandler:";

	private static readonly IntPtr selGetPendingNotificationRequestsWithCompletionHandler_Handle = Selector.GetHandle("getPendingNotificationRequestsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllDeliveredNotifications = "removeAllDeliveredNotifications";

	private static readonly IntPtr selRemoveAllDeliveredNotificationsHandle = Selector.GetHandle("removeAllDeliveredNotifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllPendingNotificationRequests = "removeAllPendingNotificationRequests";

	private static readonly IntPtr selRemoveAllPendingNotificationRequestsHandle = Selector.GetHandle("removeAllPendingNotificationRequests");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveDeliveredNotificationsWithIdentifiers_ = "removeDeliveredNotificationsWithIdentifiers:";

	private static readonly IntPtr selRemoveDeliveredNotificationsWithIdentifiers_Handle = Selector.GetHandle("removeDeliveredNotificationsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovePendingNotificationRequestsWithIdentifiers_ = "removePendingNotificationRequestsWithIdentifiers:";

	private static readonly IntPtr selRemovePendingNotificationRequestsWithIdentifiers_Handle = Selector.GetHandle("removePendingNotificationRequestsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAuthorizationWithOptions_CompletionHandler_ = "requestAuthorizationWithOptions:completionHandler:";

	private static readonly IntPtr selRequestAuthorizationWithOptions_CompletionHandler_Handle = Selector.GetHandle("requestAuthorizationWithOptions:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNotificationCategories_ = "setNotificationCategories:";

	private static readonly IntPtr selSetNotificationCategories_Handle = Selector.GetHandle("setNotificationCategories:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsContentExtensions = "supportsContentExtensions";

	private static readonly IntPtr selSupportsContentExtensionsHandle = Selector.GetHandle("supportsContentExtensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("UNUserNotificationCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static UNUserNotificationCenter Current
	{
		[Export("currentNotificationCenter")]
		get
		{
			return Runtime.GetNSObject<UNUserNotificationCenter>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentNotificationCenterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IUNUserNotificationCenterDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			IUNUserNotificationCenterDelegate iUNUserNotificationCenterDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IUNUserNotificationCenterDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<IUNUserNotificationCenterDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iUNUserNotificationCenterDelegate;
			return iUNUserNotificationCenterDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsContentExtensions
	{
		[Export("supportsContentExtensions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsContentExtensionsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsContentExtensionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected UNUserNotificationCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal UNUserNotificationCenter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addNotificationRequest:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AddNotificationRequest(UNNotificationRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddNotificationRequest_WithCompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddNotificationRequest_WithCompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task AddNotificationRequestAsync(UNNotificationRequest request)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		AddNotificationRequest(request, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("getDeliveredNotificationsWithCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetDeliveredNotifications([BlockProxy(typeof(Trampolines.NIDActionArity1V88))] Action<UNNotification[]> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V88.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetDeliveredNotificationsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetDeliveredNotificationsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<UNNotification[]> GetDeliveredNotificationsAsync()
	{
		TaskCompletionSource<UNNotification[]> tcs = new TaskCompletionSource<UNNotification[]>();
		GetDeliveredNotifications(delegate(UNNotification[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("getNotificationCategoriesWithCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetNotificationCategories([BlockProxy(typeof(Trampolines.NIDActionArity1V89))] Action<NSSet<UNNotificationCategory>> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V89.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetNotificationCategoriesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetNotificationCategoriesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSSet<UNNotificationCategory>> GetNotificationCategoriesAsync()
	{
		TaskCompletionSource<NSSet<UNNotificationCategory>> tcs = new TaskCompletionSource<NSSet<UNNotificationCategory>>();
		GetNotificationCategories(delegate(NSSet<UNNotificationCategory> obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("getNotificationSettingsWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetNotificationSettings([BlockProxy(typeof(Trampolines.NIDActionArity1V90))] Action<UNNotificationSettings> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V90.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetNotificationSettingsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetNotificationSettingsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<UNNotificationSettings> GetNotificationSettingsAsync()
	{
		TaskCompletionSource<UNNotificationSettings> tcs = new TaskCompletionSource<UNNotificationSettings>();
		GetNotificationSettings(delegate(UNNotificationSettings obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("getPendingNotificationRequestsWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetPendingNotificationRequests([BlockProxy(typeof(Trampolines.NIDActionArity1V91))] Action<UNNotificationRequest[]> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V91.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetPendingNotificationRequestsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetPendingNotificationRequestsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<UNNotificationRequest[]> GetPendingNotificationRequestsAsync()
	{
		TaskCompletionSource<UNNotificationRequest[]> tcs = new TaskCompletionSource<UNNotificationRequest[]>();
		GetPendingNotificationRequests(delegate(UNNotificationRequest[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("removeAllDeliveredNotifications")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllDeliveredNotifications()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllDeliveredNotificationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllDeliveredNotificationsHandle);
		}
	}

	[Export("removeAllPendingNotificationRequests")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllPendingNotificationRequests()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllPendingNotificationRequestsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllPendingNotificationRequestsHandle);
		}
	}

	[Export("removeDeliveredNotificationsWithIdentifiers:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveDeliveredNotifications(string[] identifiers)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveDeliveredNotificationsWithIdentifiers_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveDeliveredNotificationsWithIdentifiers_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removePendingNotificationRequestsWithIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemovePendingNotificationRequests(string[] identifiers)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemovePendingNotificationRequestsWithIdentifiers_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemovePendingNotificationRequestsWithIdentifiers_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("requestAuthorizationWithOptions:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RequestAuthorization(UNAuthorizationOptions options, [BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V4.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selRequestAuthorizationWithOptions_CompletionHandler_Handle, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selRequestAuthorizationWithOptions_CompletionHandler_Handle, (ulong)options, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<Tuple<bool, NSError>> RequestAuthorizationAsync(UNAuthorizationOptions options)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		RequestAuthorization(options, delegate(bool arg1_, NSError arg2_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[Export("setNotificationCategories:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNotificationCategories(NSSet<UNNotificationCategory> categories)
	{
		if (categories == null)
		{
			throw new ArgumentNullException("categories");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNotificationCategories_Handle, categories.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNotificationCategories_Handle, categories.Handle);
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
