using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WKHTTPCookieStore", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class WKHttpCookieStore : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObserver_ = "addObserver:";

	private static readonly IntPtr selAddObserver_Handle = Selector.GetHandle("addObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteCookie_CompletionHandler_ = "deleteCookie:completionHandler:";

	private static readonly IntPtr selDeleteCookie_CompletionHandler_Handle = Selector.GetHandle("deleteCookie:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAllCookies_ = "getAllCookies:";

	private static readonly IntPtr selGetAllCookies_Handle = Selector.GetHandle("getAllCookies:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObserver_ = "removeObserver:";

	private static readonly IntPtr selRemoveObserver_Handle = Selector.GetHandle("removeObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCookie_CompletionHandler_ = "setCookie:completionHandler:";

	private static readonly IntPtr selSetCookie_CompletionHandler_Handle = Selector.GetHandle("setCookie:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKHTTPCookieStore");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WKHttpCookieStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKHttpCookieStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObserver(IWKHttpCookieStoreObserver observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObserver_Handle, observer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObserver_Handle, observer.Handle);
		}
	}

	[Export("deleteCookie:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DeleteCookie(NSHttpCookie cookie, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDeleteCookie_CompletionHandler_Handle, cookie.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDeleteCookie_CompletionHandler_Handle, cookie.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task DeleteCookieAsync(NSHttpCookie cookie)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DeleteCookie(cookie, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("getAllCookies:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetAllCookies([BlockProxy(typeof(Trampolines.NIDActionArity1V31))] Action<NSHttpCookie[]> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V31.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetAllCookies_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetAllCookies_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSHttpCookie[]> GetAllCookiesAsync()
	{
		TaskCompletionSource<NSHttpCookie[]> tcs = new TaskCompletionSource<NSHttpCookie[]>();
		GetAllCookies(delegate(NSHttpCookie[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("removeObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObserver(IWKHttpCookieStoreObserver observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObserver_Handle, observer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObserver_Handle, observer.Handle);
		}
	}

	[Export("setCookie:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetCookie(NSHttpCookie cookie, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		if (cookie == null)
		{
			throw new ArgumentNullException("cookie");
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetCookie_CompletionHandler_Handle, cookie.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetCookie_CompletionHandler_Handle, cookie.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SetCookieAsync(NSHttpCookie cookie)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SetCookie(cookie, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}
}
