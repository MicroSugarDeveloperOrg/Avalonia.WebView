using Foundation;
using ObjCRuntime;

namespace WebKit;

[Protocol(Name = "WebPolicyDelegate", WrapperType = typeof(WebPolicyDelegateWrapper), FormalSince = "10.11")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicyForNavigation", Selector = "webView:decidePolicyForNavigationAction:request:frame:decisionListener:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSDictionary),
    typeof(NSUrlRequest),
    typeof(WebFrame),
    typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicyForNewWindow", Selector = "webView:decidePolicyForNewWindowAction:request:newFrameName:decisionListener:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSDictionary),
    typeof(NSUrlRequest),
    typeof(string),
    typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecidePolicyForMimeType", Selector = "webView:decidePolicyForMIMEType:request:frame:decisionListener:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(string),
    typeof(NSUrlRequest),
    typeof(WebFrame),
    typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UnableToImplementPolicy", Selector = "webView:unableToImplementPolicyWithError:frame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSError),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IWebPolicyDelegate : INativeObject, IDisposable
{
}
