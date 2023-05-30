using Xamarin.Utiles;

namespace ObjCRuntime;
public static class NativeObjectExtensions
{
    public static NativeHandle GetHandle(this INativeObject? self)
    {
        return self?.Handle ?? NativeHandle.Zero;
    }

    public static NativeHandle GetNonNullHandle(this INativeObject self, string argumentName)
    {
        if (self == null)
        {
            ThrowHelper.ThrowArgumentNullException(argumentName);
        }
        if (self.Handle == NativeHandle.Zero)
        {
            ThrowHelper.ThrowObjectDisposedException(self);
        }
        return self.Handle;
    }
}
