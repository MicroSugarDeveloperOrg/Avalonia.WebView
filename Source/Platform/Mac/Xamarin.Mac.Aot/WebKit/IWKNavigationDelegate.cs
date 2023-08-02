using Foundation;
using ObjCRuntime;
namespace WebKit;

[Protocol(Name = "WKNavigationDelegate", WrapperType = typeof(WKNavigationDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicy", Selector = "webView:decidePolicyForNavigationAction:decisionHandler:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKNavigationAction),
    typeof(Action<WKNavigationActionPolicy>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
    null,
    null,
    typeof(Trampolines.NIDActionArity1V93)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicy", Selector = "webView:decidePolicyForNavigationResponse:decisionHandler:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKNavigationResponse),
    typeof(Action<WKNavigationResponsePolicy>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
    null,
    null,
    typeof(Trampolines.NIDActionArity1V94)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicy", Selector = "webView:decidePolicyForNavigationAction:preferences:decisionHandler:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKNavigationAction),
    typeof(WKWebpagePreferences),
    typeof(Action<WKNavigationActionPolicy, WKWebpagePreferences>)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
    null,
    null,
    null,
    typeof(Trampolines.NIDActionArity2V85)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStartProvisionalNavigation", Selector = "webView:didStartProvisionalNavigation:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKNavigation)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveServerRedirectForProvisionalNavigation", Selector = "webView:didReceiveServerRedirectForProvisionalNavigation:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKNavigation)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailProvisionalNavigation", Selector = "webView:didFailProvisionalNavigation:withError:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKNavigation),
    typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCommitNavigation", Selector = "webView:didCommitNavigation:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKNavigation)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishNavigation", Selector = "webView:didFinishNavigation:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKNavigation)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailNavigation", Selector = "webView:didFailNavigation:withError:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKNavigation),
    typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveAuthenticationChallenge", Selector = "webView:didReceiveAuthenticationChallenge:completionHandler:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(NSUrlAuthenticationChallenge),
    typeof(Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
    null,
    null,
    typeof(Trampolines.NIDActionArity2V44)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContentProcessDidTerminate", Selector = "webViewWebContentProcessDidTerminate:", ParameterType = new Type[] { typeof(WKWebView) }, ParameterByRef = new bool[] { false })]

public interface IWKNavigationDelegate : INativeObject, IDisposable
{
}