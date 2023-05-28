using System;
using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;

namespace Foundation;

[Register("NSHTTPCookieStorage", true)]
public class NSHttpCookieStorage : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveAcceptPolicyChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AcceptPolicyChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAcceptPolicyChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AcceptPolicyChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveCookiesChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CookiesChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveCookiesChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CookiesChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCookieAcceptPolicy = "cookieAcceptPolicy";

	private static readonly IntPtr selCookieAcceptPolicyHandle = Selector.GetHandle("cookieAcceptPolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCookies = "cookies";

	private static readonly IntPtr selCookiesHandle = Selector.GetHandle("cookies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCookiesForURL_ = "cookiesForURL:";

	private static readonly IntPtr selCookiesForURL_Handle = Selector.GetHandle("cookiesForURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteCookie_ = "deleteCookie:";

	private static readonly IntPtr selDeleteCookie_Handle = Selector.GetHandle("deleteCookie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCookiesForTask_CompletionHandler_ = "getCookiesForTask:completionHandler:";

	private static readonly IntPtr selGetCookiesForTask_CompletionHandler_Handle = Selector.GetHandle("getCookiesForTask:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCookiesSinceDate_ = "removeCookiesSinceDate:";

	private static readonly IntPtr selRemoveCookiesSinceDate_Handle = Selector.GetHandle("removeCookiesSinceDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCookie_ = "setCookie:";

	private static readonly IntPtr selSetCookie_Handle = Selector.GetHandle("setCookie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCookieAcceptPolicy_ = "setCookieAcceptPolicy:";

	private static readonly IntPtr selSetCookieAcceptPolicy_Handle = Selector.GetHandle("setCookieAcceptPolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCookies_ForURL_MainDocumentURL_ = "setCookies:forURL:mainDocumentURL:";

	private static readonly IntPtr selSetCookies_ForURL_MainDocumentURL_Handle = Selector.GetHandle("setCookies:forURL:mainDocumentURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedCookieStorageForGroupContainerIdentifier_ = "sharedCookieStorageForGroupContainerIdentifier:";

	private static readonly IntPtr selSharedCookieStorageForGroupContainerIdentifier_Handle = Selector.GetHandle("sharedCookieStorageForGroupContainerIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedHTTPCookieStorage = "sharedHTTPCookieStorage";

	private static readonly IntPtr selSharedHTTPCookieStorageHandle = Selector.GetHandle("sharedHTTPCookieStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortedCookiesUsingDescriptors_ = "sortedCookiesUsingDescriptors:";

	private static readonly IntPtr selSortedCookiesUsingDescriptors_Handle = Selector.GetHandle("sortedCookiesUsingDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoreCookies_ForTask_ = "storeCookies:forTask:";

	private static readonly IntPtr selStoreCookies_ForTask_Handle = Selector.GetHandle("storeCookies:forTask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSHTTPCookieStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AcceptPolicyChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CookiesChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSHttpCookieAcceptPolicy AcceptPolicy
	{
		[Export("cookieAcceptPolicy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSHttpCookieAcceptPolicy)Messaging.UInt64_objc_msgSend(base.Handle, selCookieAcceptPolicyHandle);
			}
			return (NSHttpCookieAcceptPolicy)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCookieAcceptPolicyHandle);
		}
		[Export("setCookieAcceptPolicy:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCookieAcceptPolicy_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCookieAcceptPolicy_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSHttpCookie[] Cookies
	{
		[Export("cookies")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSend(base.Handle, selCookiesHandle));
			}
			return NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCookiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSHttpCookieStorage SharedStorage
	{
		[Export("sharedHTTPCookieStorage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSHttpCookieStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedHTTPCookieStorageHandle));
		}
	}

	[Field("NSHTTPCookieManagerCookiesChangedNotification", "Foundation")]
	[Advice("Use NSHttpCookieStorage.Notifications.ObserveAcceptPolicyChanged helper method instead.")]
	public static NSString AcceptPolicyChangedNotification
	{
		get
		{
			if (_AcceptPolicyChangedNotification == null)
			{
				_AcceptPolicyChangedNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieManagerCookiesChangedNotification");
			}
			return _AcceptPolicyChangedNotification;
		}
	}

	[Field("NSHTTPCookieManagerAcceptPolicyChangedNotification", "Foundation")]
	[Advice("Use NSHttpCookieStorage.Notifications.ObserveCookiesChanged helper method instead.")]
	public static NSString CookiesChangedNotification
	{
		get
		{
			if (_CookiesChangedNotification == null)
			{
				_CookiesChangedNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHTTPCookieManagerAcceptPolicyChangedNotification");
			}
			return _CookiesChangedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSHttpCookieStorage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSHttpCookieStorage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cookiesForURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSHttpCookie[] CookiesForUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCookiesForURL_Handle, url.Handle));
		}
		return NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCookiesForURL_Handle, url.Handle));
	}

	[Export("deleteCookie:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteCookie(NSHttpCookie cookie)
	{
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteCookie_Handle, cookie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteCookie_Handle, cookie.Handle);
		}
	}

	[Export("getCookiesForTask:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetCookiesForTask(NSUrlSessionTask task, [BlockProxy(typeof(Trampolines.NIDActionArity1V31))] Action<NSHttpCookie[]> completionHandler)
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V31.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetCookiesForTask_CompletionHandler_Handle, task.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetCookiesForTask_CompletionHandler_Handle, task.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSHttpCookie[]> GetCookiesForTaskAsync(NSUrlSessionTask task)
	{
		TaskCompletionSource<NSHttpCookie[]> tcs = new TaskCompletionSource<NSHttpCookie[]>();
		GetCookiesForTask(task, delegate(NSHttpCookie[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("sharedCookieStorageForGroupContainerIdentifier:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSHttpCookieStorage GetSharedCookieStorage(string groupContainerIdentifier)
	{
		if (groupContainerIdentifier == null)
		{
			throw new ArgumentNullException("groupContainerIdentifier");
		}
		IntPtr arg = NSString.CreateNative(groupContainerIdentifier);
		NSHttpCookieStorage nSObject = Runtime.GetNSObject<NSHttpCookieStorage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSharedCookieStorageForGroupContainerIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("sortedCookiesUsingDescriptors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSHttpCookie[] GetSortedCookies(NSSortDescriptor[] sortDescriptors)
	{
		if (sortDescriptors == null)
		{
			throw new ArgumentNullException("sortDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(sortDescriptors);
		NSHttpCookie[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSortedCookiesUsingDescriptors_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<NSHttpCookie>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSortedCookiesUsingDescriptors_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("removeCookiesSinceDate:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCookiesSinceDate(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveCookiesSinceDate_Handle, date.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveCookiesSinceDate_Handle, date.Handle);
		}
	}

	[Export("setCookie:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCookie(NSHttpCookie cookie)
	{
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCookie_Handle, cookie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCookie_Handle, cookie.Handle);
		}
	}

	[Export("setCookies:forURL:mainDocumentURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCookies(NSHttpCookie[] cookies, NSUrl forUrl, NSUrl mainDocumentUrl)
	{
		if (cookies == null)
		{
			throw new ArgumentNullException("cookies");
		}
		if (forUrl == null)
		{
			throw new ArgumentNullException("forUrl");
		}
		if (mainDocumentUrl == null)
		{
			throw new ArgumentNullException("mainDocumentUrl");
		}
		NSArray nSArray = NSArray.FromNSObjects(cookies);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetCookies_ForURL_MainDocumentURL_Handle, nSArray.Handle, forUrl.Handle, mainDocumentUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetCookies_ForURL_MainDocumentURL_Handle, nSArray.Handle, forUrl.Handle, mainDocumentUrl.Handle);
		}
		nSArray.Dispose();
	}

	[Export("storeCookies:forTask:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StoreCookies(NSHttpCookie[] cookies, NSUrlSessionTask task)
	{
		if (cookies == null)
		{
			throw new ArgumentNullException("cookies");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		NSArray nSArray = NSArray.FromNSObjects(cookies);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStoreCookies_ForTask_Handle, nSArray.Handle, task.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStoreCookies_ForTask_Handle, nSArray.Handle, task.Handle);
		}
		nSArray.Dispose();
	}
}
