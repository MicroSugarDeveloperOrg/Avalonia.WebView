using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKProcessPool", true)]
public class WKProcessPool : NSObject
{
    private const string selEncodeWithCoder_ = "encodeWithCoder:";
    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle(selEncodeWithCoder_);

    private const string selInitWithCoder_ = "initWithCoder:";
    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle(selInitWithCoder_);

    private static readonly IntPtr class_ptr = Class.GetHandle("WKProcessPool");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKProcessPool()
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export(selInitWithCoder_)]
    public WKProcessPool(NSCoder coder)
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.InitWithCoder, coder);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKProcessPool(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKProcessPool(IntPtr handle)
        : base(handle)
    {
    }
}
