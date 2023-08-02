using ObjCRuntime;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Builder;
public class InterfaceMarshaler<IInterface, IInterfaceWrapper> : ICustomMarshaler where IInterfaceWrapper : IInterface
{
    private static InterfaceMarshaler<IInterface, IInterfaceWrapper> marshaler;

    void ICustomMarshaler.CleanUpManagedData(object ManagedObj)
    {
    }

    void ICustomMarshaler.CleanUpNativeData(IntPtr pNativeData)
    {
    }

    int ICustomMarshaler.GetNativeDataSize()
    {
        return -1;
    }

    IntPtr ICustomMarshaler.MarshalManagedToNative(object ManagedObj)
    {
        if (ManagedObj is null)
            return IntPtr.Zero;

        if (ManagedObj is not INativeObject nativeObject)
            throw new MarshalDirectiveException("This custom marshaler must be used on a INativeObject derived type.");

        return nativeObject.Handle;
    }

    object ICustomMarshaler.MarshalNativeToManaged(IntPtr pNativeData)
    {
        var constructorInfo = typeof(IInterfaceWrapper).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(IntPtr) }, null);
        return constructorInfo?.Invoke(new object[] { pNativeData }) ?? default;
    }

    public static ICustomMarshaler GetInstance(string cookie)
    {
        if (marshaler == null)
            return marshaler = new InterfaceMarshaler<IInterface, IInterfaceWrapper> ();

        return marshaler;
    }
}
