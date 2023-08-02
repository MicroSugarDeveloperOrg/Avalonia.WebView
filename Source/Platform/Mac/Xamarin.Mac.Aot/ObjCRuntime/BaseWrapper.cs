namespace ObjCRuntime;

public abstract class BaseWrapper : INativeObject, IDisposable
{
    public IntPtr Handle { get; protected set; }

    public BaseWrapper(IntPtr handle, bool owns)
    {
        Handle = handle;
        if (!owns)
        {
            Messaging.void_objc_msgSend(Handle, Selector.GetHandle("retain"));
        }
    }

    ~BaseWrapper()
    {
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (Handle != IntPtr.Zero)
        {
            Messaging.void_objc_msgSend(Handle, Selector.GetHandle("release"));
            Handle = IntPtr.Zero;
        }
    }
}