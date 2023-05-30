using Xamarin.Utiles;

namespace ObjCRuntime;
public abstract class DisposableObject : INativeObject, IDisposable
{
    private IntPtr handle;

    private readonly bool owns;

    public IntPtr Handle
    {
        get
        {
            return handle;
        }
        protected set
        {
            InitializeHandle(value);
        }
    }

    protected bool Owns => owns;

    protected DisposableObject()
    {
    }

    protected DisposableObject(IntPtr handle, bool owns)
        : this(handle, owns, verify: true)
    {
    }

    protected DisposableObject(IntPtr handle, bool owns, bool verify)
    {
        InitializeHandle(handle, verify);
        this.owns = owns;
    }

    ~DisposableObject()
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
        handle = IntPtr.Zero;
    }

    private void InitializeHandle(IntPtr handle, bool verify)
    {
        if (verify && handle == IntPtr.Zero && Class.ThrowOnInitFailure)
        {
            throw new Exception($"Could not initialize an instance of the type '{GetType().FullName}': handle is null.\n{"It is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false"}.");
        }
        this.handle = handle;
    }

    protected virtual void InitializeHandle(IntPtr handle)
    {
        InitializeHandle(handle, verify: true);
    }

    public IntPtr GetCheckedHandle()
    {
        IntPtr IntPtr = handle;
        if (IntPtr == IntPtr.Zero)
        {
            ThrowHelper.ThrowObjectDisposedException(this);
        }
        return IntPtr;
    }

    public override int GetHashCode()
    {
        return handle.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is DisposableObject disposableObject)
        {
            return handle.Equals(disposableObject.handle);
        }
        return false;
    }

    public static bool operator ==(DisposableObject? a, DisposableObject? b)
    {
        if ((object)a == null)
        {
            return (object)b == null;
        }
        if ((object)b == null)
        {
            return false;
        }
        return a.Handle == b.Handle;
    }

    public static bool operator !=(DisposableObject? a, DisposableObject? b)
    {
        if ((object)a == null)
        {
            return (object)b != null;
        }
        if ((object)b == null)
        {
            return true;
        }
        return a.Handle != b.Handle;
    }
}
