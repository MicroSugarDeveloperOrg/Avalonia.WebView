using Foundation;
using ObjCRuntime;

namespace WebKit;

public static class WKWebsiteDataType
{
    private static NSString? _Cookies;

    private static NSString? _DiskCache;

    private static NSString? _FetchCache;

    private static NSString? _IndexedDBDatabases;

    private static NSString? _LocalStorage;

    private static NSString? _MemoryCache;

    private static NSString? _OfflineWebApplicationCache;

    private static NSString? _ServiceWorkerRegistrations;

    private static NSString? _SessionStorage;

    private static NSString? _WebSQLDatabases;

    [Field("WKWebsiteDataTypeCookies", "WebKit")]
    public static NSString Cookies
    {
        get
        {
            if (_Cookies == null)
            {
                _Cookies = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeCookies");
            }
            return _Cookies;
        }
    }

    [Field("WKWebsiteDataTypeDiskCache", "WebKit")]
    public static NSString DiskCache
    {
        get
        {
            if (_DiskCache == null)
            {
                _DiskCache = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeDiskCache");
            }
            return _DiskCache;
        }
    }

    [Field("WKWebsiteDataTypeFetchCache", "WebKit")]
    public static NSString FetchCache
    {
        get
        {
            if (_FetchCache == null)
            {
                _FetchCache = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeFetchCache");
            }
            return _FetchCache;
        }
    }

    [Field("WKWebsiteDataTypeIndexedDBDatabases", "WebKit")]
    public static NSString IndexedDBDatabases
    {
        get
        {
            if (_IndexedDBDatabases == null)
            {
                _IndexedDBDatabases = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeIndexedDBDatabases");
            }
            return _IndexedDBDatabases;
        }
    }

    [Field("WKWebsiteDataTypeLocalStorage", "WebKit")]
    public static NSString LocalStorage
    {
        get
        {
            if (_LocalStorage == null)
            {
                _LocalStorage = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeLocalStorage");
            }
            return _LocalStorage;
        }
    }

    [Field("WKWebsiteDataTypeMemoryCache", "WebKit")]
    public static NSString MemoryCache
    {
        get
        {
            if (_MemoryCache == null)
            {
                _MemoryCache = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeMemoryCache");
            }
            return _MemoryCache;
        }
    }

    [Field("WKWebsiteDataTypeOfflineWebApplicationCache", "WebKit")]
    public static NSString OfflineWebApplicationCache
    {
        get
        {
            if (_OfflineWebApplicationCache == null)
            {
                _OfflineWebApplicationCache = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeOfflineWebApplicationCache");
            }
            return _OfflineWebApplicationCache;
        }
    }

    [Field("WKWebsiteDataTypeServiceWorkerRegistrations", "WebKit")]
    public static NSString ServiceWorkerRegistrations
    {
        get
        {
            if (_ServiceWorkerRegistrations == null)
            {
                _ServiceWorkerRegistrations = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeServiceWorkerRegistrations");
            }
            return _ServiceWorkerRegistrations;
        }
    }

    [Field("WKWebsiteDataTypeSessionStorage", "WebKit")]
    public static NSString SessionStorage
    {
        get
        {
            if (_SessionStorage == null)
            {
                _SessionStorage = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeSessionStorage");
            }
            return _SessionStorage;
        }
    }

    [Field("WKWebsiteDataTypeWebSQLDatabases", "WebKit")]
    public static NSString WebSQLDatabases
    {
        get
        {
            if (_WebSQLDatabases == null)
            {
                _WebSQLDatabases = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKWebsiteDataTypeWebSQLDatabases");
            }
            return _WebSQLDatabases;
        }
    }
}
