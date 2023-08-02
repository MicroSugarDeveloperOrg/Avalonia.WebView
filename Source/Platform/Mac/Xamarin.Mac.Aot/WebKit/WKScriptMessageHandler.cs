using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Protocol]
[Register("WKScriptMessageHandler", false)]
[Model]
public abstract class WKScriptMessageHandler : NSObject, IWKScriptMessageHandler, INativeObject, IDisposable
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    protected WKScriptMessageHandler()
        : base(NSObjectFlag.Empty)
    {
        IsDirectBinding = false;
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKScriptMessageHandler(NSObjectFlag t)
        : base(t)
    {
        IsDirectBinding = false;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKScriptMessageHandler(IntPtr handle)
        : base(handle)
    {
        IsDirectBinding = false;
    }

    [Export("userContentController:didReceiveScriptMessage:")]
    public abstract void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message);
}
