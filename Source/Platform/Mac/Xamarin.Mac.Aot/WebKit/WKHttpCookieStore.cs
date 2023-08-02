using Foundation;
using ObjCRuntime;
using System.ComponentModel;
using Xamarin.Utiles;

namespace WebKit;

[Register("WKHTTPCookieStore", true)]
public class WKHttpCookieStore : NSObject
{
    private const string selAddObserver_ = "addObserver:";
    private static readonly IntPtr selAddObserver_Handle = Selector.GetHandle("addObserver:");

    private const string selDeleteCookie_CompletionHandler_ = "deleteCookie:completionHandler:";
    private static readonly IntPtr selDeleteCookie_CompletionHandler_Handle = Selector.GetHandle("deleteCookie:completionHandler:");

    private const string selGetAllCookies_ = "getAllCookies:";
    private static readonly IntPtr selGetAllCookies_Handle = Selector.GetHandle("getAllCookies:");

    private const string selRemoveObserver_ = "removeObserver:";
    private static readonly IntPtr selRemoveObserver_Handle = Selector.GetHandle("removeObserver:");

    private const string selSetCookie_CompletionHandler_ = "setCookie:completionHandler:";
    private static readonly IntPtr selSetCookie_CompletionHandler_Handle = Selector.GetHandle("setCookie:completionHandler:");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKHTTPCookieStore");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKHttpCookieStore(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKHttpCookieStore(IntPtr handle)
        : base(handle)
    {
    }

    [Export("addObserver:")]
    public virtual void AddObserver(IWKHttpCookieStoreObserver observer)
    {
        if (observer == null)
            throw new ArgumentNullException("observer");

        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr(Handle, selAddObserver_Handle, observer.Handle);
        else
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selAddObserver_Handle, observer.Handle);
    }

    [Export("deleteCookie:completionHandler:")]
    public unsafe virtual void DeleteCookie(NSHttpCookie cookie, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
    {
        if (cookie == null)
            throw new ArgumentNullException("cookie");

        BlockLiteral* ptr;
        if (completionHandler == null)
            ptr = null;
        else
        {
            BlockLiteral blockLiteral = default(BlockLiteral);
            ptr = &blockLiteral;
            blockLiteral.SetupBlock(Trampolines.SDAction.Handler, completionHandler);
        }
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selDeleteCookie_CompletionHandler_Handle, cookie.Handle, (IntPtr)ptr);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selDeleteCookie_CompletionHandler_Handle, cookie.Handle, (IntPtr)ptr);

        if (ptr != null)
            ptr->CleanupBlock();
    }

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
    public unsafe virtual void GetAllCookies([BlockProxy(typeof(Trampolines.NIDActionArity1V31))] Action<NSHttpCookie[]> completionHandler)
    {
        if (completionHandler == null)
            throw new ArgumentNullException("completionHandler");

        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDActionArity1V31.Handler, completionHandler);
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr(Handle, selGetAllCookies_Handle, (IntPtr)ptr);
        else
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selGetAllCookies_Handle, (IntPtr)ptr);

        ptr->CleanupBlock();
    }

    public virtual Task<NSHttpCookie[]> GetAllCookiesAsync()
    {
        TaskCompletionSource<NSHttpCookie[]> tcs = new TaskCompletionSource<NSHttpCookie[]>();
        GetAllCookies(delegate (NSHttpCookie[] obj_)
        {
            tcs.SetResult(obj_);
        });
        return tcs.Task;
    }

    [Export("removeObserver:")]
    public virtual void RemoveObserver(IWKHttpCookieStoreObserver observer)
    {
        if (observer == null)
            throw new ArgumentNullException("observer");

        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr(Handle, selRemoveObserver_Handle, observer.Handle);
        else
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selRemoveObserver_Handle, observer.Handle);
    }

    [Export("setCookie:completionHandler:")]
    public unsafe virtual void SetCookie(NSHttpCookie cookie, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
    {
        if (cookie == null)
            throw new ArgumentNullException("cookie");

        BlockLiteral* ptr;
        if (completionHandler == null)
            ptr = null;
        else
        {
            BlockLiteral blockLiteral = default(BlockLiteral);
            ptr = &blockLiteral;
            blockLiteral.SetupBlock(Trampolines.SDAction.Handler, completionHandler);
        }
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetCookie_CompletionHandler_Handle, cookie.Handle, (IntPtr)ptr);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetCookie_CompletionHandler_Handle, cookie.Handle, (IntPtr)ptr);

        if (ptr != null)
            ptr->CleanupBlock();
    }

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