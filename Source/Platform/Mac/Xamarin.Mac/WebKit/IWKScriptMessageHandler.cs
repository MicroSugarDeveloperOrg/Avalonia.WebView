using Foundation;
using ObjCRuntime;

namespace WebKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "WKScriptMessageHandler", WrapperType = typeof(WKScriptMessageHandlerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveScriptMessage", Selector = "userContentController:didReceiveScriptMessage:", ParameterType = new Type[]
{
    typeof(WKUserContentController),
    typeof(WKScriptMessage)
}, ParameterByRef = new bool[] { false, false })]
public interface IWKScriptMessageHandler : INativeObject, IDisposable
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("userContentController:didReceiveScriptMessage:")]
    [Preserve(Conditional = true)]
    void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message);
}
