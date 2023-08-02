using ObjCRuntime;

namespace CoreFoundation;
public abstract class NativeObject : DisposableObject
{
    protected NativeObject()
    {
    }

    protected NativeObject(IntPtr handle, bool owns)
        : this(handle, owns, verify: true)
    {
    }

    protected NativeObject(IntPtr handle, bool owns, bool verify)
        : base(handle, owns, verify)
    {
        if (!owns && handle != IntPtr.Zero)
        {
            Retain();
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (base.Handle != IntPtr.Zero)
        {
            Release();
        }
        base.Dispose(disposing);
    }

    protected internal virtual void Retain()
    {
        CFObject.CFRetain(GetCheckedHandle());
    }

    protected internal virtual void Release()
    {
        CFObject.CFRelease(GetCheckedHandle());
    }
}