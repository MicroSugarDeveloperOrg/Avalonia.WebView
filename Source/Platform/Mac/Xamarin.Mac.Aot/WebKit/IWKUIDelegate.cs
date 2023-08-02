using Foundation;
using ObjCRuntime;

namespace WebKit;

[Protocol(Name = "WKUIDelegate", WrapperType = typeof(WKUIDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateWebView", Selector = "webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:", ReturnType = typeof(WKWebView), ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKWebViewConfiguration),
    typeof(WKNavigationAction),
    typeof(WKWindowFeatures)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RunJavaScriptAlertPanel", Selector = "webView:runJavaScriptAlertPanelWithMessage:initiatedByFrame:completionHandler:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(string),
    typeof(WKFrameInfo),
    typeof(Action)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
    null,
    null,
    null,
    typeof(Trampolines.NIDAction)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RunJavaScriptConfirmPanel", Selector = "webView:runJavaScriptConfirmPanelWithMessage:initiatedByFrame:completionHandler:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(string),
    typeof(WKFrameInfo),
    typeof(Action<bool>)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
    null,
    null,
    null,
    typeof(Trampolines.NIDActionArity1V2)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RunJavaScriptTextInputPanel", Selector = "webView:runJavaScriptTextInputPanelWithPrompt:defaultText:initiatedByFrame:completionHandler:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(string),
    typeof(string),
    typeof(WKFrameInfo),
    typeof(Action<string>)
}, ParameterByRef = new bool[] { false, false, false, false, false }, ParameterBlockProxy = new Type[]
{
    null,
    null,
    null,
    null,
    typeof(Trampolines.NIDActionArity1V44)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RunOpenPanel", Selector = "webView:runOpenPanelWithParameters:initiatedByFrame:completionHandler:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(WKOpenPanelParameters),
    typeof(WKFrameInfo),
    typeof(Action<NSUrl[]>)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
    null,
    null,
    null,
    typeof(Trampolines.NIDActionArity1V95)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClose", Selector = "webViewDidClose:", ParameterType = new Type[] { typeof(WKWebView) }, ParameterByRef = new bool[] { false })]

public interface IWKUIDelegate : INativeObject, IDisposable
{
}
