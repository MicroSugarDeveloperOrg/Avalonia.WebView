using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreFoundation;

internal class CFData : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public int Length => CFDataGetLength(handle);

	public IntPtr Bytes => CFDataGetBytePtr(handle);

	public CFData(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	public CFData(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CFData()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFDataGetTypeID")]
	public static extern int GetTypeID();

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	public static CFData FromDataNoCopy(IntPtr buffer, int length)
	{
		return new CFData(CFDataCreateWithBytesNoCopy(IntPtr.Zero, buffer, length, CFAllocator.null_ptr), owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFDataCreateWithBytesNoCopy(IntPtr allocator, IntPtr bytes, int len, IntPtr deallocator);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern CFIndex CFDataGetLength(IntPtr data);

	public byte[] GetBuffer()
	{
		byte[] array = new byte[Length];
		Marshal.Copy(CFDataGetBytePtr(handle), array, 0, array.Length);
		return array;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFDataGetBytePtr(IntPtr data);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFDataCreate(IntPtr allocator, IntPtr bytes, CFIndex len);

	public static CFData FromData(IntPtr buffer, int length)
	{
		return new CFData(CFDataCreate(IntPtr.Zero, buffer, length), owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFDataCreateCopy(IntPtr allocator, IntPtr data);

	public CFData Copy()
	{
		return new CFData(CFDataCreateCopy(IntPtr.Zero, Handle), owns: true);
	}
}
