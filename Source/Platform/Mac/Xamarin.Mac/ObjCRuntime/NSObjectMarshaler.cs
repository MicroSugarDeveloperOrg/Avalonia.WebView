using Foundation;
using System.Runtime.InteropServices;

namespace ObjCRuntime;
public class NSObjectMarshaler<T> : ICustomMarshaler where T : NSObject
{
    private static NSObjectMarshaler<T> marshaler;

    public object MarshalNativeToManaged(IntPtr handle) => (object)(T)Runtime.GetNSObjectEx(handle);

    public IntPtr MarshalManagedToNative(object obj)
    {
        if (obj == null)
            return IntPtr.Zero;
        return obj is T ? (obj as T).Handle : throw new MarshalDirectiveException("This custom marshaler must be used on a NSObject derived type.");
    }

    public void CleanUpNativeData(IntPtr handle)
    {
    }

    public void CleanUpManagedData(object obj)
    {
    }

    public int GetNativeDataSize() => -1;

    public static ICustomMarshaler GetInstance(string cookie) => NSObjectMarshaler<T>.marshaler == null ? (ICustomMarshaler)(NSObjectMarshaler<T>.marshaler = new NSObjectMarshaler<T>()) : (ICustomMarshaler)NSObjectMarshaler<T>.marshaler;
}