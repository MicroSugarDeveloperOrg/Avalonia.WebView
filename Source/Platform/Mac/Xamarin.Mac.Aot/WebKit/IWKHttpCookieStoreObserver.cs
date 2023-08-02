using Foundation;
using ObjCRuntime;
namespace WebKit;

[Protocol(Name = "WKHTTPCookieStoreObserver", WrapperType = typeof(WKHttpCookieStoreObserverWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CookiesDidChangeInCookieStore", Selector = "cookiesDidChangeInCookieStore:", ParameterType = new Type[] { typeof(WKHttpCookieStore) }, ParameterByRef = new bool[] { false })]
public interface IWKHttpCookieStoreObserver : INativeObject, IDisposable
{
}
