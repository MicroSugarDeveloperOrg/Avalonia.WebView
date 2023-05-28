using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "WKHTTPCookieStoreObserver", WrapperType = typeof(WKHttpCookieStoreObserverWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CookiesDidChangeInCookieStore", Selector = "cookiesDidChangeInCookieStore:", ParameterType = new Type[] { typeof(WKHttpCookieStore) }, ParameterByRef = new bool[] { false })]
public interface IWKHttpCookieStoreObserver : INativeObject, IDisposable
{
}
