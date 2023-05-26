using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCollectionLayoutEnvironmentWrapper : BaseWrapper, INSCollectionLayoutEnvironment, INativeObject, IDisposable
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public INSCollectionLayoutContainer Container
    {
        [Export("container")]
        get
        {
            NSApplication.EnsureUIThread();
            return Runtime.GetINativeObject<INSCollectionLayoutContainer>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("container")), owns: false);
        }
    }

    [Preserve(Conditional = true)]
    public NSCollectionLayoutEnvironmentWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }
}
