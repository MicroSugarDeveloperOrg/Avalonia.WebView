using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKUserScript", true)]
public class WKUserScript : NSObject
{
    private const string selCopyWithZone_ = "copyWithZone:";
    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    private const string selInitWithSource_InjectionTime_ForMainFrameOnly_ = "initWithSource:injectionTime:forMainFrameOnly:";
    private static readonly IntPtr selInitWithSource_InjectionTime_ForMainFrameOnly_Handle = Selector.GetHandle("initWithSource:injectionTime:forMainFrameOnly:");

    private const string selInjectionTime = "injectionTime";
    private static readonly IntPtr selInjectionTimeHandle = Selector.GetHandle("injectionTime");

    private const string selIsForMainFrameOnly = "isForMainFrameOnly";
    private static readonly IntPtr selIsForMainFrameOnlyHandle = Selector.GetHandle("isForMainFrameOnly");

    private const string selSource = "source";
    private static readonly IntPtr selSourceHandle = Selector.GetHandle("source");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKUserScript");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKUserScript(NSObjectFlag t)
    : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKUserScript(IntPtr handle)
        : base(handle)
    {
    }

    [Export("initWithSource:injectionTime:forMainFrameOnly:")]
    public WKUserScript(NSString source, WKUserScriptInjectionTime injectionTime, bool isForMainFrameOnly)
        : base(NSObjectFlag.Empty)
    {
        if (source == null)
            throw new ArgumentNullException("source");

        if (IsDirectBinding)
            InitializeWithHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_bool(Handle, selInitWithSource_InjectionTime_ForMainFrameOnly_Handle, source.Handle, (long)injectionTime, isForMainFrameOnly));
        else
            InitializeWithHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_bool(SuperHandle, selInitWithSource_InjectionTime_ForMainFrameOnly_Handle, source.Handle, (long)injectionTime, isForMainFrameOnly));
    }


    public virtual WKUserScriptInjectionTime InjectionTime
    {
        [Export("injectionTime")]
        get
        {
            if (IsDirectBinding)
                return (WKUserScriptInjectionTime)Messaging.Int64_objc_msgSend(Handle, selInjectionTimeHandle);

            return (WKUserScriptInjectionTime)Messaging.Int64_objc_msgSendSuper(SuperHandle, selInjectionTimeHandle);
        }
    }

    public virtual bool IsForMainFrameOnly
    {
        [Export("isForMainFrameOnly")]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selIsForMainFrameOnlyHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsForMainFrameOnlyHandle);
        }
    }

    public virtual NSString Source
    {
        [Export("source", ArgumentSemantic.Copy)]
        get
        {
            if (IsDirectBinding)
                return Runtime.GetNSObjectTx<NSString>(Messaging.IntPtr_objc_msgSend(Handle, selSourceHandle));

            return Runtime.GetNSObjectTx<NSString>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selSourceHandle));
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
}
