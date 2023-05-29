using AppKit;
using Foundation;
using JavaScriptCore;
using ObjCRuntime;

namespace WebKit;

[Protocol(Name = "WebFrameLoadDelegate", WrapperType = typeof(WebFrameLoadDelegateWrapper), FormalSince = "10.11")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartedProvisionalLoad", Selector = "webView:didStartProvisionalLoadForFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedServerRedirectForProvisionalLoad", Selector = "webView:didReceiveServerRedirectForProvisionalLoadForFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedProvisionalLoad", Selector = "webView:didFailProvisionalLoadWithError:forFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSError),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CommitedLoad", Selector = "webView:didCommitLoadForFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedTitle", Selector = "webView:didReceiveTitle:forFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(string),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedIcon", Selector = "webView:didReceiveIcon:forFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSImage),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedLoad", Selector = "webView:didFinishLoadForFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedLoadWithError", Selector = "webView:didFailLoadWithError:forFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSError),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangedLocationWithinPage", Selector = "webView:didChangeLocationWithinPageForFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPerformClientRedirect", Selector = "webView:willPerformClientRedirectToURL:delay:fireDate:forFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(NSUrl),
    typeof(double),
    typeof(NSDate),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanceledClientRedirect", Selector = "webView:didCancelClientRedirectForFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCloseFrame", Selector = "webView:willCloseFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClearedWindowObject", Selector = "webView:didClearWindowObject:forFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(WebScriptObject),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WindowScriptObjectAvailable", Selector = "webView:windowScriptObjectAvailable:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(WebScriptObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCreateJavaScriptContext", Selector = "webView:didCreateJavaScriptContext:forFrame:", ParameterType = new Type[]
{
    typeof(WebView),
    typeof(JSContext),
    typeof(WebFrame)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IWebFrameLoadDelegate : INativeObject, IDisposable
{
}
