using Foundation;
using ObjCRuntime;

namespace WebKit;

[Protocol(Name = "WebResourceLoadDelegate", WrapperType = typeof(WebResourceLoadDelegateWrapper), FormalSince = "10.11")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnIdentifierForInitialRequest", Selector = "webView:identifierForInitialRequest:fromDataSource:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSUrlRequest),
    typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSendRequest", Selector = "webView:resource:willSendRequest:redirectResponse:fromDataSource:", ReturnType = typeof(NSUrlRequest), ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSObject),
    typeof(NSUrlRequest),
    typeof(NSUrlResponse),
    typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnReceivedAuthenticationChallenge", Selector = "webView:resource:didReceiveAuthenticationChallenge:fromDataSource:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSObject),
    typeof(NSUrlAuthenticationChallenge),
    typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCancelledAuthenticationChallenge", Selector = "webView:resource:didCancelAuthenticationChallenge:fromDataSource:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSObject),
    typeof(NSUrlAuthenticationChallenge),
    typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnReceivedResponse", Selector = "webView:resource:didReceiveResponse:fromDataSource:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSObject),
    typeof(NSUrlResponse),
    typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnReceivedContentLength", Selector = "webView:resource:didReceiveContentLength:fromDataSource:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSObject),
    typeof(nint),
    typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFinishedLoading", Selector = "webView:resource:didFinishLoadingFromDataSource:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSObject),
    typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFailedLoading", Selector = "webView:resource:didFailLoadingWithError:fromDataSource:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSObject),
    typeof(NSError),
    typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPlugInFailed", Selector = "webView:plugInFailedWithError:dataSource:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSError),
    typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IWebResourceLoadDelegate : INativeObject, IDisposable
{
}