using Foundation;
using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace WebKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "WKURLSchemeHandler", WrapperType = typeof(WKUrlSchemeHandlerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartUrlSchemeTask", Selector = "webView:startURLSchemeTask:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(IWKUrlSchemeTask)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StopUrlSchemeTask", Selector = "webView:stopURLSchemeTask:", ParameterType = new Type[]
{
    typeof(WKWebView),
    typeof(IWKUrlSchemeTask)
}, ParameterByRef = new bool[] { false, false })]
public interface IWKUrlSchemeHandler : INativeObject, IDisposable
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("webView:startURLSchemeTask:")]
    [Preserve(Conditional = true)]
    void StartUrlSchemeTask(WKWebView webView, IWKUrlSchemeTask urlSchemeTask);

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("webView:stopURLSchemeTask:")]
    [Preserve(Conditional = true)]
    void StopUrlSchemeTask(WKWebView webView, IWKUrlSchemeTask urlSchemeTask);
}
