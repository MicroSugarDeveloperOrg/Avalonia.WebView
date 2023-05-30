namespace ObjCRuntime;

public readonly struct NativeHandle : IEquatable<NativeHandle>
{
    private readonly IntPtr handle;

    public static NativeHandle Zero;

    public IntPtr Handle => handle;

    public NativeHandle(IntPtr handle)
    {
        this.handle = handle;
    }

    public static bool operator ==(NativeHandle left, IntPtr right)
    {
        return left.handle == right;
    }

    public static bool operator ==(NativeHandle left, NativeHandle right)
    {
        return left.handle == right.handle;
    }

    public static bool operator ==(IntPtr left, NativeHandle right)
    {
        return left == right.Handle;
    }

    public static bool operator !=(NativeHandle left, IntPtr right)
    {
        return left.handle != right;
    }

    public static bool operator !=(IntPtr left, NativeHandle right)
    {
        return left != right.Handle;
    }

    public static bool operator !=(NativeHandle left, NativeHandle right)
    {
        return left.handle != right.Handle;
    }

    public static implicit operator IntPtr(NativeHandle value)
    {
        return value.Handle;
    }

    public static implicit operator NativeHandle(IntPtr value)
    {
        return new NativeHandle(value);
    }

    public unsafe static explicit operator void*(NativeHandle value)
    {
        return (void*)(IntPtr)value;
    }

    public unsafe static explicit operator NativeHandle(void* value)
    {
        return new NativeHandle((nint)value);
    }

    public override bool Equals(object? o)
    {
        if (o is NativeHandle nativeHandle)
        {
            return nativeHandle.handle == handle;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return handle.GetHashCode();
    }

    public bool Equals(NativeHandle other)
    {
        return other.handle == handle;
    }

    public override string ToString()
    {
        return "0x" + handle.ToString("x");
    }
}
