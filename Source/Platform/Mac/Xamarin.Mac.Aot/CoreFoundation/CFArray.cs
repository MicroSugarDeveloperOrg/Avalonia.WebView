using Foundation;
using ObjCRuntime;
using System.Runtime.InteropServices;
using Xamarin.Utiles;

namespace CoreFoundation;

internal class CFArray : NativeObject
{
    [Preserve(Conditional = true)]
    internal CFArray(IntPtr handle) 
        : base(handle, false)
    {
    }

    [Preserve(Conditional = true)]
    internal CFArray(NativeHandle handle, bool owns)
        : base(handle, owns)
    {
    }

    ~CFArray()
    {
        Dispose(disposing: false);
    }

    internal static IntPtr CFNullHandle = _CFNullHandle;

    private static IntPtr kCFTypeArrayCallbacks_ptr_value;

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
      
    public IntPtr CountPtr => GetCountPtr(GetCheckedHandle());

    public int Count => GetCount(GetCheckedHandle());

    [Field("kCFNull", "CoreFoundation")]
    internal static IntPtr _CFNullHandle => Dlfcn.GetIntPtr(Libraries.CoreFoundation.Handle, "kCFNull");

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFArrayGetTypeID")]
    internal static extern IntPtr GetTypeID();

    internal static CFArray FromIntPtrs(params IntPtr[] values)
    {
        return new CFArray(Create(values));
    }

    internal static CFArray FromNativeObjects(params INativeObject[] values)
    {
        return new CFArray(Create(values));
    }

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
    private static extern IntPtr CFArrayCreate(IntPtr allocator, IntPtr values, IntPtr numValues, IntPtr callBacks);

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
    internal static extern IntPtr CFArrayGetValueAtIndex(IntPtr theArray, IntPtr idx);

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
    internal static extern IntPtr CFArrayGetValueAtIndex(IntPtr theArray, int idx);

    public IntPtr GetValue(IntPtr index)
    {
        return CFArrayGetValueAtIndex(GetCheckedHandle(), index);
    }

    public IntPtr GetValue(int index)
    {
        return CFArrayGetValueAtIndex(GetCheckedHandle(), index);
    }

    internal unsafe static IntPtr Create(params IntPtr[] values)
    {
        if (values == null)
        {
            ThrowHelper.ThrowArgumentNullException("values");
        }
        fixed (IntPtr* values2 = values)
        {
            return CFArrayCreate(IntPtr.Zero, (nint)values2, (IntPtr)values.Length, kCFTypeArrayCallbacks_ptr);
        }
    }

    public unsafe static IntPtr Create(params INativeObject[] values)
    {
        if (values == null)
        {
            ThrowHelper.ThrowArgumentNullException("values");
        }
        int num = values.Length;
        Span<IntPtr> span = ((num > 256) ? ((Span<IntPtr>)new IntPtr[num]) : stackalloc IntPtr[num]);
        Span<IntPtr> span2 = span;
        for (int i = 0; i < num; i++)
        {
            span2[i] = values[i].Handle;
        }
        fixed (IntPtr* values2 = span2)
        {
            return CFArrayCreate(IntPtr.Zero, (nint)values2, (IntPtr)num, kCFTypeArrayCallbacks_ptr);
        }
    }

    public unsafe static IntPtr Create(params string[] values)
    {
        if (values == null)
        {
            ThrowHelper.ThrowArgumentNullException("values");
        }
        int num = values.Length;
        Span<IntPtr> span = ((num > 256) ? ((Span<IntPtr>)new IntPtr[num]) : stackalloc IntPtr[num]);
        Span<IntPtr> span2 = span;
        for (int i = 0; i < num; i++)
        {
            span2[i] = ((values[i] == null) ? CFNullHandle : CFString.CreateNative(values[i]));
        }
        fixed (IntPtr* values2 = span2)
        {
            return CFArrayCreate(IntPtr.Zero, (nint)values2, (IntPtr)num, kCFTypeArrayCallbacks_ptr);
        }
    }

    public static CFArray FromStrings(params string[] items)
    {
        return new CFArray(Create(items));
    }

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFArrayGetCount")]
    internal static extern IntPtr GetCountPtr(IntPtr theArray);

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFArrayGetCount")]
    internal static extern int GetCount(IntPtr theArray);

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
    private static extern IntPtr CFArrayCreateCopy(IntPtr allocator, IntPtr theArray);

    [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
    internal static extern void CFArrayGetValues(IntPtr theArray, CFRange range, IntPtr values);

    internal CFArray Clone()
    {
        return new CFArray(CFArrayCreateCopy(IntPtr.Zero, GetCheckedHandle()));
    }



    public static string?[]? StringArrayFromHandle(IntPtr handle)
    {
        return ArrayFromHandleFunc(handle, CFString.FromHandle);
    }

    public static string?[]? StringArrayFromHandle(IntPtr handle, bool releaseHandle)
    {
        string?[]? result = StringArrayFromHandle(handle);
        if (releaseHandle && handle != IntPtr.Zero)
        {
            CFObject.CFRelease(handle);
        }
        return result;
    }

    public static T?[]? ArrayFromHandle<T>(IntPtr handle) where T : class, INativeObject
    {
        return ArrayFromHandleFunc(handle, DefaultConvert<T>);
    }

    public static T?[]? ArrayFromHandle<T>(IntPtr handle, bool releaseHandle) where T : class, INativeObject
    {
        T?[]? result = ArrayFromHandle<T>(handle);
        if (releaseHandle && handle != IntPtr.Zero)
        {
            CFObject.CFRelease(handle);
        }
        return result;
    }

    private static T DefaultConvert<T>(IntPtr handle) where T : class, INativeObject
    {
        if (handle != CFNullHandle)
        {
            return Runtime.GetNativeObject<T>(handle);
        }
        return null;
    }

    public unsafe static T[]? ArrayFromHandleFunc<T>(IntPtr handle, Func<IntPtr, T> createObject)
    {
        if (handle == IntPtr.Zero)
        {
            return null;
        }
        int num = (int)(nint)GetCount(handle);
        if (num == 0)
        {
            return Array.Empty<T>();
        }
        Span<IntPtr> span = ((num > 256) ? ((Span<IntPtr>)new IntPtr[num]) : stackalloc IntPtr[num]);
        Span<IntPtr> span2 = span;
        fixed (IntPtr* ptr = span2)
        {
            void* values = ptr;
            CFArrayGetValues(handle, new CFRange(0, num), (nint)values);
        }
        T[] array = new T[num];
        for (int i = 0; i < num; i++)
        {
            array[i] = createObject(span2[i]);
        }
        return array;
    }

    public static T[]? ArrayFromHandleFunc<T>(IntPtr handle, Func<IntPtr, T> createObject, bool releaseHandle)
    {
        T[]? result = ArrayFromHandleFunc(handle, createObject);
        if (releaseHandle && handle != IntPtr.Zero)
        {
            CFObject.CFRelease(handle);
        }
        return result;
    } 
}
