using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreFoundation;

public class CFAllocator : INativeObject, IDisposable
{
	private static CFAllocator Default_cf;

	private static CFAllocator SystemDefault_cf;

	private static CFAllocator Malloc_cf;

	private static CFAllocator MallocZone_cf;

	private static CFAllocator Null_cf;

	private IntPtr handle;

	public IntPtr Handle => handle;

	public static CFAllocator Default => Default_cf ?? (Default_cf = new CFAllocator(default_ptr));

	public static CFAllocator SystemDefault => SystemDefault_cf ?? (SystemDefault_cf = new CFAllocator(system_default_ptr));

	public static CFAllocator Malloc => Malloc_cf ?? (Malloc_cf = new CFAllocator(malloc_ptr));

	public static CFAllocator MallocZone => MallocZone_cf ?? (MallocZone_cf = new CFAllocator(malloc_zone_ptr));

	public static CFAllocator Null => Null_cf ?? (Null_cf = new CFAllocator(null_ptr));

	[Field("kCFAllocatorDefault", "CoreFoundation")]
	internal static IntPtr default_ptr => Dlfcn.GetIntPtr(Libraries.CoreFoundation.Handle, "kCFAllocatorDefault");

	[Field("kCFAllocatorMalloc", "CoreFoundation")]
	internal static IntPtr malloc_ptr => Dlfcn.GetIntPtr(Libraries.CoreFoundation.Handle, "kCFAllocatorMalloc");

	[Field("kCFAllocatorMallocZone", "CoreFoundation")]
	internal static IntPtr malloc_zone_ptr => Dlfcn.GetIntPtr(Libraries.CoreFoundation.Handle, "kCFAllocatorMallocZone");

	[Field("kCFAllocatorNull", "CoreFoundation")]
	internal static IntPtr null_ptr => Dlfcn.GetIntPtr(Libraries.CoreFoundation.Handle, "kCFAllocatorNull");

	[Field("kCFAllocatorSystemDefault", "CoreFoundation")]
	internal static IntPtr system_default_ptr => Dlfcn.GetIntPtr(Libraries.CoreFoundation.Handle, "kCFAllocatorSystemDefault");

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
	private static extern IntPtr CFAllocatorAllocate(IntPtr allocator, nint size, nuint hint);

	public IntPtr Allocate(long size)
	{
		return CFAllocatorAllocate(handle, (nint)size, (byte)0);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFAllocatorDeallocate(IntPtr allocator, IntPtr ptr);

	public void Deallocate(IntPtr ptr)
	{
		CFAllocatorDeallocate(handle, ptr);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFAllocatorGetTypeID")]
	public static extern nint GetTypeID();
}
