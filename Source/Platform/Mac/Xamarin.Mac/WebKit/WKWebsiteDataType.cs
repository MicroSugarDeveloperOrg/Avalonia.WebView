using Foundation;
using ObjCRuntime;

namespace WebKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class WKWebsiteDataType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Cookies;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DiskCache;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FetchCache;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IndexedDBDatabases;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalStorage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MemoryCache;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OfflineWebApplicationCache;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ServiceWorkerRegistrations;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SessionStorage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public static NSString FetchCache
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public static NSString ServiceWorkerRegistrations
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
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
