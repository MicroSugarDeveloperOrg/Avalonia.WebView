using Foundation;
using ObjCRuntime;
using System.ComponentModel;
using Xamarin.System;

namespace WebKit;

[Register("WKWindowFeatures", true)]
public class WKWindowFeatures : NSObject
{
    private const string selAllowsResizing = "allowsResizing";
    private static readonly IntPtr selAllowsResizingHandle = Selector.GetHandle("allowsResizing");

    private const string selHeight = "height";
    private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

    private const string selMenuBarVisibility = "menuBarVisibility";
    private static readonly IntPtr selMenuBarVisibilityHandle = Selector.GetHandle("menuBarVisibility");

    private const string selStatusBarVisibility = "statusBarVisibility";
    private static readonly IntPtr selStatusBarVisibilityHandle = Selector.GetHandle("statusBarVisibility");

    private const string selToolbarsVisibility = "toolbarsVisibility";
    private static readonly IntPtr selToolbarsVisibilityHandle = Selector.GetHandle("toolbarsVisibility");

    private const string selWidth = "width";
    private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

    private const string selX = "x";
    private static readonly IntPtr selXHandle = Selector.GetHandle("x");

    private const string selY = "y";
    private static readonly IntPtr selYHandle = Selector.GetHandle("y");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKWindowFeatures");

    public bool? MenuBarVisibility => (menuBarVisibility == null) ? null : new bool?(menuBarVisibility.BoolValue);

    public bool? StatusBarVisibility => (statusBarVisibility == null) ? null : new bool?(statusBarVisibility.BoolValue);

    public bool? ToolbarsVisibility => (toolbarsVisibility == null) ? null : new bool?(toolbarsVisibility.BoolValue);

    public bool? AllowsResizing => (allowsResizing == null) ? null : new bool?(allowsResizing.BoolValue);

    public nfloat? X => NFloatValue(x);

    public nfloat? Y => NFloatValue(y);

    public nfloat? Width => NFloatValue(width);

    public nfloat? Height => NFloatValue(height);

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKWindowFeatures()
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKWindowFeatures(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKWindowFeatures(IntPtr handle)
        : base(handle)
    {
    }

    internal virtual NSNumber allowsResizing
    {
        [Export("allowsResizing")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSend(Handle, selAllowsResizingHandle));
            }
            return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selAllowsResizingHandle));
        }
    }

    internal virtual NSNumber height
    {
        [Export("height")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSend(Handle, selHeightHandle));
            }
            return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selHeightHandle));
        }
    }

    internal virtual NSNumber menuBarVisibility
    {
        [Export("menuBarVisibility")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSend(Handle, selMenuBarVisibilityHandle));
            }
            return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selMenuBarVisibilityHandle));
        }
    }

    internal virtual NSNumber statusBarVisibility
    {
        [Export("statusBarVisibility")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSend(Handle, selStatusBarVisibilityHandle));
            }
            return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selStatusBarVisibilityHandle));
        }
    }

    internal virtual NSNumber toolbarsVisibility
    {
        [Export("toolbarsVisibility")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSend(Handle, selToolbarsVisibilityHandle));
            }
            return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selToolbarsVisibilityHandle));
        }
    }

    internal virtual NSNumber width
    {
        [Export("width")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSend(Handle, selWidthHandle));
            }
            return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selWidthHandle));
        }
    }

    internal virtual NSNumber x
    {
        [Export("x")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSend(Handle, selXHandle));
            }
            return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selXHandle));
        }
    }

    internal virtual NSNumber y
    {
        [Export("y")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSend(Handle, selYHandle));
            }
            return Runtime.GetNSObjectTx<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selYHandle));
        }
    }

    private static nfloat? NFloatValue(NSNumber number)
    {
        if (number == null)
        {
            return null;
        }
        if (IntPtr.Size == 4)
        {
            return number.FloatValue;
        }
        return (nfloat)number.DoubleValue;
    }

    
}
