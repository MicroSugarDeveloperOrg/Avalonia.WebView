using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

internal class CFArray : INativeObject, IDisposable
{
	internal IntPtr handle;

	private static readonly IntPtr kCFTypeArrayCallbacks_ptr;

	public IntPtr Handle => handle;

	public int Count => CFArrayGetCount(handle);

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
	public static extern int GetTypeID();

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

	static CFArray()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			kCFTypeArrayCallbacks_ptr = Dlfcn.GetIndirect(intPtr, "kCFTypeArrayCallBacks");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
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
	private static extern IntPtr CFArrayCreate(IntPtr allocator, IntPtr values, CFIndex numValues, IntPtr callbacks);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFArrayGetValueAtIndex(IntPtr theArray, IntPtr index);

	public IntPtr GetValue(int index)
	{
		return CFArrayGetValueAtIndex(handle, new IntPtr(index));
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
	private static extern CFIndex CFArrayGetCount(IntPtr theArray);

	public static int GetCount(IntPtr array)
	{
		return CFArrayGetCount(array);
	}
}
