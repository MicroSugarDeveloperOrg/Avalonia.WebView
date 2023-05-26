using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

internal class CFArray : INativeObject, IDisposable
{
    internal IntPtr handle;

    private static IntPtr kCFTypeArrayCallbacks_ptr_value;

    public IntPtr Handle => handle;

    private static IntPtr kCFTypeArrayCallbacks_ptr
    {
        get
        {
            if (kCFTypeArrayCallbacks_ptr_value == IntPtr.Zero)
            {
                kCFTypeArrayCallbacks_ptr_value = Dlfcn.GetIndirect(Libraries.CoreFoundation.Handle, "kCFTypeArrayCallBacks");
            }
            return kCFTypeArrayCallbacks_ptr_value;
        }
    }

    public nint Count => CFArrayGetCount(handle);

    internal CFArray(IntPtr handle)
        : this(handle, owns: false)
    {
    }

    [Preserve(Conditional = true)]
    internal CFArray(IntPtr handle, bool owns)
    {
        if (handle == IntPtr.Zero)
        {
            throw new ArgumentNullException("handle");
        }
        this.handle = handle;
        if (!owns)
        {
            CFObject.CFRetain(handle);
        }
    }

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFArrayGetTypeID")]
    public static extern nint GetTypeID();

    ~CFArray()
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
        if (handle != IntPtr.Zero)
        {
            CFObject.CFRelease(handle);
            handle = IntPtr.Zero;
        }
    }

    public static CFArray FromIntPtrs(params IntPtr[] values)
    {
        return new CFArray(Create(values), owns: true);
    }

    public static CFArray FromNativeObjects(params INativeObject[] values)
    {
        return new CFArray(Create(values), owns: true);
    }

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
    private static extern IntPtr CFArrayCreate(IntPtr allocator, IntPtr values, nint numValues, IntPtr callBacks);

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
    internal static extern IntPtr CFArrayGetValueAtIndex(IntPtr theArray, nint idx);

    public IntPtr GetValue(nint index)
    {
        return CFArrayGetValueAtIndex(handle, index);
    }

    public unsafe static IntPtr Create(params IntPtr[] values)
    {
        if (values == null)
        {
            throw new ArgumentNullException("values");
        }
        fixed (IntPtr* ptr = values)
        {
            return CFArrayCreate(IntPtr.Zero, (IntPtr)ptr, values.Length, kCFTypeArrayCallbacks_ptr);
        }
    }

    public static IntPtr Create(params INativeObject[] values)
    {
        if (values == null)
        {
            throw new ArgumentNullException("values");
        }
        IntPtr[] array = new IntPtr[values.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = values[i].Handle;
        }
        return Create(array);
    }

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
    private static extern nint CFArrayGetCount(IntPtr theArray);

    public static nint GetCount(IntPtr array)
    {
        return CFArrayGetCount(array);
    }

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
    private static extern IntPtr CFArrayCreateCopy(IntPtr allocator, IntPtr theArray);

    public CFArray Clone()
    {
        return new CFArray(CFArrayCreateCopy(IntPtr.Zero, Handle), owns: true);
    }
}
