using ObjCRuntime;
using System;
using System.Runtime.InteropServices;

namespace Builder;

public class SelectorMarshaler : ICustomMarshaler
{
    private static SelectorMarshaler marshaler;

    public object MarshalNativeToManaged(IntPtr handle)
    {
        return new Selector(handle);
    }

    public IntPtr MarshalManagedToNative(object obj)
    {
        if (obj == null)
        {
            return IntPtr.Zero;
        }
        if (!(obj is Selector))
        {
            throw new MarshalDirectiveException("This custom marshaler must be used on a Selector derived type.");
        }
        return (obj as Selector).Handle;
    }

    public void CleanUpNativeData(IntPtr handle)
    {
    }

    public void CleanUpManagedData(object obj)
    {
    }

    public int GetNativeDataSize()
    {
        return -1;
    }

    public static ICustomMarshaler GetInstance(string cookie)
    {
        if (marshaler == null)
        {
            return marshaler = new SelectorMarshaler();
        }
        return marshaler;
    }
}
