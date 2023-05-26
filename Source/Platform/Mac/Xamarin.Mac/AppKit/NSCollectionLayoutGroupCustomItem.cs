using CoreGraphics;
using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace AppKit;

[Register("NSCollectionLayoutGroupCustomItem", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutGroupCustomItem : NSObject, INSCopying, INativeObject, IDisposable
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCopyWithZone_ = "copyWithZone:";

    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCustomItemWithFrame_ = "customItemWithFrame:";

    private static readonly IntPtr selCustomItemWithFrame_Handle = Selector.GetHandle("customItemWithFrame:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCustomItemWithFrame_ZIndex_ = "customItemWithFrame:zIndex:";

    private static readonly IntPtr selCustomItemWithFrame_ZIndex_Handle = Selector.GetHandle("customItemWithFrame:zIndex:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selFrame = "frame";

    private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selZIndex = "zIndex";

    private static readonly IntPtr selZIndexHandle = Selector.GetHandle("zIndex");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutGroupCustomItem");

    public override IntPtr ClassHandle => class_ptr;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual CGRect Frame
    {
        [Export("frame")]
        get
        {
            NSApplication.EnsureUIThread();
            CGRect retval;
            if (base.IsDirectBinding)
            {
                Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFrameHandle);
            }
            else
            {
                Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameHandle);
            }
            return retval;
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual nint ZIndex
    {
        [Export("zIndex")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selZIndexHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selZIndexHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected NSCollectionLayoutGroupCustomItem(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal NSCollectionLayoutGroupCustomItem(IntPtr handle)
        : base(handle)
    {
    }

    [Export("copyWithZone:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [return: Release]
    public virtual NSObject Copy(NSZone? zone)
    {
        NSApplication.EnsureUIThread();
        NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
        {
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
        }
        return nSObject;
    }

    [Export("customItemWithFrame:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSCollectionLayoutGroupCustomItem Create(CGRect frame)
    {
        NSApplication.EnsureUIThread();
        return Runtime.GetNSObject<NSCollectionLayoutGroupCustomItem>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selCustomItemWithFrame_Handle, frame));
    }

    [Export("customItemWithFrame:zIndex:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSCollectionLayoutGroupCustomItem Create(CGRect frame, nint zIndex)
    {
        NSApplication.EnsureUIThread();
        return Runtime.GetNSObject<NSCollectionLayoutGroupCustomItem>(Messaging.IntPtr_objc_msgSend_CGRect_nint(class_ptr, selCustomItemWithFrame_ZIndex_Handle, frame, zIndex));
    }
}
