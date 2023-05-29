using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKScriptMessage", true)]
public class WKScriptMessage : NSObject
{
    private const string selBody = "body";
    private static readonly IntPtr selBodyHandle = Selector.GetHandle("body");

    private const string selFrameInfo = "frameInfo";
    private static readonly IntPtr selFrameInfoHandle = Selector.GetHandle("frameInfo");

    private const string selName = "name";
    private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

    private const string selWebView = "webView";
    private static readonly IntPtr selWebViewHandle = Selector.GetHandle("webView");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKScriptMessage");

    private object? __mt_WebView_var;

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKScriptMessage()
    : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKScriptMessage(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKScriptMessage(IntPtr handle)
        : base(handle)
    {
    }

    public virtual NSObject Body
    {
        [Export("body", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selBodyHandle));
            }
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selBodyHandle));
        }
    }

    public virtual WKFrameInfo FrameInfo
    {
        [Export("frameInfo", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<WKFrameInfo>(Messaging.IntPtr_objc_msgSend(Handle, selFrameInfoHandle));
            }
            return Runtime.GetNSObjectTx<WKFrameInfo>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selFrameInfoHandle));
        }
    }

    public virtual string Name
    {
        [Export("name")]
        get
        {
            if (IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selNameHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selNameHandle));
        }
    }

    public virtual WKWebView WebView
    {
        [Export("webView", ArgumentSemantic.Weak)]
        get
        {
            WKWebView wKWebView = ((!IsDirectBinding) ? Runtime.GetNSObjectTx<WKWebView>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selWebViewHandle)) : Runtime.GetNSObjectTx<WKWebView>(Messaging.IntPtr_objc_msgSend(Handle, selWebViewHandle)));
            __mt_WebView_var = wKWebView;
            return wKWebView;
        }
    }

    protected override void Dispose(bool disposing)
    {
        Dispose(disposing);
        if (Handle == IntPtr.Zero)
            __mt_WebView_var = null;
    }
}