using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKSecurityOrigin", true)]
public class WKSecurityOrigin : NSObject
{
    private const string selHost = "host";
    private static readonly IntPtr selHostHandle = Selector.GetHandle("host");

    private const string selPort = "port";
    private static readonly IntPtr selPortHandle = Selector.GetHandle("port");

    private const string selProtocol = "protocol";
    private static readonly IntPtr selProtocolHandle = Selector.GetHandle("protocol");

    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKSecurityOrigin");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKSecurityOrigin(NSObjectFlag t)
    : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKSecurityOrigin(IntPtr handle)
        : base(handle)
    {
    }

    public virtual string Host
    {
        [Export("host")]
        get
        {
            if (IsDirectBinding)
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selHostHandle));

            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selHostHandle));
        }
    }

    public virtual long Port
    {
        [Export("port")]
        get
        {
            if (IsDirectBinding)
                return Messaging.long_objc_msgSend(Handle, selPortHandle);

            return Messaging.long_objc_msgSendSuper(SuperHandle, selPortHandle);
        }
    }

    public virtual string Protocol
    {
        [Export("protocol")]
        get
        {
            if (IsDirectBinding)
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selProtocolHandle));

            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selProtocolHandle));
        }
    }
}