using Foundation;
using ObjCRuntime;

namespace WebKit;

[Protocol(Name = "WKScriptMessageHandler", WrapperType = typeof(WKScriptMessageHandlerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveScriptMessage", Selector = "userContentController:didReceiveScriptMessage:", ParameterType = new Type[]
{
    typeof(WKUserContentController),
    typeof(WKScriptMessage)
}, ParameterByRef = new bool[] { false, false })]
public interface IWKScriptMessageHandler : INativeObject, IDisposable
{
    [Export("userContentController:didReceiveScriptMessage:")]
    [Preserve(Conditional = true)]
    void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message);
}
