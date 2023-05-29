using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreFoundation;

public class CFAllocator : INativeObject, IDisposable
{
	private static CFAllocator Default_cf;

	private static CFAllocator SystemDefault_cf;

	private static CFAllocator Malloc_cf;

	private static CFAllocator MallocZone_cf;

	private static CFAllocator Null_cf;

	private static readonly IntPtr default_ptr;

	private static readonly IntPtr system_default_ptr;

	private static readonly IntPtr malloc_ptr;

	private static readonly IntPtr malloc_zone_ptr;

	internal static readonly IntPtr null_ptr;

	private IntPtr handle;

	public IntPtr Handle => handle;

	public static CFAllocator Default => Default_cf ?? (Default_cf = new CFAllocator(default_ptr));

	public static CFAllocator SystemDefault => SystemDefault_cf ?? (SystemDefault_cf = new CFAllocator(system_default_ptr));

	public static CFAllocator Malloc => Malloc_cf ?? (Malloc_cf = new CFAllocator(malloc_ptr));

	public static CFAllocator MallocZone => MallocZone_cf ?? (MallocZone_cf = new CFAllocator(malloc_zone_ptr));

	public static CFAllocator Null => Null_cf ?? (Null_cf = new CFAllocator(null_ptr));

	static CFAllocator()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", 0);
		try
		{
			default_ptr = Dlfcn.GetIntPtr(intPtr, "kCFAllocatorDefault");
			system_default_ptr = Dlfcn.GetIntPtr(intPtr, "kCFAllocatorSystemDefault");
			malloc_ptr = Dlfcn.GetIntPtr(intPtr, "kCFAllocatorMalloc");
			malloc_zone_ptr = Dlfcn.GetIntPtr(intPtr, "kCFAllocatorMallocZone");
			null_ptr = Dlfcn.GetIntPtr(intPtr, "kCFAllocatorNull");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	public CFAllocator(IntPtr handle)
	{
		this.handle = handle;
	}

	public CFAllocator(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CFAllocator()
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

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFAllocatorAllocate(IntPtr allocator, long size, CFAllocatorFlags hint);

	public IntPtr Allocate(long size, CFAllocatorFlags hint = (CFAllocatorFlags)0uL)
	{
		return CFAllocatorAllocate(handle, size, hint);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFAllocatorDeallocate(IntPtr allocator, IntPtr ptr);

	public void Deallocate(IntPtr ptr)
	{
		CFAllocatorDeallocate(handle, ptr);
	}
}
