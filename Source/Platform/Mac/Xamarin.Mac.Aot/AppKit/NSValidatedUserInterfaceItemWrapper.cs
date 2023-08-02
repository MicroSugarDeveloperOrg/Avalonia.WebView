using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSValidatedUserInterfaceItemWrapper : BaseWrapper, INSValidatedUserInterfaceItem, INativeObject, IDisposable
{
    public Selector? Action
    {
        [Export("action")]
        get
        {
            NSApplication.EnsureUIThread();
            return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("action")));
        }
    }

    public long Tag
    {
        [Export("tag")]
        get
        {
            NSApplication.EnsureUIThread();
            return Messaging.long_objc_msgSend(base.Handle, Selector.GetHandle("tag"));
        }
    }

    [Preserve(Conditional = true)]
    public NSValidatedUserInterfaceItemWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }
}
