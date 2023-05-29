using Foundation;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ObjCRuntime;
public class Protocol : INativeObject
{
    private IntPtr handle;

    public IntPtr Handle => handle;

    public string Name
    {
        get
        {
            IntPtr ptr = protocol_getName(handle);
            return Marshal.PtrToStringAuto(ptr);
        }
    }

    public Protocol(string name)
    {
        handle = objc_getProtocol(name);
        if (handle == IntPtr.Zero)
        {
            throw new ArgumentException($"'{name}' is an unknown protocol");
        }
    }


    public IntPtr GetProtocolForType(Type type)
    {
        if (type.IsInterface)
        {
            ProtocolAttribute customAttribute = type.GetCustomAttribute<ProtocolAttribute>(inherit: false);
            if (customAttribute != null)
            {
                IntPtr intPtr = Protocol.objc_getProtocol(customAttribute.Name);
                if (intPtr != IntPtr.Zero)
                {
                    return intPtr;
                }
            }
        }

        throw new ArgumentException($"'{type.FullName}' is an unknown protocol");
    }

    public Protocol(Type type)
    {
        handle = GetProtocolForType(type);
    }

    public Protocol(IntPtr handle)
    {
        this.handle = handle;
    }

    [Preserve(Conditional = true)]
    internal Protocol(IntPtr handle, bool owns)
    {
        this.handle = handle;
    }

    public static IntPtr GetHandle(string name)
    {
        return objc_getProtocol(name);
    }

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern IntPtr objc_getProtocol(string name);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern IntPtr objc_allocateProtocol(string name);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern void objc_registerProtocol(IntPtr protocol);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern void protocol_addProperty(IntPtr protocol, string name, Class.objc_attribute_prop[] attributes, int count, bool isRequired, bool isInstance);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern void protocol_addMethodDescription(IntPtr protocol, IntPtr nameSelector, string signature, bool isRequired, bool isInstance);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern void protocol_addProtocol(IntPtr protocol, IntPtr addition);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern IntPtr protocol_getName(IntPtr protocol);
}