using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKFrameInfo", true)]
public class WKFrameInfo : NSObject 
{
    private const string selCopyWithZone_ = "copyWithZone:";
    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    private const string selIsMainFrame = "isMainFrame";
    private static readonly IntPtr selIsMainFrameHandle = Selector.GetHandle("isMainFrame");

    private const string selRequest = "request";
    private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

    private const string selSecurityOrigin = "securityOrigin";
    private static readonly IntPtr selSecurityOriginHandle = Selector.GetHandle("securityOrigin");

    private const string selWebView = "webView";
    private static readonly IntPtr selWebViewHandle = Selector.GetHandle("webView");

    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKFrameInfo");

    private object? __mt_WebView_var;
    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKFrameInfo()
       : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKFrameInfo(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKFrameInfo(IntPtr handle)
        : base(handle)
    {
    }


    public virtual bool MainFrame
    {
        [Export("isMainFrame")]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selIsMainFrameHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsMainFrameHandle);
        }
    }

    public virtual NSUrlRequest Request
    {
        [Export("request", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(Handle, selRequestHandle));

            return Runtime.GetNSObjectTx<NSUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selRequestHandle));
        }
    }

    public virtual WKSecurityOrigin SecurityOrigin
    {
        [Export("securityOrigin")]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<WKSecurityOrigin>(Messaging.IntPtr_objc_msgSend(Handle, selSecurityOriginHandle));

            return Runtime.GetNSObjectTx<WKSecurityOrigin>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selSecurityOriginHandle));
        }
    }

    public virtual WKWebView? WebView
    {
        [Export("webView", ArgumentSemantic.Weak)]
        get
        {
            WKWebView wKWebView = ((!IsDirectBinding) ? Runtime.GetNSObjectTx<WKWebView>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selWebViewHandle)) : Runtime.GetNSObjectTx<WKWebView>(Messaging.IntPtr_objc_msgSend(Handle, selWebViewHandle)));
            __mt_WebView_var = wKWebView;
            return wKWebView;
        }
    }
     
    [Export("copyWithZone:")]
    public virtual NSObject Copy(NSZone? zone)
    {
        NSObject nSObject = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));

        return nSObject;
    }

    protected override void Dispose(bool disposing)
    {
        Dispose(disposing);
        if (Handle == IntPtr.Zero)
            __mt_WebView_var = null;
    }
}
