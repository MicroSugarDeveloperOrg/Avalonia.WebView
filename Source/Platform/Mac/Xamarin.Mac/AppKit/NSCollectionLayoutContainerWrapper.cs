using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCollectionLayoutContainerWrapper : BaseWrapper, INSCollectionLayoutContainer, INativeObject, IDisposable
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public CGSize ContentSize
    {
        [Export("contentSize")]
        get
        {
            NSApplication.EnsureUIThread();
            return Messaging.CGSize_objc_msgSend(base.Handle, Selector.GetHandle("contentSize"));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public CGSize EffectiveContentSize
    {
        [Export("effectiveContentSize")]
        get
        {
            NSApplication.EnsureUIThread();
            return Messaging.CGSize_objc_msgSend(base.Handle, Selector.GetHandle("effectiveContentSize"));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSDirectionalEdgeInsets ContentInsets
    {
        [Export("contentInsets")]
        get
        {
            NSApplication.EnsureUIThread();
            Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("contentInsets"));
            return retval;
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSDirectionalEdgeInsets EffectiveContentInsets
    {
        [Export("effectiveContentInsets")]
        get
        {
            NSApplication.EnsureUIThread();
            Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("effectiveContentInsets"));
            return retval;
        }
    }

    [Preserve(Conditional = true)]
    public NSCollectionLayoutContainerWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }
}
