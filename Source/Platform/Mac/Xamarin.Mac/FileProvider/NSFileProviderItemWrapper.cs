using Foundation;
using ObjCRuntime;

namespace FileProvider;

internal sealed class NSFileProviderItemWrapper : BaseWrapper, INSFileProviderItem, INativeObject, IDisposable
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public string Identifier
    {
        [Export("itemIdentifier")]
        get
        {
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("itemIdentifier")));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public string ParentIdentifier
    {
        [Export("parentItemIdentifier")]
        get
        {
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("parentItemIdentifier")));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public string Filename
    {
        [Export("filename")]
        get
        {
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("filename")));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public string TypeIdentifier
    {
        [Export("typeIdentifier")]
        get
        {
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("typeIdentifier")));
        }
    }

    [Preserve(Conditional = true)]
    public NSFileProviderItemWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }
}
