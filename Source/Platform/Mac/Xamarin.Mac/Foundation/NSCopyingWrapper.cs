using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation;
internal sealed class NSCopyingWrapper : BaseWrapper, INSCopying, INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    public NSCopyingWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }

    [Export("copyWithZone:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [return: Release]
    public NSObject Copy(NSZone? zone)
    {
        NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("copyWithZone:"), zone?.Handle ?? IntPtr.Zero));
        if (nSObject != null)
        {
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
        }
        return nSObject;
    }
}